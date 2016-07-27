Public Class Form2
    Dim solicitudid As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Nombre_SolicitanteTextBox.Text <> Nothing And Numero_Cuenta_SolicitanteMaskedTextBox.Text <> Nothing Then
                Me.Validate()
                Me.SolicitudesBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DataSet1)

                Dim codigo As String
                For Each row As DataGridViewRow In Me.DataGridView1.Rows
                    codigo = CStr(row.Cells(1).Value)

                    Try
                        Me.SpDocumentosySolicitudesTableAdapter.Fill(Me.DataSet1.spDocumentosySolicitudes, codigo, solicitudid)
                    Catch ex As System.Exception
                        System.Windows.Forms.MessageBox.Show(ex.Message)
                    End Try

                    MsgBox(codigo)
                Next
                'Form1.Tipo_de_DocumentoTableAdapter.Fill(Me.DataSet1.Tipo_de_Documento)
                'Try
                '    Form1.CheckBox1.Checked = False
                '    Form1.CheckBox3.Checked = False
                '    Form1.CheckBox4.Checked = False
                '    Form1.CheckBox2.Checked = False

                '    Form1.BuscardocumentosTableAdapter.Fill(Me.DataSet1.buscardocumentos, Form1.TextBox4.Text, Form1.TextBox1.Text, Form1.TextBox2.Text, Form1.TextBox3.Text, Form1.ComboBox2.SelectedValue)
                'Catch ex As System.Exception
                '    System.Windows.Forms.MessageBox.Show(ex.Message)
                'End Try
                Me.Close()
            Else
                MsgBox("Ingrese Su Nombre Completo y su Numero de Identidad", MsgBoxStyle.Critical, "Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SolicitudesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SolicitudesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Solicitudes' table. You can move, or remove it, as needed.
        Me.SolicitudesTableAdapter.Fill(Me.DataSet1.Solicitudes)
        SolicitudesBindingSource.AddNew()
        EstadoIDTextBox.Text = "PEN"
        Dim rnum As Random
        Dim num As Integer
        rnum = New Random
        num = rnum.Next(1, 999999999)
        SolicitudIDTextBox.Text = num.ToString
        solicitudid = num.ToString
        Fecha_CreacionDateTimePicker.Value = Today

    End Sub

End Class