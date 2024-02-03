<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_principal))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnl_body = New System.Windows.Forms.Panel()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.dgv_pxman = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lkbl_inisesion = New System.Windows.Forms.LinkLabel()
        Me.mnu_usu = New System.Windows.Forms.MenuStrip()
        Me.item_nombre = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerMisDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.item_cerrarsesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.in_calles = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantencionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComEspecialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lb_clock = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.hola = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pnl_body.SuspendLayout()
        CType(Me.dgv_pxman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.mnu_usu.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'pnl_body
        '
        Me.pnl_body.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_body.AutoScroll = True
        Me.pnl_body.BackColor = System.Drawing.Color.White
        Me.pnl_body.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_body.Controls.Add(Me.lbl_usuario)
        Me.pnl_body.Location = New System.Drawing.Point(3, 71)
        Me.pnl_body.Name = "pnl_body"
        Me.pnl_body.Size = New System.Drawing.Size(515, 512)
        Me.pnl_body.TabIndex = 58
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_usuario.Font = New System.Drawing.Font("Gabriola", 12.0!)
        Me.lbl_usuario.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_usuario.Location = New System.Drawing.Point(10, -29)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(54, 29)
        Me.lbl_usuario.TabIndex = 74
        Me.lbl_usuario.Text = "Usuario"
        '
        'dgv_pxman
        '
        Me.dgv_pxman.AllowUserToAddRows = False
        Me.dgv_pxman.AllowUserToDeleteRows = False
        Me.dgv_pxman.AllowUserToResizeColumns = False
        Me.dgv_pxman.AllowUserToResizeRows = False
        Me.dgv_pxman.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_pxman.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_pxman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_pxman.EnableHeadersVisualStyles = False
        Me.dgv_pxman.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgv_pxman.Location = New System.Drawing.Point(5, 283)
        Me.dgv_pxman.MultiSelect = False
        Me.dgv_pxman.Name = "dgv_pxman"
        Me.dgv_pxman.RowHeadersVisible = False
        Me.dgv_pxman.ShowCellErrors = False
        Me.dgv_pxman.ShowCellToolTips = False
        Me.dgv_pxman.ShowEditingIcon = False
        Me.dgv_pxman.ShowRowErrors = False
        Me.dgv_pxman.Size = New System.Drawing.Size(241, 216)
        Me.dgv_pxman.TabIndex = 61
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.Controls.Add(Me.PictureBox4)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(769, 30)
        Me.Panel5.TabIndex = 60
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(567, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 29)
        Me.Panel2.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(135, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(27, 23)
        Me.Button4.TabIndex = 79
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(168, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 23)
        Me.Button1.TabIndex = 78
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(769, 41)
        Me.Panel1.TabIndex = 61
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.MenuStrip2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(769, 40)
        Me.Panel3.TabIndex = 95
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel4.Controls.Add(Me.lkbl_inisesion)
        Me.Panel4.Controls.Add(Me.mnu_usu)
        Me.Panel4.Location = New System.Drawing.Point(569, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 29)
        Me.Panel4.TabIndex = 84
        '
        'lkbl_inisesion
        '
        Me.lkbl_inisesion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lkbl_inisesion.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkbl_inisesion.Image = CType(resources.GetObject("lkbl_inisesion.Image"), System.Drawing.Image)
        Me.lkbl_inisesion.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lkbl_inisesion.LinkColor = System.Drawing.Color.Blue
        Me.lkbl_inisesion.Location = New System.Drawing.Point(54, 2)
        Me.lkbl_inisesion.Name = "lkbl_inisesion"
        Me.lkbl_inisesion.Size = New System.Drawing.Size(135, 25)
        Me.lkbl_inisesion.TabIndex = 86
        Me.lkbl_inisesion.TabStop = True
        Me.lkbl_inisesion.Text = "Iniciar sesión"
        '
        'mnu_usu
        '
        Me.mnu_usu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mnu_usu.BackgroundImage = CType(resources.GetObject("mnu_usu.BackgroundImage"), System.Drawing.Image)
        Me.mnu_usu.Dock = System.Windows.Forms.DockStyle.None
        Me.mnu_usu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.item_nombre})
        Me.mnu_usu.Location = New System.Drawing.Point(14, 3)
        Me.mnu_usu.Name = "mnu_usu"
        Me.mnu_usu.Size = New System.Drawing.Size(87, 24)
        Me.mnu_usu.TabIndex = 87
        Me.mnu_usu.Text = "MenuStrip1"
        '
        'item_nombre
        '
        Me.item_nombre.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerMisDatosToolStripMenuItem, Me.item_cerrarsesion})
        Me.item_nombre.ForeColor = System.Drawing.SystemColors.Highlight
        Me.item_nombre.Image = CType(resources.GetObject("item_nombre.Image"), System.Drawing.Image)
        Me.item_nombre.Name = "item_nombre"
        Me.item_nombre.Size = New System.Drawing.Size(79, 20)
        Me.item_nombre.Text = "Nombre"
        '
        'VerMisDatosToolStripMenuItem
        '
        Me.VerMisDatosToolStripMenuItem.Image = CType(resources.GetObject("VerMisDatosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VerMisDatosToolStripMenuItem.Name = "VerMisDatosToolStripMenuItem"
        Me.VerMisDatosToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.VerMisDatosToolStripMenuItem.Text = "Mis datos"
        '
        'item_cerrarsesion
        '
        Me.item_cerrarsesion.Image = CType(resources.GetObject("item_cerrarsesion.Image"), System.Drawing.Image)
        Me.item_cerrarsesion.Name = "item_cerrarsesion"
        Me.item_cerrarsesion.Size = New System.Drawing.Size(142, 22)
        Me.item_cerrarsesion.Text = "Cerrar sesión"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem8, Me.ToolStripMenuItem6, Me.ToolStripMenuItem9})
        Me.MenuStrip2.Location = New System.Drawing.Point(2, 5)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(410, 30)
        Me.MenuStrip2.TabIndex = 83
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Checked = True
        Me.ToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.in_calles, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(75, 26)
        Me.ToolStripMenuItem1.Text = "Nuevo"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripMenuItem2.Text = "Componentes"
        '
        'in_calles
        '
        Me.in_calles.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.in_calles.Image = CType(resources.GetObject("in_calles.Image"), System.Drawing.Image)
        Me.in_calles.Name = "in_calles"
        Me.in_calles.Size = New System.Drawing.Size(183, 22)
        Me.in_calles.Text = "Calles"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripMenuItem4.Text = "Punto vaciado"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem5.Image = CType(resources.GetObject("ToolStripMenuItem5.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripMenuItem5.Text = "Tareas externas"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantencionesToolStripMenuItem})
        Me.ToolStripMenuItem8.Font = New System.Drawing.Font("Cambria", 14.25!)
        Me.ToolStripMenuItem8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(121, 26)
        Me.ToolStripMenuItem8.Text = "Administrar"
        '
        'MantencionesToolStripMenuItem
        '
        Me.MantencionesToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.MantencionesToolStripMenuItem.Image = CType(resources.GetObject("MantencionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MantencionesToolStripMenuItem.Name = "MantencionesToolStripMenuItem"
        Me.MantencionesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.MantencionesToolStripMenuItem.Text = "Mantenciones"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.ComEspecialToolStripMenuItem})
        Me.ToolStripMenuItem6.Font = New System.Drawing.Font("Cambria", 14.25!)
        Me.ToolStripMenuItem6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(111, 26)
        Me.ToolStripMenuItem6.Text = "Busquedas"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem7.Image = CType(resources.GetObject("ToolStripMenuItem7.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripMenuItem7.Text = "Com. Punto Vaciado"
        '
        'ComEspecialToolStripMenuItem
        '
        Me.ComEspecialToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ComEspecialToolStripMenuItem.Image = CType(resources.GetObject("ComEspecialToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ComEspecialToolStripMenuItem.Name = "ComEspecialToolStripMenuItem"
        Me.ComEspecialToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ComEspecialToolStripMenuItem.Text = "Historial tareas ex."
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem})
        Me.ToolStripMenuItem9.Font = New System.Drawing.Font("Cambria", 14.25!)
        Me.ToolStripMenuItem9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(95, 26)
        Me.ToolStripMenuItem9.Text = "Reportes"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ReportesToolStripMenuItem.Image = CType(resources.GetObject("ReportesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.Controls.Add(Me.lb_clock)
        Me.Panel6.Controls.Add(Me.PictureBox1)
        Me.Panel6.Controls.Add(Me.hola)
        Me.Panel6.Controls.Add(Me.dgv_pxman)
        Me.Panel6.Controls.Add(Me.PictureBox2)
        Me.Panel6.Controls.Add(Me.MonthCalendar1)
        Me.Panel6.Location = New System.Drawing.Point(516, 71)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(251, 512)
        Me.Panel6.TabIndex = 62
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(22, 22)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 33)
        Me.PictureBox3.TabIndex = 95
        Me.PictureBox3.TabStop = False
        '
        'lb_clock
        '
        Me.lb_clock.AutoSize = True
        Me.lb_clock.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lb_clock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_clock.Location = New System.Drawing.Point(71, 30)
        Me.lb_clock.Name = "lb_clock"
        Me.lb_clock.Size = New System.Drawing.Size(45, 20)
        Me.lb_clock.TabIndex = 94
        Me.lb_clock.Text = "Reloj"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(10, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 42)
        Me.PictureBox1.TabIndex = 93
        Me.PictureBox1.TabStop = False
        '
        'hola
        '
        Me.hola.AutoSize = True
        Me.hola.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.hola.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hola.Location = New System.Drawing.Point(38, 253)
        Me.hola.Name = "hola"
        Me.hola.Size = New System.Drawing.Size(177, 20)
        Me.hola.TabIndex = 92
        Me.hola.Text = "Proximas mantenciones"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(5, 242)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(241, 42)
        Me.PictureBox2.TabIndex = 91
        Me.PictureBox2.TabStop = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.MonthCalendar1.Location = New System.Drawing.Point(10, 56)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 78
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.bitácora.My.Resources.Resources.b_blue
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(26, 31)
        Me.PictureBox4.TabIndex = 75
        Me.PictureBox4.TabStop = False
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(769, 589)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.pnl_body)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnu_usu
        Me.MaximizeBox = False
        Me.Name = "frm_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bitácora"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_body.ResumeLayout(False)
        Me.pnl_body.PerformLayout()
        CType(Me.dgv_pxman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.mnu_usu.ResumeLayout(False)
        Me.mnu_usu.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pnl_body As System.Windows.Forms.Panel
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents in_calles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents ComEspecialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents MantencionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents dgv_pxman As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lb_clock As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents hola As System.Windows.Forms.Label
    Friend WithEvents lkbl_inisesion As System.Windows.Forms.LinkLabel
    Friend WithEvents mnu_usu As System.Windows.Forms.MenuStrip
    Friend WithEvents item_nombre As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerMisDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents item_cerrarsesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox

End Class
