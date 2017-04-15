Public Class Param_empresa
    Dim nombre, rif, direccion, tlf As String
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        Me.Close()
        Menu_Principal.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If txtRif.Text = "" Then
                MsgBox("Por favor ingresar Rif")
            Else
                P_empre_busqueda(rif)
            End If

        Catch ex As Exception

            MessageBox.Show("Error : " + ex.Message + "", "¡Ocurrio el siguiente Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Param_empresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnAgregar.Visible = False
        Me.btnActualizar.Visible = True
        rif = txtRif.Text
        nombre = txtNombre.Text
        direccion = txtDireccion.Text
        tlf = MaskTlf.Text
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            If txtRif.Text = "" Then
                MsgBox("Por favor ingresar Rif")
            Else
                P_empre_agregar(nombre, rif, direccion, tlf)
            End If

        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message + "", "¡Ocurrio el siguiente Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            If txtRif.Text = "" Then
                MsgBox("Por favor ingresar Rif")
            Else
                P_empre_actualizar(nombre, rif, direccion, tlf)
            End If

        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message + "", "¡Ocurrio el siguiente Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class