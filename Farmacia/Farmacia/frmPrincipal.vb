Public Class frmPrincipal

    Private Sub StockBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmaciaBDDataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FarmaciaBDDataSet.Stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.FarmaciaBDDataSet.Stock)

    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnAlta_Click(sender As System.Object, e As System.EventArgs) Handles btnAlta.Click
        frmAlta.Show()
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        frmModificar.Show()
    End Sub

    Private Sub btnVenta_Click(sender As System.Object, e As System.EventArgs) Handles btnVenta.Click
        frmVenta.Show()
    End Sub

    Private Sub btnBuscarEnGrilla_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarEnGrilla.Click
        frmGrilla.Show()
    End Sub

    Private Sub btnGrillaCompuesta_Click(sender As System.Object, e As System.EventArgs) Handles btnGrillaCompuesta.Click
        frmGrillaCompuesta.Show()
    End Sub
End Class
