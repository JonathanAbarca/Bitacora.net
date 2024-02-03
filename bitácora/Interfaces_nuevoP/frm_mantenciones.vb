Public Class frm_mantenciones
    Dim nue_man As New mantencion
    Dim sw As Integer
    Dim nue_calles As New calles
    Dim nue_puntos As New puntos
    Private Sub frm_mantenciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 	id_man 	id_localiz 	obs 	fecha_inicio 	fecha_termino 	nombre_mante 	turno 	grupo 	estado

        dgv_mantenciones.DataSource = nue_man.listar()
        columnas_dgvex()
        bloquear()
        compuntos()
        combocalles()

    End Sub

    


    Public Sub combocalles()
        'cb_calle.Items.Clear()
        cb_calleman.DataSource = nue_calles.listarcalle()
        cb_calleman.DisplayMember = "ncalle"
        cb_calleman.ValueMember = "id_calles"
        'conectarme.Close()
    End Sub
    Sub compuntos()
        'cb_puntos.Items.Clear()
        cb_puntosman.DataSource = nue_puntos.listarpuntos()
        cb_puntosman.DisplayMember = "npunto"
        cb_puntosman.ValueMember = "id_punto"
        'conectarme.Close()
    End Sub
    Private Sub bloquear()
        'bloquear botones
        btn_guardar.Enabled = False
        gb_esp.Enabled = False
        gb_esp2.Enabled = False
        btn_nuevo.Enabled = True
        btn_modificar.Enabled = True
    End Sub
    Private Sub desbloquear()
        'desbloquear botones
        lbl_nomm.Text = mod_usuario.nom_usu + " " + mod_usuario.ape_usu.ToString()
        txt_grupom.Text = mod_usuario.grupo_usu
        btn_guardar.Enabled = True
        btn_nuevo.Enabled = False
        btn_modificar.Enabled = False
        gb_esp.Enabled = True
        gb_esp2.Enabled = True
    End Sub
    Private Sub limpiar()
        'limpiar datos de los campos de texto
        dtp_fechaini.Refresh()
        dtp_fechater.Refresh()
        cb_estadom.Refresh()

    End Sub

    Sub columnas_dgvex()
        'oculta y cambia los nombres de encabezado de la tabla 
        dgv_mantenciones.Columns(0).Visible = False
        dgv_mantenciones.Columns(1).Visible = False
        dgv_mantenciones.Columns(2).HeaderText = "OBSERVACIONES"
        dgv_mantenciones.Columns(3).HeaderText = "F. INICIO"
        dgv_mantenciones.Columns(4).HeaderText = "F. TERMINO"
        dgv_mantenciones.Columns(5).HeaderText = "INGRESADO POR"
        dgv_mantenciones.Columns(6).HeaderText = "TURNO"
        dgv_mantenciones.Columns(7).HeaderText = "GRUPO"
        dgv_mantenciones.Columns(8).HeaderText = "ESTADO"


    End Sub
    Private Sub dgv_mantenciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_mantenciones.CellDoubleClick
        'llamar los datos de la celda haciendo doble click
        mod_mantencion.var_id_man = dgv_mantenciones.CurrentRow.Cells(0).Value.ToString()
        mod_mantencion.ver_loc = dgv_mantenciones.CurrentRow.Cells(1).Value.ToString()
        nue_man.listar_loc()
        dtp_fechaini.Text = dgv_mantenciones.CurrentRow.Cells(3).Value.ToString()
        dtp_fechater.Value = dgv_mantenciones.CurrentRow.Cells(4).Value.ToString()
        lbl_nomm.Text = dgv_mantenciones.CurrentRow.Cells(5).Value.ToString()
        txt_turnom.Text = dgv_mantenciones.CurrentRow.Cells(6).Value.ToString()
        txt_grupom.Text = dgv_mantenciones.CurrentRow.Cells(7).Value.ToString()
        cb_estadom.Text = dgv_mantenciones.CurrentRow.Cells(8).Value.ToString()
        cb_calleman.Text = mod_mantencion.var_calle.ToString
        cb_puntosman.Text = mod_mantencion.var_punto.ToString

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        desbloquear()
        limpiar()
        dgv_mantenciones.Enabled = False
        lbl_nomm.Text = mod_usuario.nom_usu + " " + mod_usuario.ape_usu.ToString()
        txt_grupom.Text = mod_usuario.grupo_usu
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        desbloquear()
        sw = +1
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        'Funcion de boton guardar
        If cb_calleman.Text <> "" And cb_puntosman.Text <> "" And dtp_fechaini.Text <> "" And dtp_fechater.Text <> "" Then
            If sw = 0 Then
                mod_mantencion.var_concalle = cb_calleman.Text
                mod_mantencion.var_conpunto = cb_puntosman.Text
                nue_man.listar_idloc()
                nue_man.nuevo()
                MessageBox.Show("SE HAN GUARDADO LOS DATOS")
                dgv_mantenciones.Enabled = True
                bloquear()
                limpiar()
                dgv_mantenciones.DataSource = nue_man.listar()
            Else
                'Funcion de boton modificar
                mod_mantencion.var_concalle = cb_calleman.Text
                mod_mantencion.var_conpunto = cb_puntosman.Text
                nue_man.listar_idloc()
                nue_man.modificar()
                MessageBox.Show("SE HAN MODIFICADO LOS DATOS")
                dgv_mantenciones.Enabled = True

                dgv_mantenciones.DataSource = nue_man.listar()

            End If
            frm_principal.actmantencion()
            limpiar()
            bloquear()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If

    End Sub



            



   
End Class