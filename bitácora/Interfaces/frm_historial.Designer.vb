<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_historial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_historial))
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.dtm_fecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_problema = New System.Windows.Forms.TextBox()
        Me.txt_encargado = New System.Windows.Forms.TextBox()
        Me.txt_turno = New System.Windows.Forms.TextBox()
        Me.txt_cuadrilla = New System.Windows.Forms.TextBox()
        Me.txt_detalles = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.PictureBox46 = New System.Windows.Forms.PictureBox()
        Me.PictureBox44 = New System.Windows.Forms.PictureBox()
        Me.labelasd = New System.Windows.Forms.Label()
        Me.PictureBox42 = New System.Windows.Forms.PictureBox()
        Me.gb_manhistorial = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox9.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox42, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_manhistorial.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.dtm_fecha)
        Me.GroupBox9.Controls.Add(Me.txt_problema)
        Me.GroupBox9.Controls.Add(Me.txt_encargado)
        Me.GroupBox9.Controls.Add(Me.txt_turno)
        Me.GroupBox9.Controls.Add(Me.txt_cuadrilla)
        Me.GroupBox9.Controls.Add(Me.txt_detalles)
        Me.GroupBox9.Controls.Add(Me.Label5)
        Me.GroupBox9.Controls.Add(Me.PictureBox6)
        Me.GroupBox9.Controls.Add(Me.Label3)
        Me.GroupBox9.Controls.Add(Me.Label1)
        Me.GroupBox9.Controls.Add(Me.PictureBox2)
        Me.GroupBox9.Controls.Add(Me.Label26)
        Me.GroupBox9.Controls.Add(Me.Label25)
        Me.GroupBox9.Controls.Add(Me.PictureBox46)
        Me.GroupBox9.Controls.Add(Me.PictureBox44)
        Me.GroupBox9.Controls.Add(Me.labelasd)
        Me.GroupBox9.Controls.Add(Me.PictureBox42)
        Me.GroupBox9.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(611, 203)
        Me.GroupBox9.TabIndex = 34
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Modificar tarea"
        '
        'dtm_fecha
        '
        Me.dtm_fecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtm_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtm_fecha.Location = New System.Drawing.Point(127, 117)
        Me.dtm_fecha.Name = "dtm_fecha"
        Me.dtm_fecha.Size = New System.Drawing.Size(141, 20)
        Me.dtm_fecha.TabIndex = 35
        '
        'txt_problema
        '
        Me.txt_problema.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_problema.Location = New System.Drawing.Point(392, 22)
        Me.txt_problema.Name = "txt_problema"
        Me.txt_problema.Size = New System.Drawing.Size(205, 22)
        Me.txt_problema.TabIndex = 84
        '
        'txt_encargado
        '
        Me.txt_encargado.Enabled = False
        Me.txt_encargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_encargado.Location = New System.Drawing.Point(127, 160)
        Me.txt_encargado.MaxLength = 50
        Me.txt_encargado.Name = "txt_encargado"
        Me.txt_encargado.Size = New System.Drawing.Size(141, 26)
        Me.txt_encargado.TabIndex = 83
        '
        'txt_turno
        '
        Me.txt_turno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_turno.Location = New System.Drawing.Point(127, 21)
        Me.txt_turno.Name = "txt_turno"
        Me.txt_turno.Size = New System.Drawing.Size(141, 26)
        Me.txt_turno.TabIndex = 81
        '
        'txt_cuadrilla
        '
        Me.txt_cuadrilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cuadrilla.Location = New System.Drawing.Point(127, 68)
        Me.txt_cuadrilla.Name = "txt_cuadrilla"
        Me.txt_cuadrilla.Size = New System.Drawing.Size(141, 26)
        Me.txt_cuadrilla.TabIndex = 80
        '
        'txt_detalles
        '
        Me.txt_detalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_detalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_detalles.Location = New System.Drawing.Point(284, 95)
        Me.txt_detalles.Multiline = True
        Me.txt_detalles.Name = "txt_detalles"
        Me.txt_detalles.Size = New System.Drawing.Size(321, 98)
        Me.txt_detalles.TabIndex = 79
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 18)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "ENCARGADO:"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PictureBox6.Location = New System.Drawing.Point(6, 153)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(272, 40)
        Me.PictureBox6.TabIndex = 76
        Me.PictureBox6.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(284, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 18)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "DETALLES DE PROBLEMA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(291, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 18)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "PROBLEMA:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PictureBox2.Location = New System.Drawing.Point(284, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(321, 40)
        Me.PictureBox2.TabIndex = 68
        Me.PictureBox2.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(13, 118)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 18)
        Me.Label26.TabIndex = 66
        Me.Label26.Text = "FECHA:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(13, 72)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(93, 18)
        Me.Label25.TabIndex = 66
        Me.Label25.Text = "CUADRILLA:"
        '
        'PictureBox46
        '
        Me.PictureBox46.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PictureBox46.Location = New System.Drawing.Point(6, 107)
        Me.PictureBox46.Name = "PictureBox46"
        Me.PictureBox46.Size = New System.Drawing.Size(272, 40)
        Me.PictureBox46.TabIndex = 64
        Me.PictureBox46.TabStop = False
        '
        'PictureBox44
        '
        Me.PictureBox44.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PictureBox44.Location = New System.Drawing.Point(6, 61)
        Me.PictureBox44.Name = "PictureBox44"
        Me.PictureBox44.Size = New System.Drawing.Size(272, 40)
        Me.PictureBox44.TabIndex = 64
        Me.PictureBox44.TabStop = False
        '
        'labelasd
        '
        Me.labelasd.AutoSize = True
        Me.labelasd.BackColor = System.Drawing.SystemColors.MenuBar
        Me.labelasd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelasd.Location = New System.Drawing.Point(13, 27)
        Me.labelasd.Name = "labelasd"
        Me.labelasd.Size = New System.Drawing.Size(60, 16)
        Me.labelasd.TabIndex = 62
        Me.labelasd.Text = "TURNO:"
        '
        'PictureBox42
        '
        Me.PictureBox42.BackColor = System.Drawing.SystemColors.MenuBar
        Me.PictureBox42.Location = New System.Drawing.Point(6, 15)
        Me.PictureBox42.Name = "PictureBox42"
        Me.PictureBox42.Size = New System.Drawing.Size(272, 40)
        Me.PictureBox42.TabIndex = 60
        Me.PictureBox42.TabStop = False
        '
        'gb_manhistorial
        '
        Me.gb_manhistorial.Controls.Add(Me.btn_cancelar)
        Me.gb_manhistorial.Controls.Add(Me.btn_guardar)
        Me.gb_manhistorial.Location = New System.Drawing.Point(190, 221)
        Me.gb_manhistorial.Name = "gb_manhistorial"
        Me.gb_manhistorial.Size = New System.Drawing.Size(228, 85)
        Me.gb_manhistorial.TabIndex = 35
        Me.gb_manhistorial.TabStop = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(140, 19)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(82, 57)
        Me.btn_cancelar.TabIndex = 1114
        Me.btn_cancelar.Text = "Cerrar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_guardar.Location = New System.Drawing.Point(6, 19)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(82, 57)
        Me.btn_guardar.TabIndex = 1113
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(248, 275)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(107, 20)
        Me.Label30.TabIndex = 97
        Me.Label30.Text = "inicie sesión"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(225, 255)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(154, 20)
        Me.Label31.TabIndex = 96
        Me.Label31.Text = "Para modificar datos"
        '
        'frm_historial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(633, 318)
        Me.Controls.Add(Me.gb_manhistorial)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.GroupBox9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_historial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial"
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox42, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_manhistorial.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents PictureBox46 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox44 As System.Windows.Forms.PictureBox
    Friend WithEvents labelasd As System.Windows.Forms.Label
    Friend WithEvents PictureBox42 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_problema As System.Windows.Forms.TextBox
    Friend WithEvents txt_encargado As System.Windows.Forms.TextBox
    Friend WithEvents txt_turno As System.Windows.Forms.TextBox
    Friend WithEvents txt_cuadrilla As System.Windows.Forms.TextBox
    Friend WithEvents txt_detalles As System.Windows.Forms.TextBox
    Friend WithEvents dtm_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents gb_manhistorial As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
End Class
