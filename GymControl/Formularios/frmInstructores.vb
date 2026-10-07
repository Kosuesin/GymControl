Public Class frmInstructores

    Private ReadOnly instructorDAO As New InstructorDAO()
    Private modoEdicion As Boolean
    Private idInstructorSeleccionado As Integer

    Private Sub frmInstructores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarFormulario()
        CargarInstructores()
        ModoConsulta()
    End Sub

    Private Sub ConfigurarFormulario()
        cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDown
        cboEspecialidad.Items.Clear()
        cboEspecialidad.Items.AddRange(New String() {
            "Musculación y hipertrofia", "Cardio y resistencia", "Yoga", "Pilates",
            "Spinning", "Cross training", "Boxeo", "Artes marciales", "Natación", "Rehabilitación"})

        dtpFechaContratacion.ShowCheckBox = True
        dtpFechaContratacion.Format = DateTimePickerFormat.Short

        txtId.ReadOnly = True

        dgvInstructores.ReadOnly = True
        dgvInstructores.AllowUserToAddRows = False
        dgvInstructores.AllowUserToDeleteRows = False
        dgvInstructores.MultiSelect = False
        dgvInstructores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub CargarInstructores()
        Try
            dgvInstructores.DataSource = instructorDAO.ListarInstructores(txtBuscar.Text)
            ConfigurarColumnas()
            dgvInstructores.ClearSelection()
        Catch ex As Exception
            MessageBox.Show("No se pudieron cargar los instructores." & Environment.NewLine & Environment.NewLine & ex.Message,
                            "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConfigurarColumnas()
        If dgvInstructores.Columns.Contains("id_instructor") Then dgvInstructores.Columns("id_instructor").Visible = False
        If dgvInstructores.Columns.Contains("cedula") Then dgvInstructores.Columns("cedula").HeaderText = "Cédula"
        If dgvInstructores.Columns.Contains("Nombre") Then dgvInstructores.Columns("Nombre").HeaderText = "Instructor"
        If dgvInstructores.Columns.Contains("telefono") Then dgvInstructores.Columns("telefono").HeaderText = "Teléfono"
        If dgvInstructores.Columns.Contains("especialidad") Then dgvInstructores.Columns("especialidad").HeaderText = "Especialidad"
        If dgvInstructores.Columns.Contains("Estado") Then dgvInstructores.Columns("Estado").HeaderText = "Estado"
    End Sub

    Private Sub ModoConsulta()
        modoEdicion = False
        grpDatos.Enabled = False
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnEditar.Enabled = idInstructorSeleccionado > 0
        btnEliminar.Enabled = idInstructorSeleccionado > 0
        btnNuevo.Enabled = True
    End Sub

    Private Sub ModoNuevo()
        modoEdicion = False
        idInstructorSeleccionado = 0
        LimpiarCampos()
        grpDatos.Enabled = True
        chkActivo.Checked = True
        dtpFechaContratacion.Checked = True
        dtpFechaContratacion.Value = Date.Today
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnNuevo.Enabled = False
        dgvInstructores.ClearSelection()
        txtCedula.Focus()
    End Sub

    Private Sub ModoEditar()
        If idInstructorSeleccionado = 0 Then
            MessageBox.Show("Debe seleccionar un instructor.", "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        modoEdicion = True
        grpDatos.Enabled = True
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnNuevo.Enabled = False
        txtCedula.Focus()
    End Sub

    Private Sub LimpiarCampos()
        txtId.Clear()
        txtCedula.Clear()
        txtNombres.Clear()
        txtApellidos.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        cboEspecialidad.SelectedIndex = -1
        cboEspecialidad.Text = ""
        dtpFechaContratacion.Checked = False
        dtpFechaContratacion.Value = Date.Today
        chkActivo.Checked = True
    End Sub

    Private Function ValidarDatos(ByRef cedula As String, ByRef nombres As String, ByRef apellidos As String,
                                  ByRef correo As String) As Boolean
        cedula = txtCedula.Text.Trim()
        nombres = txtNombres.Text.Trim()
        apellidos = txtApellidos.Text.Trim()
        correo = txtCorreo.Text.Trim()

        txtCedula.Text = cedula
        txtNombres.Text = nombres
        txtApellidos.Text = apellidos
        txtCorreo.Text = correo

        If nombres = "" Then
            MessageBox.Show("Los nombres son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombres.Focus()
            Return False
        End If
        If apellidos = "" Then
            MessageBox.Show("Los apellidos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtApellidos.Focus()
            Return False
        End If
        If correo <> "" Then
            Try
                Dim correoValidado As New System.Net.Mail.MailAddress(correo)
                If correoValidado.Address <> correo Then Throw New FormatException()
            Catch ex As FormatException
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCorreo.Focus()
                Return False
            End Try
        End If

        Return True
    End Function

    Private Sub dgvInstructores_SelectionChanged(sender As Object, e As EventArgs) Handles dgvInstructores.SelectionChanged
        ' No alterar el panel mientras se está creando o editando un registro.
        If modoEdicion OrElse btnGuardar.Enabled Then Return
        If dgvInstructores.CurrentRow Is Nothing Then Return
        If Not dgvInstructores.Columns.Contains("id_instructor") Then Return

        Dim valor As Object = dgvInstructores.CurrentRow.Cells("id_instructor").Value
        If valor Is Nothing OrElse IsDBNull(valor) Then Return

        CargarInstructor(Convert.ToInt32(valor))
    End Sub

    Private Sub CargarInstructor(idInstructor As Integer)
        Try
            Dim instructor As DataRow = instructorDAO.ObtenerInstructorPorId(idInstructor)
            If instructor Is Nothing Then Return

            idInstructorSeleccionado = Convert.ToInt32(instructor("id_instructor"))
            txtId.Text = idInstructorSeleccionado.ToString()
            txtCedula.Text = If(instructor.IsNull("cedula"), "", instructor("cedula").ToString())
            txtNombres.Text = instructor("nombres").ToString()
            txtApellidos.Text = instructor("apellidos").ToString()
            txtTelefono.Text = If(instructor.IsNull("telefono"), "", instructor("telefono").ToString())
            txtCorreo.Text = If(instructor.IsNull("correo"), "", instructor("correo").ToString())
            cboEspecialidad.Text = If(instructor.IsNull("especialidad"), "", instructor("especialidad").ToString())

            If instructor.IsNull("fecha_contratacion") Then
                dtpFechaContratacion.Checked = False
                dtpFechaContratacion.Value = Date.Today
            Else
                dtpFechaContratacion.Value = Convert.ToDateTime(instructor("fecha_contratacion"))
                dtpFechaContratacion.Checked = True
            End If

            chkActivo.Checked = Convert.ToBoolean(instructor("activo"))
            ModoConsulta()
        Catch ex As Exception
            MessageBox.Show("No se pudieron cargar los datos del instructor." & Environment.NewLine & Environment.NewLine & ex.Message,
                            "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        CargarInstructores()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ModoNuevo()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        ModoEditar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim cedula As String = ""
        Dim nombres As String = ""
        Dim apellidos As String = ""
        Dim correo As String = ""
        If Not ValidarDatos(cedula, nombres, apellidos, correo) Then Return

        Try
            If cedula <> "" AndAlso
                instructorDAO.ExisteCedula(cedula, If(modoEdicion, CType(idInstructorSeleccionado, Integer?), Nothing)) Then
                MessageBox.Show("Ya existe un instructor con esa cédula.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCedula.Focus()
                Return
            End If

            Dim fechaContratacion As DateTime? = Nothing
            If dtpFechaContratacion.Checked Then fechaContratacion = dtpFechaContratacion.Value.Date

            Dim guardado As Boolean
            If modoEdicion Then
                guardado = instructorDAO.ActualizarInstructor(idInstructorSeleccionado, cedula, nombres, apellidos,
                                                              txtTelefono.Text.Trim(), correo, cboEspecialidad.Text.Trim(),
                                                              fechaContratacion, chkActivo.Checked)
            Else
                guardado = instructorDAO.InsertarInstructor(cedula, nombres, apellidos,
                                                            txtTelefono.Text.Trim(), correo, cboEspecialidad.Text.Trim(),
                                                            fechaContratacion, chkActivo.Checked)
            End If

            If guardado Then
                MessageBox.Show(If(modoEdicion, "Instructor actualizado correctamente.", "Instructor registrado correctamente."),
                                "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarInstructores()
                LimpiarCampos()
                idInstructorSeleccionado = 0
                ModoConsulta()
            Else
                MessageBox.Show("No se realizaron cambios en el instructor.", "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As MySqlConnector.MySqlException When ex.Number = 1062
            MessageBox.Show("La cédula ya está registrada.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("No se pudo guardar el instructor." & Environment.NewLine & Environment.NewLine & ex.Message,
                            "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idInstructorSeleccionado = 0 Then
            MessageBox.Show("Debe seleccionar un instructor.", "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not chkActivo.Checked Then
            MessageBox.Show("El instructor ya está inactivo.", "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If MessageBox.Show("¿Desea dar de baja al instructor seleccionado?", "Confirmar baja",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

        Try
            If instructorDAO.DesactivarInstructor(idInstructorSeleccionado) Then
                MessageBox.Show("Instructor dado de baja correctamente.", "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarInstructores()
                LimpiarCampos()
                idInstructorSeleccionado = 0
                ModoConsulta()
            Else
                MessageBox.Show("El instructor ya estaba inactivo o no existe.", "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo dar de baja al instructor." & Environment.NewLine & Environment.NewLine & ex.Message,
                            "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarCampos()
        idInstructorSeleccionado = 0
        dgvInstructores.ClearSelection()
        ModoConsulta()
    End Sub

End Class
