Public Class Viewer
    Dim _parentPicture As BooruPic
    Public Property parentPicture()
        Get
            Return _parentPicture
        End Get
        Set(ByVal value)
            _parentPicture = value
        End Set
    End Property

    Sub loadPic(Optional ByVal first As Boolean = False)
        spinner.Visible = True
        ListBox1.Items.Clear()
        If Not first Then pic.Image.Dispose()
        CurLbl.Text = CStr(_parentPicture.getMyIdx + 1) + " of " + CStr(Form1.FlowLayoutPanel1.Controls.Count)
        Application.DoEvents()
        pic.Load(_parentPicture.getFullUrl)
        For Each a As String In _parentPicture.tags.ToString.Trim.Split(" ")
            ListBox1.Items.Add(a)
        Next
        spinner.Visible = False
    End Sub

    Private Sub Viewer_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        loadPic(True)
    End Sub

    Private Sub Dnld_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dnld.Click
        _parentPicture.DownloadToolStripMenuItem.PerformClick()
    End Sub

    Private Sub urlCp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles urlCp.Click
        _parentPicture.CopyURLToolStripMenuItem.PerformClick()
    End Sub

    Private Sub Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prev.Click
        _parentPicture = Form1.FlowLayoutPanel1.Controls(_parentPicture.getMyIdx - 1)
        loadPic()
    End Sub

    Private Sub NxtPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NxtPic.Click
        _parentPicture = Form1.FlowLayoutPanel1.Controls(_parentPicture.getMyIdx + 1)
        loadPic()
    End Sub

    Private Sub Viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources._1357751289_25239
    End Sub

    Private Sub pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic.Click

    End Sub

    Private Sub pic_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic.MouseWheel
        If e.Delta < 0 Then
            Me.Prev.PerformClick()
        ElseIf e.Delta > 0 Then
            Me.NxtPic.PerformClick()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class