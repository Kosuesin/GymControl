Public Class frmActividades

    Private ReadOnly catalogoDAO As New CatalogoDAO()

    Private idActividadSeleccionada As Integer = 0
    Private limpiandoDetalle As Boolean = False

    Private Sub frmActividades_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ConfigurarFormulario()
        CargarActividades()
        RestablecerDetalle()

    End Sub

    Private Sub ConfigurarFormulario()

        dgvActividades.ReadOnly = True
        dgvActividades.AllowUserToAddRows = False
        dgvActividades.AllowUserToDeleteRows = False
        dgvActividades.MultiSelect = False
        dgvActividades.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect
        dgvActividades.RowHeadersVisible = False
        dgvActividades.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        nudDuracion.Minimum = 1
        nudDuracion.Maximum = 1440

        nudCupoMaximo.Minimum = 1
        nudCupoMaximo.Maximum = 1000

    End Sub

    Private Sub CargarActividades(
        Optional idSeleccionado As Integer? = Nothing
    )

        Try

            dgvActividades.DataSource =
                catalogoDAO.ListarActividades()

            ConfigurarColumnas()

            If dgvActividades.Rows.Count = 0 Then

                RestablecerDetalle()

            ElseIf idSeleccionado.HasValue Then

                SeleccionarFila(idSeleccionado.Value)

            End If

        Catch ex As Exception

            MessageBox.Show(
                "No se pudieron cargar las actividades." &
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

        If dgvActividades.Columns.Contains("id_actividad") Then
            dgvActividades.Columns("id_actividad").Visible = False
        End If

        If dgvActividades.Columns.Contains("nombre") Then
            dgvActividades.Columns("nombre").HeaderText =
                "Nombre"
        End If

        If dgvActividades.Columns.Contains("descripcion") Then
            dgvActividades.Columns("descripcion").HeaderText =
                "Descripción"
        End If

        If dgvActividades.Columns.Contains("duracion_min") Then
            dgvActividades.Columns("duracion_min").HeaderText =
                "Duración (min)"
        End If

        If dgvActividades.Columns.Contains("cupo_maximo") Then
            dgvActividades.Columns("cupo_maximo").HeaderText =
                "Cupo máximo"
        End If

        If dgvActividades.Columns.Contains("Estado") Then
            dgvActividades.Columns("Estado").HeaderText =
                "Estado"
        End If

    End Sub

    Private Sub SeleccionarFila(idActividad As Integer)

        For Each fila As DataGridViewRow In dgvActividades.Rows

            If fila.IsNewRow Then Continue For

            Dim valor As Object =
                fila.Cells("id_actividad").Value

            If valor Is Nothing OrElse IsDBNull(valor) Then
                Continue For
            End If

            If Convert.ToInt32(valor) <> idActividad Then
                Continue For
            End If

            dgvActividades.CurrentCell =
                fila.Cells("nombre")

            Exit For

        Next

    End Sub

    Private Sub dgvActividades_SelectionChanged(
        sender As Object,
        e As EventArgs
    ) Handles dgvActividades.SelectionChanged

        If limpiandoDetalle Then Return

        If dgvActividades.CurrentRow Is Nothing Then
            Return
        End If

        If dgvActividades.CurrentRow.IsNewRow Then
            Return
        End If

        Dim valor As Object =
            dgvActividades.CurrentRow.Cells(
                "id_actividad"
            ).Value

        If valor Is Nothing OrElse IsDBNull(valor) Then
            Return
        End If

        CargarActividad(
            Convert.ToInt32(valor)
        )

    End Sub

    Private Sub CargarActividad(idActividad As Integer)

        Try

            Dim actividad As DataRow =
                catalogoDAO.ObtenerActividadPorId(
                    idActividad
                )

            If actividad Is Nothing Then Return

            idActividadSeleccionada = idActividad

            txtNombre.Text =
                Convert.ToString(
                    actividad("nombre")
                )

            txtDescripcion.Text =
                Convert.ToString(
                    actividad("descripcion")
                )

            nudDuracion.Value =
                Convert.ToDecimal(
                    actividad("duracion_min")
                )

            nudCupoMaximo.Value =
                Convert.ToDecimal(
                    actividad("cupo_maximo")
                )

            chkActivo.Checked =
                Convert.ToBoolean(
                    actividad("activo")
                )

        Catch ex As Exception

            MessageBox.Show(
                "No se pudieron cargar los datos " &
                "de la actividad." &
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

            idActividadSeleccionada = 0

            dgvActividades.ClearSelection()

            txtNombre.Clear()
            txtDescripcion.Clear()

            nudDuracion.Value = 1
            nudCupoMaximo.Value = 1

            chkActivo.Checked = True

        Finally

            limpiandoDetalle = False

        End Try

    End Sub

    Private Function ValidarDetalle() As Boolean

        If String.IsNullOrWhiteSpace(
            txtNombre.Text
        ) Then

            MessageBox.Show(
                "Debe ingresar el nombre de la actividad.",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtNombre.Focus()
            Return False

        End If

        If txtNombre.Text.Trim().Length > 50 Then

            MessageBox.Show(
                "El nombre de la actividad no puede " &
                "superar los 50 caracteres.",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtNombre.Focus()
            Return False

        End If

        If txtDescripcion.Text.Trim().Length > 200 Then

            MessageBox.Show(
                "La descripción no puede superar " &
                "los 200 caracteres.",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtDescripcion.Focus()
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

        Dim descripcion As String =
            txtDescripcion.Text.Trim()

        Dim duracion As Integer =
            Convert.ToInt32(
                nudDuracion.Value
            )

        Dim cupoMaximo As Integer =
            Convert.ToInt32(
                nudCupoMaximo.Value
            )

        Dim esEdicion As Boolean =
            idActividadSeleccionada > 0

        Try

            Dim excluirId As Integer? = Nothing

            If esEdicion Then
                excluirId =
                    idActividadSeleccionada
            End If

            If catalogoDAO.ExisteNombreActividad(
                nombre,
                excluirId
            ) Then

                MessageBox.Show(
                    "Ya existe una actividad " &
                    "con ese nombre.",
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
                    catalogoDAO.ActualizarActividad(
                        idActividadSeleccionada,
                        nombre,
                        descripcion,
                        duracion,
                        cupoMaximo,
                        chkActivo.Checked
                    )

            Else

                guardado =
                    catalogoDAO.InsertarActividad(
                        nombre,
                        descripcion,
                        duracion,
                        cupoMaximo,
                        chkActivo.Checked
                    )

            End If

            If guardado Then

                MessageBox.Show(
                    If(
                        esEdicion,
                        "Actividad actualizada correctamente.",
                        "Actividad registrada correctamente."
                    ),
                    "GymControl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                If esEdicion Then

                    CargarActividades(
                        idActividadSeleccionada
                    )

                Else

                    CargarActividades()
                    RestablecerDetalle()

                End If

            Else

                MessageBox.Show(
                    "No se realizaron cambios " &
                    "en la actividad.",
                    "GymControl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

            End If

        Catch ex As Exception

            MessageBox.Show(
                "No se pudo guardar la actividad." &
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

        If idActividadSeleccionada = 0 Then

            MessageBox.Show(
                "Debe seleccionar una actividad.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If

        If MessageBox.Show(
            "¿Desea desactivar la actividad seleccionada?",
            "Confirmar desactivación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        ) <> DialogResult.Yes Then

            Return

        End If

        Try

            If catalogoDAO.DesactivarActividad(
                idActividadSeleccionada
            ) Then

                MessageBox.Show(
                    "Actividad desactivada correctamente.",
                    "GymControl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                CargarActividades()
                RestablecerDetalle()

            Else

                MessageBox.Show(
                    "La actividad ya se encuentra inactiva.",
                    "GymControl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            End If

        Catch ex As Exception

            MessageBox.Show(
                "No se pudo desactivar la actividad." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnSalas_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSalas.Click

        Using formulario As New frmSalas()
            formulario.ShowDialog(Me)
        End Using

    End Sub

End Class