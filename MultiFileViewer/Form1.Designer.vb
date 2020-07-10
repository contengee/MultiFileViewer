<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lstFileName = New System.Windows.Forms.ListBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.WebBrowser1)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.SplitContainer1.SplitterDistance = 252
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnLoad)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnSave)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.lstFileName)
        Me.SplitContainer2.Size = New System.Drawing.Size(252, 450)
        Me.SplitContainer2.SplitterDistance = 89
        Me.SplitContainer2.TabIndex = 0
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(106, 12)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(77, 43)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(12, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 43)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lstFileName
        '
        Me.lstFileName.AllowDrop = True
        Me.lstFileName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstFileName.FormattingEnabled = True
        Me.lstFileName.ItemHeight = 12
        Me.lstFileName.Location = New System.Drawing.Point(0, 0)
        Me.lstFileName.Name = "lstFileName"
        Me.lstFileName.Size = New System.Drawing.Size(252, 357)
        Me.lstFileName.TabIndex = 0
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(544, 450)
        Me.WebBrowser1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents lstFileName As ListBox
    Friend WithEvents WebBrowser1 As WebBrowser

    Private Sub IsFileName_DragEnter(sender As Object, e As DragEventArgs) Handles lstFileName.DragEnter
        ' ドラッグされているものがファイルであるか確認します。
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            ' ファイルであればコピー可能であることを宣言します。
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub IsFileName_DragDrop(sender As Object, e As DragEventArgs) Handles lstFileName.DragDrop
        ' ドロップされたファイルのフルパスを取得します。
        Dim fileName As String
        fileName = CType(e.Data.GetData(DataFormats.FileDrop), String())(0)

        ' フルパスからファイル情報を生成してIsFileNameに格納します
        lstFileName.Items.Add(New IO.FileInfo(fileName))

        ' saveを有効にする
        btnSave.Enabled = True
    End Sub

    Private Sub lstFileName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFileName.SelectedIndexChanged
        Dim file As IO.FileInfo = DirectCast(lstFileName.SelectedItem, IO.FileInfo)
        WebBrowser1.Navigate(file.FullName)
        Me.Text = Application.ProductName & " - " & file.FullName
    End Sub

    Friend WithEvents btnLoad As Button
    Friend WithEvents btnSave As Button

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' ▼保存するファイルの指定
        Dim dialog As New SaveFileDialog
        dialog.DefaultExt = ".txt" ' 既存の拡張を .txtとします。

        ' ファイルを保存するダイアログを開き、閉じられるまで待ちます。OKが押されたか確認します。
        If dialog.ShowDialog <> DialogResult.OK Then
            ' OK以外で閉じられた場合何もしません。
            Return
        End If

        ' ▼ファイルへの書き込み
        Using writer As New IO.StreamWriter(dialog.FileName)
            ' lstFileNameに格納されているファイル情報を1つずつ取り出します。
            For Each fileInfo As IO.FileInfo In lstFileName.Items
                ' ファイル情報からフルパスに書き込みます。
                writer.WriteLine(fileInfo.FullName)
            Next
        End Using

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        ' ▼開くファイルの指定
        Dim dialog As New OpenFileDialog

        ' ファイルを開くダイアログを開き、閉じられるまで待ちます。OKが押されたか確認します。
        If dialog.ShowDialog <> DialogResult.OK Then
            Return
        End If

        ' ▼ファイルからの読み込み
        ' lstFileNameに格納している内容をすべてクリアします。
        lstFileName.Items.Clear()

        ' 指定されたファイルの内容を1行ずつ処理します。
        For Each line As String In IO.File.ReadAllLines(dialog.FileName)
            ' フルパスからファイル情報を生成してlstFileNameに格納します。
            lstFileName.Items.Add(New IO.FileInfo(line))
        Next

        ' saveを有効にする
        btnSave.Enabled = True

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Application.ProductName
    End Sub

End Class
