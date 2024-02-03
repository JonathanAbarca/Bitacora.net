Imports MySql.Data.MySqlClient
Public Class caja_local


    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar los componentes de la caja local
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM caja", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function

    Public Sub modificar(ByVal chapa As String, ByVal candado As String, ByVal aldaba As String, ByVal en60 As String, ByVal en30 As String, ByVal en35 As String)
        'procedimiento para modificar los componenetes de gabinete
        chapa = mod_caja.chapa.ToString
        candado = mod_caja.candado.ToString
        aldaba = mod_caja.aldaba.ToString
        en60 = mod_caja.en60.ToString
        en30 = mod_caja.en30.ToString
        en35 = mod_caja.en35.ToString

        nue_var.consulta = "UPDATE caja SET aldaba = ?alda, candado = ?cand, chapa = ?chap, enchufe_60 = ?60, enchufe_30 = ?30, enchufe_35p = ?35  WHERE id_local =" & mod_caja.id_caja

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?chap", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = chapa
            nue_var.cmd.Parameters.Add("?cand", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = candado
            nue_var.cmd.Parameters.Add("?alda", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = aldaba
            nue_var.cmd.Parameters.Add("?60", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = en60
            nue_var.cmd.Parameters.Add("?30", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = en30
            nue_var.cmd.Parameters.Add("?35", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = en35
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub


    'mod_caja._id_caja, cb_aldaba.Text, cb_candado.Text, cb_chapa.Text, cb_en60.Text, cb_en30.Text, cb_en35.Text
    Public Sub nuevo(ByVal id_caj As Integer, ByVal chapa As String, ByVal candado As String, ByVal aldaba As String, ByVal en60 As String, ByVal en30 As String, ByVal en35 As String)
        'procedimiento para modificar los componenetes de gabinete
        id_caj = mod_caja._id_caja
        chapa = frm_nuevopunto.cb_chapa.Text
        candado = frm_nuevopunto.cb_candado.Text
        aldaba = frm_nuevopunto.cb_aldaba.Text
        en60 = frm_nuevopunto.cb_en60.Text
        en30 = frm_nuevopunto.cb_en30.Text
        en35 = frm_nuevopunto.cb_en35.Text

        nue_var.consulta = "INSERT INTO caja (id_local, aldaba, candado, chapa, enchufe_60, enchufe_30, enchufe_35p) VALUES (?id_caj, ?alda, ?cand, ?chap, ?60, ?30, ?35)"

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?id_caj", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_caj
            nue_var.cmd.Parameters.Add("?alda", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = aldaba
            nue_var.cmd.Parameters.Add("?cand", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = candado
            nue_var.cmd.Parameters.Add("?chap", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = chapa
            nue_var.cmd.Parameters.Add("?60", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = en60
            nue_var.cmd.Parameters.Add("?30", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = en30
            nue_var.cmd.Parameters.Add("?35", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = en35
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub




End Class
