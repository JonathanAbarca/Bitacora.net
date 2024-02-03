<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_calles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_calles))
        Me.dgv_vercalles = New System.Windows.Forms.DataGridView()
        Me.txt_idcalle = New System.Windows.Forms.TextBox()
        Me.txt_frmcalle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        CType(Me.dgv_vercalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_vercalles
        '
        Me.dgv_vercalles.AllowDrop = True
        Me.dgv_vercalles.AllowUserToAddRows = False
        Me.dgv_vercalles.AllowUserToDeleteRows = False
        Me.dgv_vercalles.AllowUserToOrderColumns = True
        Me.dgv_vercalles.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_vercalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_vercalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vercalles.EnableHeadersVisualStyles = False
        Me.dgv_vercalles.Location = New System.Drawing.Point(12, 125)
        Me.dgv_vercalles.Name = "dgv_vercalles"
        Me.dgv_vercalles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_vercalles.RowHeadersVisible = False
        Me.dgv_vercalles.ShowCellErrors = False
        Me.dgv_vercalles.ShowCellToolTips = False
        Me.dgv_vercalles.ShowEditingIcon = False
        Me.dgv_vercalles.ShowRowErrors = False
        Me.dgv_vercalles.Size = New System.Drawing.Size(141, 191)
        Me.dgv_vercalles.TabIndex = 0
        '
        'txt_idcalle
        '
        Me.txt_idcalle.Location = New System.Drawing.Point(40, 41)
        Me.txt_idcalle.MaxLength = 10
        Me.txt_idcalle.Name = "txt_idcalle"
        Me.txt_idcalle.Size = New System.Drawing.Size(83, 20)
        Me.txt_idcalle.TabIndex = 1
        '
        'txt_frmcalle
        '
        Me.txt_frmcalle.Location = New System.Drawing.Point(40, 92)
        Me.txt_frmcalle.MaxLength = 4
        Me.txt_frmcalle.Name = "txt_frmcalle"
        Me.txt_frmcalle.Size = New System.Drawing.Size(83, 20)
        Me.txt_frmcalle.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nº CALLE:"
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
        Me.btn_cerrar.TabIndex = 6
        Me.btn_cerrar.Text = "Cancelar"
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cerrar.UseVisualStyleBackColor = False
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
        Me.btn_guardar.TabIndex = 4
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = False
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
        Me.btn_nuevo.TabIndex = 5
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = False
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
        Me.btn_modificar.TabIndex = 3
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'frm_calles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(248, 328)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_frmcalle)
        Me.Controls.Add(Me.txt_idcalle)
        Me.Controls.Add(Me.dgv_vercalles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frm_calles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calles"
        CType(Me.dgv_vercalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_vercalles As System.Windows.Forms.DataGridView
    Friend WithEvents txt_idcalle As System.Windows.Forms.TextBox
    Friend WithEvents txt_frmcalle As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Private WithEvents btn_modificar As System.Windows.Forms.Button
End Class
