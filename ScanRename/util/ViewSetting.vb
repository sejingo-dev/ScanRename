Public Class ViewSetting

    '// 유저 리스트
    Shared Sub initSrcFileList(ByRef lv As ListView)
        '////////////////////////
        lv.View = View.Details
        lv.GridLines = True
        lv.FullRowSelect = True

        lv.Columns.Add("", 0, HorizontalAlignment.Center)

        lv.Columns.Add("원본파일명", 300, HorizontalAlignment.Left)
        lv.Columns.Add("페이지", 80, HorizontalAlignment.Left)

        lv.Columns.RemoveAt(0)
    End Sub

    '// 파일 리스트
    Shared Sub loadSrcFileList(ByRef lv As ListView, ByVal list As List(Of PageData))

        lv.Items.Clear()

        For Each pd As PageData In list

            Dim itemList As New List(Of String)
            Dim fileName = System.IO.Path.GetFileName(pd.src_path)
            itemList.Add(fileName)
            itemList.Add(pd.page_number)

            Dim lvItem = New ListViewItem(itemList.ToArray)
            lvItem.UseItemStyleForSubItems = False

            If IsNumeric(pd.page_number) Then
                If Integer.Parse(pd.page_number) < 0 Then
                    lvItem.SubItems(1).BackColor = Color.Red
                End If
            End If
            lv.Items.Add(lvItem)

        Next
    End Sub

End Class
