' =============================================================
' ReciboPago  (R01)
'
' Documento imprimible de un recibo de pago en ticket de 80 mm.
' Recibe un DataRow con los datos que entrega
' PagoDAO.ObtenerPagoParaRecibo y dibuja el comprobante con
' Graphics sobre un PrintDocument (pdRecibo).
'
' Si el pago está anulado, dibuja una marca de agua diagonal
' con la palabra "ANULADO".
' =============================================================
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Printing
Imports System.Globalization

Public Class ReciboPago
    Implements IDisposable

    ' 80 mm equivalen a 3.15 pulgadas = 315 centésimas de pulgada.
    Private Const AnchoTicket As Integer = 315
    Private Const AltoMinimo As Integer = 440

    Private _datos As DataRow
    Private ReadOnly pdRecibo As New PrintDocument()

    Public Sub New()
        ConfigurarDocumento()
    End Sub

    Public Sub New(datos As DataRow)
        Me.New()
        Me.Datos = datos
    End Sub

    ''' <summary>
    ''' Datos del pago a imprimir (una fila de PagoDAO.ObtenerPagoParaRecibo).
    ''' </summary>
    Public Property Datos As DataRow
        Get
            Return _datos
        End Get
        Set(value As DataRow)
            _datos = value
            If value IsNot Nothing Then
                pdRecibo.DocumentName = "Recibo " & NumeroRecibo()
                pdRecibo.DefaultPageSettings.PaperSize =
                    New PaperSize("Ticket 80 mm", AnchoTicket, CalcularAlto())
            End If
        End Set
    End Property

    ''' <summary>
    ''' Documento subyacente, expuesto para vista previa o PageSetupDialog.
    ''' </summary>
    Public ReadOnly Property Documento As PrintDocument
        Get
            Return pdRecibo
        End Get
    End Property

    ''' <summary>
    ''' Envía el recibo a la vista previa o directamente a la
    ''' impresora predeterminada.
    ''' </summary>
    Public Sub Imprimir(vistaPrevia As Boolean, Optional propietario As IWin32Window = Nothing)

        If _datos Is Nothing Then
            Throw New InvalidOperationException("No hay datos de pago para imprimir el recibo.")
        End If

        If vistaPrevia Then
            Using vista As New PrintPreviewDialog()
                vista.Document = pdRecibo
                vista.UseAntiAlias = True
                vista.WindowState = FormWindowState.Maximized
                vista.Text = "Vista previa - Recibo de pago " & NumeroRecibo()
                vista.ShowDialog(propietario)
            End Using
        Else
            pdRecibo.Print()
        End If

    End Sub

    Private Sub ConfigurarDocumento()

        pdRecibo.DocumentName = "Recibo de pago"
        pdRecibo.DefaultPageSettings.PaperSize = New PaperSize("Ticket 80 mm", AnchoTicket, AltoMinimo)
        pdRecibo.DefaultPageSettings.Margins = New Margins(12, 12, 14, 14)
        pdRecibo.OriginAtMargins = False

        AddHandler pdRecibo.PrintPage, AddressOf ImprimirPagina

    End Sub

    Private Sub ImprimirPagina(sender As Object, e As PrintPageEventArgs)

        If _datos Is Nothing Then
            e.Cancel = True
            Return
        End If

        Dim g As Graphics = e.Graphics
        Dim x As Single = e.MarginBounds.Left
        Dim ancho As Single = e.MarginBounds.Width
        Dim y As Single = e.MarginBounds.Top

        ' ---------------------------------------------
        ' Marca de agua para pagos anulados
        ' ---------------------------------------------
        If Anulado() Then DibujarMarcaAnulado(g, e)

        Using titulo As New Font("Segoe UI", 11.5F, FontStyle.Bold),
              subtitulo As New Font("Segoe UI", 6.5F, FontStyle.Regular),
              encabezado As New Font("Segoe UI", 8.0F, FontStyle.Bold),
              normal As New Font("Segoe UI", 7.5F, FontStyle.Regular),
              negrita As New Font("Segoe UI", 7.5F, FontStyle.Bold),
              pequena As New Font("Segoe UI", 6.5F, FontStyle.Regular),
              total As New Font("Segoe UI", 10.5F, FontStyle.Bold),
              negro As New SolidBrush(Color.Black),
              gris As New SolidBrush(Color.FromArgb(95, 95, 95)),
              rojo As New SolidBrush(Color.FromArgb(160, 40, 40)),
              lapiz As New Pen(Color.Black, 0.7F),
              punteado As Pen = CrearLapizPunteado()

            ' ---------------------------------------------
            ' Encabezado del gimnasio
            ' ---------------------------------------------
            y += ImpresionUtil.DibujarCentrado(g, "GIMNASIO TITÁN", titulo, negro, x, y, ancho)
            y += ImpresionUtil.DibujarCentrado(g, "Control de socios y membresías", pequena, gris, x, y, ancho)
            y += 2.0F

            ImpresionUtil.DibujarLinea(g, lapiz, x, y, x + ancho)
            y += 6.0F

            y += ImpresionUtil.DibujarCentrado(g, "RECIBO DE PAGO", encabezado, negro, x, y, ancho)
            y += ImpresionUtil.DibujarCentrado(g, "No. " & NumeroRecibo(), normal, negro, x, y, ancho)
            y += 2.0F

            ImpresionUtil.DibujarSeparadorPunteado(g, punteado, x, y, x + ancho)
            y += 6.0F

            ' ---------------------------------------------
            ' Datos del comprobante
            ' ---------------------------------------------
            DibujarFila(g, "Fecha:", Fecha("fecha_pago").ToString("dd/MM/yyyy HH:mm"),
                        normal, negrita, gris, negro, x, y, ancho)
            DibujarFila(g, "Socio:", Texto("Socio", "Socio no disponible"),
                        normal, negrita, gris, negro, x, y, ancho)
            DibujarFila(g, "Cédula:", Texto("cedula", "-"),
                        normal, normal, gris, negro, x, y, ancho)
            DibujarFila(g, "Plan:", Texto("Tipo", "-"),
                        normal, negrita, gris, negro, x, y, ancho)
            DibujarFila(g, "Desde:", Fecha("fecha_inicio").ToString("dd/MM/yyyy"),
                        normal, normal, gris, negro, x, y, ancho)
            DibujarFila(g, "Hasta:", Fecha("fecha_vencimiento").ToString("dd/MM/yyyy"),
                        normal, normal, gris, negro, x, y, ancho)
            DibujarFila(g, "Método:", Texto("metodo_pago", "-"),
                        normal, normal, gris, negro, x, y, ancho)

            If Not String.IsNullOrWhiteSpace(Texto("referencia")) Then
                DibujarFila(g, "Referencia:", Texto("referencia"),
                            normal, normal, gris, negro, x, y, ancho)
            End If

            If Not String.IsNullOrWhiteSpace(Texto("RegistradoPor")) Then
                DibujarFila(g, "Atendió:", Texto("RegistradoPor"),
                            normal, normal, gris, negro, x, y, ancho)
            End If

            DibujarFila(g, "Estado:", If(Anulado(), "ANULADO", "VIGENTE"),
                        normal, negrita, gris, If(Anulado(), rojo, negro), x, y, ancho)

            y += 3.0F
            ImpresionUtil.DibujarSeparadorPunteado(g, punteado, x, y, x + ancho)
            y += 6.0F

            ' ---------------------------------------------
            ' Monto total
            ' ---------------------------------------------
            Dim monto As Decimal = Numero("monto")
            g.DrawString("TOTAL PAGADO", total, negro, x, y)
            Dim textoMonto As String = ImpresionUtil.FormatearMoneda(monto)
            Dim tamanoMonto As SizeF = g.MeasureString(textoMonto, total)
            g.DrawString(textoMonto, total, negro, x + ancho - tamanoMonto.Width, y)
            y += 18.0F

            ' ---------------------------------------------
            ' Monto en letras
            ' ---------------------------------------------
            g.DrawString("Son:", pequena, gris, x, y)
            y += 10.0F
            y = ImpresionUtil.DibujarParrafo(
                    g,
                    TextoMontoEnLetras().ToUpper(CultureInfo.CurrentCulture),
                    pequena, negro, x, y, ancho, 1.1F)

            y += 3.0F
            ImpresionUtil.DibujarSeparadorPunteado(g, punteado, x, y, x + ancho)
            y += 6.0F

            ' ---------------------------------------------
            ' Saldo pendiente de la membresía
            ' ---------------------------------------------
            Dim saldo As Decimal = Numero("Saldo")
            g.DrawString("Saldo pendiente:", normal, gris, x, y)
            Dim textoSaldo As String = If(saldo <= 0D, "C$ 0.00 (PAGADO)", ImpresionUtil.FormatearMoneda(saldo))
            Dim tamanoSaldo As SizeF = g.MeasureString(textoSaldo, negrita)
            g.DrawString(textoSaldo, negrita, If(saldo <= 0D, negro, rojo),
                         x + ancho - tamanoSaldo.Width, y)
            y += 16.0F

            ' ---------------------------------------------
            ' Pie del comprobante
            ' ---------------------------------------------
            ImpresionUtil.DibujarSeparadorPunteado(g, punteado, x, y, x + ancho)
            y += 6.0F

            y += ImpresionUtil.DibujarCentrado(g, "Gracias por su preferencia", pequena, gris, x, y, ancho)
            y += ImpresionUtil.DibujarCentrado(g, "GymControl · Gimnasio Titán", pequena, gris, x, y, ancho)
            ImpresionUtil.DibujarCentrado(g, "Generado el " & Now.ToString("dd/MM/yyyy HH:mm"), pequena, gris, x, y, ancho)

        End Using

    End Sub

    ' ---------------------------------------------------------
    ' Dibuja una fila "etiqueta: valor" alineada a los extremos
    ' del ticket. El valor se recorta si no cabe.
    ' ---------------------------------------------------------
    Private Sub DibujarFila(g As Graphics, etiqueta As String, valor As String,
                            fuenteEtiqueta As Font, fuenteValor As Font,
                            pincelEtiqueta As Brush, pincelValor As Brush,
                            x As Single, ByRef y As Single, ancho As Single)

        Dim anchoEtiqueta As Single = g.MeasureString(etiqueta, fuenteEtiqueta).Width
        Dim disponible As Single = ancho - anchoEtiqueta - 4.0F

        If disponible <= 0.0F Then
            y += 12.0F
            Return
        End If

        g.DrawString(etiqueta, fuenteEtiqueta, pincelEtiqueta, x, y)

        Dim texto As String = ImpresionUtil.Recortar(g, valor, fuenteValor, disponible)
        Dim tamano As SizeF = g.MeasureString(texto, fuenteValor)
        g.DrawString(texto, fuenteValor, pincelValor, x + ancho - tamano.Width, y)

        y += 13.0F

    End Sub

    ' ---------------------------------------------------------
    ' Marca de agua diagonal "ANULADO"
    ' ---------------------------------------------------------
    Private Sub DibujarMarcaAnulado(g As Graphics, e As PrintPageEventArgs)

        Using marca As New Font("Segoe UI", 34.0F, FontStyle.Bold)
            Using pincel As New SolidBrush(Color.FromArgb(55, 192, 57, 43))
                Dim estado As GraphicsState = g.Save()
                Try
                    g.TranslateTransform(
                        e.PageBounds.Left + (e.PageBounds.Width / 2.0F),
                        e.PageBounds.Top + (e.PageBounds.Height / 2.0F))
                    g.RotateTransform(-35.0F)

                    Dim tamano As SizeF = g.MeasureString("ANULADO", marca)
                    g.DrawString("ANULADO", marca, pincel, -tamano.Width / 2.0F, -tamano.Height / 2.0F)
                Finally
                    g.Restore(estado)
                End Try
            End Using
        End Using

    End Sub

    ' ---------------------------------------------------------
    ' Alto estimado del ticket según el contenido
    ' ---------------------------------------------------------
    Private Function CalcularAlto() As Integer

        Dim alto As Integer = 430
        Dim letras As String = TextoMontoEnLetras()

        If Not String.IsNullOrEmpty(letras) Then
            alto += CInt(Math.Ceiling(letras.Length / 40.0)) * 11
        End If

        If Not String.IsNullOrWhiteSpace(Texto("referencia")) Then alto += 13
        If Not String.IsNullOrWhiteSpace(Texto("RegistradoPor")) Then alto += 13

        Return Math.Max(AltoMinimo, alto)

    End Function

    Private Function NumeroRecibo() As String
        Return Convert.ToInt32(Numero("id_pago")).ToString("D6")
    End Function

    Private Shared Function CrearLapizPunteado() As Pen
        Dim lapiz As New Pen(Color.Gray, 0.5F)
        lapiz.DashStyle = DashStyle.Dot
        Return lapiz
    End Function

    Private Function TextoMontoEnLetras() As String
        Return NumeroALetras.Convertir(Numero("monto"))
    End Function

    Private Function Anulado() As Boolean
        Return Numero("anulado") <> 0D
    End Function

    ' ---------------------------------------------------------
    ' Acceso seguro a las columnas del DataRow
    ' ---------------------------------------------------------
    Private Function Campo(nombre As String) As Object

        If _datos Is Nothing Then Return Nothing
        If Not _datos.Table.Columns.Contains(nombre) Then Return Nothing
        Return _datos(nombre)

    End Function

    Private Function Texto(nombre As String, Optional predeterminado As String = "") As String

        Dim valor As Object = Campo(nombre)
        If valor Is Nothing OrElse Convert.IsDBNull(valor) Then Return predeterminado
        Return valor.ToString()

    End Function

    Private Function Numero(nombre As String) As Decimal

        Dim valor As Object = Campo(nombre)
        If valor Is Nothing OrElse Convert.IsDBNull(valor) Then Return 0D
        Return Convert.ToDecimal(valor)

    End Function

    Private Function Fecha(nombre As String) As Date

        Dim valor As Object = Campo(nombre)
        If valor Is Nothing OrElse Convert.IsDBNull(valor) Then Return Date.MinValue
        Return Convert.ToDateTime(valor)

    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        pdRecibo.Dispose()
    End Sub

End Class
