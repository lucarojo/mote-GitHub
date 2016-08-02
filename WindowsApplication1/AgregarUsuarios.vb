Public Class AgregarUsuarios
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub AgregarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Usuarios' table. You can move, or remove it, as needed.
        Me.UsuariosTableAdapter.Fill(Me.DataSet1.Usuarios)
        'TODO: This line of code loads data into the 'DataSet1.Usuarios' table. You can move, or remove it, as needed.
        Me.UsuariosTableAdapter.Fill(Me.DataSet1.Usuarios)
        'TODO: This line of code loads data into the 'DataSet1.Usuarios' table. You can move, or remove it, as needed.
        Me.UsuariosTableAdapter.Fill(Me.DataSet1.Usuarios)
        If usuarionombre <> "admin" And usuarionombre <> "lucarojo" Then
            Me.Close()
            MsgBox("Mantenimiento de Usuarios solo esta disponibles para un Usuario Programador", MsgBoxStyle.Information, "Sistema")
        End If
    End Sub

    Private Sub GradoTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs) Handles UsuariosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim rnum As Random
        Dim num As Integer
        rnum = New Random
        num = rnum.Next(1, 999999999)
        UsuariosBindingSource.AddNew()
        UsuarioIDTextBox.Text = num.ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'NombreTextBox.Clear()
        'ContraseñaTextBox.Clear()
        'Try
        '    UsuariosBindingSource.RemoveCurrent()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Me.Close()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
    End Sub
End Class