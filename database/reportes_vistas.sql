-- ============================================================
-- GymControl - Módulo de reportes (Integrante B)
-- Motor objetivo: MariaDB 12.x / MySQL 8.x
-- Base de datos: gimnasio_db
--
-- Este script NO recrea la base ni modifica datos.
-- Crea/reemplaza las vistas de solo lectura con los nombres
-- exigidos por los requisitos:
--   vw_ingresos_detalle
--   vw_saldos_membresia
--   vw_estado_cuenta
--   vw_horario_semanal
-- y las vistas auxiliares necesarias para los filtros.
--
-- El bloque de usuario gym_reportes está al final y debe
-- ejecutarse como root después de reemplazar el marcador de
-- contraseña. No guardar la contraseña en el repositorio.
-- ============================================================

USE gimnasio_db;

-- ------------------------------------------------------------
-- AUXILIARES DE FILTROS
-- ------------------------------------------------------------

-- Catálogo completo de métodos permitidos. No se limita a los
-- métodos que ya tienen pagos, para que el combo siempre muestre
-- EFECTIVO, TARJETA y TRANSFERENCIA.
CREATE OR REPLACE SQL SECURITY DEFINER VIEW vw_metodos_pago AS
SELECT 'EFECTIVO' AS metodo_pago
UNION ALL
SELECT 'TARJETA'
UNION ALL
SELECT 'TRANSFERENCIA';

CREATE OR REPLACE SQL SECURITY DEFINER VIEW vw_salas AS
SELECT
    s.id_sala,
    s.nombre AS sala,
    CAST(s.capacidad AS SIGNED) AS capacidad,
    CAST(s.activo AS SIGNED) AS activo
FROM salas s;

CREATE OR REPLACE SQL SECURITY DEFINER VIEW vw_instructores AS
SELECT
    i.id_instructor,
    i.cedula,
    CONCAT(i.nombres, ' ', i.apellidos) AS instructor,
    i.especialidad,
    CAST(i.activo AS SIGNED) AS activo
FROM instructores i;

-- ------------------------------------------------------------
-- R04 - Ingresos por período
-- Una fila por pago. Incluye la fecha (sin hora) para agrupar
-- los subtotales por método y por fecha.
-- ------------------------------------------------------------
CREATE OR REPLACE SQL SECURITY DEFINER VIEW vw_ingresos_detalle AS
SELECT
    p.id_pago,
    p.fecha_pago,
    DATE(p.fecha_pago) AS fecha,
    DATE_FORMAT(p.fecha_pago, '%Y-%m') AS periodo,
    p.metodo_pago,
    p.referencia,
    p.observacion,
    CAST(p.anulado AS SIGNED) AS anulado,
    CASE WHEN p.anulado = 1 THEN 'ANULADO' ELSE 'VIGENTE' END AS estado_pago,
    p.monto,
    CASE WHEN p.anulado = 0 THEN p.monto ELSE 0.00 END AS monto_vigente,
    CASE WHEN p.anulado = 1 THEN p.monto ELSE 0.00 END AS monto_anulado,
    m.id_membresia,
    m.fecha_inicio,
    m.fecha_vencimiento,
    m.estado AS estado_membresia,
    tm.nombre AS tipo_membresia,
    s.id_socio,
    s.cedula,
    CONCAT(s.nombres, ' ', s.apellidos) AS socio,
    s.telefono,
    u.nombre_usuario AS registrado_por
FROM pagos p
INNER JOIN membresias m
    ON p.id_membresia = m.id_membresia
INNER JOIN tipos_membresia tm
    ON m.id_tipo = tm.id_tipo
INNER JOIN socios s
    ON m.id_socio = s.id_socio
LEFT JOIN usuarios u
    ON p.id_usuario_registro = u.id_usuario;

