<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_puntos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_puntos))
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_frmpunto = New System.Windows.Forms.TextBox()
        Me.txt_idpunto = New System.Windows.Forms.TextBox()
        Me.dgv_verpuntos = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_verpuntos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.LightCyan
        Me.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_modificar.Image = CType(resources.GetObject("btn_modificar.Image"), System.Drawing.Image)
        Me.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_modificar.Location = New System.Drawing.Point(172, 35)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(58, 54)
        Me.btn_modificar.TabIndex = 10
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.LightCyan
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(172, 155)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(58, 54)
        Me.btn_nuevo.TabIndex = 14
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.LightCyan
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_guardar.Location = New System.Drawing.Point(172, 95)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(58, 54)
        Me.btn_guardar.TabIndex = 12
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.MistyRose
        Me.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cerrar.Location = New System.Drawing.Point(172, 241)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(58, 54)
        Me.btn_cerrar.TabIndex = 15
        Me.btn_cerrar.Text = "Cancelar"
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nº PUNTO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID:"
        '
        'txt_frmpunto
        '
        Me.txt_frmpunto.Location = New System.Drawing.Point(40, 92)
        Me.txt_frmpunto.MaxLength = 4
        Me.txt_frmpunto.Name = "txt_frmpunto"
        Me.txt_frmpunto.Size = New System.Drawing.Size(83, 20)
        Me.txt_frmpunto.TabIndex = 9
        '
        'txt_idpunto
        '
        Me.txt_idpunto.Location = New System.Drawing.Point(40, 41)
        Me.txt_idpunto.MaxLength = 10
        Me.txt_idpunto.Name = "txt_idpunto"
        Me.txt_idpunto.Size = New System.Drawing.Size(83, 20)
        Me.txt_idpunto.TabIndex = 8
        '
        'dgv_verpuntos
        '
        Me.dgv_verpuntos.AllowDrop = True
        Me.dgv_verpuntos.AllowUserToAddRows = False
        Me.dgv_verpuntos.AllowUserToDeleteRows = False
        Me.dgv_verpuntos.AllowUserToOrderColumns = True
        Me.dgv_verpuntos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_verpuntos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_verpuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_verpuntos.EnableHeadersVisualStyles = False
        Me.dgv_verpuntos.Location = New System.Drawing.Point(12, 125)
        Me.dgv_verpuntos.Name = "dgv_verpuntos"
        Me.dgv_verpuntos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_verpuntos.RowHeadersVisible = False
        Me.dgv_verpuntos.ShowCellErrors = False
        Me.dgv_verpuntos.ShowCellToolTips = False
        Me.dgv_verpuntos.ShowEditingIcon = False
        Me.dgv_verpuntos.ShowRowErrors = False
        Me.dgv_verpuntos.Size = New System.Drawing.Size(141, 191)
        Me.dgv_verpuntos.TabIndex = 7
        '
        'frm_puntos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(248, 328)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_frmpunto)
        Me.Controls.Add(Me.txt_idpunto)
        Me.Controls.Add(Me.dgv_verpuntos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frm_puntos"
        Me.Text = "Puntos de Vaciado"
        CType(Me.dgv_verpuntos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_frmpunto As System.Windows.Forms.TextBox
    Friend WithEvents txt_idpunto As System.Windows.Forms.TextBox
    Friend WithEvents dgv_verpuntos As System.Windows.Forms.DataGridView
End Class
