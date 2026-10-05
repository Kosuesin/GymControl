Public Class Sesion

    Public Shared Property IdUsuario As Integer = 0
    Public Shared Property NombreUsuario As String = ""
    Public Shared Property Rol As String = ""

    Public Shared ReadOnly Property HaySesion As Boolean
        Get
            Return IdUsuario > 0
        End Get
    End Property

    Public Shared Sub Iniciar(
        nuevoIdUsuario As Integer,
        nuevoNombreUsuario As String,
        nuevoRol As String
    )

        IdUsuario = nuevoIdUsuario
        NombreUsuario = nuevoNombreUsuario
        Rol = nuevoRol

    End Sub

    Public Shared Sub Cerrar()

        IdUsuario = 0
        NombreUsuario = ""
        Rol = ""

    End Sub

End Class