Public Class frm_usuario
    Dim nue_usu As New usuario
    Private Sub frm_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_unom.Text = mod_usuario.nom_usu
        lbl_uape.Text = mod_usuario.ape_usu
        lbl_ucargo.Text = mod_usuario.cargo_usu
        lbl_usuario.Text = mod_usuario.user
        lbl_ugrupo.Text = mod_usuario.grupo_usu
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_realizar_Click(sender As Object, e As EventArgs) Handles btn_realizar.Click
        Dim f As New frm_camcontra
        f.ShowDialog()
    End Sub
End Class