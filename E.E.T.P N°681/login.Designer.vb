<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        cerralogin = New PictureBox()
        panelleftlogin = New Panel()
        logologin = New PictureBox()
        usuariologin = New TextBox()
        passwordlogin = New TextBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        textingreso = New Label()
        accederlogin = New Button()
        CType(cerralogin, ComponentModel.ISupportInitialize).BeginInit()
        panelleftlogin.SuspendLayout()
        CType(logologin, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cerralogin
        ' 
        cerralogin.Cursor = Cursors.Hand
        cerralogin.Image = My.Resources.Resources.x
        cerralogin.Location = New Point(841, 16)
        cerralogin.Margin = New Padding(3, 4, 3, 4)
        cerralogin.Name = "cerralogin"
        cerralogin.Size = New Size(42, 48)
        cerralogin.SizeMode = PictureBoxSizeMode.Zoom
        cerralogin.TabIndex = 0
        cerralogin.TabStop = False
        ' 
        ' panelleftlogin
        ' 
        panelleftlogin.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        panelleftlogin.Controls.Add(logologin)
        panelleftlogin.Dock = DockStyle.Left
        panelleftlogin.Location = New Point(0, 0)
        panelleftlogin.Margin = New Padding(3, 4, 3, 4)
        panelleftlogin.Name = "panelleftlogin"
        panelleftlogin.Size = New Size(289, 460)
        panelleftlogin.TabIndex = 1
        ' 
        ' logologin
        ' 
        logologin.Image = My.Resources.Resources.logo_sin_fondo1
        logologin.Location = New Point(37, 80)
        logologin.Margin = New Padding(3, 4, 3, 4)
        logologin.Name = "logologin"
        logologin.Size = New Size(218, 261)
        logologin.SizeMode = PictureBoxSizeMode.Zoom
        logologin.TabIndex = 2
        logologin.TabStop = False
        ' 
        ' usuariologin
        ' 
        usuariologin.BackColor = Color.FromArgb(CByte(22), CByte(71), CByte(115))
        usuariologin.BorderStyle = BorderStyle.None
        usuariologin.Cursor = Cursors.IBeam
        usuariologin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        usuariologin.ForeColor = Color.Black
        usuariologin.Location = New Point(421, 143)
        usuariologin.Margin = New Padding(3, 4, 3, 4)
        usuariologin.Name = "usuariologin"
        usuariologin.Size = New Size(343, 20)
        usuariologin.TabIndex = 2
        usuariologin.TextAlign = HorizontalAlignment.Center
        ' 
        ' passwordlogin
        ' 
        passwordlogin.BackColor = Color.FromArgb(CByte(22), CByte(71), CByte(115))
        passwordlogin.BorderStyle = BorderStyle.None
        passwordlogin.Cursor = Cursors.IBeam
        passwordlogin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        passwordlogin.ForeColor = Color.Black
        passwordlogin.Location = New Point(421, 256)
        passwordlogin.Margin = New Padding(3, 4, 3, 4)
        passwordlogin.Name = "passwordlogin"
        passwordlogin.Size = New Size(343, 20)
        passwordlogin.TabIndex = 3
        passwordlogin.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        Panel1.Location = New Point(421, 285)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(343, 5)
        Panel1.TabIndex = 4
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        Panel2.Location = New Point(421, 172)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(343, 5)
        Panel2.TabIndex = 5
        ' 
        ' textingreso
        ' 
        textingreso.AutoSize = True
        textingreso.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        textingreso.ForeColor = Color.Silver
        textingreso.Location = New Point(515, 29)
        textingreso.Name = "textingreso"
        textingreso.Size = New Size(182, 50)
        textingreso.TabIndex = 6
        textingreso.Text = "INGRESO"
        ' 
        ' accederlogin
        ' 
        accederlogin.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        accederlogin.FlatStyle = FlatStyle.Flat
        accederlogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        accederlogin.ForeColor = Color.Silver
        accederlogin.Location = New Point(534, 352)
        accederlogin.Margin = New Padding(3, 4, 3, 4)
        accederlogin.Name = "accederlogin"
        accederlogin.Size = New Size(122, 49)
        accederlogin.TabIndex = 7
        accederlogin.Text = "ACCEDER"
        accederlogin.UseVisualStyleBackColor = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(22), CByte(71), CByte(115))
        ClientSize = New Size(897, 460)
        Controls.Add(accederlogin)
        Controls.Add(textingreso)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(passwordlogin)
        Controls.Add(usuariologin)
        Controls.Add(panelleftlogin)
        Controls.Add(cerralogin)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        CType(cerralogin, ComponentModel.ISupportInitialize).EndInit()
        panelleftlogin.ResumeLayout(False)
        CType(logologin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cerralogin As PictureBox
    Friend WithEvents panelleftlogin As Panel
    Friend WithEvents logologin As PictureBox
    Friend WithEvents usuariologin As TextBox
    Friend WithEvents passwordlogin As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents textingreso As Label
    Friend WithEvents accederlogin As Button
End Class
