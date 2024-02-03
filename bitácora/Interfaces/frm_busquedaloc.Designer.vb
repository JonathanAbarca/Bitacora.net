<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_busquedaloc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gb_busqueda = New System.Windows.Forms.GroupBox()
        Me.lbl_selecpunto = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgv_listarop = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_buscarcalle = New System.Windows.Forms.Button()
        Me.cb_buscalles = New System.Windows.Forms.ComboBox()
        Me.gb_busqueda.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_listarop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_busqueda
        '
        Me.gb_busqueda.BackColor = System.Drawing.Color.Transparent
        Me.gb_busqueda.Controls.Add(Me.cb_buscalles)
        Me.gb_busqueda.Controls.Add(Me.lbl_selecpunto)
        Me.gb_busqueda.Controls.Add(Me.PictureBox1)
        Me.gb_busqueda.Controls.Add(Me.dgv_listarop)
        Me.gb_busqueda.Controls.Add(Me.Label2)
        Me.gb_busqueda.Controls.Add(Me.btn_buscarcalle)
        Me.gb_busqueda.Location = New System.Drawing.Point(12, 12)
        Me.gb_busqueda.Name = "gb_busqueda"
        Me.gb_busqueda.Size = New System.Drawing.Size(322, 230)
        Me.gb_busqueda.TabIndex = 1
        Me.gb_busqueda.TabStop = False
        Me.gb_busqueda.Text = "BUSQUEDA"
        '
        'lbl_selecpunto
        '
        Me.lbl_selecpunto.AutoSize = True
        Me.lbl_selecpunto.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_selecpunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_selecpunto.Location = New System.Drawing.Point(62, 88)
        Me.lbl_selecpunto.Name = "lbl_selecpunto"
        Me.lbl_selecpunto.Size = New System.Drawing.Size(202, 18)
        Me.lbl_selecpunto.TabIndex = 66
        Me.lbl_selecpunto.Text = "Seleccionar punto de vaciado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(36, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 29)
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'dgv_listarop
        '
        Me.dgv_listarop.AllowUserToAddRows = False
        Me.dgv_listarop.AllowUserToDeleteRows = False
        Me.dgv_listarop.AllowUserToResizeColumns = False
        Me.dgv_listarop.AllowUserToResizeRows = False
        Me.dgv_listarop.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_listarop.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_listarop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_listarop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_listarop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_listarop.EnableHeadersVisualStyles = False
        Me.dgv_listarop.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_listarop.Location = New System.Drawing.Point(106, 89)
        Me.dgv_listarop.Name = "dgv_listarop"
        Me.dgv_listarop.RowHeadersVisible = False
        Me.dgv_listarop.ShowCellErrors = False
        Me.dgv_listarop.ShowCellToolTips = False
        Me.dgv_listarop.ShowEditingIcon = False
        Me.dgv_listarop.ShowRowErrors = False
        Me.dgv_listarop.Size = New System.Drawing.Size(102, 129)
        Me.dgv_listarop.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Nº Calle"
        '
        'btn_buscarcalle
        '
        Me.btn_buscarcalle.BackColor = System.Drawing.Color.Honeydew
        Me.btn_buscarcalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscarcalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscarcalle.Location = New System.Drawing.Point(180, 39)
        Me.btn_buscarcalle.Name = "btn_buscarcalle"
        Me.btn_buscarcalle.Size = New System.Drawing.Size(84, 28)
        Me.btn_buscarcalle.TabIndex = 60
        Me.btn_buscarcalle.Text = "BUSCAR"
        Me.btn_buscarcalle.UseVisualStyleBackColor = False
        '
        'cb_buscalles
        '
        Me.cb_buscalles.FormattingEnabled = True
        Me.cb_buscalles.Location = New System.Drawing.Point(101, 44)
        Me.cb_buscalles.Name = "cb_buscalles"
        Me.cb_buscalles.Size = New System.Drawing.Size(73, 21)
        Me.cb_buscalles.TabIndex = 67
        '
        'frm_busquedaloc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(347, 251)
        Me.Controls.Add(Me.gb_busqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_busquedaloc"
        Me.Text = "bitácora"
        Me.gb_busqueda.ResumeLayout(False)
        Me.gb_busqueda.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_listarop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_busqueda As System.Windows.Forms.GroupBox
    Private WithEvents dgv_listarop As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_buscarcalle As System.Windows.Forms.Button
    Friend WithEvents lbl_selecpunto As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cb_buscalles As System.Windows.Forms.ComboBox
End Class
