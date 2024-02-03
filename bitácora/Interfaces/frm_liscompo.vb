Public Class frm_liscompo
    Dim nue_his As New historial
    Dim nue_maestra As New maestra
    Private Sub frm_liscompo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'carga los datos traidos desde las clases
        actializar_dgv()
        columnas_dgv()
        rdb_alum.Checked = True


       
        'dgv_usuario.Columns(1).Width = 170
    End Sub

    Sub columnas_dgv()
        'oculta y cambia los nombres de encabezado de la tabla 
        dgv_historial.Columns(0).Visible = False
        dgv_historial.Columns(1).Visible = False
        dgv_historial.Columns(2).HeaderText = "TURNO"
        dgv_historial.Columns(3).HeaderText = "GRUPO"
        dgv_historial.Columns(4).HeaderText = "FECHA"
        dgv_historial.Columns(5).HeaderText = "PROBLEMA"
        dgv_historial.Columns(6).HeaderText = "REGISTRO DEL PROBLEMA"
        dgv_historial.Columns(7).HeaderText = "RUT ENCARGADO"

        dgv_historial.Columns(2).Width = 50
        dgv_historial.Columns(3).Width = 70
        dgv_historial.Columns(4).Width = 100
        dgv_historial.Columns(5).Width = 90
        dgv_historial.Columns(6).Width = 246
        dgv_historial.Columns(7).Width = 100
    End Sub

    Public Sub actializar_dgv()

        dgv_componentes.DataSource = nue_maestra.listar()
        dgv_historial.DataSource = nue_his.listar()

    End Sub

    Private Sub dgv_componentes_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_componentes.CellPainting
        'funcion para mostrar los datos de los distintos componentes 
      
        'tabla alumbrado
        lbl_foco.Text = dgv_componentes.CurrentRow.Cells(11).Value.ToString()
        lbl_alimfoco.Text = dgv_componentes.CurrentRow.Cells(12).Value.ToString()
        'tabla caja local
        lbl_caldaba.Text = dgv_componentes.CurrentRow.Cells(14).Value.ToString()
        lbl_ccandado.Text = dgv_componentes.CurrentRow.Cells(15).Value.ToString()
        lbl_cchapa.Text = dgv_componentes.CurrentRow.Cells(16).Value.ToString()
        lbl_enchufe60.Text = dgv_componentes.CurrentRow.Cells(17).Value.ToString()
        lbl_enchufe30.Text = dgv_componentes.CurrentRow.Cells(18).Value.ToString()
        lbl_enchufe35.Text = dgv_componentes.CurrentRow.Cells(19).Value.ToString()
        'tabla gabinete componentes de seguridad exteriores
        lbl_galdaba.Text = dgv_componentes.CurrentRow.Cells(21).Value.ToString()
        lbl_gcandado.Text = dgv_componentes.CurrentRow.Cells(22).Value.ToString()
        lbl_gchapa.Text = dgv_componentes.CurrentRow.Cells(23).Value.ToString()
        lbl_sw.Text = dgv_componentes.CurrentRow.Cells(24).Value.ToString()
        lbl_g600v.Text = dgv_componentes.CurrentRow.Cells(25).Value.ToString()
        'tabla componentes gabinete internos
        lbl_cbprin.Text = dgv_componentes.CurrentRow.Cells(27).Value.ToString()
        lbl_releprin.Text = dgv_componentes.CurrentRow.Cells(28).Value.ToString()
        lbl_cbbom.Text = dgv_componentes.CurrentRow.Cells(29).Value.ToString()
        lbl_conbom.Text = dgv_componentes.CurrentRow.Cells(30).Value.ToString()
        lbl_olbom.Text = dgv_componentes.CurrentRow.Cells(31).Value.ToString()
        lbl_cbven.Text = dgv_componentes.CurrentRow.Cells(32).Value.ToString()
        lbl_contacven.Text = dgv_componentes.CurrentRow.Cells(33).Value.ToString()
        lbl_olven.Text = dgv_componentes.CurrentRow.Cells(34).Value.ToString()
        lbl_cbtrafo.Text = dgv_componentes.CurrentRow.Cells(35).Value.ToString()
        lbl_trafo600.Text = dgv_componentes.CurrentRow.Cells(36).Value.ToString()
        lbl_trafo220.Text = dgv_componentes.CurrentRow.Cells(37).Value.ToString()
        lbl_cbenchu.Text = dgv_componentes.CurrentRow.Cells(38).Value.ToString()
        lbl_enchhem.Text = dgv_componentes.CurrentRow.Cells(39).Value.ToString()
        'envia las variables a los modulos correspondientes
        mod_alumbrado.id_alum = dgv_componentes.CurrentRow.Cells(10).Value.ToString()
        mod_maestra.id_maestra = dgv_componentes.CurrentRow.Cells(0).Value.ToString()
        mod_gabinete.id_gab = dgv_componentes.CurrentRow.Cells(20).Value.ToString()
        mod_caja.id_caja = dgv_componentes.CurrentRow.Cells(13).Value.ToString()
        mod_componentes.id_com = dgv_componentes.CurrentRow.Cells(26).Value.ToString()
    End Sub
  


    

    Private Sub btn_mod2_Click(sender As Object, e As EventArgs)
        frm_componentes.Show()
    End Sub


    Private Sub Label30_DoubleClick(sender As Object, e As EventArgs)
        frm_login.Show()
    End Sub

  
    Private Sub dgv_historial_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_historial.CellDoubleClick
        mod_historial.id_actuhis = dgv_historial.CurrentRow.Cells(0).Value.ToString()
        frm_historial.txt_turno.Text = dgv_historial.CurrentRow.Cells(2).Value.ToString()
        frm_historial.txt_cuadrilla.Text = dgv_historial.CurrentRow.Cells(3).Value.ToString()
        frm_historial.dtm_fecha.Value = dgv_historial.CurrentRow.Cells(4).Value.ToString()
        frm_historial.txt_problema.Text = dgv_historial.CurrentRow.Cells(5).Value.ToString()
        frm_historial.txt_detalles.Text = dgv_historial.CurrentRow.Cells(6).Value.ToString()
        frm_historial.txt_encargado.Text = dgv_historial.CurrentRow.Cells(7).Value.ToString()

        'Dim f As New frm_historial
        'f.ShowDialog()
        frm_historial.ShowDialog()


    End Sub


 
  

    Private Sub btn_nue_Click(sender As Object, e As EventArgs) Handles btn_nue.Click
        frm_nuetarea.ShowDialog()
    End Sub

    Private Sub Label29_DoubleClick(sender As Object, e As EventArgs) Handles Label29.DoubleClick
        frm_login.Show()
    End Sub

    Private Sub btn_mod_Click_1(sender As Object, e As EventArgs) Handles btn_mod.Click
        'seleccion de modulo a modificar 

        If rdb_alum.Checked = True Then
            frm_alumbrado.Show()
        ElseIf rdb_caja.Checked = True Then
            frm_caja.Show()
        ElseIf rdb_com.Checked = True Then

            frm_componentes.Show()
        Else
            frm_gabinete.Show()
        End If

    End Sub

End Class