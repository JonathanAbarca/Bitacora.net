Imports MySql.Data.MySqlClient
Public Class frm_busquedaloc
    Dim nue_liscalle As New calles

    Private Sub frm_busquedaloc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_buscalles.DataSource = nue_liscalle.listarcalle()
        cb_buscalles.DisplayMember = "ncalle"
        cb_buscalles.ValueMember = "id_calles"
    End Sub
    Private Sub btn_buscarcalle_Click(sender As Object, e As EventArgs) Handles btn_buscarcalle.Click
        'buscar en base de datos el punto segun sea la calle ingresada
        If cb_buscalles.Text <> "" Then
            Try


                dgv_listarop.DataSource = nue_liscalle.listar()
                ocultar_celdas()
                lbl_selecpunto.Visible = True
                dgv_listarop.Visible = True


            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("Ingrese una calle")
            cb_buscalles.Focus()
        End If

    End Sub
    Public Sub ocultar_celdas()
        'evento que oculta las columnas que no se mostraran en el datagridview listar punto de vaciado
        dgv_listarop.Columns(0).Visible = False
        dgv_listarop.Columns(1).Visible = False
        dgv_listarop.Columns(2).Visible = False
        dgv_listarop.Columns(3).Visible = False
        dgv_listarop.Columns(4).Visible = False
        dgv_listarop.Columns(5).Visible = False
        dgv_listarop.Columns(6).HeaderText = " "
    End Sub
    Private Sub dgv_listarop_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_listarop.CellDoubleClick
        'funcion para obtener los datos de la consulta en la base de datos 
        frm_liscompo.lbl_nbcalle.Text = dgv_listarop.CurrentRow.Cells(4).Value.ToString()
        frm_liscompo.lbl_nbop.Text = dgv_listarop.CurrentRow.Cells(6).Value.ToString()
        mod_maestra.id_selecion = dgv_listarop.CurrentRow.Cells(0).Value.ToString()

        frm_principal.abrir_en_panel(frm_liscompo, frm_principal.pnl_body)

        frm_liscompo.actializar_dgv()
        Me.Close()
    End Sub
End Class