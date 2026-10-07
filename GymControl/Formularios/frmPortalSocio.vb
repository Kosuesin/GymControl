Imports System.Data

Public Class frmPortalSocio

    Private ReadOnly socioDAO As New SocioDAO()
    Private ReadOnly membresiaDAO As New MembresiaDAO()
    Private ReadOnly pagoDAO As New PagoDAO()
    Private ReadOnly horarioDAO As New HorarioDAO()
    Private ReadOnly usuarioDAO As New UsuarioDAO()

    Private idMembresiaActual As Integer?

    Private Sub frmPortalSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Sesion.HaySesion() OrElse Not Sesion.IdSocio.HasValue Then
            MessageBox.Show("No hay una sesión de socio activa.", "GymControl",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Close()
            Return
        End If

        ConfigurarGrillas()
        CargarEstadoSesion()

        If Not CargarEncabezado() Then Return

        CargarMembresia()
        CargarClasesSemana()
    End Sub

    Private Sub ConfigurarGrillas()
        For Each grilla As DataGridView In New DataGridView() {dgvMisPagos, dgvClases}
            grilla.AllowUserToAddRows = False
            grilla.AllowUserToDeleteRows = False
            grilla.MultiSelect = False
            grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Next
    End Sub

    Private Sub CargarEstadoSesion()
        lblStatusUsuario.Text = "Usuario: " & Sesion.NombreUsuario
        lblStatusRol.Text = "Rol: " & If(String.IsNullOrWhiteSpace(Sesion.Rol), "Socio", Sesion.Rol)
        lblStatusModo.Text = "Modo: solo lectura"
    End Sub

    ' =========================================================
    ' ENCABEZADO (NOMBRE, AVATAR, ÚLTIMO ACCESO)
    ' =========================================================
    Private Function CargarEncabezado() As Boolean
        Try
            Dim socio As DataRow = socioDAO.ObtenerSocioPorId(Sesion.IdSocio.Value)
            If socio Is Nothing Then
                MessageBox.Show("No se encontró el registro del socio.", "GymControl",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Close()
                Return False
            End If

            Dim nombres As String = socio("nombres").ToString().Trim()
            Dim apellidos As String = socio("apellidos").ToString().Trim()

            lblNombreSocio.Text = "Hola, " & (nombres & " " & apellidos).Trim()
            lblAvatar.Text = Iniciales(nombres, apellidos)

            Dim ultimoAcceso As DateTime? = usuarioDAO.ObtenerUltimoAcceso(Sesion.IdUsuario)
            lblInfoAcceso.Text = "Socio N.º " & Sesion.IdSocio.Value.ToString() &
                                 " - Último acceso: " &
                                 If(ultimoAcceso.HasValue, ultimoAcceso.Value.ToString("dd/MM/yyyy HH:mm"),
                                    "--/--/---- --:--")
            Return True
        Catch ex As Exception
            MessageBox.Show("No se pudieron cargar los datos del socio." & Environment.NewLine &
                            Environment.NewLine & ex.Message,
                            "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
            Return False
        End Try
    End Function

    Private Shared Function Iniciales(nombres As String, apellidos As String) As String
        Dim resultado As String = ""
        If nombres <> "" Then resultado = nombres.Substring(0, 1)
        If apellidos <> "" Then resultado &= apellidos.Substring(0, 1)
        If resultado = "" Then resultado = "?"
        Return resultado.ToUpper()
    End Function

    ' =========================================================
    ' PANEL: MI MEMBRESÍA
    ' =========================================================
    Private Sub CargarMembresia()
        Try
            Dim tabla As DataTable = membresiaDAO.ListarMembresiasPorSocio(Sesion.IdSocio.Value)
            Dim fila As DataRow = SeleccionarMembresiaActual(tabla)

            If fila Is Nothing Then
                SinMembresia()
                Return
            End If

            idMembresiaActual = Convert.ToInt32(fila("id_membresia"))
            Dim detalle As DataRow = membresiaDAO.ObtenerMembresiaPorId(idMembresiaActual.Value)

            Dim duracion As Integer = 0
            Dim incluyeClases As Boolean = True
            If detalle IsNot Nothing Then
                duracion = Convert.ToInt32(detalle("duracion_dias"))
                incluyeClases = Convert.ToBoolean(detalle("incluye_clases"))
            End If

            Dim inicio As Date = Convert.ToDateTime(fila("FechaInicio")).Date
            Dim vencimiento As Date = Convert.ToDateTime(fila("FechaVencimiento")).Date
            If duracion <= 0 Then duracion = Math.Max((vencimiento - inicio).Days, 1)

            lblValTipo.Text = fila("Tipo").ToString()
            lblValInicio.Text = inicio.ToString("dd/MM/yyyy")
            lblValVence.Text = vencimiento.ToString("dd/MM/yyyy")
            lblValIncluye.Text = If(incluyeClases, "Sí", "No")

            MostrarEstadoYDias(fila("Estado").ToString().Trim().ToUpper(),
                               (vencimiento - Date.Today).Days, duracion)

            CargarCuenta()
            CargarPagos()
        Catch ex As Exception
            MessageBox.Show("No se pudo cargar la membresía." & Environment.NewLine & Environment.NewLine & ex.Message,
                            "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Prioriza la membresía ACTIVA más reciente; si no hay, la más reciente en general.
    Private Shared Function SeleccionarMembresiaActual(tabla As DataTable) As DataRow
        If tabla Is Nothing OrElse tabla.Rows.Count = 0 Then Return Nothing

        Dim activas = tabla.AsEnumerable().Where(Function(f) f("Estado").ToString().Trim().ToUpper() = "ACTIVA")
        If activas.Any() Then
            Return activas.OrderByDescending(Function(f) Convert.ToDateTime(f("FechaVencimiento"))).First()
        End If

        Return tabla.Rows(0)
    End Function

    Private Sub SinMembresia()
        idMembresiaActual = Nothing
        lblValTipo.Text = "-"
        lblValInicio.Text = "--/--/----"
        lblValVence.Text = "--/--/----"
        lblValIncluye.Text = "-"
        PintarEstado("SIN MEMBRESÍA", Color.Gainsboro, Color.DimGray)
        lblDiasRestantes.Text = "El socio no tiene membresías registradas."
        pgbDiasRestantes.Minimum = 0
        pgbDiasRestantes.Maximum = 100
        pgbDiasRestantes.Value = 0
        lblValTotal.Text = FormatearMoneda(0D)
        lblValPagado.Text = FormatearMoneda(0D)
        lblValSaldo.Text = FormatearMoneda(0D)
        lblValSaldo.ForeColor = Color.Green
        dgvMisPagos.DataSource = Nothing
    End Sub

    Private Sub MostrarEstadoYDias(estado As String, diasRestantes As Integer, duracion As Integer)
        ' Una membresía ACTIVA con vencimiento pasado se muestra como VENCIDA.
        If estado = "ACTIVA" AndAlso diasRestantes < 0 Then estado = "VENCIDA"

        Select Case estado
            Case "ACTIVA"
                PintarEstado("ACTIVA", Color.LightGreen, Color.DarkGreen)
                lblDiasRestantes.Text = "Días restantes: " & diasRestantes.ToString() & " de " & duracion.ToString()
                lblDiasRestantes.ForeColor = Color.DarkOrange
                pgbDiasRestantes.Minimum = 0
                pgbDiasRestantes.Maximum = Math.Max(duracion, 1)
                pgbDiasRestantes.Value = Math.Clamp(diasRestantes, 0, pgbDiasRestantes.Maximum)

            Case "VENCIDA"
                PintarEstado("VENCIDA", Color.LightCoral, Color.DarkRed)
                If diasRestantes < 0 Then
                    lblDiasRestantes.Text = "Vencida hace " & Math.Abs(diasRestantes).ToString() & " día(s)."
                Else
                    lblDiasRestantes.Text = "Membresía vencida."
                End If
                lblDiasRestantes.ForeColor = Color.DarkRed
                pgbDiasRestantes.Minimum = 0
                pgbDiasRestantes.Maximum = Math.Max(duracion, 1)
                pgbDiasRestantes.Value = 0

            Case "SUSPENDIDA"
                PintarEstado("SUSPENDIDA", Color.LightGoldenrodYellow, Color.DarkOrange)
                lblDiasRestantes.Text = "Membresía suspendida."
                lblDiasRestantes.ForeColor = Color.DarkOrange
                pgbDiasRestantes.Minimum = 0
                pgbDiasRestantes.Maximum = Math.Max(duracion, 1)
                pgbDiasRestantes.Value = 0

            Case "CANCELADA"
                PintarEstado("CANCELADA", Color.Gainsboro, Color.DimGray)
                lblDiasRestantes.Text = "Membresía cancelada."
                lblDiasRestantes.ForeColor = Color.DimGray
                pgbDiasRestantes.Minimum = 0
                pgbDiasRestantes.Maximum = Math.Max(duracion, 1)
                pgbDiasRestantes.Value = 0

            Case Else
                PintarEstado(estado, Color.LightGray, Color.Black)
                lblDiasRestantes.Text = "Días restantes: " & diasRestantes.ToString() & " de " & duracion.ToString()
                pgbDiasRestantes.Minimum = 0
                pgbDiasRestantes.Maximum = Math.Max(duracion, 1)
                pgbDiasRestantes.Value = Math.Clamp(diasRestantes, 0, pgbDiasRestantes.Maximum)
        End Select
    End Sub

    Private Sub PintarEstado(texto As String, fondo As Color, colorTexto As Color)
        lblEstadoMembresia.Text = texto
        lblEstadoMembresia.BackColor = fondo
        lblEstadoMembresia.ForeColor = colorTexto
    End Sub

    ' =========================================================
    ' PANEL: ESTADO DE CUENTA
    ' =========================================================
    Private Sub CargarCuenta()
        If Not idMembresiaActual.HasValue Then
            lblValTotal.Text = FormatearMoneda(0D)
            lblValPagado.Text = FormatearMoneda(0D)
            lblValSaldo.Text = FormatearMoneda(0D)
            Return
        End If

        Dim totales As DataRow = pagoDAO.ObtenerTotalesPago(idMembresiaActual.Value)
        Dim total As Decimal = 0D
        Dim pagado As Decimal = 0D

        If totales IsNot Nothing Then
            total = Convert.ToDecimal(totales("Total"))
            pagado = Convert.ToDecimal(totales("Pagado"))
        End If

        Dim saldo As Decimal = total - pagado

        lblValTotal.Text = FormatearMoneda(total)
        lblValPagado.Text = FormatearMoneda(pagado)
        lblValSaldo.Text = FormatearMoneda(saldo)
        lblValSaldo.ForeColor = If(saldo > 0, Color.Red, Color.Green)
    End Sub

    ' =========================================================
    ' GRID: MIS PAGOS
    ' =========================================================
    Private Sub CargarPagos()
        If Not idMembresiaActual.HasValue Then
            dgvMisPagos.DataSource = Nothing
            Return
        End If

        dgvMisPagos.DataSource = pagoDAO.ListarPagosPorMembresia(idMembresiaActual.Value)

        If dgvMisPagos.Columns.Contains("id_pago") Then dgvMisPagos.Columns("id_pago").Visible = False
        If dgvMisPagos.Columns.Contains("Registrado") Then dgvMisPagos.Columns("Registrado").Visible = False

        If dgvMisPagos.Columns.Contains("fecha_pago") Then
            dgvMisPagos.Columns("fecha_pago").HeaderText = "Fecha"
            dgvMisPagos.Columns("fecha_pago").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
        End If
        If dgvMisPagos.Columns.Contains("monto") Then dgvMisPagos.Columns("monto").HeaderText = "Monto"
        If dgvMisPagos.Columns.Contains("metodo_pago") Then dgvMisPagos.Columns("metodo_pago").HeaderText = "Método"
        If dgvMisPagos.Columns.Contains("Estado") Then dgvMisPagos.Columns("Estado").HeaderText = "Estado"

        Dim pesos As New Dictionary(Of String, Integer) From {
            {"fecha_pago", 130}, {"monto", 90}, {"metodo_pago", 100}, {"Estado", 80}
        }
        For Each par In pesos
            If dgvMisPagos.Columns.Contains(par.Key) Then
                dgvMisPagos.Columns(par.Key).FillWeight = par.Value
            End If
        Next
    End Sub

    ' =========================================================
    ' GRID: CLASES DE LA SEMANA
    ' =========================================================
    Private Sub CargarClasesSemana()
        dgvClases.DataSource = horarioDAO.ListarHorarios(soloActivos:=True)

        For Each nombre As String In New String() {"id_horario", "id_instructor", "id_actividad",
                                                    "id_sala", "dia_semana", "Estado"}
            If dgvClases.Columns.Contains(nombre) Then dgvClases.Columns(nombre).Visible = False
        Next

        If dgvClases.Columns.Contains("Dia") Then dgvClases.Columns("Dia").HeaderText = "Día"
        If dgvClases.Columns.Contains("HoraInicio") Then dgvClases.Columns("HoraInicio").HeaderText = "Hora inicio"
        If dgvClases.Columns.Contains("HoraFin") Then dgvClases.Columns("HoraFin").HeaderText = "Hora fin"

        Dim pesos As New Dictionary(Of String, Integer) From {
            {"Dia", 75}, {"HoraInicio", 80}, {"HoraFin", 80},
            {"Actividad", 115}, {"Instructor", 130}, {"Sala", 95}
        }
        For Each par In pesos
            If dgvClases.Columns.Contains(par.Key) Then
                dgvClases.Columns(par.Key).FillWeight = par.Value
            End If
        Next
    End Sub

    Private Shared Function FormatearMoneda(valor As Decimal) As String
        Return "C$ " & valor.ToString("N2", Globalization.CultureInfo.CurrentCulture)
    End Function

    ' =========================================================
    ' BOTONES
    ' =========================================================
    Private Sub btnCambiarContrasena_Click(sender As Object, e As EventArgs) Handles btnCambiarContrasena.Click
        Try
            Using frm As New frmCambiarContrasena()
                frm.ShowDialog(Me)
            End Using
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir el formulario de cambio de contraseña." &
                            Environment.NewLine & Environment.NewLine & ex.Message,
                            "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim respuesta As DialogResult =
            MessageBox.Show("¿Desea cerrar la sesión actual?", "Confirmar cierre de sesión",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta <> DialogResult.Yes Then Return

        Sesion.CerrarSesion()

        ' Volver a mostrar el inicio de sesión.
        ' Cuando este formulario se cierra, el frmLogin
        ' original también termina por sí solo.
        Using login As New frmLogin()
            login.ShowDialog()
        End Using

        Close()
    End Sub

End Class
