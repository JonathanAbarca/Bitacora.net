<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_histareasex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_histareasex))
        Me.dgv_tareasex = New System.Windows.Forms.DataGridView()
        Me.gb_tex = New System.Windows.Forms.GroupBox()
        Me.txt_problemaex = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txt_grupoex = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_turnoex = New System.Windows.Forms.TextBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.dtp_fechaex = New System.Windows.Forms.DateTimePicker()
        Me.txt_nomex = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.txt_comentarioex = New System.Windows.Forms.TextBox()
        Me.gb_tarext = New System.Windows.Forms.GroupBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        CType(Me.dgv_tareasex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_tex.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_tarext.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_tareasex
        '
        Me.dgv_tareasex.AllowUserToAddRows = False
        Me.dgv_tareasex.AllowUserToDeleteRows = False
        Me.dgv_tareasex.AllowUserToResizeColumns = False
        Me.dgv_tareasex.AllowUserToResizeRows = False
        Me.dgv_tareasex.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_tareasex.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv_tareasex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tareasex.GridColor = System.Drawing.SystemColors.Control
        Me.dgv_tareasex.Location = New System.Drawing.Point(12, 382)
        Me.dgv_tareasex.Name = "dgv_tareasex"
        Me.dgv_tareasex.RowHeadersVisible = False
        Me.dgv_tareasex.ShowCellErrors = False
        Me.dgv_tareasex.ShowCellToolTips = False
        Me.dgv_tareasex.ShowEditingIcon = False
        Me.dgv_tareasex.ShowRowErrors = False
        Me.dgv_tareasex.Size = New System.Drawing.Size(535, 178)
        Me.dgv_tareasex.TabIndex = 0
        '
        'gb_tex
        '
        Me.gb_tex.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gb_tex.Controls.Add(Me.txt_problemaex)
        Me.gb_tex.Controls.Add(Me.Label3)
        Me.gb_tex.Controls.Add(Me.PictureBox5)
        Me.gb_tex.Controls.Add(Me.txt_grupoex)
        Me.gb_tex.Controls.Add(Me.Label10)
        Me.gb_tex.Controls.Add(Me.PictureBox4)
        Me.gb_tex.Controls.Add(Me.Label12)
        Me.gb_tex.Controls.Add(Me.txt_turnoex)
        Me.gb_tex.Controls.Add(Me.PictureBox10)
        Me.gb_tex.Controls.Add(Me.dtp_fechaex)
        Me.gb_tex.Controls.Add(Me.txt_nomex)
        Me.gb_tex.Controls.Add(Me.Label2)
        Me.gb_tex.Controls.Add(Me.PictureBox2)
        Me.gb_tex.Controls.Add(Me.Label1)
        Me.gb_tex.Controls.Add(Me.PictureBox1)
        Me.gb_tex.Controls.Add(Me.Label17)
        Me.gb_tex.Controls.Add(Me.PictureBox11)
        Me.gb_tex.Controls.Add(Me.txt_comentarioex)
        Me.gb_tex.Location = New System.Drawing.Point(12, 12)
        Me.gb_tex.Name = "gb_tex"
        Me.gb_tex.Size = New System.Drawing.Size(535, 270)
        Me.gb_tex.TabIndex = 1125
        Me.gb_tex.TabStop = False
        Me.gb_tex.Text = "NUEVA TAREA"
        '
        'txt_problemaex
        '
        Me.txt_problemaex.FormattingEnabled = True
        Me.txt_problemaex.Items.AddRange(New Object() {"FALLA", "MODIFICACIÓN"})
        Me.txt_problemaex.Location = New System.Drawing.Point(106, 129)
        Me.txt_problemaex.Name = "txt_problemaex"
        Me.txt_problemaex.Size = New System.Drawing.Size(92, 21)
        Me.txt_problemaex.TabIndex = 119
        Me.txt_problemaex.Text = "Tipo tarea"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "TAREA:"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PictureBox5.Location = New System.Drawing.Point(27, 119)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(194, 40)
        Me.PictureBox5.TabIndex = 117
        Me.PictureBox5.TabStop = False
        '
        'txt_grupoex
        '
        Me.txt_grupoex.Location = New System.Drawing.Point(106, 83)
        Me.txt_grupoex.Name = "txt_grupoex"
        Me.txt_grupoex.Size = New System.Drawing.Size(92, 20)
        Me.txt_grupoex.TabIndex = 116
        Me.txt_grupoex.Text = "Nº Grupo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(40, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 16)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "GRUPO:"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PictureBox4.Location = New System.Drawing.Point(27, 73)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(194, 40)
        Me.PictureBox4.TabIndex = 114
        Me.PictureBox4.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(40, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 16)
        Me.Label12.TabIndex = 113
        Me.Label12.Text = "TURNO:"
        '
        'txt_turnoex
        '
        Me.txt_turnoex.Location = New System.Drawing.Point(106, 37)
        Me.txt_turnoex.Name = "txt_turnoex"
        Me.txt_turnoex.Size = New System.Drawing.Size(92, 20)
        Me.txt_turnoex.TabIndex = 112
        Me.txt_turnoex.Text = "Nº Turno"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PictureBox10.Location = New System.Drawing.Point(27, 27)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(194, 40)
        Me.PictureBox10.TabIndex = 111
        Me.PictureBox10.TabStop = False
        '
        'dtp_fechaex
        '
        Me.dtp_fechaex.Location = New System.Drawing.Point(307, 85)
        Me.dtp_fechaex.Name = "dtp_fechaex"
        Me.dtp_fechaex.Size = New System.Drawing.Size(208, 20)
        Me.dtp_fechaex.TabIndex = 110
        '
        'txt_nomex
        '
        Me.txt_nomex.Location = New System.Drawing.Point(307, 38)
        Me.txt_nomex.Name = "txt_nomex"
        Me.txt_nomex.Size = New System.Drawing.Size(208, 20)
        Me.txt_nomex.TabIndex = 109
        Me.txt_nomex.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(231, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "FECHA:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PictureBox2.Location = New System.Drawing.Point(227, 73)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(302, 40)
        Me.PictureBox2.TabIndex = 96
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "NOMBRE:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PictureBox1.Location = New System.Drawing.Point(227, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(302, 40)
        Me.PictureBox1.TabIndex = 93
        Me.PictureBox1.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(40, 174)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 16)
        Me.Label17.TabIndex = 92
        Me.Label17.Text = "Descripción:"
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PictureBox11.Location = New System.Drawing.Point(27, 168)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(144, 27)
        Me.PictureBox11.TabIndex = 91
        Me.PictureBox11.TabStop = False
        '
        'txt_comentarioex
        '
        Me.txt_comentarioex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_comentarioex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comentarioex.Location = New System.Drawing.Point(27, 195)
        Me.txt_comentarioex.Multiline = True
        Me.txt_comentarioex.Name = "txt_comentarioex"
        Me.txt_comentarioex.Size = New System.Drawing.Size(502, 64)
        Me.txt_comentarioex.TabIndex = 53
        '
        'gb_tarext
        '
        Me.gb_tarext.Controls.Add(Me.btn_guardar)
        Me.gb_tarext.Controls.Add(Me.btn_editar)
        Me.gb_tarext.Location = New System.Drawing.Point(173, 288)
        Me.gb_tarext.Name = "gb_tarext"
        Me.gb_tarext.Size = New System.Drawing.Size(209, 88)
        Me.gb_tarext.TabIndex = 1126
        Me.gb_tarext.TabStop = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_guardar.Location = New System.Drawing.Point(120, 18)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(82, 57)
        Me.btn_guardar.TabIndex = 1118
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(6, 18)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(82, 57)
        Me.btn_editar.TabIndex = 1119
        Me.btn_editar.Text = "Modificar"
        Me.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'frm_histareasex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(559, 572)
        Me.Controls.Add(Me.gb_tarext)
        Me.Controls.Add(Me.gb_tex)
        Me.Controls.Add(Me.dgv_tareasex)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_histareasex"
        Me.Text = "Tareas externas"
        CType(Me.dgv_tareasex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_tex.ResumeLayout(False)
        Me.gb_tex.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_tarext.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_tareasex As System.Windows.Forms.DataGridView
    Friend WithEvents gb_tex As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_comentarioex As System.Windows.Forms.TextBox
    Friend WithEvents dtp_fechaex As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_nomex As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_turnoex As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_grupoex As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_problemaex As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents gb_tarext As System.Windows.Forms.GroupBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
End Class
