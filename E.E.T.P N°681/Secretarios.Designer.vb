<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Secretarios
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
        PanelBase = New Panel()
        PanelContenido = New Panel()
        btnEliminar = New Button()
        btnEditar = New Button()
        btnAgregar = New Button()
        txtCorreo = New TextBox()
        txtTelefono = New TextBox()
        txtDireccion = New TextBox()
        txtDni = New TextBox()
        txtApellido = New TextBox()
        txtNombre = New TextBox()
        DataGridViewSecretarios = New DataGridView()
        PanelTitulo = New Panel()
        LabelTitulo = New Label()
        PanelBase.SuspendLayout()
        PanelContenido.SuspendLayout()
        CType(DataGridViewSecretarios, ComponentModel.ISupportInitialize).BeginInit()
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
        PanelBase.Size = New Size(846, 680)
        PanelBase.TabIndex = 0
        ' 
        ' PanelContenido
        ' 
        PanelContenido.BackColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        PanelContenido.Controls.Add(btnEliminar)
        PanelContenido.Controls.Add(btnEditar)
        PanelContenido.Controls.Add(btnAgregar)
        PanelContenido.Controls.Add(txtCorreo)
        PanelContenido.Controls.Add(txtTelefono)
        PanelContenido.Controls.Add(txtDireccion)
        PanelContenido.Controls.Add(txtDni)
        PanelContenido.Controls.Add(txtApellido)
        PanelContenido.Controls.Add(txtNombre)
        PanelContenido.Controls.Add(DataGridViewSecretarios)
        PanelContenido.Dock = DockStyle.Fill
        PanelContenido.Location = New Point(0, 100)
        PanelContenido.Name = "PanelContenido"
        PanelContenido.Size = New Size(846, 580)
        PanelContenido.TabIndex = 0
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Anchor = AnchorStyles.None
        btnEliminar.Location = New Point(263, 82)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 0
        btnEliminar.Text = "Eliminar"
        ' 
        ' btnEditar
        ' 
        btnEditar.Anchor = AnchorStyles.None
        btnEditar.Location = New Point(182, 82)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(75, 23)
        btnEditar.TabIndex = 1
        btnEditar.Text = "Editar"
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Anchor = AnchorStyles.None
        btnAgregar.Location = New Point(101, 82)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(75, 23)
        btnAgregar.TabIndex = 2
        btnAgregar.Text = "Agregar"
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Anchor = AnchorStyles.None
        txtCorreo.Location = New Point(631, 44)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.PlaceholderText = "Correo"
        txtCorreo.Size = New Size(115, 23)
        txtCorreo.TabIndex = 3
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Anchor = AnchorStyles.None
        txtTelefono.Location = New Point(525, 44)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.PlaceholderText = "Teléfono"
        txtTelefono.Size = New Size(100, 23)
        txtTelefono.TabIndex = 4
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Anchor = AnchorStyles.None
        txtDireccion.Location = New Point(419, 44)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.PlaceholderText = "Dirección"
        txtDireccion.Size = New Size(100, 23)
        txtDireccion.TabIndex = 5
        ' 
        ' txtDni
        ' 
        txtDni.Anchor = AnchorStyles.None
        txtDni.Location = New Point(313, 44)
        txtDni.Name = "txtDni"
        txtDni.PlaceholderText = "DNI"
        txtDni.Size = New Size(100, 23)
        txtDni.TabIndex = 6
        ' 
        ' txtApellido
        ' 
        txtApellido.Anchor = AnchorStyles.None
        txtApellido.Location = New Point(207, 44)
        txtApellido.Name = "txtApellido"
        txtApellido.PlaceholderText = "Apellido"
        txtApellido.Size = New Size(100, 23)
        txtApellido.TabIndex = 7
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.None
        txtNombre.Location = New Point(101, 44)
        txtNombre.Name = "txtNombre"
        txtNombre.PlaceholderText = "Nombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 8
        ' 
        ' DataGridViewSecretarios
        ' 
        DataGridViewSecretarios.AllowUserToAddRows = False
        DataGridViewSecretarios.AllowUserToDeleteRows = False
        DataGridViewSecretarios.Anchor = AnchorStyles.None
        DataGridViewSecretarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewSecretarios.Location = New Point(101, 130)
        DataGridViewSecretarios.Name = "DataGridViewSecretarios"
        DataGridViewSecretarios.ReadOnly = True
        DataGridViewSecretarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewSecretarios.Size = New Size(645, 374)
        DataGridViewSecretarios.TabIndex = 9
        ' 
        ' PanelTitulo
        ' 
        PanelTitulo.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        PanelTitulo.Controls.Add(LabelTitulo)
        PanelTitulo.Dock = DockStyle.Top
        PanelTitulo.Location = New Point(0, 0)
        PanelTitulo.Name = "PanelTitulo"
        PanelTitulo.Size = New Size(846, 100)
        PanelTitulo.TabIndex = 1
        ' 
        ' LabelTitulo
        ' 
        LabelTitulo.Dock = DockStyle.Fill
        LabelTitulo.Font = New Font("Segoe UI", 32F, FontStyle.Bold)
        LabelTitulo.ForeColor = Color.White
        LabelTitulo.Location = New Point(0, 0)
        LabelTitulo.Name = "LabelTitulo"
        LabelTitulo.Size = New Size(846, 100)
        LabelTitulo.TabIndex = 0
        LabelTitulo.Text = "SECRETARIOS"
        LabelTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Secretarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(846, 680)
        Controls.Add(PanelBase)
        FormBorderStyle = FormBorderStyle.None
        Name = "Secretarios"
        Text = "Secretarios"
        PanelBase.ResumeLayout(False)
        PanelContenido.ResumeLayout(False)
        PanelContenido.PerformLayout()
        CType(DataGridViewSecretarios, ComponentModel.ISupportInitialize).EndInit()
        PanelTitulo.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelBase As Panel
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents DataGridViewSecretarios As DataGridView
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
