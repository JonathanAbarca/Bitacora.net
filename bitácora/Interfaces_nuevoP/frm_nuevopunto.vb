Imports MySql.Data.MySqlClient
Public Class frm_nuevopunto
    Dim nue_conexion As New conexion
    Dim nue_maestra As New maestra
    Dim nue_var As New variables
    Dim nue_calle As New calles
    Dim nue_punto As New puntos
    Dim nue_loc As New localizacion
    Dim nue_alum As New alumbrado
    Dim nue_caja As New caja_local
    Dim nue_sgab As New gabinete
    Dim nue_comin As New componentes
    Dim nue_hist As New historial
    Dim nue_ayudacom As New ayudacomponentes

    Private Sub frm_nuevopunto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_comentario.Enabled = False
        cargarMax()
        combocalles()
        compuntos()
        combocomponentes()
        btn_guardar.Enabled = False
        btn_limpiar.Enabled = False
        'cb_aldaba.Text = mod_maestra._id_selecion
    End Sub
    Public Sub combocalles()
        'cb_calle.Items.Clear()
        cb_callen.DataSource = nue_calle.listarcalle()
        cb_callen.DisplayMember = "ncalle"
        cb_callen.ValueMember = "id_calles"
        'conectarme.Close()
    End Sub
    Sub compuntos()
        'cb_puntos.Items.Clear()
        cb_puntosn.DataSource = nue_punto.listarpuntos()
        cb_puntosn.DisplayMember = "npunto"
        cb_puntosn.ValueMember = "id_punto"
        'conectarme.Close()
    End Sub

    'funcion para obtener e incrementar en 1 los ultimos numeros registrados de cada tabla en la base de datos 
    Public Sub cargarMax()

        'llamar de la tabla calles
        'nue_calle.comprovarid()
        'llamar de la tabla puntos
        'nue_punto.comprovarid()




        'maxcalle()
        'mod_calles.var_calles = _dtscalles.Tables("calles").Rows(0).Item("id_calles") + 1



        'maxpuntos()
        'mod_puntos.var_puntos = _dtspuntos.Tables("puntos").Rows(0).Item("id_punto") + 1


        'maximo de la tabla localizacion
        maxloc()
        mod_localizacion.nloc = _dtsloc.Tables("localizacion").Rows(0).Item("id_loc") + 1
        'maximo de la tabla alumbrado
        maxalum()
        mod_alumbrado._id_alum = _dtsalum.Tables("alumbrado").Rows(0).Item("id_alum") + 1
        'maximo de la tabla caja
        maxacaja()
        mod_caja._id_caja = _dtscaja.Tables("caja").Rows(0).Item("id_local") + 1
        'maximo de la tabla seguridad gabinete
        maxasgab()
        mod_gabinete._id_gab = _dtssgab.Tables("gabinete").Rows(0).Item("id_gabinete") + 1
        'maximo de la tabla componentes gabinete
        maxcompo()
        mod_componentes._id_com = _dtscompo.Tables("componentes").Rows(0).Item("id_componentes") + 1
        'maximo de la tabla componentes gabinete
        maxmaestra()
        mod_maestra._id_selecion = _dtsmaes.Tables("maestra").Rows(0).Item("id_enlaces") + 1
        'maximo de la tabla historial
        maxhis()
        mod_historial._id_his = _dtshis.Tables("historial").Rows(0).Item("id_his") + 1

    End Sub

    Private Sub btn_comprobar_Click(sender As Object, e As EventArgs) Handles btn_comprobar.Click
        nue_loc.verificarloc()
        'recordar comprobar si la calle o punto existen

        If mod_localizacion.verificar = False Then

            btn_guardar.Enabled = True
            btn_limpiar.Enabled = True
            gb_callepun.Enabled = False
        Else
            MessageBox.Show("LOS DATOS YA EXISTEN")
            cb_callen.Focus()
        End If

    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        'llamar de la tabla calles
        nue_calle.comprovarid()
        'llamar de la tabla puntos
        nue_punto.comprovarid()

        'accion del boton guardar que llama al modulo y clase alumbrado 
        If txt_foco.Text <> "" Then
            'cb_saldaba.Text <> "" And cb_scandado.Text <> "" And cb_schapa.Text <> "" And cb_sw.Text <> "" And txt_alim600v.Text <> ""
            'txt_cbprin.Text <> "" And txt_rlcbprin.Text <> "" And txt_cbbom.Text <> "" And txt_conbom.Text <> "" And txt_olbom.Text <> "" And txt_cbven.Text <> "" And txt_conven.Text <> "" And txt_olven.Text <> "" And txt_cbtrafo.Text <> "" And txt_trafo600.Text <> "" And txt_trafo220.Text <> "" And txt_cbenh.Text <> "" And txt_enh.Text <> ""

            nue_loc.nuevo(mod_calles.var_calles, mod_puntos.pvar_puntos, mod_localizacion.nloc)
            nue_alum.nuevo(mod_alumbrado._id_alum, txt_foco.Text, cb_alim.Text)
            nue_caja.nuevo(mod_caja._id_caja, cb_aldaba.Text, cb_candado.Text, cb_chapa.Text, cb_en60.Text, cb_en30.Text, cb_en35.Text)
            nue_sgab.nuevo(mod_gabinete._id_gab, cb_saldaba.Text, cb_scandado.Text, cb_schapa.Text, cb_sw.Text, cb_alimgene.Text)

            nue_comin.nuevo()

            nue_maestra.modificarfecha(mod_maestra.fecha)
            nue_maestra.nuevo(mod_maestra._id_selecion, mod_localizacion.nloc, mod_alumbrado._id_alum, mod_caja._id_caja, mod_gabinete._id_gab, mod_componentes._id_com, mod_maestra.fecha.ToString)
            nue_hist.nuevo(mod_maestra.fecha, txt_grupo.Text, txt_turno.Text, txt_comentario.Text, mod_localizacion.nloc, mod_usuario.id_usuario)
            'id_his 	id_loc 	turno 	grupo 	fecha 	tipo_pro 	comentario 	id_usuario
            MessageBox.Show("SE HAN GUARDADO LOS DATOS")
            Me.Close()
        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")

        End If
    End Sub
    Public Sub combocomponentes()
        'cb_calle.Items.Clear()
        cb_alim.DataSource = nue_ayudacom.listar()
        cb_alim.DisplayMember = "tipo"
        cb_alim.ValueMember = "id"


        cb_alimgene.DataSource = nue_ayudacom.listar()
        cb_alimgene.DisplayMember = "tipo"
        cb_alimgene.ValueMember = "id"

        cb_cbprin.DataSource = nue_ayudacom.listar()
        cb_cbprin.DisplayMember = "tipo"
        cb_cbprin.ValueMember = "id"

        cb_reledifprin.DataSource = nue_ayudacom.listar()
        cb_reledifprin.DisplayMember = "tipo"
        cb_reledifprin.ValueMember = "id"

        cb_cbvent.DataSource = nue_ayudacom.listar()
        cb_cbvent.DisplayMember = "tipo"
        cb_cbvent.ValueMember = "id"

        cb_convent.DataSource = nue_ayudacom.listar()
        cb_convent.DisplayMember = "tipo"
        cb_convent.ValueMember = "id"

        cb_olvent.DataSource = nue_ayudacom.listar()
        cb_olvent.DisplayMember = "tipo"
        cb_olvent.ValueMember = "id"

        cb_cbbomh.DataSource = nue_ayudacom.listar()
        cb_cbbomh.DisplayMember = "tipo"
        cb_cbbomh.ValueMember = "id"

        cb_conbom.DataSource = nue_ayudacom.listar()
        cb_conbom.DisplayMember = "tipo"
        cb_conbom.ValueMember = "id"

        cb_olbom.DataSource = nue_ayudacom.listar()
        cb_olbom.DisplayMember = "tipo"
        cb_olbom.ValueMember = "id"

        cb_cbtra600.DataSource = nue_ayudacom.listar()
        cb_cbtra600.DisplayMember = "tipo"
        cb_cbtra600.ValueMember = "id"

        cb_trafo600.DataSource = nue_ayudacom.listar()
        cb_trafo600.DisplayMember = "tipo"
        cb_trafo600.ValueMember = "id"

        cb_trafo220.DataSource = nue_ayudacom.listar()
        cb_trafo220.DisplayMember = "tipo"
        cb_trafo220.ValueMember = "id"

        cb_cbenh.DataSource = nue_ayudacom.listar()
        cb_cbenh.DisplayMember = "tipo"
        cb_cbenh.ValueMember = "id"

        cb_enh.DataSource = nue_ayudacom.listar()
        cb_enh.DisplayMember = "tipo"
        cb_enh.ValueMember = "id"

        'conectarme.Close()
    End Sub


End Class