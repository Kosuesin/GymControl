' =============================================================
' ImpresionUtil
'
' Funciones de apoyo compartidas por los documentos imprimibles
' (recibos, constancias y listados). Centraliza el ajuste de
' texto, el recorte con puntos suspensivos, el dibujo centrado
' y el formato de moneda para no duplicar código en cada
' PrintDocument.
' =============================================================
Imports System.Drawing
Imports System.Globalization

Public Module ImpresionUtil

    ''' <summary>
    ''' Formatea un valor monetario con el separador de la cultura
    ''' actual: "C$ 1,250.00".
    ''' </summary>
    Public Function FormatearMoneda(valor As Decimal) As String
        Return "C$ " & valor.ToString("N2", CultureInfo.CurrentCulture)
    End Function

    ''' <summary>
    ''' Dibuja un texto centrado horizontalmente y devuelve el alto
    ''' ocupado por la línea.
    ''' </summary>
    Public Function DibujarCentrado(g As Graphics, texto As String, fuente As Font,
                                    pincel As Brush, x As Single, y As Single,
                                    ancho As Single) As Single

        If String.IsNullOrEmpty(texto) Then Return 0.0F

        Dim tamano As SizeF = g.MeasureString(texto, fuente)
        g.DrawString(texto, fuente, pincel, x + ((ancho - tamano.Width) / 2.0F), y)
        Return tamano.Height

    End Function

    ''' <summary>
    ''' Dibuja un párrafo con ajuste automático de palabras y
    ''' devuelve la coordenada Y donde terminó el dibujo.
    ''' </summary>
    Public Function DibujarParrafo(g As Graphics, texto As String, fuente As Font,
                                   pincel As Brush, x As Single, y As Single,
                                   ancho As Single,
                                   Optional interlineado As Single = 1.0F) As Single

        If String.IsNullOrEmpty(texto) Then Return y

        Dim altoLinea As Single = fuente.GetHeight(g) * interlineado
        Dim palabras As String() = texto.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
        Dim linea As String = String.Empty
        Dim yActual As Single = y

        For Each palabra As String In palabras

            Dim prueba As String = If(linea.Length = 0, palabra, linea & " " & palabra)

            If linea.Length > 0 AndAlso g.MeasureString(prueba, fuente).Width > ancho Then
                g.DrawString(linea, fuente, pincel, x, yActual)
                yActual += altoLinea
                linea = palabra
            Else
                linea = prueba
            End If

        Next

        If linea.Length > 0 Then
            g.DrawString(linea, fuente, pincel, x, yActual)
            yActual += altoLinea
        End If

        Return yActual

    End Function

    ''' <summary>
    ''' Dibuja un párrafo dentro de un rectángulo delimitado
    ''' (RectangleF) usando MeasureString para calcular los cortes
    ''' de línea. Devuelve la Y final del contenido dibujado.
    ''' </summary>
    Public Function DibujarParrafoEnRectangulo(g As Graphics, texto As String, fuente As Font,
                                               pincel As Brush, rectangulo As RectangleF,
                                               Optional interlineado As Single = 1.15F) As Single

        If String.IsNullOrEmpty(texto) Then Return rectangulo.Y

        Dim altoLinea As Single = fuente.GetHeight(g) * interlineado
        Dim palabras As String() = texto.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
        Dim linea As String = String.Empty
        Dim yActual As Single = rectangulo.Y

        For Each palabra As String In palabras

            Dim prueba As String = If(linea.Length = 0, palabra, linea & " " & palabra)
            Dim anchoPrueba As Single = g.MeasureString(prueba, fuente).Width

            If linea.Length > 0 AndAlso anchoPrueba > rectangulo.Width Then
                If yActual + altoLinea > rectangulo.Bottom Then Exit For
                g.DrawString(linea, fuente, pincel, rectangulo.X, yActual)
                yActual += altoLinea
                linea = palabra
            Else
                linea = prueba
            End If

        Next

        If linea.Length > 0 AndAlso yActual + altoLinea <= rectangulo.Bottom Then
            g.DrawString(linea, fuente, pincel, rectangulo.X, yActual)
            yActual += altoLinea
        End If

        Return yActual

    End Function

    ''' <summary>
    ''' Recorta un texto agregando puntos suspensivos si excede el
    ''' ancho disponible.
    ''' </summary>
    Public Function Recortar(g As Graphics, texto As String, fuente As Font, anchoMaximo As Single) As String

        If String.IsNullOrEmpty(texto) Then Return String.Empty
        If anchoMaximo <= 0.0F Then Return String.Empty
        If g.MeasureString(texto, fuente).Width <= anchoMaximo Then Return texto

        Dim recorte As String = texto

        While recorte.Length > 1 AndAlso
              g.MeasureString(recorte & "...", fuente).Width > anchoMaximo
            recorte = recorte.Substring(0, recorte.Length - 1)
        End While

        Return recorte.TrimEnd() & "..."

    End Function

    ''' <summary>
    ''' Dibuja una línea horizontal.
    ''' </summary>
    Public Sub DibujarLinea(g As Graphics, lapiz As Pen, x1 As Single, y As Single, x2 As Single)
        g.DrawLine(lapiz, x1, y, x2, y)
    End Sub

    ''' <summary>
    ''' Dibuja una línea punteada horizontal (separadores de ticket).
    ''' </summary>
    Public Sub DibujarSeparadorPunteado(g As Graphics, lapiz As Pen, x1 As Single, y As Single, x2 As Single)
        g.DrawLine(lapiz, x1, y, x2, y)
    End Sub

End Module