-- ------------------------------------------------------------
-- R05 - Saldos por membresía
-- Una fila por membresía. Los socios sin membresías también
-- aparecen una vez, con importes en cero, para que el combo de
-- socios y el resumen no los pierdan.
--
-- El saldo se calcula SIEMPRE igual:
--   precio_pactado - pagos vigentes
-- Los pagos anulados se informan aparte y NO reducen el saldo.
-- Se limita a cero para que "saldo pendiente" no sea negativo.
-- ------------------------------------------------------------
CREATE OR REPLACE SQL SECURITY DEFINER VIEW vw_saldos_membresia AS
SELECT
    s.id_socio,
    s.cedula,
    CONCAT(s.nombres, ' ', s.apellidos) AS socio,
    s.telefono,
    s.correo,
    CAST(s.activo AS SIGNED) AS socio_activo,
    m.id_membresia,
    tm.nombre AS tipo_membresia,
    m.fecha_inicio,
    m.fecha_vencimiento,
    m.estado AS estado_membresia,
    COALESCE(m.precio_pactado, 0.00) AS precio_pactado,
    COALESCE(t.total_pagado, 0.00) AS total_pagado_membresia,
    COALESCE(t.total_anulado, 0.00) AS total_anulado_membresia,
    GREATEST(
        COALESCE(m.precio_pactado, 0.00) - COALESCE(t.total_pagado, 0.00),
        0.00
    ) AS saldo_membresia
FROM socios s
LEFT JOIN membresias m
    ON m.id_socio = s.id_socio
LEFT JOIN tipos_membresia tm
    ON m.id_tipo = tm.id_tipo
LEFT JOIN (
    SELECT
        id_membresia,
        SUM(CASE WHEN anulado = 0 THEN monto ELSE 0.00 END) AS total_pagado,
        SUM(CASE WHEN anulado = 1 THEN monto ELSE 0.00 END) AS total_anulado
    FROM pagos
    GROUP BY id_membresia
) t
    ON t.id_membresia = m.id_membresia;

-- ------------------------------------------------------------
-- R05 - Estado de cuenta (detalle de pagos)
-- Una fila por membresía y pago. Las membresías sin pagos
-- aparecen con id_pago NULL para que el DAO pueda conservar la
-- cabecera de la membresía si se necesita.
--
-- El filtro FechaDesde se aplica en el DAO a la lista de pagos;
-- las membresías y el saldo se muestran completos para que el
-- estado de cuenta refleje el saldo real del socio.
-- ------------------------------------------------------------
CREATE OR REPLACE SQL SECURITY DEFINER VIEW vw_estado_cuenta AS
SELECT
    vs.id_socio,
    vs.cedula,
    vs.socio,
    vs.telefono,
    vs.correo,
    vs.socio_activo,
    vs.id_membresia,
    vs.tipo_membresia,
    vs.fecha_inicio,
    vs.fecha_vencimiento,
    vs.estado_membresia,
    vs.precio_pactado,
    vs.total_pagado_membresia,
    vs.total_anulado_membresia,
    vs.saldo_membresia,
    p.id_pago,
    p.fecha_pago,
    p.monto,
    p.metodo_pago,
    p.referencia,
    p.observacion,
    CAST(p.anulado AS SIGNED) AS anulado,
    CASE
        WHEN p.id_pago IS NULL THEN 'SIN PAGOS'
        WHEN p.anulado = 1 THEN 'ANULADO'
        ELSE 'VIGENTE'
    END AS estado_pago,
    u.nombre_usuario AS registrado_por
FROM vw_saldos_membresia vs
LEFT JOIN pagos p
    ON p.id_membresia = vs.id_membresia
LEFT JOIN usuarios u
    ON p.id_usuario_registro = u.id_usuario;

