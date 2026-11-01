
Imports System.Data
Imports System.Diagnostics
Imports System.IO
Imports System.Threading.Tasks

Public Class frmExportarArchivos
    Inherits Form

    Private ReadOnly rdbCartera As New RadioButton()
    Private ReadOnly rdbInformeMensual As New RadioButton()
    Private ReadOnly rdbLibroAnual As New RadioButton()
    Private ReadOnly chkIncluirAlDia As New CheckBox()
    Private ReadOnly chkAbrirAlTerminar As New CheckBox()
    Private ReadOnly txtRuta As New TextBox()
    Private ReadOnly btnExaminar As New Button()
    Private ReadOnly btnGenerar As New Button()
    Private ReadOnly lblEstado As New Label()
    Private ReadOnly prgAvance As New ProgressBar()
    Private ReadOnly dao As New ReporteDAO()

    Public Sub New()
        Me.Text = "GymControl - Exportar archivos"
        Me.ClientSize = New Size(820, 400)
        Me.StartPosition = FormStartPosition.CenterParent
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Font = New Font("Segoe UI", 10)

        ConstruirInterfaz()
    End Sub

    Private Sub ConstruirInterfaz()
        Dim titulo As New Label With {
            .Text = "Exportación de reportes",
            .Font = New Font("Segoe UI", 16, FontStyle.Bold),
            .Location = New Point(25, 20),
            .AutoSize = True
        }

        rdbCartera.Text = "R07 - Cartera de saldos (Excel)"
        rdbCartera.Location = New Point(30, 75)
        rdbCartera.AutoSize = True
        rdbCartera.Checked = True

        rdbInformeMensual.Text = "R08 - Informe gerencial mensual (PDF)"
        rdbInformeMensual.Location = New Point(30, 105)
        rdbInformeMensual.AutoSize = True
        rdbInformeMensual.Enabled = False

        rdbLibroAnual.Text = "R09 - Libro de ingresos anual (Excel)"
        rdbLibroAnual.Location = New Point(30, 135)
        rdbLibroAnual.AutoSize = True
        rdbLibroAnual.Enabled = False

        chkIncluirAlDia.Text = "Incluir membresías al día"
        chkIncluirAlDia.Location = New Point(30, 180)
        chkIncluirAlDia.AutoSize = True

        chkAbrirAlTerminar.Text = "Abrir archivo al terminar"
        chkAbrirAlTerminar.Location = New Point(30, 210)
        chkAbrirAlTerminar.AutoSize = True
        chkAbrirAlTerminar.Checked = True

        txtRuta.Location = New Point(30, 255)
        txtRuta.Size = New Size(610, 27)
        txtRuta.ReadOnly = True

        btnExaminar.Text = "Examinar..."
        btnExaminar.Location = New Point(655, 253)
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
            titulo, rdbCartera, rdbInformeMensual,
            rdbLibroAnual, chkIncluirAlDia,
            chkAbrirAlTerminar, txtRuta, btnExaminar,
            btnGenerar, prgAvance, lblEstado
        })
    End Sub

    Private Sub ExaminarArchivo(sender As Object, e As EventArgs)
        Using dialogo As New SaveFileDialog()
            dialogo.Title = "Guardar cartera de saldos"
            dialogo.Filter = "Archivo Excel (*.xlsx)|*.xlsx"
            dialogo.DefaultExt = "xlsx"
            dialogo.AddExtension = True
            dialogo.FileName =
                "Cartera_" & Date.Today.ToString("yyyy-MM-dd") & ".xlsx"

            If dialogo.ShowDialog(Me) = DialogResult.OK Then
                txtRuta.Text = dialogo.FileName
            End If
        End Using
    End Sub

    Private Async Sub GenerarArchivo(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(txtRuta.Text) Then
            MessageBox.Show(
                "Primero seleccione dónde guardar el archivo.",
                "Exportación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
            Return
        End If

        Dim ruta As String = txtRuta.Text
        Dim incluirAlDia As Boolean = chkIncluirAlDia.Checked

        btnGenerar.Enabled = False
        btnExaminar.Enabled = False
        prgAvance.Visible = True
        lblEstado.Text = "Generando archivo..."

        Try
            Await Task.Run(Sub()
                Dim datos As DataTable =
                    dao.ListarCarteraSaldos(incluirAlDia)

                ExcelCartera.Generar(datos, ruta)
            End Sub)

            lblEstado.Text = "Archivo generado correctamente."

            MessageBox.Show(
                "El archivo Excel se generó correctamente.",
                "GymControl",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            If chkAbrirAlTerminar.Checked Then
                Process.Start(New ProcessStartInfo(ruta) With {
                    .UseShellExecute = True
                })
            End If

        Catch ex As Exception
            lblEstado.Text = "Error al generar el archivo."

            MessageBox.Show(
                ex.Message,
                "Error de exportación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        Finally
            btnGenerar.Enabled = True
            btnExaminar.Enabled = True
            prgAvance.Visible = False
        End Try
    End Sub
End Class
