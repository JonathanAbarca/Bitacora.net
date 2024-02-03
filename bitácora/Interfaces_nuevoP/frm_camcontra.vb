Public Class frm_camcontra
    Dim neu_usu As New usuario
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_realizar_Click(sender As Object, e As EventArgs) Handles btn_realizar.Click

        If mod_usuario.pass = txt_conactual.Text Then
            If txt_conactual.Text <> "" And txt_nuecon.Text <> "" And txt_repcon.Text <> "" Then
                If txt_nuecon.Text = txt_repcon.Text Then
                    mod_usuario.pass_upd = txt_nuecon.Text
                    neu_usu.modpass()
                    MsgBox("Se han guardado los datos")
                    txt_conactual.Clear()
                    txt_nuecon.Clear()
                    txt_repcon.Clear()
                Else
                    MsgBox("Las contraseñas no coiciden")
                End If

            Else
                MsgBox("Faltan campos por llenar")
            End If


        Else
            MsgBox("La contraseña actual no coincide")
        End If


    End Sub
End Class