' =============================================================
' ConstanciaMembresia  (R02)
'
' Documento imprimible de constancia de membresía vigente.
' Se configura en papel tamaño Carta, orientación vertical y
' admite márgenes configurables mediante PageSetupDialog
' (la persona que la usa modifica Documento.DefaultPageSettings).
'
' Recibe un DataRow con los datos que entrega
' MembresiaDAO.ObtenerConstanciaPorSocio.
' =============================================================
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Printing

Public Class ConstanciaMembresia
    Implements IDisposable

    Private Const AnchoCarta As Integer = 850
    Private Const AltoCarta As Integer = 1100

    Private _datos As DataRow
    Private ReadOnly pdConstancia As New PrintDocument()

    Public Sub New()
        ConfigurarDocumento()
    End Sub

    Public Sub New(datos As DataRow)
        Me.New()
        Me.Datos = datos
    End Sub

    ''' <summary>
    ''' Datos del socio y de su membresía vigente.
    ''' </summary>
    Public Property Datos As DataRow
        Get
            Return _datos
        End Get
        Set(value As DataRow)
            _datos = value
            If value IsNot Nothing Then
                pdConstancia.DocumentName = "Constancia - " & Texto("Socio", "Socio")
            End If
        End Set
    End Property

    ''' <summary>
    ''' Documento subyacente, expuesto para PageSetupDialog.
    ''' </summary>
    Public ReadOnly Property Documento As PrintDocument
        Get
            Return pdConstancia
        End Get
    End Property

    ''' <summary>
    ''' Envía la constancia a la vista previa o directamente a la
    ''' impresora predeterminada.
    ''' </summary>
    Public Sub Imprimir(vistaPrevia As Boolean, Optional propietario As IWin32Window = Nothing)

        If _datos Is Nothing Then
            Throw New InvalidOperationException("No hay datos de membresía para generar la constancia.")
        End If

        If vistaPrevia Then
            Using vista As New PrintPreviewDialog()
                vista.Document = pdConstancia
                vista.UseAntiAlias = True
                vista.WindowState = FormWindowState.Maximized
                vista.Text = "Vista previa - Constancia de membresía"
                vista.ShowDialog(propietario)
            End Using
        Else
            pdConstancia.Print()
        End If

    End Sub

    Private Sub ConfigurarDocumento()

        pdConstancia.DocumentName = "Constancia de membresía"
        pdConstancia.DefaultPageSettings.PaperSize = New PaperSize("Carta", AnchoCarta, AltoCarta)
        pdConstancia.DefaultPageSettings.Landscape = False
        pdConstancia.DefaultPageSettings.Margins = New Margins(85, 85, 90, 90)
        pdConstancia.OriginAtMargins = False

        AddHandler pdConstancia.PrintPage, AddressOf ImprimirPagina

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

        Using titulo As New Font("Segoe UI", 15.0F, FontStyle.Bold),
              institucion As New Font("Segoe UI", 13.0F, FontStyle.Bold),
              subtitulo As New Font("Segoe UI", 9.0F, FontStyle.Regular),
              normal As New Font("Segoe UI", 10.5F, FontStyle.Regular),
              negrita As New Font("Segoe UI", 10.0F, FontStyle.Bold),
              pequena As New Font("Segoe UI", 8.0F, FontStyle.Regular),
              negro As New SolidBrush(Color.Black),
              gris As New SolidBrush(Color.FromArgb(95, 95, 95)),
              azul As New SolidBrush(Color.FromArgb(44, 62, 80)),
              lapiz As New Pen(Color.FromArgb(44, 62, 80), 1.2F),
              lapizFino As New Pen(Color.FromArgb(180, 180, 180), 0.6F)

            ' ---------------------------------------------
            ' Logotipo institucional
            ' ---------------------------------------------
            DibujarLogo(g, x, y, ancho)
            y += 76.0F

            y += ImpresionUtil.DibujarCentrado(g, "GIMNASIO TITÁN", institucion, azul, x, y, ancho)
            y += ImpresionUtil.DibujarCentrado(g, "Administración General", subtitulo, gris, x, y, ancho)
            y += 6.0F

            ImpresionUtil.DibujarLinea(g, lapizFino, x, y, x + ancho)
            y += 26.0F

            y += ImpresionUtil.DibujarCentrado(g, "CONSTANCIA DE MEMBRESÍA VIGENTE", titulo, negro, x, y, ancho)
            y += 8.0F

            ' Línea corta decorativa bajo el título
            Dim centro As Single = x + (ancho / 2.0F)
            g.DrawLine(lapiz, centro - 90.0F, y, centro + 90.0F, y)
            y += 30.0F

            ' ---------------------------------------------
            ' Primer párrafo
            ' ---------------------------------------------
            Dim parrafo1 As String =
                "El suscrito, Administrador General del GIMNASIO TITÁN, hace constar que el(la) " &
                "señor(a) " & Texto("Socio", "________________") & ", con cédula de identidad No. " &
                Texto("cedula", "________________") & ", es socio(a) activo(a) de nuestra institución " &
                "y mantiene vigente su membresía " & Texto("Tipo", "________________") & ", adquirida " &
                FechaEnLetras.Formatear(Fecha("fecha_inicio")) & " y con vigencia hasta el " &
                FechaEnLetras.FormatearCorta(Fecha("fecha_vencimiento")) & "."

            Dim altoParrafo1 As Single = MedirParrafo(g, parrafo1, normal, ancho)
            Dim rectangulo1 As New RectangleF(x, y, ancho, altoParrafo1 + 6.0F)
            y = ImpresionUtil.DibujarParrafoEnRectangulo(g, parrafo1, normal, negro, rectangulo1, 1.35F)
            y += 18.0F

            ' ---------------------------------------------
            ' Recuadro con el detalle de la membresía
            ' ---------------------------------------------
            y = DibujarRecuadroDetalle(g, x, y, ancho, normal, negrita, pequena, negro, gris, lapizFino)
            y += 20.0F

            ' ---------------------------------------------
            ' Segundo párrafo
            ' ---------------------------------------------
            Dim parrafo2 As String =
                "La presente constancia se extiende " &
                FechaEnLetras.Formatear(Date.Today) &
                ", a solicitud del interesado, para los fines que estime convenientes."

            Dim altoParrafo2 As Single = MedirParrafo(g, parrafo2, normal, ancho)
            Dim rectangulo2 As New RectangleF(x, y, ancho, altoParrafo2 + 6.0F)
            y = ImpresionUtil.DibujarParrafoEnRectangulo(g, parrafo2, normal, negro, rectangulo2, 1.35F)
            y += 22.0F

            ' ---------------------------------------------
            ' Firma al pie
            ' ---------------------------------------------
            Dim yFirma As Single = Math.Max(y + 40.0F, e.MarginBounds.Bottom - 120.0F)

            If yFirma + 80.0F > e.MarginBounds.Bottom Then
                yFirma = e.MarginBounds.Bottom - 120.0F
            End If

            g.DrawLine(lapizFino, centro - 130.0F, yFirma, centro + 130.0F, yFirma)
            yFirma += 6.0F
            yFirma += ImpresionUtil.DibujarCentrado(g, "Administración General", negrita, negro, x, yFirma, ancho)
            ImpresionUtil.DibujarCentrado(g, "GIMNASIO TITÁN", pequena, gris, x, yFirma, ancho)

            ' ---------------------------------------------
            ' Pie de página
            ' ---------------------------------------------
            Dim pie As String = "Documento generado el " & Now.ToString("dd/MM/yyyy HH:mm") &
                                " · GymControl · Válido únicamente con sello y firma"
            ImpresionUtil.DibujarCentrado(g, pie, pequena, gris, x,
                                          e.MarginBounds.Bottom - 12.0F, ancho)

        End Using

    End Sub

    ' ---------------------------------------------------------
    ' Dibuja el recuadro con los datos de la membresía
    ' ---------------------------------------------------------
    Private Function DibujarRecuadroDetalle(g As Graphics, x As Single, y As Single, ancho As Single,
                                           fuenteNormal As Font, fuenteNegrita As Font,
                                           fuentePequena As Font, pincelNegro As Brush,
                                           pincelGris As Brush, lapiz As Pen) As Single

        Dim alto As Single = 92.0F
        Dim rectangulo As New RectangleF(x, y, ancho, alto)

        Using fondo As New SolidBrush(Color.FromArgb(247, 249, 251))
            g.FillRectangle(fondo, rectangulo)
        End Using
        g.DrawRectangle(lapiz, x, y, ancho, alto)

        Dim margen As Single = 14.0F
        Dim yFila As Single = y + 12.0F
        Dim anchoEtiqueta As Single = 150.0F
        Dim altoFila As Single = 18.0F

        DibujarDetalle(g, "Tipo de membresía:", Texto("Tipo", "-"), x + margen, yFila,
                       anchoEtiqueta, fuentePequena, fuenteNegrita, pincelGris, pincelNegro)
        yFila += altoFila

        Dim vigencia As String = Fecha("fecha_inicio").ToString("dd/MM/yyyy") &
                                 "  al  " & Fecha("fecha_vencimiento").ToString("dd/MM/yyyy")
        DibujarDetalle(g, "Vigencia:", vigencia, x + margen, yFila,
                       anchoEtiqueta, fuentePequena, fuenteNegrita, pincelGris, pincelNegro)
        yFila += altoFila

        Dim dias As Integer = Convert.ToInt32(Numero("DiasRestantes"))
        Dim textoDias As String = If(dias = 1, "1 día", dias.ToString() & " días")
        DibujarDetalle(g, "Días restantes:", textoDias, x + margen, yFila,
                       anchoEtiqueta, fuentePequena, fuenteNegrita, pincelGris, pincelNegro)
        yFila += altoFila

        DibujarDetalle(g, "Estado:", Texto("estado", "ACTIVA"), x + margen, yFila,
                       anchoEtiqueta, fuentePequena, fuenteNegrita, pincelGris, pincelNegro)

        Return y + alto

    End Function

    Private Sub DibujarDetalle(g As Graphics, etiqueta As String, valor As String,
                               x As Single, y As Single, anchoEtiqueta As Single,
                               fuenteEtiqueta As Font, fuenteValor As Font,
                               pincelEtiqueta As Brush, pincelValor As Brush)

        g.DrawString(etiqueta, fuenteEtiqueta, pincelEtiqueta, x, y)
        g.DrawString(valor, fuenteValor, pincelValor, x + anchoEtiqueta, y - 1.0F)

    End Sub

    ' ---------------------------------------------------------
    ' Dibuja el logotipo institucional. Si el recurso no existe,
    ' dibuja un emblema circular con las iniciales.
    ' ---------------------------------------------------------
    Private Sub DibujarLogo(g As Graphics, x As Single, y As Single, ancho As Single)

        Dim lado As Single = 64.0F
        Dim izquierda As Single = x + ((ancho - lado) / 2.0F)
        Dim logo As Image = ObtenerLogo()

        If logo IsNot Nothing Then
            g.DrawImage(logo, izquierda, y, lado, lado)
            Return
        End If

        Dim rectangulo As New RectangleF(izquierda, y, lado, lado)

        Using fondo As New SolidBrush(Color.FromArgb(44, 62, 80))
            g.FillEllipse(fondo, rectangulo)
        End Using

        Using borde As New Pen(Color.FromArgb(189, 195, 199), 1.5F)
            g.DrawEllipse(borde, rectangulo)
        End Using

        Using fuente As New Font("Segoe UI", 18.0F, FontStyle.Bold)
            Using pincel As New SolidBrush(Color.White)
                Dim tamano As SizeF = g.MeasureString("GT", fuente)
                g.DrawString("GT", fuente, pincel,
                             izquierda + ((lado - tamano.Width) / 2.0F),
                             y + ((lado - tamano.Height) / 2.0F))
            End Using
        End Using

    End Sub

    Private Shared Function ObtenerLogo() As Image

        Try
            Dim recurso As Object = My.Resources.ResourceManager.GetObject("LogoGymControl")
            Return TryCast(recurso, Image)
        Catch
            Return Nothing
        End Try

    End Function

    ' ---------------------------------------------------------
    ' Calcula el alto que ocupará un párrafo ajustado al ancho
    ' ---------------------------------------------------------
    Private Shared Function MedirParrafo(g As Graphics, texto As String, fuente As Font, ancho As Single) As Single

        Dim altoLinea As Single = fuente.GetHeight(g) * 1.35F
        Dim palabras As String() = texto.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
        Dim linea As String = String.Empty
        Dim lineas As Integer = 1

        For Each palabra As String In palabras

            Dim prueba As String = If(linea.Length = 0, palabra, linea & " " & palabra)

            If linea.Length > 0 AndAlso g.MeasureString(prueba, fuente).Width > ancho Then
                lineas += 1
                linea = palabra
            Else
                linea = prueba
            End If

        Next

        Return lineas * altoLinea

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
        pdConstancia.Dispose()
    End Sub

End Class
