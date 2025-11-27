<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Notas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        LabelTri = New Label()
        cmbTrimestre = New ComboBox()
        botonPromocionar = New Button()
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
        Panelsuperiornotasalum.Size = New Size(806, 100)
        Panelsuperiornotasalum.TabIndex = 1
        ' 
        ' titulonotasalum
        ' 
        titulonotasalum.Anchor = AnchorStyles.None
        titulonotasalum.AutoSize = True
        titulonotasalum.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        titulonotasalum.ForeColor = Color.White
        titulonotasalum.Location = New Point(323, 22)
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
        DataGridViewNotas.Location = New Point(119, 234)
        DataGridViewNotas.Name = "DataGridViewNotas"
        DataGridViewNotas.RowHeadersVisible = False
        DataGridViewNotas.RowHeadersWidth = 51
        DataGridViewNotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewNotas.Size = New Size(594, 374)
        DataGridViewNotas.TabIndex = 2
        ' 
        ' Cbmnotasalum
        ' 
        Cbmnotasalum.Anchor = AnchorStyles.None
        Cbmnotasalum.FormattingEnabled = True
        Cbmnotasalum.Location = New Point(387, 140)
        Cbmnotasalum.Name = "Cbmnotasalum"
        Cbmnotasalum.Size = New Size(121, 23)
        Cbmnotasalum.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(478, 131)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 4
        ' 
        ' LabelCursos
        ' 
        LabelCursos.Anchor = AnchorStyles.None
        LabelCursos.AutoSize = True
        LabelCursos.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelCursos.Location = New Point(306, 138)
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
        Label2.Location = New Point(154, 184)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 25)
        Label2.TabIndex = 9
        Label2.Text = "MATERIA"
        ' 
        ' cmbMateria
        ' 
        cmbMateria.Anchor = AnchorStyles.None
        cmbMateria.FormattingEnabled = True
        cmbMateria.Location = New Point(250, 186)
        cmbMateria.Name = "cmbMateria"
        cmbMateria.Size = New Size(121, 23)
        cmbMateria.TabIndex = 8
        ' 
        ' LabelTri
        ' 
        LabelTri.Anchor = AnchorStyles.None
        LabelTri.AutoSize = True
        LabelTri.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTri.Location = New Point(417, 184)
        LabelTri.Name = "LabelTri"
        LabelTri.Size = New Size(113, 25)
        LabelTri.TabIndex = 10
        LabelTri.Text = "TRIMESTRE"
        ' 
        ' cmbTrimestre
        ' 
        cmbTrimestre.Anchor = AnchorStyles.None
        cmbTrimestre.FormattingEnabled = True
        cmbTrimestre.Location = New Point(536, 184)
        cmbTrimestre.Name = "cmbTrimestre"
        cmbTrimestre.Size = New Size(121, 23)
        cmbTrimestre.TabIndex = 11
        ' 
        ' botonPromocionar
        ' 
        botonPromocionar.Anchor = AnchorStyles.None
        botonPromocionar.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        botonPromocionar.Cursor = Cursors.Hand
        botonPromocionar.FlatAppearance.BorderSize = 0
        botonPromocionar.FlatStyle = FlatStyle.Flat
        botonPromocionar.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        botonPromocionar.ForeColor = Color.White
        botonPromocionar.Location = New Point(291, 629)
        botonPromocionar.Name = "botonPromocionar"
        botonPromocionar.Size = New Size(239, 36)
        botonPromocionar.TabIndex = 12
        botonPromocionar.Text = "PROMOCIONAR ALUMNOS"
        botonPromocionar.UseVisualStyleBackColor = False
        ' 
        ' Notas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(806, 591)
        Controls.Add(botonPromocionar)
        Controls.Add(cmbTrimestre)
        Controls.Add(LabelTri)
        Controls.Add(Label2)
        Controls.Add(cmbMateria)
        Controls.Add(LabelCursos)
        Controls.Add(Label1)
        Controls.Add(Cbmnotasalum)
        Controls.Add(DataGridViewNotas)
        Controls.Add(Panelsuperiornotasalum)
        FormBorderStyle = FormBorderStyle.None
        Name = "Notas"
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
    Friend WithEvents LabelTri As Label
    Friend WithEvents cmbTrimestre As ComboBox
    Friend WithEvents botonPromocionar As Button
End Class
