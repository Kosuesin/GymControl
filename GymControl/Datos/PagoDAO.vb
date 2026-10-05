Imports MySqlConnector

Public Class PagoDAO

    ' =========================================================
    ' OBTENER INGRESOS DEL MES
    '
    ' Suma el monto de los pagos registrados dentro
    ' del mes de la fecha indicada, excluyendo los
    ' pagos anulados (anulado = 0).
    ' =========================================================
    Public Function ObtenerIngresosDelMes(
        fechaReferencia As Date
    ) As Decimal

        Dim fechaInicio As New Date(
            fechaReferencia.Year,
            fechaReferencia.Month,
            1
        )

        Dim fechaFin As Date =
            fechaInicio.AddMonths(1)

        Dim sql As String =
            "SELECT SUM(monto)
             FROM pagos
             WHERE anulado = @anulado
               AND fecha_pago >= @fechaInicio
               AND fecha_pago < @fechaFin"

        Using cn As MySqlConnection =
            ConexionBD.ObtenerConexion()

            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue(
                    "@anulado",
                    0
                )

                cmd.Parameters.AddWithValue(
                    "@fechaInicio",
                    fechaInicio
                )

                cmd.Parameters.AddWithValue(
                    "@fechaFin",
                    fechaFin
                )

                cn.Open()

                Dim resultado As Object =
                    cmd.ExecuteScalar()

                If resultado Is Nothing OrElse
                   IsDBNull(resultado) Then

                    Return 0D

                End If

                Return Convert.ToDecimal(resultado)

            End Using

        End Using

    End Function

End Class
