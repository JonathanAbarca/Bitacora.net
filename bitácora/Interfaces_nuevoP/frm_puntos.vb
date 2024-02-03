Public Class frm_puntos
    Dim nue_puntos As New puntos
    Private Sub frm_puntos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llamarpuntos()
        desabilitar()
    End Sub
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        llamarpuntos()
        desabilitar()
        btn_nuevo.Enabled = True
        txt_frmpunto.Clear()
        txt_idpunto.Clear()
    End Sub
    Public Sub llamarpuntos()
        dgv_verpuntos.DataSource = nue_puntos.listarpuntos()

        dgv_verpuntos.Columns(0).HeaderText = "ID"
        dgv_verpuntos.Columns(1).HeaderText = "Nº PUNTO"

        dgv_verpuntos.Columns(0).Width = 50
        dgv_verpuntos.Columns(1).Width = 89
    End Sub
    Private Sub dgv_verpuntos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_verpuntos.CellDoubleClick
        txt_idpunto.Text = dgv_verpuntos.CurrentRow.Cells(0).Value.ToString()
        txt_frmpunto.Text = dgv_verpuntos.CurrentRow.Cells(1).Value.ToString()
        habilitar()
        btn_modificar.Enabled = True
        btn_nuevo.Enabled = False
    End Sub
    Private Sub habilitar()
        'txt_idcalle.Enabled = True
        txt_frmpunto.Enabled = True
    End Sub
    Private Sub desabilitar()
        txt_idpunto.Enabled = False
        txt_frmpunto.Enabled = False
        btn_guardar.Enabled = False
        btn_modificar.Enabled = False
    End Sub
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        txt_idpunto.Enabled = False
        txt_frmpunto.Enabled = True
        btn_guardar.Enabled = True
        btn_modificar.Enabled = False
        btn_nuevo.Enabled = False
        txt_frmpunto.Clear()
        txt_idpunto.Clear()
        txt_frmpunto.Focus()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        nue_puntos.verificarpunto()
        If mod_calles.verificar = True Then
            MessageBox.Show("LA CALLE YA EXISTE")
            txt_frmpunto.Clear()
            txt_frmpunto.Focus()
        Else
            If txt_frmpunto.Text <> "" Then
                nue_puntos.nuevo()
                MessageBox.Show("SE HAN GUARDADO LOS DATOS")
                llamarpuntos()
                txt_frmpunto.Clear()
                btn_nuevo.Enabled = True
            Else
                MessageBox.Show("FALTAN CAMPOS POR LLENAR")
                txt_frmpunto.Focus()
            End If
        End If

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If txt_frmpunto.Text <> "" Then
            nue_puntos.modificar()
            MessageBox.Show("SE HAN MODIFICADO LOS DATOS")
            llamarpuntos()
            txt_frmpunto.Clear()
            txt_idpunto.Clear()
            btn_nuevo.Enabled = True
            btn_modificar.Enabled = False
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
            txt_frmpunto.Focus()
        End If


    End Sub
End Class