Public Class frmSalas

    Private ReadOnly catalogoDAO As New CatalogoDAO()

    Private idSalaSeleccionada As Integer = 0
    Private limpiandoDetalle As Boolean = False

    Private Sub frmSalas_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ConfigurarFormulario()
        CargarSalas()
        RestablecerDetalle()

    End Sub

    Private Sub ConfigurarFormulario()

        dgvSalas.ReadOnly = True
        dgvSalas.AllowUserToAddRows = False
        dgvSalas.AllowUserToDeleteRows = False
        dgvSalas.MultiSelect = False
        dgvSalas.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect
        dgvSalas.RowHeadersVisible = False
        dgvSalas.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        nudCapacidad.Minimum = 1
        nudCapacidad.Maximum = 1000

    End Sub

    Private Sub CargarSalas(
        Optional idSeleccionado As Integer? = Nothing
    )

        Try
            dgvSalas.DataSource =
                catalogoDAO.ListarSalas()

            ConfigurarColumnas()

            If dgvSalas.Rows.Count = 0 Then
                RestablecerDetalle()
            ElseIf idSeleccionado.HasValue Then
                SeleccionarFila(idSeleccionado.Value)
            End If

        Catch ex As Exception

            MessageBox.Show(
                "No se pudieron cargar las salas." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub ConfigurarColumnas()

        If dgvSalas.Columns.Contains("id_sala") Then
            dgvSalas.Columns("id_sala").Visible = False
        End If

        If dgvSalas.Columns.Contains("nombre") Then
            dgvSalas.Columns("nombre").HeaderText = "Nombre"
        End If

        If dgvSalas.Columns.Contains("capacidad") Then
            dgvSalas.Columns("capacidad").HeaderText = "Capacidad"
        End If

        If dgvSalas.Columns.Contains("Estado") Then
            dgvSalas.Columns("Estado").HeaderText = "Estado"
        End If

    End Sub

    Private Sub SeleccionarFila(idSala As Integer)

        For Each fila As DataGridViewRow In dgvSalas.Rows

            If fila.IsNewRow Then Continue For

            Dim valor As Object =
                fila.Cells("id_sala").Value

            If valor Is Nothing OrElse IsDBNull(valor) Then
                Continue For
            End If

            If Convert.ToInt32(valor) <> idSala Then
                Continue For
            End If

            dgvSalas.CurrentCell =
                fila.Cells("nombre")

            Exit For

        Next

    End Sub

    Private Sub dgvSalas_SelectionChanged(
        sender As Object,
        e As EventArgs
    ) Handles dgvSalas.SelectionChanged

        If limpiandoDetalle Then Return
        If dgvSalas.CurrentRow Is Nothing Then Return
        If dgvSalas.CurrentRow.IsNewRow Then Return

        Dim valor As Object =
            dgvSalas.CurrentRow.Cells("id_sala").Value

        If valor Is Nothing OrElse IsDBNull(valor) Then Return

        CargarSala(Convert.ToInt32(valor))

    End Sub

    Private Sub CargarSala(idSala As Integer)

        Try
            Dim sala As DataRow =
                catalogoDAO.ObtenerSalaPorId(idSala)

            If sala Is Nothing Then Return

            idSalaSeleccionada = idSala

            txtNombre.Text =
                Convert.ToString(sala("nombre"))

            nudCapacidad.Value =
                Convert.ToDecimal(sala("capacidad"))

            chkActivo.Checked =
                Convert.ToBoolean(sala("activo"))

        Catch ex As Exception

            MessageBox.Show(
                "No se pudieron cargar los datos de la sala." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub RestablecerDetalle()

        limpiandoDetalle = True

        Try
            idSalaSeleccionada = 0

            dgvSalas.ClearSelection()

            txtNombre.Clear()
            nudCapacidad.Value = 1
            chkActivo.Checked = True

        Finally
            limpiandoDetalle = False
        End Try

    End Sub

    Private Function ValidarDetalle() As Boolean

        If String.IsNullOrWhiteSpace(txtNombre.Text) Then

            MessageBox.Show(
                "Debe ingresar el nombre de la sala.",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtNombre.Focus()
            Return False

        End If

        If txtNombre.Text.Trim().Length > 40 Then

            MessageBox.Show(
                "El nombre de la sala no puede superar " &
                "los 40 caracteres.",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtNombre.Focus()
            Return False

        End If

        Return True

    End Function

    Private Sub btnNuevo_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNuevo.Click

        RestablecerDetalle()
        txtNombre.Focus()

    End Sub

    Private Sub btnGuardar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnGuardar.Click

        If Not ValidarDetalle() Then Return

        Dim nombre As String =
            txtNombre.Text.Trim()

        Dim capacidad As Integer =
            Convert.ToInt32(nudCapacidad.Value)

        Dim esEdicion As Boolean =
            idSalaSeleccionada > 0

        Try

            Dim excluirId As Integer? = Nothing

            If esEdicion Then
                excluirId = idSalaSeleccionada
            End If

            If catalogoDAO.ExisteNombreSala(
                nombre,
                excluirId
            ) Then

                MessageBox.Show(
                    "Ya existe una sala con ese nombre.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                txtNombre.Focus()
                txtNombre.SelectAll()
                Return

            End If

            Dim guardado As Boolean

            If esEdicion Then

                guardado =
                    catalogoDAO.ActualizarSala(
                        idSalaSeleccionada,
                        nombre,
                        capacidad,
                        chkActivo.Checked
                    )

            Else

                guardado =
                    catalogoDAO.InsertarSala(
                        nombre,
                        capacidad,
                        chkActivo.Checked
                    )

            End If

            If guardado Then

                MessageBox.Show(
                    If(
                        esEdicion,
                        "Sala actualizada correctamente.",
                        "Sala registrada correctamente."
                    ),
                    "GymControl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                If esEdicion Then
                    CargarSalas(idSalaSeleccionada)
                Else
                    CargarSalas()
                    RestablecerDetalle()
                End If

            Else

                MessageBox.Show(
                    "No se realizaron cambios en la sala.",
                    "GymControl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

            End If

        Catch ex As Exception

            MessageBox.Show(
                "No se pudo guardar la sala." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnDesactivar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDesactivar.Click

        If idSalaSeleccionada = 0 Then

            MessageBox.Show(
                "Debe seleccionar una sala.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If

        If MessageBox.Show(
            "¿Desea desactivar la sala seleccionada?",
            "Confirmar desactivación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        ) <> DialogResult.Yes Then

            Return

        End If

        Try

            If catalogoDAO.DesactivarSala(
                idSalaSeleccionada
            ) Then

                MessageBox.Show(
                    "Sala desactivada correctamente.",
                    "GymControl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                CargarSalas()
                RestablecerDetalle()

            Else

                MessageBox.Show(
                    "La sala ya se encuentra inactiva.",
                    "GymControl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            End If

        Catch ex As Exception

            MessageBox.Show(
                "No se pudo desactivar la sala." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

End Class