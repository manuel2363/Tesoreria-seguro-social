<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Param_Cargo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.cb_status = New System.Windows.Forms.ComboBox()
        Me.cb_cargo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Masktxt_ced = New System.Windows.Forms.MaskedTextBox()
        Me.RdoBtn_e = New System.Windows.Forms.RadioButton()
        Me.RdoBtn_v = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ParametrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InscripcionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfiliaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambioDeCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasYReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_clave)
        Me.GroupBox1.Controls.Add(Me.cb_status)
        Me.GroupBox1.Controls.Add(Me.cb_cargo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 231)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Del Cargo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(176, 145)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 32)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Ingrese su clave para " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "validar la actualización" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_clave
        '
        Me.txt_clave.Location = New System.Drawing.Point(208, 192)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(119, 20)
        Me.txt_clave.TabIndex = 7
        Me.txt_clave.UseSystemPasswordChar = True
        '
        'cb_status
        '
        Me.cb_status.FormattingEnabled = True
        Me.cb_status.Location = New System.Drawing.Point(337, 72)
        Me.cb_status.Name = "cb_status"
        Me.cb_status.Size = New System.Drawing.Size(119, 21)
        Me.cb_status.TabIndex = 6
        '
        'cb_cargo
        '
        Me.cb_cargo.FormattingEnabled = True
        Me.cb_cargo.Location = New System.Drawing.Point(337, 38)
        Me.cb_cargo.Name = "cb_cargo"
        Me.cb_cargo.Size = New System.Drawing.Size(119, 21)
        Me.cb_cargo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(164, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Clave:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(293, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Status:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(293, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cargo:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Masktxt_ced)
        Me.GroupBox2.Controls.Add(Me.RdoBtn_e)
        Me.GroupBox2.Controls.Add(Me.RdoBtn_v)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 112)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Buscar Empleado"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 47)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Introduzca la cédula" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del empleado para " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "iniciar su búsqueda"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Masktxt_ced
        '
        Me.Masktxt_ced.Location = New System.Drawing.Point(157, 43)
        Me.Masktxt_ced.Mask = "000000000"
        Me.Masktxt_ced.Name = "Masktxt_ced"
        Me.Masktxt_ced.Size = New System.Drawing.Size(70, 20)
        Me.Masktxt_ced.TabIndex = 2
        '
        'RdoBtn_e
        '
        Me.RdoBtn_e.AutoSize = True
        Me.RdoBtn_e.Location = New System.Drawing.Point(195, 20)
        Me.RdoBtn_e.Name = "RdoBtn_e"
        Me.RdoBtn_e.Size = New System.Drawing.Size(32, 17)
        Me.RdoBtn_e.TabIndex = 1
        Me.RdoBtn_e.TabStop = True
        Me.RdoBtn_e.Text = "E"
        Me.RdoBtn_e.UseVisualStyleBackColor = True
        '
        'RdoBtn_v
        '
        Me.RdoBtn_v.AutoSize = True
        Me.RdoBtn_v.Location = New System.Drawing.Point(157, 20)
        Me.RdoBtn_v.Name = "RdoBtn_v"
        Me.RdoBtn_v.Size = New System.Drawing.Size(32, 17)
        Me.RdoBtn_v.TabIndex = 0
        Me.RdoBtn_v.TabStop = True
        Me.RdoBtn_v.Text = "V"
        Me.RdoBtn_v.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParametrosToolStripMenuItem, Me.InscripcionToolStripMenuItem, Me.AfiliaciónToolStripMenuItem, Me.SeguridadToolStripMenuItem, Me.ConsultasYReportesToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(509, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ParametrosToolStripMenuItem
        '
        Me.ParametrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpresaToolStripMenuItem, Me.CargoToolStripMenuItem1, Me.EmpleadoToolStripMenuItem})
        Me.ParametrosToolStripMenuItem.Name = "ParametrosToolStripMenuItem"
        Me.ParametrosToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ParametrosToolStripMenuItem.Text = "Parametrización"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.EmpresaToolStripMenuItem.Text = "&Empresa"
        '
        'CargoToolStripMenuItem1
        '
        Me.CargoToolStripMenuItem1.Name = "CargoToolStripMenuItem1"
        Me.CargoToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.CargoToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
        Me.CargoToolStripMenuItem1.Text = "C&argo"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.EmpleadoToolStripMenuItem.Text = "E&mpleado"
        '
        'InscripcionToolStripMenuItem
        '
        Me.InscripcionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.InscripcionToolStripMenuItem.Name = "InscripcionToolStripMenuItem"
        Me.InscripcionToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.InscripcionToolStripMenuItem.Text = "Registro"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.AgregarToolStripMenuItem.Text = "Incorporar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'AfiliaciónToolStripMenuItem
        '
        Me.AfiliaciónToolStripMenuItem.Name = "AfiliaciónToolStripMenuItem"
        Me.AfiliaciónToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.AfiliaciónToolStripMenuItem.Text = "Afiliación"
        '
        'SeguridadToolStripMenuItem
        '
        Me.SeguridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoUsuarioToolStripMenuItem, Me.CambioDeCToolStripMenuItem})
        Me.SeguridadToolStripMenuItem.Name = "SeguridadToolStripMenuItem"
        Me.SeguridadToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.SeguridadToolStripMenuItem.Text = "Seguridad"
        '
        'NuevoUsuarioToolStripMenuItem
        '
        Me.NuevoUsuarioToolStripMenuItem.Name = "NuevoUsuarioToolStripMenuItem"
        Me.NuevoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.NuevoUsuarioToolStripMenuItem.Text = "Nuevo usuario"
        '
        'CambioDeCToolStripMenuItem
        '
        Me.CambioDeCToolStripMenuItem.Name = "CambioDeCToolStripMenuItem"
        Me.CambioDeCToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.CambioDeCToolStripMenuItem.Text = "Cambio de contraseña"
        '
        'ConsultasYReportesToolStripMenuItem
        '
        Me.ConsultasYReportesToolStripMenuItem.Name = "ConsultasYReportesToolStripMenuItem"
        Me.ConsultasYReportesToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.ConsultasYReportesToolStripMenuItem.Text = "Consultas y Reportes"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSessionToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CerrarSessionToolStripMenuItem
        '
        Me.CerrarSessionToolStripMenuItem.Name = "CerrarSessionToolStripMenuItem"
        Me.CerrarSessionToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.CerrarSessionToolStripMenuItem.Text = "Cerrar sesión"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(422, 301)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 301)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Atras"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Param_Cargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 333)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Param_Cargo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Masktxt_ced As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RdoBtn_e As System.Windows.Forms.RadioButton
    Friend WithEvents RdoBtn_v As System.Windows.Forms.RadioButton
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents cb_status As System.Windows.Forms.ComboBox
    Friend WithEvents cb_cargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ParametrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InscripcionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AfiliaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambioDeCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasYReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
