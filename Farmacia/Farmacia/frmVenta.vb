Public Class frmVenta

    Private Sub StockBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmaciaBDDataSet)

    End Sub

    Private Sub frmVenta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FarmaciaBDDataSet.Ventas' table. You can move, or remove it, as needed.
        Me.VentasTableAdapter.Fill(Me.FarmaciaBDDataSet.Ventas)
        'TODO: This line of code loads data into the 'FarmaciaBDDataSet.Stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.FarmaciaBDDataSet.Stock)

    End Sub

    Private Sub btnVender_Click(sender As System.Object, e As System.EventArgs) Handles btnVender.Click
        Dim CodConsulta, fila, aux As Integer
        Dim importe As Decimal
        CodConsulta = Val(txtCodArticulo.Text)
        fila = Me.StockBindingSource.Find("IDArticulo", CodConsulta)
        If fila = -1 Then
            MsgBox("El registro no se encuentra")
        Else
            Me.StockBindingSource.Position = fila
            aux = MsgBox("Quiere realmente vender el codigo: " & CodConsulta, 32 + 1, "VENDER")
            If aux = 1 Then
                If Me.StockBindingSource.Current("Cantidad") >= Val(txtCantidad.Text) Then
                    'Agrega el registro
                    Me.VentasBindingSource.AddNew()
                    Me.VentasBindingSource.Current("IDArticulo") = Me.StockBindingSource.Current("IDArticulo")
                    Me.VentasBindingSource.Current("Cantidad") = Val(txtCantidad.Text)
                    Me.VentasBindingSource.Current("Precio") = Val(txtCantidad.Text) * Me.StockBindingSource.Current("Precio")
                    'Finaliza la actualizacion de la venta
                    Me.VentasBindingSource.EndEdit()
                    Me.VentasTableAdapter.Update(Me.FarmaciaBDDataSet.Ventas)

                    'Actualiza el valor de stock
                    Me.StockBindingSource.Current("Cantidad") = Me.StockBindingSource.Current("Cantidad") - Val(txtCantidad.Text)
                    importe = Val(txtCantidad.Text) * Me.StockBindingSource.Current("Precio")
                    MsgBox("La venta ha sidorealizada con exito el importe es: $" & importe)

                    'Finaliza la actualizacion del stock
                    Me.StockBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.FarmaciaBDDataSet)
                    'Actualiza conexion en el principal
                    frmPrincipal.StockTableAdapter.Fill(frmPrincipal.FarmaciaBDDataSet.Stock)
                    'Vuelve a cargar los datos (refresca)
                    Me.StockTableAdapter.Fill(Me.FarmaciaBDDataSet.Stock)
                    Me.VentasTableAdapter.Fill(Me.FarmaciaBDDataSet.Ventas)
                End If

            End If

        End If
    End Sub

    Private Sub txtCodArticulo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodArticulo.TextChanged
        Dim vista As New DataView
        vista.Table = Me.FarmaciaBDDataSet.Stock
        vista.RowFilter = "IDProducto=" & Val(txtCodArticulo.Text)
        Me.StockDataGridView.DataSource = vista
        If txtCodArticulo.Text = String.Empty Then
            Me.StockTableAdapter.Fill(Me.FarmaciaBDDataSet.Stock)
            Me.StockDataGridView.DataSource = Me.StockBindingSource
        End If

    End Sub
End Class