Imports MySqlConnector
Imports System.Data

Public Class PagoDAO

    Public Function ListarPagosPorMembresia(idMembresia As Integer) As DataTable
        Dim tabla As New DataTable()
        Const sql As String =
            "SELECT p.id_pago, p.fecha_pago, p.monto, p.metodo_pago, " &
            "u.nombre_usuario AS Registrado, " &
            "CASE WHEN p.anulado = 1 THEN 'ANULADO' ELSE 'VIGENTE' END AS Estado " &
            "FROM pagos p INNER JOIN usuarios u ON p.id_usuario_registro = u.id_usuario " &
            "WHERE p.id_membresia = @idMembresia ORDER BY p.fecha_pago DESC, p.id_pago DESC"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idMembresia", idMembresia)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        End Using
        Return tabla
    End Function

    Public Function ObtenerTotalesPago(idMembresia As Integer) As DataRow
        Dim tabla As New DataTable()
        Const sql As String =
            "SELECT m.precio_pactado AS Total, " &
            "COALESCE(SUM(CASE WHEN p.anulado = 0 THEN p.monto ELSE 0 END), 0) AS Pagado " &
            "FROM membresias m LEFT JOIN pagos p ON p.id_membresia = m.id_membresia " &
            "WHERE m.id_membresia = @idMembresia GROUP BY m.id_membresia, m.precio_pactado"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idMembresia", idMembresia)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        End Using
        If tabla.Rows.Count = 0 Then Return Nothing
        Return tabla.Rows(0)
    End Function

    Public Function InsertarPago(idMembresia As Integer, idUsuario As Integer,
                                 monto As Decimal, metodoPago As String,
                                 referencia As String, observacion As String) As Boolean
        Const sql As String =
            "INSERT INTO pagos (id_membresia, id_usuario_registro, monto, metodo_pago, referencia, observacion, anulado) " &
            "VALUES (@idMembresia, @idUsuario, @monto, @metodoPago, @referencia, @observacion, 0)"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idMembresia", idMembresia)
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario)
                cmd.Parameters.AddWithValue("@monto", monto)
                cmd.Parameters.AddWithValue("@metodoPago", metodoPago)
                cmd.Parameters.AddWithValue("@referencia", If(String.IsNullOrWhiteSpace(referencia), CType(DBNull.Value, Object), referencia.Trim()))
                cmd.Parameters.AddWithValue("@observacion", If(String.IsNullOrWhiteSpace(observacion), CType(DBNull.Value, Object), observacion.Trim()))
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function AnularPago(idPago As Integer) As Boolean
        Const sql As String = "UPDATE pagos SET anulado = 1 WHERE id_pago = @idPago AND anulado = 0"
        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idPago", idPago)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

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
