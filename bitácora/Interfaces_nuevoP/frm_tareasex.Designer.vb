<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tareasex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tareasex))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cb_tareaex = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.gb_manhistorial = New System.Windows.Forms.GroupBox()
        Me.btn_cancelarex = New System.Windows.Forms.Button()
        Me.btn_guardarex = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.txt_grupoex = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_turnoex = New System.Windows.Forms.TextBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.txt_comentarioex = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lbl_nombreex = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lbl_fechaex = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_manhistorial.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lbl_fechaex)
        Me.GroupBox5.Controls.Add(Me.PictureBox5)
        Me.GroupBox5.Controls.Add(Me.lbl_nombreex)
        Me.GroupBox5.Controls.Add(Me.PictureBox4)
        Me.GroupBox5.Controls.Add(Me.cb_tareaex)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.PictureBox3)
        Me.GroupBox5.Controls.Add(Me.gb_manhistorial)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.PictureBox2)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.PictureBox11)
        Me.GroupBox5.Controls.Add(Me.txt_grupoex)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.PictureBox9)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.txt_turnoex)
        Me.GroupBox5.Controls.Add(Me.PictureBox7)
        Me.GroupBox5.Controls.Add(Me.txt_comentarioex)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(434, 382)
        Me.GroupBox5.TabIndex = 1124
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "NUEVA TAREA"
        '
        'cb_tareaex
        '
        Me.cb_tareaex.FormattingEnabled = True
        Me.cb_tareaex.Items.AddRange(New Object() {"FALLA", "MODIFICACIÓN"})
        Me.cb_tareaex.Location = New System.Drawing.Point(103, 135)
        Me.cb_tareaex.Name = "cb_tareaex"
        Me.cb_tareaex.Size = New System.Drawing.Size(107, 21)
        Me.cb_tareaex.TabIndex = 104
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "TAREA"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PictureBox3.Location = New System.Drawing.Point(22, 124)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(194, 40)
        Me.PictureBox3.TabIndex = 102
        Me.PictureBox3.TabStop = False
        '
        'gb_manhistorial
        '
        Me.gb_manhistorial.Controls.Add(Me.btn_cancelarex)
        Me.gb_manhistorial.Controls.Add(Me.btn_guardarex)
        Me.gb_manhistorial.Location = New System.Drawing.Point(103, 286)
        Me.gb_manhistorial.Name = "gb_manhistorial"
        Me.gb_manhistorial.Size = New System.Drawing.Size(228, 85)
        Me.gb_manhistorial.TabIndex = 99
        Me.gb_manhistorial.TabStop = False
        '
        'btn_cancelarex
        '
        Me.btn_cancelarex.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_cancelarex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancelarex.Image = CType(resources.GetObject("btn_cancelarex.Image"), System.Drawing.Image)
        Me.btn_cancelarex.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelarex.Location = New System.Drawing.Point(140, 19)
        Me.btn_cancelarex.Name = "btn_cancelarex"
        Me.btn_cancelarex.Size = New System.Drawing.Size(82, 57)
        Me.btn_cancelarex.TabIndex = 1114
        Me.btn_cancelarex.Text = "Cerrar"
        Me.btn_cancelarex.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelarex.UseVisualStyleBackColor = False
        '
        'btn_guardarex
        '
        Me.btn_guardarex.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_guardarex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardarex.Image = CType(resources.GetObject("btn_guardarex.Image"), System.Drawing.Image)
        Me.btn_guardarex.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_guardarex.Location = New System.Drawing.Point(6, 19)
        Me.btn_guardarex.Name = "btn_guardarex"
        Me.btn_guardarex.Size = New System.Drawing.Size(82, 57)
        Me.btn_guardarex.TabIndex = 1113
        Me.btn_guardarex.Text = "Guardar"
        Me.btn_guardarex.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardarex.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(226, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "FECHA:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PictureBox2.Location = New System.Drawing.Point(222, 77)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(206, 40)
        Me.PictureBox2.TabIndex = 96
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "NOMBRE:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PictureBox1.Location = New System.Drawing.Point(222, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 40)
        Me.PictureBox1.TabIndex = 93
        Me.PictureBox1.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(34, 175)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 16)
        Me.Label17.TabIndex = 92
        Me.Label17.Text = "Descripción:"
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PictureBox11.Location = New System.Drawing.Point(22, 170)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(194, 27)
        Me.PictureBox11.TabIndex = 91
        Me.PictureBox11.TabStop = False
        '
        'txt_grupoex
        '
        Me.txt_grupoex.Enabled = False
        Me.txt_grupoex.Location = New System.Drawing.Point(122, 87)
        Me.txt_grupoex.Name = "txt_grupoex"
        Me.txt_grupoex.Size = New System.Drawing.Size(71, 20)
        Me.txt_grupoex.TabIndex = 90
        Me.txt_grupoex.Text = "Nº Grupo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 16)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "GRUPO:"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PictureBox9.Location = New System.Drawing.Point(22, 77)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(194, 40)
        Me.PictureBox9.TabIndex = 88
        Me.PictureBox9.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(35, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 16)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "TURNO:"
        '
        'txt_turnoex
        '
        Me.txt_turnoex.Enabled = False
        Me.txt_turnoex.Location = New System.Drawing.Point(122, 41)
        Me.txt_turnoex.Name = "txt_turnoex"
        Me.txt_turnoex.Size = New System.Drawing.Size(71, 20)
        Me.txt_turnoex.TabIndex = 86
        Me.txt_turnoex.Text = "A"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PictureBox7.Location = New System.Drawing.Point(22, 31)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(194, 40)
        Me.PictureBox7.TabIndex = 85
        Me.PictureBox7.TabStop = False
        '
        'txt_comentarioex
        '
        Me.txt_comentarioex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_comentarioex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comentarioex.Location = New System.Drawing.Point(22, 197)
        Me.txt_comentarioex.Multiline = True
        Me.txt_comentarioex.Name = "txt_comentarioex"
        Me.txt_comentarioex.Size = New System.Drawing.Size(394, 89)
        Me.txt_comentarioex.TabIndex = 53
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(297, 40)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(126, 23)
        Me.PictureBox4.TabIndex = 105
        Me.PictureBox4.TabStop = False
        '
        'lbl_nombreex
        '
        Me.lbl_nombreex.AutoSize = True
        Me.lbl_nombreex.Location = New System.Drawing.Point(303, 45)
        Me.lbl_nombreex.Name = "lbl_nombreex"
        Me.lbl_nombreex.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombreex.TabIndex = 106
        Me.lbl_nombreex.Text = "Nombre"
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(297, 86)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(126, 23)
        Me.PictureBox5.TabIndex = 107
        Me.PictureBox5.TabStop = False
        '
        'lbl_fechaex
        '
        Me.lbl_fechaex.AutoSize = True
        Me.lbl_fechaex.Location = New System.Drawing.Point(303, 91)
        Me.lbl_fechaex.Name = "lbl_fechaex"
        Me.lbl_fechaex.Size = New System.Drawing.Size(37, 13)
        Me.lbl_fechaex.TabIndex = 108
        Me.lbl_fechaex.Text = "Fecha"
        '
        'frm_tareasex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(459, 404)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_tareasex"
        Me.Text = "Tareas "
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_manhistorial.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_tareaex As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents gb_manhistorial As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancelarex As System.Windows.Forms.Button
    Friend WithEvents btn_guardarex As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_grupoex As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_turnoex As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_comentarioex As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fechaex As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_nombreex As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
