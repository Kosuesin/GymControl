Imports MySqlConnector
Imports System.Data

Public Class InstructorDAO

    ' LISTADO / BUSQUEDA PARA EL GRID
    Public Function ListarInstructores(Optional filtro As String = "") As DataTable
        Dim tabla As New DataTable()
        Dim sql As String =
            "SELECT id_instructor, cedula, " &
            "CONCAT(nombres, ' ', apellidos) AS Nombre, " &
            "telefono, especialidad, " &
            "CASE WHEN activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado " &
            "FROM instructores " &
            "WHERE (@filtro = '' OR cedula LIKE CONCAT('%', @filtro, '%') " &
            "OR nombres LIKE CONCAT('%', @filtro, '%') " &
            "OR apellidos LIKE CONCAT('%', @filtro, '%') " &
            "OR especialidad LIKE CONCAT('%', @filtro, '%')) " &
            "ORDER BY apellidos, nombres"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@filtro", If(filtro, "").Trim())
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        End Using

        Return tabla
    End Function

    ' COMBO PARA OTROS FORMULARIOS (HORARIOS, USUARIOS)
    Public Function ListarParaCombo() As DataTable
        Dim tabla As New DataTable()
        Dim sql As String =
            "SELECT id_instructor, CONCAT(nombres, ' ', apellidos) AS nombre " &
            "FROM instructores WHERE activo = 1 " &
            "ORDER BY apellidos, nombres"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        End Using

        Return tabla
    End Function

    ' OBTENER UN INSTRUCTOR POR ID (DATOS COMPLETOS)
    Public Function ObtenerInstructorPorId(idInstructor As Integer) As DataRow
        Dim tabla As New DataTable()
        Dim sql As String =
            "SELECT id_instructor, cedula, nombres, apellidos, telefono, correo, " &
            "especialidad, fecha_contratacion, activo " &
            "FROM instructores WHERE id_instructor = @idInstructor LIMIT 1"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idInstructor", idInstructor)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        End Using

        If tabla.Rows.Count = 0 Then Return Nothing
        Return tabla.Rows(0)
    End Function

    ' VERIFICAR CEDULA UNICA
    Public Function ExisteCedula(cedula As String, Optional excluirId As Integer? = Nothing) As Boolean
        Dim sql As String =
            "SELECT COUNT(*) FROM instructores " &
            "WHERE cedula = @cedula AND (@excluirId IS NULL OR id_instructor <> @excluirId)"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@cedula", If(cedula, "").Trim())
                cmd.Parameters.AddWithValue("@excluirId", If(excluirId.HasValue, CType(excluirId.Value, Object), DBNull.Value))
                cn.Open()
                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

    Public Function InsertarInstructor(cedula As String, nombres As String, apellidos As String,
                                       telefono As String, correo As String, especialidad As String,
                                       fechaContratacion As DateTime?, activo As Boolean) As Boolean
        Dim sql As String =
            "INSERT INTO instructores " &
            "(cedula, nombres, apellidos, telefono, correo, especialidad, fecha_contratacion, activo) " &
            "VALUES (@cedula, @nombres, @apellidos, @telefono, @correo, @especialidad, @fechaContratacion, @activo)"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                AgregarParametros(cmd, cedula, nombres, apellidos, telefono, correo, especialidad, fechaContratacion, activo)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function ActualizarInstructor(idInstructor As Integer, cedula As String, nombres As String, apellidos As String,
                                         telefono As String, correo As String, especialidad As String,
                                         fechaContratacion As DateTime?, activo As Boolean) As Boolean
        Dim sql As String =
            "UPDATE instructores SET cedula = @cedula, nombres = @nombres, apellidos = @apellidos, " &
            "telefono = @telefono, correo = @correo, especialidad = @especialidad, " &
            "fecha_contratacion = @fechaContratacion, activo = @activo " &
            "WHERE id_instructor = @idInstructor"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                AgregarParametros(cmd, cedula, nombres, apellidos, telefono, correo, especialidad, fechaContratacion, activo)
                cmd.Parameters.AddWithValue("@idInstructor", idInstructor)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' BAJA LOGICA (NO ELIMINA EL REGISTRO POR LAS RELACIONES CON USUARIOS Y HORARIOS)
    Public Function DesactivarInstructor(idInstructor As Integer) As Boolean
        Const sql As String = "UPDATE instructores SET activo = 0 WHERE id_instructor = @idInstructor AND activo = 1"
        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idInstructor", idInstructor)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Private Sub AgregarParametros(cmd As MySqlCommand, cedula As String, nombres As String, apellidos As String,
                                  telefono As String, correo As String, especialidad As String,
                                  fechaContratacion As DateTime?, activo As Boolean)
        cmd.Parameters.AddWithValue("@cedula", If(String.IsNullOrWhiteSpace(cedula), CType(DBNull.Value, Object), cedula))
        cmd.Parameters.AddWithValue("@nombres", nombres)
        cmd.Parameters.AddWithValue("@apellidos", apellidos)
        cmd.Parameters.AddWithValue("@telefono", If(String.IsNullOrWhiteSpace(telefono), CType(DBNull.Value, Object), telefono))
        cmd.Parameters.AddWithValue("@correo", If(String.IsNullOrWhiteSpace(correo), CType(DBNull.Value, Object), correo))
        cmd.Parameters.AddWithValue("@especialidad", If(String.IsNullOrWhiteSpace(especialidad), CType(DBNull.Value, Object), especialidad))
        cmd.Parameters.AddWithValue("@fechaContratacion", If(fechaContratacion.HasValue, CType(fechaContratacion.Value.Date, Object), DBNull.Value))
        cmd.Parameters.AddWithValue("@activo", If(activo, 1, 0))
    End Sub

End Class
