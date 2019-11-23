Public Class Principal

    Private Sub ArticulosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PreparcialDataSet)

    End Sub

    Private Sub Principal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PreparcialDataSet.Articulos' table. You can move, or remove it, as needed.
        Me.ArticulosTableAdapter.Fill(Me.PreparcialDataSet.Articulos)
    End Sub

    Private Sub ArticulosBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PreparcialDataSet)

    End Sub

    Private Sub btnSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles btnSiguiente.Click
        Me.ArticulosBindingSource.MoveNext()
    End Sub

    Private Sub btnAtras_Click(sender As System.Object, e As System.EventArgs) Handles btnAtras.Click
        Me.ArticulosBindingSource.MovePrevious()
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Me.ArticulosBindingSource.AddNew()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Me.ArticulosBindingSource.EndEdit()        
        'Me.ArticulosTableAdapter.Update(Me.PreparcialDataSet)
        Me.TableAdapterManager.UpdateAll(Me.PreparcialDataSet)
        Me.ArticulosTableAdapter.Fill(Me.PreparcialDataSet.Articulos)
        Me.ArticulosBindingSource.MoveLast()
        MsgBox(String.Format("Registro guardado correctamente: {0}", Me.ArticulosBindingSource.Current("IdArticulo")))
    End Sub

    Private Sub TextBox1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim iIdxFila As Integer
        If e.KeyChar = vbCr Then
            'iIdxFila = Me.ArticulosBindingSource.Filter = "Descripcion LIKE '%" & TextBox1.Text & "%'"
            iIdxFila = Me.ArticulosBindingSource.Find("Codigo", TextBox1.Text)
            If iIdxFila > -1 Then
                ArticulosBindingSource.Position = iIdxFila
            Else
                MsgBox("No se encontró el registro.")
            End If
        End If
    End Sub

    Private Sub bntEliminar_Click(sender As System.Object, e As System.EventArgs) Handles bntEliminar.Click
        Dim rta As DialogResult
        rta = MsgBox("¿Seguro de eliminar el registro?", MsgBoxStyle.YesNo)
        If rta = Windows.Forms.DialogResult.Yes Then
            Me.ArticulosBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.PreparcialDataSet)
            MsgBox("Registro eliminado.")
            Me.ArticulosTableAdapter.Fill(Me.PreparcialDataSet.Articulos)
            Me.ArticulosBindingSource.MoveFirst()
        End If

    End Sub
End Class
