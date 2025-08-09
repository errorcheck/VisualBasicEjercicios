Public Class frmVenta
    Private searchTimer As New Timer()
    Private lastSearchText As String = ""

    Public Sub New()
        InitializeComponent()
        ' Initialize search timer for better performance
        searchTimer.Interval = 300 ' 300ms delay for debouncing
        AddHandler searchTimer.Tick, AddressOf SearchTimer_Tick
    End Sub

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
                    
                    ' OPTIMIZATION: Only update parent form if it's open and visible
                    If frmPrincipal.Visible Then
                        frmPrincipal.StockTableAdapter.Fill(frmPrincipal.FarmaciaBDDataSet.Stock)
                    End If
                    
                    ' OPTIMIZATION: No need to reload all data, just refresh current view
                    ' Remove redundant data fills - data is already updated in memory
                    ' Me.StockTableAdapter.Fill(Me.FarmaciaBDDataSet.Stock)
                    ' Me.VentasTableAdapter.Fill(Me.FarmaciaBDDataSet.Ventas)
                End If

            End If

        End If
    End Sub

    Private Sub txtCodArticulo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodArticulo.TextChanged
        ' OPTIMIZATION: Debounce search to avoid excessive filtering
        searchTimer.Stop()
        lastSearchText = txtCodArticulo.Text
        searchTimer.Start()
    End Sub
    
    Private Sub SearchTimer_Tick(sender As Object, e As EventArgs)
        searchTimer.Stop()
        
        If lastSearchText = String.Empty Then
            Me.StockDataGridView.DataSource = Me.StockBindingSource
        Else
            ' OPTIMIZATION: Use existing DataView instead of creating new one each time
            Dim vista As DataView = CType(Me.StockDataGridView.DataSource, DataView)
            If vista Is Nothing Then
                vista = New DataView()
                vista.Table = Me.FarmaciaBDDataSet.Stock
            End If
            vista.RowFilter = "IDProducto=" & Val(lastSearchText)
            Me.StockDataGridView.DataSource = vista
        End If
    End Sub
End Class