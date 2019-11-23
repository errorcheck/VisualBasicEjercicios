Public Class principal

    Private Sub StockBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmaciaDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmaciaDataSet.stock' Puede moverla o quitarla según sea necesario.
        Me.StockTableAdapter.Fill(Me.FarmaciaDataSet.stock)

    End Sub

    Private Sub BtnAltas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAltas.Click
        Altas2.Show()

    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Modificar.Show()

    End Sub

    Private Sub BtnVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVentas.Click

    End Sub

    Private Sub BtnBuscarGrilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarGrilla.Click

    End Sub

    Private Sub BtnGriCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGriCom.Click

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click

    End Sub
End Class
