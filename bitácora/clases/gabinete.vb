Imports MySql.Data.MySqlClient
Public Class gabinete

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar componenetes externos de gabinete
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM gabinete", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Sub modificar(ByVal chapa As String, ByVal candado As String, ByVal aldaba As String, ByVal va_sw As String, ByVal nue_alim600 As String)
        'procedimiento para modificar los componenetes de gabinete
        chapa = mod_gabinete.va_chapa.ToString
        candado = mod_gabinete.va_candado.ToString
        aldaba = mod_gabinete.va_aldaba.ToString
        va_sw = mod_gabinete.va_sw.ToString
        nue_alim600 = mod_gabinete.va_alim600.ToString


        nue_var.consulta = "UPDATE gabinete SET aldaba = ?alda, candado = ?cand, chapa = ?chap, seguridad_sw = ?sw, sw_alim = ?alim  WHERE id_gabinete =" & mod_gabinete.id_gab

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?chap", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = chapa
            nue_var.cmd.Parameters.Add("?cand", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = candado
            nue_var.cmd.Parameters.Add("?alda", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = aldaba
            nue_var.cmd.Parameters.Add("?sw", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = va_sw
            nue_var.cmd.Parameters.Add("?alim", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nue_alim600
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Sub nuevo(ByVal id_gab As Integer, ByVal chapa As String, ByVal candado As String, ByVal aldaba As String, ByVal va_sw As String, ByVal nue_alim600 As String)
        'procedimiento para modificar los componenetes de gabinete
        id_gab = mod_gabinete._id_gab
        chapa = frm_nuevopunto.cb_schapa.Text
        candado = frm_nuevopunto.cb_scandado.Text
        aldaba = frm_nuevopunto.cb_saldaba.Text
        va_sw = frm_nuevopunto.cb_sw.Text
        nue_alim600 = frm_nuevopunto.cb_alimgene.Text


        nue_var.consulta = "INSERT INTO gabinete (id_gabinete, aldaba, candado, chapa, seguridad_sw, sw_alim) VALUES (?id_gab, ?alda, ?cand, ?chap, ?sw, ?alim)"

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?id_gab", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_gab
            nue_var.cmd.Parameters.Add("?chap", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = chapa
            nue_var.cmd.Parameters.Add("?cand", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = candado
            nue_var.cmd.Parameters.Add("?alda", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = aldaba
            nue_var.cmd.Parameters.Add("?sw", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = va_sw
            nue_var.cmd.Parameters.Add("?alim", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nue_alim600
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

End Class
