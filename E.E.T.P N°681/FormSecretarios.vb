Imports System.Drawing.Imaging

Public Class FormSecretarios

    ' Función que devuelve una nueva imagen con la opacidad ajustada
    Function AjustarOpacidad(logomenu As Image, opacidad As Single) As Image
        ' Crear un bitmap del mismo tamaño
        Dim bmp As New Bitmap(logomenu.Width, logomenu.Height)
        ' Crear una matriz de color para ajustar el canal alfa
        Dim matrix As New ColorMatrix()
        matrix.Matrix33 = opacidad ' Valor entre 0.0 (transparente) y 1.0 (opaco)
        ' Crear atributos y aplicar la matriz
        Dim atributos As New ImageAttributes()
        atributos.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap)
        ' Dibujar la imagen con opacidad ajustada en el nuevo bitmap
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(logomenu,
            New Rectangle(0, 0, bmp.Width, bmp.Height),
            0, 0, logomenu.Width, logomenu.Height,
            GraphicsUnit.Pixel, atributos)
        End Using

        Return bmp
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelBienvenida.Text = "Bienvenido, " & login.secretarioApellido
        ' Cargar imagen "logo sin fondo1.png" desde la carpeta de recursos del proyecto
        Dim img As Image = My.Resources.logo_sin_fondo1
        ' Aplicar opacidad del 50%
        Dim imgTransparente As Image = AjustarOpacidad(img, 0.3F)
        ' Mostrar en un PictureBox
        logomenu.Image = imgTransparente
        logomenu.SizeMode = PictureBoxSizeMode.StretchImage
        hideSubMenu()

    End Sub

    Private Sub hideSubMenu()
        submenuPD.Visible = False
        submenuGA.Visible = False
    End Sub

    Private Sub ShowSubMenu(submenu As Panel)

        If submenu.Visible = False Then
            hideSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub botonPD_Click(sender As Object, e As EventArgs) Handles botonPD.Click
        ShowSubMenu(submenuPD)
    End Sub

    Private Sub botonGA_Click(sender As Object, e As EventArgs) Handles botonGA.Click
        ShowSubMenu(submenuGA)
    End Sub

    ' Método para abrir un formulario dentro del PanelPantalla
    Private Sub AbrirFormEnPanel(formHijo As Form)
        ' Limpiar el contenido previo
        PanelPantalla.Controls.Clear()

        ' Configurar el formulario hijo
        formHijo.TopLevel = False
        formHijo.FormBorderStyle = FormBorderStyle.None
        formHijo.Dock = DockStyle.Fill

        ' Agregarlo al panel y mostrarlo
        PanelPantalla.Controls.Add(formHijo)
        formHijo.Show()
    End Sub

    Private Sub botonSecre_Click(sender As Object, e As EventArgs)
        AbrirFormEnPanel(New Secretarios)
    End Sub

    Private Sub botonProfes_Click(sender As Object, e As EventArgs) Handles botonProfes.Click
        AbrirFormEnPanel(New Profesores())
    End Sub

    Private Sub botonPrecep_Click(sender As Object, e As EventArgs) Handles botonPrecep.Click
        AbrirFormEnPanel(New Preceptores())
    End Sub

    Private Sub botonAlum_Click(sender As Object, e As EventArgs) Handles botonAlum.Click
        AbrirFormEnPanel(New Alumnos())
    End Sub

    Private Sub botonCurs_Click(sender As Object, e As EventArgs) Handles botonCurs.Click
        AbrirFormEnPanel(New Curso())
    End Sub

    Private Sub botonNotas_Click(sender As Object, e As EventArgs) Handles botonNotas.Click
        AbrirFormEnPanel(New Notas())
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        login.Close()
        Dispose()
    End Sub

    Private Sub botonMinimizar_Click(sender As Object, e As EventArgs) Handles botonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class