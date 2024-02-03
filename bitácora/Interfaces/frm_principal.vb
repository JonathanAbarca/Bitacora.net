Imports MySql.Data.MySqlClient
Public Class frm_principal
    Dim nue_liscalle As New calles
    Dim nue_usu As New usuario
    Dim nue_man As New mantencion
    Dim esta_var As Integer

    Public var_login As Boolean = False

    Private Sub frm_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mnu_usu.Visible = False
        'Centrar el Panel
        Dim desktopSize As Size = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        'Captura el Tamaño del Monitor
        Dim ancho As Int32 = (Me.Width - Panel5.Width) / 2
        Panel5.Location = New Point(ancho, Panel5.Location.Y)
        'cargar dgv de mantenciones
        actmantencion()
        columnas_dgvman()
        'carga los componentes del formualrio principal
        Timer1.Start()
        Timer1.Interval = 1000

        deslogeado()


    End Sub

    Public Sub abrir_en_panel(ByVal form_hijo As Object, ByVal panel As Panel)
        'clase para mostrar los demas formularios en el panel principal
        panel.Controls.Clear()
        Dim form As Form = CType(form_hijo, Form)
        form.TopLevel = False
        panel.Controls.Add(form)
        form.Show()
        'abrir_en_panel(frm_liscompo, pnl_body)
    End Sub


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'llamar al relog del computador y lo muetra en la etiqueta
        lb_clock.Text = My.Computer.Clock.LocalTime.ToString
        mod_maestra.fecha = My.Computer.Clock.LocalTime.ToString

        Dim fechacreacion As Date
        fechacreacion = lb_clock.Text
        mod_mantencion.var_confecha = Format(fechacreacion, "yyyy/MM/dd")

        
    End Sub

    Public Sub deslogeado()
        If var_login = False Then
            'sin usuario en sistema
            frm_liscompo.btn_nue.Enabled = False
            frm_histareasex.gb_tarext.Enabled = False
            frm_mantenciones.gb_maning.Enabled = False
            frm_liscompo.gb_modificar.Visible = False
            mod_mantencion.var_log = False
            lbl_usuario.Visible = False
            mnu_usu.Visible = False
            lkbl_inisesion.Visible = True
            frm_historial.gb_manhistorial.Visible = False
        ElseIf var_login = True Then
            frm_liscompo.btn_nue.Enabled = True
            frm_mantenciones.gb_maning.Enabled = True
            frm_histareasex.gb_tarext.Enabled = True
            'con usuario en sistema
            frm_liscompo.gb_modificar.Visible = True
            mod_mantencion.var_log = True
            nue_usu.listar_usuario()
            item_nombre.Text = mod_usuario.nom_usu.ToString + " " + mod_usuario.ape_usu.ToString
            mnu_usu.Visible = True
            lkbl_inisesion.Visible = False
            frm_historial.gb_manhistorial.Visible = True
        End If

    End Sub
    Public Sub actmantencion()
        'listar datos de mantenciones
        dgv_pxman.DataSource = nue_man.listar()
        
    End Sub
    Sub columnas_dgvman()
        'oculta y cambia los nombres de encabezado de la tabla 
        dgv_pxman.Columns(0).Visible = False
        dgv_pxman.Columns(1).Visible = False
        dgv_pxman.Columns(2).HeaderText = "OBSERVACIONES"
        dgv_pxman.Columns(3).HeaderText = "F. INICIO"
        dgv_pxman.Columns(2).Width = 150
        dgv_pxman.Columns(3).Width = 85
        dgv_pxman.Columns(4).Visible = False
        dgv_pxman.Columns(5).Visible = False
        dgv_pxman.Columns(6).Visible = False
        dgv_pxman.Columns(7).Visible = False
        dgv_pxman.Columns(8).Visible = False


    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        'minimizar sistema
        Me.WindowState = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'cerrar programa
        Me.Close()
        End
    End Sub


    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        frm_busquedaloc.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        abrir_en_panel(frm_nuevopunto, pnl_body)
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        abrir_en_panel(frm_tareasex, pnl_body)
    End Sub

    Private Sub ComEspecialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComEspecialToolStripMenuItem.Click
        abrir_en_panel(frm_histareasex, pnl_body)
    End Sub

    Private Sub MantencionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantencionesToolStripMenuItem.Click
        abrir_en_panel(frm_mantenciones, pnl_body)
    End Sub

    Public Sub dgv_pxman_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pxman.CellDoubleClick
        'llamar los datos de la celda haciendo doble click y cargarlos en formulario manrealizadas
        abrir_en_panel(frm_manrealizada, pnl_body)
        mod_mantencion.var_idmanre = dgv_pxman.CurrentRow.Cells(0).Value.ToString()
        mod_mantencion.ver_loc = dgv_pxman.CurrentRow.Cells(1).Value.ToString()
        nue_man.listar_loc()
        frm_manrealizada.lbl_ffini.Text = dgv_pxman.CurrentRow.Cells(3).Value.ToString()
        frm_manrealizada.lbl_fturno.Text = dgv_pxman.CurrentRow.Cells(6).Value.ToString()
        frm_manrealizada.lbl_ffter.Text = dgv_pxman.CurrentRow.Cells(4).Value.ToString()
        frm_manrealizada.lbl_festado.Text = dgv_pxman.CurrentRow.Cells(8).Value.ToString()
        frm_manrealizada.lbl_fcalle.Text = mod_mantencion.var_calle.ToString
        frm_manrealizada.lbl_fpunto.Text = mod_mantencion.var_punto.ToString


    End Sub

    Private Sub FechaMantenciónToolStripMenuItem_Click(sender As Object, e As EventArgs)

        abrir_en_panel(frm_alertas, pnl_body)

    End Sub

    Private Sub lkbl_inisesion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkbl_inisesion.LinkClicked
        'boton de inicio de sesion
        frm_login.ShowDialog()
    End Sub

    Private Sub item_cerrarsesion_Click(sender As Object, e As EventArgs) Handles item_cerrarsesion.Click
        'boton de cerrado de sesion
        var_login = False
        mod_mantencion.var_log = False
        frm_manrealizada.verificar()
        deslogeado()
        Me.pnl_body.Controls.Clear()
        MsgBox("Ha salido de sesión")

    End Sub

    Private Sub VerMisDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerMisDatosToolStripMenuItem.Click
        Me.abrir_en_panel(frm_usuario, pnl_body)
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        Me.abrir_en_panel(frm_imprimirhis, pnl_body)
    End Sub

  
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles in_calles.Click
        Me.abrir_en_panel(frm_calles, pnl_body)
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Me.abrir_en_panel(frm_puntos, pnl_body)
    End Sub
End Class
