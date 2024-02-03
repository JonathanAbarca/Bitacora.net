Imports MySql.Data.MySqlClient
Public Class usuario
    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    'funcion que verifica si un usuario existe
    Public Function verificar(ByVal pass As String, ByVal usuario As String) As Boolean
        nue_var.consulta = "SELECT * FROM usuarios WHERE pass= ?pass AND user=user"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?pass", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pass
        nue_var.cmd.Parameters.Add("?user", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            verificar = True
        Else
            verificar = False
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return verificar
    End Function

    'funcion que retorna el codigo usuario
    'id_usuario 	nombre 	apellido 	cargo 	grupo 	user 	pass 
    Public Function contraseña_u(ByVal pass As String, ByVal usuario As String) As String
        nue_var.consulta = "SELECT * FROM usuarios WHERE pass= ?pass AND user=user"
        nue_conexion.conectar()
        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
        nue_var.cmd.Parameters.Add("?pass", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pass
        nue_var.cmd.Parameters.Add("?user", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = usuario
        nue_var.dr = nue_var.cmd.ExecuteReader()
        If nue_var.dr.Read Then
            contraseña_u = nue_var.dr("pass")
        End If
        nue_var.dr.Close()
        nue_conexion.desconectar()
        Return contraseña_u
    End Function

    Public Sub listar_usuario()
        'listar los datos de usuario(jefe cuadrilla)
        Dim consulta As String
        Dim adaptador As MySqlDataAdapter
        Dim lista As Byte

        consulta = "SELECT * FROM usuarios WHERE pass ='" & frm_login.txt_contraseña.Text & "'"

        adaptador = New MySqlDataAdapter(consulta, nue_conexion.conex)
        nue_var.ds = New DataSet
        adaptador.Fill(nue_var.ds, "usuarios")
        lista = nue_var.ds.Tables("usuarios").Rows.Count

        If lista <> 0 Then
            mod_usuario.id_usuario = nue_var.ds.Tables("usuarios").Rows(0).Item("id_usuario")
            mod_usuario.nom_usu = nue_var.ds.Tables("usuarios").Rows(0).Item("nombre")
            mod_usuario.ape_usu = nue_var.ds.Tables("usuarios").Rows(0).Item("apellido")
            mod_usuario.cargo_usu = nue_var.ds.Tables("usuarios").Rows(0).Item("cargo")
            mod_usuario.pass = nue_var.ds.Tables("usuarios").Rows(0).Item("pass")
            mod_usuario.user = nue_var.ds.Tables("usuarios").Rows(0).Item("user")
            mod_usuario.grupo_usu = nue_var.ds.Tables("usuarios").Rows(0).Item("grupo")
        Else
            MsgBox("No se han encontrado datos")
        End If
    End Sub

    Public Sub listar_nomape()
        'nue_var.da dataadapter
        'nue_conexion mysqlconection
        'nue:var.ds dataset
        Dim consulta As String
        Dim adaptador As MySqlDataAdapter
        Dim lista As Byte

        consulta = "SELECT NOMBRE, APELLIDO FROM usuarios WHERE id_usuario ='" & frm_histareasex.var_rut & "'"

        adaptador = New MySqlDataAdapter(consulta, nue_conexion.conex)
        nue_var.ds = New DataSet
        adaptador.Fill(nue_var.ds, "usuarios")
        lista = nue_var.ds.Tables("usuarios").Rows.Count

        If lista <> 0 Then

            mod_usuario.nom = nue_var.ds.Tables("usuarios").Rows(0).Item("nombre")
            mod_usuario.ape = nue_var.ds.Tables("usuarios").Rows(0).Item("apellido")
           
        Else
            MsgBox("No se han encontrado datos")

        End If
    End Sub
    'modpass
    Public Sub modpass()
        'id_usuario 	nombre 	apellido 	cargo 	grupo 	user 	pass
        nue_var.consulta = "UPDATE usuarios SET pass = ?pass WHERE id_usuario =" & mod_usuario.id_usuario

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?pass", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = mod_usuario.pass_upd
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub



End Class
