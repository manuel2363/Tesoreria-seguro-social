Public Class Regis_empre_part_2
    Dim nacionalidad, sexo As String
    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        Me.Close()
        Param_empresa.Show()
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

    Private Sub CargoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargoToolStripMenuItem1.Click
        Me.Close()
        Param_Cargo.Show()
    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadoToolStripMenuItem.Click
        Me.Close()
        Param_Empleado.Show()
    End Sub

    Private Sub cb_nacio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_nacio.SelectedIndexChanged
        If cb_nacio.Text = "V-" Then
            nacionalidad = "V-"
        ElseIf cb_nacio.Text = "E-" Then
            nacionalidad = "E-"
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Sexo.SelectedIndexChanged
        If cb_Sexo.Text = "Masculino" Then
            sexo = "Masculino"
        ElseIf cb_Sexo.Text = "Femenino" Then
            sexo = "Femenino"
        End If
    End Sub
End Class