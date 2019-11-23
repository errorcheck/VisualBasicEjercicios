Public Class altas

    Private Sub MercaderiaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.MercaderiaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ArticulosDataSet)

    End Sub

    Private Sub altas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ArticulosDataSet.mercaderia' Puede moverla o quitarla según sea necesario.
        Me.MercaderiaTableAdapter.Fill(Me.ArticulosDataSet.mercaderia)
        Me.MercaderiaBindingSource.AddNew()



    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.MercaderiaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ArticulosDataSet)
        principal.MercaderiaTableAdapter.Fill(principal.ArticulosDataSet.mercaderia)
        Me.MercaderiaTableAdapter.Fill(Me.ArticulosDataSet.mercaderia)
        Me.MercaderiaBindingSource.MoveLast()
        MsgBox("se guardo el registro numero: " + Me.MercaderiaBindingSource.Current("id_Art").ToString)
        Me.MercaderiaBindingSource.AddNew()

    End Sub

    Private Sub DescripcionTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles DescripcionTextBox.TextChanged

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class