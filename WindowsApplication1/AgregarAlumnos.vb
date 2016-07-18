Public Class AgregarAlumnos
    Private Sub AlumnosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AlumnosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AlumnosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub AgregarAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Carreras' table. You can move, or remove it, as needed.
        Me.CarrerasTableAdapter.Fill(Me.DataSet1.Carreras)
        'TODO: This line of code loads data into the 'DataSet1.Detalle_Carreras' table. You can move, or remove it, as needed.
        Me.Detalle_CarrerasTableAdapter.Fill(Me.DataSet1.Detalle_Carreras)
        'TODO: This line of code loads data into the 'DataSet1.Alumnos' table. You can move, or remove it, as needed.
        Me.AlumnosTableAdapter.Fill(Me.DataSet1.Alumnos)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rnum As Random
        Dim num As Integer
        rnum = New Random
        num = rnum.Next(1, 999999999)
        AlumnosBindingSource.AddNew()
        AlumnoIDTextBox.Text = num.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Validate()
        Me.AlumnosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'NombreTextBox.Clear()
        'NumeroDeCuentaTextBox.Clear()
        'Try
        '    AlumnosBindingSource.RemoveCurrent()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Me.Close()
    End Sub
End Class