Public Class Altas2

    Private Sub StockBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmaciaDataSet)

    End Sub

    Private Sub Altas2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmaciaDataSet.Blister' Puede moverla o quitarla según sea necesario.
        Me.BlisterTableAdapter.Fill(Me.FarmaciaDataSet.Blister)
        'TODO: esta línea de código carga datos en la tabla 'FarmaciaDataSet.stock' Puede moverla o quitarla según sea necesario.
        Me.StockTableAdapter.Fill(Me.FarmaciaDataSet.stock)

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Me.StockBindingSource.Current("Id_Producto") = Val(Id_ProductoTextBox.Text)
        Me.StockBindingSource.Current("Descripcion") = DescripcionTextBox.Text
        Me.StockBindingSource.Current("Blister") = BlisterComboBox.SelectedValue
        Me.StockBindingSource.Current("Cantida") = Val(CantidaTextBox.Text)
        Me.StockBindingSource.Current("Precio") = Val(PrecioTextBox.Text)
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmaciaDataSet)
        Me.StockTableAdapter.Fill(Me.FarmaciaDataSet.stock)
        principal.StockTableAdapter.Fill(principal.FarmaciaDataSet.stock)
        Me.StockBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class