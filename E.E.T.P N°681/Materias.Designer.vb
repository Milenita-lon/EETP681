<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Materias
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
        PanelsuperiorMaterias = New Panel()
        Label1 = New Label()
        cbmCurso = New ComboBox()
        dgvMaterias = New DataGridView()
        PanelsuperiorMaterias.SuspendLayout()
        CType(dgvMaterias, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelsuperiorMaterias
        ' 
        PanelsuperiorMaterias.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        PanelsuperiorMaterias.Controls.Add(Label1)
        PanelsuperiorMaterias.Dock = DockStyle.Top
        PanelsuperiorMaterias.Location = New Point(0, 0)
        PanelsuperiorMaterias.Name = "PanelsuperiorMaterias"
        PanelsuperiorMaterias.Size = New Size(846, 100)
        PanelsuperiorMaterias.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(310, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(237, 59)
        Label1.TabIndex = 1
        Label1.Text = "MATERIAS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cbmCurso
        ' 
        cbmCurso.Anchor = AnchorStyles.None
        cbmCurso.FormattingEnabled = True
        cbmCurso.Location = New Point(360, 131)
        cbmCurso.Name = "cbmCurso"
        cbmCurso.Size = New Size(121, 23)
        cbmCurso.TabIndex = 1
        ' 
        ' dgvMaterias
        ' 
        dgvMaterias.Anchor = AnchorStyles.None
        dgvMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMaterias.Location = New Point(57, 181)
        dgvMaterias.Name = "dgvMaterias"
        dgvMaterias.Size = New Size(731, 371)
        dgvMaterias.TabIndex = 2
        ' 
        ' Materias
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(846, 680)
        Controls.Add(dgvMaterias)
        Controls.Add(cbmCurso)
        Controls.Add(PanelsuperiorMaterias)
        FormBorderStyle = FormBorderStyle.None
        Name = "Materias"
        Text = "Materias"
        PanelsuperiorMaterias.ResumeLayout(False)
        PanelsuperiorMaterias.PerformLayout()
        CType(dgvMaterias, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelsuperiorMaterias As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cbmCurso As ComboBox
    Friend WithEvents dgvMaterias As DataGridView
End Class
