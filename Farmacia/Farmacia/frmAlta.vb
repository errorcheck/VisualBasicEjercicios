Public Class frmAlta

    Private Sub StockBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmaciaBDDataSet)

    End Sub

    Private Sub frmAlta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FarmaciaBDDataSet.Blister' table. You can move, or remove it, as needed.
        Me.BlisterTableAdapter.Fill(Me.FarmaciaBDDataSet.Blister)
        'TODO: This line of code loads data into the 'FarmaciaBDDataSet.Stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.FarmaciaBDDataSet.Stock)

    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Me.StockBindingSource.Current("IDProducto") = IDProductoTextBox.Text
        Me.StockBindingSource.Current("Descripcion") = DescripcionTextBox.Text
        Me.StockBindingSource.Current("IDBlister") = IdBlisterComboBox.SelectedValue
        Me.StockBindingSource.Current("Cantidad") = CantidadTextBox.Text
        Me.StockBindingSource.Current("Precio") = PrecioTextBox.Text
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmaciaBDDataSet)
        Me.StockTableAdapter.Fill(Me.FarmaciaBDDataSet.Stock)
        'Actualiza en el formulario padre.
        frmPrincipal.StockTableAdapter.Fill(frmPrincipal.FarmaciaBDDataSet.Stock)
        Me.StockBindingSource.AddNew()
    End Sub
End Class