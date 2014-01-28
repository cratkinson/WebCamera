Imports System.Net
Imports System.IO
Imports System.Linq
Imports System.Drawing
Imports LinqKit.PredicateBuilder


Public Class App
    Private url As String = String.Empty
    Private _recordPointer As Integer = 0
    Public Sub New()
        url = "http://" + My.Settings.IP + ":" + My.Settings.Port + "/cgi-bin/CGIProxy.fcgi?cmd=snapPicture2"
        url += "&usr=" + My.Settings.UserID
        url += "&pwd=" + My.Settings.Password
    End Sub
    Public Sub PostPicture()
        Try
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
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub
    Function GetPictureAll(ID As Integer) As tblWebCamera_DATA
        Try
            Using db As CameraDBDataContext = New CameraDBDataContext
                Return db.tblWebCamera_DATAs.SingleOrDefault(Function(f) f.ID = ID)
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Function GetPicture(ID As Integer) As System.Drawing.Image
        Try
            Using db As CameraDBDataContext = New CameraDBDataContext
                Dim r As tblWebCamera_DATA = db.tblWebCamera_DATAs.SingleOrDefault(Function(f) f.ID = ID)
                If Not r Is Nothing Then
                    Dim ms As MemoryStream = New MemoryStream(r.Photo.ToArray)
                    Return Image.FromStream(ms)
                Else
                    Return Nothing
                End If
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function GetPictureRange(startID As Integer, endID As Integer) As List(Of tblWebCamera_DATA)
        Try
            Using db As CameraDBDataContext = New CameraDBDataContext
                Dim p = LinqKit.PredicateBuilder.True(Of tblWebCamera_DATA)()
                p = p.And(Function(f) f.ID >= startID)
                p = p.And(Function(f) f.ID <= endID)

                Return db.tblWebCamera_DATAs.Where(p).ToList
            End Using

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function GetPictures() As List(Of tblWebCamera_DATA)
        Try
            Using db As CameraDBDataContext = New CameraDBDataContext
                Return db.tblWebCamera_DATAs.ToList
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function GetTemperature(thePhoto As tblWebCamera_DATA) As Decimal
        Dim theDate As Date = thePhoto.Date
        Using db As CameraDBDataContext = New CameraDBDataContext
            Return db.usp_BLISS_CLOSEST_TMP(theDate).FirstOrDefault.TMP
        End Using
    End Function
    '-----------------------------------------------------------------------------------
    ' Recordset Like Functions
    '-----------------------------------------------------------------------------------
    Function Count() As Integer
        Using db As CameraDBDataContext = New CameraDBDataContext
            Return db.tblWebCamera_DATAs.Count
        End Using
    End Function
    Function LastID() As Integer
        Using db As CameraDBDataContext = New CameraDBDataContext
            Dim q As tblWebCamera_DATA = db.tblWebCamera_DATAs.OrderByDescending(Function(f) f.ID).FirstOrDefault

            Return q.ID
        End Using
    End Function
End Class
