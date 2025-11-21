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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PanelBase = New Panel()
        PanelContenido = New Panel()
        DataGridViewAlumnos = New DataGridView()
        btnEliminar = New Button()
        btnEditar = New Button()
        btnAgregar = New Button()
        txtCorreo = New TextBox()
        txtTelefono = New TextBox()
        txtDireccion = New TextBox()
        txtDni = New TextBox()
        txtApellido = New TextBox()
        txtNombre = New TextBox()
        LabelCursos = New Label()
        ComboBox1 = New ComboBox()
        PanelTitulo = New Panel()
        LabelTitulo = New Label()
        PanelBase.SuspendLayout()
        PanelContenido.SuspendLayout()
        CType(DataGridViewAlumnos, ComponentModel.ISupportInitialize).BeginInit()
        PanelTitulo.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelBase
        ' 
        PanelBase.Controls.Add(PanelContenido)
        PanelBase.Controls.Add(PanelTitulo)
        PanelBase.Dock = DockStyle.Fill
        PanelBase.Location = New Point(0, 0)
        PanelBase.Margin = New Padding(3, 4, 3, 4)
        PanelBase.Name = "PanelBase"
        PanelBase.Size = New Size(1040, 869)
        PanelBase.TabIndex = 0
        ' 
        ' PanelContenido
        ' 
        PanelContenido.Controls.Add(DataGridViewAlumnos)
        PanelContenido.Controls.Add(btnEliminar)
        PanelContenido.Controls.Add(btnEditar)
        PanelContenido.Controls.Add(btnAgregar)
        PanelContenido.Controls.Add(txtCorreo)
        PanelContenido.Controls.Add(txtTelefono)
        PanelContenido.Controls.Add(txtDireccion)
        PanelContenido.Controls.Add(txtDni)
        PanelContenido.Controls.Add(txtApellido)
        PanelContenido.Controls.Add(txtNombre)
        PanelContenido.Controls.Add(LabelCursos)
        PanelContenido.Controls.Add(ComboBox1)
        PanelContenido.Dock = DockStyle.Fill
        PanelContenido.Location = New Point(0, 133)
        PanelContenido.Margin = New Padding(3, 4, 3, 4)
        PanelContenido.Name = "PanelContenido"
        PanelContenido.Size = New Size(1040, 736)
        PanelContenido.TabIndex = 1
        ' 
        ' DataGridViewAlumnos
        ' 
        DataGridViewAlumnos.Anchor = AnchorStyles.None
        DataGridViewAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewAlumnos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewAlumnos.BackgroundColor = Color.White
        DataGridViewAlumnos.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(0), CByte(51), CByte(102))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridViewAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(230), CByte(240), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridViewAlumnos.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewAlumnos.EnableHeadersVisualStyles = False
        DataGridViewAlumnos.GridColor = SystemColors.ScrollBar
        DataGridViewAlumnos.Location = New Point(142, 219)
        DataGridViewAlumnos.Margin = New Padding(3, 4, 3, 4)
        DataGridViewAlumnos.Name = "DataGridViewAlumnos"
        DataGridViewAlumnos.RowHeadersVisible = False
        DataGridViewAlumnos.RowHeadersWidth = 51
        DataGridViewAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewAlumnos.Size = New Size(759, 499)
        DataGridViewAlumnos.TabIndex = 18
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Anchor = AnchorStyles.None
        btnEliminar.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnEliminar.ForeColor = Color.White
        btnEliminar.Location = New Point(328, 144)
        btnEliminar.Margin = New Padding(3, 4, 3, 4)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(86, 33)
        btnEliminar.TabIndex = 15
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnEditar
        ' 
        btnEditar.Anchor = AnchorStyles.None
        btnEditar.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        btnEditar.FlatStyle = FlatStyle.Flat
        btnEditar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnEditar.ForeColor = Color.White
        btnEditar.Location = New Point(235, 144)
        btnEditar.Margin = New Padding(3, 4, 3, 4)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(86, 33)
        btnEditar.TabIndex = 16
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Anchor = AnchorStyles.None
        btnAgregar.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        btnAgregar.FlatStyle = FlatStyle.Flat
        btnAgregar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnAgregar.ForeColor = Color.White
        btnAgregar.Location = New Point(143, 144)
        btnAgregar.Margin = New Padding(3, 4, 3, 4)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(86, 33)
        btnAgregar.TabIndex = 17
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Anchor = AnchorStyles.None
        txtCorreo.Location = New Point(750, 93)
        txtCorreo.Margin = New Padding(3, 4, 3, 4)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.PlaceholderText = "Correo"
        txtCorreo.Size = New Size(131, 27)
        txtCorreo.TabIndex = 9
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Anchor = AnchorStyles.None
        txtTelefono.Location = New Point(629, 93)
        txtTelefono.Margin = New Padding(3, 4, 3, 4)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.PlaceholderText = "Teléfono"
        txtTelefono.Size = New Size(114, 27)
        txtTelefono.TabIndex = 10
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Anchor = AnchorStyles.None
        txtDireccion.Location = New Point(507, 93)
        txtDireccion.Margin = New Padding(3, 4, 3, 4)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.PlaceholderText = "Dirección"
        txtDireccion.Size = New Size(114, 27)
        txtDireccion.TabIndex = 11
        ' 
        ' txtDni
        ' 
        txtDni.Anchor = AnchorStyles.None
        txtDni.Location = New Point(386, 93)
        txtDni.Margin = New Padding(3, 4, 3, 4)
        txtDni.Name = "txtDni"
        txtDni.PlaceholderText = "DNI"
        txtDni.Size = New Size(114, 27)
        txtDni.TabIndex = 12
        ' 
        ' txtApellido
        ' 
        txtApellido.Anchor = AnchorStyles.None
        txtApellido.Location = New Point(265, 93)
        txtApellido.Margin = New Padding(3, 4, 3, 4)
        txtApellido.Name = "txtApellido"
        txtApellido.PlaceholderText = "Apellido"
        txtApellido.Size = New Size(114, 27)
        txtApellido.TabIndex = 13
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.None
        txtNombre.Location = New Point(144, 93)
        txtNombre.Margin = New Padding(3, 4, 3, 4)
        txtNombre.Name = "txtNombre"
        txtNombre.PlaceholderText = "Nombre"
        txtNombre.Size = New Size(114, 27)
        txtNombre.TabIndex = 14
        ' 
        ' LabelCursos
        ' 
        LabelCursos.Anchor = AnchorStyles.None
        LabelCursos.AutoSize = True
        LabelCursos.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelCursos.Location = New Point(389, 16)
        LabelCursos.Name = "LabelCursos"
        LabelCursos.Size = New Size(106, 32)
        LabelCursos.TabIndex = 6
        LabelCursos.Text = "CURSOS"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.None
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(494, 16)
        ComboBox1.Margin = New Padding(3, 4, 3, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(157, 28)
        ComboBox1.TabIndex = 4
        ' 
        ' PanelTitulo
        ' 
        PanelTitulo.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        PanelTitulo.Controls.Add(LabelTitulo)
        PanelTitulo.Dock = DockStyle.Top
        PanelTitulo.Location = New Point(0, 0)
        PanelTitulo.Margin = New Padding(3, 4, 3, 4)
        PanelTitulo.Name = "PanelTitulo"
        PanelTitulo.Size = New Size(1040, 133)
        PanelTitulo.TabIndex = 0
        ' 
        ' LabelTitulo
        ' 
        LabelTitulo.Dock = DockStyle.Fill
        LabelTitulo.Font = New Font("Segoe UI", 32F, FontStyle.Bold)
        LabelTitulo.ForeColor = Color.White
        LabelTitulo.Location = New Point(0, 0)
        LabelTitulo.Name = "LabelTitulo"
        LabelTitulo.Size = New Size(1040, 133)
        LabelTitulo.TabIndex = 1
        LabelTitulo.Text = "ALUMNOS"
        LabelTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Alumnos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1040, 869)
        Controls.Add(PanelBase)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Alumnos"
        Text = "Alumnos"
        PanelBase.ResumeLayout(False)
        PanelContenido.ResumeLayout(False)
        PanelContenido.PerformLayout()
        CType(DataGridViewAlumnos, ComponentModel.ISupportInitialize).EndInit()
        PanelTitulo.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelBase As Panel
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LabelCursos As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents DataGridViewAlumnos As DataGridView
End Class
