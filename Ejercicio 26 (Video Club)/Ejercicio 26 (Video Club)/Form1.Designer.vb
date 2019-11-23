<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CodVideoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim GeneroLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.VideoClubDataSet = New Video_Club.VideoClubDataSet()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter = New Video_Club.VideoClubDataSetTableAdapters.StockTableAdapter()
        Me.TableAdapterManager = New Video_Club.VideoClubDataSetTableAdapters.TableAdapterManager()
        Me.StockBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.StockBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodVideoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.GeneroTextBox = New System.Windows.Forms.TextBox()
        Me.StockDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnPrimero = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnAlta = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnAlquilar = New System.Windows.Forms.Button()
        Me.BtnDevolucion = New System.Windows.Forms.Button()
        CodVideoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        GeneroLabel = New System.Windows.Forms.Label()
        CType(Me.VideoClubDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StockBindingNavigator.SuspendLayout()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodVideoLabel
        '
        CodVideoLabel.AutoSize = True
        CodVideoLabel.Location = New System.Drawing.Point(29, 63)
        CodVideoLabel.Name = "CodVideoLabel"
        CodVideoLabel.Size = New System.Drawing.Size(59, 13)
        CodVideoLabel.TabIndex = 1
        CodVideoLabel.Text = "Cod Video:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(29, 89)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(29, 115)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 5
        CantidadLabel.Text = "Cantidad:"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.Location = New System.Drawing.Point(29, 141)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(45, 13)
        GeneroLabel.TabIndex = 7
        GeneroLabel.Text = "Genero:"
        '
        'VideoClubDataSet
        '
        Me.VideoClubDataSet.DataSetName = "VideoClubDataSet"
        Me.VideoClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "Stock"
        Me.StockBindingSource.DataSource = Me.VideoClubDataSet
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StockTableAdapter = Me.StockTableAdapter
        Me.TableAdapterManager.UpdateOrder = Video_Club.VideoClubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StockBindingNavigator
        '
        Me.StockBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StockBindingNavigator.BindingSource = Me.StockBindingSource
        Me.StockBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StockBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StockBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StockBindingNavigatorSaveItem})
        Me.StockBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StockBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StockBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StockBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StockBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StockBindingNavigator.Name = "StockBindingNavigator"
        Me.StockBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StockBindingNavigator.Size = New System.Drawing.Size(735, 25)
        Me.StockBindingNavigator.TabIndex = 0
        Me.StockBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
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
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'StockBindingNavigatorSaveItem
        '
        Me.StockBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StockBindingNavigatorSaveItem.Image = CType(resources.GetObject("StockBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StockBindingNavigatorSaveItem.Name = "StockBindingNavigatorSaveItem"
        Me.StockBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StockBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CodVideoTextBox
        '
        Me.CodVideoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "CodVideo", True))
        Me.CodVideoTextBox.Location = New System.Drawing.Point(94, 60)
        Me.CodVideoTextBox.Name = "CodVideoTextBox"
        Me.CodVideoTextBox.Size = New System.Drawing.Size(157, 20)
        Me.CodVideoTextBox.TabIndex = 2
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(94, 86)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(157, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(94, 112)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(157, 20)
        Me.CantidadTextBox.TabIndex = 6
        '
        'GeneroTextBox
        '
        Me.GeneroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StockBindingSource, "Genero", True))
        Me.GeneroTextBox.Location = New System.Drawing.Point(94, 138)
        Me.GeneroTextBox.Name = "GeneroTextBox"
        Me.GeneroTextBox.Size = New System.Drawing.Size(157, 20)
        Me.GeneroTextBox.TabIndex = 8
        '
        'StockDataGridView
        '
        Me.StockDataGridView.AutoGenerateColumns = False
        Me.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.StockDataGridView.DataSource = Me.StockBindingSource
        Me.StockDataGridView.Location = New System.Drawing.Point(257, 60)
        Me.StockDataGridView.Name = "StockDataGridView"
        Me.StockDataGridView.Size = New System.Drawing.Size(461, 98)
        Me.StockDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodVideo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodVideo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Genero"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Genero"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'BtnPrimero
        '
        Me.BtnPrimero.Location = New System.Drawing.Point(325, 164)
        Me.BtnPrimero.Name = "BtnPrimero"
        Me.BtnPrimero.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrimero.TabIndex = 10
        Me.BtnPrimero.Text = "<<"
        Me.BtnPrimero.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.Location = New System.Drawing.Point(406, 164)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(75, 23)
        Me.BtnAnterior.TabIndex = 11
        Me.BtnAnterior.Text = "<"
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Location = New System.Drawing.Point(487, 164)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.BtnSiguiente.TabIndex = 13
        Me.BtnSiguiente.Text = ">"
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'BtnUltimo
        '
        Me.BtnUltimo.Location = New System.Drawing.Point(568, 164)
        Me.BtnUltimo.Name = "BtnUltimo"
        Me.BtnUltimo.Size = New System.Drawing.Size(75, 23)
        Me.BtnUltimo.TabIndex = 12
        Me.BtnUltimo.Text = ">>"
        Me.BtnUltimo.UseVisualStyleBackColor = True
        '
        'BtnAlta
        '
        Me.BtnAlta.Location = New System.Drawing.Point(163, 228)
        Me.BtnAlta.Name = "BtnAlta"
        Me.BtnAlta.Size = New System.Drawing.Size(75, 23)
        Me.BtnAlta.TabIndex = 14
        Me.BtnAlta.Text = "Alta"
        Me.BtnAlta.UseVisualStyleBackColor = True
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(244, 228)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConsultar.TabIndex = 15
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(325, 227)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 16
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(487, 257)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 17
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnAlquilar
        '
        Me.BtnAlquilar.Location = New System.Drawing.Point(406, 228)
        Me.BtnAlquilar.Name = "BtnAlquilar"
        Me.BtnAlquilar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAlquilar.TabIndex = 26
        Me.BtnAlquilar.Text = "Alquilar"
        Me.BtnAlquilar.UseVisualStyleBackColor = True
        '
        'BtnDevolucion
        '
        Me.BtnDevolucion.Location = New System.Drawing.Point(487, 228)
        Me.BtnDevolucion.Name = "BtnDevolucion"
        Me.BtnDevolucion.Size = New System.Drawing.Size(75, 23)
        Me.BtnDevolucion.TabIndex = 27
        Me.BtnDevolucion.Text = "Devolución"
        Me.BtnDevolucion.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 287)
        Me.Controls.Add(Me.BtnDevolucion)
        Me.Controls.Add(Me.BtnAlquilar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.BtnAlta)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Controls.Add(Me.BtnUltimo)
        Me.Controls.Add(Me.BtnAnterior)
        Me.Controls.Add(Me.BtnPrimero)
        Me.Controls.Add(Me.StockDataGridView)
        Me.Controls.Add(CodVideoLabel)
        Me.Controls.Add(Me.CodVideoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(GeneroLabel)
        Me.Controls.Add(Me.GeneroTextBox)
        Me.Controls.Add(Me.StockBindingNavigator)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.VideoClubDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StockBindingNavigator.ResumeLayout(False)
        Me.StockBindingNavigator.PerformLayout()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VideoClubDataSet As Video_Club.VideoClubDataSet
    Friend WithEvents StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockTableAdapter As Video_Club.VideoClubDataSetTableAdapters.StockTableAdapter
    Friend WithEvents TableAdapterManager As Video_Club.VideoClubDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StockBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StockBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodVideoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GeneroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StockDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnPrimero As System.Windows.Forms.Button
    Friend WithEvents BtnAnterior As System.Windows.Forms.Button
    Friend WithEvents BtnSiguiente As System.Windows.Forms.Button
    Friend WithEvents BtnUltimo As System.Windows.Forms.Button
    Friend WithEvents BtnAlta As System.Windows.Forms.Button
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnAlquilar As System.Windows.Forms.Button
    Friend WithEvents BtnDevolucion As System.Windows.Forms.Button

End Class
