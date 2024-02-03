Imports MySql.Data.MySqlClient
Public Class mantencion
    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para buscar todo de la tabla mantenciones con estado activo
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM mantenciones WHERE estado='ACTIVO' ", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Sub listar_loc()
        'funcion para buscar localizacion y convertir en calle y punto
        Dim consulta As String
        Dim adaptador As MySqlDataAdapter
        Dim lista As Byte

        consulta = "SELECT ncalle, npunto FROM localizacion INNER JOIN calles ON calles.id_calles = localizacion.id_calles INNER JOIN puntos ON puntos.id_punto = localizacion.id_puntos WHERE id_loc ='" & mod_mantencion.ver_loc & "'"


        adaptador = New MySqlDataAdapter(consulta, nue_conexion.conex)
        nue_var.ds = New DataSet
        adaptador.Fill(nue_var.ds, "localizacion")
        lista = nue_var.ds.Tables("localizacion").Rows.Count

        If lista <> 0 Then

            mod_mantencion.var_calle = nue_var.ds.Tables("localizacion").Rows(0).Item("ncalle")
            mod_mantencion.var_punto = nue_var.ds.Tables("localizacion").Rows(0).Item("npunto")

        Else
            MsgBox("No se han encontrado datos listar loc")

        End If
    End Sub
    Public Sub listar_idloc()
        'funcion para convertir la calle y el punto en una id de localizacion
        Dim consulta As String
        Dim adaptador As MySqlDataAdapter
        Dim lista As Byte

        consulta = "SELECT id_loc FROM localizacion INNER JOIN calles ON calles.id_calles = localizacion.id_calles INNER JOIN puntos ON puntos.id_punto = localizacion.id_puntos WHERE ncalle ='" & mod_mantencion.var_concalle & "' AND npunto ='" & mod_mantencion.var_conpunto & "'"


        adaptador = New MySqlDataAdapter(consulta, nue_conexion.conex)
        nue_var.ds = New DataSet
        adaptador.Fill(nue_var.ds, "localizacion")
        lista = nue_var.ds.Tables("localizacion").Rows.Count

        If lista <> 0 Then

            mod_mantencion.var_conloc = nue_var.ds.Tables("localizacion").Rows(0).Item("id_loc")


        Else
            MsgBox("No se han encontrado datos idloc")

        End If
    End Sub

    Public Sub nuevo()
        'procedimiento para ingresar un nuevo registro de mantenciones
      
        nue_var.consulta = "INSERT INTO mantenciones (id_man, id_localiz, obs, fecha_inicio, fecha_termino, nombre_mante, turno, grupo, estado) VALUES('', ?id_localiz,'REALIZAR MANTENCIÓN PROGRAMADA', ?fecha_inicio, ?fecha_termino, ?nombre_mante, ?turno, ?grupo,'ACTIVO')"

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?id_localiz", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = mod_mantencion.var_conloc.ToString
            nue_var.cmd.Parameters.Add("?fecha_inicio", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = frm_mantenciones.dtp_fechaini.Value
            nue_var.cmd.Parameters.Add("?fecha_termino", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = frm_mantenciones.dtp_fechater.Value
            nue_var.cmd.Parameters.Add("?nombre_mante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = frm_mantenciones.lbl_nomm.Text
            nue_var.cmd.Parameters.Add("?turno", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = frm_mantenciones.txt_turnom.Text
            nue_var.cmd.Parameters.Add("?grupo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = frm_mantenciones.txt_grupom.Text

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub modificar()
        'procedimiento para modificar las mantenciones
        'mantenciones  id_man 	id_localiz 	obs 	fecha_inicio 	fecha_termino 	nombre_mante 	turno 	grupo 	estado


        nue_var.consulta = "UPDATE mantenciones SET id_localiz = ?id_localiz, fecha_inicio = ?fecha_inicio, fecha_termino = ?fecha_termino ,nombre_mante = ?nombre_mante, turno = ?turno, grupo = ?grupo, estado = ?estado WHERE id_man = " & mod_mantencion.var_id_man

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?id_localiz", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = mod_mantencion.var_conloc.ToString
            nue_var.cmd.Parameters.Add("?fecha_inicio", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = frm_mantenciones.dtp_fechaini.Value
            nue_var.cmd.Parameters.Add("?fecha_termino", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = frm_mantenciones.dtp_fechater.Value
            nue_var.cmd.Parameters.Add("?nombre_mante", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = frm_mantenciones.lbl_nomm.Text
            nue_var.cmd.Parameters.Add("?turno", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = frm_mantenciones.txt_turnom.Text
            nue_var.cmd.Parameters.Add("?grupo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = frm_mantenciones.txt_grupom.Text
            nue_var.cmd.Parameters.Add("?estado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = frm_mantenciones.cb_estadom.Text
            'cb_estadom
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub modificarestado()
        'procedimiento para modificar las mantenciones



        nue_var.consulta = "UPDATE mantenciones SET obs = ?obs, estado = ?estado WHERE id_man =" & mod_mantencion.var_idmanre

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())


            nue_var.cmd.Parameters.Add("?obs", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = frm_manrealizada.txt_fcomenta.Text
            nue_var.cmd.Parameters.Add("?estado", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = frm_manrealizada.lbl_fnestado.Text

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub listartodo()
        'funcion para buscar la mantencion al dia de hoy
        'mantenciones  id_man 	id_localiz 	obs 	fecha_inicio 	fecha_termino 	nombre_mante 	turno 	grupo 	estado
        Dim consulta As String
        Dim adaptador As MySqlDataAdapter
        Dim lista As Byte

        consulta = "SELECT id_man, id_localiz, fecha_inicio, fecha_termino FROM mantenciones WHERE fecha_inicio='" & mod_mantencion.var_confecha & "' AND estado='ACTIVO'"


        adaptador = New MySqlDataAdapter(consulta, nue_conexion.conex)
        nue_var.ds = New DataSet
        adaptador.Fill(nue_var.ds, "mantenciones")
        lista = nue_var.ds.Tables("mantenciones").Rows.Count

        If lista <> 0 Then
            mod_mantencion.var_fini = nue_var.ds.Tables("mantenciones").Rows(0).Item("fecha_inicio")
            mod_mantencion.var_fter = nue_var.ds.Tables("mantenciones").Rows(0).Item("fecha_termino")
            mod_mantencion.ver_loc = nue_var.ds.Tables("mantenciones").Rows(0).Item("id_localiz")
            mod_mantencion.var_idmanre = nue_var.ds.Tables("mantenciones").Rows(0).Item("id_man")

        Else
            MsgBox("NO HAY MANTENCIÓN POR RELIZAR")
        End If
    End Sub
End Class
