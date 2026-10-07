Imports MySqlConnector
Imports System.Data

Public Class SocioDAO

    Public Function ListarSocios(Optional filtro As String = "", Optional estado As Integer? = Nothing) As DataTable
        Return BuscarSocios(filtro, estado)
    End Function

    Public Function BuscarSocios(filtro As String, estado As Integer?) As DataTable
        Dim tabla As New DataTable()
        Dim sql As String =
            "SELECT id_socio, cedula, " &
            "CONCAT(nombres, ' ', apellidos) AS Nombre, " &
            "CASE WHEN activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado " &
            "FROM socios " &
            "WHERE (@filtro = '' OR cedula LIKE CONCAT('%', @filtro, '%') " &
            "OR nombres LIKE CONCAT('%', @filtro, '%') " &
            "OR apellidos LIKE CONCAT('%', @filtro, '%')) " &
            "AND (@estado IS NULL OR activo = @estado) " &
            "ORDER BY apellidos, nombres"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@filtro", If(filtro, "").Trim())
                cmd.Parameters.AddWithValue("@estado", If(estado.HasValue, CType(estado.Value, Object), DBNull.Value))
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        End Using

        Return tabla
    End Function

    Public Function ObtenerSocioPorId(idSocio As Integer) As DataRow
        Dim tabla As New DataTable()
        Dim sql As String =
            "SELECT id_socio, cedula, nombres, apellidos, fecha_nacimiento, " &
            "genero, telefono, correo, direccion, fecha_registro, activo " &
            "FROM socios WHERE id_socio = @idSocio LIMIT 1"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idSocio", idSocio)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        End Using

        If tabla.Rows.Count = 0 Then Return Nothing
        Return tabla.Rows(0)
    End Function

    Public Function ExisteCedula(cedula As String, Optional excluirId As Integer? = Nothing) As Boolean
        Dim sql As String =
            "SELECT COUNT(*) FROM socios " &
            "WHERE cedula = @cedula AND (@excluirId IS NULL OR id_socio <> @excluirId)"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@cedula", cedula.Trim())
                cmd.Parameters.AddWithValue("@excluirId", If(excluirId.HasValue, CType(excluirId.Value, Object), DBNull.Value))
                cn.Open()
                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

    Public Function InsertarSocio(cedula As String, nombres As String, apellidos As String,
                                  fechaNacimiento As DateTime?, genero As String, telefono As String,
                                  correo As String, direccion As String, fechaRegistro As DateTime,
                                  activo As Boolean) As Boolean
        Dim sql As String =
            "INSERT INTO socios " &
            "(cedula, nombres, apellidos, fecha_nacimiento, genero, telefono, correo, direccion, fecha_registro, activo) " &
            "VALUES (@cedula, @nombres, @apellidos, @fechaNacimiento, @genero, @telefono, @correo, @direccion, @fechaRegistro, @activo)"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                AgregarParametros(cmd, cedula, nombres, apellidos, fechaNacimiento, genero, telefono, correo, direccion, fechaRegistro, activo)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function ActualizarSocio(idSocio As Integer, cedula As String, nombres As String, apellidos As String,
                                    fechaNacimiento As DateTime?, genero As String, telefono As String,
                                    correo As String, direccion As String, fechaRegistro As DateTime,
                                    activo As Boolean) As Boolean
        Dim sql As String =
            "UPDATE socios SET cedula = @cedula, nombres = @nombres, apellidos = @apellidos, " &
            "fecha_nacimiento = @fechaNacimiento, genero = @genero, telefono = @telefono, correo = @correo, " &
            "direccion = @direccion, fecha_registro = @fechaRegistro, activo = @activo " &
            "WHERE id_socio = @idSocio"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                AgregarParametros(cmd, cedula, nombres, apellidos, fechaNacimiento, genero, telefono, correo, direccion, fechaRegistro, activo)
                cmd.Parameters.AddWithValue("@idSocio", idSocio)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function DesactivarSocio(idSocio As Integer) As Boolean
        Const sql As String = "UPDATE socios SET activo = 0 WHERE id_socio = @idSocio AND activo = 1"
        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idSocio", idSocio)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Private Sub AgregarParametros(cmd As MySqlCommand, cedula As String, nombres As String, apellidos As String,
                                  fechaNacimiento As DateTime?, genero As String, telefono As String,
                                  correo As String, direccion As String, fechaRegistro As DateTime,
                                  activo As Boolean)
        cmd.Parameters.AddWithValue("@cedula", cedula)
        cmd.Parameters.AddWithValue("@nombres", nombres)
        cmd.Parameters.AddWithValue("@apellidos", apellidos)
        cmd.Parameters.AddWithValue("@fechaNacimiento", If(fechaNacimiento.HasValue, CType(fechaNacimiento.Value.Date, Object), DBNull.Value))
        cmd.Parameters.AddWithValue("@genero", If(String.IsNullOrWhiteSpace(genero), CType(DBNull.Value, Object), genero))
        cmd.Parameters.AddWithValue("@telefono", If(String.IsNullOrWhiteSpace(telefono), CType(DBNull.Value, Object), telefono))
        cmd.Parameters.AddWithValue("@correo", If(String.IsNullOrWhiteSpace(correo), CType(DBNull.Value, Object), correo))
        cmd.Parameters.AddWithValue("@direccion", If(String.IsNullOrWhiteSpace(direccion), CType(DBNull.Value, Object), direccion))
        cmd.Parameters.AddWithValue("@fechaRegistro", fechaRegistro.Date)
        cmd.Parameters.AddWithValue("@activo", If(activo, 1, 0))
    End Sub

End Class
