<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrillaCompuesta
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
        Me.dtgDatos = New System.Windows.Forms.DataGridView()
        Me.colCodArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBlister = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgDatos
        '
        Me.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodArticulo, Me.colDescripcion, Me.colBlister, Me.colCantidad, Me.colPrecio, Me.colSubTotal})
        Me.dtgDatos.Location = New System.Drawing.Point(12, 13)
        Me.dtgDatos.Name = "dtgDatos"
        Me.dtgDatos.Size = New System.Drawing.Size(660, 191)
        Me.dtgDatos.TabIndex = 0
        '
        'colCodArticulo
        '
        Me.colCodArticulo.HeaderText = "Código de Articulo"
        Me.colCodArticulo.Name = "colCodArticulo"
        '
        'colDescripcion
        '
        Me.colDescripcion.HeaderText = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        '
        'colBlister
        '
        Me.colBlister.HeaderText = "Blister"
        Me.colBlister.Name = "colBlister"
        '
        'colCantidad
        '
        Me.colCantidad.HeaderText = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        '
        'colPrecio
        '
        Me.colPrecio.HeaderText = "Precio"
        Me.colPrecio.Name = "colPrecio"
        '
        'colSubTotal
        '
        Me.colSubTotal.HeaderText = "SubTotal"
        Me.colSubTotal.Name = "colSubTotal"
        '
        'frmGrillaCompuesta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 438)
        Me.Controls.Add(Me.dtgDatos)
        Me.Name = "frmGrillaCompuesta"
        Me.Text = "frmGrillaCompuesta"
        CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgDatos As System.Windows.Forms.DataGridView
    Friend WithEvents colCodArticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBlister As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
