<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.SolicitudesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SolicitudesTableAdapter = New WindowsApplication1.DataSet1TableAdapters.SolicitudesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DataSet1TableAdapters.TableAdapterManager()
        Me.SolicitudIDTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_CreacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Nombre_SolicitanteTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SpDocumentosySolicitudesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpDocumentosySolicitudesTableAdapter = New WindowsApplication1.DataSet1TableAdapters.spDocumentosySolicitudesTableAdapter()
        Me.Numero_Cuenta_SolicitanteMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolicitudesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpDocumentosySolicitudesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(722, 282)
        Me.DataGridView1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(480, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Solicitar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Para completar su solicitúd ingrese lo siguiente:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre Completo"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Numero de Identidad"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(449, 345)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(272, 48)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Recuerde que debera presentar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "una memoria USB para que los docuemntos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sean faci" &
    "litados."
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(435, 326)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 84)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Atención"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SolicitudesBindingSource
        '
        Me.SolicitudesBindingSource.DataMember = "Solicitudes"
        Me.SolicitudesBindingSource.DataSource = Me.DataSet1
        '
        'SolicitudesTableAdapter
        '
        Me.SolicitudesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlumnosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CarrerasTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_CarrerasTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_DocumentoTableAdapter = Nothing
        Me.TableAdapterManager.DocumentosTableAdapter = Nothing
        Me.TableAdapterManager.EstadoTableAdapter = Nothing
        Me.TableAdapterManager.ServerTableAdapter = Nothing
        Me.TableAdapterManager.SolicitudesTableAdapter = Me.SolicitudesTableAdapter
        Me.TableAdapterManager.Tipo_de_DocumentoTableAdapter = Nothing
        Me.TableAdapterManager.Tipo_GradoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'SolicitudIDTextBox
        '
        Me.SolicitudIDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SolicitudIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SolicitudesBindingSource, "SolicitudID", True))
        Me.SolicitudIDTextBox.Location = New System.Drawing.Point(150, 405)
        Me.SolicitudIDTextBox.Name = "SolicitudIDTextBox"
        Me.SolicitudIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SolicitudIDTextBox.TabIndex = 23
        '
        'Fecha_CreacionDateTimePicker
        '
        Me.Fecha_CreacionDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Fecha_CreacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SolicitudesBindingSource, "Fecha_Creacion", True))
        Me.Fecha_CreacionDateTimePicker.Enabled = False
        Me.Fecha_CreacionDateTimePicker.Location = New System.Drawing.Point(150, 405)
        Me.Fecha_CreacionDateTimePicker.Name = "Fecha_CreacionDateTimePicker"
        Me.Fecha_CreacionDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_CreacionDateTimePicker.TabIndex = 25
        '
        'Nombre_SolicitanteTextBox
        '
        Me.Nombre_SolicitanteTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Nombre_SolicitanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SolicitudesBindingSource, "Nombre_Solicitante", True))
        Me.Nombre_SolicitanteTextBox.Location = New System.Drawing.Point(150, 340)
        Me.Nombre_SolicitanteTextBox.Name = "Nombre_SolicitanteTextBox"
        Me.Nombre_SolicitanteTextBox.Size = New System.Drawing.Size(233, 20)
        Me.Nombre_SolicitanteTextBox.TabIndex = 26
        '
        'EstadoIDTextBox
        '
        Me.EstadoIDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EstadoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SolicitudesBindingSource, "EstadoID", True))
        Me.EstadoIDTextBox.Location = New System.Drawing.Point(150, 405)
        Me.EstadoIDTextBox.Name = "EstadoIDTextBox"
        Me.EstadoIDTextBox.Size = New System.Drawing.Size(60, 20)
        Me.EstadoIDTextBox.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 410)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Fecha"
        '
        'SpDocumentosySolicitudesBindingSource
        '
        Me.SpDocumentosySolicitudesBindingSource.DataSource = Me.DataSet1
        Me.SpDocumentosySolicitudesBindingSource.Position = 0
        '
        'SpDocumentosySolicitudesTableAdapter
        '
        Me.SpDocumentosySolicitudesTableAdapter.ClearBeforeFill = True
        '
        'Numero_Cuenta_SolicitanteMaskedTextBox
        '
        Me.Numero_Cuenta_SolicitanteMaskedTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Numero_Cuenta_SolicitanteMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SolicitudesBindingSource, "Numero_Cuenta_Solicitante", True))
        Me.Numero_Cuenta_SolicitanteMaskedTextBox.Location = New System.Drawing.Point(150, 376)
        Me.Numero_Cuenta_SolicitanteMaskedTextBox.Mask = "0000-0000-00000"
        Me.Numero_Cuenta_SolicitanteMaskedTextBox.Name = "Numero_Cuenta_SolicitanteMaskedTextBox"
        Me.Numero_Cuenta_SolicitanteMaskedTextBox.Size = New System.Drawing.Size(162, 20)
        Me.Numero_Cuenta_SolicitanteMaskedTextBox.TabIndex = 30
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(754, 476)
        Me.Controls.Add(Me.Fecha_CreacionDateTimePicker)
        Me.Controls.Add(Me.SolicitudIDTextBox)
        Me.Controls.Add(Me.Numero_Cuenta_SolicitanteMaskedTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.EstadoIDTextBox)
        Me.Controls.Add(Me.Nombre_SolicitanteTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmación"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolicitudesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpDocumentosySolicitudesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents SolicitudesBindingSource As BindingSource
    Friend WithEvents SolicitudesTableAdapter As DataSet1TableAdapters.SolicitudesTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents SolicitudIDTextBox As TextBox
    Friend WithEvents Fecha_CreacionDateTimePicker As DateTimePicker
    Friend WithEvents Nombre_SolicitanteTextBox As TextBox
    Friend WithEvents EstadoIDTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SpDocumentosySolicitudesBindingSource As BindingSource
    Friend WithEvents SpDocumentosySolicitudesTableAdapter As DataSet1TableAdapters.spDocumentosySolicitudesTableAdapter
    Friend WithEvents Numero_Cuenta_SolicitanteMaskedTextBox As MaskedTextBox
End Class
