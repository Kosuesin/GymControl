' =============================================================
' NumeroALetras
'
' Convierte valores numéricos a su expresión en letras en
' español. Se utiliza en los reportes para imprimir el monto
' de un recibo en letras (por ejemplo: "trescientos córdobas
' netos").
'
' Soporta hasta 999,999,999,999.99 (billones).
' =============================================================
Public Module NumeroALetras

    Private ReadOnly Unidades As String() = {
        "cero", "uno", "dos", "tres", "cuatro", "cinco",
        "seis", "siete", "ocho", "nueve", "diez", "once",
        "doce", "trece", "catorce", "quince", "dieciséis",
        "diecisiete", "dieciocho", "diecinueve", "veinte"
    }

    Private ReadOnly Veintenas As String() = {
        "", "veintiuno", "veintidós", "veintitrés", "veinticuatro",
        "veinticinco", "veintiséis", "veintisiete", "veintiocho",
        "veintinueve"
    }

    Private ReadOnly Decenas As String() = {
        "", "", "veinte", "treinta", "cuarenta", "cincuenta",
        "sesenta", "setenta", "ochenta", "noventa"
    }

    Private ReadOnly Centenas As String() = {
        "", "ciento", "doscientos", "trescientos", "cuatrocientos",
        "quinientos", "seiscientos", "setecientos", "ochocientos",
        "novecientos"
    }

    ''' <summary>
    ''' Convierte un monto decimal a letras agregando el nombre de
    ''' la moneda y el tratamiento de los centavos.
    ''' Ejemplo: 300.00 -> "trescientos córdobas netos".
    ''' </summary>
    Public Function Convertir(monto As Decimal,
                              Optional monedaPlural As String = "córdobas",
                              Optional monedaSingular As String = "córdoba") As String

        If monto < 0D Then
            Return "menos " & Convertir(-monto, monedaPlural, monedaSingular)
        End If

        Dim entero As Long = CLng(Decimal.Truncate(monto))
        Dim centavos As Integer = CInt(Decimal.Round((monto - entero) * 100D, 0, MidpointRounding.AwayFromZero))

        If centavos >= 100 Then
            entero += 1
            centavos -= 100
        End If

        Dim texto As String = If(entero = 1L, "un", ConvertirEntero(entero))

        If entero = 1L Then
            texto &= " " & monedaSingular
        Else
            texto &= " " & monedaPlural
        End If

        If centavos = 0 Then
            texto &= If(entero = 1L, " neto", " netos")
        Else
            texto &= " con " & centavos.ToString("00") & "/100 centavos"
        End If

        Return texto

    End Function

    ''' <summary>
    ''' Convierte la parte entera de un número a letras.
    ''' </summary>
    Public Function ConvertirEntero(numero As Long) As String

        If numero < 0L Then
            Return "menos " & ConvertirEntero(-numero)
        End If

        If numero = 0L Then Return "cero"
        If numero < 21L Then Return Unidades(CInt(numero))
        If numero < 30L Then Return Veintenas(CInt(numero - 20L))

        If numero < 100L Then
            Dim decena As Integer = CInt(numero \ 10L)
            Dim unidad As Integer = CInt(numero Mod 10L)
            If unidad = 0 Then Return Decenas(decena)
            Return Decenas(decena) & " y " & Unidades(unidad)
        End If

        If numero = 100L Then Return "cien"

        If numero < 1000L Then
            Dim centena As Integer = CInt(numero \ 100L)
            Dim resto As Long = numero Mod 100L
            If resto = 0L Then Return Centenas(centena)
            Return Centenas(centena) & " " & ConvertirEntero(resto)
        End If

        If numero < 1000000L Then
            Dim miles As Long = numero \ 1000L
            Dim resto As Long = numero Mod 1000L
            Dim textoMiles As String

            If miles = 1L Then
                textoMiles = "mil"
            Else
                textoMiles = Apocope(ConvertirEntero(miles)) & " mil"
            End If

            If resto = 0L Then Return textoMiles
            Return textoMiles & " " & ConvertirEntero(resto)
        End If

        If numero < 1000000000000L Then
            Dim millones As Long = numero \ 1000000L
            Dim resto As Long = numero Mod 1000000L
            Dim textoMillones As String

            If millones = 1L Then
                textoMillones = "un millón"
            Else
                textoMillones = Apocope(ConvertirEntero(millones)) & " millones"
            End If

            If resto = 0L Then Return textoMillones
            Return textoMillones & " " & ConvertirEntero(resto)
        End If

        Return numero.ToString()

    End Function

    ''' <summary>
    ''' Aplica la apócope necesaria antes de "mil" o "millón":
    ''' "uno" -> "un", "veintiuno" -> "veintiún".
    ''' </summary>
    Private Function Apocope(texto As String) As String

        If texto.EndsWith("veintiuno", StringComparison.Ordinal) Then
            Return texto.Substring(0, texto.Length - 9) & "veintiún"
        End If

        If texto.EndsWith("uno", StringComparison.Ordinal) Then
            Return texto.Substring(0, texto.Length - 3) & "un"
        End If

        Return texto

    End Function

End Module
