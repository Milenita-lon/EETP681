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
        Me.PanelBase = New Panel()
        Me.PanelContenido = New Panel()
        Me.btnEliminar = New Button()
        Me.btnEditar = New Button()
        Me.btnAgregar = New Button()
        Me.txtCorreo = New TextBox()
        Me.txtTelefono = New TextBox()
        Me.txtDireccion = New TextBox()
        Me.txtDni = New TextBox()
        Me.txtApellido = New TextBox()
        Me.txtNombre = New TextBox()
        Me.DataGridViewSecretarios = New DataGridView()
        Me.PanelTitulo = New Panel()
        Me.LabelTitulo = New Label()
        Me.PanelBase.SuspendLayout()
        Me.PanelContenido.SuspendLayout()
        CType(Me.DataGridViewSecretarios, ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        ' PanelBase
        '
        Me.PanelBase.BackColor = Color.FromArgb(22, 71, 115)
        Me.PanelBase.Controls.Add(Me.PanelContenido)
        Me.PanelBase.Controls.Add(Me.PanelTitulo)
        Me.PanelBase.Dock = DockStyle.Fill
        Me.PanelBase.Name = "PanelBase"
        Me.PanelBase.Size = New Size(846, 680)
        '
        ' PanelContenido
        '
        Me.PanelContenido.BackColor = Color.FromArgb(244, 244, 244)
        Me.PanelContenido.Controls.Add(Me.btnEliminar)
        Me.PanelContenido.Controls.Add(Me.btnEditar)
        Me.PanelContenido.Controls.Add(Me.btnAgregar)
        Me.PanelContenido.Controls.Add(Me.txtCorreo)
        Me.PanelContenido.Controls.Add(Me.txtTelefono)
        Me.PanelContenido.Controls.Add(Me.txtDireccion)
        Me.PanelContenido.Controls.Add(Me.txtDni)
        Me.PanelContenido.Controls.Add(Me.txtApellido)
        Me.PanelContenido.Controls.Add(Me.txtNombre)
        Me.PanelContenido.Controls.Add(Me.DataGridViewSecretarios)
        Me.PanelContenido.Dock = DockStyle.Fill
        Me.PanelContenido.Location = New Point(0, 100)
        Me.PanelContenido.Size = New Size(846, 580)
        '
        ' DataGridViewSecretarios
        '
        Me.DataGridViewSecretarios.AllowUserToAddRows = False
        Me.DataGridViewSecretarios.AllowUserToDeleteRows = False
        Me.DataGridViewSecretarios.ReadOnly = True
        Me.DataGridViewSecretarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewSecretarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSecretarios.Location = New Point(101, 130)
        Me.DataGridViewSecretarios.Size = New Size(645, 374)
        '
        ' txtNombre
        '
        Me.txtNombre.Location = New Point(101, 44)
        Me.txtNombre.Size = New Size(100, 23)
        Me.txtNombre.PlaceholderText = "Nombre"
        '
        ' txtApellido
        '
        Me.txtApellido.Location = New Point(207, 44)
        Me.txtApellido.Size = New Size(100, 23)
        Me.txtApellido.PlaceholderText = "Apellido"
        '
        ' txtDni
        '
        Me.txtDni.Location = New Point(313, 44)
        Me.txtDni.Size = New Size(100, 23)
        Me.txtDni.PlaceholderText = "DNI"
        '
        ' txtDireccion
        '
        Me.txtDireccion.Location = New Point(419, 44)
        Me.txtDireccion.Size = New Size(100, 23)
        Me.txtDireccion.PlaceholderText = "Dirección"
        '
        ' txtTelefono
        '
        Me.txtTelefono.Location = New Point(525, 44)
        Me.txtTelefono.Size = New Size(100, 23)
        Me.txtTelefono.PlaceholderText = "Teléfono"
        '
        ' txtCorreo
        '
        Me.txtCorreo.Location = New Point(631, 44)
        Me.txtCorreo.Size = New Size(115, 23)
        Me.txtCorreo.PlaceholderText = "Correo"
        '
        ' btnAgregar
        '
        Me.btnAgregar.Location = New Point(101, 82)
        Me.btnAgregar.Size = New Size(75, 23)
        Me.btnAgregar.Text = "Agregar"
        '
        ' btnEditar
        '
        Me.btnEditar.Location = New Point(182, 82)
        Me.btnEditar.Size = New Size(75, 23)
        Me.btnEditar.Text = "Editar"
        '
        ' btnEliminar
        '
        Me.btnEliminar.Location = New Point(263, 82)
        Me.btnEliminar.Size = New Size(75, 23)
        Me.btnEliminar.Text = "Eliminar"
        '
        ' PanelTitulo
        '
        Me.PanelTitulo.BackColor = Color.FromArgb(4, 36, 64)
        Me.PanelTitulo.Controls.Add(Me.LabelTitulo)
        Me.PanelTitulo.Dock = DockStyle.Top
        Me.PanelTitulo.Size = New Size(846, 100)
        '
        ' LabelTitulo
        '
        Me.LabelTitulo.Dock = DockStyle.Fill
        Me.LabelTitulo.Font = New Font("Segoe UI", 32.0!, FontStyle.Bold)
        Me.LabelTitulo.ForeColor = Color.White
        Me.LabelTitulo.Text = "SECRETARIOS"
        Me.LabelTitulo.TextAlign = ContentAlignment.MiddleCenter
        '
        ' Secretarios
        '
        Me.AutoScaleDimensions = New SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(846, 680)
        Me.Controls.Add(Me.PanelBase)
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Text = "Secretarios"
        Me.PanelBase.ResumeLayout(False)
        Me.PanelContenido.ResumeLayout(False)
        Me.PanelContenido.PerformLayout()
        CType(Me.DataGridViewSecretarios, ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitulo.ResumeLayout(False)
        Me.ResumeLayout(False)
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
