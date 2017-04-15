Module conexion
    Public Id_form As String
    Public ConexionPostgres As New Odbc.OdbcConnection("DSN=proyecto")
    Public Tabla, dr As Odbc.OdbcDataReader

    Dim Convertido As String
    'Dim cont As Integer


    Public Sub Cargar_Datos(ByVal sql As String)

        ' si la conexion esta abierta se cierra 
        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open() ' abre la conexión   
        Dim cdo As New Odbc.OdbcCommand(sql, ConexionPostgres)
        cdo.ExecuteNonQuery() 'ejecuta la sentencia sql
        'Tabla = cdo.ExecuteReader()

        'se cierra la conexion    
        ConexionPostgres.Close()
    End Sub
    '------------------------------------------------------------------------------------'

    Public Sub login(ByVal Usu As String, ByVal clave As String)

        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()
        Form1.Hide()
        Menu_Principal.Show()
        
    End Sub

    '------------------------------------------------------------------------------------'

    Public Sub cargo_busqueda(ByVal nacionalidad As String, ByVal cedula As String)

        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()

        'Select view_cargo_select(nacionalidad, cedula)
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        'Dim sql As String
        cmd.CommandText = "Select * from view_cargo_select('" & nacionalidad & "', '" & cedula & "');"

        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then

                Param_Cargo.cb_cargo.Text = dr.Item(1).ToString
                Param_Cargo.cb_status.Text = dr.Item(2).ToString

            Else
                MsgBox("Usuario no existe", MsgBoxStyle.Critical, "Error de datos")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    '------------------------------------------------------------------------------------'

    Public Sub cargo_actualizar(ByVal cargo As String, ByVal estatus As String, ByVal clave As String)

        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()

        'Select view_cargo_select(nacionalidad, cedula)
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        'Dim sql As String

        Try

            'cmd.CommandText = "Update usuario set usuar_permi ='" & Param_Cargo.cb_cargo.Text &
            '                  "', usuar_satus ='" & Param_Cargo.cb_status.Text &
            '                  "' where usuar_clave='" & Param_Cargo.txt_clave.Text & "';"
            cmd.CommandText = "Select * from funcion('" & cargo & "','" & estatus & "','" & clave & "');"

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    '------------------------------------------------------------------------------------'

    Public Sub P_emple_busqueda(ByVal nacionalidad As String, ByVal cedula As String)

        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()

        'Select view_cargo_select(nacionalidad, cedula)
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        'Dim sql As String
        cmd.CommandText = "Select * from view_emple_select('" & nacionalidad & "', '" & cedula & "');"

        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then

                Param_Empleado.txtpNombre.Text = dr.Item(1).ToString()
                Param_Empleado.txtsNombre.Text = dr.Item(2).ToString()
                Param_Empleado.txtpApellido.Text = dr.Item(3).ToString()
                Param_Empleado.txtsApellido.Text = dr.Item(4).ToString()
                Param_Empleado.txtdireccion.Text = dr.Item(5).ToString()
                Param_Empleado.MaskTlfHab.Text = dr.Item(6).ToString()
                Param_Empleado.MaskTlfMovil.Text = dr.Item(7).ToString()
                Param_Empleado.txtCorreo.Text = dr.Item(8).ToString()

            Else
                MsgBox("Usuario no existe", MsgBoxStyle.Critical, "Error de datos")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    '------------------------------------------------------------------------------------'

    Public Sub P_emple_actualizar(ByVal pnombre As String,
                                  ByVal snombre As String,
                                  ByVal papellido As String,
                                  ByVal sapellido As String,
                                  ByVal direc As String,
                                  ByVal telef1 As String,
                                  ByVal telef2 As String,
                                  ByVal correo As String)

        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()

        'Select view_cargo_select(nacionalidad, cedula)
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        'Dim sql As String

        Try

            'cmd.CommandText = "Update usuario set usuar_permi ='" & Param_Cargo.cb_cargo.Text &
            '                  "', usuar_satus ='" & Param_Cargo.cb_status.Text &
            '                  "' where usuar_clave='" & Param_Cargo.txt_clave.Text & "';"
            cmd.CommandText = "Select * from funcion('" & pnombre &
                                                     "','" & snombre &
                                                     "','" & papellido &
                                                     "','" & sapellido &
                                                     "','" & direc &
                                                     "','" & telef1 &
                                                     "','" & telef2 &
                                                     "','" & correo & "');"

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    '------------------------------------------------------------------------------------'

    Public Sub P_empre_busqueda(ByVal rif As String)

        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()

        'Select view_cargo_select(nacionalidad, cedula)
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        'Dim sql As String
        cmd.CommandText = "Select * from view_empre_select('" & rif & "');"

        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then

                Param_empresa.txtNombre.Text = dr.Item(1).ToString()
                Param_empresa.txtRif.Text = dr.Item(2).ToString()
                Param_empresa.txtDireccion.Text = dr.Item(3).ToString()
                Param_empresa.MaskTlf.Text = dr.Item(4).ToString()
            Else
                MsgBox("Usuario no existe", MsgBoxStyle.Critical, "Error de datos")
                Param_empresa.btnAgregar.Visible = True
                Param_empresa.btnActualizar.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    '------------------------------------------------------------------------------------'

    Public Sub P_empre_agregar(ByVal nombre As String,
                               ByVal rif As String,
                               ByVal direccion As String,
                               ByVal tlf As String)

        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()

        'Select view_cargo_select(nacionalidad, cedula)
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        'Dim sql As String

        Try
            cmd.CommandText = "Select * from f_empre_insert('" & nombre & "','" & rif & "','" & direccion & "','" & tlf & "');"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    '------------------------------------------------------------------------------------'

    Public Sub P_empre_actualizar(ByVal nombre As String,
                                  ByVal rif As String,
                                  ByVal direccion As String,
                                  ByVal tlf As String)

        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()

        'Select view_cargo_select(nacionalidad, cedula)
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        'Dim sql As String

        Try
            cmd.CommandText = "Select * from f_empre_update('" & nombre & "','" & rif & "','" & direccion & "','" & tlf & "');"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Perdida_Correo(ByVal Usu As String, ByVal Correo As String)

        Dim clave, asunto, usuario As String
        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()

        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        'Dim sql As String
        cmd.CommandText = "Select * from usuario where usuar_log='" + Usu + "' and usuar_ccorr='" + Correo + "'; "
        'MsgBox(sql)
        'cmd.CommandType = sql
        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                usuario = dr.Item(0)
                clave = dr.Item(2)
                asunto = "Recuperacion de clave"
                Dim _Message As New System.Net.Mail.MailMessage()
                Dim _SMTP As New System.Net.Mail.SmtpClient

                'CONFIGURACIÓN DEL STMP
                '_SMTP.Credentials = New System.Net.NetworkCredential("cuenta de correo", "contraseña")
                _SMTP.Credentials = New System.Net.NetworkCredential("GuarderiaDulceAmor@gmail.com", "Guarderia")
                _SMTP.Host = "smtp.gmail.com"
                _SMTP.Port = 587
                _SMTP.EnableSsl = True

                ' CONFIGURACION DEL MENSAJE
                _Message.[To].Add(Recup_Clave.txtCorreo.Text.ToString) 'Cuenta de Correo al que se le quiere enviar el e-mail
                _Message.From = New System.Net.Mail.MailAddress("GuarderiaDulceAmor@gmail.com", "Guarderia Dulce Amor", System.Text.Encoding.UTF8) 'Quien lo envía
                _Message.Subject = asunto.ToString 'Sujeto del e-mail
                _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
                _Message.Body = ("Usuario: " + usuario.ToString + vbCr + "Clave: " + clave.ToString) 'contenido del mail
                ''_Message.Body = Me.txtMensaje.Text.ToString 'contenido del mail
                _Message.BodyEncoding = System.Text.Encoding.UTF8
                _Message.Priority = System.Net.Mail.MailPriority.Normal
                _Message.IsBodyHtml = False

                'ENVIO
                Try
                    _SMTP.Send(_Message)
                    MessageBox.Show("Mensaje enviado correctamene", "Exito!", MessageBoxButtons.OK)
                    Form1.Show()
                    Recup_Clave.Close()
                Catch ex As System.Net.Mail.SmtpException
                    MessageBox.Show(ex.ToString, "Error!", MessageBoxButtons.OK)
                End Try

            Else
                MsgBox("Usuario o correo incorrecto.", MsgBoxStyle.Critical, "¡Error de datos!")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        ConexionPostgres.Close()

    End Sub

End Module
