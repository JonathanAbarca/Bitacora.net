Public Class frm_componentes

    Dim nue_com As New componentes
    Dim nue_maestra As New maestra
    Private Sub frm_componentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_cbprin.Text = frm_liscompo.lbl_cbprin.Text.ToString
        txt_rlcbprin.Text = frm_liscompo.lbl_releprin.Text.ToString
        txt_cbbom.Text = frm_liscompo.lbl_cbbom.Text.ToString
        txt_conbom.Text = frm_liscompo.lbl_conbom.Text.ToString
        txt_olbom.Text = frm_liscompo.lbl_olbom.Text.ToString
        txt_cbven.Text = frm_liscompo.lbl_cbven.Text.ToString
        txt_conven.Text = frm_liscompo.lbl_contacven.Text.ToString
        txt_olven.Text = frm_liscompo.lbl_olven.Text.ToString
        txt_cbtrafo.Text = frm_liscompo.lbl_cbtrafo.Text.ToString
        txt_trafo600.Text = frm_liscompo.lbl_trafo600.Text.ToString
        txt_trafo220.Text = frm_liscompo.lbl_trafo220.Text.ToString
        txt_cbenh.Text = frm_liscompo.lbl_cbenchu.Text.ToString
        txt_enh.Text = frm_liscompo.lbl_enchhem.Text.ToString




    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        'accion del boton guardar que llama al modulo y clase componentes 
        If txt_cbprin.Text <> "" And txt_rlcbprin.Text <> "" And txt_cbbom.Text <> "" And txt_conbom.Text <> "" And txt_olbom.Text <> "" And txt_cbven.Text <> "" And txt_conven.Text <> "" And txt_olven.Text <> "" And txt_cbtrafo.Text <> "" And txt_trafo600.Text <> "" And txt_trafo220.Text <> "" And txt_cbenh.Text <> "" And txt_enh.Text <> "" Then


            mod_componentes.cb_princ = txt_cbprin.Text.ToString
            mod_componentes.rele_princ = txt_rlcbprin.Text.ToString
            mod_componentes.cb_bom = txt_cbbom.Text.ToString
            mod_componentes.cont_bom = txt_conbom.Text.ToString
            mod_componentes.ol_bom = txt_olbom.Text.ToString
            mod_componentes.cb_vent = txt_cbven.Text.ToString
            mod_componentes.cont_vent = txt_conven.Text.ToString
            mod_componentes.ol_vent = txt_olven.Text.ToString
            mod_componentes.cb_trafo = txt_cbtrafo.Text.ToString
            mod_componentes.trafo600 = txt_trafo600.Text.ToString
            mod_componentes.trafo220 = txt_trafo220.Text.ToString
            mod_componentes.cb_enchu = txt_cbenh.Text.ToString
            mod_componentes.enchu_hem = txt_enh.Text.ToString

            nue_com.modificar(mod_componentes.cb_princ, mod_componentes.rele_princ, mod_componentes.cb_bom, mod_componentes.cont_bom, mod_componentes.ol_bom, mod_componentes.cb_vent, mod_componentes.cont_vent, mod_componentes.ol_vent, mod_componentes.cb_trafo, mod_componentes.trafo600, mod_componentes.trafo220, mod_componentes.cb_enchu, mod_componentes.enchu_hem)
            nue_maestra.modificarfecha(mod_maestra.fecha)
            frm_liscompo.actializar_dgv()
            MessageBox.Show("SE HAN MODIFICADO LOS DATOS")
            frm_principal.Show()




        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")

        End If
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class