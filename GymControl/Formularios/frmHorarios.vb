Imports System.Data
Imports System.Drawing.Printing

Public Class frmHorarios

    Private ReadOnly horarioDAO As New HorarioDAO()
    Private ReadOnly instructorDAO As New InstructorDAO()
    Private ReadOnly catalogoDAO As New CatalogoDAO()

    Private idHorarioSeleccionado As Integer
    Private limpiandoDetalle As Boolean

    ' Estado de la impresión del horario semanal
    Private tablaImpresion As DataTable
    Private indiceImpresion As Integer
    Private diaImpresionAnterior As Integer

    Private Sub frmHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarFormulario()
        CargarCombos()
        CargarHorarios()
    End Sub

    Private Sub ConfigurarFormulario()
        dgvHorario.ReadOnly = True
        dgvHorario.AllowUserToAddRows = False
        dgvHorario.AllowUserToDeleteRows = False
        dgvHorario.MultiSelect = False
        dgvHorario.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvHorario.RowHeadersVisible = False
        dgvHorario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        cboInstructor.DropDownStyle = ComboBoxStyle.DropDownList
        cboActividad.DropDownStyle = ComboBoxStyle.DropDownList
        cboSala.DropDownStyle = ComboBoxStyle.DropDownList
        cboDia.DropDownStyle = ComboBoxStyle.DropDownList

        cboDia.Items.Clear()
        cboDia.Items.AddRange(New String() {"Lunes", "Martes", "Miércoles", "Jueves",
                                            "Viernes", "Sábado", "Domingo"})

        dtpHoraInicio.Value = Date.Today.AddHours(6)
        dtpHoraFin.Value = Date.Today.AddHours(7)
    End Sub

    Private Sub CargarCombos()
        Try
            Dim dtInstructores As DataTable = instructorDAO.ListarParaCombo()
            cboInstructor.DisplayMember = "nombre"
            cboInstructor.ValueMember = "id_instructor"
            cboInstructor.DataSource = dtInstructores

            Dim dtActividades As DataTable = catalogoDAO.ListarActividadesParaCombo()
            cboActividad.DisplayMember = "nombre"
            cboActividad.ValueMember = "id_actividad"
            cboActividad.DataSource = dtActividades

            Dim dtSalas As DataTable = catalogoDAO.ListarSalasParaCombo()
            cboSala.DisplayMember = "nombre"
            cboSala.ValueMember = "id_sala"
            cboSala.DataSource = dtSalas

            ' Combos de filtro con fila "Todos/Todas" (id = 0)
            Dim dtFiltroInstructores As DataTable = dtInstructores.Copy()
            Dim filaInstructor As DataRow = dtFiltroInstructores.NewRow()
            filaInstructor("id_instructor") = 0
            filaInstructor("nombre") = "Todos"
            dtFiltroInstructores.Rows.InsertAt(filaInstructor, 0)
            cboFiltroInstructor.DisplayMember = "nombre"
            cboFiltroInstructor.ValueMember = "id_instructor"
            cboFiltroInstructor.DataSource = dtFiltroInstructores
            cboFiltroInstructor.SelectedValue = 0

            Dim dtFiltroSalas As DataTable = dtSalas.Copy()
            Dim filaSala As DataRow = dtFiltroSalas.NewRow()
            filaSala("id_sala") = 0
            filaSala("nombre") = "Todas"
            dtFiltroSalas.Rows.InsertAt(filaSala, 0)
            cboFiltroSala.DisplayMember = "nombre"
            cboFiltroSala.ValueMember = "id_sala"
            cboFiltroSala.DataSource = dtFiltroSalas
            cboFiltroSala.SelectedValue = 0
        Catch ex As Exception
            MessageBox.Show("No se pudieron cargar los catálogos del formulario." & Environment.NewLine &
                            Environment.NewLine & ex.Message,
                            "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarHorarios(Optional idSeleccionado As Integer? = Nothing)
        Try
            dgvHorario.DataSource = horarioDAO.ListarHorarios(
                IdFiltroSeleccionado(cboFiltroInstructor),
                IdFiltroSeleccionado(cboFiltroSala))
            ConfigurarColumnas()

            If dgvHorario.Rows.Count = 0 Then
                RestablecerDetalle()
            ElseIf idSeleccionado.HasValue Then
                SeleccionarFila(idSeleccionado.Value)
                ' Asegura el refresco del detalle aunque la fila ya sea la actual.
                CargarHorario(idSeleccionado.Value)
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudieron cargar los horarios." & Environment.NewLine & Environment.NewLine & ex.Message,
                            "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConfigurarColumnas()
        For Each nombre As String In New String() {"id_horario", "id_instructor", "id_actividad",
                                                    "id_sala", "dia_semana"}
            If dgvHorario.Columns.Contains(nombre) Then dgvHorario.Columns(nombre).Visible = False
        Next

        If dgvHorario.Columns.Contains("Dia") Then dgvHorario.Columns("Dia").HeaderText = "Día"
        If dgvHorario.Columns.Contains("HoraInicio") Then dgvHorario.Columns("HoraInicio").HeaderText = "Hora inicio"
        If dgvHorario.Columns.Contains("HoraFin") Then dgvHorario.Columns("HoraFin").HeaderText = "Hora fin"

        ' Proporciones de las columnas visibles: Día, horas, actividad, instructor, sala, estado
        Dim pesos As New Dictionary(Of String, Integer) From {
            {"Dia", 80}, {"HoraInicio", 85}, {"HoraFin", 85},
            {"Actividad", 150}, {"Instructor", 170}, {"Sala", 130}, {"Estado", 70}
        }
        For Each par In pesos
            If dgvHorario.Columns.Contains(par.Key) Then
                dgvHorario.Columns(par.Key).FillWeight = par.Value
            End If
        Next
    End Sub

    Private Sub SeleccionarFila(idHorario As Integer)
        For Each fila As DataGridViewRow In dgvHorario.Rows
            If fila.IsNewRow Then Continue For
            Dim valor As Object = fila.Cells("id_horario").Value
            If valor Is Nothing OrElse IsDBNull(valor) Then Continue For
            If Convert.ToInt32(valor) <> idHorario Then Continue For

            For Each celda As DataGridViewCell In fila.Cells
                If celda.Visible Then
                    dgvHorario.CurrentCell = celda
                    Exit For
                End If
            Next
            Exit For
        Next
    End Sub

    Private Function IdFiltroSeleccionado(cbo As ComboBox) As Integer?
        If cbo.SelectedValue Is Nothing Then Return Nothing
        If TypeOf cbo.SelectedValue Is DataRowView Then Return Nothing

        Dim id As Integer
        If Integer.TryParse(cbo.SelectedValue.ToString(), id) AndAlso id > 0 Then Return id
        Return Nothing
    End Function

    ' =========================================================
    ' DETALLE
    ' =========================================================
    Private Sub dgvHorario_SelectionChanged(sender As Object, e As EventArgs) Handles dgvHorario.SelectionChanged
        If limpiandoDetalle Then Return
        If dgvHorario.CurrentRow Is Nothing OrElse dgvHorario.CurrentRow.IsNewRow Then Return
        If Not dgvHorario.Columns.Contains("id_horario") Then Return

        Dim valor As Object = dgvHorario.CurrentRow.Cells("id_horario").Value
        If valor Is Nothing OrElse IsDBNull(valor) Then Return

        CargarHorario(Convert.ToInt32(valor))
    End Sub

    Private Sub CargarHorario(idHorario As Integer)
        Try
            Dim horario As DataRow = horarioDAO.ObtenerHorarioPorId(idHorario)
            If horario Is Nothing Then Return

            idHorarioSeleccionado = idHorario

            If cboInstructor.DataSource IsNot Nothing Then
                cboInstructor.SelectedValue = Convert.ToInt32(horario("id_instructor"))
            End If
            If cboActividad.DataSource IsNot Nothing Then
                cboActividad.SelectedValue = Convert.ToInt32(horario("id_actividad"))
            End If
            If cboSala.DataSource IsNot Nothing Then
                cboSala.SelectedValue = Convert.ToInt32(horario("id_sala"))
            End If

            Dim dia As Integer = Convert.ToInt32(horario("dia_semana"))
            If dia >= 1 AndAlso dia <= cboDia.Items.Count Then
                cboDia.SelectedIndex = dia - 1
            End If

            dtpHoraInicio.Value = Date.Today.Add(ATimeSpan(horario("hora_inicio")))
            dtpHoraFin.Value = Date.Today.Add(ATimeSpan(horario("hora_fin")))
            chkActivo.Checked = Convert.ToBoolean(horario("activo"))
        Catch ex As Exception
            MessageBox.Show("No se pudieron cargar los datos del horario." & Environment.NewLine & Environment.NewLine & ex.Message,
                            "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RestablecerDetalle()
        limpiandoDetalle = True
        Try
            idHorarioSeleccionado = 0
            dgvHorario.ClearSelection()
            cboInstructor.SelectedIndex = -1
            cboActividad.SelectedIndex = -1
            cboSala.SelectedIndex = -1
            cboDia.SelectedIndex = -1
            dtpHoraInicio.Value = Date.Today.AddHours(6)
            dtpHoraFin.Value = Date.Today.AddHours(7)
            chkActivo.Checked = True
        Finally
            limpiandoDetalle = False
        End Try
    End Sub

    Private Shared Function ATimeSpan(valor As Object) As TimeSpan
        If valor Is Nothing OrElse IsDBNull(valor) Then Return TimeSpan.Zero
        If TypeOf valor Is TimeSpan Then Return DirectCast(valor, TimeSpan)
        If TypeOf valor Is DateTime Then Return DirectCast(valor, DateTime).TimeOfDay

        Dim resultado As TimeSpan
        If TimeSpan.TryParse(valor.ToString(), Globalization.CultureInfo.InvariantCulture, resultado) Then
            Return resultado
        End If
        Return TimeSpan.Zero
    End Function

    ' =========================================================
    ' FILTROS
    ' =========================================================
    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        CargarHorarios()
    End Sub

    ' =========================================================
    ' BOTONES DEL DETALLE
    ' =========================================================
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        RestablecerDetalle()
        cboInstructor.Focus()
    End Sub

    Private Function ValidarDetalle(ByRef idInstructor As Integer, ByRef idActividad As Integer,
                                    ByRef idSala As Integer, ByRef dia As Integer,
                                    ByRef horaInicio As TimeSpan, ByRef horaFin As TimeSpan) As Boolean
        If cboInstructor.SelectedValue Is Nothing OrElse TypeOf cboInstructor.SelectedValue Is DataRowView Then
            MessageBox.Show("Debe seleccionar un instructor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboInstructor.Focus()
            Return False
        End If
        If cboActividad.SelectedValue Is Nothing OrElse TypeOf cboActividad.SelectedValue Is DataRowView Then
            MessageBox.Show("Debe seleccionar una actividad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboActividad.Focus()
            Return False
        End If
        If cboSala.SelectedValue Is Nothing OrElse TypeOf cboSala.SelectedValue Is DataRowView Then
            MessageBox.Show("Debe seleccionar una sala.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboSala.Focus()
            Return False
        End If
        If cboDia.SelectedIndex < 0 Then
            MessageBox.Show("Debe seleccionar el día de la semana.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboDia.Focus()
            Return False
        End If

        idInstructor = Convert.ToInt32(cboInstructor.SelectedValue)
        idActividad = Convert.ToInt32(cboActividad.SelectedValue)
        idSala = Convert.ToInt32(cboSala.SelectedValue)
        dia = cboDia.SelectedIndex + 1
        horaInicio = dtpHoraInicio.Value.TimeOfDay
        horaFin = dtpHoraFin.Value.TimeOfDay

        If horaFin <= horaInicio Then
            MessageBox.Show("La hora de fin debe ser posterior a la hora de inicio.",
                            "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpHoraFin.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim idInstructor As Integer
        Dim idActividad As Integer
        Dim idSala As Integer
        Dim dia As Integer
        Dim horaInicio As TimeSpan
        Dim horaFin As TimeSpan

        If Not ValidarDetalle(idInstructor, idActividad, idSala, dia, horaInicio, horaFin) Then Return

        Dim esEdicion As Boolean = idHorarioSeleccionado > 0

        Try
            Dim conflicto As String = horarioDAO.VerificarConflictos(
                idInstructor, idSala, dia, horaInicio, horaFin,
                If(esEdicion, CType(idHorarioSeleccionado, Integer?), Nothing))

            If conflicto <> "" Then
                MessageBox.Show(conflicto, "Conflicto de horario", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim guardado As Boolean
            If esEdicion Then
                guardado = horarioDAO.ActualizarHorario(idHorarioSeleccionado, idInstructor, idActividad,
                                                        idSala, dia, horaInicio, horaFin, chkActivo.Checked)
            Else
                guardado = horarioDAO.InsertarHorario(idInstructor, idActividad, idSala, dia,
                                                      horaInicio, horaFin, chkActivo.Checked)
            End If

            If guardado Then
                MessageBox.Show(If(esEdicion, "Horario actualizado correctamente.", "Horario registrado correctamente."),
                                "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If esEdicion Then
                    CargarHorarios(idHorarioSeleccionado)
                Else
                    CargarHorarios()
                    RestablecerDetalle()
                End If
            Else
                MessageBox.Show("No se realizaron cambios en el horario.", "GymControl",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo guardar el horario." & Environment.NewLine & Environment.NewLine & ex.Message,
                            "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idHorarioSeleccionado = 0 Then
            MessageBox.Show("Debe seleccionar un horario.", "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If MessageBox.Show("¿Desea eliminar el horario seleccionado? Esta acción no se puede deshacer.",
                           "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If

        Try
            If horarioDAO.EliminarHorario(idHorarioSeleccionado) Then
                MessageBox.Show("Horario eliminado correctamente.", "GymControl",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarHorarios()
                RestablecerDetalle()
            Else
                MessageBox.Show("El horario no existe o ya fue eliminado.", "GymControl",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar el horario." & Environment.NewLine & Environment.NewLine & ex.Message,
                            "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================================================
    ' IMPRESIÓN DE LA SEMANA
    ' =========================================================
    Private Sub btnImprimirSemana_Click(sender As Object, e As EventArgs) Handles btnImprimirSemana.Click
        Try
            tablaImpresion = horarioDAO.ListarHorarios(
                IdFiltroSeleccionado(cboFiltroInstructor),
                IdFiltroSeleccionado(cboFiltroSala),
                soloActivos:=True)

            If tablaImpresion.Rows.Count = 0 Then
                MessageBox.Show("No hay horarios activos para imprimir.", "GymControl",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Using documento As New PrintDocument()
                AddHandler documento.PrintPage, AddressOf Documento_PrintPage
                AddHandler documento.BeginPrint, AddressOf Documento_BeginPrint

                Using vista As New PrintPreviewDialog()
                    vista.Document = documento
                    vista.Text = "Vista previa - Horario semanal"
                    vista.StartPosition = FormStartPosition.CenterParent
                    vista.Width = 950
                    vista.Height = 700
                    vista.ShowDialog(Me)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("No se pudo generar la impresión del horario semanal." &
                            Environment.NewLine & Environment.NewLine & ex.Message,
                            "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Cada impresión (vista previa o real) comienza desde el inicio.
    Private Sub Documento_BeginPrint(sender As Object, e As PrintEventArgs)
        indiceImpresion = 0
        diaImpresionAnterior = -1
    End Sub

    Private Sub Documento_PrintPage(sender As Object, e As PrintPageEventArgs)
        Using titulo As New Font("Segoe UI", 16, FontStyle.Bold),
              subtitulo As New Font("Segoe UI", 9.0F),
              fuenteDia As New Font("Segoe UI", 11, FontStyle.Bold),
              fuenteFila As New Font("Segoe UI", 10),
              pincelGris As New SolidBrush(Color.FromArgb(96, 125, 139))

            Dim x As Single = e.MarginBounds.Left
            Dim y As Single = e.MarginBounds.Top
            Dim limiteInferior As Single = e.MarginBounds.Bottom

            If indiceImpresion = 0 Then
                e.Graphics.DrawString("Horario semanal", titulo, Brushes.Black, x, y)
                y += 32
                e.Graphics.DrawString("GymControl - Generado el " & Date.Now.ToString("dd/MM/yyyy HH:mm"),
                                      subtitulo, pincelGris, x, y)
                y += 28
            End If

            While indiceImpresion < tablaImpresion.Rows.Count
                Dim fila As DataRow = tablaImpresion.Rows(indiceImpresion)
                Dim dia As Integer = Convert.ToInt32(fila("dia_semana"))

                If dia <> diaImpresionAnterior Then
                    If y > limiteInferior - 50 Then Exit While
                    diaImpresionAnterior = dia
                    y += 8
                    e.Graphics.DrawString(fila("Dia").ToString(), fuenteDia, Brushes.Black, x, y)
                    y += 26
                End If

                If y > limiteInferior - 24 Then Exit While

                Dim texto As String =
                    fila("HoraInicio").ToString() & " - " & fila("HoraFin").ToString().PadRight(6) &
                    "    " & fila("Actividad").ToString() &
                    "    " & fila("Instructor").ToString() &
                    "    " & fila("Sala").ToString()

                e.Graphics.DrawString(texto, fuenteFila, Brushes.Black, x, y)
                y += 22
                indiceImpresion += 1
            End While

            e.HasMorePages = indiceImpresion < tablaImpresion.Rows.Count
        End Using
    End Sub

End Class
