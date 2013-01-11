Imports System.Net
Public Class BooruPic
    Dim fullUrl As String = ""
    Dim myIdx As Integer = -1
    Dim _tags As String
    Public Property tags()
        Get
            Return _tags
        End Get
        Set(ByVal value)
            _tags = value
        End Set
    End Property
    Event dblC(ByVal sender As BooruPic)
    Public Sub setFullurl(ByVal ur As String)
        fullUrl = ur
    End Sub
    Public Function getFullUrl()
        Return fullUrl
    End Function
    Public Function getMyIdx()
        Return myIdx
    End Function
    Public Sub setMyIdx(ByVal idx As Integer)
        myIdx = idx
    End Sub
    Public Sub loadUrl(ByVal url As String)
        Me._innerPic.SizeMode = PictureBoxSizeMode.AutoSize
        Me._innerPic.Load(url)
    End Sub


    Private Sub DownloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadToolStripMenuItem.Click
        Dim myPic As Image = Me._innerPic.Image.Clone
        Dim dler As New WebClient
        Dim fx = Split(fullUrl, ".")
        Dim f As New SaveFileDialog
        f.Filter = "*." + fx(UBound(fx)) + "|*." + fx(UBound(fx))
        f.ShowDialog()
        If f.FileName = "" Then Return
        Me._innerPic.SizeMode = PictureBoxSizeMode.Zoom
        Me._innerPic.Image = My.Resources.spin_color
        Application.DoEvents()
        dler.DownloadFile(New System.Uri(fullUrl), f.FileName)
        MsgBox("Download complete!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Okay")
        Me._innerPic.SizeMode = PictureBoxSizeMode.AutoSize
        Me._innerPic.Image = myPic.Clone
        myPic.Dispose()
    End Sub

    Private Sub CopyURLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyURLToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(fullUrl)
    End Sub


    Private Sub _innerPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _innerPic.Click

    End Sub

    Private Sub _innerPic_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles _innerPic.DoubleClick
        RaiseEvent dblC(Me)
    End Sub
End Class
