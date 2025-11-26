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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PanelBase = New Panel()
        PanelContenido = New Panel()
        DataGridViewSecretarios = New DataGridView()
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
        PanelBase.Margin = New Padding(3, 4, 3, 4)
        PanelBase.Name = "PanelBase"
        PanelBase.Size = New Size(967, 907)
        PanelBase.TabIndex = 0
        ' 
        ' PanelContenido
        ' 
        PanelContenido.BackColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        PanelContenido.Controls.Add(DataGridViewSecretarios)
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
        PanelContenido.Location = New Point(0, 133)
        PanelContenido.Margin = New Padding(3, 4, 3, 4)
        PanelContenido.Name = "PanelContenido"
        PanelContenido.Size = New Size(967, 774)
        PanelContenido.TabIndex = 0
        ' 
        ' DataGridViewSecretarios
        ' 
        DataGridViewSecretarios.Anchor = AnchorStyles.None
        DataGridViewSecretarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewSecretarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewSecretarios.BackgroundColor = Color.White
        DataGridViewSecretarios.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(0), CByte(51), CByte(102))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridViewSecretarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewSecretarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(230), CByte(240), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridViewSecretarios.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewSecretarios.EnableHeadersVisualStyles = False
        DataGridViewSecretarios.GridColor = SystemColors.ScrollBar
        DataGridViewSecretarios.Location = New Point(115, 174)
        DataGridViewSecretarios.Margin = New Padding(3, 4, 3, 4)
        DataGridViewSecretarios.Name = "DataGridViewSecretarios"
        DataGridViewSecretarios.RowHeadersVisible = False
        DataGridViewSecretarios.RowHeadersWidth = 51
        DataGridViewSecretarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewSecretarios.Size = New Size(737, 499)
        DataGridViewSecretarios.TabIndex = 19
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Anchor = AnchorStyles.None
        btnEliminar.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnEliminar.ForeColor = Color.White
        btnEliminar.Location = New Point(301, 110)
        btnEliminar.Margin = New Padding(3, 4, 3, 4)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(86, 33)
        btnEliminar.TabIndex = 0
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
        btnEditar.Location = New Point(208, 110)
        btnEditar.Margin = New Padding(3, 4, 3, 4)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(86, 33)
        btnEditar.TabIndex = 1
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
        btnAgregar.Location = New Point(115, 110)
        btnAgregar.Margin = New Padding(3, 4, 3, 4)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(86, 33)
        btnAgregar.TabIndex = 2
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Anchor = AnchorStyles.None
        txtCorreo.Location = New Point(721, 60)
        txtCorreo.Margin = New Padding(3, 4, 3, 4)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.PlaceholderText = "Correo"
        txtCorreo.Size = New Size(131, 27)
        txtCorreo.TabIndex = 3
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Anchor = AnchorStyles.None
        txtTelefono.Location = New Point(600, 60)
        txtTelefono.Margin = New Padding(3, 4, 3, 4)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.PlaceholderText = "Teléfono"
        txtTelefono.Size = New Size(114, 27)
        txtTelefono.TabIndex = 4
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Anchor = AnchorStyles.None
        txtDireccion.Location = New Point(479, 60)
        txtDireccion.Margin = New Padding(3, 4, 3, 4)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.PlaceholderText = "Dirección"
        txtDireccion.Size = New Size(114, 27)
        txtDireccion.TabIndex = 5
        ' 
        ' txtDni
        ' 
        txtDni.Anchor = AnchorStyles.None
        txtDni.Location = New Point(358, 60)
        txtDni.Margin = New Padding(3, 4, 3, 4)
        txtDni.Name = "txtDni"
        txtDni.PlaceholderText = "DNI"
        txtDni.Size = New Size(114, 27)
        txtDni.TabIndex = 6
        ' 
        ' txtApellido
        ' 
        txtApellido.Anchor = AnchorStyles.None
        txtApellido.Location = New Point(237, 60)
        txtApellido.Margin = New Padding(3, 4, 3, 4)
        txtApellido.Name = "txtApellido"
        txtApellido.PlaceholderText = "Apellido"
        txtApellido.Size = New Size(114, 27)
        txtApellido.TabIndex = 7
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.None
        txtNombre.Location = New Point(115, 60)
        txtNombre.Margin = New Padding(3, 4, 3, 4)
        txtNombre.Name = "txtNombre"
        txtNombre.PlaceholderText = "Nombre"
        txtNombre.Size = New Size(114, 27)
        txtNombre.TabIndex = 8
        ' 
        ' PanelTitulo
        ' 
        PanelTitulo.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        PanelTitulo.Controls.Add(LabelTitulo)
        PanelTitulo.Dock = DockStyle.Top
        PanelTitulo.Location = New Point(0, 0)
        PanelTitulo.Margin = New Padding(3, 4, 3, 4)
        PanelTitulo.Name = "PanelTitulo"
        PanelTitulo.Size = New Size(967, 133)
        PanelTitulo.TabIndex = 1
        ' 
        ' LabelTitulo
        ' 
        LabelTitulo.Dock = DockStyle.Fill
        LabelTitulo.Font = New Font("Segoe UI", 32F, FontStyle.Bold)
        LabelTitulo.ForeColor = Color.White
        LabelTitulo.Location = New Point(0, 0)
        LabelTitulo.Name = "LabelTitulo"
        LabelTitulo.Size = New Size(967, 133)
        LabelTitulo.TabIndex = 0
        LabelTitulo.Text = "SECRETARIOS"
        LabelTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Secretarios
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(967, 907)
        Controls.Add(PanelBase)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
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
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents DataGridViewSecretarios As DataGridView
End Class
