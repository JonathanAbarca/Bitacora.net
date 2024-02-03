Public Class frm_calles
    Dim nue_calles As New calles
    Private Sub frm_calles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llamarcalles()
        desabilitar()
    End Sub


    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        llamarcalles()
        desabilitar()
        btn_nuevo.Enabled = True
        txt_frmcalle.Clear()
        txt_idcalle.Clear()
    End Sub

    Public Sub llamarcalles()
        dgv_vercalles.DataSource = nue_calles.listarcalle()

        dgv_vercalles.Columns(0).HeaderText = "ID"
        dgv_vercalles.Columns(1).HeaderText = "Nº CALLE"

        dgv_vercalles.Columns(0).Width = 50
        dgv_vercalles.Columns(1).Width = 89

    End Sub

    Private Sub dgv_vercalles_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_vercalles.CellDoubleClick
        txt_idcalle.Text = dgv_vercalles.CurrentRow.Cells(0).Value.ToString()
        txt_frmcalle.Text = dgv_vercalles.CurrentRow.Cells(1).Value.ToString()
        habilitar()
        btn_modificar.Enabled = True
        btn_nuevo.Enabled = False
    End Sub
    Private Sub habilitar()
        'txt_idcalle.Enabled = True
        txt_frmcalle.Enabled = True
    End Sub
    Private Sub desabilitar()
        txt_idcalle.Enabled = False
        txt_frmcalle.Enabled = False
        btn_guardar.Enabled = False
        btn_modificar.Enabled = False
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        txt_idcalle.Enabled = False
        txt_frmcalle.Enabled = True
        btn_guardar.Enabled = True
        btn_modificar.Enabled = False
        btn_nuevo.Enabled = False
        txt_frmcalle.Clear()
        txt_idcalle.Clear()
        txt_frmcalle.Focus()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        nue_calles.verificarcalle()
        If mod_calles.verificar = True Then
            MessageBox.Show("LA CALLE YA EXISTE")
            txt_frmcalle.Clear()
            txt_frmcalle.Focus()
        Else
            If txt_frmcalle.Text <> "" Then
                nue_calles.nuevo()
                MessageBox.Show("SE HAN GUARDADO LOS DATOS")
                llamarcalles()
                txt_frmcalle.Clear()
                btn_nuevo.Enabled = True
            Else
                MessageBox.Show("FALTAN CAMPOS POR LLENAR")
                txt_frmcalle.Focus()
            End If
        End If

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If txt_frmcalle.Text <> "" Then
            nue_calles.modificar()
            MessageBox.Show("SE HAN MODIFICADO LOS DATOS")
            llamarcalles()
            txt_frmcalle.Clear()
            txt_idcalle.Clear()
            btn_nuevo.Enabled = True
            btn_modificar.Enabled = False
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")
            txt_frmcalle.Focus()
        End If


    End Sub
End Class