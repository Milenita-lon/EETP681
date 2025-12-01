<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preceptores
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
        DataGridViewPreceptores = New DataGridView()
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
        CType(DataGridViewPreceptores, ComponentModel.ISupportInitialize).BeginInit()
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
        PanelBase.Size = New Size(940, 629)
        PanelBase.TabIndex = 0
        ' 
        ' PanelContenido
        ' 
        PanelContenido.BackColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        PanelContenido.Controls.Add(DataGridViewPreceptores)
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
        PanelContenido.Size = New Size(940, 529)
        PanelContenido.TabIndex = 0
        ' 
        ' DataGridViewPreceptores
        ' 
        DataGridViewPreceptores.Anchor = AnchorStyles.None
        DataGridViewPreceptores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewPreceptores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewPreceptores.BackgroundColor = Color.White
        DataGridViewPreceptores.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(0), CByte(51), CByte(102))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridViewPreceptores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewPreceptores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(230), CByte(240), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridViewPreceptores.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewPreceptores.EnableHeadersVisualStyles = False
        DataGridViewPreceptores.GridColor = SystemColors.ScrollBar
        DataGridViewPreceptores.Location = New Point(148, 104)
        DataGridViewPreceptores.Name = "DataGridViewPreceptores"
        DataGridViewPreceptores.RowHeadersVisible = False
        DataGridViewPreceptores.RowHeadersWidth = 51
        DataGridViewPreceptores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewPreceptores.Size = New Size(664, 374)
        DataGridViewPreceptores.TabIndex = 19
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Anchor = AnchorStyles.None
        btnEliminar.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnEliminar.ForeColor = Color.White
        btnEliminar.Location = New Point(310, 56)
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
        btnEditar.Location = New Point(229, 56)
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
        btnAgregar.Location = New Point(148, 56)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(75, 25)
        btnAgregar.TabIndex = 7
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Anchor = AnchorStyles.None
        txtCorreo.Location = New Point(678, 20)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.PlaceholderText = "Correo"
        txtCorreo.Size = New Size(115, 23)
        txtCorreo.TabIndex = 6
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Anchor = AnchorStyles.None
        txtTelefono.Location = New Point(572, 20)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.PlaceholderText = "Teléfono"
        txtTelefono.Size = New Size(100, 23)
        txtTelefono.TabIndex = 5
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Anchor = AnchorStyles.None
        txtDireccion.Location = New Point(466, 20)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.PlaceholderText = "Dirección"
        txtDireccion.Size = New Size(100, 23)
        txtDireccion.TabIndex = 4
        ' 
        ' txtDni
        ' 
        txtDni.Anchor = AnchorStyles.None
        txtDni.Location = New Point(360, 20)
        txtDni.Name = "txtDni"
        txtDni.PlaceholderText = "DNI"
        txtDni.Size = New Size(100, 23)
        txtDni.TabIndex = 3
        ' 
        ' txtApellido
        ' 
        txtApellido.Anchor = AnchorStyles.None
        txtApellido.Location = New Point(254, 20)
        txtApellido.Name = "txtApellido"
        txtApellido.PlaceholderText = "Apellido"
        txtApellido.Size = New Size(100, 23)
        txtApellido.TabIndex = 2
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.None
        txtNombre.Location = New Point(148, 20)
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
        PanelTitulo.Size = New Size(940, 100)
        PanelTitulo.TabIndex = 1
        ' 
        ' LabelTitulo
        ' 
        LabelTitulo.Dock = DockStyle.Fill
        LabelTitulo.Font = New Font("Segoe UI", 32F, FontStyle.Bold)
        LabelTitulo.ForeColor = Color.White
        LabelTitulo.Location = New Point(0, 0)
        LabelTitulo.Name = "LabelTitulo"
        LabelTitulo.Size = New Size(940, 100)
        LabelTitulo.TabIndex = 0
        LabelTitulo.Text = "PRECEPTORES"
        LabelTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Preceptores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(940, 629)
        Controls.Add(PanelBase)
        FormBorderStyle = FormBorderStyle.None
        Name = "Preceptores"
        Text = "Secretarios"
        PanelBase.ResumeLayout(False)
        PanelContenido.ResumeLayout(False)
        PanelContenido.PerformLayout()
        CType(DataGridViewPreceptores, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridViewPreceptores As DataGridView
End Class
