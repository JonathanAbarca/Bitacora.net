Public Class frm_histareasex
    Dim nue_tareaex As New tareasex
    Dim nue_user As New usuario
    Public var_rut As String
    Public var_idex As Integer
    Private Sub frm_histareasex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actializar_dgvex()
        columnas_dgvex()
        gb_tex.Enabled = False
        btn_guardar.Enabled = False
    End Sub
    Public Sub actializar_dgvex()
        'cargar datos en datagrid
        dgv_tareasex.DataSource = nue_tareaex.listar()
    End Sub
    Sub columnas_dgvex()
        'oculta y cambia los nombres de encabezado de la tabla 
        dgv_tareasex.Columns(0).Visible = False
        dgv_tareasex.Columns(1).Visible = False
        dgv_tareasex.Columns(2).HeaderText = "TURNO"
        dgv_tareasex.Columns(3).HeaderText = "CUADRILLA"
        dgv_tareasex.Columns(4).HeaderText = "FECHA"
        dgv_tareasex.Columns(5).HeaderText = "PROBLEMA"
        dgv_tareasex.Columns(6).HeaderText = "REGISTRO DEL PROBLEMA"

        dgv_tareasex.Columns(2).Width = 60
        dgv_tareasex.Columns(3).Width = 80
        dgv_tareasex.Columns(4).Width = 100
        dgv_tareasex.Columns(5).Width = 90
        dgv_tareasex.Columns(6).Width = 203

    End Sub

    Private Sub dgv_tareasex_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tareasex.CellDoubleClick
        var_idex = dgv_tareasex.CurrentRow.Cells(0).Value.ToString()
        var_rut = dgv_tareasex.CurrentRow.Cells(1).Value.ToString()
        nue_user.listar_nomape()
        txt_turnoex.Text = dgv_tareasex.CurrentRow.Cells(2).Value.ToString()
        txt_grupoex.Text = dgv_tareasex.CurrentRow.Cells(3).Value.ToString()
        dtp_fechaex.Value = dgv_tareasex.CurrentRow.Cells(4).Value.ToString()
        txt_problemaex.Text = dgv_tareasex.CurrentRow.Cells(5).Value.ToString()
        txt_comentarioex.Text = dgv_tareasex.CurrentRow.Cells(6).Value.ToString()
        txt_nomex.Text = mod_usuario.nom + " " + mod_usuario.ape

    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        gb_tex.Enabled = True
        btn_editar.Enabled = False
        btn_guardar.Enabled = True
    End Sub

    Private Sub btn_guardar_Click_1(sender As Object, e As EventArgs) Handles btn_guardar.Click
        'accion del boton guardar que llama al modulo y clase historial 

        If txt_problemaex.Text <> "" And txt_comentarioex.Text <> "" Then
            nue_tareaex.modificar(txt_turnoex.Text, txt_grupoex.Text, dtp_fechaex.Value, txt_problemaex.Text, txt_comentarioex.Text)
            frm_liscompo.actializar_dgv()
            MessageBox.Show("SE HAN MODIFICADO LOS DATOS")
            actializar_dgvex()
            btn_editar.Enabled = True
            btn_guardar.Enabled = False
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")

        End If
    End Sub
End Class