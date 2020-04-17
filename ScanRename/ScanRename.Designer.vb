<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScanRename
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScanRename))
        Me.lv = New System.Windows.Forms.ListView()
        Me.btnFileChooser = New System.Windows.Forms.Button()
        Me.btnPageNumber = New System.Windows.Forms.Button()
        Me.ckOddPage = New System.Windows.Forms.RadioButton()
        Me.ckEvenPage = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbLog = New System.Windows.Forms.Label()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lv
        '
        Me.lv.Font = New System.Drawing.Font("굴림체", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lv.HideSelection = False
        Me.lv.Location = New System.Drawing.Point(12, 111)
        Me.lv.MultiSelect = False
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(400, 648)
        Me.lv.TabIndex = 19
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'btnFileChooser
        '
        Me.btnFileChooser.Location = New System.Drawing.Point(15, 24)
        Me.btnFileChooser.Name = "btnFileChooser"
        Me.btnFileChooser.Size = New System.Drawing.Size(79, 29)
        Me.btnFileChooser.TabIndex = 20
        Me.btnFileChooser.Text = "파일 선택"
        Me.btnFileChooser.UseVisualStyleBackColor = True
        '
        'btnPageNumber
        '
        Me.btnPageNumber.Location = New System.Drawing.Point(209, 24)
        Me.btnPageNumber.Name = "btnPageNumber"
        Me.btnPageNumber.Size = New System.Drawing.Size(79, 29)
        Me.btnPageNumber.TabIndex = 21
        Me.btnPageNumber.Text = "번호 수정"
        Me.btnPageNumber.UseVisualStyleBackColor = True
        '
        'ckOddPage
        '
        Me.ckOddPage.AutoSize = True
        Me.ckOddPage.Location = New System.Drawing.Point(109, 20)
        Me.ckOddPage.Name = "ckOddPage"
        Me.ckOddPage.Size = New System.Drawing.Size(87, 16)
        Me.ckOddPage.TabIndex = 23
        Me.ckOddPage.Text = "홀수 페이지"
        Me.ckOddPage.UseVisualStyleBackColor = True
        '
        'ckEvenPage
        '
        Me.ckEvenPage.AutoSize = True
        Me.ckEvenPage.Location = New System.Drawing.Point(109, 42)
        Me.ckEvenPage.Name = "ckEvenPage"
        Me.ckEvenPage.Size = New System.Drawing.Size(87, 16)
        Me.ckEvenPage.TabIndex = 24
        Me.ckEvenPage.TabStop = True
        Me.ckEvenPage.Text = "짝수 페이지"
        Me.ckEvenPage.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbLog)
        Me.GroupBox1.Controls.Add(Me.btnRename)
        Me.GroupBox1.Controls.Add(Me.btnFileChooser)
        Me.GroupBox1.Controls.Add(Me.ckEvenPage)
        Me.GroupBox1.Controls.Add(Me.btnPageNumber)
        Me.GroupBox1.Controls.Add(Me.ckOddPage)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 93)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "스캔이미지 이름 변경"
        '
        'lbLog
        '
        Me.lbLog.Font = New System.Drawing.Font("굴림", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lbLog.ForeColor = System.Drawing.Color.Red
        Me.lbLog.Location = New System.Drawing.Point(6, 68)
        Me.lbLog.Name = "lbLog"
        Me.lbLog.Size = New System.Drawing.Size(388, 19)
        Me.lbLog.TabIndex = 26
        Me.lbLog.Text = "이름 변경할 파일을 선택하세요"
        '
        'btnRename
        '
        Me.btnRename.Location = New System.Drawing.Point(303, 24)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(79, 29)
        Me.btnRename.TabIndex = 25
        Me.btnRename.Text = "변경 적용"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'pic
        '
        Me.pic.Location = New System.Drawing.Point(418, 22)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(585, 737)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic.TabIndex = 26
        Me.pic.TabStop = False
        '
        'ScanRename
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 771)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ScanRename"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScanRename"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents btnFileChooser As System.Windows.Forms.Button
    Friend WithEvents btnPageNumber As System.Windows.Forms.Button
    Friend WithEvents ckOddPage As System.Windows.Forms.RadioButton
    Friend WithEvents ckEvenPage As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRename As System.Windows.Forms.Button
    Friend WithEvents lbLog As System.Windows.Forms.Label
    Friend WithEvents pic As System.Windows.Forms.PictureBox

End Class
