Imports System.Data
Imports System.Data.Odbc
Public Class frm_imprimirhis
    Dim nue_calles As New calles
    Dim nue_puntos As New puntos
    Dim nue_calle As New calles
    Private Sub frm_imprimirhis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conexiones()
        'Me.reportehis.Enabled = False
        compuntos()
        combocalles()
        btn_imprimir.Enabled = False

    End Sub
    Public Sub combocalles()
        'cb_calle.Items.Clear()
        cb_calle.DataSource = nue_calles.listarcalle()
        cb_calle.DisplayMember = "ncalle"
        cb_calle.ValueMember = "id_calles"
        'conectarme.Close()
    End Sub
    Sub compuntos()
        'cb_puntos.Items.Clear()
        cb_puntos.DataSource = nue_puntos.listarpuntos()
        cb_puntos.DisplayMember = "npunto"
        cb_puntos.ValueMember = "id_punto"
        'conectarme.Close()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        If cb_calle.Text = "" And cb_puntos.Text = "" Then
            MsgBox("Ingrese un dato", MsgBoxStyle.Information, "Información")
        Else

            mod_reportes.var_call = cb_calle.Text
            mod_reportes.var_pun = cb_puntos.Text
            nue_calle.listar_repor()
            ''=================LlENNO la Rejilla de datos==========================
            dataset.Clear()

            buscar = "select * From historial WHERE id_loc='" & mod_reportes.var_result & "'" ''Busco el Campo
            adapter = New Odbc.OdbcDataAdapter(buscar, conectarme)
            adapter.Fill(dataset, "bd_bitacora")
            DataGridView1.DataSource = dataset
            DataGridView1.DataMember = "bd_bitacora"
            columnas_dgv()
            btn_imprimir.Enabled = True
            'Me.reportehis.Enabled = True

        End If
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        Dim rpt As New reportehis '' Objeto crystal Reports
        Dim formulario As New frm_moshist '' Fromulario que contiene al Objeto CrystalReportViewer
        'mod_reportes.var_call = cb_calle.Text
        'mod_reportes.var_pun = cb_puntos.Text
        'nue_calle.listar_repor()
        dat.Clear()
        bus = "select * From historial WHERE id_loc='" & mod_reportes.var_result & "'"
        ada = New OdbcDataAdapter(bus, conectarme)
        ada.Fill(dat, "historial")

        rpt.SetDataSource(dat)
        formulario.CrystalReportViewer1.ReportSource = rpt
        formulario.CrystalReportViewer1.Dock = DockStyle.Fill

        Dim frmReporte As New Form()
        With frmReporte
            .Controls.Add(formulario.CrystalReportViewer1)
            .Text = "Reporte de Historial"
            .WindowState = FormWindowState.Maximized
            .ShowDialog()
        End With
        conectarme.Close()
    End Sub
    Private Sub columnas_dgv()
        'oculta y cambia los nombres de encabezado de la tabla 
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = False
        DataGridView1.Columns(2).HeaderText = "TURNO"
        DataGridView1.Columns(3).HeaderText = "GRUPO"
        DataGridView1.Columns(4).HeaderText = "FECHA"
        DataGridView1.Columns(5).HeaderText = "PROBLEMA"
        DataGridView1.Columns(6).HeaderText = "REGISTRO DEL PROBLEMA"
        DataGridView1.Columns(7).HeaderText = "RUT ENCARGADO"

        DataGridView1.Columns(2).Width = 50
        DataGridView1.Columns(3).Width = 70
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 90
        DataGridView1.Columns(6).Width = 246
        DataGridView1.Columns(7).Width = 100
    End Sub
End Class