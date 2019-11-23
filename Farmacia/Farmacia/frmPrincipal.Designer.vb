<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBuscarEnGrilla = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGrillaCompuesta = New System.Windows.Forms.Button()
        IDArticuloLabel = New System.Windows.Forms.Label()
        IDProductoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        IdBlisterLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        CType(Me.FarmaciaBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDArticuloLabel
        '
        IDArticuloLabel.AutoSize = True
        IDArticuloLabel.Location = New System.Drawing.Point(183, 36)
        IDArticuloLabel.Name = "IDArticuloLabel"
        IDArticuloLabel.Size = New System.Drawing.Size(56, 13)
        IDArticuloLabel.TabIndex = 1
        IDArticuloLabel.Text = "IDArticulo:"
        '
        'IDProductoLabel
        '
        IDProductoLabel.AutoSize = True
        IDProductoLabel.Location = New System.Drawing.Point(183, 62)
        IDProductoLabel.Name = "IDProductoLabel"
        IDProductoLabel.Size = New System.Drawing.Size(64, 13)
        IDProductoLabel.TabIndex = 3
        IDProductoLabel.Text = "IDProducto:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(183, 88)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 5
        DescripcionLabel.Text = "Descripcion:"
        '
        'IdBlisterLabel
        '
        IdBlisterLabel.AutoSize = True
        IdBlisterLabel.Location = New System.Drawing.Point(183, 114)
        IdBlisterLabel.Name = "IdBlisterLabel"
        IdBlisterLabel.Size = New System.Drawing.Size(50, 13)
        IdBlisterLabel.TabIndex = 7
        IdBlisterLabel.Text = "Id Blister:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(183, 140)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 9
        CantidadLabel.Text = "Cantidad:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(183, 166)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 11
        PrecioLabel.Text = "Precio:"
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
        'IDArticuloTextBox
        '
        Me.IDArticuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "IDArticulo", True))
        Me.IDArticuloTextBox.Location = New System.Drawing.Point(255, 33)
        Me.IDArticuloTextBox.Name = "IDArticuloTextBox"
        Me.IDArticuloTextBox.Size = New System.Drawing.Size(195, 20)
        Me.IDArticuloTextBox.TabIndex = 2
        '
        'IDProductoTextBox
        '
        Me.IDProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "IDProducto", True))
        Me.IDProductoTextBox.Location = New System.Drawing.Point(255, 59)
        Me.IDProductoTextBox.Name = "IDProductoTextBox"
        Me.IDProductoTextBox.Size = New System.Drawing.Size(195, 20)
        Me.IDProductoTextBox.TabIndex = 4
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(255, 85)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(195, 20)
        Me.DescripcionTextBox.TabIndex = 6
        '
        'IdBlisterTextBox
        '
        Me.IdBlisterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "IdBlister", True))
        Me.IdBlisterTextBox.Location = New System.Drawing.Point(255, 111)
        Me.IdBlisterTextBox.Name = "IdBlisterTextBox"
        Me.IdBlisterTextBox.Size = New System.Drawing.Size(195, 20)
        Me.IdBlisterTextBox.TabIndex = 8
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(255, 137)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(195, 20)
        Me.CantidadTextBox.TabIndex = 10
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(255, 163)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(195, 20)
        Me.PrecioTextBox.TabIndex = 12
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(164, 209)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnAlta.TabIndex = 13
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnVenta
        '
        Me.btnVenta.Location = New System.Drawing.Point(375, 209)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(75, 23)
        Me.btnVenta.TabIndex = 14
        Me.btnVenta.Text = "Venta"
        Me.btnVenta.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(375, 298)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscarEnGrilla
        '
        Me.btnBuscarEnGrilla.Location = New System.Drawing.Point(164, 255)
        Me.btnBuscarEnGrilla.Name = "btnBuscarEnGrilla"
        Me.btnBuscarEnGrilla.Size = New System.Drawing.Size(123, 23)
        Me.btnBuscarEnGrilla.TabIndex = 16
        Me.btnBuscarEnGrilla.Text = "Buscar en Grilla"
        Me.btnBuscarEnGrilla.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(266, 209)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 17
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnGrillaCompuesta
        '
        Me.btnGrillaCompuesta.Location = New System.Drawing.Point(164, 298)
        Me.btnGrillaCompuesta.Name = "btnGrillaCompuesta"
        Me.btnGrillaCompuesta.Size = New System.Drawing.Size(123, 23)
        Me.btnGrillaCompuesta.TabIndex = 18
        Me.btnGrillaCompuesta.Text = "Grilla Compuesta"
        Me.btnGrillaCompuesta.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 356)
        Me.Controls.Add(Me.btnGrillaCompuesta)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBuscarEnGrilla)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVenta)
        Me.Controls.Add(Me.btnAlta)
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
        Me.Name = "frmPrincipal"
        Me.Text = "Form1"
        CType(Me.FarmaciaBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents btnVenta As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBuscarEnGrilla As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnGrillaCompuesta As System.Windows.Forms.Button

End Class
