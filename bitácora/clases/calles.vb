Imports MySql.Data.MySqlClient
Public Class calles

    Dim nue_conexion As New conexion
    Dim nue_var As New variables

    'funcion para listar las calles
    Public Function listar() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM localizacion INNER JOIN calles ON calles.id_calles = localizacion.id_calles INNER JOIN puntos ON puntos.id_punto = localizacion.id_puntos WHERE calles.ncalle =" & frm_busquedaloc.cb_buscalles.Text, nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listar = nue_var.dt
        Return listar
    End Function
    Public Function listarcalle() As DataTable
        nue_var.dt = New DataTable
        nue_conexion.conectar()
        nue_var.da = New MySqlDataAdapter("SELECT * FROM calles ORDER BY ncalle DESC", nue_conexion.conex())
        nue_var.da.Fill(nue_var.dt)
        nue_conexion.desconectar()
        listarcalle = nue_var.dt
        Return listarcalle
    End Function

    Public Sub nuevo()
        'procedimiento para ingresar un nueva calle
        Dim calles As String
        calles = frm_calles.txt_frmcalle.Text
        nue_var.consulta = "INSERT INTO calles (id_calles, ncalle) VALUES('',?calles)"

        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?calles", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = calles
            nue_var.cmd.ExecuteNonQuery()
            nue_conexion.desconectar()
        Catch mierror As MySqlException
            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
        End Try
    End Sub
    Public Sub listar_repor()
        'funcion para buscar localizacion y convertir en calle y punto
        Dim consulta As String
        Dim adaptador As MySqlDataAdapter
        Dim lista As Byte

        consulta = "SELECT id_loc FROM localizacion INNER JOIN calles ON calles.id_calles = localizacion.id_calles INNER JOIN puntos ON puntos.id_punto = localizacion.id_puntos WHERE ncalle ='" & mod_reportes.var_call & "' AND npunto='" & mod_reportes.var_pun & "'"


        adaptador = New MySqlDataAdapter(consulta, nue_conexion.conex)
        nue_var.ds = New DataSet
        adaptador.Fill(nue_var.ds, "localizacion")
        lista = nue_var.ds.Tables("localizacion").Rows.Count

        If lista <> 0 Then

            mod_reportes.var_result = nue_var.ds.Tables("localizacion").Rows(0).Item("id_loc")


        Else
            MsgBox("No se han encontrado datos que listar")

        End If
    End Sub
    Public Sub verificarcalle()
        'funcion para buscar localizacion y convertir en calle y punto
        Dim consulta As String
        Dim adaptador As MySqlDataAdapter
        Dim lista As Byte

        consulta = "SELECT ncalle FROM calles WHERE ncalle ='" & frm_calles.txt_frmcalle.Text & "'"


        adaptador = New MySqlDataAdapter(consulta, nue_conexion.conex)
        nue_var.ds = New DataSet
        adaptador.Fill(nue_var.ds, "calles")
        lista = nue_var.ds.Tables("calles").Rows.Count

        If lista <> 0 Then

            mod_calles.verificar = True


        Else
            mod_calles.verificar = False

        End If
    End Sub
    Public Sub modificar()
        
        nue_var.consulta = "UPDATE calles SET ncalle=?ncalle WHERE id_calles =" & frm_calles.txt_idcalle.Text
        Try
            nue_conexion.conectar()
            nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
            nue_var.cmd.Parameters.Add("?ncalle", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = frm_calles.txt_frmcalle.Text
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

        consulta = "SELECT id_calles FROM calles WHERE ncalle ='" & frm_nuevopunto.cb_callen.Text & "'"


        adaptador = New MySqlDataAdapter(consulta, nue_conexion.conex)
        nue_var.ds = New DataSet
        adaptador.Fill(nue_var.ds, "calles")
        lista = nue_var.ds.Tables("calles").Rows.Count

        If lista <> 0 Then

            mod_calles.var_calles = nue_var.ds.Tables("calles").Rows(0).Item("id_calles")


        Else
            MsgBox("No se han encontrado datos que listar")

        End If
    End Sub



End Class
