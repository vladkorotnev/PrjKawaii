Imports System.Xml
Public Class Form1
    Dim totalPostsHere As Integer = 0
    Dim totalTagStr As String
    'Item is filled either manually or from database
    Dim lst As New List(Of String)

    'AutoComplete collection that will help to filter keep the records.
    Dim MySource As New AutoCompleteStringCollection()

    Dim srchQuery As New List(Of String)
    Dim currentlyShownPosts As Integer = 0
    Dim isBoot As Boolean = True
    Function xmlUrlforBoard(ByVal nohttproot As String, ByVal tags As String, ByVal page As Integer)
        Dim r = "http://" + nohttproot + "//index.php?page=dapi&s=post&q=index"
        If tags <> "" Then
            r = r + "&tags=" + Replace(tags, " ", "+")
        End If
        If page > 0 Then
            r = r + "&pid=" + CStr(page)
        End If
        Return r
    End Function

    Sub getNextPg(Optional ByVal onBoot As Boolean = False)

        If currentlyShownPosts = totalPostsHere And Not onBoot Then Me.Button1.Enabled = False : Return
        spinner.Visible = True
        lbHint.Text = "Please wait while loading"
        srch.Enabled = False
        Dim reader As XmlReader
        reader = XmlReader.Create(xmlUrlforBoard(ComboBox1.Text, Me.srch.Text, currentlyShownPosts / 100))
        reader.ReadToFollowing("posts")
        reader.MoveToAttribute("count")
        totalPostsHere = CInt(reader.Value)

        While Not reader.EOF
            reader.ReadToFollowing("post")
            reader.MoveToAttribute("preview_url")
            Dim url = reader.Value

            reader.MoveToAttribute("file_url")
            Dim fullutl = reader.Value

            reader.MoveToAttribute("tags")
            Dim tag = reader.Value
            totalTagStr += tag
            Dim p As New BooruPic
            Application.DoEvents()
            On Error GoTo failed
            p.loadUrl(url)
            p.setFullurl(fullutl)
            p.setMyIdx(Me.FlowLayoutPanel1.Controls.Count)
            p.tags = tag
            Me.FlowLayoutPanel1.Controls.Add(p)
            AddHandler p.dblC, AddressOf picDblC
            Label1.Text = "Loading " + currentlyShownPosts.ToString

            currentlyShownPosts += 1

            Continue While
