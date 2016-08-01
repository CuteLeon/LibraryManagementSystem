<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBookForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.labBookName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.txtBookWriter = New System.Windows.Forms.TextBox()
        Me.txtBookNumber = New System.Windows.Forms.TextBox()
        Me.txtHowMuch = New System.Windows.Forms.TextBox()
        Me.txtBuyDate = New System.Windows.Forms.TextBox()
        Me.nupBookCount = New System.Windows.Forms.NumericUpDown()
        Me.btnAddBookData = New System.Windows.Forms.Button()
        CType(Me.nupBookCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labBookName
        '
        Me.labBookName.AutoSize = True
        Me.labBookName.Location = New System.Drawing.Point(23, 25)
        Me.labBookName.Name = "labBookName"
        Me.labBookName.Size = New System.Drawing.Size(59, 12)
        Me.labBookName.TabIndex = 0
        Me.labBookName.Text = "图书名称:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "图书作者:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "图书编号:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "购书价格:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "购书日期:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "库存数:"
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(88, 22)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(159, 21)
        Me.txtBookName.TabIndex = 0
        '
        'txtBookWriter
        '
        Me.txtBookWriter.Location = New System.Drawing.Point(88, 45)
        Me.txtBookWriter.Name = "txtBookWriter"
        Me.txtBookWriter.Size = New System.Drawing.Size(159, 21)
        Me.txtBookWriter.TabIndex = 1
        '
        'txtBookNumber
        '
        Me.txtBookNumber.Location = New System.Drawing.Point(88, 68)
        Me.txtBookNumber.Name = "txtBookNumber"
        Me.txtBookNumber.Size = New System.Drawing.Size(159, 21)
        Me.txtBookNumber.TabIndex = 2
        '
        'txtHowMuch
        '
        Me.txtHowMuch.Location = New System.Drawing.Point(88, 114)
        Me.txtHowMuch.Name = "txtHowMuch"
        Me.txtHowMuch.Size = New System.Drawing.Size(159, 21)
        Me.txtHowMuch.TabIndex = 4
        '
        'txtBuyDate
        '
        Me.txtBuyDate.Location = New System.Drawing.Point(88, 91)
        Me.txtBuyDate.Name = "txtBuyDate"
        Me.txtBuyDate.Size = New System.Drawing.Size(159, 21)
        Me.txtBuyDate.TabIndex = 3
        '
        'nupBookCount
        '
        Me.nupBookCount.Location = New System.Drawing.Point(88, 137)
        Me.nupBookCount.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nupBookCount.Name = "nupBookCount"
        Me.nupBookCount.Size = New System.Drawing.Size(159, 21)
        Me.nupBookCount.TabIndex = 5
        Me.nupBookCount.ThousandsSeparator = True
        Me.nupBookCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnAddBookData
        '
        Me.btnAddBookData.Location = New System.Drawing.Point(88, 164)
        Me.btnAddBookData.Name = "btnAddBookData"
        Me.btnAddBookData.Size = New System.Drawing.Size(159, 40)
        Me.btnAddBookData.TabIndex = 6
        Me.btnAddBookData.Text = "添加新图书"
        Me.btnAddBookData.UseVisualStyleBackColor = True
        '
        'AddBookForm
        '
        Me.AcceptButton = Me.btnAddBookData
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 213)
        Me.Controls.Add(Me.btnAddBookData)
        Me.Controls.Add(Me.nupBookCount)
        Me.Controls.Add(Me.txtBuyDate)
        Me.Controls.Add(Me.txtHowMuch)
        Me.Controls.Add(Me.txtBookNumber)
        Me.Controls.Add(Me.txtBookWriter)
        Me.Controls.Add(Me.txtBookName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labBookName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddBookForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "添加新图书"
        CType(Me.nupBookCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labBookName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBookName As System.Windows.Forms.TextBox
    Friend WithEvents txtBookWriter As System.Windows.Forms.TextBox
    Friend WithEvents txtBookNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtHowMuch As System.Windows.Forms.TextBox
    Friend WithEvents txtBuyDate As System.Windows.Forms.TextBox
    Friend WithEvents nupBookCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnAddBookData As System.Windows.Forms.Button
End Class
