Imports MySql.Data.MySqlClient
Public Class historial


    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar las jornadas
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM historial WHERE id_loc=" & mod_maestra.id_selecion, nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    'id_his 	id_loc 	turno 	grupo 	fecha 	tipo_pro 	comentario 	id_usuario

    Public Sub nuevo(ByVal var_fecha As DateTime, ByVal var_grupo As Integer, ByVal var_turno As String, ByVal var_com As String, ByVal id_locali As Integer, ByVal var_use As Integer)
        'procedimiento para ingresar un nuevo registro al historial al crear un punto de vaciado
        var_grupo = frm_nuevopunto.txt_grupo.Text
        var_turno = frm_nuevopunto.txt_turno.Text
        var_com = frm_nuevopunto.txt_comentario.Text
        id_locali = mod_localizacion.nloc.ToString
        var_use = mod_usuario.id_usuario.ToString
        var_fecha = mod_maestra.fecha.ToString
        Dim var_his As Integer = mod_historial._id_his.ToString

        nue_var.consulta = "INSERT INTO historial (id_his, id_loc, turno, grupo, fecha, tipo_pro, comentario, id_usuario) VALUES(?id_his, ?id_locali, ?var_turno, ?var_grupo, ?var_fecha,'NUEVO INGRESO', ?var_com, ?var_use)"

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?id_his", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = var_his
            nue_var.cmd.Parameters.Add("?id_locali", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_locali
            nue_var.cmd.Parameters.Add("?var_turno", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = var_turno
            nue_var.cmd.Parameters.Add("?var_grupo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = var_grupo
            nue_var.cmd.Parameters.Add("?var_fecha", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = var_fecha
            nue_var.cmd.Parameters.Add("?var_com", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = var_com
            nue_var.cmd.Parameters.Add("?var_use", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = var_use
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub modificar(ByVal id_histo As Integer, ByVal turno As String, ByVal grupo As String, ByVal tipo_pro As String, ByVal comentario As String, ByVal fecha As DateTime)
        'procedimiento para modificarun registro del historial

        id_histo = mod_historial.id_actuhis.ToString
        grupo = frm_historial.txt_cuadrilla.Text
        turno = frm_historial.txt_turno.Text
        tipo_pro = frm_historial.txt_problema.Text
        comentario = frm_historial.txt_detalles.Text
        id_usuario = frm_historial.txt_encargado.Text
        fecha = frm_historial.dtm_fecha.Value

        nue_var.consulta = "UPDATE historial SET turno=?turno, grupo=?grupo, fecha=?fecha, tipo_pro=?tipo_pro, comentario=?comentario WHERE id_his =" & mod_historial.id_actuhis

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?turno", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = turno
            nue_var.cmd.Parameters.Add("?grupo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = grupo
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = fecha
            nue_var.cmd.Parameters.Add("?tipo_pro", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_pro
            nue_var.cmd.Parameters.Add("?comentario", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = comentario
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub nuevoin(ByVal var_fecha As DateTime, ByVal tipo_pro As String, ByVal var_grupo As Integer, ByVal var_turno As String, ByVal var_com As String, ByVal id_locali As Integer, ByVal var_use As Integer)
        'procedimiento para ingresar un nuevo registro al historial
        var_grupo = frm_nuetarea.txt_grupo.Text
        var_turno = frm_nuetarea.txt_turno.Text
        tipo_pro = frm_nuetarea.var_tarea.ToString
        var_com = frm_nuetarea.txt_comentario.Text
        id_locali = mod_maestra.id_selecion.ToString
        var_use = mod_usuario.id_usuario.ToString
        var_fecha = mod_maestra.fecha.ToString

        'id_his 	id_loc 	turno 	grupo 	fecha 	tipo_pro 	comentario 	id_usuario
        nue_var.consulta = "INSERT INTO historial (id_his, id_loc, turno, grupo, fecha, tipo_pro, comentario, id_usuario) VALUES('', ?id_locali, ?var_turno, ?var_grupo, ?var_fecha, ?tipo_pro, ?var_com, ?var_use)"

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?id_locali", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_locali
            nue_var.cmd.Parameters.Add("?var_turno", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = var_turno
            nue_var.cmd.Parameters.Add("?var_grupo", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = var_grupo
            nue_var.cmd.Parameters.Add("?var_fecha", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = var_fecha
            nue_var.cmd.Parameters.Add("?tipo_pro", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tipo_pro
            nue_var.cmd.Parameters.Add("?var_com", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = var_com
            nue_var.cmd.Parameters.Add("?var_use", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = var_use
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
End Class
