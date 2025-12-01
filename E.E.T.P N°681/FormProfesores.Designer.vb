<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProfesores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProfesores))
        PanelCerrar = New Panel()
        LabelBienvenida = New Label()
        BtnCerrar = New Button()
        PanelMenu = New Panel()
        submenuGA = New Panel()
        botonNotas = New Button()
        botonCurs = New Button()
        botonAsis = New Button()
        PanelGA = New Panel()
        Panel8 = New Panel()
        botonGA = New Button()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        PanelPantalla = New Panel()
        logomenu = New PictureBox()
        PanelCerrar.SuspendLayout()
        PanelMenu.SuspendLayout()
        submenuGA.SuspendLayout()
        PanelGA.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelPantalla.SuspendLayout()
        CType(logomenu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelCerrar
        ' 
        PanelCerrar.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        PanelCerrar.Controls.Add(LabelBienvenida)
        PanelCerrar.Controls.Add(BtnCerrar)
        PanelCerrar.Dock = DockStyle.Top
        PanelCerrar.Location = New Point(0, 0)
        PanelCerrar.Name = "PanelCerrar"
        PanelCerrar.Size = New Size(1080, 40)
        PanelCerrar.TabIndex = 0
        ' 
        ' LabelBienvenida
        ' 
        LabelBienvenida.Anchor = AnchorStyles.None
        LabelBienvenida.AutoSize = True
        LabelBienvenida.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        LabelBienvenida.ForeColor = Color.White
        LabelBienvenida.Location = New Point(508, 10)
        LabelBienvenida.Name = "LabelBienvenida"
        LabelBienvenida.Size = New Size(60, 21)
        LabelBienvenida.TabIndex = 3
        LabelBienvenida.Text = "Label1"
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        BtnCerrar.Dock = DockStyle.Right
        BtnCerrar.FlatAppearance.BorderSize = 0
        BtnCerrar.FlatAppearance.MouseOverBackColor = Color.Silver
        BtnCerrar.FlatStyle = FlatStyle.Flat
        BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), Image)
        BtnCerrar.Location = New Point(1040, 0)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(40, 40)
        BtnCerrar.TabIndex = 2
        BtnCerrar.UseVisualStyleBackColor = False
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        PanelMenu.Controls.Add(submenuGA)
        PanelMenu.Controls.Add(PanelGA)
        PanelMenu.Controls.Add(Panel2)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 40)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(234, 551)
        PanelMenu.TabIndex = 1
        ' 
        ' submenuGA
        ' 
        submenuGA.BackColor = Color.FromArgb(CByte(6), CByte(46), CByte(98))
        submenuGA.Controls.Add(botonNotas)
        submenuGA.Controls.Add(botonCurs)
        submenuGA.Controls.Add(botonAsis)
        submenuGA.Dock = DockStyle.Top
        submenuGA.Location = New Point(0, 160)
        submenuGA.Name = "submenuGA"
        submenuGA.Size = New Size(234, 105)
        submenuGA.TabIndex = 9
        ' 
        ' botonNotas
        ' 
        botonNotas.BackColor = Color.Transparent
        botonNotas.Dock = DockStyle.Top
        botonNotas.FlatAppearance.BorderSize = 0
        botonNotas.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(22), CByte(71), CByte(115))
        botonNotas.FlatStyle = FlatStyle.Flat
        botonNotas.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        botonNotas.ForeColor = SystemColors.Control
        botonNotas.ImageAlign = ContentAlignment.MiddleRight
        botonNotas.Location = New Point(0, 70)
        botonNotas.Margin = New Padding(0)
        botonNotas.Name = "botonNotas"
        botonNotas.Padding = New Padding(30, 0, 0, 0)
        botonNotas.Size = New Size(234, 35)
        botonNotas.TabIndex = 7
        botonNotas.Text = "NOTAS"
        botonNotas.TextAlign = ContentAlignment.MiddleLeft
        botonNotas.UseVisualStyleBackColor = False
        ' 
        ' botonCurs
        ' 
        botonCurs.BackColor = Color.Transparent
        botonCurs.Dock = DockStyle.Top
        botonCurs.FlatAppearance.BorderSize = 0
        botonCurs.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(22), CByte(71), CByte(115))
        botonCurs.FlatStyle = FlatStyle.Flat
        botonCurs.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        botonCurs.ForeColor = SystemColors.Control
        botonCurs.ImageAlign = ContentAlignment.MiddleRight
        botonCurs.Location = New Point(0, 35)
        botonCurs.Margin = New Padding(0)
        botonCurs.Name = "botonCurs"
        botonCurs.Padding = New Padding(30, 0, 0, 0)
        botonCurs.Size = New Size(234, 35)
        botonCurs.TabIndex = 6
        botonCurs.Text = "CURSOS"
        botonCurs.TextAlign = ContentAlignment.MiddleLeft
        botonCurs.UseVisualStyleBackColor = False
        ' 
        ' botonAsis
        ' 
        botonAsis.BackColor = Color.Transparent
        botonAsis.Dock = DockStyle.Top
        botonAsis.FlatAppearance.BorderSize = 0
        botonAsis.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(22), CByte(71), CByte(115))
        botonAsis.FlatStyle = FlatStyle.Flat
        botonAsis.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        botonAsis.ForeColor = SystemColors.Control
        botonAsis.ImageAlign = ContentAlignment.MiddleRight
        botonAsis.Location = New Point(0, 0)
        botonAsis.Margin = New Padding(0)
        botonAsis.Name = "botonAsis"
        botonAsis.Padding = New Padding(30, 0, 0, 0)
        botonAsis.Size = New Size(234, 35)
        botonAsis.TabIndex = 5
        botonAsis.Text = "ASISTENCIAS"
        botonAsis.TextAlign = ContentAlignment.MiddleLeft
        botonAsis.UseVisualStyleBackColor = False
        ' 
        ' PanelGA
        ' 
        PanelGA.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        PanelGA.Controls.Add(Panel8)
        PanelGA.Controls.Add(botonGA)
        PanelGA.Dock = DockStyle.Top
        PanelGA.Location = New Point(0, 110)
        PanelGA.Name = "PanelGA"
        PanelGA.Padding = New Padding(0, 0, 0, 5)
        PanelGA.Size = New Size(234, 50)
        PanelGA.TabIndex = 8
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Blue
        Panel8.Dock = DockStyle.Left
        Panel8.Location = New Point(0, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(8, 45)
        Panel8.TabIndex = 3
        ' 
        ' botonGA
        ' 
        botonGA.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        botonGA.Dock = DockStyle.Fill
        botonGA.FlatAppearance.BorderSize = 0
        botonGA.FlatStyle = FlatStyle.Flat
        botonGA.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        botonGA.ForeColor = SystemColors.Control
        botonGA.Location = New Point(0, 0)
        botonGA.Margin = New Padding(0)
        botonGA.Name = "botonGA"
        botonGA.Size = New Size(234, 45)
        botonGA.TabIndex = 2
        botonGA.Text = "  GESTIÓN ACADÉMICA"
        botonGA.TextAlign = ContentAlignment.MiddleLeft
        botonGA.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(234, 110)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.logo_letras
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(234, 110)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PanelPantalla
        ' 
        PanelPantalla.BackColor = Color.FromArgb(CByte(22), CByte(71), CByte(115))
        PanelPantalla.Controls.Add(logomenu)
        PanelPantalla.Dock = DockStyle.Fill
        PanelPantalla.Location = New Point(234, 40)
        PanelPantalla.Margin = New Padding(40, 3, 3, 3)
        PanelPantalla.Name = "PanelPantalla"
        PanelPantalla.Size = New Size(846, 551)
        PanelPantalla.TabIndex = 2
        ' 
        ' logomenu
        ' 
        logomenu.Anchor = AnchorStyles.None
        logomenu.BackColor = Color.Transparent
        logomenu.Image = My.Resources.Resources.logo_sin_fondo1
        logomenu.Location = New Point(320, 161)
        logomenu.Margin = New Padding(3, 6, 3, 3)
        logomenu.Name = "logomenu"
        logomenu.Size = New Size(229, 229)
        logomenu.SizeMode = PictureBoxSizeMode.Zoom
        logomenu.TabIndex = 0
        logomenu.TabStop = False
        ' 
        ' FormProfesores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1080, 591)
        Controls.Add(PanelPantalla)
        Controls.Add(PanelMenu)
        Controls.Add(PanelCerrar)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormProfesores"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        PanelCerrar.ResumeLayout(False)
        PanelCerrar.PerformLayout()
        PanelMenu.ResumeLayout(False)
        submenuGA.ResumeLayout(False)
        PanelGA.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelPantalla.ResumeLayout(False)
        CType(logomenu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelCerrar As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelPantalla As Panel
    Friend WithEvents logomenu As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents submenuGA As Panel
    Friend WithEvents PanelGA As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents botonGA As Button
    Friend WithEvents botonNotas As Button
    Friend WithEvents botonCurs As Button
    Friend WithEvents botonAsis As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents LabelBienvenida As Label

End Class
