Public Class frm_historial
    Dim nue_his As New historial
    Private Sub frm_historial_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        'accion del boton guardar que llama al modulo y clase historial 
        If txt_cuadrilla.Text <> "" And txt_detalles.Text <> "" And txt_encargado.Text <> "" And txt_problema.Text <> "" And txt_turno.Text <> "" And dtm_fecha.Value.ToString <> "" Then

            nue_his.modificar(mod_historial.id_actuhis, txt_cuadrilla.Text, txt_detalles.Text, txt_problema.Text, txt_turno.Text, dtm_fecha.Value)
            frm_liscompo.actializar_dgv()
            MessageBox.Show("SE HAN MODIFICADO LOS DATOS")
            Me.Close()



        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")

        End If
    End Sub


    Private Sub Label30_DoubleClick(sender As Object, e As EventArgs) Handles Label30.DoubleClick
        frm_login.Show()
    End Sub
End Class