Public Class agregarcarreras
    Private Sub CarrerasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CarrerasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CarrerasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub agregarcarreras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Tipo_Grado' table. You can move, or remove it, as needed.
        Me.Tipo_GradoTableAdapter.Fill(Me.DataSet1.Tipo_Grado)
        'TODO: This line of code loads data into the 'DataSet1.Tipo_de_Documento' table. You can move, or remove it, as needed.
        Me.Tipo_de_DocumentoTableAdapter.Fill(Me.DataSet1.Tipo_de_Documento)
        'TODO: This line of code loads data into the 'DataSet1.Carreras' table. You can move, or remove it, as needed.
        Me.CarrerasTableAdapter.Fill(Me.DataSet1.Carreras)

    End Sub
End Class