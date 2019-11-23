Public Class Form1

    Private Sub StockBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VideoClubDataSet)

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VideoClubDataSet.Stock' Puede moverla o quitarla según sea necesario.
        Me.StockTableAdapter.Fill(Me.VideoClubDataSet.Stock)

    End Sub

    'Botones Primero/Anterior/Siguiente/Último
    Private Sub BtnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrimero.Click
        'Mover al primero
        Me.StockBindingSource.MoveFirst()

    End Sub
    Private Sub BtnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnterior.Click
        Me.StockBindingSource.MovePrevious()
    End Sub
    Private Sub BtnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSiguiente.Click
        Me.StockBindingSource.MoveNext()
    End Sub
    Private Sub BtnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUltimo.Click
        Me.StockBindingSource.MoveLast()
    End Sub

    'Boton "Alta"
    Private Sub BtnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlta.Click
        Form2.Show()

    End Sub
    'Boton "Salir"
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        End

    End Sub
    'Boton "Eliminar"
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim fila, CodConsulta, aux As Integer
        CodConsulta = InputBox("Código de Video: ")
        fila = Me.StockBindingSource.Find("CodVideo", CodConsulta)
        If fila = -1 Then
            MsgBox("El Registro No Se Encontró")
        Else
            Me.StockBindingSource.Position = fila 'Mover la Fila a la que ingreso en la busqueda
            aux = MsgBox("Quiere Eliminar El Registro: " & CodConsulta, 32 + 1, "Eliminar")
            If aux = 1 Then
                Me.StockBindingSource.RemoveCurrent() 'Eliminó
                Me.StockBindingSource.EndEdit() 'Cierro Edicion
                Me.TableAdapterManager.UpdateAll(Me.VideoClubDataSet) 'Grabó
            End If
        End If
    End Sub
    'Boton "Consultar"
    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultar.Click
        Dim fila, CodigoConsulta As Integer
        CodigoConsulta = InputBox("Ingrese Código de Consulta")
        fila = Me.StockBindingSource.Find("CodVideo", CodigoConsulta)
        If fila = -1 Then
            MsgBox("El registro No Se Encontró")
        Else
            StockBindingSource.Position = fila
        End If
    End Sub
    'Boton "Alquilar"
    Private Sub BtnAlquilar_Click(sender As System.Object, e As System.EventArgs) Handles BtnAlquilar.Click
        Dim fila, CodConsulta, aux As Integer
        CodConsulta = InputBox("Codigo De Video")
        fila = Me.StockBindingSource.Find("CodVideo", CodConsulta)
        If fila = -1 Then
            'no se encontró último registro -1
            MsgBox("El registro No Se Encontró")
        Else
            'Se Encontró
            StockBindingSource.Position = fila
            'aux = MsgBox("Quiere Alguilar Este Video: " & CodConsulta, 32 + 1, "Alquilar")
            aux = MsgBox("Quiere Alguilar Este Video: " & StockBindingSource.Current("Nombre"), 32 + 1, "Alquilar")

            If aux = 1 Then
                If StockBindingSource.Current("Cantidad") > 0 Then

                    Me.StockBindingSource.Current("Cantidad") = StockBindingSource.Current("Cantidad") - 1
                    Me.StockBindingSource.EndEdit() 'Cierro Edicion
                    Me.TableAdapterManager.UpdateAll(Me.VideoClubDataSet)
                    Me.StockTableAdapter.Fill(Me.VideoClubDataSet.Stock)
                    MsgBox("El Video Ha Sido Alquilado")

                Else
                    MsgBox("La Película No Se Encuentra En Stock")
                    'MsgBox("El Stock Actual es: " + Me.StockBindingSource.Current("Cantidad").ToString)

                End If
            End If
        End If

    End Sub
    'Boton "Devolver"
    Private Sub BtnDevolucion_Click(sender As System.Object, e As System.EventArgs) Handles BtnDevolucion.Click
        Dim fila, CodConsulta, aux As Integer
        CodConsulta = InputBox("Codigo De Video")
        fila = Me.StockBindingSource.Find("CodVideo", CodConsulta)
        If fila = -1 Then
            'no se encontró último registro -1
            MsgBox("El registro No Se Encontró")
        Else
            'Se Encontró
            StockBindingSource.Position = fila
            'aux = MsgBox("Quiere Alguilar Este Video: " & CodConsulta, 32 + 1, "Alquilar")
            aux = MsgBox("Quiere Devolver Este Video: " & StockBindingSource.Current("Nombre"), 32 + 1, "Alquilar")

            If aux = 1 Then
                If StockBindingSource.Current("Cantidad") > 0 Then

                    Me.StockBindingSource.Current("Cantidad") = StockBindingSource.Current("Cantidad") + 1
                    Me.StockBindingSource.EndEdit() 'Cierro Edicion
                    Me.TableAdapterManager.UpdateAll(Me.VideoClubDataSet)
                    Me.StockTableAdapter.Fill(Me.VideoClubDataSet.Stock)
                    MsgBox("El Video Ha Sido Devuelto")

                Else
                    MsgBox("La Película No Se Encuentra En Stock")
                    'MsgBox("El Stock Actual es: " + Me.StockBindingSource.Current("Cantidad").ToString)

                End If
            End If
        End If
    End Sub

End Class
