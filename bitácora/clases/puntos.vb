Imports MySql.Data.MySqlClient
Public Class puntos
    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    Public Sub nuevo()
        'procedimiento para ingresar un nuevo punto
       
        nue_var.consulta = "INSERT INTO puntos(id_punto, npunto) VALUES('',?puntos)"

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?puntos", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = frm_puntos.txt_frmpunto.Text
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Function listarpuntos() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM puntos ORDER BY npunto DESC", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listarpuntos = nue_var.dt
        Return listarpuntos
    End Function
    Public Sub verificarpunto()
        'funcion para buscar localizacion y convertir en calle y punto
        Dim consulta As String
        Dim adaptador As MySqlDataAdapter
        Dim lista As Byte

        consulta = "SELECT npunto FROM puntos WHERE npunto ='" & frm_puntos.txt_frmpunto.Text & "'"


        adaptador = New MySqlDataAdapter(consulta, nue_conexion.conex)
        nue_var.ds = New DataSet
        adaptador.Fill(nue_var.ds, "puntos")
        lista = nue_var.ds.Tables("puntos").Rows.Count

        If lista <> 0 Then

            mod_puntos.verificarpunto = True


        Else
            mod_puntos.verificarpunto = False

        End If
    End Sub
    Public Sub modificar()

        nue_var.consulta = "UPDATE puntos SET npunto=?npuntos WHERE id_punto =" & frm_puntos.txt_idpunto.Text
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?npuntos", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = frm_puntos.txt_frmpunto.Text
            'cb_estadom
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub comprovarid()
        'funcion para buscar localizacion y convertir en calle y punto
        Dim consulta As String
        Dim adaptador As MySqlDataAdapter
        Dim lista As Byte

        consulta = "SELECT id_punto FROM puntos WHERE npunto ='" & frm_nuevopunto.cb_puntosn.Text & "'"


        adaptador = New MySqlDataAdapter(consulta, nue_conexion.conex)
        nue_var.ds = New DataSet
        adaptador.Fill(nue_var.ds, "puntos")
        lista = nue_var.ds.Tables("puntos").Rows.Count

        If lista <> 0 Then

            mod_puntos.pvar_puntos = nue_var.ds.Tables("puntos").Rows(0).Item("id_punto")


        Else
            MsgBox("No se han encontrado datos que listar")

        End If
    End Sub

End Class
