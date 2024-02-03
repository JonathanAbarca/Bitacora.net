Public Class frm_alumbrado
    Dim nue_alum As New alumbrado
    Dim nue_maestra As New maestra

    Private Sub frm_alumbrado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' cuando carga el formulario de alumbrado
        txt_foco.Text = frm_liscompo.lbl_foco.Text.ToString
        txt_alimfoc.Text = frm_liscompo.lbl_alimfoco.Text.ToString
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click

        Me.Close()

    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        'accion del boton guardar que llama al modulo y clase alumbrado 
        If txt_alimfoc.Text <> "" And txt_foco.Text <> "" Then

            mod_alumbrado.foco = txt_foco.Text.ToString
            mod_alumbrado.alim_alum = txt_alimfoc.Text.ToString

            nue_alum.modificar(mod_alumbrado.alim_alum, mod_alumbrado.foco)
            nue_maestra.modificarfecha(mod_maestra.fecha)
            frm_liscompo.actializar_dgv()
            MessageBox.Show("SE HAN MODIFICADO LOS DATOS")
            Me.Close()



        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")

        End If
    End Sub

End Class