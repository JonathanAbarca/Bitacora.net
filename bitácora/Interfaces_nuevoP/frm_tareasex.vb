Public Class frm_tareasex
    Public var_tarea As String
    Dim nue_histex As New tareasex
    'id_his 	id_loc 	turno 	grupo 	fecha 	tipo_pro 	comentario 	id_usuario
    Private Sub frm_nietarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_nombreex.Text = mod_usuario.nom_usu + " " + mod_usuario.ape_usu.ToString()
        txt_grupoex.Text = mod_usuario.grupo_usu.ToString
        lbl_fechaex.Text = mod_maestra.fecha


    End Sub

    Private Sub btn_cancelarex_Click(sender As Object, e As EventArgs) Handles btn_cancelarex.Click
        Me.Close()
    End Sub

    Private Sub btn_guardarex_Click(sender As Object, e As EventArgs) Handles btn_guardarex.Click
        var_tarea = cb_tareaex.Text

        If txt_comentarioex.Text <> "" Then
            nue_histex.nuevoinex(mod_maestra.fecha, txt_comentarioex.Text, txt_grupoex.Text, txt_turnoex.Text, txt_comentarioex.Text, mod_usuario.id_usuario)
            Me.Close()
            MessageBox.Show("SE HAN GUARDADO LOS DATOS")
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
        End If
    End Sub
End Class