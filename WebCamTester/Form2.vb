Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim l As WebCameraLibrary.App = New WebCameraLibrary.App
        bs.DataSource = l.GetPictures
        Dim b As New Binding("Image", bs, "PictureImage")
        pb.DataBindings.Add(b)

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub
End Class