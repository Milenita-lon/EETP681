<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profesores
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PanelBase = New Panel()
        PanelContenido = New Panel()
        DataGridViewProfesores = New DataGridView()
        btnEliminar = New Button()
        btnEditar = New Button()
        btnAgregar = New Button()
        txtCorreo = New TextBox()
        txtTelefono = New TextBox()
        txtDireccion = New TextBox()
        txtDni = New TextBox()
        txtApellido = New TextBox()
        txtNombre = New TextBox()
        PanelTitulo = New Panel()
        LabelTitulo = New Label()
        PanelBase.SuspendLayout()
        PanelContenido.SuspendLayout()
        CType(DataGridViewProfesores, ComponentModel.ISupportInitialize).BeginInit()
        PanelTitulo.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelBase
        ' 
        PanelBase.BackColor = Color.FromArgb(CByte(22), CByte(71), CByte(115))
        PanelBase.Controls.Add(PanelContenido)
        PanelBase.Controls.Add(PanelTitulo)
        PanelBase.Dock = DockStyle.Fill
        PanelBase.Location = New Point(0, 0)
        PanelBase.Name = "PanelBase"
        PanelBase.Size = New Size(928, 632)
        PanelBase.TabIndex = 0
        ' 
        ' PanelContenido
        ' 
        PanelContenido.BackColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        PanelContenido.Controls.Add(DataGridViewProfesores)
        PanelContenido.Controls.Add(btnEliminar)
        PanelContenido.Controls.Add(btnEditar)
        PanelContenido.Controls.Add(btnAgregar)
        PanelContenido.Controls.Add(txtCorreo)
        PanelContenido.Controls.Add(txtTelefono)
        PanelContenido.Controls.Add(txtDireccion)
        PanelContenido.Controls.Add(txtDni)
        PanelContenido.Controls.Add(txtApellido)
        PanelContenido.Controls.Add(txtNombre)
        PanelContenido.Dock = DockStyle.Fill
        PanelContenido.Location = New Point(0, 100)
        PanelContenido.Name = "PanelContenido"
        PanelContenido.Size = New Size(928, 532)
        PanelContenido.TabIndex = 0
        ' 
        ' DataGridViewProfesores
        ' 
        DataGridViewProfesores.Anchor = AnchorStyles.None
        DataGridViewProfesores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewProfesores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewProfesores.BackgroundColor = Color.White
        DataGridViewProfesores.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(0), CByte(51), CByte(102))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridViewProfesores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(230), CByte(240), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridViewProfesores.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewProfesores.EnableHeadersVisualStyles = False
        DataGridViewProfesores.GridColor = SystemColors.ScrollBar
        DataGridViewProfesores.Location = New Point(142, 106)
        DataGridViewProfesores.Name = "DataGridViewProfesores"
        DataGridViewProfesores.RowHeadersVisible = False
        DataGridViewProfesores.RowHeadersWidth = 51
        DataGridViewProfesores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewProfesores.Size = New Size(645, 374)
        DataGridViewProfesores.TabIndex = 19
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Anchor = AnchorStyles.None
        btnEliminar.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnEliminar.ForeColor = Color.White
        btnEliminar.Location = New Point(304, 58)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 25)
        btnEliminar.TabIndex = 9
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
        btnEditar.Location = New Point(223, 58)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(75, 25)
        btnEditar.TabIndex = 8
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
        btnAgregar.Location = New Point(142, 58)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(75, 25)
        btnAgregar.TabIndex = 7
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Anchor = AnchorStyles.None
        txtCorreo.Location = New Point(672, 21)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.PlaceholderText = "Correo"
        txtCorreo.Size = New Size(115, 23)
        txtCorreo.TabIndex = 6
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Anchor = AnchorStyles.None
        txtTelefono.Location = New Point(566, 21)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.PlaceholderText = "Teléfono"
        txtTelefono.Size = New Size(100, 23)
        txtTelefono.TabIndex = 5
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Anchor = AnchorStyles.None
        txtDireccion.Location = New Point(460, 21)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.PlaceholderText = "Dirección"
        txtDireccion.Size = New Size(100, 23)
        txtDireccion.TabIndex = 4
        ' 
        ' txtDni
        ' 
        txtDni.Anchor = AnchorStyles.None
        txtDni.Location = New Point(354, 21)
        txtDni.Name = "txtDni"
        txtDni.PlaceholderText = "DNI"
        txtDni.Size = New Size(100, 23)
        txtDni.TabIndex = 3
        ' 
        ' txtApellido
        ' 
        txtApellido.Anchor = AnchorStyles.None
        txtApellido.Location = New Point(248, 21)
        txtApellido.Name = "txtApellido"
        txtApellido.PlaceholderText = "Apellido"
        txtApellido.Size = New Size(100, 23)
        txtApellido.TabIndex = 2
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.None
        txtNombre.Location = New Point(142, 21)
        txtNombre.Name = "txtNombre"
        txtNombre.PlaceholderText = "Nombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 1
        ' 
        ' PanelTitulo
        ' 
        PanelTitulo.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        PanelTitulo.Controls.Add(LabelTitulo)
        PanelTitulo.Dock = DockStyle.Top
        PanelTitulo.Location = New Point(0, 0)
        PanelTitulo.Name = "PanelTitulo"
        PanelTitulo.Size = New Size(928, 100)
        PanelTitulo.TabIndex = 1
        ' 
        ' LabelTitulo
        ' 
        LabelTitulo.Dock = DockStyle.Fill
        LabelTitulo.Font = New Font("Segoe UI", 32F, FontStyle.Bold)
        LabelTitulo.ForeColor = Color.White
        LabelTitulo.Location = New Point(0, 0)
        LabelTitulo.Name = "LabelTitulo"
        LabelTitulo.Size = New Size(928, 100)
        LabelTitulo.TabIndex = 0
        LabelTitulo.Text = "PROFESORES"
        LabelTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Profesores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(928, 632)
        Controls.Add(PanelBase)
        FormBorderStyle = FormBorderStyle.None
        Name = "Profesores"
        Text = "Secretarios"
        PanelBase.ResumeLayout(False)
        PanelContenido.ResumeLayout(False)
        PanelContenido.PerformLayout()
        CType(DataGridViewProfesores, ComponentModel.ISupportInitialize).EndInit()
        PanelTitulo.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelBase As Panel
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents DataGridViewProfesores As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
End Class
