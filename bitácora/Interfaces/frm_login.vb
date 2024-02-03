Public Class frm_login
    Dim nue_usua As New usuario
    Public contraseña_u As String = ""


    'id_usuario 	nombre 	apellido 	cargo 	grupo 	user 	pass 
    Private Sub btn_entrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_entrar.Click
        If txt_contraseña.Text <> "" And txt_user.Text <> "" Then
            If nue_usua.verificar(txt_contraseña.Text, txt_user.Text) = True Then
                mod_usuario.pass = txt_contraseña.Text

                contraseña_u = nue_usua.contraseña_u(txt_contraseña.Text, txt_user.Text)

                MessageBox.Show("Se ha registrado correctamente")

                frm_principal.var_login = True
                frm_principal.deslogeado()
                mod_mantencion.var_log = True
                frm_manrealizada.verificar()
                txt_contraseña.Clear()
                txt_user.Clear()
                Me.Close()
                frm_principal.pnl_body.Controls.Clear()
                'frm_principal.Show()
            Else
                txt_contraseña.Clear()
                txt_user.Clear()
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS")
            End If
        Else
            MessageBox.Show("ESCRIBA SU NOMBRE DE USUARIO Y SU CONTRASEÑA")
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
        txt_contraseña.Clear()
        txt_user.Clear()
    End Sub

   
End Class