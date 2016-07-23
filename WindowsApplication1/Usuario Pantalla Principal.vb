Imports System.Data
Imports System.Linq
Imports System.Data.SqlClient

Public Class Form1
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        login.Show()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Me.BuscardocumentosTableAdapter.Fill(Me.DataSet1.buscardocumentos, TextBox4.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text, ComboBox2.SelectedValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = 1 Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
            TextBox1.Clear()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.CheckState = 1 Then
            TextBox2.Enabled = True
        Else
            TextBox2.Enabled = False
            TextBox2.Clear()
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.CheckState = 1 Then
            TextBox3.Enabled = True
        Else
            TextBox3.Enabled = False
            TextBox3.Clear()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.CheckState = 1 Then
            TextBox4.Enabled = True
        Else
            TextBox4.Enabled = False
            TextBox4.Clear()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscardocumentosDataGridView.AllowUserToAddRows = False
        'TODO: This line of code loads data into the 'DataSet1.Tipo_de_Documento' table. You can move, or remove it, as needed.
        Me.Tipo_de_DocumentoTableAdapter.Fill(Me.DataSet1.Tipo_de_Documento)
        Try
            Me.BuscardocumentosTableAdapter.Fill(Me.DataSet1.buscardocumentos, TextBox4.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text, ComboBox2.SelectedValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Label3.Text = DateAndTime.Today.ToLongDateString

        Dim checkBoxColumn As New DataGridViewCheckBoxColumn
        checkBoxColumn.HeaderText = "Seleccionar"
        checkBoxColumn.Width = 70
        checkBoxColumn.Name = "CheckBoxColumn"
        BuscardocumentosDataGridView.Columns.Insert(0, checkBoxColumn)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedRows As List(Of DataGridViewRow) = (From row In BuscardocumentosDataGridView.Rows.Cast(Of DataGridViewRow)()
                                                        Where Convert.ToBoolean(row.Cells("checkBoxColumn").Value) = True).ToList
        If MessageBox.Show(String.Format("Usted Eligio {0} filas,Desea Continuar?", selectedRows.Count), "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            MessageBox.Show("Selectedrow->" + selectedRows.Count.ToString)
            Dim obj As Form2 = New Form2

            For Each column As DataGridViewColumn In BuscardocumentosDataGridView.Columns
                obj.DataGridView1.Columns.Add(CType(column.Clone(), DataGridViewColumn))
            Next

            For Each row As DataGridViewRow In selectedRows

                If (Not row.IsNewRow) Then
                    Dim TempRow = CType(row.Clone(), DataGridViewRow)

                    For Each cell As DataGridViewCell In row.Cells
                        TempRow.Cells(row.Cells.IndexOf(cell)).Value = cell.Value
                    Next

                    obj.DataGridView1.Rows.Add(TempRow)

                End If
            Next
            obj.Button1.Show()
            obj.Show()
        End If

    End Sub
End Class
