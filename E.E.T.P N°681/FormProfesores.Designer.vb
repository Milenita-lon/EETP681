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
        botonMate = New Button()
        botonCurs = New Button()
        botonAlum = New Button()
        PanelGA = New Panel()
        Panel8 = New Panel()
        botonGA = New Button()
        submenuAU = New Panel()
        botonDirec = New Button()
        PanelAU = New Panel()
        Panel7 = New Panel()
        botonAU = New Button()
        submenuPD = New Panel()
        botonPrecep = New Button()
        botonProfes = New Button()
        PanelPD = New Panel()
        Panel6 = New Panel()
        botonPD = New Button()
        submenuAG = New Panel()
        botonSecre = New Button()
        PanelAG = New Panel()
        Panel4 = New Panel()
        botonAG = New Button()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        PanelPantalla = New Panel()
        logomenu = New PictureBox()
        PanelCerrar.SuspendLayout()
        PanelMenu.SuspendLayout()
        submenuGA.SuspendLayout()
        PanelGA.SuspendLayout()
        submenuAU.SuspendLayout()
        PanelAU.SuspendLayout()
        submenuPD.SuspendLayout()
        PanelPD.SuspendLayout()
        submenuAG.SuspendLayout()
        PanelAG.SuspendLayout()
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
        PanelCerrar.Margin = New Padding(3, 4, 3, 4)
        PanelCerrar.Name = "PanelCerrar"
        PanelCerrar.Size = New Size(1234, 53)
        PanelCerrar.TabIndex = 0
        ' 
        ' LabelBienvenida
        ' 
        LabelBienvenida.Anchor = AnchorStyles.None
        LabelBienvenida.AutoSize = True
        LabelBienvenida.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        LabelBienvenida.ForeColor = Color.White
        LabelBienvenida.Location = New Point(580, 13)
        LabelBienvenida.Name = "LabelBienvenida"
        LabelBienvenida.Size = New Size(74, 28)
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
        BtnCerrar.Location = New Point(1188, 0)
        BtnCerrar.Margin = New Padding(3, 4, 3, 4)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(46, 53)
        BtnCerrar.TabIndex = 2
        BtnCerrar.UseVisualStyleBackColor = False
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        PanelMenu.Controls.Add(submenuGA)
        PanelMenu.Controls.Add(PanelGA)
        PanelMenu.Controls.Add(submenuAU)
        PanelMenu.Controls.Add(PanelAU)
        PanelMenu.Controls.Add(submenuPD)
        PanelMenu.Controls.Add(PanelPD)
        PanelMenu.Controls.Add(submenuAG)
        PanelMenu.Controls.Add(PanelAG)
        PanelMenu.Controls.Add(Panel2)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 53)
        PanelMenu.Margin = New Padding(3, 4, 3, 4)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(267, 907)
        PanelMenu.TabIndex = 1
        ' 
        ' submenuGA
        ' 
        submenuGA.BackColor = Color.FromArgb(CByte(6), CByte(46), CByte(98))
        submenuGA.Controls.Add(botonMate)
        submenuGA.Controls.Add(botonCurs)
        submenuGA.Controls.Add(botonAlum)
        submenuGA.Dock = DockStyle.Top
        submenuGA.Location = New Point(0, 602)
        submenuGA.Margin = New Padding(3, 4, 3, 4)
        submenuGA.Name = "submenuGA"
        submenuGA.Size = New Size(267, 140)
        submenuGA.TabIndex = 9
        ' 
        ' botonMate
        ' 
        botonMate.BackColor = Color.Transparent
        botonMate.Dock = DockStyle.Top
        botonMate.FlatAppearance.BorderSize = 0
        botonMate.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(22), CByte(71), CByte(115))
        botonMate.FlatStyle = FlatStyle.Flat
        botonMate.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        botonMate.ForeColor = SystemColors.Control
        botonMate.ImageAlign = ContentAlignment.MiddleRight
        botonMate.Location = New Point(0, 94)
        botonMate.Margin = New Padding(0)
        botonMate.Name = "botonMate"
        botonMate.Padding = New Padding(34, 0, 0, 0)
        botonMate.Size = New Size(267, 47)
        botonMate.TabIndex = 7
        botonMate.Text = "MATERIAS"
        botonMate.TextAlign = ContentAlignment.MiddleLeft
        botonMate.UseVisualStyleBackColor = False
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
        botonCurs.Location = New Point(0, 47)
        botonCurs.Margin = New Padding(0)
        botonCurs.Name = "botonCurs"
        botonCurs.Padding = New Padding(34, 0, 0, 0)
        botonCurs.Size = New Size(267, 47)
        botonCurs.TabIndex = 6
        botonCurs.Text = "CURSOS"
        botonCurs.TextAlign = ContentAlignment.MiddleLeft
        botonCurs.UseVisualStyleBackColor = False
        ' 
        ' botonAlum
        ' 
        botonAlum.BackColor = Color.Transparent
        botonAlum.Dock = DockStyle.Top
        botonAlum.FlatAppearance.BorderSize = 0
        botonAlum.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(22), CByte(71), CByte(115))
        botonAlum.FlatStyle = FlatStyle.Flat
        botonAlum.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        botonAlum.ForeColor = SystemColors.Control
        botonAlum.ImageAlign = ContentAlignment.MiddleRight
        botonAlum.Location = New Point(0, 0)
        botonAlum.Margin = New Padding(0)
        botonAlum.Name = "botonAlum"
        botonAlum.Padding = New Padding(34, 0, 0, 0)
        botonAlum.Size = New Size(267, 47)
        botonAlum.TabIndex = 5
        botonAlum.Text = "ALUMNOS"
        botonAlum.TextAlign = ContentAlignment.MiddleLeft
        botonAlum.UseVisualStyleBackColor = False
        ' 
        ' PanelGA
        ' 
        PanelGA.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        PanelGA.Controls.Add(Panel8)
        PanelGA.Controls.Add(botonGA)
        PanelGA.Dock = DockStyle.Top
        PanelGA.Location = New Point(0, 535)
        PanelGA.Margin = New Padding(3, 4, 3, 4)
        PanelGA.Name = "PanelGA"
        PanelGA.Padding = New Padding(0, 0, 0, 7)
        PanelGA.Size = New Size(267, 67)
        PanelGA.TabIndex = 8
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Blue
        Panel8.Dock = DockStyle.Left
        Panel8.Location = New Point(0, 0)
        Panel8.Margin = New Padding(3, 4, 3, 4)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(9, 60)
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
        botonGA.Size = New Size(267, 60)
        botonGA.TabIndex = 2
        botonGA.Text = "  GESTIÓN ACADÉMICA"
        botonGA.TextAlign = ContentAlignment.MiddleLeft
        botonGA.UseVisualStyleBackColor = False
        ' 
        ' submenuAU
        ' 
        submenuAU.BackColor = Color.FromArgb(CByte(6), CByte(46), CByte(98))
        submenuAU.Controls.Add(botonDirec)
        submenuAU.Dock = DockStyle.Top
        submenuAU.Location = New Point(0, 488)
        submenuAU.Margin = New Padding(3, 4, 3, 4)
        submenuAU.Name = "submenuAU"
        submenuAU.Size = New Size(267, 47)
        submenuAU.TabIndex = 7
        ' 
        ' botonDirec
        ' 
        botonDirec.BackColor = Color.Transparent
        botonDirec.Dock = DockStyle.Top
        botonDirec.FlatAppearance.BorderSize = 0
        botonDirec.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(22), CByte(71), CByte(115))
        botonDirec.FlatStyle = FlatStyle.Flat
        botonDirec.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        botonDirec.ForeColor = SystemColors.Control
        botonDirec.ImageAlign = ContentAlignment.MiddleRight
        botonDirec.Location = New Point(0, 0)
        botonDirec.Margin = New Padding(0)
        botonDirec.Name = "botonDirec"
        botonDirec.Padding = New Padding(34, 0, 0, 0)
        botonDirec.Size = New Size(267, 47)
        botonDirec.TabIndex = 4
        botonDirec.Text = "DIRECTIVOS"
        botonDirec.TextAlign = ContentAlignment.MiddleLeft
        botonDirec.UseVisualStyleBackColor = False
        ' 
        ' PanelAU
        ' 
        PanelAU.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        PanelAU.Controls.Add(Panel7)
        PanelAU.Controls.Add(botonAU)
        PanelAU.Dock = DockStyle.Top
        PanelAU.Location = New Point(0, 421)
        PanelAU.Margin = New Padding(3, 4, 3, 4)
        PanelAU.Name = "PanelAU"
        PanelAU.Padding = New Padding(0, 0, 0, 7)
        PanelAU.Size = New Size(267, 67)
        PanelAU.TabIndex = 6
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Blue
        Panel7.Dock = DockStyle.Left
        Panel7.Location = New Point(0, 0)
        Panel7.Margin = New Padding(3, 4, 3, 4)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(9, 60)
        Panel7.TabIndex = 3
        ' 
        ' botonAU
        ' 
        botonAU.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        botonAU.Dock = DockStyle.Fill
        botonAU.FlatAppearance.BorderSize = 0
        botonAU.FlatStyle = FlatStyle.Flat
        botonAU.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        botonAU.ForeColor = SystemColors.Control
        botonAU.Location = New Point(0, 0)
        botonAU.Margin = New Padding(0)
        botonAU.Name = "botonAU"
        botonAU.Size = New Size(267, 60)
        botonAU.TabIndex = 2
        botonAU.Text = "  AUTORIDADES"
        botonAU.TextAlign = ContentAlignment.MiddleLeft
        botonAU.UseVisualStyleBackColor = False
        ' 
        ' submenuPD
        ' 
        submenuPD.BackColor = Color.FromArgb(CByte(6), CByte(46), CByte(98))
        submenuPD.Controls.Add(botonPrecep)
        submenuPD.Controls.Add(botonProfes)
        submenuPD.Dock = DockStyle.Top
        submenuPD.Location = New Point(0, 328)
        submenuPD.Margin = New Padding(3, 4, 3, 4)
        submenuPD.Name = "submenuPD"
        submenuPD.Size = New Size(267, 93)
        submenuPD.TabIndex = 5
        ' 
        ' botonPrecep
        ' 
        botonPrecep.BackColor = Color.Transparent
        botonPrecep.Dock = DockStyle.Top
        botonPrecep.FlatAppearance.BorderSize = 0
        botonPrecep.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(22), CByte(71), CByte(115))
        botonPrecep.FlatStyle = FlatStyle.Flat
        botonPrecep.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        botonPrecep.ForeColor = SystemColors.Control
        botonPrecep.ImageAlign = ContentAlignment.MiddleRight
        botonPrecep.Location = New Point(0, 47)
        botonPrecep.Margin = New Padding(0)
        botonPrecep.Name = "botonPrecep"
        botonPrecep.Padding = New Padding(34, 0, 0, 0)
        botonPrecep.Size = New Size(267, 47)
        botonPrecep.TabIndex = 5
        botonPrecep.Text = "PRECEPTORES"
        botonPrecep.TextAlign = ContentAlignment.MiddleLeft
        botonPrecep.UseVisualStyleBackColor = False
        ' 
        ' botonProfes
        ' 
        botonProfes.BackColor = Color.Transparent
        botonProfes.Dock = DockStyle.Top
        botonProfes.FlatAppearance.BorderSize = 0
        botonProfes.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(22), CByte(71), CByte(115))
        botonProfes.FlatStyle = FlatStyle.Flat
        botonProfes.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        botonProfes.ForeColor = SystemColors.Control
        botonProfes.ImageAlign = ContentAlignment.MiddleRight
        botonProfes.Location = New Point(0, 0)
        botonProfes.Margin = New Padding(0)
        botonProfes.Name = "botonProfes"
        botonProfes.Padding = New Padding(34, 0, 0, 0)
        botonProfes.Size = New Size(267, 47)
        botonProfes.TabIndex = 4
        botonProfes.Text = "PROFESORES"
        botonProfes.TextAlign = ContentAlignment.MiddleLeft
        botonProfes.UseVisualStyleBackColor = False
        ' 
        ' PanelPD
        ' 
        PanelPD.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        PanelPD.Controls.Add(Panel6)
        PanelPD.Controls.Add(botonPD)
        PanelPD.Dock = DockStyle.Top
        PanelPD.Location = New Point(0, 261)
        PanelPD.Margin = New Padding(3, 4, 3, 4)
        PanelPD.Name = "PanelPD"
        PanelPD.Padding = New Padding(0, 0, 0, 7)
        PanelPD.Size = New Size(267, 67)
        PanelPD.TabIndex = 4
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Blue
        Panel6.Dock = DockStyle.Left
        Panel6.Location = New Point(0, 0)
        Panel6.Margin = New Padding(3, 4, 3, 4)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(9, 60)
        Panel6.TabIndex = 3
        ' 
        ' botonPD
        ' 
        botonPD.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        botonPD.Dock = DockStyle.Fill
        botonPD.FlatAppearance.BorderSize = 0
        botonPD.FlatStyle = FlatStyle.Flat
        botonPD.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        botonPD.ForeColor = SystemColors.Control
        botonPD.Location = New Point(0, 0)
        botonPD.Margin = New Padding(0)
        botonPD.Name = "botonPD"
        botonPD.Size = New Size(267, 60)
        botonPD.TabIndex = 2
        botonPD.Text = "  PERSONAL DOCENTE"
        botonPD.TextAlign = ContentAlignment.MiddleLeft
        botonPD.UseVisualStyleBackColor = False
        ' 
        ' submenuAG
        ' 
        submenuAG.BackColor = Color.FromArgb(CByte(6), CByte(46), CByte(98))
        submenuAG.Controls.Add(botonSecre)
        submenuAG.Dock = DockStyle.Top
        submenuAG.Location = New Point(0, 214)
        submenuAG.Margin = New Padding(3, 4, 3, 4)
        submenuAG.Name = "submenuAG"
        submenuAG.Size = New Size(267, 47)
        submenuAG.TabIndex = 3
        ' 
        ' botonSecre
        ' 
        botonSecre.BackColor = Color.Transparent
        botonSecre.Dock = DockStyle.Top
        botonSecre.FlatAppearance.BorderSize = 0
        botonSecre.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(22), CByte(71), CByte(115))
        botonSecre.FlatStyle = FlatStyle.Flat
        botonSecre.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        botonSecre.ForeColor = SystemColors.Control
        botonSecre.ImageAlign = ContentAlignment.MiddleRight
        botonSecre.Location = New Point(0, 0)
        botonSecre.Margin = New Padding(0)
        botonSecre.Name = "botonSecre"
        botonSecre.Padding = New Padding(34, 0, 0, 0)
        botonSecre.Size = New Size(267, 47)
        botonSecre.TabIndex = 4
        botonSecre.Text = "SECRETARIOS"
        botonSecre.TextAlign = ContentAlignment.MiddleLeft
        botonSecre.UseVisualStyleBackColor = False
        ' 
        ' PanelAG
        ' 
        PanelAG.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        PanelAG.Controls.Add(Panel4)
        PanelAG.Controls.Add(botonAG)
        PanelAG.Dock = DockStyle.Top
        PanelAG.ForeColor = SystemColors.Control
        PanelAG.Location = New Point(0, 147)
        PanelAG.Margin = New Padding(3, 4, 3, 4)
        PanelAG.Name = "PanelAG"
        PanelAG.Padding = New Padding(0, 0, 0, 7)
        PanelAG.Size = New Size(267, 67)
        PanelAG.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Blue
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 0)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(9, 60)
        Panel4.TabIndex = 3
        ' 
        ' botonAG
        ' 
        botonAG.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        botonAG.Dock = DockStyle.Fill
        botonAG.FlatAppearance.BorderSize = 0
        botonAG.FlatStyle = FlatStyle.Flat
        botonAG.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        botonAG.ForeColor = SystemColors.Control
        botonAG.Location = New Point(0, 0)
        botonAG.Margin = New Padding(0)
        botonAG.Name = "botonAG"
        botonAG.Size = New Size(267, 60)
        botonAG.TabIndex = 2
        botonAG.Text = "  ADMINISTRACIÓN GENERAL"
        botonAG.TextAlign = ContentAlignment.MiddleLeft
        botonAG.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(267, 147)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.logo_letras
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(267, 147)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PanelPantalla
        ' 
        PanelPantalla.BackColor = Color.FromArgb(CByte(22), CByte(71), CByte(115))
        PanelPantalla.Controls.Add(logomenu)
        PanelPantalla.Dock = DockStyle.Fill
        PanelPantalla.Location = New Point(267, 53)
        PanelPantalla.Margin = New Padding(46, 4, 3, 4)
        PanelPantalla.Name = "PanelPantalla"
        PanelPantalla.Size = New Size(967, 907)
        PanelPantalla.TabIndex = 2
        ' 
        ' logomenu
        ' 
        logomenu.Anchor = AnchorStyles.None
        logomenu.BackColor = Color.Transparent
        logomenu.Image = My.Resources.Resources.logo_sin_fondo1
        logomenu.Location = New Point(366, 301)
        logomenu.Margin = New Padding(3, 8, 3, 4)
        logomenu.Name = "logomenu"
        logomenu.Size = New Size(262, 305)
        logomenu.SizeMode = PictureBoxSizeMode.Zoom
        logomenu.TabIndex = 0
        logomenu.TabStop = False
        ' 
        ' FormProfesores
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1234, 960)
        Controls.Add(PanelPantalla)
        Controls.Add(PanelMenu)
        Controls.Add(PanelCerrar)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormProfesores"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        PanelCerrar.ResumeLayout(False)
        PanelCerrar.PerformLayout()
        PanelMenu.ResumeLayout(False)
        submenuGA.ResumeLayout(False)
        PanelGA.ResumeLayout(False)
        submenuAU.ResumeLayout(False)
        PanelAU.ResumeLayout(False)
        submenuPD.ResumeLayout(False)
        PanelPD.ResumeLayout(False)
        submenuAG.ResumeLayout(False)
        PanelAG.ResumeLayout(False)
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
    Friend WithEvents botonAG As Button
    Friend WithEvents PanelAG As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents submenuPD As Panel
    Friend WithEvents PanelPD As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents botonPD As Button
    Friend WithEvents submenuAG As Panel
    Friend WithEvents submenuAU As Panel
    Friend WithEvents PanelAU As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents botonAU As Button
    Friend WithEvents submenuGA As Panel
    Friend WithEvents PanelGA As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents botonGA As Button
    Friend WithEvents botonProfes As Button
    Friend WithEvents botonSecre As Button
    Friend WithEvents botonMate As Button
    Friend WithEvents botonCurs As Button
    Friend WithEvents botonAlum As Button
    Friend WithEvents botonDirec As Button
    Friend WithEvents botonPrecep As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents LabelBienvenida As Label

End Class
