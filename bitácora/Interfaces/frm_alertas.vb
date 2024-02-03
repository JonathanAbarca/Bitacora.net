Public Class frm_alertas
    Dim nue_man As New mantencion
    Private Sub frm_alertas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub
    Private Sub listar()
        nue_man.listartodo()
        nue_man.listar_loc()
        lbl_alfini.Text = mod_mantencion.var_fini
        lbl_alfter.Text = mod_mantencion.var_fter
        lbl_alcalle.Text = mod_mantencion.var_calle
        lbl_alpunto.Text = mod_mantencion.var_punto
    End Sub

    Private Sub btn_realizar_Click(sender As Object, e As EventArgs) Handles btn_realizar.Click
        frm_manrealizada.lbl_ffter.Text = lbl_alfter.Text
        frm_manrealizada.lbl_ffini.Text = lbl_alfini.Text
        frm_manrealizada.lbl_fcalle.Text = lbl_alcalle.Text
        frm_manrealizada.lbl_fpunto.Text = lbl_alpunto.Text
        Me.Close()
        frm_principal.abrir_en_panel(frm_manrealizada, frm_principal.pnl_body)
    End Sub

    Private Sub btn_recordar_Click(sender As Object, e As EventArgs) Handles btn_recordar.Click
        Me.Close()
    End Sub
End Class