Public Class Param_Cargo
    Dim nacionalidad, cedula, cargo, estatus, clave As String
    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        Me.Close()
        Param_empresa.Show()
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Menu_Principal.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        Try
            If RdoBtn_e.Enabled = False And RdoBtn_v.Enabled = False Then
                MsgBox("Por favor ingresar nacionalidad")
            ElseIf Masktxt_ced.Text = "" Then
                MsgBox("Ingrese el número de cedula")
            Else
                cedula = Masktxt_ced.Text
                cargo_busqueda(nacionalidad, cedula)
            End If

        Catch ex As Exception

            MessageBox.Show("Error : " + ex.Message + "", "¡Ocurrio el siguiente Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub RdoBtn_v_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoBtn_v.CheckedChanged
        If RdoBtn_v.Checked = True Then
            nacionalidad = "V-"
        ElseIf RdoBtn_e.Checked = True Then
            nacionalidad = "E-"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            If cb_cargo.Text = "" And cb_status.Text = "" And txt_clave.Text = "" Then
                MsgBox("Por favor ingrese datos en todos los campos", MsgBoxStyle.ApplicationModal, "Información")
            ElseIf cb_cargo.Text <> "" And cb_status.Text = "" And txt_clave.Text = "" Then
                MsgBox("Por favor ingrese el estatus y la clave", MsgBoxStyle.ApplicationModal, "Información")
            ElseIf cb_cargo.Text = "" And cb_status.Text <> "" And txt_clave.Text = "" Then
                MsgBox("Por favor ingrese el cargo y la clave", MsgBoxStyle.ApplicationModal, "Información")
            ElseIf cb_cargo.Text = "" And cb_status.Text = "" And txt_clave.Text <> "" Then
                MsgBox("Por favor ingrese el cargo y el estatus", MsgBoxStyle.ApplicationModal, "Información")
            Else

                cargo = cb_cargo.Text
                estatus = cb_status.Text
                clave = txt_clave.Text
                cargo_actualizar(cargo, estatus, clave)

                MessageBox.Show("Cambio exitoso", "¡Cambio exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception

            MessageBox.Show("Error : " + ex.Message + "", "¡Ocurrio el siguiente Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Param_Cargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        llenarcombo()
    End Sub

    Public Sub llenarcombo()
        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()
        Me.cb_cargo.Items.Clear()
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select cargo_nombr from cargo;"

        dr = cmd.ExecuteReader

        If dr.HasRows = True Then
            While dr.Read()
                Me.cb_cargo.Items.Add(dr.GetValue(0))
            End While
        End If
        dr.Close()
    End Sub

End Class