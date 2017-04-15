<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbLogin = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.lbClave = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnIngre = New System.Windows.Forms.Button()
        Me.BtnClean = New System.Windows.Forms.Button()
        Me.BtnConex = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbLogin
        '
        Me.lbLogin.AutoSize = True
        Me.lbLogin.ForeColor = System.Drawing.Color.Black
        Me.lbLogin.Location = New System.Drawing.Point(39, 97)
        Me.lbLogin.Name = "lbLogin"
        Me.lbLogin.Size = New System.Drawing.Size(46, 13)
        Me.lbLogin.TabIndex = 0
        Me.lbLogin.Text = "Usuario:"
        '
        'txtLogin
        '
        Me.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLogin.Location = New System.Drawing.Point(91, 95)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(121, 20)
        Me.txtLogin.TabIndex = 1
        Me.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLogin.UseSystemPasswordChar = True
        '
        'lbClave
        '
        Me.lbClave.AutoSize = True
        Me.lbClave.Location = New System.Drawing.Point(39, 124)
        Me.lbClave.Name = "lbClave"
        Me.lbClave.Size = New System.Drawing.Size(37, 13)
        Me.lbClave.TabIndex = 2
        Me.lbClave.Text = "Clave:"
        '
        'txtClave
        '
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClave.Location = New System.Drawing.Point(91, 121)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(121, 20)
        Me.txtClave.TabIndex = 3
        Me.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtClave.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(265, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(334, 298)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'BtnIngre
        '
        Me.BtnIngre.Location = New System.Drawing.Point(42, 181)
        Me.BtnIngre.Name = "BtnIngre"
        Me.BtnIngre.Size = New System.Drawing.Size(75, 23)
        Me.BtnIngre.TabIndex = 5
        Me.BtnIngre.Text = "Ingresar"
        Me.BtnIngre.UseVisualStyleBackColor = True
        '
        'BtnClean
        '
        Me.BtnClean.Location = New System.Drawing.Point(137, 181)
        Me.BtnClean.Name = "BtnClean"
        Me.BtnClean.Size = New System.Drawing.Size(75, 23)
        Me.BtnClean.TabIndex = 6
        Me.BtnClean.Text = "Limpiar"
        Me.BtnClean.UseVisualStyleBackColor = True
        '
        'BtnConex
        '
        Me.BtnConex.Location = New System.Drawing.Point(42, 287)
        Me.BtnConex.Name = "BtnConex"
        Me.BtnConex.Size = New System.Drawing.Size(170, 23)
        Me.BtnConex.TabIndex = 7
        Me.BtnConex.Text = "Conexión"
        Me.BtnConex.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(71, 239)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(113, 13)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Recuperar contraseña"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 333)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.BtnConex)
        Me.Controls.Add(Me.BtnClean)
        Me.Controls.Add(Me.BtnIngre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.lbClave)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.lbLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tss Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbLogin As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents lbClave As System.Windows.Forms.Label
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnIngre As System.Windows.Forms.Button
    Friend WithEvents BtnClean As System.Windows.Forms.Button
    Friend WithEvents BtnConex As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
