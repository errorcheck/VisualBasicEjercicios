Public Class Form2

    Private Sub StockBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VideoClubDataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VideoClubDataSet.Stock' Puede moverla o quitarla según sea necesario.
        Me.StockTableAdapter.Fill(Me.VideoClubDataSet.Stock)
        Me.StockBindingSource.AddNew()

    End Sub

    'Boton "Guardar"
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Me.StockBindingSource.EndEdit() 'Cierro la Base
        Me.TableAdapterManager.UpdateAll(Me.VideoClubDataSet) 'Grabo en Disco y devuelve el número de Índice

        'Actualizo el Formulario Anterior "Principal" para que cargue el ultimo dato agregado
        Form1.StockTableAdapter.Fill(Form1.VideoClubDataSet.Stock)

        'Para que muetre el Código
        Me.StockTableAdapter.Fill(Me.VideoClubDataSet.Stock) 'Actualizo el recorset
        Me.StockBindingSource.MoveLast()  'Mueve al último registro agregado
        MsgBox("Se Guardó El Registro Número: " + Me.StockBindingSource.Current("CodVideo").ToString) '"ToString" Para que no intente sumar
        '                                                                  .Current("ID_Cod_Art") devuelve el dato que se encuentra en ese registro
        Me.StockBindingSource.AddNew() 'Vuelve a Aparecer los textbox en blanco
        'NombreTextBox.Focus()
        Close()
    End Sub
    'Boton "Volver"
    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Close()

    End Sub
End Class