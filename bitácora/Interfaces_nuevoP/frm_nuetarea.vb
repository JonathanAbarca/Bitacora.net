Public Class frm_nuetarea
    Public var_tarea As String
    Dim nue_hist As New historial
    'id_his 	id_loc 	turno 	grupo 	fecha 	tipo_pro 	comentario 	id_usuario
    Private Sub frm_nietarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_nombre.Text = mod_usuario.nom_usu + " " + mod_usuario.ape_usu.ToString()
        txt_grupo.Text = mod_usuario.grupo_usu.ToString
        lbl_fecha.Text = mod_maestra.fecha


    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        var_tarea = cb_tarea.SelectedItem.ToString()

        If txt_comentario.Text <> "" Then
            nue_hist.nuevoin(mod_maestra.fecha, txt_comentario.Text, txt_grupo.Text, txt_turno.Text, txt_comentario.Text, mod_localizacion.nloc, mod_usuario.id_usuario)
            MessageBox.Show("SE HAN GUARDADO LOS DATOS")
            frm_liscompo.actializar_dgv()
            Me.Close()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub

End Class