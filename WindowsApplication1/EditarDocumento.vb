Public Class EditarDocumento
    Private Sub EditarDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Documentos' table. You can move, or remove it, as needed.
        Me.DocumentosTableAdapter.Fill(Me.DataSet1.Documentos)
        TextBox1.Text = Jalar
    End Sub

    Private Sub DocumentosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DocumentosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DocumentosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub


End Class