<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notasalum
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
        Panelsuperiornotasalum = New Panel()
        titulonotasalum = New Label()
        DataGridViewNotas = New DataGridView()
        Cbmnotasalum = New ComboBox()
        Label1 = New Label()
        Panelsuperiornotasalum.SuspendLayout()
        CType(DataGridViewNotas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panelsuperiornotasalum
        ' 
        Panelsuperiornotasalum.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        Panelsuperiornotasalum.Controls.Add(titulonotasalum)
        Panelsuperiornotasalum.Dock = DockStyle.Top
        Panelsuperiornotasalum.Location = New Point(0, 0)
        Panelsuperiornotasalum.Name = "Panelsuperiornotasalum"
        Panelsuperiornotasalum.Size = New Size(830, 100)
        Panelsuperiornotasalum.TabIndex = 1
        ' 
        ' titulonotasalum
        ' 
        titulonotasalum.Anchor = AnchorStyles.None
        titulonotasalum.AutoSize = True
        titulonotasalum.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        titulonotasalum.ForeColor = Color.White
        titulonotasalum.Location = New Point(335, 22)
        titulonotasalum.Name = "titulonotasalum"
        titulonotasalum.Size = New Size(166, 59)
        titulonotasalum.TabIndex = 0
        titulonotasalum.Text = "NOTAS"
        titulonotasalum.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DataGridViewNotas
        ' 
        DataGridViewNotas.Anchor = AnchorStyles.None
        DataGridViewNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewNotas.Location = New Point(149, 189)
        DataGridViewNotas.Name = "DataGridViewNotas"
        DataGridViewNotas.Size = New Size(537, 314)
        DataGridViewNotas.TabIndex = 2
        ' 
        ' Cbmnotasalum
        ' 
        Cbmnotasalum.Anchor = AnchorStyles.None
        Cbmnotasalum.FormattingEnabled = True
        Cbmnotasalum.Location = New Point(149, 141)
        Cbmnotasalum.Name = "Cbmnotasalum"
        Cbmnotasalum.Size = New Size(121, 23)
        Cbmnotasalum.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(324, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 4
        ' 
        ' notasalum
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(830, 591)
        Controls.Add(Label1)
        Controls.Add(Cbmnotasalum)
        Controls.Add(DataGridViewNotas)
        Controls.Add(Panelsuperiornotasalum)
        FormBorderStyle = FormBorderStyle.None
        Name = "notasalum"
        Panelsuperiornotasalum.ResumeLayout(False)
        Panelsuperiornotasalum.PerformLayout()
        CType(DataGridViewNotas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panelsuperiornotasalum As Panel
    Friend WithEvents titulonotasalum As Label
    Friend WithEvents DataGridViewNotas As DataGridView
    Friend WithEvents Cbmnotasalum As ComboBox
    Friend WithEvents Label1 As Label
End Class
