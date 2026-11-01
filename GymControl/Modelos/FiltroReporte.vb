''' <summary>
''' Filtros comunes de los reportes R04, R05 y R06.
''' No contiene SQL: el ReporteDAO traduce estos valores a
''' parámetros de las vistas de reportes.
''' </summary>
Public Class FiltroReporte

    Public Const Todos As String = "TODOS"

    Public Shared ReadOnly MetodosPagoValidos As String() =
        {"EFECTIVO", "TARJETA", "TRANSFERENCIA"}

    Public Sub New()
        FechaInicio = New Date(Date.Today.Year, Date.Today.Month, 1)
        FechaFin = Date.Today
        MetodoPago = Todos
        SoloActivos = True
    End Sub

    ' R04
    Public Property FechaInicio As Date
    Public Property FechaFin As Date
    Public Property MetodoPago As String

    ' R05
    Public Property IdSocio As Integer?
    Public Property FechaDesde As Date?

    ' R06
    Public Property IdSala As Integer?
    Public Property IdInstructor As Integer?
    Public Property SoloActivos As Boolean

    Public ReadOnly Property FechaFinExclusiva As Date
        Get
            Return FechaFin.Date.AddDays(1)
        End Get
    End Property

    Public ReadOnly Property EsTodosLosMetodos As Boolean
        Get
            Return String.IsNullOrWhiteSpace(MetodoPago) OrElse
                   MetodoPago.Trim().Equals(Todos, StringComparison.OrdinalIgnoreCase)
        End Get
    End Property

    ''' <summary>
    ''' Devuelve Nothing cuando el filtro es válido o un mensaje
    ''' listo para mostrar al usuario.
    ''' </summary>
    Public Function Validar() As String

        If FechaInicio.Date > FechaFin.Date Then
            Return "La fecha inicial no puede ser mayor que la fecha final."
        End If

        If Not EsTodosLosMetodos Then

            Dim metodo As String = MetodoPago.Trim().ToUpperInvariant()

            If Array.IndexOf(MetodosPagoValidos, metodo) < 0 Then
                Return "El método de pago seleccionado no es válido."
            End If

        End If

        If IdSocio.HasValue AndAlso IdSocio.Value <= 0 Then
            Return "El socio seleccionado no es válido."
        End If

        If FechaDesde.HasValue AndAlso FechaDesde.Value.Year < 1900 Then
            Return "La fecha desde no es válida."
        End If

        If IdSala.HasValue AndAlso IdSala.Value <= 0 Then
            Return "La sala seleccionada no es válida."
        End If

        If IdInstructor.HasValue AndAlso IdInstructor.Value <= 0 Then
            Return "El instructor seleccionado no es válido."
        End If

        Return String.Empty

    End Function

    Public Function MetodoPagoNormalizado() As String

        If EsTodosLosMetodos Then Return Todos
        Return MetodoPago.Trim().ToUpperInvariant()

    End Function

    Public Function Clonar() As FiltroReporte

        Return New FiltroReporte With {
            .FechaInicio = FechaInicio,
            .FechaFin = FechaFin,
            .MetodoPago = MetodoPago,
            .IdSocio = IdSocio,
            .FechaDesde = FechaDesde,
            .IdSala = IdSala,
            .IdInstructor = IdInstructor,
            .SoloActivos = SoloActivos
        }

    End Function

End Class
