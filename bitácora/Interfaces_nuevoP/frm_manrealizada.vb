Public Class frm_manrealizada
    Dim nue_manrea As New mantencion
    Private Sub frm_manrealizada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'frm_principal.deslogeado()
        verificar()

    End Sub
    Public Sub verificar()
        If mod_mantencion.var_log = True Then

            lbl_fnom.Text = mod_usuario.nom_usu.ToString + " " + mod_usuario.ape_usu.ToString
            lbl_fgrupo.Text = mod_usuario.grupo_usu.ToString

            gb_fguard.Visible = True
            vercampos()
        Else
            camposocultos()

            gb_fguard.Visible = False
        End If
    End Sub
    Private Sub camposocultos()
        lbl_fnom.Visible = False
        lbl_fturno.Visible = False
        lbl_fgrupo.Visible = False
        txt_fcomenta.Enabled = False
    End Sub
    Private Sub vercampos()
        lbl_fnom.Visible = True
        lbl_fturno.Visible = True
        lbl_fgrupo.Visible = True
        txt_fcomenta.Enabled = True
    End Sub
    Private Sub limpiar()
        txt_fcomenta.Clear()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar1_Click_1(sender As Object, e As EventArgs) Handles btn_guardar1.Click
        If txt_fcomenta.Text <> "" Then

            nue_manrea.modificarestado()
            MessageBox.Show("SE HAN MODIFICADO LOS DATOS")
            frm_principal.actmantencion()
            Me.Close()
            limpiar()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")

        End If
    End Sub
End Class