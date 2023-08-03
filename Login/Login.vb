Imports System.Net.Security

Public Class Login
    Private Sub btnCanelar_Click(sender As Object, e As EventArgs) Handles btnCanelar.Click
        End
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click



        Dim usuarioEsperado As String = "admin"
        Dim contraseñaEsperado As String = "admin"

        Dim usuarioIngresado As String = txtUsuario.Text
        Dim contraseñaIngresada As String = txtContraseña.Text

        If (usuarioIngresado = usuarioEsperado And contraseñaIngresada = contraseñaEsperado) Then
            Inicio.Show()
            Me.Hide()
            txtUsuario.Text = ""
            txtContraseña.Text = ""
        Else
            MessageBox.Show("El usuario o la contraseña esta mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If




    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
