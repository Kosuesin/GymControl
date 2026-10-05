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
-- 4. INSERT DE DATOS FIJOS (ROLES DEL SISTEMA)
-- ------------------------------------------------------------

INSERT INTO roles (nombre, descripcion) VALUES
('Administrador', 'Acceso total al sistema y configuraciones'),
('Recepcionista', 'Gestion de socios, membresias, pagos y asistencia'),
('Instructor', 'Consulta de horarios y actividades asignadas'),
('Socio', 'Acceso al portal personal para ver estado de membresia');
