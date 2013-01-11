<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label1 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Prev = New System.Windows.Forms.Button
        Me.NxtPic = New System.Windows.Forms.Button
        Me.CurLbl = New System.Windows.Forms.Label
        Me.Dnld = New System.Windows.Forms.Button
        Me.urlCp = New System.Windows.Forms.Button
        Me.pic = New System.Windows.Forms.PictureBox
        Me.spinner = New System.Windows.Forms.PictureBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pic, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.spinner, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(583, 570)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 43)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(114, 524)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tags"
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(114, 485)
        Me.ListBox1.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Prev, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.NxtPic, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CurLbl, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Dnld, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.urlCp, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(123, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(457, 34)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Prev
        '
        Me.Prev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Prev.Location = New System.Drawing.Point(3, 3)
        Me.Prev.Name = "Prev"
        Me.Prev.Size = New System.Drawing.Size(19, 28)
        Me.Prev.TabIndex = 0
        Me.Prev.Text = "<"
        Me.Prev.UseVisualStyleBackColor = True
        '
        'NxtPic
        '
        Me.NxtPic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NxtPic.Location = New System.Drawing.Point(435, 3)
        Me.NxtPic.Name = "NxtPic"
        Me.NxtPic.Size = New System.Drawing.Size(19, 28)
        Me.NxtPic.TabIndex = 1
        Me.NxtPic.Text = ">"
        Me.NxtPic.UseVisualStyleBackColor = True
        '
        'CurLbl
        '
        Me.CurLbl.AutoSize = True
        Me.CurLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurLbl.Location = New System.Drawing.Point(158, 0)
        Me.CurLbl.Name = "CurLbl"
        Me.CurLbl.Size = New System.Drawing.Size(141, 34)
        Me.CurLbl.TabIndex = 2
        Me.CurLbl.Text = "Label2"
        '
        'Dnld
        '
        Me.Dnld.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dnld.Location = New System.Drawing.Point(28, 3)
        Me.Dnld.Name = "Dnld"
        Me.Dnld.Size = New System.Drawing.Size(124, 28)
        Me.Dnld.TabIndex = 3
        Me.Dnld.Text = "Download"
        Me.Dnld.UseVisualStyleBackColor = True
        '
        'urlCp
        '
        Me.urlCp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.urlCp.Location = New System.Drawing.Point(305, 3)
        Me.urlCp.Name = "urlCp"
        Me.urlCp.Size = New System.Drawing.Size(124, 28)
        Me.urlCp.TabIndex = 4
        Me.urlCp.Text = "Copy URL"
        Me.urlCp.UseVisualStyleBackColor = True
        '
        'pic
        '
        Me.pic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic.Location = New System.Drawing.Point(123, 43)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(457, 524)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic.TabIndex = 2
        Me.pic.TabStop = False
        '
        'spinner
        '
        Me.spinner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spinner.Image = Global.PrjKawaii.My.Resources.Resources.spin_color
        Me.spinner.Location = New System.Drawing.Point(3, 3)
        Me.spinner.Name = "spinner"
        Me.spinner.Size = New System.Drawing.Size(114, 34)
        Me.spinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.spinner.TabIndex = 3
        Me.spinner.TabStop = False
        '
        'Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 570)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Viewer"
        Me.Text = "Viewer"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Prev As System.Windows.Forms.Button
    Friend WithEvents NxtPic As System.Windows.Forms.Button
    Friend WithEvents CurLbl As System.Windows.Forms.Label
    Friend WithEvents Dnld As System.Windows.Forms.Button
    Friend WithEvents urlCp As System.Windows.Forms.Button
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents spinner As System.Windows.Forms.PictureBox
End Class
