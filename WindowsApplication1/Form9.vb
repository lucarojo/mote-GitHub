Public Class Form9
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub FillReporteToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.ProcedimientoReporteTableAdapter.FillReporte(Me.DataSet1.ProcedimientoReporte, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)), New System.Nullable(Of Date)(CType(DateTimePicker2.Text, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GridViewReporte.ShowRibbonPrintPreview()

    End Sub
End Class