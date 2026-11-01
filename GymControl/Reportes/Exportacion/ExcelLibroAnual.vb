Imports ClosedXML.Excel
Imports System.Data
Imports System.Globalization

Public NotInheritable Class ExcelLibroAnual
    Private Sub New()
    End Sub

    Public Shared Sub Generar(anio As Integer, datos As DataTable, ruta As String)
        Dim cultura As New CultureInfo("es-NI")
        Using libro As New XLWorkbook()
            Dim resumen = libro.Worksheets.Add("Resumen")
            resumen.Range("A1:F1").Merge()
            resumen.Cell("A1").Value = "GIMNASIO TITÁN - LIBRO DE INGRESOS " & anio
            resumen.Cell("A1").Style.Font.Bold = True
            resumen.Cell("A1").Style.Font.FontSize = 16
            Dim encabezados = {"Mes", "Efectivo", "Tarjeta", "Transferencia", "Total", "Variación"}
            For i = 0 To encabezados.Length - 1
                resumen.Cell(3, i + 1).Value = encabezados(i)
            Next
            For mes As Integer = 1 To 12
                Dim nombre = cultura.DateTimeFormat.GetMonthName(mes)
                nombre = Char.ToUpperInvariant(nombre(0)) & nombre.Substring(1)
                Dim hoja = libro.Worksheets.Add(nombre)
                hoja.Range("A1:G1").Merge()
                hoja.Cell("A1").Value = "INGRESOS - " & nombre.ToUpperInvariant() & " " & anio
                hoja.Cell("A1").Style.Font.Bold = True
                hoja.Cell("A1").Style.Font.FontSize = 15
                Dim titulos = {"Fecha", "Recibo", "Socio", "Plan", "Método", "Monto", "Anulado"}
                For j = 0 To titulos.Length - 1
                    hoja.Cell(4, j + 1).Value = titulos(j)
                Next
                Dim fila As Integer = 5
                For Each pago As DataRow In datos.Rows
                    Dim fecha = Convert.ToDateTime(pago("fecha_pago"))
                    If fecha.Month <> mes Then Continue For
                    hoja.Cell(fila, 1).Value = fecha
                    hoja.Cell(fila, 2).Value = Convert.ToInt32(pago("id_pago")).ToString("D6")
                    hoja.Cell(fila, 3).Value = pago("socio").ToString()
                    hoja.Cell(fila, 4).Value = pago("tipo_membresia").ToString()
                    hoja.Cell(fila, 5).Value = pago("metodo_pago").ToString()
                    hoja.Cell(fila, 6).Value = Convert.ToDecimal(pago("monto"))
                    hoja.Cell(fila, 7).Value = If(Convert.ToInt32(pago("anulado")) = 1, "Sí", "No")
                    fila += 1
                Next
                Dim fin = Math.Max(5, fila - 1)
                If fila = 5 Then hoja.Cell("A6").Value = "Sin pagos registrados"
                If fila > 5 Then hoja.Range($"A4:G{fila - 1}").CreateTable()
                hoja.Range($"A5:A{fin}").Style.DateFormat.Format = "dd/MM/yyyy"
                hoja.Range($"F5:F{fin}").Style.NumberFormat.Format = """C$ ""#,##0.00"
                hoja.Range("A4:G4").Style.Fill.BackgroundColor = XLColor.FromHtml("#193D88")
                hoja.Range("A4:G4").Style.Font.FontColor = XLColor.White
                hoja.SheetView.FreezeRows(4)
                hoja.Columns().AdjustToContents()
                Dim r = mes + 3
                resumen.Cell(r, 1).Value = nombre
                For metodo As Integer = 2 To 4
                    Dim etiqueta = encabezados(metodo - 1).ToUpperInvariant()
                    resumen.Cell(r, metodo).FormulaA1 = $"=SUMIFS('{nombre}'!F5:F{fin},'{nombre}'!E5:E{fin},""{etiqueta}"",'{nombre}'!G5:G{fin},""No"")"
                Next
                resumen.Cell(r, 5).FormulaA1 = $"=SUM(B{r}:D{r})"
                If mes > 1 Then resumen.Cell(r, 6).FormulaA1 = $"=IF(E{r - 1}=0,0,(E{r}-E{r - 1})/E{r - 1})"
            Next
            resumen.Cell("A17").Value = "TOTAL ANUAL"
            For j As Integer = 2 To 5
                Dim letra = resumen.Column(j).ColumnLetter()
                resumen.Cell(17, j).FormulaA1 = $"=SUM({letra}4:{letra}15)"
            Next
            resumen.Range("A3:F3").Style.Fill.BackgroundColor = XLColor.FromHtml("#193D88")
            resumen.Range("A3:F3").Style.Font.FontColor = XLColor.White
            resumen.Range("A3:F3").Style.Font.Bold = True
            resumen.Range("A17:F17").Style.Font.Bold = True
            resumen.Range("B4:E17").Style.NumberFormat.Format = """C$ ""#,##0.00"
            resumen.Range("F5:F15").Style.NumberFormat.Format = "0.00%"
            resumen.Range("F5:F15").AddConditionalFormat().WhenLessThan(0).Fill.SetBackgroundColor(XLColor.LightPink)
            resumen.Range("F5:F15").AddConditionalFormat().WhenGreaterThan(0).Fill.SetBackgroundColor(XLColor.LightGreen)
            resumen.Columns().AdjustToContents()
            resumen.SheetView.FreezeRows(3)
            resumen.Protect()
            libro.SaveAs(ruta)
        End Using
    End Sub
End Class
