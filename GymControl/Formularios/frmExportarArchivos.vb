Imports System.Data
Imports System.Diagnostics
Imports System.IO
Imports System.Threading.Tasks

Public Class frmExportarArchivos
    Inherits Form

    Private ReadOnly rdbCartera As New RadioButton()
    Private ReadOnly rdbInformeMensual As New RadioButton()
    Private ReadOnly rdbLibroAnual As New RadioButton()
    Private ReadOnly dtpMes As New DateTimePicker()
    Private ReadOnly nudAnio As New NumericUpDown()
    Private ReadOnly chkIncluirAlDia As New CheckBox()
    Private ReadOnly chkAbrirAlTerminar As New CheckBox()
    Private ReadOnly txtRuta As New TextBox()
    Private ReadOnly btnExaminar As New Button()
    Private ReadOnly btnGenerar As New Button()
    Private ReadOnly lblEstado As New Label()
    Private ReadOnly prgAvance As New ProgressBar()
    Private ReadOnly dao As New ReporteDAO()

    Public Sub New()
        Text = "GymControl - Exportar archivos"
        ClientSize = New Size(820, 400)
        StartPosition = FormStartPosition.CenterParent
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Font = New Font("Segoe UI", 10)
        ConstruirInterfaz()
        ActualizarOpciones()
    End Sub

    Private Sub ConstruirInterfaz()
        Dim titulo As New Label With {
            .Text = "Exportación de reportes",
            .Font = New Font("Segoe UI", 16, FontStyle.Bold),
            .Location = New Point(25, 16), .AutoSize = True
        }
        rdbCartera.Text = "R07 - Cartera de saldos (Excel)"
        rdbCartera.Location = New Point(30, 65)
        rdbCartera.AutoSize = True
        rdbCartera.Checked = True
        rdbInformeMensual.Text = "R08 - Informe gerencial mensual (PDF)"
        rdbInformeMensual.Location = New Point(30, 94)
        rdbInformeMensual.AutoSize = True
        rdbLibroAnual.Text = "R09 - Libro de ingresos anual (Excel)"
        rdbLibroAnual.Location = New Point(30, 123)
        rdbLibroAnual.AutoSize = True
        For Each radio In New RadioButton() {rdbCartera, rdbInformeMensual, rdbLibroAnual}
            AddHandler radio.CheckedChanged, AddressOf OpcionesCambiadas
        Next

        Dim lblMes As New Label With {.Text = "Mes del informe:", .Location = New Point(30, 161), .AutoSize = True}
        dtpMes.Location = New Point(168, 157)
        dtpMes.Width = 205
        dtpMes.Format = DateTimePickerFormat.Custom
        dtpMes.CustomFormat = "MMMM 'de' yyyy"
        dtpMes.ShowUpDown = True
        AddHandler dtpMes.ValueChanged, AddressOf OpcionesCambiadas

        Dim lblAnio As New Label With {.Text = "Año del libro:", .Location = New Point(420, 161), .AutoSize = True}
        nudAnio.Location = New Point(550, 157)
        nudAnio.Width = 100
        nudAnio.Minimum = 2024
        nudAnio.Maximum = Math.Max(2024, Date.Today.Year)
        nudAnio.Value = Math.Max(2024, Date.Today.Year)
        AddHandler nudAnio.ValueChanged, AddressOf OpcionesCambiadas

        chkIncluirAlDia.Text = "Incluir membresías al día"
        chkIncluirAlDia.Location = New Point(30, 200)
        chkIncluirAlDia.AutoSize = True
        chkAbrirAlTerminar.Text = "Abrir archivo al terminar"
        chkAbrirAlTerminar.Location = New Point(350, 200)
        chkAbrirAlTerminar.AutoSize = True
        chkAbrirAlTerminar.Checked = True

        txtRuta.Location = New Point(30, 252)
        txtRuta.Size = New Size(610, 27)
        txtRuta.ReadOnly = True
        btnExaminar.Text = "Examinar..."
        btnExaminar.Location = New Point(655, 250)
        btnExaminar.Size = New Size(125, 32)
        AddHandler btnExaminar.Click, AddressOf ExaminarArchivo
        btnGenerar.Text = "Generar archivo"
        btnGenerar.Location = New Point(620, 315)
        btnGenerar.Size = New Size(160, 38)
        AddHandler btnGenerar.Click, AddressOf GenerarArchivo
        prgAvance.Location = New Point(30, 320)
        prgAvance.Size = New Size(350, 20)
        prgAvance.Style = ProgressBarStyle.Marquee
        prgAvance.Visible = False
        lblEstado.Text = "Listo para generar."
        lblEstado.Location = New Point(30, 355)
        lblEstado.AutoSize = True

        Controls.AddRange(New Control() {
            titulo, rdbCartera, rdbInformeMensual, rdbLibroAnual,
            lblMes, dtpMes, lblAnio, nudAnio, chkIncluirAlDia,
            chkAbrirAlTerminar, txtRuta, btnExaminar,
            btnGenerar, prgAvance, lblEstado
        })
    End Sub

    Private Sub OpcionesCambiadas(sender As Object, e As EventArgs)
        ActualizarOpciones()
    End Sub

    Private Sub ActualizarOpciones()
        dtpMes.Enabled = rdbInformeMensual.Checked
        nudAnio.Enabled = rdbLibroAnual.Checked
        chkIncluirAlDia.Enabled = rdbCartera.Checked
        txtRuta.Clear()
    End Sub

    Private Function NombreSugerido() As String
        If rdbInformeMensual.Checked Then Return "Informe_" & dtpMes.Value.ToString("yyyy-MM") & ".pdf"
        If rdbLibroAnual.Checked Then Return "Ingresos_" & nudAnio.Value.ToString("0") & ".xlsx"
        Return "Cartera_" & Date.Today.ToString("yyyy-MM-dd") & ".xlsx"
    End Function

    Private Sub ExaminarArchivo(sender As Object, e As EventArgs)
        Using dialogo As New SaveFileDialog()
            dialogo.Title = "Guardar reporte"
            dialogo.Filter = If(rdbInformeMensual.Checked, "Archivo PDF (*.pdf)|*.pdf", "Archivo Excel (*.xlsx)|*.xlsx")
            dialogo.DefaultExt = If(rdbInformeMensual.Checked, "pdf", "xlsx")
            dialogo.AddExtension = True
            dialogo.FileName = NombreSugerido()
            If dialogo.ShowDialog(Me) = DialogResult.OK Then txtRuta.Text = dialogo.FileName
        End Using
    End Sub

    Private Async Sub GenerarArchivo(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(txtRuta.Text) Then
            MessageBox.Show("Primero seleccione dónde guardar el archivo.", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Sesion.HaySesion() AndAlso Not String.Equals(Sesion.Rol, "Administrador", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("Estos reportes requieren el rol Administrador.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim ruta = txtRuta.Text
        Dim incluir = chkIncluirAlDia.Checked
        Dim mes = dtpMes.Value
        Dim anio = CInt(nudAnio.Value)
        Dim tipo = If(rdbCartera.Checked, 7, If(rdbInformeMensual.Checked, 8, 9))
        Dim usuario = If(Sesion.HaySesion(), Sesion.NombreUsuario, "Prueba local")
        btnGenerar.Enabled = False
        btnExaminar.Enabled = False
        prgAvance.Visible = True
        lblEstado.Text = "Generando archivo..."
        Try
            Await Task.Run(Sub()
                Select Case tipo
                    Case 7
                        ExcelCartera.Generar(dao.ListarCarteraSaldos(incluir), ruta)
                    Case 8
                        PdfInformeMensual.Generar(mes, dao.ObtenerIndicadoresGerenciales(mes),
                            dao.ListarIngresosPorPlan(mes), dao.ListarMayoresSaldos(),
                            dao.ListarHorasPorInstructor(), usuario, ruta)
                    Case 9
                        ExcelLibroAnual.Generar(anio, dao.ListarIngresosAnuales(anio), ruta)
                End Select
            End Sub)
            lblEstado.Text = "Archivo generado correctamente."
            MessageBox.Show("Archivo generado correctamente.", "GymControl", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If chkAbrirAlTerminar.Checked Then
                Process.Start(New ProcessStartInfo(ruta) With {.UseShellExecute = True})
            End If
        Catch ex As Exception
            lblEstado.Text = "Error al generar el archivo."
            MessageBox.Show(ex.ToString(), "Error de exportación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnGenerar.Enabled = True
            btnExaminar.Enabled = True
            prgAvance.Visible = False
        End Try
    End Sub
End Class
