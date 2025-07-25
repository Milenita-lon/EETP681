Imports System.Drawing.Imaging

Public Class Form1

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
        ' Cargar imagen desde archivo
        Dim img As Image = Image.FromFile("D:\Usuarios\Usuario\Escritorio\E.E.T.P N°681\E.E.T.P N°681\Resources\logo sin fondo1.png")

        ' Aplicar opacidad del 50%
        Dim imgTransparente As Image = AjustarOpacidad(img, 0.3F)

        ' Mostrar en un PictureBox
        logomenu.Image = imgTransparente
        logomenu.SizeMode = PictureBoxSizeMode.StretchImage

        hideSubMenu()

    End Sub

    Private Sub hideSubMenu()
        submenuAG.Visible = False
        submenuPD.Visible = False
        submenuAU.Visible = False
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

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        login.Close()
        Dispose()
    End Sub

    Private Sub botonAG_Click(sender As Object, e As EventArgs) Handles botonAG.Click
        ShowSubMenu(submenuAG)
    End Sub

    Private Sub botonPD_Click(sender As Object, e As EventArgs) Handles botonPD.Click
        ShowSubMenu(submenuPD)
    End Sub

    Private Sub botonAU_Click(sender As Object, e As EventArgs) Handles botonAU.Click
        ShowSubMenu(submenuAU)
    End Sub

    Private Sub botonGA_Click(sender As Object, e As EventArgs) Handles botonGA.Click
        ShowSubMenu(submenuGA)
    End Sub

    Private Sub submenuGA_Paint(sender As Object, e As PaintEventArgs) Handles submenuGA.Paint

    End Sub

End Class
