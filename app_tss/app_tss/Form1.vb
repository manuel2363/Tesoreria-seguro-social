Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClean.Click
        txtLogin.Text = ""
        txtClave.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngre.Click

        Try
            If txtLogin.Text = "" And txtClave.Text = "" Then
                MsgBox("Por favor ingrese sus datos en todos los campos", MsgBoxStyle.ApplicationModal, "Información")
            ElseIf txtLogin.Text <> "" And txtClave.Text = "" Then
                MsgBox("Por favor ingrese la clave", MsgBoxStyle.ApplicationModal, "Información")
            ElseIf txtLogin.Text = "" And txtClave.Text <> "" Then
                MsgBox("Por favor ingrese su usuario", MsgBoxStyle.ApplicationModal, "Información")
            Else
                Dim usu As String
                Dim clave As String
                usu = txtLogin.Text
                clave = txtClave.Text
                login(usu, clave)

            End If

        Catch ex As Exception

            MessageBox.Show("Error : " + ex.Message + "", "¡Ocurrio el siguiente Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub BtnConex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConex.Click

        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()

        If ConexionPostgres.State = ConnectionState.Open Then

            MsgBox("Conexión Exitosa", MsgBoxStyle.OkOnly, "Prueba de Conexión")

        Else

            MsgBox("Conexión Fallida", MsgBoxStyle.Critical, "Prueba de Conexión")

        End If
        'ConexionPostgres.Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Recup_Clave.Show()
    End Sub

End Class