-- ------------------------------------------------------------
-- R06 - Horario semanal y ocupación estimada
-- Solo lunes a sábado (1 a 6).
-- La ocupación es ESTIMADA: cupo máximo de la actividad contra
-- capacidad de la sala. No existe tabla de asistencias, por lo
-- que no representa ocupación real de personas.
-- ------------------------------------------------------------
CREATE OR REPLACE SQL SECURITY DEFINER VIEW vw_horario_semanal AS
SELECT
    h.id_horario,
    CAST(h.dia_semana AS SIGNED) AS dia_semana,
    CASE h.dia_semana
        WHEN 1 THEN 'Lunes'
        WHEN 2 THEN 'Martes'
        WHEN 3 THEN 'Miércoles'
        WHEN 4 THEN 'Jueves'
        WHEN 5 THEN 'Viernes'
        WHEN 6 THEN 'Sábado'
        ELSE 'Sin día'
    END AS dia,
    DATE_FORMAT(h.hora_inicio, '%H:%i') AS hora_inicio,
    DATE_FORMAT(h.hora_fin, '%H:%i') AS hora_fin,
    ROUND(TIME_TO_SEC(TIMEDIFF(h.hora_fin, h.hora_inicio)) / 3600, 2) AS horas,
    a.id_actividad,
    a.nombre AS actividad,
    CAST(a.duracion_min AS SIGNED) AS duracion_min,
    CAST(a.cupo_maximo AS SIGNED) AS cupo_maximo,
    i.id_instructor,
    CONCAT(i.nombres, ' ', i.apellidos) AS instructor,
    i.especialidad,
    sa.id_sala,
    sa.nombre AS sala,
    CAST(sa.capacidad AS SIGNED) AS capacidad,
    CAST(h.activo AS SIGNED) AS activo,
    CASE WHEN h.activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS estado,
    ROUND(
        CASE
            WHEN sa.capacidad > 0 THEN (a.cupo_maximo / sa.capacidad) * 100
            ELSE 0
        END,
        1
    ) AS ocupacion_estimada_pct
FROM horarios h
INNER JOIN actividades a
    ON h.id_actividad = a.id_actividad
INNER JOIN instructores i
    ON h.id_instructor = i.id_instructor
INNER JOIN salas sa
    ON h.id_sala = sa.id_sala
WHERE h.dia_semana BETWEEN 1 AND 6;

-- ============================================================
-- USUARIO DE SOLO LECTURA
--
-- Ejecutar esta sección como root. Reemplace el marcador por una
-- contraseña fuerte en el momento de ejecutar; no la guarde en
-- Git. El código de la aplicación la lee de la variable de
-- entorno GYMCONTROL_REPORTES_PWD o de
-- %LOCALAPPDATA%\GymControl\reportes.pwd.
-- ============================================================

-- CREATE USER IF NOT EXISTS 'gym_reportes'@'localhost'
--     IDENTIFIED BY '__GYM_REPORTES_PASSWORD__';

-- ALTER USER 'gym_reportes'@'localhost'
--     IDENTIFIED BY '__GYM_REPORTES_PASSWORD__';

-- REVOKE ALL PRIVILEGES, GRANT OPTION FROM 'gym_reportes'@'localhost';

-- GRANT SELECT ON gimnasio_db.vw_ingresos_detalle TO 'gym_reportes'@'localhost';
-- GRANT SELECT ON gimnasio_db.vw_saldos_membresia TO 'gym_reportes'@'localhost';
-- GRANT SELECT ON gimnasio_db.vw_estado_cuenta TO 'gym_reportes'@'localhost';
-- GRANT SELECT ON gimnasio_db.vw_horario_semanal TO 'gym_reportes'@'localhost';
-- GRANT SELECT ON gimnasio_db.vw_metodos_pago TO 'gym_reportes'@'localhost';
-- GRANT SELECT ON gimnasio_db.vw_salas TO 'gym_reportes'@'localhost';
-- GRANT SELECT ON gimnasio_db.vw_instructores TO 'gym_reportes'@'localhost';

-- FLUSH PRIVILEGES;
