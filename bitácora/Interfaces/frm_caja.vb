Public Class frm_caja
    Dim nue_caja As New caja_local
    Dim nue_maestra As New maestra
    Private Sub frm_caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'carga los datos desde el formulario listas caja local
        cb_aldaba.Text = frm_liscompo.lbl_caldaba.Text.ToString
        cb_candado.Text = frm_liscompo.lbl_ccandado.Text.ToString
        cb_chapa.Text = frm_liscompo.lbl_cchapa.Text.ToString
        cb_en60.Text = frm_liscompo.lbl_enchufe60.Text.ToString
        cb_en30.Text = frm_liscompo.lbl_enchufe30.Text.ToString
        cb_en35.Text = frm_liscompo.lbl_enchufe35.Text.ToString
        combos()
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If cb_aldaba.Text <> "" And cb_candado.Text <> "" And cb_chapa.Text <> "" And cb_en60.Text <> "" And cb_en30.Text <> "" And cb_en35.Text <> "" Then

            mod_caja.aldaba = cb_aldaba.Text.ToString
            mod_caja.candado = cb_candado.Text.ToString
            mod_caja.chapa = cb_chapa.Text.ToString
            mod_caja.en60 = cb_en60.Text.ToString
            mod_caja.en30 = cb_en30.Text.ToString
            mod_caja.en35 = cb_en35.Text.ToString

            nue_caja.modificar(mod_caja.aldaba, mod_caja.candado, mod_caja.chapa, mod_caja.en60, mod_caja.en30, mod_caja.en35)
            nue_maestra.modificarfecha(mod_maestra.fecha)
            frm_liscompo.actializar_dgv()
            MessageBox.Show("SE HAN MODIFICADO LOS DATOS")
            Me.Close()



        Else
            MessageBox.Show("FALTAN CAMPOS POR LLENAR")

        End If
    End Sub

    Private Sub combos()
        'propiedad para mostrar solamente el dato opuesto al registro 
        If cb_aldaba.Text = "SI" Then

            cb_aldaba.Items.Add("NO")

        ElseIf cb_aldaba.Text = "NO" Then

            cb_aldaba.Items.Add("SI")

        Else
            If cb_aldaba.Text = " " Then
                cb_aldaba.Items.Add("SI")
                cb_aldaba.Items.Add("NO")
            End If
        End If

        If cb_candado.Text = "SI" Then

            cb_candado.Items.Add("NO")

        ElseIf cb_candado.Text = "NO" Then

            cb_candado.Items.Add("SI")

        Else
            If cb_candado.Text = " " Then
                cb_candado.Items.Add("SI")
                cb_candado.Items.Add("NO")
            End If
        End If

        If cb_chapa.Text = "SI" Then

            cb_chapa.Items.Add("NO")

        ElseIf cb_chapa.Text = "NO" Then

            cb_chapa.Items.Add("SI")

        Else
            If cb_chapa.Text = " " Then
                cb_chapa.Items.Add("SI")
                cb_chapa.Items.Add("NO")
            End If
        End If
        If cb_en60.Text = "SI" Then

            cb_en60.Items.Add("NO")

        ElseIf cb_en60.Text = "NO" Then

            cb_en60.Items.Add("SI")

        Else
            If cb_en60.Text = " " Then
                cb_en60.Items.Add("SI")
                cb_en60.Items.Add("NO")
            End If
        End If
        If cb_en30.Text = "SI" Then

            cb_en30.Items.Add("NO")

        ElseIf cb_en30.Text = "NO" Then

            cb_en30.Items.Add("SI")

        Else
            If cb_en30.Text = " " Then
                cb_en30.Items.Add("SI")
                cb_en30.Items.Add("NO")
            End If
        End If
        If cb_en35.Text = "SI" Then

            cb_en35.Items.Add("NO")

        ElseIf cb_en35.Text = "NO" Then

            cb_en35.Items.Add("SI")

        Else
            If cb_en35.Text = " " Then
                cb_en35.Items.Add("SI")
                cb_en35.Items.Add("NO")
            End If
        End If
    End Sub
End Class