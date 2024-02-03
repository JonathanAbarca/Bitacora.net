Imports MySql.Data.MySqlClient
Public Class localizacion
    Dim nue_conexion As New conexion
    Dim nue_var As New variables
    Public Sub nuevo(ByVal max_calles As Integer, ByVal max_puntos As Integer, ByVal max_loc As Integer)
        'procedimiento para ingresar un nueva localizacion
        max_calles = mod_calles.var_calles
        max_puntos = mod_puntos.pvar_puntos
        max_loc = mod_localizacion.nloc

        '

        nue_var.consulta = "INSERT INTO localizacion (id_loc, id_calles, id_puntos) VALUES(?max_loc, ?max_calles, ?max_puntos)"

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?max_loc", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = max_loc
            nue_var.cmd.Parameters.Add("?max_calles", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = max_calles
            nue_var.cmd.Parameters.Add("?max_puntos", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = max_puntos
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub verificarloc()
        'funcion para buscar localizacion y convertir en calle y punto
        Dim consulta As String
        Dim adaptador As MySqlDataAdapter
        Dim lista As Byte

        consulta = "SELECT id_loc FROM localizacion INNER JOIN calles ON calles.id_calles = localizacion.id_calles INNER JOIN puntos ON puntos.id_punto = localizacion.id_puntos WHERE calles.ncalle ='" & frm_nuevopunto.cb_callen.Text & "'AND puntos.npunto='" & frm_nuevopunto.cb_puntosn.Text & "'"


        adaptador = New MySqlDataAdapter(consulta, nue_conexion.conex)
        nue_var.ds = New DataSet
        adaptador.Fill(nue_var.ds, "localizacion")
        lista = nue_var.ds.Tables("localizacion").Rows.Count

        If lista <> 0 Then

            mod_localizacion.verificar = True


        Else
            mod_localizacion.verificar = False

        End If
    End Sub
End Class
