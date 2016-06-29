<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
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
        Dim Nombre_SolicitanteLabel As System.Windows.Forms.Label
        Dim Numero_Cuenta_SolicitanteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AgregarDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.MantenimientoUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Nombre_SolicitanteTextBox = New System.Windows.Forms.TextBox()
        Me.Numero_Cuenta_SolicitanteTextBox = New System.Windows.Forms.TextBox()
        Me.DocumentosDeSolicitudDataGridView = New System.Windows.Forms.DataGridView()
        Me.Archivo_Adjunto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descargar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.EstadoID = New System.Windows.Forms.TextBox()
        Me.SolicitudID = New System.Windows.Forms.TextBox()
        Me.UpdateEstadoEnSolicitudBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.DocumentosDeSolicitudBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentosDeSolicitudTableAdapter = New WindowsApplication1.DataSet1TableAdapters.DocumentosDeSolicitudTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DataSet1TableAdapters.TableAdapterManager()
        Me.UpdateEstadoEnSolicitudTableAdapter = New WindowsApplication1.DataSet1TableAdapters.updateEstadoEnSolicitudTableAdapter()
        Nombre_SolicitanteLabel = New System.Windows.Forms.Label()
        Numero_Cuenta_SolicitanteLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DocumentosDeSolicitudDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpdateEstadoEnSolicitudBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentosDeSolicitudBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nombre_SolicitanteLabel
        '
        Nombre_SolicitanteLabel.AutoSize = True
        Nombre_SolicitanteLabel.Location = New System.Drawing.Point(12, 45)
        Nombre_SolicitanteLabel.Name = "Nombre_SolicitanteLabel"
        Nombre_SolicitanteLabel.Size = New System.Drawing.Size(99, 13)
        Nombre_SolicitanteLabel.TabIndex = 54
        Nombre_SolicitanteLabel.Text = "Nombre Solicitante:"
        '
        'Numero_Cuenta_SolicitanteLabel
        '
        Numero_Cuenta_SolicitanteLabel.AutoSize = True
        Numero_Cuenta_SolicitanteLabel.Location = New System.Drawing.Point(358, 45)
        Numero_Cuenta_SolicitanteLabel.Name = "Numero_Cuenta_SolicitanteLabel"
        Numero_Cuenta_SolicitanteLabel.Size = New System.Drawing.Size(136, 13)
        Numero_Cuenta_SolicitanteLabel.TabIndex = 55
        Numero_Cuenta_SolicitanteLabel.Text = "Numero Cuenta Solicitante:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 15)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Documentos Solicitados"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1048, 25)
        Me.ToolStrip1.TabIndex = 50
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripButton5.Text = "Inicio"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripButton3.Text = "Generar Reportes"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarDocumentoToolStripMenuItem, Me.BuscarDocumentoToolStripMenuItem})
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(118, 22)
        Me.ToolStripButton4.Text = "Mantenimiento"
        '
        'AgregarDocumentoToolStripMenuItem
        '
        Me.AgregarDocumentoToolStripMenuItem.Name = "AgregarDocumentoToolStripMenuItem"
        Me.AgregarDocumentoToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AgregarDocumentoToolStripMenuItem.Text = "Agregar Documento"
        '
        'BuscarDocumentoToolStripMenuItem
        '
        Me.BuscarDocumentoToolStripMenuItem.Name = "BuscarDocumentoToolStripMenuItem"
        Me.BuscarDocumentoToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.BuscarDocumentoToolStripMenuItem.Text = "Buscar Documento"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoUsuariosToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(81, 22)
        Me.ToolStripButton1.Text = "Usuarios"
        '
        'MantenimientoUsuariosToolStripMenuItem
        '
        Me.MantenimientoUsuariosToolStripMenuItem.Name = "MantenimientoUsuariosToolStripMenuItem"
        Me.MantenimientoUsuariosToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.MantenimientoUsuariosToolStripMenuItem.Text = "Mantenimiento Usuarios"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripButton2.Text = "Pantalla De Usuarios"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(677, 426)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 38)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Completar Solicitud"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(879, 28)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 54
        Me.TextBox2.Visible = False
        '
        'Nombre_SolicitanteTextBox
        '
        Me.Nombre_SolicitanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentosDeSolicitudBindingSource, "Nombre_Solicitante", True))
        Me.Nombre_SolicitanteTextBox.Location = New System.Drawing.Point(117, 42)
        Me.Nombre_SolicitanteTextBox.Name = "Nombre_SolicitanteTextBox"
        Me.Nombre_SolicitanteTextBox.Size = New System.Drawing.Size(219, 20)
        Me.Nombre_SolicitanteTextBox.TabIndex = 55
        '
        'Numero_Cuenta_SolicitanteTextBox
        '
        Me.Numero_Cuenta_SolicitanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentosDeSolicitudBindingSource, "Numero_Cuenta_Solicitante", True))
        Me.Numero_Cuenta_SolicitanteTextBox.Location = New System.Drawing.Point(500, 42)
        Me.Numero_Cuenta_SolicitanteTextBox.Name = "Numero_Cuenta_SolicitanteTextBox"
        Me.Numero_Cuenta_SolicitanteTextBox.Size = New System.Drawing.Size(175, 20)
        Me.Numero_Cuenta_SolicitanteTextBox.TabIndex = 56
        '
        'DocumentosDeSolicitudDataGridView
        '
        Me.DocumentosDeSolicitudDataGridView.AllowUserToAddRows = False
        Me.DocumentosDeSolicitudDataGridView.AllowUserToDeleteRows = False
        Me.DocumentosDeSolicitudDataGridView.AutoGenerateColumns = False
        Me.DocumentosDeSolicitudDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DocumentosDeSolicitudDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Archivo_Adjunto, Me.Descargar, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DocumentosDeSolicitudDataGridView.DataSource = Me.DocumentosDeSolicitudBindingSource
        Me.DocumentosDeSolicitudDataGridView.Location = New System.Drawing.Point(12, 91)
        Me.DocumentosDeSolicitudDataGridView.Name = "DocumentosDeSolicitudDataGridView"
        Me.DocumentosDeSolicitudDataGridView.ReadOnly = True
        Me.DocumentosDeSolicitudDataGridView.Size = New System.Drawing.Size(1016, 318)
        Me.DocumentosDeSolicitudDataGridView.TabIndex = 53
        '
        'Archivo_Adjunto
        '
        Me.Archivo_Adjunto.DataPropertyName = "Archivo_Adjunto"
        Me.Archivo_Adjunto.HeaderText = "Archivo_Adjunto"
        Me.Archivo_Adjunto.Name = "Archivo_Adjunto"
        Me.Archivo_Adjunto.ReadOnly = True
        Me.Archivo_Adjunto.Visible = False
        '
        'Descargar
        '
        Me.Descargar.DataPropertyName = "SolicitudID"
        Me.Descargar.HeaderText = "Descargar"
        Me.Descargar.Name = "Descargar"
        Me.Descargar.ReadOnly = True
        Me.Descargar.Text = "Descargar"
        Me.Descargar.UseColumnTextForButtonValue = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(847, 426)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 38)
        Me.Button2.TabIndex = 57
        Me.Button2.Text = "Cacelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'EstadoID
        '
        Me.EstadoID.Location = New System.Drawing.Point(15, 452)
        Me.EstadoID.Name = "EstadoID"
        Me.EstadoID.Size = New System.Drawing.Size(100, 20)
        Me.EstadoID.TabIndex = 62
        Me.EstadoID.Visible = False
        '
        'SolicitudID
        '
        Me.SolicitudID.Location = New System.Drawing.Point(15, 426)
        Me.SolicitudID.Name = "SolicitudID"
        Me.SolicitudID.Size = New System.Drawing.Size(100, 20)
        Me.SolicitudID.TabIndex = 63
        Me.SolicitudID.Visible = False
        '
        'UpdateEstadoEnSolicitudBindingSource
        '
        Me.UpdateEstadoEnSolicitudBindingSource.DataMember = "updateEstadoEnSolicitud"
        Me.UpdateEstadoEnSolicitudBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DocumentosDeSolicitudBindingSource
        '
        Me.DocumentosDeSolicitudBindingSource.DataMember = "DocumentosDeSolicitud"
        Me.DocumentosDeSolicitudBindingSource.DataSource = Me.DataSet1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SolicitudID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SolicitudID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Autor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Autor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Carrera"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Carrera"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Año"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Año"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Tipo de Documento"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tipo de Documento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Nombre_Solicitante"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nombre_Solicitante"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Numero_Cuenta_Solicitante"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Numero_Cuenta_Solicitante"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DocumentosDeSolicitudTableAdapter
        '
        Me.DocumentosDeSolicitudTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlumnosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DocumentosTableAdapter = Nothing
        Me.TableAdapterManager.EstadoTableAdapter = Nothing
        Me.TableAdapterManager.SolicitudesTableAdapter = Nothing
        Me.TableAdapterManager.Tipo_de_DocumentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'UpdateEstadoEnSolicitudTableAdapter
        '
        Me.UpdateEstadoEnSolicitudTableAdapter.ClearBeforeFill = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 493)
        Me.Controls.Add(Me.SolicitudID)
        Me.Controls.Add(Me.EstadoID)
        Me.Controls.Add(Numero_Cuenta_SolicitanteLabel)
        Me.Controls.Add(Me.Numero_Cuenta_SolicitanteTextBox)
        Me.Controls.Add(Nombre_SolicitanteLabel)
        Me.Controls.Add(Me.Nombre_SolicitanteTextBox)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DocumentosDeSolicitudDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Completar Solicitud"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DocumentosDeSolicitudDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpdateEstadoEnSolicitudBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentosDeSolicitudBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripDropDownButton
    Friend WithEvents AgregarDocumentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarDocumentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripDropDownButton
    Friend WithEvents MantenimientoUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents Button1 As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DocumentosDeSolicitudBindingSource As BindingSource
    Friend WithEvents DocumentosDeSolicitudTableAdapter As DataSet1TableAdapters.DocumentosDeSolicitudTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Nombre_SolicitanteTextBox As TextBox
    Friend WithEvents Numero_Cuenta_SolicitanteTextBox As TextBox
    Friend WithEvents DocumentosDeSolicitudDataGridView As DataGridView
    Friend WithEvents Archivo_Adjunto As DataGridViewTextBoxColumn
    Friend WithEvents Descargar As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents UpdateEstadoEnSolicitudBindingSource As BindingSource
    Friend WithEvents UpdateEstadoEnSolicitudTableAdapter As DataSet1TableAdapters.updateEstadoEnSolicitudTableAdapter
    Friend WithEvents EstadoID As TextBox
    Friend WithEvents SolicitudID As TextBox
End Class
