Module FileChooser
    Function getChooseFileList() As List(Of PageData)

        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "파일을 선택하세요."
        fd.InitialDirectory = Application.StartupPath
        fd.Filter = "JPG File (*.jpg)|*.jpg"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True
        fd.Multiselect = True

        Dim fileList As New List(Of PageData)
        If fd.ShowDialog() = DialogResult.OK Then
            For Each mFile As String In fd.FileNames
                Dim pd As New PageData
                pd.src_path = mFile
                pd.page_number = ""
                fileList.Add(pd)
            Next
        End If

        fileList = fileList.OrderBy(Function(x) x.src_path).ToList()
        Return fileList
    End Function
End Module
