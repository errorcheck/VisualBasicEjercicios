Public Class frmGrilla

    Private Sub StockBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmaciaBDDataSet)

    End Sub

    Private Sub frmGrilla_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FarmaciaBDDataSet.Stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.FarmaciaBDDataSet.Stock)

    End Sub

    Private Sub txtBusPorDescripcion_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBusPorDescripcion.TextChanged
        Dim vista As New DataView
        vista.Table = Me.FarmaciaBDDataSet.Stock
        vista.RowFilter = "Descripcion LIKE '" & Me.txtBusPorDescripcion.Text & "%'"
        Me.StockBindingSource.DataSource = vista
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBusPorCodArticulo.TextChanged
        Dim vista As New DataView
        vista.Table = Me.FarmaciaBDDataSet.Stock
        vista.RowFilter = "IDProducto=" & Val(txtBusPorCodArticulo.Text)
        Me.StockBindingSource.DataSource = vista
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