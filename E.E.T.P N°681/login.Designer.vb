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
        TextBox1 = New TextBox()
        CType(cerralogin, ComponentModel.ISupportInitialize).BeginInit()
        panelleftlogin.SuspendLayout()
        CType(logologin, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cerralogin
        ' 
        cerralogin.Image = My.Resources.Resources.x
        cerralogin.Location = New Point(736, 12)
        cerralogin.Name = "cerralogin"
        cerralogin.Size = New Size(37, 36)
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
        panelleftlogin.Name = "panelleftlogin"
        panelleftlogin.Size = New Size(253, 345)
        panelleftlogin.TabIndex = 1
        ' 
        ' logologin
        ' 
        logologin.Image = My.Resources.Resources.logo_sin_fondo1
        logologin.Location = New Point(32, 60)
        logologin.Name = "logologin"
        logologin.Size = New Size(191, 196)
        logologin.SizeMode = PictureBoxSizeMode.Zoom
        logologin.TabIndex = 2
        logologin.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(22), CByte(71), CByte(115))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Location = New Point(368, 107)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(300, 23)
        TextBox1.TabIndex = 2
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(22), CByte(71), CByte(115))
        ClientSize = New Size(785, 345)
        Controls.Add(TextBox1)
        Controls.Add(panelleftlogin)
        Controls.Add(cerralogin)
        FormBorderStyle = FormBorderStyle.None
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
    Friend WithEvents TextBox1 As TextBox
End Class
