Imports System.Data
Imports System.Globalization
Imports QuestPDF.Fluent
Imports QuestPDF.Helpers
Imports QuestPDF.Infrastructure

Public NotInheritable Class PdfInformeMensual
    Private Sub New()
    End Sub

    Public Shared Sub Generar(mes As Date, indicadores As DataTable,
                             planes As DataTable, saldos As DataTable,
                             instructores As DataTable, usuario As String, ruta As String)
        QuestPDF.Settings.License = LicenseType.Community
        Dim cultura As New CultureInfo("es-NI")
        Dim periodo = mes.ToString("MMMM yyyy", cultura)
        Dim fila = indicadores.Rows(0)
        Dim activos = Convert.ToInt32(fila("socios_activos"))
        Dim nuevas = Convert.ToInt32(fila("nuevas_membresias"))
        Dim ingresos = Convert.ToDecimal(fila("ingresos"))
        Dim cartera = Convert.ToDecimal(fila("cartera"))

        Document.Create(Sub(doc)
            doc.Page(Sub(pagina)
                pagina.Size(PageSizes.A4)
                pagina.Margin(30)
                pagina.DefaultTextStyle(Function(t) t.FontSize(10))
                pagina.Header().Column(Sub(c)
                    c.Item().Text("GIMNASIO TITÁN | GYMCONTROL").Bold().FontSize(17).FontColor(Colors.Blue.Darken3)
                    c.Item().Text("Informe gerencial mensual · " & periodo).FontSize(12)
                    c.Item().Text("Generado: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm"))
                    c.Item().PaddingBottom(8).LineHorizontal(1).LineColor(Colors.Grey.Lighten2)
                End Sub)
                pagina.Content().Column(Sub(c)
                    c.Spacing(12)
                    c.Item().Text("INDICADORES PRINCIPALES").Bold().FontSize(12)
                    c.Item().Table(Sub(t)
                        t.ColumnsDefinition(Sub(cols)
                            cols.RelativeColumn()
                            cols.RelativeColumn()
                        End Sub)
                        Celda(t, "Socios activos", activos.ToString())
                        Celda(t, "Nuevas membresías", nuevas.ToString())
                        Celda(t, "Ingresos del mes", Dinero(ingresos))
                        Celda(t, "Cartera pendiente actual", Dinero(cartera))
                    End Sub)
                    Tabla(c, "INGRESOS POR TIPO DE MEMBRESÍA", planes,
                          New String() {"Plan", "Pagos", "Total"},
                          New String() {"plan", "pagos", "total"}, 2)
                    Tabla(c, "10 MAYORES SALDOS PENDIENTES", saldos,
                          New String() {"Socio", "Plan", "Vence", "Saldo"},
                          New String() {"socio", "plan", "fecha_vencimiento", "saldo"}, 3)
                    Tabla(c, "HORAS SEMANALES POR INSTRUCTOR", instructores,
                          New String() {"Instructor", "Clases", "Horas"},
                          New String() {"instructor", "clases", "horas"}, -1)
                End Sub)
                pagina.Footer().Row(Sub(r)
                    r.RelativeItem().Text("Generado por: " & If(String.IsNullOrWhiteSpace(usuario), "Sistema", usuario)).FontSize(8)
                    r.ConstantItem(115).AlignRight().Text(Sub(t)
                        t.Span("Página ")
                        t.CurrentPageNumber()
                        t.Span(" de ")
                        t.TotalPages()
                    End Sub)
                End Sub)
            End Sub)
        End Sub).GeneratePdf(ruta)
    End Sub

    Private Shared Function Dinero(valor As Decimal) As String
        Return "C$ " & valor.ToString("#,##0.00", New CultureInfo("es-NI"))
    End Function

    Private Shared Sub Celda(t As QuestPDF.Fluent.TableDescriptor, etiqueta As String, valor As String)
        t.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2).Padding(6).Text(etiqueta)
        t.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2).Padding(6).Text(valor).Bold()
    End Sub

    Private Shared Sub Tabla(c As QuestPDF.Fluent.ColumnDescriptor, titulo As String,
                             datos As DataTable, encabezados As String(), campos As String(), monedaCol As Integer)
        c.Item().Text(titulo).Bold().FontSize(11).FontColor(Colors.Blue.Darken3)
        If datos.Rows.Count = 0 Then
            c.Item().Text("Sin registros para mostrar.").Italic()
            Return
        End If
        c.Item().Table(Sub(t)
            t.ColumnsDefinition(Sub(cols)
                For Each nombre In encabezados
                    cols.RelativeColumn()
                Next
            End Sub)
            t.Header(Sub(h)
                For Each nombre In encabezados
                    h.Cell().Background(Colors.Blue.Darken3).Padding(5).Text(nombre).FontColor(Colors.White).Bold()
                Next
            End Sub)
            For Each fila As DataRow In datos.Rows
                For i As Integer = 0 To campos.Length - 1
                    Dim valor As String = If(IsDBNull(fila(campos(i))), "", fila(campos(i)).ToString())
                    If i = monedaCol Then valor = Dinero(Convert.ToDecimal(fila(campos(i))))
                    If campos(i) = "fecha_vencimiento" AndAlso Not IsDBNull(fila(campos(i))) Then
                        valor = Convert.ToDateTime(fila(campos(i))).ToString("dd/MM/yyyy")
                    End If
                    t.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten2).Padding(4).Text(valor)
                Next
            Next
        End Sub)
    End Sub
End Class
