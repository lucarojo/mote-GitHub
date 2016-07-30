Imports entidad
Imports datos

Public Class login

    Dim fu As New fusuario
    Dim eu As New eusuario


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Try
            If txtPassword.Text <> "" And txtUsuario.Text <> "" Then
                Dim dt As New DataTable

                eu._users = txtUsuario.Text
                eu._password = txtPassword.Text
                dt = fu.validarusuario(eu)

                If dt.Rows.Count > 0 Then
                    Timer1.Start()

                    'Dim nivel As String
                    'nivel = dt.Rows(0)("Grado")
                    'If nivel = "Alumno" Then
                    'ElseIf nivel = "Administrador" Then

                    'End If
                Else
                    MsgBox("Información incorrecta!", MsgBoxStyle.Critical, "Sistema")

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            MsgBox("Bienvenido " & txtUsuario.Text, MsgBoxStyle.OkOnly, "Sistema")
            usuarionombre = txtUsuario.Text
            Form4.Show()
            ProgressBar1.Value = 0
            txtPassword.Text = ""
            txtUsuario.Text = ""
            Form1.Hide()
        End If


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
    End Sub
End Class