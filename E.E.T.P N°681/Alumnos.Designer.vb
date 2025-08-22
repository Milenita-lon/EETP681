<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alumnos
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
        PanelBase = New Panel()
        PanelContenido = New Panel()
        ComboBox1 = New ComboBox()
        PanelTitulo = New Panel()
        LabelTitulo = New Label()
        DataGridView1 = New DataGridView()
        PanelBase.SuspendLayout()
        PanelContenido.SuspendLayout()
        PanelTitulo.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelBase
        ' 
        PanelBase.Controls.Add(PanelContenido)
        PanelBase.Controls.Add(PanelTitulo)
        PanelBase.Dock = DockStyle.Fill
        PanelBase.Location = New Point(0, 0)
        PanelBase.Name = "PanelBase"
        PanelBase.Size = New Size(846, 680)
        PanelBase.TabIndex = 0
        ' 
        ' PanelContenido
        ' 
        PanelContenido.Controls.Add(DataGridView1)
        PanelContenido.Controls.Add(ComboBox1)
        PanelContenido.Dock = DockStyle.Fill
        PanelContenido.Location = New Point(0, 100)
        PanelContenido.Name = "PanelContenido"
        PanelContenido.Size = New Size(846, 580)
        PanelContenido.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(101, 44)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 4
        ' 
        ' PanelTitulo
        ' 
        PanelTitulo.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        PanelTitulo.Controls.Add(LabelTitulo)
        PanelTitulo.Dock = DockStyle.Top
        PanelTitulo.Location = New Point(0, 0)
        PanelTitulo.Name = "PanelTitulo"
        PanelTitulo.Size = New Size(846, 100)
        PanelTitulo.TabIndex = 0
        ' 
        ' LabelTitulo
        ' 
        LabelTitulo.Dock = DockStyle.Fill
        LabelTitulo.Font = New Font("Segoe UI", 32F, FontStyle.Bold)
        LabelTitulo.ForeColor = Color.White
        LabelTitulo.Location = New Point(0, 0)
        LabelTitulo.Name = "LabelTitulo"
        LabelTitulo.Size = New Size(846, 100)
        LabelTitulo.TabIndex = 1
        LabelTitulo.Text = "ALUMNOS"
        LabelTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(103, 92)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(631, 383)
        DataGridView1.TabIndex = 5
        ' 
        ' Alumnos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(846, 680)
        Controls.Add(PanelBase)
        FormBorderStyle = FormBorderStyle.None
        Name = "Alumnos"
        Text = "Alumnos"
        PanelBase.ResumeLayout(False)
        PanelContenido.ResumeLayout(False)
        PanelTitulo.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelBase As Panel
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
