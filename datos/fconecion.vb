﻿Imports System.Data.SqlClient
Public Class fconecion
    Public cnn As New SqlConnection
    Public cmd As New SqlCommand

    Public Function conectado()
        Try
            cnn = New SqlConnection(My.Settings.MATE)
            cnn.Open()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
