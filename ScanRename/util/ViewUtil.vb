Public Class ViewUtil

    Shared Sub setListViewFocus(ByRef lv As ListView, ByVal idx As Integer)
        If lv.Items.Count = 0 Then
            Exit Sub
        End If

        If lv.Items.Count = idx Then
            idx = idx - 1
        End If

        lv.Items(idx).Selected = True

        If lv.SelectedIndices.Count > 0 Then
            lv.Focus()
            lv.SelectedItems(0).EnsureVisible()
        End If
    End Sub

    Shared Sub setFocusBySelected(ByRef lv As ListView)
        If lv.SelectedIndices.Count > 0 Then
            lv.Focus()
            lv.SelectedItems(0).EnsureVisible()
        End If
    End Sub

    Shared Function getListViewSelectedIndexList(ByVal lv As ListView) As List(Of Integer)
        Dim selList As List(Of Integer) = New List(Of Integer)

        For Each selIdx In lv.SelectedIndices
            Dim idx As Integer = selIdx
            selList.Add(idx)
        Next

        selList.Sort()
        Return selList
    End Function

    Shared Sub changeListViewItem(ByVal curIdx As Integer, ByVal newIdx As Integer, ByRef lv As ListView)
        Console.WriteLine("cur=" & curIdx & ", new=" & newIdx)

        Dim curItem = Nothing

        Dim selRow = lv.Items(curIdx)
        lv.Items(curIdx).Remove()
        lv.Items.Insert(newIdx, selRow)

    End Sub

    Shared Sub changeDataIndex(ByVal curIdx As Integer, ByVal newIdx As Integer, ByRef DATA_IDX_LIST As List(Of Integer))
        Console.WriteLine("cur=" & curIdx & ", new=" & newIdx)

        Dim curItem = Nothing

        curItem = DATA_IDX_LIST.Item(curIdx)
        DATA_IDX_LIST.RemoveAt(curIdx)
        DATA_IDX_LIST.Insert(newIdx, curItem)
    End Sub

    '// 데이터 인덱스 생성
    Shared Function generateDataIdxList(ByVal itemCount As Integer) As List(Of Integer)
        Dim idxList = New List(Of Integer)

        For i = 0 To itemCount - 1 Step 1
            idxList.Add(i)
        Next

        Return idxList
    End Function

    Shared Function moveListViewOrder(ByVal moveStep As Integer, ByRef lv As ListView) As List(Of Integer)

        '// 변경 전 데이터 인덱스 생성
        Dim DATA_IDX_LIST As List(Of Integer) = ViewUtil.generateDataIdxList(lv.Items.Count)

        '// 선택된 행 리스트를 가져와서
        Dim selList As List(Of Integer) = getListViewSelectedIndexList(lv)
        Dim maxIdx = lv.Items.Count - 1

        If selList.Count < 1 Then
            MsgBox("순서를 변경할 그룹들을 선택하세요.")
            Return DATA_IDX_LIST
        End If

        Dim minIdx = 0

        If moveStep = 1 Or moveStep = maxIdx Then
            selList.Reverse()
        End If

        Dim newList = New List(Of Integer)

        '// TOP 선택
        If moveStep = minIdx Then
            Dim limit = minIdx + selList.Count - 1
            For idx = minIdx To limit Step 1
                newList.Add(idx)
            Next
        ElseIf moveStep = maxIdx Then
            '// BOTTOM 선택
            Dim limit = maxIdx - selList.Count + 1
            For idx = maxIdx To limit Step -1
                newList.Add(idx)
            Next
        Else
            '// UP, DOWN 선택
            For Each selIdx In selList
                Dim newIdx = selIdx + moveStep

                If newIdx < minIdx Then
                    newIdx = minIdx
                End If

                If newIdx > maxIdx Then
                    newIdx = maxIdx
                End If

                If newList.Contains(newIdx) Then
                    newIdx = selIdx
                End If

                newList.Add(newIdx)
            Next
        End If

        '// 아이템 이동
        Dim i = -1
        For Each selIdx In selList
            i = i + 1

            Dim newIdx = newList.Item(i)

            If selIdx = newIdx Then
                Continue For
            End If
            changeListViewItem(selIdx, newIdx, lv)
            changeDataIndex(selIdx, newIdx, DATA_IDX_LIST)

        Next

        lv.SelectedIndices.Clear()

        '// 옮긴 콘텐츠로 셀렉션 이동
        For Each newIdx In newList
            lv.Items(newIdx).Selected = True
        Next

        lv.Focus()
        Return DATA_IDX_LIST
    End Function

    Shared Function isNotSelectedItem(ByVal lv As ListView) As Boolean
        If lv.SelectedIndices.Count < 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Shared Function getSelectedIdxOne(ByVal lv As ListView) As Integer
        Return lv.SelectedIndices(0)
    End Function

    

End Class