failed:
            Exit While

        End While
        For Each ass As String In Split(totalTagStr.Trim, " ")
            If Not lst.Contains(ass) Then lst.Add(ass)
        Next
        'Records binded to the AutocompleteStringCollection.
        MySource.AddRange(lst.ToArray)

        'this AutocompleteStringcollection binded to the textbox as custom
        'source.
        srch.AutoCompleteCustomSource = MySource

        'Auto complete mode set to suggest append so that it will sugesst one
        'or more suggested completion strings it has bith ‘Suggest’ and
        '‘Append’ functionality
        srch.AutoCompleteMode = AutoCompleteMode.Suggest

        'Set to Custom source we have filled already
        srch.AutoCompleteSource = AutoCompleteSource.CustomSource
        If currentlyShownPosts = totalPostsHere Then Me.Button1.Enabled = False Else Me.Button1.Enabled = True
        Label1.Text = ("Showing " + CStr(currentlyShownPosts) + " of " + CStr(totalPostsHere))
        srch.Enabled = True
        spinner.Visible = False
        lbHint.Text = "Double-click to open, right-click to copy/save"
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End

    End Sub
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    
        Me.spinner.Left = Me.Width / 2 - Me.spinner.Width / 2
        Me.spinner.Top = Me.Height / 2 - Me.spinner.Height / 2
        Me.FlowLayoutPanel1.Padding = New Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0)

    End Sub
    Sub picDblC(ByVal sender As BooruPic) 'handles boorupic-> dblClick
        Dim v As New Viewer
        v.parentPicture = sender
        v.Show()

    End Sub
    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Icon = My.Resources._1357751289_25239

        SplitContainer1.FixedPanel = FixedPanel.Panel1
        Try
            getNextPg(True)
        Catch ex As Exception
            MsgBox("Failed to load " + ComboBox1.Text + vbCrLf + ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
        End Try

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            getNextPg()
        Catch ex As Exception
            MsgBox("Failed to load " + ComboBox1.Text + vbCrLf + ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
        End Try

    End Sub

    Private Sub clsSrc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clsSrc.Click
        srch.Text = ""
        currentlyShownPosts = 0
        totalPostsHere = 0
        clsSrc.Enabled = False
        Me.FlowLayoutPanel1.Controls.Clear()
        Try
            getNextPg(True)
        Catch ex As Exception
            MsgBox("Failed to load " + ComboBox1.Text + vbCrLf + ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
        End Try

    End Sub

    Private Sub srch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles srch.KeyDown
        If srchQuery.Count = 0 Then Label1.Text = ("Showing " + CStr(currentlyShownPosts) + " of " + CStr(totalPostsHere))
        lbHint.Text = "Enter tags one by one, separating with spaces. Then press enter."
        If e.KeyCode = (Keys.Enter) Then
            currentlyShownPosts = 0
            totalPostsHere = 0
            Me.FlowLayoutPanel1.Controls.Clear()
            For Each ass As String In srchQuery
                If Not MySource.Contains(ass) Then MySource.Add(ass)
                If Not lst.Contains(ass) Then lst.Add(ass)
                If srch.Text <> "" Then srch.Text = srch.Text + "+" + ass Else srch.Text = ass
            Next
            srchQuery.Clear()
            Try
                getNextPg(True)
            Catch ex As Exception
                MsgBox("Failed to load " + ComboBox1.Text + vbCrLf + ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
            End Try
            e.Handled = True
            clsSrc.Enabled = True
        End If

        If e.KeyCode = Keys.Space Then
            srchQuery.Add(srch.Text)
            srch.Text = ""
            Label1.Text = "Will search for: "
            For Each a As String In srchQuery
                Label1.Text += a + " "
            Next
            e.SuppressKeyPress = True
            e.Handled = True
        End If
        If e.KeyCode = Keys.Back And srch.Text = "" And srchQuery.Count > 0 Then
            srch.Text = srchQuery(srchQuery.Count - 1)
            srch.SelectionStart = srch.TextLength
            srch.SelectionLength = 0
            srchQuery.RemoveAt(srchQuery.Count - 1)
            Label1.Text = "Will search for: "
            For Each a As String In srchQuery
                Label1.Text += a + " "
            Next
            e.SuppressKeyPress = True
            e.Handled = True
        End If
    End Sub

    Private Sub srch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles srch.KeyPress
        
    End Sub

    Private Sub srch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles srch.TextChanged
        If srch.Text.Trim <> "" Then clsSrc.Enabled = True Else clsSrc.Enabled = False
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        lbHint.Text = "Enter board url in the combobox, then press enter"
        If e.KeyChar = Chr(Keys.Enter) Then
            If isBoot Then isBoot = False : Return

            ComboBox1.Items.Add(ComboBox1.Text)
            currentlyShownPosts = 0
            totalPostsHere = 0
            Me.FlowLayoutPanel1.Controls.Clear()
            Try
                getNextPg(True)
            Catch ex As Exception
                MsgBox("Failed to load " + ComboBox1.Text + vbCrLf + ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
            End Try
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If isBoot Then isBoot = False : Return
        lbHint.Text = "Enter board url in the combobox, then press enter"
        ComboBox1.Text = ComboBox1.SelectedItem.ToString
        currentlyShownPosts = 0
        totalPostsHere = 0
        Me.FlowLayoutPanel1.Controls.Clear()
        Try
            getNextPg(True)
        Catch ex As Exception
            MsgBox("Failed to load " + ComboBox1.Text + vbCrLf + ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
        End Try
    End Sub

  
    Private Sub FlowLayoutPanel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.FlowLayoutPanel1.Focus()
    End Sub

  
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("GBBrowser" + vbCrLf + "By vladkorotnev, 2013" + vbCrLf + "http://vladkorotnev.github.com", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "About")
    End Sub

  
End Class
