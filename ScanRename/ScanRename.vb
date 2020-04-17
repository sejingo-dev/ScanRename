Public Class ScanRename

    Private Sub ScanRename_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewSetting.initSrcFileList(lv)
    End Sub

    Public SRC_FILE_LIST As New List(Of PageData)
    Private Sub btnFileChooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileChooser.Click
        '        pic.SizeMode = PictureBoxSizeMode.Zoom

        SRC_FILE_LIST = FileChooser.getChooseFileList
        ViewSetting.loadSrcFileList(lv, SRC_FILE_LIST)
        lbLog.Text = SRC_FILE_LIST.Count & "개의 파일 선택됨"
    End Sub

    Private Sub btnPageNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPageNumber.Click
        If ViewUtil.isNotSelectedItem(lv) Then
            MsgBox("페이지 변경할 이미지를 선택하세요")
            Exit Sub
        End If

        If ckOddPage.Checked = False And ckEvenPage.Checked = False Then
            MsgBox("변경할 이미지가 홀수 페이지인지 짝수 페이지인지 선택하세요")
            Exit Sub
        End If

        '// 입력
        Dim pageNumber = InputBox("선택한 이미지의 페이지 번호를 입력하세요", "페이지 번호 입력", "")

        If pageNumber = "" Then
            MessageBox.Show("페이지 번호가 입력되지 않았습니다")
            Exit Sub
        End If

        If ckOddPage.Checked Then
            lbLog.Text = pageNumber & "번 부터 홀수 페이지를 적용합니다"
        Else
            lbLog.Text = pageNumber & "번 부터 짝수 페이지를 역순으로 적용합니다"
        End If

        renewalPageNumner(pageNumber)

    End Sub

    '// 페이지 번호 수정
    Private Sub renewalPageNumner(ByVal pageNumber As Integer)
        If ViewUtil.isNotSelectedItem(lv) Then
            Exit Sub
        End If

        Dim selIdx = ViewUtil.getSelectedIdxOne(lv)

        Dim loopCnt = -1

        For Each pd As PageData In SRC_FILE_LIST
            loopCnt = loopCnt + 1
            If selIdx > loopCnt Then
                Continue For
            End If

            pd.page_number = pageNumber.ToString("0000")
            pageNumber = pageNumber + 2

        Next

        ViewSetting.loadSrcFileList(lv, SRC_FILE_LIST)
        ViewUtil.setListViewFocus(lv, selIdx)
    End Sub

    Private Sub ckOddPage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckOddPage.CheckedChanged
        lbLog.Text = "1번 부터 홀수 페이지를 자동 적용합니다"
        ViewUtil.setListViewFocus(lv, 0)
        renewalPageNumner("1")
    End Sub

    Private Sub ckEvenPage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckEvenPage.CheckedChanged
        Dim lastNumber = SRC_FILE_LIST.Count * 2
        lbLog.Text = lastNumber & "번 부터 짝수 페이지를 자동 적용합니다"
        ViewUtil.setListViewFocus(lv, 0)

        renewalPageNumner("2")
    End Sub

    Private Sub btnRename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRename.Click
        Dim outDir = System.IO.Path.GetDirectoryName(SRC_FILE_LIST.Item(0).src_path)

        'If ckOddPage.Checked Then
        '    outDir = outDir & "\" & "홀수"
        'Else
        '    outDir = outDir & "\" & "짝수"
        'End If

        'If System.IO.Directory.Exists(outDir) Then
        '    System.IO.Directory.Delete(outDir, True)
        'End If

        'My.Computer.FileSystem.CreateDirectory(outDir)

        For Each pd As PageData In SRC_FILE_LIST
            'My.Computer.FileSystem.CopyFile(pd.src_path, outDir & "\" & Trim(pd.page_number) & ".jpg")
            My.Computer.FileSystem.RenameFile(pd.src_path, pd.page_number & ".jpg")
        Next

        lbLog.Text = "파일이름 변경완료"
        Process.Start(outDir)

    End Sub

    Private Sub lv_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lv.MouseClick
        If ViewUtil.isNotSelectedItem(lv) Then
            Exit Sub
        End If

        Dim selIdx = ViewUtil.getSelectedIdxOne(lv)

        Dim pd As PageData = SRC_FILE_LIST.Item(selIdx)

        Dim fs As System.IO.FileStream
        fs = New System.IO.FileStream(pd.src_path, System.IO.FileMode.Open, System.IO.FileAccess.Read)
        pic.Image = System.Drawing.Image.FromStream(fs)
        fs.Close()

    End Sub

 
End Class
