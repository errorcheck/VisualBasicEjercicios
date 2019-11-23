<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlta
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
        Dim IDArticuloLabel As System.Windows.Forms.Label
        Dim IDProductoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim IdBlisterLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Me.FarmaciaBDDataSet = New Farmacia.FarmaciaBDDataSet()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter = New Farmacia.FarmaciaBDDataSetTableAdapters.StockTableAdapter()
        Me.TableAdapterManager = New Farmacia.FarmaciaBDDataSetTableAdapters.TableAdapterManager()
        Me.BlisterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlisterTableAdapter = New Farmacia.FarmaciaBDDataSetTableAdapters.BlisterTableAdapter()
        Me.IDArticuloTextBox = New System.Windows.Forms.TextBox()
        Me.IDProductoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.IdBlisterComboBox = New System.Windows.Forms.ComboBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        IDArticuloLabel = New System.Windows.Forms.Label()
        IDProductoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        IdBlisterLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        CType(Me.FarmaciaBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlisterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FarmaciaBDDataSet
        '
        Me.FarmaciaBDDataSet.DataSetName = "FarmaciaBDDataSet"
        Me.FarmaciaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "Stock"
        Me.StockBindingSource.DataSource = Me.FarmaciaBDDataSet
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BlisterTableAdapter = Me.BlisterTableAdapter
        Me.TableAdapterManager.StockTableAdapter = Me.StockTableAdapter
        Me.TableAdapterManager.UpdateOrder = Farmacia.FarmaciaBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'BlisterBindingSource
        '
        Me.BlisterBindingSource.DataMember = "Blister"
        Me.BlisterBindingSource.DataSource = Me.FarmaciaBDDataSet
        '
        'BlisterTableAdapter
        '
        Me.BlisterTableAdapter.ClearBeforeFill = True
        '
        'IDArticuloLabel
        '
        IDArticuloLabel.AutoSize = True
        IDArticuloLabel.Location = New System.Drawing.Point(65, 32)
        IDArticuloLabel.Name = "IDArticuloLabel"
        IDArticuloLabel.Size = New System.Drawing.Size(56, 13)
        IDArticuloLabel.TabIndex = 0
        IDArticuloLabel.Text = "IDArticulo:"
        '
        'IDArticuloTextBox
        '
        Me.IDArticuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "IDArticulo", True))
        Me.IDArticuloTextBox.Location = New System.Drawing.Point(137, 29)
        Me.IDArticuloTextBox.Name = "IDArticuloTextBox"
        Me.IDArticuloTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IDArticuloTextBox.TabIndex = 1
        '
        'IDProductoLabel
        '
        IDProductoLabel.AutoSize = True
        IDProductoLabel.Location = New System.Drawing.Point(65, 58)
        IDProductoLabel.Name = "IDProductoLabel"
        IDProductoLabel.Size = New System.Drawing.Size(64, 13)
        IDProductoLabel.TabIndex = 2
        IDProductoLabel.Text = "IDProducto:"
        '
        'IDProductoTextBox
        '
        Me.IDProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "IDProducto", True))
        Me.IDProductoTextBox.Location = New System.Drawing.Point(137, 55)
        Me.IDProductoTextBox.Name = "IDProductoTextBox"
        Me.IDProductoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IDProductoTextBox.TabIndex = 3
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(65, 84)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(137, 81)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DescripcionTextBox.TabIndex = 5
        '
        'IdBlisterLabel
        '
        IdBlisterLabel.AutoSize = True
        IdBlisterLabel.Location = New System.Drawing.Point(65, 110)
        IdBlisterLabel.Name = "IdBlisterLabel"
        IdBlisterLabel.Size = New System.Drawing.Size(50, 13)
        IdBlisterLabel.TabIndex = 6
        IdBlisterLabel.Text = "Id Blister:"
        '
        'IdBlisterComboBox
        '
        Me.IdBlisterComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BlisterBindingSource, "Cantidad", True))
        Me.IdBlisterComboBox.DataSource = Me.BlisterBindingSource
        Me.IdBlisterComboBox.DisplayMember = "Cantidad"
        Me.IdBlisterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdBlisterComboBox.FormattingEnabled = True
        Me.IdBlisterComboBox.Location = New System.Drawing.Point(137, 107)
        Me.IdBlisterComboBox.Name = "IdBlisterComboBox"
        Me.IdBlisterComboBox.Size = New System.Drawing.Size(121, 21)
        Me.IdBlisterComboBox.TabIndex = 7
        Me.IdBlisterComboBox.ValueMember = "IdBlister"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(65, 137)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 8
        CantidadLabel.Text = "Cantidad:"
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(137, 134)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CantidadTextBox.TabIndex = 9
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(65, 163)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 10
        PrecioLabel.Text = "Precio:"
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(137, 160)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PrecioTextBox.TabIndex = 11
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(68, 202)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(183, 202)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 263)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(IDArticuloLabel)
        Me.Controls.Add(Me.IDArticuloTextBox)
        Me.Controls.Add(IDProductoLabel)
        Me.Controls.Add(Me.IDProductoTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(IdBlisterLabel)
        Me.Controls.Add(Me.IdBlisterComboBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Name = "frmAlta"
        Me.Text = "frmAlta"
        CType(Me.FarmaciaBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlisterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FarmaciaBDDataSet As Farmacia.FarmaciaBDDataSet
    Friend WithEvents StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockTableAdapter As Farmacia.FarmaciaBDDataSetTableAdapters.StockTableAdapter
    Friend WithEvents TableAdapterManager As Farmacia.FarmaciaBDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BlisterTableAdapter As Farmacia.FarmaciaBDDataSetTableAdapters.BlisterTableAdapter
    Friend WithEvents BlisterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IDArticuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdBlisterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
