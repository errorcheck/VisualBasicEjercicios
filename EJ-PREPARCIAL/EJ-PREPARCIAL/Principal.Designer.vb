<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim IdArticuloLabel As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim DescripcionLabel1 As System.Windows.Forms.Label
        Me.IdArticuloTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreparcialDataSet = New EJ_PREPARCIAL.PreparcialDataSet()
        Me.ArticulosTableAdapter = New EJ_PREPARCIAL.PreparcialDataSetTableAdapters.ArticulosTableAdapter()
        Me.TableAdapterManager = New EJ_PREPARCIAL.PreparcialDataSetTableAdapters.TableAdapterManager()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.DescripcionComboBox = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblBuscarCodigo = New System.Windows.Forms.Label()
        Me.lblBuscarDescripcion = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.bntEliminar = New System.Windows.Forms.Button()
        IdArticuloLabel = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        DescripcionLabel1 = New System.Windows.Forms.Label()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreparcialDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdArticuloLabel
        '
        IdArticuloLabel.AutoSize = True
        IdArticuloLabel.Location = New System.Drawing.Point(105, 39)
        IdArticuloLabel.Name = "IdArticuloLabel"
        IdArticuloLabel.Size = New System.Drawing.Size(57, 13)
        IdArticuloLabel.TabIndex = 1
        IdArticuloLabel.Text = "Id Articulo:"
        '
        'IdArticuloTextBox
        '
        Me.IdArticuloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "IdArticulo", True))
        Me.IdArticuloTextBox.Location = New System.Drawing.Point(177, 36)
        Me.IdArticuloTextBox.Name = "IdArticuloTextBox"
        Me.IdArticuloTextBox.ReadOnly = True
        Me.IdArticuloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdArticuloTextBox.TabIndex = 2
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(105, 65)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 3
        CodigoLabel.Text = "Codigo:"
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(177, 62)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox.TabIndex = 4
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(105, 91)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 5
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(177, 88)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextBox.TabIndex = 6
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(105, 117)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 7
        PrecioLabel.Text = "Precio:"
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(177, 114)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioTextBox.TabIndex = 8
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(108, 206)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 23)
        Me.btnAtras.TabIndex = 9
        Me.btnAtras.Text = "<"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(212, 206)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 10
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "Articulos"
        Me.ArticulosBindingSource.DataSource = Me.PreparcialDataSet
        '
        'PreparcialDataSet
        '
        Me.PreparcialDataSet.DataSetName = "PreparcialDataSet"
        Me.PreparcialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArticulosTableAdapter = Me.ArticulosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = EJ_PREPARCIAL.PreparcialDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(325, 33)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 11
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(325, 206)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'DescripcionLabel1
        '
        DescripcionLabel1.AutoSize = True
        DescripcionLabel1.Location = New System.Drawing.Point(105, 162)
        DescripcionLabel1.Name = "DescripcionLabel1"
        DescripcionLabel1.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel1.TabIndex = 12
        DescripcionLabel1.Text = "Descripcion:"
        '
        'DescripcionComboBox
        '
        Me.DescripcionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "Descripcion", True))
        Me.DescripcionComboBox.DataSource = Me.ArticulosBindingSource
        Me.DescripcionComboBox.DisplayMember = "Descripcion"
        Me.DescripcionComboBox.FormattingEnabled = True
        Me.DescripcionComboBox.Location = New System.Drawing.Point(177, 159)
        Me.DescripcionComboBox.Name = "DescripcionComboBox"
        Me.DescripcionComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DescripcionComboBox.TabIndex = 13
        Me.DescripcionComboBox.ValueMember = "IdArticulo"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(438, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(193, 20)
        Me.TextBox1.TabIndex = 14
        '
        'lblBuscarCodigo
        '
        Me.lblBuscarCodigo.AutoSize = True
        Me.lblBuscarCodigo.Location = New System.Drawing.Point(435, 64)
        Me.lblBuscarCodigo.Name = "lblBuscarCodigo"
        Me.lblBuscarCodigo.Size = New System.Drawing.Size(122, 13)
        Me.lblBuscarCodigo.TabIndex = 15
        Me.lblBuscarCodigo.Text = "Buscar Articulo x Codigo"
        '
        'lblBuscarDescripcion
        '
        Me.lblBuscarDescripcion.AutoSize = True
        Me.lblBuscarDescripcion.Location = New System.Drawing.Point(435, 117)
        Me.lblBuscarDescripcion.Name = "lblBuscarDescripcion"
        Me.lblBuscarDescripcion.Size = New System.Drawing.Size(145, 13)
        Me.lblBuscarDescripcion.TabIndex = 16
        Me.lblBuscarDescripcion.Text = "Buscar Articulo x Descripcion"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(438, 136)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(193, 20)
        Me.TextBox2.TabIndex = 17
        '
        'bntEliminar
        '
        Me.bntEliminar.Location = New System.Drawing.Point(325, 65)
        Me.bntEliminar.Name = "bntEliminar"
        Me.bntEliminar.Size = New System.Drawing.Size(75, 23)
        Me.bntEliminar.TabIndex = 18
        Me.bntEliminar.Text = "Eliminar"
        Me.bntEliminar.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 282)
        Me.Controls.Add(Me.bntEliminar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblBuscarDescripcion)
        Me.Controls.Add(Me.lblBuscarCodigo)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(DescripcionLabel1)
        Me.Controls.Add(Me.DescripcionComboBox)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(IdArticuloLabel)
        Me.Controls.Add(Me.IdArticuloTextBox)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Name = "Principal"
        Me.Text = "Form1"
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreparcialDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PreparcialDataSet As EJ_PREPARCIAL.PreparcialDataSet
    Friend WithEvents ArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosTableAdapter As EJ_PREPARCIAL.PreparcialDataSetTableAdapters.ArticulosTableAdapter
    Friend WithEvents TableAdapterManager As EJ_PREPARCIAL.PreparcialDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdArticuloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents DescripcionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblBuscarCodigo As System.Windows.Forms.Label
    Friend WithEvents lblBuscarDescripcion As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents bntEliminar As System.Windows.Forms.Button

End Class
