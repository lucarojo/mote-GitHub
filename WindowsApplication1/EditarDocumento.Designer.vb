<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarDocumento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NombreLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Dim Archivo_AdjuntoLabel As System.Windows.Forms.Label
        Dim AlumnoIDLabel As System.Windows.Forms.Label
        Dim TipoDocIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarDocumento))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.DocumentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocumentosTableAdapter = New WindowsApplication1.DataSet1TableAdapters.DocumentosTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DataSet1TableAdapters.TableAdapterManager()
        Me.DocumentosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DocumentosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.AñoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Archivo_AdjuntoTextBox = New System.Windows.Forms.TextBox()
        Me.AlumnoIDComboBox = New System.Windows.Forms.ComboBox()
        Me.TipoDocIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        NombreLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        Archivo_AdjuntoLabel = New System.Windows.Forms.Label()
        AlumnoIDLabel = New System.Windows.Forms.Label()
        TipoDocIDLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(30, 56)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Location = New System.Drawing.Point(30, 99)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(29, 13)
        AñoLabel.TabIndex = 4
        AñoLabel.Text = "Año:"
        '
        'Archivo_AdjuntoLabel
        '
        Archivo_AdjuntoLabel.AutoSize = True
        Archivo_AdjuntoLabel.Location = New System.Drawing.Point(30, 139)
        Archivo_AdjuntoLabel.Name = "Archivo_AdjuntoLabel"
        Archivo_AdjuntoLabel.Size = New System.Drawing.Size(85, 13)
        Archivo_AdjuntoLabel.TabIndex = 6
        Archivo_AdjuntoLabel.Text = "Archivo Adjunto:"
        '
        'AlumnoIDLabel
        '
        AlumnoIDLabel.AutoSize = True
        AlumnoIDLabel.Location = New System.Drawing.Point(30, 180)
        AlumnoIDLabel.Name = "AlumnoIDLabel"
        AlumnoIDLabel.Size = New System.Drawing.Size(59, 13)
        AlumnoIDLabel.TabIndex = 8
        AlumnoIDLabel.Text = "Alumno ID:"
        '
        'TipoDocIDLabel
        '
        TipoDocIDLabel.AutoSize = True
        TipoDocIDLabel.Location = New System.Drawing.Point(30, 219)
        TipoDocIDLabel.Name = "TipoDocIDLabel"
        TipoDocIDLabel.Size = New System.Drawing.Size(68, 13)
        TipoDocIDLabel.TabIndex = 10
        TipoDocIDLabel.Text = "Tipo Doc ID:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 261)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DocumentosBindingSource
        '
        Me.DocumentosBindingSource.DataMember = "Documentos"
        Me.DocumentosBindingSource.DataSource = Me.DataSet1
        '
        'DocumentosTableAdapter
        '
        Me.DocumentosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlumnosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CarrerasTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_CarrerasTableAdapter = Nothing
        Me.TableAdapterManager.DocumentosTableAdapter = Me.DocumentosTableAdapter
        Me.TableAdapterManager.EstadoTableAdapter = Nothing
        Me.TableAdapterManager.SolicitudesTableAdapter = Nothing
        Me.TableAdapterManager.Tipo_de_DocumentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'DocumentosBindingNavigator
        '
        Me.DocumentosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DocumentosBindingNavigator.BindingSource = Me.DocumentosBindingSource
        Me.DocumentosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DocumentosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DocumentosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DocumentosBindingNavigatorSaveItem})
        Me.DocumentosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DocumentosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DocumentosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DocumentosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DocumentosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DocumentosBindingNavigator.Name = "DocumentosBindingNavigator"
        Me.DocumentosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DocumentosBindingNavigator.Size = New System.Drawing.Size(584, 25)
        Me.DocumentosBindingNavigator.TabIndex = 1
        Me.DocumentosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DocumentosBindingNavigatorSaveItem
        '
        Me.DocumentosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DocumentosBindingNavigatorSaveItem.Image = CType(resources.GetObject("DocumentosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DocumentosBindingNavigatorSaveItem.Name = "DocumentosBindingNavigatorSaveItem"
        Me.DocumentosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DocumentosBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(121, 53)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombreTextBox.TabIndex = 3
        '
        'AñoDateTimePicker
        '
        Me.AñoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DocumentosBindingSource, "Año", True))
        Me.AñoDateTimePicker.Location = New System.Drawing.Point(121, 92)
        Me.AñoDateTimePicker.Name = "AñoDateTimePicker"
        Me.AñoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.AñoDateTimePicker.TabIndex = 5
        '
        'Archivo_AdjuntoTextBox
        '
        Me.Archivo_AdjuntoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentosBindingSource, "Archivo_Adjunto", True))
        Me.Archivo_AdjuntoTextBox.Location = New System.Drawing.Point(121, 136)
        Me.Archivo_AdjuntoTextBox.Name = "Archivo_AdjuntoTextBox"
        Me.Archivo_AdjuntoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Archivo_AdjuntoTextBox.TabIndex = 7
        '
        'AlumnoIDComboBox
        '
        Me.AlumnoIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentosBindingSource, "AlumnoID", True))
        Me.AlumnoIDComboBox.FormattingEnabled = True
        Me.AlumnoIDComboBox.Location = New System.Drawing.Point(121, 177)
        Me.AlumnoIDComboBox.Name = "AlumnoIDComboBox"
        Me.AlumnoIDComboBox.Size = New System.Drawing.Size(200, 21)
        Me.AlumnoIDComboBox.TabIndex = 9
        '
        'TipoDocIDComboBox
        '
        Me.TipoDocIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DocumentosBindingSource, "TipoDocID", True))
        Me.TipoDocIDComboBox.FormattingEnabled = True
        Me.TipoDocIDComboBox.Location = New System.Drawing.Point(121, 216)
        Me.TipoDocIDComboBox.Name = "TipoDocIDComboBox"
        Me.TipoDocIDComboBox.Size = New System.Drawing.Size(200, 21)
        Me.TipoDocIDComboBox.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(347, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 36)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(347, 204)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 33)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(347, 133)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Adjuntar Archivo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'EditarDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 300)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(TipoDocIDLabel)
        Me.Controls.Add(Me.TipoDocIDComboBox)
        Me.Controls.Add(AlumnoIDLabel)
        Me.Controls.Add(Me.AlumnoIDComboBox)
        Me.Controls.Add(Archivo_AdjuntoLabel)
        Me.Controls.Add(Me.Archivo_AdjuntoTextBox)
        Me.Controls.Add(AñoLabel)
        Me.Controls.Add(Me.AñoDateTimePicker)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.DocumentosBindingNavigator)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "EditarDocumento"
        Me.Text = "EditarDocumento"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentosBindingNavigator.ResumeLayout(False)
        Me.DocumentosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DocumentosBindingSource As BindingSource
    Friend WithEvents DocumentosTableAdapter As DataSet1TableAdapters.DocumentosTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents DocumentosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DocumentosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents AñoDateTimePicker As DateTimePicker
    Friend WithEvents Archivo_AdjuntoTextBox As TextBox
    Friend WithEvents AlumnoIDComboBox As ComboBox
    Friend WithEvents TipoDocIDComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
