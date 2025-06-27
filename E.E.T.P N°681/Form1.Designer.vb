<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PanelCerrar = New Panel()
        BtnCerrar = New Button()
        PanelMenu = New Panel()
        Panel1 = New Panel()
        logomenu = New PictureBox()
        PanelCerrar.SuspendLayout()
        Panel1.SuspendLayout()
        CType(logomenu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelCerrar
        ' 
        PanelCerrar.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        PanelCerrar.Controls.Add(BtnCerrar)
        PanelCerrar.Dock = DockStyle.Top
        PanelCerrar.Location = New Point(0, 0)
        PanelCerrar.Name = "PanelCerrar"
        PanelCerrar.Size = New Size(976, 40)
        PanelCerrar.TabIndex = 0
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        BtnCerrar.Dock = DockStyle.Right
        BtnCerrar.FlatAppearance.BorderSize = 0
        BtnCerrar.FlatAppearance.MouseOverBackColor = Color.Silver
        BtnCerrar.FlatStyle = FlatStyle.Flat
        BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), Image)
        BtnCerrar.Location = New Point(936, 0)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(40, 40)
        BtnCerrar.TabIndex = 1
        BtnCerrar.UseVisualStyleBackColor = False
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 40)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(234, 543)
        PanelMenu.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(22), CByte(71), CByte(115))
        Panel1.Controls.Add(logomenu)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(234, 40)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(742, 543)
        Panel1.TabIndex = 2
        ' 
        ' logomenu
        ' 
        logomenu.Anchor = AnchorStyles.None
        logomenu.BackColor = Color.Transparent
        logomenu.Image = My.Resources.Resources.logo_sin_fondo
        logomenu.Location = New Point(268, 157)
        logomenu.Name = "logomenu"
        logomenu.Size = New Size(229, 229)
        logomenu.SizeMode = PictureBoxSizeMode.Zoom
        logomenu.TabIndex = 0
        logomenu.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(976, 583)
        Controls.Add(Panel1)
        Controls.Add(PanelMenu)
        Controls.Add(PanelCerrar)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        PanelCerrar.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(logomenu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelCerrar As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents logomenu As PictureBox

End Class
