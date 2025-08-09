Public Class frmGrilla
    Private searchTimer As New Timer()
    Private descSearchTimer As New Timer()
    Private lastDescSearch As String = ""
    Private lastCodeSearch As String = ""
    Private sharedDataView As DataView

    Public Sub New()
        InitializeComponent()
        ' Initialize search timers for better performance
        searchTimer.Interval = 300 ' 300ms delay for debouncing
        descSearchTimer.Interval = 300
        AddHandler searchTimer.Tick, AddressOf CodeSearchTimer_Tick
        AddHandler descSearchTimer.Tick, AddressOf DescSearchTimer_Tick
    End Sub

    Private Sub StockBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmaciaBDDataSet)

    End Sub

    Private Sub frmGrilla_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FarmaciaBDDataSet.Stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.FarmaciaBDDataSet.Stock)
        
        ' OPTIMIZATION: Initialize shared DataView once
        sharedDataView = New DataView()
        sharedDataView.Table = Me.FarmaciaBDDataSet.Stock

    End Sub

    Private Sub txtBusPorDescripcion_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBusPorDescripcion.TextChanged
        ' OPTIMIZATION: Debounce search to avoid excessive filtering
        descSearchTimer.Stop()
        lastDescSearch = Me.txtBusPorDescripcion.Text
        descSearchTimer.Start()
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBusPorCodArticulo.TextChanged
        ' OPTIMIZATION: Debounce search to avoid excessive filtering
        searchTimer.Stop()
        lastCodeSearch = Me.txtBusPorCodArticulo.Text
        searchTimer.Start()
    End Sub
    
    Private Sub DescSearchTimer_Tick(sender As Object, e As EventArgs)
        descSearchTimer.Stop()
        
        ' OPTIMIZATION: Reuse shared DataView instead of creating new instance
        If lastDescSearch = String.Empty Then
            sharedDataView.RowFilter = ""
        Else
            sharedDataView.RowFilter = "Descripcion LIKE '" & lastDescSearch.Replace("'", "''") & "%'"
        End If
        Me.StockBindingSource.DataSource = sharedDataView
    End Sub
    
    Private Sub CodeSearchTimer_Tick(sender As Object, e As EventArgs)
        searchTimer.Stop()
        
        ' OPTIMIZATION: Reuse shared DataView instead of creating new instance
        If lastCodeSearch = String.Empty Then
            sharedDataView.RowFilter = ""
        Else
            sharedDataView.RowFilter = "IDProducto=" & Val(lastCodeSearch)
        End If
        Me.StockBindingSource.DataSource = sharedDataView
    End Sub

    Private Sub StockDataGridView_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StockDataGridView.CellClick
        'Dim fila As Integer
        'fila = Me.StockDataGridView.CurrentCellAddress.Y
        'frmVenta.txtCodArticulo.Text = Me.StockDataGridView.Item(0, fila).Value()
        frmVenta.txtCodArticulo.Text = Me.StockDataGridView.SelectedRows(0).Cells(0).Value()
        frmVenta.txtCantidad.Focus()
        frmVenta.Show()
        Close()
    End Sub
End Class