Imports System.Drawing
Imports System.IO
Partial Public Class tblWebCamera_DATA
    Public Function ToImage() As Image
        Dim ms As MemoryStream = New MemoryStream(Me.Photo.ToArray)
        Return Image.FromStream(ms)
    End Function
    Public ReadOnly Property PhotoImage As Image
        Get
            Dim ms As MemoryStream = New MemoryStream(Me.Photo.ToArray)
            Return Image.FromStream(ms)
        End Get
    End Property

End Class
