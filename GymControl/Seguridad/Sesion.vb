Public Class Sesion

    Public Shared Property IdUsuario As Integer
    Public Shared Property NombreUsuario As String
    Public Shared Property Rol As String
    Public Shared Property IdSocio As Integer?
    Public Shared Property IdInstructor As Integer?

    Public Shared Sub CerrarSesion()

        IdUsuario = 0
        NombreUsuario = String.Empty
        Rol = String.Empty
        IdSocio = Nothing
        IdInstructor = Nothing


    End Sub

    Public Shared Function HaySesion() As Boolean

        Return IdUsuario > 0 AndAlso
               Not String.IsNullOrWhiteSpace(NombreUsuario)

    End Function

End Class