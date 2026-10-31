' =============================================================
' frmListadoVencimientos  (R03)
'
' Listado paginado de membresías por fecha de vencimiento.
' Permite filtrar por días hacia atrás / adelante, imprimir en
' orientación horizontal y repetir el encabezado de la tabla en
' cada página usando PrintDocument + HasMorePages.
' =============================================================
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Printing

Public Class frmListadoVencimientos

    Private ReadOnly membresiaDAO As New MembresiaDAO()
    Private ReadOnly pdListado As New PrintDocument()

    Private tabla As DataTable
    Private filaActual As Integer
    Private paginaActual As Integer
    Private ReadOnly fuenteDiasAlerta As New Font("Segoe UI", 9.0F, FontStyle.Bold)

    Public Sub New()

        InitializeComponent()

        ConfigurarDocumento()

    End Sub

    Private Sub ConfigurarDocumento()

        pdListado.DocumentName = "Listado de vencimientos"
        pdListado.DefaultPageSettings.PaperSize = New PaperSize("Carta", 850, 1100)
        pdListado.DefaultPageSettings.Landscape = False
        pdListado.DefaultPageSettings.Margins = New Margins(60, 60, 70, 70)
        pdListado.OriginAtMargins = False

        AddHandler pdListado.BeginPrint, AddressOf pdListado_BeginPrint
        AddHandler pdListado.PrintPage, AddressOf pdListado_PrintPage

    End Sub

    Private Sub frmListadoVencimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvVencimientos.AutoGenerateColumns = False
        CargarDatos()

    End Sub

    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        MyBase.OnFormClosed(e)
        pdListado.Dispose()
        fuenteDiasAlerta.Dispose()
    End Sub

    ' =========================================================
    ' CARGA DE DATOS
    ' =========================================================
    Private Sub CargarDatos()

        Try
            tabla = membresiaDAO.ListarVencimientos(
                CInt(nudDiasAtras.Value),
                CInt(nudDiasAdelante.Value))

            dgvVencimientos.DataSource = tabla

            Dim atras As Integer = CInt(nudDiasAtras.Value)
            Dim adelante As Integer = CInt(nudDiasAdelante.Value)

            lblResumenListado.Text =
                tabla.Rows.Count.ToString() & " membresía(s) entre " &
                Date.Today.AddDays(-atras).ToString("dd/MM/yyyy") & " y " &
                Date.Today.AddDays(adelante).ToString("dd/MM/yyyy") & "."

        Catch ex As Exception
            MostrarError("No se pudo cargar el listado de vencimientos.", ex)
        End Try

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        CargarDatos()
    End Sub

    ' =========================================================
    ' COLORES POR DÍAS RESTANTES
    ' =========================================================
    Private Sub dgvVencimientos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvVencimientos.CellFormatting

        If e.ColumnIndex <> colDias.Index OrElse e.Value Is Nothing Then Return

        Dim dias As Integer
        If Not Integer.TryParse(e.Value.ToString(), dias) Then Return

        If dias < 0 Then
            e.CellStyle.ForeColor = Color.Firebrick
            e.CellStyle.Font = fuenteDiasAlerta
        ElseIf dias <= 7 Then
            e.CellStyle.ForeColor = Color.DarkOrange
            e.CellStyle.Font = fuenteDiasAlerta
        End If

    End Sub

    ' =========================================================
    ' IMPRESIÓN
    ' =========================================================
    Private Sub btnVistaPreviaListado_Click(sender As Object, e As EventArgs) Handles btnVistaPreviaListado.Click
        Imprimir(vistaPrevia:=True)
    End Sub

    Private Sub btnImprimirListado_Click(sender As Object, e As EventArgs) Handles btnImprimirListado.Click
        Imprimir(vistaPrevia:=False)
    End Sub

    Private Sub Imprimir(vistaPrevia As Boolean)

        If tabla Is Nothing OrElse tabla.Rows.Count = 0 Then
            MostrarAviso("No hay membresías en el rango seleccionado.")
            Return
        End If

        Try
            pdListado.DefaultPageSettings.Landscape = chkHorizontal.Checked

            If vistaPrevia Then
                Using vista As New PrintPreviewDialog()
                    vista.Document = pdListado
                    vista.UseAntiAlias = True
                    vista.WindowState = FormWindowState.Maximized
                    vista.Text = "Vista previa - Listado de vencimientos"
                    vista.ShowDialog(Me)
                End Using
            Else
                pdListado.Print()
            End If

        Catch ex As Exception
            MostrarError("No se pudo imprimir el listado de vencimientos.", ex)
        End Try

    End Sub

    Private Sub pdListado_BeginPrint(sender As Object, e As PrintEventArgs)
        filaActual = 0
        paginaActual = 0
    End Sub

    Private Sub pdListado_PrintPage(sender As Object, e As PrintPageEventArgs)

        If tabla Is Nothing Then
            e.Cancel = True
            Return
        End If

        paginaActual += 1

        Dim g As Graphics = e.Graphics
        Dim x As Single = e.MarginBounds.Left
        Dim ancho As Single = e.MarginBounds.Width
        Dim y As Single = e.MarginBounds.Top

        Using titulo As New Font("Segoe UI", 13.0F, FontStyle.Bold),
              subtitulo As New Font("Segoe UI", 8.5F, FontStyle.Regular),
              encabezado As New Font("Segoe UI", 8.0F, FontStyle.Bold),
              normal As New Font("Segoe UI", 8.0F, FontStyle.Regular),
              pie As New Font("Segoe UI", 7.0F, FontStyle.Regular),
              negro As New SolidBrush(Color.Black),
              gris As New SolidBrush(Color.FromArgb(90, 90, 90)),
              blanco As New SolidBrush(Color.White),
              fondoEncabezado As New SolidBrush(Color.FromArgb(44, 62, 80)),
              fondoCebra As New SolidBrush(Color.FromArgb(245, 247, 250)),
              lapiz As New Pen(Color.FromArgb(180, 180, 180), 0.6F)

            ' ---------------------------------------------
            ' Encabezado del documento (se repite en cada página)
            ' ---------------------------------------------
            g.DrawString("GIMNASIO TITÁN", titulo, negro, x, y)
            y += 24.0F

            g.DrawString("Listado de vencimientos de membresías", encabezado, gris, x, y)
            y += 16.0F

            Dim atras As Integer = CInt(nudDiasAtras.Value)
            Dim adelante As Integer = CInt(nudDiasAdelante.Value)

            Dim rango As String =
                "Rango: " & Date.Today.AddDays(-atras).ToString("dd/MM/yyyy") &
                " al " & Date.Today.AddDays(adelante).ToString("dd/MM/yyyy") &
                "   ·   Registros: " & tabla.Rows.Count.ToString()

            g.DrawString(rango, subtitulo, gris, x, y)
            y += 14.0F

            g.DrawString("Generado: " & Now.ToString("dd/MM/yyyy HH:mm"), subtitulo, gris, x, y)
            y += 20.0F

            g.DrawLine(lapiz, x, y, x + ancho, y)
            y += 8.0F

            ' ---------------------------------------------
            ' Columnas
            ' ---------------------------------------------
            Dim campos As String() = {"cedula", "Socio", "Tipo", "Vencimiento", "Dias", "Estado"}
            Dim columnas As String() = {"Cédula", "Socio", "Membresía", "Vence", "Días", "Estado"}
            Dim pesos As Single() = {0.16F, 0.30F, 0.24F, 0.12F, 0.08F, 0.10F}

            Dim posiciones(campos.Length - 1) As Single
            Dim anchos(campos.Length - 1) As Single

            Dim acumulado As Single = 0.0F
            For i As Integer = 0 To pesos.Length - 1
                posiciones(i) = x + (ancho * acumulado)
                anchos(i) = (ancho * pesos(i)) - 6.0F
                acumulado += pesos(i)
            Next

            Dim altoFila As Single = 16.0F
            Dim filasEnPagina As Integer = 0

            g.FillRectangle(fondoEncabezado, x, y, ancho, altoFila)
            For i As Integer = 0 To columnas.Length - 1
                g.DrawString(columnas(i), encabezado, blanco, posiciones(i) + 3.0F, y + 3.0F)
            Next
            y += altoFila

            ' ---------------------------------------------
            ' Filas (con paginación)
            ' ---------------------------------------------
            While filaActual < tabla.Rows.Count

                ' Se garantiza al menos una fila por página para evitar
                ' un bucle infinito si el área imprimible es muy pequeña.
                If filasEnPagina > 0 AndAlso y + altoFila > e.MarginBounds.Bottom - 26.0F Then Exit While

                Dim fila As DataRow = tabla.Rows(filaActual)

                If filaActual Mod 2 = 1 Then
                    g.FillRectangle(fondoCebra, x, y, ancho, altoFila)
                End If

                For i As Integer = 0 To campos.Length - 1
                    Dim valor As String = If(fila(campos(i)) Is DBNull.Value,
                                             String.Empty,
                                             fila(campos(i)).ToString())
                    g.DrawString(ImpresionUtil.Recortar(g, valor, normal, anchos(i)),
                                 normal, negro, posiciones(i) + 3.0F, y + 3.0F)
                Next

                g.DrawLine(lapiz, x, y + altoFila, x + ancho, y + altoFila)

                filaActual += 1
                filasEnPagina += 1
                y += altoFila

            End While

            ' ---------------------------------------------
            ' Pie de página
            ' ---------------------------------------------
            Dim yPie As Single = e.MarginBounds.Bottom - 14.0F

            g.DrawString("GymControl · Gimnasio Titán", pie, gris, x, yPie)

            Dim textoPagina As String = "Página " & paginaActual.ToString()
            Dim tamanoPagina As SizeF = g.MeasureString(textoPagina, pie)
            g.DrawString(textoPagina, pie, gris, x + ancho - tamanoPagina.Width, yPie)

            e.HasMorePages = filaActual < tabla.Rows.Count

        End Using

    End Sub

    ' =========================================================
    ' UTILIDADES
    ' =========================================================
    Private Sub btnCerrarListado_Click(sender As Object, e As EventArgs) Handles btnCerrarListado.Click
        Close()
    End Sub

    Private Shared Sub MostrarAviso(mensaje As String)
        MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Shared Sub MostrarError(mensaje As String, ex As Exception)
        MessageBox.Show(mensaje & Environment.NewLine & Environment.NewLine & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

End Class
