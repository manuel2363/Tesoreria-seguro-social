Public Class Param_Empleado
    Dim nacionalidad, cedula As String
    Dim pnombre, snombre, papellido, sapellido, direc, telef1, telf2, correo As String
    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        Me.Close()
        Param_empresa.Show()
    End Sub

    Private Sub CargoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargoToolStripMenuItem1.Click
        Me.Close()
        Param_Cargo.Show()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        Me.Close()
        Regis_Empre.Show()
    End Sub

    Private Sub CerrarSessionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSessionToolStripMenuItem.Click
        Form1.txtLogin.Text = ""
        Form1.txtClave.Text = ""
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        S_Usu_Nuevo.Show()
        Me.Close()
    End Sub

    Private Sub CambioDeCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambioDeCToolStripMenuItem.Click
        S_Usu_cambio_clave.Show()
        Me.Close()
    End Sub

    Private Sub AfiliaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AfiliaciónToolStripMenuItem.Click
        Me.Close()
        A_afilia_tipos.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoBtn_v.CheckedChanged
        If RdoBtn_v.Checked = True Then
            nacionalidad = "V-"
        ElseIf RdoBtn_e.Checked = True Then
            nacionalidad = "E-"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If RdoBtn_e.Enabled = False And RdoBtn_v.Enabled = False Then
                MsgBox("Por favor ingresar nacionalidad")
            ElseIf Masktxt_ced.Text = "" Then
                MsgBox("Ingrese el número de cedula")
            Else
                cedula = Masktxt_ced.Text
                P_emple_busqueda(nacionalidad, cedula)
            End If

        Catch ex As Exception

            MessageBox.Show("Error : " + ex.Message + "", "¡Ocurrio el siguiente Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            pnombre = txtpNombre.Text
            snombre = txtsNombre.Text
            papellido = txtsApellido.Text
            sapellido = txtsApellido.Text
            direc = txtdireccion.Text
            telef1 = MaskTlfHab.Text
            telf2 = MaskTlfMovil.Text
            correo = txtCorreo.Text

            If pnombre = "" And snombre = "" And papellido = "" And sapellido = "" And
               direc = "" And telef1 = "" And telf2 = "" And correo = "" Then
                MsgBox("Por favor ingrese datos en todos los campos", MsgBoxStyle.ApplicationModal, "Información")
            Else

                P_emple_actualizar(pnombre, snombre, papellido, sapellido, direc, telef1, telf2, correo)

                MessageBox.Show("Cambio exitoso", "¡Cambio exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception

            MessageBox.Show("Error : " + ex.Message + "", "¡Ocurrio el siguiente Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Menu_Principal.Show()
    End Sub
End Class