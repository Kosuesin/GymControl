Imports System.Security.Cryptography

Public Class Seguridad

    Private Const Iteraciones As Integer = 100000

    Public Shared Function GenerarSal() As String

        Return Convert.ToBase64String(
            RandomNumberGenerator.GetBytes(16)
        )

    End Function


    Public Shared Function CalcularHash(
        contrasena As String,
        sal As String
    ) As String

        Dim hash As Byte() =
            Rfc2898DeriveBytes.Pbkdf2(
                contrasena,
                Convert.FromBase64String(sal),
                Iteraciones,
                HashAlgorithmName.SHA256,
                32
            )

        Return Convert.ToBase64String(hash)

    End Function


    Public Shared Function Verificar(
        contrasena As String,
        sal As String,
        hashGuardado As String
    ) As Boolean

        Dim calculado As Byte() =
            Convert.FromBase64String(
                CalcularHash(contrasena, sal)
            )

        Dim guardado As Byte() =
            Convert.FromBase64String(hashGuardado)

        Return CryptographicOperations.FixedTimeEquals(
            calculado,
            guardado
        )

    End Function

End Class