﻿Imports System.IO
Imports System.Net
Imports WebCameraLibrary
Imports System.Threading

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim request As WebRequest = HttpWebRequest.Create("http://10.0.1.220:88/cgi-bin/CGIProxy.fcgi?cmd=snapPicture2&usr=admin&pwd=monica63")
        Dim request As WebRequest = HttpWebRequest.Create("http://97.72.74.222:8088/cgi-bin/CGIProxy.fcgi?cmd=snapPicture2&usr=admin&pwd=monica63")
        Dim response As WebResponse = request.GetResponse
        Dim thePic As Stream = response.GetResponseStream
        Dim theImage As Image = Image.FromStream(thePic)
        pb.Image = theImage
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim l As WebCameraLibrary.App = New WebCameraLibrary.App
        l.PostPicture()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim l As WebCameraLibrary.App = New WebCameraLibrary.App
        pb.Image = l.GetPicture(3)
        pb.SizeMode = PictureBoxSizeMode.Zoom

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim l As WebCameraLibrary.App = New WebCameraLibrary.App
        pb.SizeMode = PictureBoxSizeMode.Zoom
        For Each img In l.GetPictures
            pb.Image = img.ToImage
            pb.Refresh()
            Thread.Sleep(30)
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i As Integer = 0

        For icnt = 1 To 6
            i += 15
            i = i Mod 60
        Next icnt

    End Sub
End Class
