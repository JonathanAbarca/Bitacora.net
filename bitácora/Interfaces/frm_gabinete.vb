Public Class frm_gabinete
    Dim nue_gab As New gabinete
    Dim nue_maestra As New maestra
    Private Sub frm_gabinete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'carga los datos desde el formulario listas componentes
        cb_aldaba.Text = frm_liscompo.lbl_galdaba.Text.ToString
        cb_candado.Text = frm_liscompo.lbl_gcandado.Text.ToString
        cb_chapa.Text = frm_liscompo.lbl_gchapa.Text.ToString
        cb_sw.Text = frm_liscompo.lbl_sw.Text.ToString
        txt_alim600v.Text = frm_liscompo.lbl_g600v.Text.ToString
        combos()
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        'accion del boton guardar que llama al modulo y clase alumbrado 
        If cb_aldaba.Text <> "" And cb_candado.Text <> "" And cb_chapa.Text <> "" And cb_sw.Text <> "" And txt_alim600v.Text <> "" Then

            mod_gabinete.va_aldaba = cb_aldaba.Text.ToString
            mod_gabinete.va_candado = cb_candado.Text.ToString
            mod_gabinete.va_chapa = cb_chapa.Text.ToString
            mod_gabinete.va_sw = cb_sw.Text.ToString
            mod_gabinete.va_alim600 = txt_alim600v.Text.ToString

            nue_gab.modificar(mod_gabinete.va_aldaba, mod_gabinete.va_candado, mod_gabinete.va_chapa, mod_gabinete.va_sw, mod_gabinete.va_alim600)
            nue_maestra.modificarfecha(mod_maestra.fecha)
            frm_liscompo.actializar_dgv()
            MessageBox.Show("SE HAN MODIFICADO LOS DATOS")
            frm_principal.Show()




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
        If cb_sw.Text = "SI" Then

            cb_sw.Items.Add("NO")

        ElseIf cb_sw.Text = "NO" Then

            cb_sw.Items.Add("SI")

        Else
            If cb_sw.Text = " " Then
                cb_sw.Items.Add("SI")
                cb_sw.Items.Add("NO")
            End If
        End If

    End Sub





End Class