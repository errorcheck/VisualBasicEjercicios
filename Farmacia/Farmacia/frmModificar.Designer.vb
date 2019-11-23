<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificar
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
        Me.IDArticuloTextBox = New System.Windows.Forms.TextBox()
        Me.IDProductoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.IdBlisterTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.StockDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        IDArticuloLabel = New System.Windows.Forms.Label()
        IDProductoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        IdBlisterLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        CType(Me.FarmaciaBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableAdapterManager.BlisterTableAdapter = Nothing
        Me.TableAdapterManager.StockTableAdapter = Me.StockTableAdapter
        Me.TableAdapterManager.UpdateOrder = Farmacia.FarmaciaBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'IDArticuloLabel
        '
        IDArticuloLabel.AutoSize = True
        IDArticuloLabel.Location = New System.Drawing.Point(23, 26)
        IDArticuloLabel.Name = "IDArticuloLabel"
        IDArticuloLabel.Size = New System.Drawing.Size(56, 13)
        IDArticuloLabel.TabIndex = 1
        IDArticuloLabel.Text = "IDArticulo:"
        '
        'IDArticuloTextBox
        '
        Me.IDArticuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "IDArticulo", True))
        Me.IDArticuloTextBox.Location = New System.Drawing.Point(95, 23)
        Me.IDArticuloTextBox.Name = "IDArticuloTextBox"
        Me.IDArticuloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDArticuloTextBox.TabIndex = 2
        '
        'IDProductoLabel
        '
        IDProductoLabel.AutoSize = True
        IDProductoLabel.Location = New System.Drawing.Point(23, 52)
        IDProductoLabel.Name = "IDProductoLabel"
        IDProductoLabel.Size = New System.Drawing.Size(64, 13)
        IDProductoLabel.TabIndex = 3
        IDProductoLabel.Text = "IDProducto:"
        '
        'IDProductoTextBox
        '
        Me.IDProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "IDProducto", True))
        Me.IDProductoTextBox.Location = New System.Drawing.Point(95, 49)
        Me.IDProductoTextBox.Name = "IDProductoTextBox"
        Me.IDProductoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDProductoTextBox.TabIndex = 4
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(23, 78)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 5
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(95, 75)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextBox.TabIndex = 6
        '
        'IdBlisterLabel
        '
        IdBlisterLabel.AutoSize = True
        IdBlisterLabel.Location = New System.Drawing.Point(23, 104)
        IdBlisterLabel.Name = "IdBlisterLabel"
        IdBlisterLabel.Size = New System.Drawing.Size(50, 13)
        IdBlisterLabel.TabIndex = 7
        IdBlisterLabel.Text = "Id Blister:"
        '
        'IdBlisterTextBox
        '
        Me.IdBlisterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "IdBlister", True))
        Me.IdBlisterTextBox.Location = New System.Drawing.Point(95, 101)
        Me.IdBlisterTextBox.Name = "IdBlisterTextBox"
        Me.IdBlisterTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdBlisterTextBox.TabIndex = 8
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(23, 130)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 9
        CantidadLabel.Text = "Cantidad:"
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(95, 127)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CantidadTextBox.TabIndex = 10
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(23, 156)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 11
        PrecioLabel.Text = "Precio:"
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(95, 153)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioTextBox.TabIndex = 12
        '
        'StockDataGridView
        '
        Me.StockDataGridView.AutoGenerateColumns = False
        Me.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.StockDataGridView.DataSource = Me.StockBindingSource
        Me.StockDataGridView.Location = New System.Drawing.Point(215, 23)
        Me.StockDataGridView.Name = "StockDataGridView"
        Me.StockDataGridView.Size = New System.Drawing.Size(661, 150)
        Me.StockDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDArticulo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDArticulo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IDProducto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IDProducto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdBlister"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IdBlister"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(192, 203)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 13
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(322, 203)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 14
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(451, 203)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 15
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 273)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.StockDataGridView)
        Me.Controls.Add(IDArticuloLabel)
        Me.Controls.Add(Me.IDArticuloTextBox)
        Me.Controls.Add(IDProductoLabel)
        Me.Controls.Add(Me.IDProductoTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(IdBlisterLabel)
        Me.Controls.Add(Me.IdBlisterTextBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Name = "frmModificar"
        Me.Text = "Modificar"
        CType(Me.FarmaciaBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FarmaciaBDDataSet As Farmacia.FarmaciaBDDataSet
    Friend WithEvents StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockTableAdapter As Farmacia.FarmaciaBDDataSetTableAdapters.StockTableAdapter
    Friend WithEvents TableAdapterManager As Farmacia.FarmaciaBDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDArticuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdBlisterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StockDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
