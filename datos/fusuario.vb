Imports System.Data.SqlClient
Imports entidad
Public Class fusuario

    Inherits fconecion

    Public Function validarusuario(ByVal dts As eusuario) As DataTable
        conectado()
        cmd = New SqlCommand("iniciosesion")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnn

        cmd.Parameters.AddWithValue("@Usuario", dts._users)
        cmd.Parameters.AddWithValue("@Password", dts._password)

        If cmd.ExecuteNonQuery Then
            Using dt As New DataTable
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        Else
            Return Nothing
        End If


    End Function
End Class
