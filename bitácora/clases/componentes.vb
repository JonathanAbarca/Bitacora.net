Imports MySql.Data.MySqlClient
Public Class componentes

    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Dim id_comin As Integer
    'funcion para listar las jornadas
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM componentes", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Sub modificar(ByVal cb_princ As String, ByVal rele_princ As String, ByVal cb_bom As String, ByVal cont_bom As String, ByVal ol_bom As String, ByVal cb_vent As String, ByVal cont_vent As String, ByVal ol_vent As String, ByVal cb_trafo As String, ByVal trafo600 As String, ByVal trafo220 As String, ByVal cb_enchu As String, ByVal enchu_hem As String)
        'procedimiento para modificar los componenetes de gabinete
        cb_princ = mod_componentes.cb_princ.ToString
        rele_princ = mod_componentes.rele_princ.ToString
        cb_bom = mod_componentes.cb_bom.ToString
        cont_bom = mod_componentes.cont_bom.ToString
        ol_bom = mod_componentes.ol_bom.ToString
        cb_vent = mod_componentes.cb_vent.ToString
        cont_vent = mod_componentes.cont_vent.ToString
        ol_vent = mod_componentes.ol_vent.ToString
        cb_trafo = mod_componentes.cb_trafo.ToString
        trafo600 = mod_componentes.trafo600.ToString
        trafo220 = mod_componentes.trafo220.ToString
        cb_enchu = mod_componentes.cb_enchu.ToString
        enchu_hem = mod_componentes.enchu_hem.ToString


        nue_var.consulta = "UPDATE componentes SET cb_princ = ?cb_princ, rele_princ = rele_princ, cb_bom = ?cb_bom, cont_bom =?cont_bom, ol_bom = ?ol_bom, cb_vent = ?cb_vent, cont_vent = ?cont_vent, ol_vent = ?ol_vent,	cb_trafo =?cb_trafo, trafo600 = ?trafo600, trafo220 = ?trafo220, cb_enchu = ?cb_enchu, enchu_hem = ?enchu_hem   WHERE id_componentes =" & mod_componentes.id_com

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?cb_princ", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cb_princ
            nue_var.cmd.Parameters.Add("?rele_princ", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rele_princ
            nue_var.cmd.Parameters.Add("?cb_bom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cb_bom
            nue_var.cmd.Parameters.Add("?cont_bom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cont_bom
            nue_var.cmd.Parameters.Add("?ol_bom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ol_bom
            nue_var.cmd.Parameters.Add("?cb_vent", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cb_vent
            nue_var.cmd.Parameters.Add("?cont_vent", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cont_vent
            nue_var.cmd.Parameters.Add("?ol_vent", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ol_vent
            nue_var.cmd.Parameters.Add("?cb_trafo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cb_trafo
            nue_var.cmd.Parameters.Add("?trafo600", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = trafo600
            nue_var.cmd.Parameters.Add("?trafo220", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = trafo220
            nue_var.cmd.Parameters.Add("?cb_enchu", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cb_enchu
            nue_var.cmd.Parameters.Add("?enchu_hem", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = enchu_hem

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub

    Public Sub nuevo()
        'procedimiento para ingresar unos nuevos componenetes de gabinete

        'And txt_cbtrafo.Text <> "" And txt_trafo600.Text <> "" And txt_trafo220.Text <> "" And txt_cbenh.Text <> "" And txt_enh.Text <> ""
        id_comin = mod_componentes._id_com
        cb_princ = frm_nuevopunto.cb_cbprin.Text
        rele_princ = frm_nuevopunto.cb_reledifprin.Text
        cb_vent = frm_nuevopunto.cb_cbvent.Text
        cont_vent = frm_nuevopunto.cb_convent.Text
        ol_vent = frm_nuevopunto.cb_olvent.Text

        cb_bom = frm_nuevopunto.cb_cbbomh.Text
        cont_bom = frm_nuevopunto.cb_conbom.Text
        ol_bom = frm_nuevopunto.cb_olbom.Text

        
        cb_trafo = frm_nuevopunto.cb_cbtra600.Text
        trafo600 = frm_nuevopunto.cb_trafo600.Text
        trafo220 = frm_nuevopunto.cb_trafo220.Text
        cb_enchu = frm_nuevopunto.cb_cbenh.Text
        enchu_hem = frm_nuevopunto.cb_enh.Text


        nue_var.consulta = "INSERT INTO componentes (id_componentes, cb_princ, rele_princ, cb_bom, cont_bom, ol_bom, cb_vent, cont_vent, ol_vent, cb_trafo, trafo600, trafo220, cb_enchu, enchu_hem) VALUES (?id_comin, ?cb_princ, ?rele_princ, ?cb_bom, ?cont_bom, ?ol_bom, ?cb_vent, ?cont_vent, ?ol_vent, ?cb_trafo, ?trafo600, ?trafo220, ?cb_enchu, ?enchu_hem)"



        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?id_comin", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = id_comin
            nue_var.cmd.Parameters.Add("?cb_princ", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cb_princ
            nue_var.cmd.Parameters.Add("?rele_princ", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = rele_princ
            nue_var.cmd.Parameters.Add("?cb_bom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cb_bom
            nue_var.cmd.Parameters.Add("?cont_bom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cont_bom
            nue_var.cmd.Parameters.Add("?ol_bom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ol_bom
            nue_var.cmd.Parameters.Add("?cb_vent", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cb_vent
            nue_var.cmd.Parameters.Add("?cont_vent", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cont_vent
            nue_var.cmd.Parameters.Add("?ol_vent", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ol_vent
            nue_var.cmd.Parameters.Add("?cb_trafo", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cb_trafo
            nue_var.cmd.Parameters.Add("?trafo600", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = trafo600
            nue_var.cmd.Parameters.Add("?trafo220", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = trafo220
            nue_var.cmd.Parameters.Add("?cb_enchu", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cb_enchu
            nue_var.cmd.Parameters.Add("?enchu_hem", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = enchu_hem

            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
End Class
