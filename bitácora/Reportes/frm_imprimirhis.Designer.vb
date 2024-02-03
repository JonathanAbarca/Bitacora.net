<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_imprimirhis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_imprimirhis))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cb_calle = New System.Windows.Forms.ComboBox()
        Me.cb_puntos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 210)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(448, 276)
        Me.DataGridView1.TabIndex = 1
        '
        'cb_calle
        '
        Me.cb_calle.FormattingEnabled = True
        Me.cb_calle.Location = New System.Drawing.Point(27, 54)
        Me.cb_calle.Name = "cb_calle"
        Me.cb_calle.Size = New System.Drawing.Size(119, 21)
        Me.cb_calle.TabIndex = 6
        '
        'cb_puntos
        '
        Me.cb_puntos.FormattingEnabled = True
        Me.cb_puntos.Location = New System.Drawing.Point(27, 101)
        Me.cb_puntos.Name = "cb_puntos"
        Me.cb_puntos.Size = New System.Drawing.Size(119, 21)
        Me.cb_puntos.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "CALLES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "PUNTOS DE VACIADO"
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.LightCyan
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_buscar.Location = New System.Drawing.Point(246, 56)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(58, 54)
        Me.btn_buscar.TabIndex = 1
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.MistyRose
        Me.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cerrar.Location = New System.Drawing.Point(355, 56)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(58, 54)
        Me.btn_cerrar.TabIndex = 1
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.Color.Honeydew
        Me.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_imprimir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_imprimir.Location = New System.Drawing.Point(12, 178)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(81, 27)
        Me.btn_imprimir.TabIndex = 10
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_puntos)
        Me.GroupBox1.Controls.Add(Me.cb_calle)
        Me.GroupBox1.Controls.Add(Me.btn_buscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_cerrar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 159)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de tareas "
        '
        'frm_imprimirhis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(485, 526)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frm_imprimirhis"
        Me.Text = "Bitácora"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cb_calle As System.Windows.Forms.ComboBox
    Friend WithEvents cb_puntos As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
