<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Param_empresa
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.MaskTlf = New System.Windows.Forms.MaskedTextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtRif = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(325, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 45)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Por favor introduzca RIF " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de la empresa para iniciar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "su búsqueda"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.MaskTlf)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.txtRif)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(511, 275)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Empresa"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(365, 41)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(88, 43)
        Me.btnBuscar.TabIndex = 14
        Me.btnBuscar.Text = "Buscar Empresa"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'MaskTlf
        '
        Me.MaskTlf.Location = New System.Drawing.Point(70, 232)
        Me.MaskTlf.Mask = "0000-000-0000"
        Me.MaskTlf.Name = "MaskTlf"
        Me.MaskTlf.Size = New System.Drawing.Size(86, 20)
        Me.MaskTlf.TabIndex = 13
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(71, 146)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(258, 72)
        Me.txtDireccion.TabIndex = 11
        '
        'txtRif
        '
        Me.txtRif.Location = New System.Drawing.Point(45, 100)
        Me.txtRif.Name = "txtRif"
        Me.txtRif.Size = New System.Drawing.Size(143, 20)
        Me.txtRif.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(65, 43)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(231, 20)
        Me.txtNombre.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 235)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Teléfono:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Direccón:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "RIF:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nombre:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParametrosToolStripMenuItem, Me.InscripcionToolStripMenuItem, Me.AfiliaciónToolStripMenuItem, Me.SeguridadToolStripMenuItem, Me.ConsultasYReportesToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(538, 24)
        Me.MenuStrip1.TabIndex = 6
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
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        Me.CerrarSessionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CerrarSessionToolStripMenuItem.Text = "Cerrar sesión"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(451, 345)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 7
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(451, 345)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(12, 345)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 23)
        Me.btnAtras.TabIndex = 9
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'Param_empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 376)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Param_empresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresa"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRif As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents MaskTlf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
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
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
End Class
