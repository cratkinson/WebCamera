Imports System.Threading
Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Dim l As WebCameraLibrary.App = New WebCameraLibrary.App
        'Dim theCnt As Integer = l.LastID
        'Dim d As List(Of WebCameraLibrary.tblWebCamera_DATA) = l.GetPictureRange(theCnt - 96, theCnt)
        'TblWebCameraDATABindingSource.DataSource = d 'l.GetPictures

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As List(Of WebCameraLibrary.tblWebCamera_DATA) = TblWebCameraDATABindingSource.DataSource
        For Each p In d
            pb.Image = p.PhotoImage
            pb.Refresh()
            Thread.Sleep(10)
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim l As WebCameraLibrary.App = New WebCameraLibrary.App
        Dim theCnt As Integer = l.LastID
        Dim d As List(Of WebCameraLibrary.tblWebCamera_DATA) = l.GetPictureRange(theCnt - 96, theCnt)
        TblWebCameraDATABindingSource.DataSource = d 'l.GetPictures
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim l As WebCameraLibrary.App = New WebCameraLibrary.App

        Dim p As WebCameraLibrary.tblWebCamera_DATA = l.GetPictureAll(l.LastID)
        Dim t As Decimal = l.GetTemperature(p)

        Dim aImage As Image = p.PhotoImage
        'pb.Image = p.PhotoImage
        Dim g As Graphics = Graphics.FromImage(aImage)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.DrawString(t.ToString("0.0°"), New Font("Calibri", 18, FontStyle.Bold), Brushes.AntiqueWhite, New Point(110, 20))
        pb.Image = aImage


    End Sub
End Class