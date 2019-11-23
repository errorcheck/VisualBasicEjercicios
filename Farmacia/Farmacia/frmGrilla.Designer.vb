<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrilla
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
        Me.FarmaciaBDDataSet = New Farmacia.FarmaciaBDDataSet()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter = New Farmacia.FarmaciaBDDataSetTableAdapters.StockTableAdapter()
        Me.TableAdapterManager = New Farmacia.FarmaciaBDDataSetTableAdapters.TableAdapterManager()
        Me.StockDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBusPorDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBusPorCodArticulo = New System.Windows.Forms.Label()
        Me.txtBusPorCodArticulo = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
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
        'StockDataGridView
        '
        Me.StockDataGridView.AutoGenerateColumns = False
        Me.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.StockDataGridView.DataSource = Me.StockBindingSource
        Me.StockDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.StockDataGridView.Name = "StockDataGridView"
        Me.StockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StockDataGridView.Size = New System.Drawing.Size(708, 220)
        Me.StockDataGridView.TabIndex = 1
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
        'txtBusPorDescripcion
        '
        Me.txtBusPorDescripcion.Location = New System.Drawing.Point(189, 259)
        Me.txtBusPorDescripcion.Name = "txtBusPorDescripcion"
        Me.txtBusPorDescripcion.Size = New System.Drawing.Size(222, 20)
        Me.txtBusPorDescripcion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingrese Descripcion:"
        '
        'lblBusPorCodArticulo
        '
        Me.lblBusPorCodArticulo.AutoSize = True
        Me.lblBusPorCodArticulo.Location = New System.Drawing.Point(49, 288)
        Me.lblBusPorCodArticulo.Name = "lblBusPorCodArticulo"
        Me.lblBusPorCodArticulo.Size = New System.Drawing.Size(134, 13)
        Me.lblBusPorCodArticulo.TabIndex = 5
        Me.lblBusPorCodArticulo.Text = "Ingrese Codigo de Articulo:"
        '
        'txtBusPorCodArticulo
        '
        Me.txtBusPorCodArticulo.Location = New System.Drawing.Point(189, 285)
        Me.txtBusPorCodArticulo.Name = "txtBusPorCodArticulo"
        Me.txtBusPorCodArticulo.Size = New System.Drawing.Size(222, 20)
        Me.txtBusPorCodArticulo.TabIndex = 4
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(453, 262)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 39)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmGrilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 361)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblBusPorCodArticulo)
        Me.Controls.Add(Me.txtBusPorCodArticulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBusPorDescripcion)
        Me.Controls.Add(Me.StockDataGridView)
        Me.Name = "frmGrilla"
        Me.Text = "frmGrilla"
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
    Friend WithEvents StockDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtBusPorDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBusPorCodArticulo As System.Windows.Forms.Label
    Friend WithEvents txtBusPorCodArticulo As System.Windows.Forms.TextBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
