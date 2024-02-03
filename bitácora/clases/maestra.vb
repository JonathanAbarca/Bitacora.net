Imports MySql.Data.MySqlClient
Public Class maestra

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar todo los datos de la tabla maestra
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM maestra INNER JOIN localizacion ON localizacion.id_loc = maestra.id_loc INNER JOIN alumbrado ON alumbrado.id_alum = maestra.id_alum INNER JOIN caja ON caja.id_local = maestra.id_caja INNER JOIN gabinete ON gabinete.id_gabinete = maestra.id_gabex INNER JOIN componentes ON componentes.id_componentes = maestra.id_componentes WHERE maestra.id_loc =" & mod_maestra.id_selecion, nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Sub modificarfecha(ByVal fecha As DateTime)

        fecha = mod_maestra.fecha.ToString

        nue_var.consulta = "UPDATE maestra SET fecha_mod = ?fecha WHERE id_alum =" & mod_maestra.id_maestra

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = fecha
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Sub nuevo(ByVal id_enlaces As Integer, ByVal id_loc As Integer, ByVal id_alum As Integer, ByVal id_caja As Integer, ByVal id_gabex As Integer, ByVal id_componentes As Integer, ByVal fecha As DateTime)
        id_enlaces = mod_maestra._id_selecion
        id_loc = mod_localizacion.nloc
        id_alum = mod_alumbrado._id_alum
        id_caja = mod_caja._id_caja
        id_gabex = mod_gabinete._id_gab
        id_componentes = mod_componentes._id_com
        fecha = mod_maestra.fecha.ToString

        nue_var.consulta = "INSERT INTO maestra (id_enlaces, id_loc, id_alum, id_caja, id_gabex, id_componentes, fecha_mod) VALUES (?id_enlaces, ?id_loc, ?id_alum, ?id_caja, ?id_gabex, ?id_componentes, ?fecha)"

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?id_enlaces", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_enlaces
            nue_var.cmd.Parameters.Add("?id_loc", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_loc
            nue_var.cmd.Parameters.Add("?id_alum", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_alum
            nue_var.cmd.Parameters.Add("?id_caja", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_caja
            nue_var.cmd.Parameters.Add("?id_gabex", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_gabex
            nue_var.cmd.Parameters.Add("?id_componentes", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_componentes
            nue_var.cmd.Parameters.Add("?fecha", MySql.Data.MySqlClient.MySqlDbType.DateTime).Value = fecha
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    
End Class
