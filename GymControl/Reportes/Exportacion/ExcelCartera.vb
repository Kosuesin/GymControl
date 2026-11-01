
Imports ClosedXML.Excel
Imports System.Data

Public Class ExcelCartera

    Public Shared Sub Generar(datos As DataTable,
                              ruta As String)

        If datos Is Nothing Then
            Throw New ArgumentNullException(NameOf(datos))
        End If

        Using libro As New XLWorkbook()

            Dim hoja = libro.Worksheets.Add("Cartera")

            ' Título
            hoja.Range("A1:K1").Merge()
            hoja.Cell("A1").Value = "GIMNASIO TITÁN - CARTERA DE SALDOS"
            hoja.Cell("A1").Style.Font.Bold = True
            hoja.Cell("A1").Style.Font.FontSize = 16
            hoja.Cell("A1").Style.Fill.BackgroundColor =
                XLColor.FromHtml("#193D88")
            hoja.Cell("A1").Style.Font.FontColor = XLColor.White

            hoja.Range("A2:K2").Merge()
            hoja.Cell("A2").Value =
                "Fecha de corte: " & Date.Today.ToString("dd/MM/yyyy")

            Dim encabezados = {
                "Cédula", "Socio", "Teléfono", "Plan",
                "Inicio", "Vence", "Precio C$",
                "Pagado C$", "Saldo C$",
                "Días vencidos", "Categoría"
            }

            For i As Integer = 0 To encabezados.Length - 1
                hoja.Cell(4, i + 1).Value = encabezados(i)
            Next

            Dim fila As Integer = 5

            For Each registro As DataRow In datos.Rows

                hoja.Cell(fila, 1).Value = registro("cedula").ToString()
                hoja.Cell(fila, 2).Value = registro("socio").ToString()
                hoja.Cell(fila, 3).Value = registro("telefono").ToString()
                hoja.Cell(fila, 4).Value = registro("tipo_membresia").ToString()

                hoja.Cell(fila, 5).Value =
                    Convert.ToDateTime(registro("fecha_inicio"))

                hoja.Cell(fila, 6).Value =
                    Convert.ToDateTime(registro("fecha_vencimiento"))

                hoja.Cell(fila, 7).Value =
                    Convert.ToDecimal(registro("precio_pactado"))

                hoja.Cell(fila, 8).Value =
                    Convert.ToDecimal(registro("total_pagado_membresia"))

                hoja.Cell(fila, 9).FormulaA1 =
                    $"=MAX(G{fila}-H{fila},0)"

                hoja.Cell(fila, 10).FormulaA1 =
                    $"=MAX(TODAY()-F{fila},0)"

                hoja.Cell(fila, 11).FormulaA1 =
                    $"=IF(I{fila}<=0,""Al día"",IF(J{fila}=0,""Al día"",IF(J{fila}<=30,""1-30"",IF(J{fila}<=60,""31-60"",""Más de 60""))))"

                fila += 1
            Next

            Dim ultimaFila As Integer = fila - 1

            ' Encabezados
            With hoja.Range("A4:K4").Style
                .Fill.BackgroundColor = XLColor.FromHtml("#193D88")
                .Font.FontColor = XLColor.White
                .Font.Bold = True
            End With

            hoja.Range($"E5:F{Math.Max(5, ultimaFila)}").
                Style.DateFormat.Format = "dd/MM/yyyy"

            hoja.Range($"G5:I{Math.Max(5, ultimaFila)}").
                Style.NumberFormat.Format = """C$ ""#,##0.00"

            If ultimaFila >= 5 Then
                hoja.Range($"A4:K{ultimaFila}").SetAutoFilter()
            End If

            hoja.SheetView.FreezeRows(4)

            ' Formato condicional para las categorías de vencimiento
            If ultimaFila >= 5 Then

                Dim rangoCategorias = hoja.Range($"K5:K{ultimaFila}")

                rangoCategorias.AddConditionalFormat().
        WhenEquals("""Al día""").
        Fill.SetBackgroundColor(XLColor.LightGreen)

                rangoCategorias.AddConditionalFormat().
        WhenEquals("""1-30""").
        Fill.SetBackgroundColor(XLColor.LightYellow)

                rangoCategorias.AddConditionalFormat().
        WhenEquals("""31-60""").
        Fill.SetBackgroundColor(XLColor.LightSalmon)

                rangoCategorias.AddConditionalFormat().
        WhenEquals("""Más de 60""").
        Fill.SetBackgroundColor(XLColor.LightPink)

            End If


            ' Totales que respetan los filtros
            Dim filaTotal As Integer = fila + 1

            hoja.Cell(filaTotal, 2).Value = "TOTAL VISIBLE"

            For columna As Integer = 7 To 9
                Dim letra = hoja.Column(columna).ColumnLetter()
                hoja.Cell(filaTotal, columna).FormulaA1 =
                    $"=SUBTOTAL(109,{letra}5:{letra}{ultimaFila})"
            Next

            hoja.Range(filaTotal, 2, filaTotal, 9).
                Style.Font.Bold = True

            hoja.Range(filaTotal, 7, filaTotal, 9).
                Style.NumberFormat.Format = """C$ ""#,##0.00"

            ' Segunda hoja
            Dim resumen = libro.Worksheets.Add("Resumen")

            resumen.Cell("A1").Value = "RESUMEN DE CARTERA"
            resumen.Cell("A1").Style.Font.Bold = True
            resumen.Cell("A1").Style.Font.FontSize = 16

            resumen.Cell("A3").Value = "Categoría"
            resumen.Cell("B3").Value = "Cantidad"
            resumen.Cell("C3").Value = "Saldo C$"

            Dim categorias = {
                "Al día", "1-30", "31-60", "Más de 60"
            }

            For i As Integer = 0 To categorias.Length - 1

                Dim r As Integer = i + 4

                resumen.Cell(r, 1).Value = categorias(i)

                resumen.Cell(r, 2).FormulaA1 =
                    $"=COUNTIF(Cartera!K5:K{Math.Max(5, ultimaFila)},A{r})"

                resumen.Cell(r, 3).FormulaA1 =
                    $"=SUMIF(Cartera!K5:K{Math.Max(5, ultimaFila)},A{r},Cartera!I5:I{Math.Max(5, ultimaFila)})"

            Next

            resumen.Range("A3:C3").Style.Fill.BackgroundColor =
                XLColor.FromHtml("#193D88")

            resumen.Range("A3:C3").Style.Font.FontColor =
                XLColor.White

            resumen.Range("A3:C3").Style.Font.Bold = True
            resumen.Range("C4:C7").Style.NumberFormat.Format =
                """C$ ""#,##0.00"

            hoja.Columns().AdjustToContents()
            resumen.Columns().AdjustToContents()

            libro.SaveAs(ruta)

        End Using

    End Sub

End Class
