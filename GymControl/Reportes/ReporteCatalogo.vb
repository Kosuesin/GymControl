Imports System.IO

''' <summary>
''' Catálogo único de los reportes R04, R05 y R06: archivo RDLC,
''' datasets, roles autorizados y textos para la interfaz.
'''
''' Mantener aquí los nombres evita que el formulario, los RDLC y
''' el DAO se desincronicen.
''' </summary>
Public NotInheritable Class ReporteCatalogo

    Public Const R04 As String = "R04"
    Public Const R05 As String = "R05"
    Public Const R06 As String = "R06"

    Public Const DatasetIngresos As String = "dsIngresos"
    Public Const DatasetEstadoCuenta As String = "dsEstadoCuenta"
    Public Const DatasetMembresias As String = "dsMembresias"
    Public Const DatasetResumenCuenta As String = "dsResumenCuenta"
    Public Const DatasetHorario As String = "dsHorario"
    Public Const DatasetResumenSala As String = "dsResumenSala"
    Public Const DatasetResumenInstructor As String = "dsResumenInstructor"

    Private Sub New()
    End Sub

    Public Shared Function Obtener(codigo As String) As DefinicionReporte

        Select Case Normalizar(codigo)

            Case R04
                Return New DefinicionReporte With {
                    .Codigo = R04,
                    .Nombre = "Ingresos por período",
                    .Categoria = "Financieros",
                    .Descripcion = "Pagos registrados en un rango de fechas, filtrados por método. " &
                                   "Incluye subtotales por método y por fecha, cantidad de pagos, " &
                                   "total general y pagos anulados identificados.",
                    .ArchivoRdlc = "R04_Ingresos.rdlc",
                    .Datasets = New String() {DatasetIngresos},
                    .Roles = New String() {"Administrador", "Recepcionista"}
                }

            Case R05
                Return New DefinicionReporte With {
                    .Codigo = R05,
                    .Nombre = "Estado de cuenta del socio",
                    .Categoria = "Cuentas",
                    .Descripcion = "Membresías y pagos de un socio desde una fecha. Incluye pagos anulados " &
                                   "identificados y saldo pendiente calculado solo con pagos vigentes. " &
                                   "El rol Socio solo puede consultar su propia cuenta.",
                    .ArchivoRdlc = "R05_EstadoCuenta.rdlc",
                    .Datasets = New String() {DatasetResumenCuenta, DatasetMembresias, DatasetEstadoCuenta},
                    .Roles = New String() {"Administrador", "Recepcionista", "Socio"}
                }

            Case R06
                Return New DefinicionReporte With {
                    .Codigo = R06,
                    .Nombre = "Horario semanal y ocupación estimada",
                    .Categoria = "Horarios",
                    .Descripcion = "Programación de lunes a sábado por actividad, instructor y sala. " &
                                   "Incluye resumen de horas por sala y por instructor. La ocupación " &
                                   "se presenta como estimada (cupo máximo/capacidad), no como asistencia real.",
                    .ArchivoRdlc = "R06_Horario.rdlc",
                    .Datasets = New String() {DatasetHorario, DatasetResumenSala, DatasetResumenInstructor},
                    .Roles = New String() {"Administrador", "Recepcionista", "Instructor", "Socio"}
                }

        End Select

        Return Nothing

    End Function

    Public Shared Function Normalizar(codigo As String) As String

        If String.IsNullOrWhiteSpace(codigo) Then Return String.Empty
        Return codigo.Trim().ToUpperInvariant()

    End Function

    Public Shared Function PuedeVer(codigo As String) As Boolean

        If Not Sesion.HaySesion() Then Return False

        Dim definicion As DefinicionReporte = Obtener(codigo)
        If definicion Is Nothing Then Return False

        Dim rol As String = If(Sesion.Rol, String.Empty).Trim()

        For Each permitido As String In definicion.Roles
            If permitido.Equals(rol, StringComparison.OrdinalIgnoreCase) Then Return True
        Next

        Return False

    End Function

    Public Shared Function RutaRdlc(codigo As String) As String

        Dim definicion As DefinicionReporte = Obtener(codigo)
        If definicion Is Nothing Then Return String.Empty

        Return Path.Combine(Application.StartupPath, "Reportes", definicion.ArchivoRdlc)

    End Function

End Class

Public Class DefinicionReporte

    Public Property Codigo As String
    Public Property Nombre As String
    Public Property Categoria As String
    Public Property Descripcion As String
    Public Property ArchivoRdlc As String
    Public Property Datasets As String()
    Public Property Roles As String()

End Class
