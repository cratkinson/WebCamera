Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim l As WebCameraLibrary.App = New WebCameraLibrary.App
        Dim theCnt As Integer = l.Count
        Dim d As List(Of WebCameraLibrary.tblWebCamera_DATA) = l.GetPictureRange(theCnt - 95, theCnt + 1)
        TblWebCameraDATABindingSource.DataSource = d 'l.GetPictures

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New Form1
        f.Show()

    End Sub
End Class