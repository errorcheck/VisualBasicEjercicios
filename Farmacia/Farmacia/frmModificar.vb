Public Class frmModificar

    Private Sub StockBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmaciaBDDataSet)

    End Sub

    Private Sub frmModificar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FarmaciaBDDataSet.Stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.FarmaciaBDDataSet.Stock)

    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim fila, CodConsulta As Integer
        CodConsulta = InputBox("Ingrese el codigo de PRODUCTO buscar:")
        fila = Me.StockBindingSource.Find("IDProducto", CodConsulta)
        If fila = -1 Then
            MsgBox("El registro no se encuentra")
        Else
            Me.StockBindingSource.Position = fila
        End If

    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmaciaBDDataSet)
        Me.StockTableAdapter.Fill(Me.FarmaciaBDDataSet.Stock)
    End Sub
End Class