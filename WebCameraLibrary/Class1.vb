Imports System.Net
Imports System.IO
Imports System.Linq
Imports System.Drawing

Public Class App
    'Dim c As String = "http://10.0.1.220:88/cgi-bin/CGIProxy.fcgi?cmd=snapPicture2&usr=admin&pwd=monica63"

    Private url As String = String.Empty
    Public Sub New()
        url = "http://" + My.Settings.IP + ":" + My.Settings.Port + "/cgi-bin/CGIProxy.fcgi?cmd=snapPicture2"
        url += "&usr=" + My.Settings.UserID
        url += "&pwd=" + My.Settings.Password
    End Sub
    Public Sub PostPicture()
        Dim request As WebRequest = HttpWebRequest.Create(url)
        Dim response As WebResponse = request.GetResponse
        Dim thePic As Stream = response.GetResponseStream
        Dim theBytes() As Byte
        Using ms As MemoryStream = New MemoryStream
            thePic.CopyTo(ms)
            theBytes = ms.ToArray
        End Using
        

        'Dim theImage As Image = Image.FromStream(thePic)
        Using db As CameraDBDataContext = New CameraDBDataContext
            Dim r As New tblWebCamera_DATA
            With r
                .CameraID = 1
                .Date = DateTime.Now
                .Photo = theBytes
            End With
            db.tblWebCamera_DATAs.InsertOnSubmit(r)
            db.SubmitChanges()

        End Using
    End Sub
    Function GetPicture(ID As Integer) As System.Drawing.Image
        Using db As CameraDBDataContext = New CameraDBDataContext
            Dim r As tblWebCamera_DATA = db.tblWebCamera_DATAs.SingleOrDefault(Function(f) f.ID = ID)
            If Not r Is Nothing Then
                Dim ms As MemoryStream = New MemoryStream(r.Photo.ToArray)
                Return Image.FromStream(ms)
            Else
                Return Nothing
            End If
        End Using
    End Function
End Class
