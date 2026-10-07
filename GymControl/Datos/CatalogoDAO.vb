Imports MySqlConnector
Imports System.Data

Public Class CatalogoDAO

    ' =========================================================
    ' CATÁLOGO: ACTIVIDADES
    ' =========================================================

    Public Function ListarActividades(Optional incluirInactivas As Boolean = True) As DataTable
        Dim tabla As New DataTable()
        Dim sql As String =
            "SELECT id_actividad, nombre, descripcion, duracion_min, cupo_maximo, " &
            "CASE WHEN activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado " &
            "FROM actividades " &
            "WHERE (@incluirInactivas = 1 OR activo = 1) " &
            "ORDER BY nombre"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@incluirInactivas", If(incluirInactivas, 1, 0))
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        End Using
        Return tabla
    End Function

    Public Function ListarActividadesParaCombo() As DataTable
        Dim tabla As New DataTable()
        Const sql As String =
            "SELECT id_actividad, nombre FROM actividades WHERE activo = 1 ORDER BY nombre"

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

    Public Function ObtenerActividadPorId(idActividad As Integer) As DataRow
        Dim tabla As New DataTable()
        Const sql As String =
            "SELECT id_actividad, nombre, descripcion, duracion_min, cupo_maximo, activo " &
            "FROM actividades WHERE id_actividad = @idActividad LIMIT 1"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idActividad", idActividad)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        End Using
        If tabla.Rows.Count = 0 Then Return Nothing
        Return tabla.Rows(0)
    End Function

    Public Function ExisteNombreActividad(nombre As String, Optional excluirId As Integer? = Nothing) As Boolean
        Const sql As String =
            "SELECT COUNT(*) FROM actividades " &
            "WHERE nombre = @nombre AND (@excluirId IS NULL OR id_actividad <> @excluirId)"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@nombre", If(nombre, "").Trim())
                cmd.Parameters.AddWithValue("@excluirId", If(excluirId.HasValue, CType(excluirId.Value, Object), DBNull.Value))
                cn.Open()
                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

    Public Function InsertarActividad(nombre As String, descripcion As String,
                                      duracionMin As Integer, cupoMaximo As Integer,
                                      activo As Boolean) As Boolean
        Const sql As String =
            "INSERT INTO actividades (nombre, descripcion, duracion_min, cupo_maximo, activo) " &
            "VALUES (@nombre, @descripcion, @duracionMin, @cupoMaximo, @activo)"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                AgregarParametrosActividad(cmd, nombre, descripcion, duracionMin, cupoMaximo, activo)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function ActualizarActividad(idActividad As Integer, nombre As String, descripcion As String,
                                        duracionMin As Integer, cupoMaximo As Integer,
                                        activo As Boolean) As Boolean
        Const sql As String =
            "UPDATE actividades SET nombre = @nombre, descripcion = @descripcion, " &
            "duracion_min = @duracionMin, cupo_maximo = @cupoMaximo, activo = @activo " &
            "WHERE id_actividad = @idActividad"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                AgregarParametrosActividad(cmd, nombre, descripcion, duracionMin, cupoMaximo, activo)
                cmd.Parameters.AddWithValue("@idActividad", idActividad)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function DesactivarActividad(idActividad As Integer) As Boolean
        Const sql As String = "UPDATE actividades SET activo = 0 WHERE id_actividad = @idActividad AND activo = 1"
        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idActividad", idActividad)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Private Sub AgregarParametrosActividad(cmd As MySqlCommand, nombre As String, descripcion As String,
                                           duracionMin As Integer, cupoMaximo As Integer, activo As Boolean)
        cmd.Parameters.AddWithValue("@nombre", nombre.Trim())
        cmd.Parameters.AddWithValue("@descripcion", If(String.IsNullOrWhiteSpace(descripcion), CType(DBNull.Value, Object), descripcion.Trim()))
        cmd.Parameters.AddWithValue("@duracionMin", duracionMin)
        cmd.Parameters.AddWithValue("@cupoMaximo", cupoMaximo)
        cmd.Parameters.AddWithValue("@activo", If(activo, 1, 0))
    End Sub

    ' =========================================================
    ' CATÁLOGO: SALAS
    ' =========================================================

    Public Function ListarSalas(Optional incluirInactivas As Boolean = True) As DataTable
        Dim tabla As New DataTable()
        Dim sql As String =
            "SELECT id_sala, nombre, capacidad, " &
            "CASE WHEN activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado " &
            "FROM salas " &
            "WHERE (@incluirInactivas = 1 OR activo = 1) " &
            "ORDER BY nombre"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@incluirInactivas", If(incluirInactivas, 1, 0))
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        End Using
        Return tabla
    End Function

    Public Function ListarSalasParaCombo() As DataTable
        Dim tabla As New DataTable()
        Const sql As String =
            "SELECT id_sala, nombre FROM salas WHERE activo = 1 ORDER BY nombre"

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

    Public Function ObtenerSalaPorId(idSala As Integer) As DataRow
        Dim tabla As New DataTable()
        Const sql As String =
            "SELECT id_sala, nombre, capacidad, activo FROM salas WHERE id_sala = @idSala LIMIT 1"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idSala", idSala)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        End Using
        If tabla.Rows.Count = 0 Then Return Nothing
        Return tabla.Rows(0)
    End Function

    Public Function ExisteNombreSala(nombre As String, Optional excluirId As Integer? = Nothing) As Boolean
        Const sql As String =
            "SELECT COUNT(*) FROM salas " &
            "WHERE nombre = @nombre AND (@excluirId IS NULL OR id_sala <> @excluirId)"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@nombre", If(nombre, "").Trim())
                cmd.Parameters.AddWithValue("@excluirId", If(excluirId.HasValue, CType(excluirId.Value, Object), DBNull.Value))
                cn.Open()
                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

    Public Function InsertarSala(nombre As String, capacidad As Integer, activo As Boolean) As Boolean
        Const sql As String =
            "INSERT INTO salas (nombre, capacidad, activo) VALUES (@nombre, @capacidad, @activo)"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                AgregarParametrosSala(cmd, nombre, capacidad, activo)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function ActualizarSala(idSala As Integer, nombre As String, capacidad As Integer,
                                   activo As Boolean) As Boolean
        Const sql As String =
            "UPDATE salas SET nombre = @nombre, capacidad = @capacidad, activo = @activo " &
            "WHERE id_sala = @idSala"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                AgregarParametrosSala(cmd, nombre, capacidad, activo)
                cmd.Parameters.AddWithValue("@idSala", idSala)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function DesactivarSala(idSala As Integer) As Boolean
        Const sql As String = "UPDATE salas SET activo = 0 WHERE id_sala = @idSala AND activo = 1"
        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idSala", idSala)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Private Sub AgregarParametrosSala(cmd As MySqlCommand, nombre As String, capacidad As Integer, activo As Boolean)
        cmd.Parameters.AddWithValue("@nombre", nombre.Trim())
        cmd.Parameters.AddWithValue("@capacidad", capacidad)
        cmd.Parameters.AddWithValue("@activo", If(activo, 1, 0))
    End Sub

    ' =========================================================
    ' CATÁLOGO: TIPOS DE MEMBRESÍA
    ' (el combo del formulario lo provee MembresiaDAO)
    ' =========================================================

    Public Function ListarTiposMembresia(Optional incluirInactivos As Boolean = True) As DataTable
        Dim tabla As New DataTable()
        Dim sql As String =
            "SELECT id_tipo, nombre, descripcion, duracion_dias, precio, incluye_clases, " &
            "CASE WHEN activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado " &
            "FROM tipos_membresia " &
            "WHERE (@incluirInactivos = 1 OR activo = 1) " &
            "ORDER BY nombre"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@incluirInactivos", If(incluirInactivos, 1, 0))
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        End Using
        Return tabla
    End Function

    Public Function ObtenerTipoMembresiaPorId(idTipo As Integer) As DataRow
        Dim tabla As New DataTable()
        Const sql As String =
            "SELECT id_tipo, nombre, descripcion, duracion_dias, precio, incluye_clases, activo " &
            "FROM tipos_membresia WHERE id_tipo = @idTipo LIMIT 1"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idTipo", idTipo)
                cn.Open()
                Using adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        End Using
        If tabla.Rows.Count = 0 Then Return Nothing
        Return tabla.Rows(0)
    End Function

    Public Function ExisteNombreTipoMembresia(nombre As String, Optional excluirId As Integer? = Nothing) As Boolean
        Const sql As String =
            "SELECT COUNT(*) FROM tipos_membresia " &
            "WHERE nombre = @nombre AND (@excluirId IS NULL OR id_tipo <> @excluirId)"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@nombre", If(nombre, "").Trim())
                cmd.Parameters.AddWithValue("@excluirId", If(excluirId.HasValue, CType(excluirId.Value, Object), DBNull.Value))
                cn.Open()
                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

    Public Function InsertarTipoMembresia(nombre As String, descripcion As String, duracionDias As Integer,
                                          precio As Decimal, incluyeClases As Boolean,
                                          activo As Boolean) As Boolean
        Const sql As String =
            "INSERT INTO tipos_membresia (nombre, descripcion, duracion_dias, precio, incluye_clases, activo) " &
            "VALUES (@nombre, @descripcion, @duracionDias, @precio, @incluyeClases, @activo)"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                AgregarParametrosTipoMembresia(cmd, nombre, descripcion, duracionDias, precio, incluyeClases, activo)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function ActualizarTipoMembresia(idTipo As Integer, nombre As String, descripcion As String,
                                            duracionDias As Integer, precio As Decimal, incluyeClases As Boolean,
                                            activo As Boolean) As Boolean
        Const sql As String =
            "UPDATE tipos_membresia SET nombre = @nombre, descripcion = @descripcion, " &
            "duracion_dias = @duracionDias, precio = @precio, incluye_clases = @incluyeClases, activo = @activo " &
            "WHERE id_tipo = @idTipo"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                AgregarParametrosTipoMembresia(cmd, nombre, descripcion, duracionDias, precio, incluyeClases, activo)
                cmd.Parameters.AddWithValue("@idTipo", idTipo)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function DesactivarTipoMembresia(idTipo As Integer) As Boolean
        Const sql As String = "UPDATE tipos_membresia SET activo = 0 WHERE id_tipo = @idTipo AND activo = 1"
        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@idTipo", idTipo)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Private Sub AgregarParametrosTipoMembresia(cmd As MySqlCommand, nombre As String, descripcion As String,
                                               duracionDias As Integer, precio As Decimal,
                                               incluyeClases As Boolean, activo As Boolean)
        cmd.Parameters.AddWithValue("@nombre", nombre.Trim())
        cmd.Parameters.AddWithValue("@descripcion", If(String.IsNullOrWhiteSpace(descripcion), CType(DBNull.Value, Object), descripcion.Trim()))
        cmd.Parameters.AddWithValue("@duracionDias", duracionDias)
        cmd.Parameters.AddWithValue("@precio", precio)
        cmd.Parameters.AddWithValue("@incluyeClases", If(incluyeClases, 1, 0))
        cmd.Parameters.AddWithValue("@activo", If(activo, 1, 0))
    End Sub

End Class
