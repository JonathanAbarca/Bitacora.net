Imports MySql.Data.MySqlClient
Public Class alumbrado

    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    
    'funcion para listar los componentes de alumbrado
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM alumbrado", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function


    Public Sub modificar(ByVal foco As String, ByVal alim As String)
        'procedimiento para modificar los componenetes de alumbrado
        foco = mod_alumbrado.foco.ToString
        alim = mod_alumbrado.alim_alum.ToString
        nue_var.consulta = "UPDATE alumbrado SET foco = ?foco , alimentacion = ?alim WHERE id_alum =" & mod_alumbrado.id_alum

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?foco", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = foco
            nue_var.cmd.Parameters.Add("?alim", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = alim
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Sub nuevo(ByVal var_alum As Integer, ByVal foco As String, ByVal alim As String)
        'procedimiento para ingresar nuevos componenetes de alumbrado
        foco = frm_nuevopunto.txt_foco.Text
        alim = frm_nuevopunto.cb_alim.Text
        var_alum = mod_alumbrado._id_alum
        nue_var.consulta = "INSERT INTO alumbrado (id_alum, foco, alimentacion) VALUES(?var_alum, ?foco, ?alim)"
        'id_alum 	foco 	alimentacion
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?var_alum", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = var_alum
            nue_var.cmd.Parameters.Add("?foco", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = foco
            nue_var.cmd.Parameters.Add("?alim", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = alim
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
End Class
