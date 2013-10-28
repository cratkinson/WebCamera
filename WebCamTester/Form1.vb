Imports System.IO
Imports System.Net
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim request As WebRequest = HttpWebRequest.Create("http://10.0.1.220:88/cgi-bin/CGIProxy.fcgi?cmd=snapPicture2&usr=admin&pwd=monica63")
        Dim request As WebRequest = HttpWebRequest.Create("http://97.72.74.222:8088/cgi-bin/CGIProxy.fcgi?cmd=snapPicture2&usr=admin&pwd=monica63")
        Dim response As WebResponse = request.GetResponse
        Dim thePic As Stream = response.GetResponseStream
        Dim theImage As Image = Image.FromStream(thePic)
        pb.Image = theImage
    End Sub
End Class
