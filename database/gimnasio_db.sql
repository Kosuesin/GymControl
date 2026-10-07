-- ============================================================
-- Motor objetivo: MariaDB / MySQL
--   - Nombre de base de datos: gimnasio_db
--   - Motor: InnoDB
--   - Juego de caracteres: utf8mb4
--   - Intercalación: utf8mb4_spanish_ci
-- ============================================================

CREATE DATABASE IF NOT EXISTS gimnasio_db
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_spanish_ci;

USE gimnasio_db;

-- ------------------------------------------------------------
-- 1. TABLAS DEL MÓDULO DE SEGURIDAD Y USUARIOS
-- ------------------------------------------------------------

-- Tabla: roles
CREATE TABLE IF NOT EXISTS roles (
    id_rol INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(30) NOT NULL UNIQUE,
    descripcion VARCHAR(150) NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- Tabla: socios
CREATE TABLE IF NOT EXISTS socios (
    id_socio INT AUTO_INCREMENT PRIMARY KEY,
    cedula VARCHAR(16) NULL UNIQUE,
    nombres VARCHAR(60) NOT NULL,
    apellidos VARCHAR(60) NOT NULL,
    fecha_nacimiento DATE NULL,
    genero ENUM('F', 'M') NULL,
    telefono VARCHAR(15) NULL,
    correo VARCHAR(100) NULL,
    direccion VARCHAR(200) NULL,
    fecha_registro DATE NOT NULL DEFAULT (CURRENT_DATE),
    activo TINYINT(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- Tabla: instructores
CREATE TABLE IF NOT EXISTS instructores (
    id_instructor INT AUTO_INCREMENT PRIMARY KEY,
    cedula VARCHAR(16) NULL UNIQUE,
    nombres VARCHAR(60) NOT NULL,
    apellidos VARCHAR(60) NOT NULL,
    telefono VARCHAR(15) NULL,
    correo VARCHAR(100) NULL,
    especialidad VARCHAR(60) NULL,
    fecha_contratacion DATE NULL,
    activo TINYINT(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- Tabla: usuarios
CREATE TABLE IF NOT EXISTS usuarios (
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    nombre_usuario VARCHAR(40) NOT NULL UNIQUE,
    contrasena_hash VARCHAR(255) NOT NULL,
    sal VARCHAR(64) NOT NULL,
    id_rol INT NOT NULL,
    id_socio INT NULL UNIQUE,
    id_instructor INT NULL UNIQUE,
    intentos_fallidos TINYINT NOT NULL DEFAULT 0,
    activo TINYINT(1) NOT NULL DEFAULT 1,
    ultimo_acceso DATETIME NULL,
    CONSTRAINT fk_usuarios_roles FOREIGN KEY (id_rol) REFERENCES roles(id_rol),
    CONSTRAINT fk_usuarios_socios FOREIGN KEY (id_socio) REFERENCES socios(id_socio),
    CONSTRAINT fk_usuarios_instructores FOREIGN KEY (id_instructor) REFERENCES instructores(id_instructor)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- Tabla: bitacora_accesos
CREATE TABLE IF NOT EXISTS bitacora_accesos (
    id_bitacora INT AUTO_INCREMENT PRIMARY KEY,
    id_usuario INT NULL,
    usuario_intento VARCHAR(40) NOT NULL,
    fecha_hora DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    resultado ENUM('EXITO', 'FALLIDO', 'BLOQUEADO') NOT NULL,
    equipo VARCHAR(60) NULL,
    CONSTRAINT fk_bitacora_usuarios FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- ------------------------------------------------------------
-- 2. TABLAS DEL MODULO DE MEMBRESIAS Y PAGOS
-- ------------------------------------------------------------

-- Tabla: tipos_membresia
CREATE TABLE IF NOT EXISTS tipos_membresia (
    id_tipo INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(40) NOT NULL UNIQUE,
    descripcion VARCHAR(200) NULL,
    duracion_dias SMALLINT NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    incluye_clases TINYINT(1) NOT NULL DEFAULT 1,
    activo TINYINT(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- Tabla: membresias
CREATE TABLE IF NOT EXISTS membresias (
    id_membresia INT AUTO_INCREMENT PRIMARY KEY,
    id_socio INT NOT NULL,
    id_tipo INT NOT NULL,
    fecha_inicio DATE NOT NULL,
    fecha_vencimiento DATE NOT NULL,
    precio_pactado DECIMAL(10,2) NOT NULL,
    estado ENUM('ACTIVA', 'SUSPENDIDA', 'VENCIDA', 'CANCELADA') NOT NULL DEFAULT 'ACTIVA',
    CONSTRAINT fk_membresias_socios FOREIGN KEY (id_socio) REFERENCES socios(id_socio),
    CONSTRAINT fk_membresias_tipos FOREIGN KEY (id_tipo) REFERENCES tipos_membresia(id_tipo)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- Tabla: pagos
CREATE TABLE IF NOT EXISTS pagos (
    id_pago INT AUTO_INCREMENT PRIMARY KEY,
    id_membresia INT NOT NULL,
    id_usuario_registro INT NOT NULL,
    fecha_pago DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    monto DECIMAL(10,2) NOT NULL,
    metodo_pago ENUM('EFECTIVO', 'TARJETA', 'TRANSFERENCIA') NOT NULL,
    referencia VARCHAR(50) NULL,
    observacion VARCHAR(200) NULL,
    anulado TINYINT(1) NOT NULL DEFAULT 0,
    CONSTRAINT fk_pagos_membresias FOREIGN KEY (id_membresia) REFERENCES membresias(id_membresia),
    CONSTRAINT fk_pagos_usuarios FOREIGN KEY (id_usuario_registro) REFERENCES usuarios(id_usuario)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- ------------------------------------------------------------
-- 3. TABLAS DEL MODULO DE HORARIOS Y ACTIVIDADES
-- ------------------------------------------------------------

-- Tabla: salas
CREATE TABLE IF NOT EXISTS salas (
    id_sala INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(40) NOT NULL UNIQUE,
    capacidad SMALLINT NOT NULL,
    activo TINYINT(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- Tabla: actividades
CREATE TABLE IF NOT EXISTS actividades (
    id_actividad INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL UNIQUE,
    descripcion VARCHAR(200) NULL,
    duracion_min SMALLINT NOT NULL,
    cupo_maximo SMALLINT NOT NULL,
    activo TINYINT(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- Tabla: horarios
CREATE TABLE IF NOT EXISTS horarios (
    id_horario INT AUTO_INCREMENT PRIMARY KEY,
    id_instructor INT NOT NULL,
    id_actividad INT NOT NULL,
    id_sala INT NOT NULL,
    dia_semana TINYINT NOT NULL COMMENT '1=Lunes, 2=Martes, ..., 7=Domingo',
    hora_inicio TIME NOT NULL,
    hora_fin TIME NOT NULL,
    activo TINYINT(1) NOT NULL DEFAULT 1,
    CONSTRAINT fk_horarios_instructores FOREIGN KEY (id_instructor) REFERENCES instructores(id_instructor),
    CONSTRAINT fk_horarios_actividades FOREIGN KEY (id_actividad) REFERENCES actividades(id_actividad),
    CONSTRAINT fk_horarios_salas FOREIGN KEY (id_sala) REFERENCES salas(id_sala)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- ------------------------------------------------------------
-- 0. INSERT DE DATOS FIJOS (ROLES DEL SISTEMA)
-- ------------------------------------------------------------

INSERT INTO roles (nombre, descripcion) VALUES
('Administrador', 'Acceso total al sistema y configuraciones'),
('Recepcionista', 'Gestion de socios, membresias, pagos y asistencia'),
('Instructor', 'Consulta de horarios y actividades asignadas'),
('Socio', 'Acceso al portal personal para ver estado de membresia');

-- ------------------------------------------------------------
-- 1. INSERT EN SOCIOS
-- ------------------------------------------------------------
INSERT INTO socios (cedula, nombres, apellidos, fecha_nacimiento, genero, telefono, correo, direccion, fecha_registro, activo) VALUES
('001-150398-0001A', 'Carlos Eduardo', 'Mendoza Ruiz', '1998-03-15', 'M', '88123456', 'carlos.mendoza@email.com', 'Reparto San Antonio, Casa #45', '2024-01-10', 1),
('001-220795-0002B', 'Ana Lucia', 'Gomez Estrada', '1995-07-22', 'F', '87654321', 'ana.gomez@email.com', 'Colonia Centroamerica, Modulo C-12', '2024-02-01', 1),
('001-101100-0003C', 'Roberto Jose', 'Torres Blandon', '2000-11-10', 'M', '89551122', 'roberto.torres@email.com', 'Barrio Altamira, Calle Principal #102', '2024-02-15', 1),
('001-050402-0004D', 'Maria Fernanda', 'Lopez Silva', '2002-04-05', 'F', '84332211', 'maria.lopez@email.com', 'Residencial Las Colinas, Etapa 2 #8', '2024-03-01', 1);

-- ------------------------------------------------------------
-- 2. INSERT EN INSTRUCTORES
-- ------------------------------------------------------------
INSERT INTO instructores (cedula, nombres, apellidos, telefono, correo, especialidad, fecha_contratacion, activo) VALUES
('001-120588-0005E', 'Javier Alexander', 'Rios Gutierrez', '88776655', 'javier.rios@gymcontrol.com', 'Musculacion y Hipertrofia', '2023-05-15', 1),
('001-300992-0006F', 'Sofia Beatrix', 'Morales Solis', '83445566', 'sofia.morales@gymcontrol.com', 'Spinning y Cardio Cross', '2023-08-01', 1);

-- ------------------------------------------------------------
-- 3. INSERT EN USUARIOS (Sin contraseñas para generar desde VB.NET)
-- ------------------------------------------------------------
-- Nota: La columna contrasena_hash y sal se dejan con valores temporales ficticios
-- para cumplir con la restriccion NOT NULL de la tabla.
INSERT INTO usuarios (nombre_usuario, contrasena_hash, sal, id_rol, id_socio, id_instructor, intentos_fallidos, activo) VALUES
('admin', 'HASH_PENDIENTE', 'SAL_PENDIENTE', 1, NULL, NULL, 0, 1),
('recepcion01', 'HASH_PENDIENTE', 'SAL_PENDIENTE', 2, NULL, NULL, 0, 1),
('inst_javier', 'HASH_PENDIENTE', 'SAL_PENDIENTE', 3, NULL, 1, 0, 1),
('socio_carlos', 'HASH_PENDIENTE', 'SAL_PENDIENTE', 4, 1, NULL, 0, 1),
('usuario_bloqueado', 'HASH_PENDIENTE', 'SAL_PENDIENTE', 2, NULL, NULL, 3, 0);

-- ------------------------------------------------------------
-- 4. INSERT EN TIPOS DE MEMBRESIA
-- ------------------------------------------------------------
INSERT INTO tipos_membresia (nombre, descripcion, duracion_dias, precio, incluye_clases, activo) VALUES
('Mensual Basica', 'Acceso al area de pesas y maquinaria cardiovascular', 30, 35.00, 0, 1),
('Mensual VIP', 'Acceso total a pesas, sauna y todas las clases grupales', 30, 50.00, 1, 1),
('Trimestral VIP', 'Plan trimestral con acceso total y descuento del 10%', 90, 135.00, 1, 1),
('Pase Diario', 'Acceso por un solo dia a las instalaciones', 1, 5.00, 0, 1);

-- ------------------------------------------------------------
-- 5. INSERT EN MEMBRESIAS
-- ------------------------------------------------------------
INSERT INTO membresias (id_socio, id_tipo, fecha_inicio, fecha_vencimiento, precio_pactado, estado) VALUES
(1, 2, '2024-03-01', '2024-03-31', 50.00, 'ACTIVA'),
(2, 1, '2024-02-01', '2024-03-02', 35.00, 'VENCIDA'),
(3, 3, '2024-01-15', '2024-04-15', 135.00, 'ACTIVA');

-- ------------------------------------------------------------
-- 6. INSERT EN PAGOS
-- ------------------------------------------------------------
INSERT INTO pagos (id_membresia, id_usuario_registro, fecha_pago, monto, metodo_pago, referencia, observacion, anulado) VALUES
(1, 2, '2024-03-01 08:30:00', 50.00, 'EFECTIVO', NULL, 'Pago mensualidad marzo', 0),
(2, 2, '2024-02-01 10:15:00', 35.00, 'TARJETA', 'TXN-984512', 'Pago con tarjeta BAC', 0),
(3, 1, '2024-01-15 14:00:00', 135.00, 'TRANSFERENCIA', 'TRF-001298', 'Transferencia Lafise', 0);

-- ------------------------------------------------------------
-- 7. INSERT EN SALAS
-- ------------------------------------------------------------
INSERT INTO salas (nombre, capacidad, activo) VALUES
('Sala Principal de Pesas', 50, 1),
('Salon Aerobico A', 20, 1),
('Salon de Spinning', 15, 1);

-- ------------------------------------------------------------
-- 8. INSERT EN ACTIVIDADES
-- ------------------------------------------------------------
INSERT INTO actividades (nombre, descripcion, duracion_min, cupo_maximo, activo) VALUES
('Spinning Intenso', 'Clase de ciclismo bajo techo de alta intensidad', 45, 15, 1),
('Zumba Fit', 'Baile aerobico para quema de calorias', 60, 20, 1),
('Cross Training', 'Entrenamiento funcional de alta resistencia', 60, 15, 1);

-- ------------------------------------------------------------
-- 9. INSERT EN HORARIOS
-- ------------------------------------------------------------
-- 1=Lunes, 2=Martes, 3=Miercoles, 4=Jueves, 5=Viernes, 6=Sabado
INSERT INTO horarios (id_instructor, id_actividad, id_sala, dia_semana, hora_inicio, hora_fin, activo) VALUES
(2, 1, 3, 1, '06:00:00', '06:45:00', 1),
(2, 1, 3, 3, '06:00:00', '06:45:00', 1),
(1, 3, 2, 2, '17:00:00', '18:00:00', 1),
(1, 3, 2, 4, '17:00:00', '18:00:00', 1);

-- ------------------------------------------------------------
-- 10. INSERT EN BITACORA DE ACCESOS (Histórico de demostración)
-- ------------------------------------------------------------
INSERT INTO bitacora_accesos (id_usuario, usuario_intento, fecha_hora, resultado, equipo) VALUES
(1, 'admin', '2024-03-01 08:00:00', 'EXITO', 'RECEPCION-PC1'),
(2, 'recepcion01', '2024-03-01 08:05:00', 'EXITO', 'RECEPCION-PC1'),
(NULL, 'admin_incorrecto', '2024-03-01 08:10:00', 'FALLIDO', 'RECEPCION-PC1');

DROP USER IF EXISTS 'gym_app'@'localhost';
CREATE USER 'gym_app'@'localhost' IDENTIFIED BY 'Gym#2026app';
GRANT ALL PRIVILEGES ON gimnasio_db.* TO 'gym_app'@'localhost';
FLUSH PRIVILEGES;

UPDATE membresias
SET fecha_vencimiento = '2026-12-31', estado = 'ACTIVA'
WHERE id_socio IN (1, 2, 3);