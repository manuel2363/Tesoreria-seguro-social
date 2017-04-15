Public Class A_afili_Lote

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        A_afilia_tipos.Show()
    End Sub

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

    Private Sub A_afili_Lote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        'If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
        'TextBox1.Text = FolderBrowserDialog1.SelectedPath
        'End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
        '   TextBox1.Text = OpenFileDialog1.SafeFileName
        'End If

        'If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
        ' TextBox1.Text = FolderBrowserDialog1.SelectedPath
        'End If

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim sr As New System.IO.StreamReader(OpenFileDialog1.FileName)
            'MessageBox.Show(sr.ReadToEnd)
            sr.Close()
        End If

        'Dim openFileDialog1 As New OpenFileDialog()
        'If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '' Assign the cursor in the Stream to the Form's Cursor property.
        'Me.Cursor = New Cursor(OpenFileDialog1.OpenFile())
        'End If

        'Imports System.IO
        '' Call ShowDialog.
        'Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        '
        '' Test result.
        'If result = Windows.Forms.DialogResult.OK Then
        '
        '' Get the file name.
        'Dim path As String = OpenFileDialog1.FileName
        'Try
        '' Read in text.
        'Dim text As String = File.ReadAllText(path)
        '
        '' For debugging.
        'Me.Text = text.Length.ToString
        '
        'Catch ex As Exception

        '' Report an error.
        'Me.Text = "Error"
        '
        '   End Try
        'End If
    End Sub
End Class