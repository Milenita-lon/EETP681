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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panelsuperiornotasalum = New Panel()
        titulonotasalum = New Label()
        DataGridViewNotas = New DataGridView()
        Cbmnotasalum = New ComboBox()
        Label1 = New Label()
        LabelCursos = New Label()
        Label2 = New Label()
        cmbMateria = New ComboBox()
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
        DataGridViewNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewNotas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewNotas.BackgroundColor = Color.White
        DataGridViewNotas.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(0), CByte(51), CByte(102))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridViewNotas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(230), CByte(240), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridViewNotas.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewNotas.EnableHeadersVisualStyles = False
        DataGridViewNotas.GridColor = SystemColors.ScrollBar
        DataGridViewNotas.Location = New Point(149, 189)
        DataGridViewNotas.Name = "DataGridViewNotas"
        DataGridViewNotas.RowHeadersVisible = False
        DataGridViewNotas.SelectionMode = DataGridViewSelectionMode.CellSelect
        DataGridViewNotas.Size = New Size(537, 314)
        DataGridViewNotas.TabIndex = 2
        ' 
        ' Cbmnotasalum
        ' 
        Cbmnotasalum.Anchor = AnchorStyles.None
        Cbmnotasalum.FormattingEnabled = True
        Cbmnotasalum.Location = New Point(241, 139)
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
        ' LabelCursos
        ' 
        LabelCursos.Anchor = AnchorStyles.None
        LabelCursos.AutoSize = True
        LabelCursos.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelCursos.Location = New Point(149, 139)
        LabelCursos.Name = "LabelCursos"
        LabelCursos.Size = New Size(75, 25)
        LabelCursos.TabIndex = 7
        LabelCursos.Text = "CURSO"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(407, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 25)
        Label2.TabIndex = 9
        Label2.Text = "MATERIA"
        ' 
        ' cmbMateria
        ' 
        cmbMateria.Anchor = AnchorStyles.None
        cmbMateria.FormattingEnabled = True
        cmbMateria.Location = New Point(507, 139)
        cmbMateria.Name = "cmbMateria"
        cmbMateria.Size = New Size(121, 23)
        cmbMateria.TabIndex = 8
        ' 
        ' notasalum
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(830, 591)
        Controls.Add(Label2)
        Controls.Add(cmbMateria)
        Controls.Add(LabelCursos)
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
    Friend WithEvents LabelCursos As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbMateria As ComboBox
End Class
