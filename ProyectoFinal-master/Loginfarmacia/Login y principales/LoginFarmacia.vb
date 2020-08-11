Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class LoginFarmacia
    Dim conexion As New Conexion()
    Private Sub LoginFarmacia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conexion.conectar()
        llenarRol()
    End Sub

    Private Sub limpiar()
        txtnombreusuario.Text = ""
        txtcontraseña.Text = ""
    End Sub
    Private Sub ingresarFarmaciaempleados()
        Dim userName, psw, rol As String

        userName = txtnombreusuario.Text
        rol = cmbrol.Text
        psw = txtcontraseña.Text
        Try
            If (conexion.validarUsuario(userName, psw, rol)) Then
                If (rol = "Farmaceutico") Then
                    MsgBox("Bienvenido(a) Farmacéutico(a)")
                    FarmaciaGerente.txtflag.Text = "1"
                    limpiar()
                    FarmaciaGerente.Show()
                    Me.Hide()
                ElseIf (rol = "Auxiliar") Then
                    MsgBox("Bienvenido(a)")
                    FarmaciaGerente.txtflag.Text = "2"
                    limpiar()
                    FarmaciaGerente.Show()

                    Me.Hide()
                End If
            Else
                MsgBox("Datos incorrectos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub llenarRol()
        conexion.llenarRol()
        cmbrol.DataSource = conexion.datos.Tables("Rol")
        cmbrol.DisplayMember = "Rol"
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtnombreusuario.Text = "" And txtnombreusuario.Text.Length < 13 Then
            MsgBox("Ingrese un usuario valido")
        ElseIf txtcontraseña.Text = "" Then
            MsgBox("Ingrese su contraseña")
        Else
            ingresarFarmaciaempleados()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Esta Seguro que quiere salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub txtnombreusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombreusuario.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtnombreusuario_Validating(sender As Object, e As CancelEventArgs) Handles txtnombreusuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cmbrol_Validating(sender As Object, e As CancelEventArgs) Handles cmbrol.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtcontraseña_Validating(sender As Object, e As CancelEventArgs) Handles txtcontraseña.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Esta Seguro que quiere salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover
        btnSalir.BackColor = Color.Red
    End Sub

    Private Sub btnSalir_MouseLeave(sender As Object, e As EventArgs) Handles btnSalir.MouseLeave
        btnSalir.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(38, 45, 53))
    End Sub

    Private Sub btnlogin_MouseHover(sender As Object, e As EventArgs) Handles btnlogin.MouseHover
        btnlogin.BackColor = Color.Blue
    End Sub

    Private Sub btnlogin_MouseLeave(sender As Object, e As EventArgs) Handles btnlogin.MouseLeave
        btnlogin.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(38, 45, 53))
    End Sub
End Class


