Imports System.ComponentModel

Public Class frmCompra
    Dim conexion As New conexion()
    Dim dt As New DataTable()

    Private Sub frmCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_compraPro()
    End Sub
    Public Sub mostrar_compraPro()
        Try
            Dim func As New conexion
            dt = func.mostrarCompraProveedor

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
                ocultar_columnas()
            Else
                datalistado.DataSource = Nothing

                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'buscar()
    End Sub
    Public Sub limpiar()
        btnguardar.Visible = True
        txtidproducto.Text = ""
        txtnom_producto.Text = ""
        txtprecio_compra.Text = ""
        txtidcompra.Text = ""
        txtidproveedor.Text = ""
        txtnombre_proveedor.Text = ""
        txtcantidad.Value = 0
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(0).Visible = False
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
    End Sub

    Private Sub InsertarCompraProveedor()
        Dim idProveedor, idproducto, cantidad As Integer
        Dim PrecioCompra As Double
        Dim fechaCompra As Date

        idProveedor = txtidproveedor.Text
        idproducto = txtidproducto.Text
        cantidad = txtcantidad.Text
        PrecioCompra = txtprecio_compra.Text
        fechaCompra = txtfechaCompra.Text

        If conexion.aumentar_stock(idproducto, cantidad) Then
        End If
        Try
            If conexion.insertarCompraProveedor(idProveedor, idproducto, PrecioCompra, cantidad, fechaCompra) Then

            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtidproducto.Text <> "" And txtcantidad.Text <> "" And txtprecio_compra.Text <> "" Then
            Try
                InsertarCompraProveedor()
                mostrar_compraPro()
                limpiar()
                conexion.conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Revise los datos Ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar_compraPro()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        MostrarProductos.txtflag.Text = "2"
        MostrarProductos.ShowDialog()
    End Sub
    Private Sub btnbuscarPro_Click(sender As Object, e As EventArgs) Handles btnbuscarPro.Click
        MostrarProveedor.txtflag.Text = "2"
        MostrarProveedor.ShowDialog()
    End Sub

    Private Sub txtprecio_compra_TextChanged(sender As Object, e As EventArgs) Handles txtprecio_compra.TextChanged

    End Sub

    Private Sub txtprecio_compra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio_compra.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnbuscarPro_MouseHover(sender As Object, e As EventArgs) Handles btnbuscarPro.MouseHover
        ToolTip.SetToolTip(btnbuscarPro, "Buscar en tabla proveedor")
        ToolTip.ToolTipTitle = "Buscar Proveedor"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnBuscarProducto_MouseHover(sender As Object, e As EventArgs) Handles btnBuscarProducto.MouseHover
        ToolTip.SetToolTip(btnbuscarPro, "Buscar en tabla productos")
        ToolTip.ToolTipTitle = "Buscar Productos"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class