Public Class Recup_Clave

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Form1.txtLogin.Text = ""
        Form1.txtClave.Text = ""
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            If txtUsuario.Text = "" And txtCorreo.Text = "" Then
                MsgBox("Por favor ingrese sus datos en todos los campos")
            ElseIf txtUsuario.Text = "" And txtCorreo.Text <> "" Then
                MsgBox("Por favor ingrese su usuario")
            ElseIf txtUsuario.Text <> "" And txtCorreo.Text = "" Then
                MsgBox("Por favor ingrese su correo")
            Else
                Dim Usu As String
                Dim Correo As String
                Usu = txtUsuario.Text
                Correo = txtCorreo.Text
                Perdida_Correo(Usu, Correo)

            End If
        Catch ex As Exception

            MessageBox.Show("Error : " + ex.Message + "", "¡Ocurrio el siguiente Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
End Class