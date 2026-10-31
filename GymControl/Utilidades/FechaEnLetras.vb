' =============================================================
' FechaEnLetras
'
' Formatea fechas con el estilo formal que se utiliza en las
' constancias y documentos legales del gimnasio.
'
' Ejemplo:
'   Formatear(#2026-10-18#) ->
'   "a los dieciocho días del mes de octubre del año dos mil veintiséis"
' =============================================================
Public Module FechaEnLetras

    Private ReadOnly Meses As String() = {
        "enero", "febrero", "marzo", "abril", "mayo", "junio",
        "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"
    }

    ''' <summary>
    ''' Devuelve la fecha en el formato formal usado en las
    ''' constancias: "a los dieciocho días del mes de octubre
    ''' del año dos mil veintiséis".
    ''' </summary>
    Public Function Formatear(fecha As Date) As String

        Dim anio As String = NumeroALetras.ConvertirEntero(fecha.Year)

        If fecha.Day = 1 Then
            Return "al primer día del mes de " & NombreMes(fecha.Month) &
                   " del año " & anio
        End If

        Return "a los " & NumeroALetras.ConvertirEntero(fecha.Day) &
               " días del mes de " & NombreMes(fecha.Month) &
               " del año " & anio

    End Function

    ''' <summary>
    ''' Devuelve la fecha en formato corto y legible:
    ''' "18 de octubre de 2026".
    ''' </summary>
    Public Function FormatearCorta(fecha As Date) As String
        Return fecha.Day.ToString() & " de " & NombreMes(fecha.Month) &
               " de " & fecha.Year.ToString()
    End Function

    ''' <summary>
    ''' Devuelve el nombre del mes en minúsculas (1 = enero).
    ''' </summary>
    Public Function NombreMes(numero As Integer) As String
        If numero < 1 OrElse numero > 12 Then Return String.Empty
        Return Meses(numero - 1)
    End Function

    ''' <summary>
    ''' Devuelve el día del mes escrito en letras.
    ''' </summary>
    Public Function DiaEnLetras(dia As Integer) As String
        If dia < 1 OrElse dia > 31 Then Return String.Empty
        Return NumeroALetras.ConvertirEntero(dia)
    End Function

End Module
