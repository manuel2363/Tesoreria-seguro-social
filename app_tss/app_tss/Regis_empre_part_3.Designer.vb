<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Regis_empre_part_3
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_Sexo = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MaskTlfMovil = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MaskTlfHab = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Date_f_nacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.cb_nacio = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ParametrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InscripcionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfiliaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambioDeCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasYReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 358)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Atras"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(425, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_Sexo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.MaskTlfMovil)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.MaskTlfHab)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Date_f_nacimiento)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.cb_nacio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtsApellido)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtpApellido)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtsNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtpNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 305)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información persona de contacto"
        '
        'cb_Sexo
        '
        Me.cb_Sexo.FormattingEnabled = True
        Me.cb_Sexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cb_Sexo.Location = New System.Drawing.Point(308, 99)
        Me.cb_Sexo.Name = "cb_Sexo"
        Me.cb_Sexo.Size = New System.Drawing.Size(100, 21)
        Me.cb_Sexo.TabIndex = 50
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(268, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Sexo:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(118, 264)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(159, 20)
        Me.txtCorreo.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Correo Electronico:"
        '
        'MaskTlfMovil
        '
        Me.MaskTlfMovil.Location = New System.Drawing.Point(354, 225)
        Me.MaskTlfMovil.Mask = "0000-000-0000"
        Me.MaskTlfMovil.Name = "MaskTlfMovil"
        Me.MaskTlfMovil.Size = New System.Drawing.Size(85, 20)
        Me.MaskTlfMovil.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(268, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Teléfono Movil:"
        '
        'MaskTlfHab
        '
        Me.MaskTlfHab.Location = New System.Drawing.Point(98, 225)
        Me.MaskTlfHab.Mask = "0000-000-0000"
        Me.MaskTlfHab.Name = "MaskTlfHab"
        Me.MaskTlfHab.Size = New System.Drawing.Size(83, 20)
        Me.MaskTlfHab.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Teléfono Hab.:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(75, 163)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(388, 46)
        Me.txtDireccion.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Dirección:"
        '
        'Date_f_nacimiento
        '
        Me.Date_f_nacimiento.Location = New System.Drawing.Point(128, 131)
        Me.Date_f_nacimiento.Name = "Date_f_nacimiento"
        Me.Date_f_nacimiento.Size = New System.Drawing.Size(200, 20)
        Me.Date_f_nacimiento.TabIndex = 38
        Me.Date_f_nacimiento.Value = New Date(2015, 5, 27, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Fecha de Nacimiento"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(114, 99)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(86, 20)
        Me.txtCedula.TabIndex = 36
        '
        'cb_nacio
        '
        Me.cb_nacio.FormattingEnabled = True
        Me.cb_nacio.Items.AddRange(New Object() {"V-", "E-"})
        Me.cb_nacio.Location = New System.Drawing.Point(64, 99)
        Me.cb_nacio.Name = "cb_nacio"
        Me.cb_nacio.Size = New System.Drawing.Size(44, 21)
        Me.cb_nacio.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Cedula:"
        '
        'txtsApellido
        '
        Me.txtsApellido.Location = New System.Drawing.Point(367, 64)
        Me.txtsApellido.Name = "txtsApellido"
        Me.txtsApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtsApellido.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(268, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Segundo Apellido:"
        '
        'txtpApellido
        '
        Me.txtpApellido.Location = New System.Drawing.Point(100, 64)
        Me.txtpApellido.Name = "txtpApellido"
        Me.txtpApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtpApellido.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Primer Apellido:"
        '
        'txtsNombre
        '
        Me.txtsNombre.Location = New System.Drawing.Point(367, 30)
        Me.txtsNombre.Name = "txtsNombre"
        Me.txtsNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtsNombre.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(268, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Segundo Nombre:"
        '
        'txtpNombre
        '
        Me.txtpNombre.Location = New System.Drawing.Point(100, 30)
        Me.txtpNombre.Name = "txtpNombre"
        Me.txtpNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtpNombre.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Primer Nombre:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParametrosToolStripMenuItem, Me.InscripcionToolStripMenuItem, Me.AfiliaciónToolStripMenuItem, Me.SeguridadToolStripMenuItem, Me.ConsultasYReportesToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(512, 24)
        Me.MenuStrip1.TabIndex = 9
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
        Me.InscripcionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem})
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
        'Regis_empre_part_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 390)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "Regis_empre_part_3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información de Contacto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents MaskTlfMovil As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MaskTlfHab As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Date_f_nacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents cb_nacio As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtpApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtsNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ParametrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InscripcionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AfiliaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambioDeCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasYReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cb_Sexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
