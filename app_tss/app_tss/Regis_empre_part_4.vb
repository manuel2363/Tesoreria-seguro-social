Public Class Regis_empre_part_4

    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        Me.Close()
        Param_empresa.Show()
    End Sub

    Private Sub CargoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargoToolStripMenuItem1.Click
        Me.Close()
        Param_Cargo.Show()
    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadoToolStripMenuItem.Click
        Me.Close()
        Param_Empleado.Show()
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Regis_empre_part_3.Show()
    End Sub
End Class