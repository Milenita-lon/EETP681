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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        PanelsuperiorMaterias.Margin = New Padding(3, 4, 3, 4)
        PanelsuperiorMaterias.Name = "PanelsuperiorMaterias"
        PanelsuperiorMaterias.Size = New Size(967, 133)
        PanelsuperiorMaterias.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(354, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(297, 72)
        Label1.TabIndex = 1
        Label1.Text = "MATERIAS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cbmCurso
        ' 
        cbmCurso.Anchor = AnchorStyles.None
        cbmCurso.FormattingEnabled = True
        cbmCurso.Location = New Point(411, 175)
        cbmCurso.Margin = New Padding(3, 4, 3, 4)
        cbmCurso.Name = "cbmCurso"
        cbmCurso.Size = New Size(138, 28)
        cbmCurso.TabIndex = 1
        ' 
        ' dgvMaterias
        ' 
        dgvMaterias.Anchor = AnchorStyles.None
        dgvMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMaterias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvMaterias.BackgroundColor = Color.White
        dgvMaterias.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(0), CByte(51), CByte(102))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvMaterias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(230), CByte(240), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvMaterias.DefaultCellStyle = DataGridViewCellStyle2
        dgvMaterias.EnableHeadersVisualStyles = False
        dgvMaterias.GridColor = SystemColors.ScrollBar
        dgvMaterias.Location = New Point(66, 293)
        dgvMaterias.Margin = New Padding(3, 4, 3, 4)
        dgvMaterias.Name = "dgvMaterias"
        dgvMaterias.RowHeadersVisible = False
        dgvMaterias.RowHeadersWidth = 51
        dgvMaterias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMaterias.Size = New Size(834, 493)
        dgvMaterias.TabIndex = 3
        ' 
        ' Materias
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(967, 907)
        Controls.Add(dgvMaterias)
        Controls.Add(cbmCurso)
        Controls.Add(PanelsuperiorMaterias)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
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
