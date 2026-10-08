# GymControl

<p align="center">
  <img src="https://readme-typing-svg.demolab.com?font=JetBrains+Mono&size=24&duration=3000&pause=1000&color=CBA6F7&center=true&vCenter=true&width=650&lines=Sistema+de+Gesti%C3%B3n+para+Gimnasios;VB.NET+%7C+Windows+Forms;MariaDB+%7C+MySqlConnector;Proyecto+Acad%C3%A9mico" />
</p>

<p align="center">
  Sistema de escritorio para la gestión y administración de un gimnasio.
</p>

---

## Sobre el proyecto

**GymControl** es una aplicación de escritorio desarrollada para gestionar las principales operaciones de un gimnasio.

El sistema permite administrar socios, membresías, pagos, instructores, actividades, horarios y usuarios. También cuenta con autenticación, control de acceso según roles y registro de los accesos al sistema.

El proyecto fue desarrollado como parte de la carrera de **Ingeniería de Sistemas**.

---

## Funcionalidades

- Inicio de sesión de usuarios
- Control de acceso según el rol
- Gestión de socios
- Gestión de membresías
- Registro y gestión de pagos
- Gestión de instructores
- Gestión de actividades
- Gestión de horarios
- Gestión de usuarios
- Bitácora de accesos
- Cambio de contraseña
- Bloqueo de cuentas después de 3 intentos fallidos
- Panel principal con indicadores
- Consulta de membresías próximas a vencer
- Consulta de ingresos del mes
- Consulta de clases programadas para el día

---

## Roles del sistema

| Rol | Descripción |
|---|---|
| Administrador | Acceso completo al sistema |
| Recepcionista | Gestión de socios, membresías, pagos y operaciones de recepción |
| Instructor | Consulta de horarios y actividades asignadas |
| Socio | Acceso al portal personal y consulta de su membresía |

---

## Tecnologías

### Lenguaje y plataforma

<p>
  <img src="https://skillicons.dev/icons?i=dotnet" />
</p>

- Visual Basic .NET
- .NET 10
- Windows Forms

### Base de datos

<p>
  <img src="https://skillicons.dev/icons?i=mysql" />
</p>

- MariaDB
- MySqlConnector

### Herramientas

<p>
  <img src="https://skillicons.dev/icons?i=git,github,visualstudio" />
</p>

- Visual Studio
- Git
- GitHub

---

## Estructura del proyecto

El proyecto está organizado separando los formularios, acceso a datos y componentes generales de la aplicación.

```text
GymControl/
│
├── Formularios/
│   ├── frmLogin
│   ├── frmPrincipal
│   ├── FrmSocios
│   ├── frmMembresiasPagos
│   ├── frmInstructores
│   ├── frmHorarios
│   ├── frmUsuarios
│   ├── frmBitacora
│   └── frmCambiarContrasena
│
├── Datos/
│   ├── ConexionBD
│   ├── Seguridad
│   ├── Sesion
│   ├── UsuarioDAO
│   ├── BitacoraDAO
│   ├── MembresiaDAO
│   ├── PagoDAO
│   └── HorarioDAO
│
└── GymControl.sln
```
## Usuarios e inicio de sesion.
Estos son los usuarios con su respectiva contrasena en texto plano ya que en la base de datos estan encriptadas:
- Usuario: admin, Contraseña: Admin123*
- Usuario: recepcion01, Contraseña: Recep2024!
- Usuario: inst_javier, Contraseña: Javier2024!
- Usuario: socio_carlos, Contraseña: Carlos2024!
- Usuario: usuario_bloqueado, Contraseña: Bloqueado123*
