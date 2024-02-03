Imports MySql.Data.MySqlClient
Public Class tareasex
    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar las tareas externas a las calles y puntos de vaciado
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM hisexternas", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Sub nuevoinex(ByVal var_fecha As DateTime, ByVal tipo_pro As String, ByVal var_grupo As Integer, ByVal var_turno As String, ByVal var_com As String, ByVal var_use As Integer)
        'procedimiento para ingresar un nuevo registro al historial de tareas externas
        var_grupo = frm_tareasex.txt_grupoex.Text
        var_turno = frm_tareasex.txt_turnoex.Text
        tipo_pro = frm_tareasex.var_tarea.ToString
        var_com = frm_tareasex.txt_comentarioex.Text

        var_use = mod_usuario.id_usuario.ToString
        var_fecha = mod_maestra.fecha.ToString
        nue_var.consulta = "INSERT INTO hisexternas (id_hisex, id_user, turno, grupo, fecha, tipo_pro, comen) VALUES('', ?var_use, ?var_turno, ?var_grupo, ?var_fecha, ?tipo_pro, ?var_com)"
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())

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
    Public Sub modificar(ByVal turno As String, ByVal grupo As String, ByVal fecha As DateTime, ByVal tipo_pro As String, ByVal comentario As String)
        'procedimiento para modificar el historial


        grupo = frm_histareasex.txt_grupoex.Text
        turno = frm_histareasex.txt_turnoex.Text
        tipo_pro = frm_histareasex.txt_problemaex.Text()
        comentario = frm_histareasex.txt_comentarioex.Text
        fecha = frm_histareasex.dtp_fechaex.Value
        'id_hisex 	id_user 	turno 	grupo 	fecha 	tipo_pro 	comen 
        nue_var.consulta = "UPDATE hisexternas SET turno=?turno, grupo=?grupo, fecha=?fecha, tipo_pro=?tipo_pro, comen=?comentario WHERE id_hisex =" & frm_histareasex.var_idex

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
End Class
