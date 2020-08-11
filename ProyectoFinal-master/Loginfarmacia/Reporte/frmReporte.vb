Imports System.ComponentModel

Public Class frmReporte
    Dim conexion As New conexion()
    Dim dt As New DataTable()

    Private Sub frmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtidventa.Text = frmDetalles_venta.txtidventa.Text
        mostrar()
        mostrar2()
    End Sub

    Public Sub mostrar()
        Dim idventa As Integer

        idventa = txtidventa.Text
        Try
            Dim func As New conexion
            dt = func.mostrarReporte(idventa)

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False

            Else
                datalistado.DataSource = Nothing
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub mostrar2()
        Dim idventa As Integer

        idventa = txtidventa.Text
        Try
            Dim func As New conexion
            dt = func.MostrarTotal(idventa)

            If dt.Rows.Count <> 0 Then
                dataSuma.DataSource = dt
                dataSuma.ColumnHeadersVisible = True
                ocultar_columnas()
            Else
                dataSuma.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ocultar_columnas()
        dataSuma.Columns(0).Visible = False
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub datalistado_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    Private Sub dataSuma_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataSuma.CellContentClick

    End Sub
End Class