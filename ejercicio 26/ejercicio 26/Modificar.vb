Public Class Modificar

    Private Sub StockBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmaciaDataSet)

    End Sub

    Private Sub Modificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmaciaDataSet.stock' Puede moverla o quitarla según sea necesario.
        Me.StockTableAdapter.Fill(Me.FarmaciaDataSet.stock)

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim fila, CodConsulta As Integer
        CodConsulta = InputBox("ingrese articulo")
        fila = Me.StockBindingSource.Find("Id_art", CodConsulta)
        If fila = -1 Then
            MsgBox("el registro no se encontro")
        Else
            Me.StockBindingSource.Position = fila
        End If
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmaciaDataSet)
        Me.StockTableAdapter.Fill(Me.FarmaciaDataSet.stock)
    End Sub
End Class