Imports System.Data
Imports System.Globalization

Public Class frmMembresiasPagos
    Private ReadOnly membresiaDAO As New MembresiaDAO()
    Private ReadOnly pagoDAO As New PagoDAO()
    Private ReadOnly socioDAO As New SocioDAO()
    Private idSocioSeleccionado As Integer?
    Private idMembresiaPagoSeleccionada As Integer?
    Private cargando As Boolean

    Private Sub frmMembresiasPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsuarioActual.Text = If(Sesion.HaySesion(), "Usuario: " & Sesion.NombreUsuario, "Usuario: Sin sesión")
        cboMetodo.Items.Clear()
        cboMetodo.Items.AddRange(New Object() {"EFECTIVO", "TARJETA", "TRANSFERENCIA"})
        cboEstado.Items.Clear()
        cboEstado.Items.AddRange(New Object() {"ACTIVA", "SUSPENDIDA", "VENCIDA", "CANCELADA"})
        cboEstado.SelectedItem = "ACTIVA"
        dgvMembresias.AutoGenerateColumns = True
        dgvMembresias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMembresias.MultiSelect = False
        dgvPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPagos.MultiSelect = False
        CargarTiposMembresia()
        LimpiarDatosSocio()
    End Sub

    Private Sub CargarTiposMembresia()
        Try
            cboTipoMembresia.DataSource = membresiaDAO.ListarTiposMembresia()
            cboTipoMembresia.DisplayMember = "nombre"
            cboTipoMembresia.ValueMember = "id_tipo"
            ActualizarDatosTipo()
        Catch ex As Exception
            MostrarError("No se pudieron cargar los tipos de membresía.", ex)
        End Try
    End Sub

    Private Sub btnBuscarSocio_Click(sender As Object, e As EventArgs) Handles btnBuscarSocio.Click
        Dim cedula As String = txtCedula.Text.Trim()
        If String.IsNullOrWhiteSpace(cedula) Then
            MostrarAviso("Ingrese la cédula del socio.")
            Return
        End If

        Try
            Dim encontrados As DataTable = socioDAO.BuscarSocios(cedula, 1)
            If encontrados.Rows.Count = 0 Then
                idSocioSeleccionado = Nothing
                LimpiarDatosSocio()
                MostrarAviso("No se encontró un socio activo con esa cédula.")
                Return
            End If

            Dim id As Integer = Convert.ToInt32(encontrados.Rows(0)("id_socio"))
            Dim socio As DataRow = socioDAO.ObtenerSocioPorId(id)
            If socio Is Nothing Then
                MostrarAviso("No se pudo obtener la información del socio.")
                Return
            End If

            idSocioSeleccionado = id
            lblSocio.Text = "Socio: " & socio("nombres").ToString() & " " & socio("apellidos").ToString()
            CargarMembresias()
        Catch ex As Exception
            MostrarError("No se pudo buscar el socio.", ex)
        End Try
    End Sub

    Private Sub CargarMembresias(Optional idSeleccionado As Integer? = Nothing)
        If Not idSocioSeleccionado.HasValue Then
            LimpiarDatosSocio()
            Return
        End If

        Dim tabla As DataTable = membresiaDAO.ListarMembresiasPorSocio(idSocioSeleccionado.Value)
        dgvMembresias.DataSource = tabla
        If dgvMembresias.Columns.Contains("id_membresia") Then dgvMembresias.Columns("id_membresia").Visible = False
        If dgvMembresias.Columns.Contains("id_tipo") Then dgvMembresias.Columns("id_tipo").Visible = False
        If dgvMembresias.Columns.Contains("Descripcion") Then dgvMembresias.Columns("Descripcion").Visible = False
        If dgvMembresias.Columns.Contains("FechaInicio") Then dgvMembresias.Columns("FechaInicio").HeaderText = "Fecha inicio"
        If dgvMembresias.Columns.Contains("FechaVencimiento") Then dgvMembresias.Columns("FechaVencimiento").HeaderText = "Fecha vencimiento"
        If dgvMembresias.Columns.Contains("Precio") Then dgvMembresias.Columns("Precio").HeaderText = "Precio C$"

        ActualizarEstadoSocio(tabla)
        CargarMembresiasPago(tabla, idSeleccionado)
    End Sub

    Private Sub ActualizarEstadoSocio(tabla As DataTable)
        If tabla.Rows.Count = 0 Then
            lblEstadoSocio.Text = "Socio: Sin membresías"
            lblMembresiasActiva.Text = "Membresía activa: Ninguna"
            lblSaldoPendiente.Text = "Saldo pendiente: C$ 0.00"
            Return
        End If

        Dim activa As DataRow = tabla.AsEnumerable().FirstOrDefault(Function(f) f("Estado").ToString() = "ACTIVA")
        If activa Is Nothing Then
            lblEstadoSocio.Text = "Socio: Sin membresía ACTIVA"
            lblMembresiasActiva.Text = "Membresía activa: Ninguna"
            lblSaldoPendiente.Text = "Saldo pendiente: C$ 0.00"
        Else
            lblEstadoSocio.Text = "Socio: Activo"
            lblMembresiasActiva.Text = "Membresía activa: " & activa("Tipo").ToString()
            Dim totales As DataRow = pagoDAO.ObtenerTotalesPago(Convert.ToInt32(activa("id_membresia")))
            Dim saldo As Decimal = If(totales Is Nothing, 0D, Convert.ToDecimal(totales("Total")) - Convert.ToDecimal(totales("Pagado")))
            lblSaldoPendiente.Text = "Saldo pendiente: " & FormatearMoneda(saldo)
        End If
    End Sub

    Private Sub CargarMembresiasPago(tabla As DataTable, idSeleccionado As Integer?)
        cargando = True
        Try
            cboMembresiaPago.DataSource = tabla.Copy()
            cboMembresiaPago.DisplayMember = "Descripcion"
            cboMembresiaPago.ValueMember = "id_membresia"
            If idSeleccionado.HasValue Then cboMembresiaPago.SelectedValue = idSeleccionado.Value
            If cboMembresiaPago.SelectedIndex >= 0 Then
                idMembresiaPagoSeleccionada = ObtenerIdMembresiaCombo()
            Else
                idMembresiaPagoSeleccionada = Nothing
            End If
        Finally
            cargando = False
        End Try
        CargarDatosPago()
    End Sub

    Private Sub cboTipoMembresia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoMembresia.SelectedIndexChanged
        If Not cargando Then ActualizarDatosTipo()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ActualizarFechaVencimiento()
    End Sub

    Private Sub ActualizarDatosTipo()
        Dim fila As DataRowView = TryCast(cboTipoMembresia.SelectedItem, DataRowView)
        If fila Is Nothing Then Return
        txtDuracion.Text = fila("duracion_dias").ToString()
        txtPrecio.Text = Convert.ToDecimal(fila("precio")).ToString("0.00", CultureInfo.InvariantCulture)
        ActualizarFechaVencimiento()
    End Sub

    Private Sub ActualizarFechaVencimiento()
        Dim fila As DataRowView = TryCast(cboTipoMembresia.SelectedItem, DataRowView)
        If fila Is Nothing Then Return
        Dim duracion As Integer
        If Integer.TryParse(fila("duracion_dias").ToString(), duracion) AndAlso duracion > 0 Then
            dtpFechccaVencimiento.Value = DateTimePicker1.Value.Date.AddDays(duracion)
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If Not idSocioSeleccionado.HasValue Then MostrarAviso("Debe buscar y seleccionar un socio.") : Return
        Dim fila As DataRowView = TryCast(cboTipoMembresia.SelectedItem, DataRowView)
        If fila Is Nothing Then MostrarAviso("Debe seleccionar un tipo de membresía.") : Return
        If dtpFechccaVencimiento.Value.Date < DateTimePicker1.Value.Date Then MostrarAviso("La fecha de vencimiento no puede ser anterior a la fecha de inicio.") : Return

        Try
            Dim precio As Decimal = Convert.ToDecimal(fila("precio"))
            If membresiaDAO.InsertarMembresia(idSocioSeleccionado.Value, Convert.ToInt32(fila("id_tipo")), DateTimePicker1.Value.Date, dtpFechccaVencimiento.Value.Date, precio, "ACTIVA") Then
                MessageBox.Show("Membresía registrada correctamente.", "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarMembresias()
            End If
        Catch ex As Exception
            MostrarError("No se pudo registrar la membresía.", ex)
        End Try
    End Sub

    Private Sub btnRenovar_Click(sender As Object, e As EventArgs) Handles btnRenovar.Click
        Dim id As Integer? = ObtenerIdMembresiaGrid()
        If Not id.HasValue Then MostrarAviso("Seleccione una membresía para renovar.") : Return
        Dim fila As DataRow = membresiaDAO.ObtenerMembresiaPorId(id.Value)
        If fila Is Nothing Then MostrarAviso("La membresía seleccionada ya no existe.") : Return
        If MessageBox.Show("¿Desea renovar la membresía seleccionada?", "Confirmar renovación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

        Try
            Dim inicioReferencia As Date = If(fila("fecha_vencimiento") Is DBNull.Value, Date.Today, Convert.ToDateTime(fila("fecha_vencimiento")).Date)
            If fila("estado").ToString() <> "ACTIVA" OrElse inicioReferencia < Date.Today Then inicioReferencia = Date.Today
            Dim nuevaFecha As Date = inicioReferencia.AddDays(Convert.ToInt32(fila("duracion_dias")))
            If membresiaDAO.ActualizarMembresia(id.Value, inicioReferencia, nuevaFecha, Convert.ToDecimal(fila("precio")), "ACTIVA") Then
                MessageBox.Show("Membresía renovada correctamente.", "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarMembresias(id)
            End If
        Catch ex As Exception
            MostrarError("No se pudo renovar la membresía.", ex)
        End Try
    End Sub

    Private Sub btnSuspender_Click(sender As Object, e As EventArgs) Handles btnSuspender.Click
        CambiarEstadoMembresia("SUSPENDIDA", "suspender")
    End Sub

    Private Sub btnCacelar_Click(sender As Object, e As EventArgs) Handles btnCacelar.Click
        CambiarEstadoMembresia("CANCELADA", "cancelar")
    End Sub

    Private Sub CambiarEstadoMembresia(estado As String, accion As String)
        Dim id As Integer? = ObtenerIdMembresiaGrid()
        If Not id.HasValue Then MostrarAviso("Seleccione una membresía para " & accion & ".") : Return
        If MessageBox.Show("¿Desea " & accion & " la membresía seleccionada?", "Confirmar operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        Try
            Dim resultado As Boolean = If(estado = "SUSPENDIDA", membresiaDAO.SuspenderMembresia(id.Value), membresiaDAO.CancelarMembresia(id.Value))
            If resultado Then CargarMembresias(id)
        Catch ex As Exception
            MostrarError("No se pudo actualizar el estado de la membresía.", ex)
        End Try
    End Sub

    Private Sub dgvMembresias_SelectionChanged(sender As Object, e As EventArgs) Handles dgvMembresias.SelectionChanged
        Dim id As Integer? = ObtenerIdMembresiaGrid()
        If id.HasValue AndAlso Not cargando Then
            CargarMembresiaEnEditor(id.Value)
            cargando = True
            cboMembresiaPago.SelectedValue = id.Value
            cargando = False
        End If
    End Sub

    Private Sub CargarMembresiaEnEditor(idMembresia As Integer)
        Dim fila As DataRowView = TryCast(dgvMembresias.CurrentRow.DataBoundItem, DataRowView)
        If fila Is Nothing Then Return
        cargando = True
        Try
            cboTipoMembresia.SelectedValue = Convert.ToInt32(fila("id_tipo"))
            DateTimePicker1.Value = Convert.ToDateTime(fila("FechaInicio")).Date
            dtpFechccaVencimiento.Value = Convert.ToDateTime(fila("FechaVencimiento")).Date
            txtPrecio.Text = Convert.ToDecimal(fila("Precio")).ToString("0.00", CultureInfo.InvariantCulture)
            Dim estado As String = fila("Estado").ToString()
            If cboEstado.Items.Contains(estado) Then cboEstado.SelectedItem = estado
        Finally
            cargando = False
        End Try
    End Sub

    Private Sub cboMembresiaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMembresiaPago.SelectedIndexChanged
        If cargando Then Return
        idMembresiaPagoSeleccionada = ObtenerIdMembresiaCombo()
        CargarDatosPago()
    End Sub

    Private Sub CargarDatosPago()
        If Not idMembresiaPagoSeleccionada.HasValue Then
            dgvPagos.Rows.Clear()
            ActualizarTotales(Nothing)
            Return
        End If
        Try
            Dim totales As DataRow = pagoDAO.ObtenerTotalesPago(idMembresiaPagoSeleccionada.Value)
            ActualizarTotales(totales)
            Dim pagos As DataTable = pagoDAO.ListarPagosPorMembresia(idMembresiaPagoSeleccionada.Value)
            dgvPagos.Rows.Clear()
            For Each pago As DataRow In pagos.Rows
                Dim indice As Integer = dgvPagos.Rows.Add(Convert.ToDateTime(pago("fecha_pago")).ToString("dd/MM/yyyy HH:mm"), FormatearMoneda(Convert.ToDecimal(pago("monto"))), pago("metodo_pago").ToString(), pago("Registrado").ToString(), pago("Estado").ToString())
                dgvPagos.Rows(indice).Tag = Convert.ToInt32(pago("id_pago"))
            Next
        Catch ex As Exception
            MostrarError("No se pudieron cargar los pagos.", ex)
        End Try
    End Sub

    Private Sub ActualizarTotales(totales As DataRow)
        Dim total As Decimal = If(totales Is Nothing, 0D, Convert.ToDecimal(totales("Total")))
        Dim pagado As Decimal = If(totales Is Nothing, 0D, Convert.ToDecimal(totales("Pagado")))
        Dim saldo As Decimal = total - pagado
        lblTotal.Text = FormatearMoneda(total)
        lblPagado.Text = FormatearMoneda(pagado)
        lblSaldo.Text = FormatearMoneda(saldo)
        lblSaldoPendiente.Text = "Saldo pendiente: " & FormatearMoneda(saldo)
    End Sub

    Private Sub btnRegistrarPago_Click(sender As Object, e As EventArgs) Handles btnRegistrarPago.Click
        If Not idMembresiaPagoSeleccionada.HasValue Then MostrarAviso("Debe seleccionar una membresía.") : Return
        If Not Sesion.HaySesion() Then MostrarAviso("Debe existir una sesión válida para registrar el pago.") : Return
        Dim monto As Decimal
        If Not Decimal.TryParse(txtMonto.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, monto) OrElse monto <= 0D Then MostrarAviso("Ingrese un monto válido mayor que cero.") : Return
        If cboMetodo.SelectedItem Is Nothing OrElse Not {"EFECTIVO", "TARJETA", "TRANSFERENCIA"}.Contains(cboMetodo.SelectedItem.ToString()) Then MostrarAviso("Seleccione un método de pago válido.") : Return

        Try
            Dim totales As DataRow = pagoDAO.ObtenerTotalesPago(idMembresiaPagoSeleccionada.Value)
            Dim saldo As Decimal = If(totales Is Nothing, 0D, Convert.ToDecimal(totales("Total")) - Convert.ToDecimal(totales("Pagado")))
            If monto > saldo Then MostrarAviso("El monto no puede superar el saldo pendiente.") : Return
            If pagoDAO.InsertarPago(idMembresiaPagoSeleccionada.Value, Sesion.IdUsuario, monto, cboMetodo.SelectedItem.ToString(), txtReferencia.Text, txtObservacion.Text) Then
                MessageBox.Show("Pago registrado correctamente.", "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtMonto.Clear() : txtReferencia.Clear() : txtObservacion.Clear()
                CargarDatosPago()
                If idSocioSeleccionado.HasValue Then CargarMembresias(idMembresiaPagoSeleccionada)
            End If
        Catch ex As Exception
            MostrarError("No se pudo registrar el pago.", ex)
        End Try
    End Sub

    Private Sub btnAnularPago_Click(sender As Object, e As EventArgs) Handles btnAnularPago.Click
        If dgvPagos.CurrentRow Is Nothing OrElse dgvPagos.CurrentRow.Tag Is Nothing Then MostrarAviso("Seleccione un pago para anular.") : Return
        If dgvPagos.CurrentRow.Cells("colEstadoPago").Value.ToString() = "ANULADO" Then MostrarAviso("El pago seleccionado ya está anulado.") : Return
        If MessageBox.Show("¿Desea anular el pago seleccionado?", "Confirmar anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        Try
            If pagoDAO.AnularPago(Convert.ToInt32(dgvPagos.CurrentRow.Tag)) Then
                CargarDatosPago()
                If idSocioSeleccionado.HasValue Then CargarMembresias(idMembresiaPagoSeleccionada)
            End If
        Catch ex As Exception
            MostrarError("No se pudo anular el pago.", ex)
        End Try
    End Sub

    Private Function ObtenerIdMembresiaGrid() As Integer?
        If dgvMembresias.CurrentRow Is Nothing OrElse dgvMembresias.CurrentRow.DataBoundItem Is Nothing Then Return Nothing
        Dim vista As DataRowView = TryCast(dgvMembresias.CurrentRow.DataBoundItem, DataRowView)
        If vista Is Nothing Then Return Nothing
        Return Convert.ToInt32(vista("id_membresia"))
    End Function

    Private Function ObtenerIdMembresiaCombo() As Integer?
        If cboMembresiaPago.SelectedValue Is Nothing OrElse TypeOf cboMembresiaPago.SelectedValue Is DataRowView Then Return Nothing
        Dim id As Integer
        If Integer.TryParse(cboMembresiaPago.SelectedValue.ToString(), id) Then Return id
        Return Nothing
    End Function

    Private Sub LimpiarDatosSocio()
        lblSocio.Text = "Socio:"
        dgvMembresias.DataSource = Nothing
        cboMembresiaPago.DataSource = Nothing
        dgvPagos.Rows.Clear()
        idMembresiaPagoSeleccionada = Nothing
        ActualizarEstadoSocio(New DataTable())
        ActualizarTotales(Nothing)
    End Sub

    Private Shared Function FormatearMoneda(valor As Decimal) As String
        Return "C$ " & valor.ToString("N2", CultureInfo.CurrentCulture)
    End Function

    Private Shared Sub MostrarAviso(mensaje As String)
        MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Shared Sub MostrarError(mensaje As String, ex As Exception)
        MessageBox.Show(mensaje & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub txtCedula_TextChanged(sender As Object, e As EventArgs) Handles txtCedula.TextChanged
    End Sub

    Private Sub lblHistorialMembresias_Click(sender As Object, e As EventArgs) Handles lblHistorialMembresias.Click
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTotalTitulo.Click
    End Sub
End Class
