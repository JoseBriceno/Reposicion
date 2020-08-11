Imports System.ComponentModel
Public Class MostrarProveedor
    Dim conexion As New conexion()
    Dim dt As New DataTable()
    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub
    Public Sub mostrar()
        Try
            Dim func As New conexion
            dt = func.mostrarProveedor

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt

                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False

            Else
                datalistado.DataSource = Nothing

                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "2" Then
            frmCompra.txtidproveedor.Text = datalistado.SelectedCells.Item(0).Value
            frmCompra.txtnombre_proveedor.Text = datalistado.SelectedCells.Item(1).Value
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub MostrarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
End Class