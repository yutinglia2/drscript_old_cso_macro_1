<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form21
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ModeKey1 = New System.Windows.Forms.ComboBox()
        Me.ModeKey2 = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 78)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "前後台模式轉換只影響滑鼠 鍵盤按鍵永久後台" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "因後台無法模擬按住滑鼠 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "所以需要把開火鍵(左鍵)和特殊功能鍵(右鍵)更改" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "開火鍵(左鍵)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "特殊功能鍵(右鍵)"
        '
        'ModeKey1
        '
        Me.ModeKey1.DropDownHeight = 250
        Me.ModeKey1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ModeKey1.DropDownWidth = 100
        Me.ModeKey1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ModeKey1.FormattingEnabled = True
        Me.ModeKey1.IntegralHeight = False
        Me.ModeKey1.ItemHeight = 20
        Me.ModeKey1.Items.AddRange(New Object() {"蓋亞", "刀戰蓋亞"})
        Me.ModeKey1.Location = New System.Drawing.Point(192, 124)
        Me.ModeKey1.MaxDropDownItems = 5
        Me.ModeKey1.Name = "ModeKey1"
        Me.ModeKey1.Size = New System.Drawing.Size(129, 28)
        Me.ModeKey1.TabIndex = 12
        '
        'ModeKey2
        '
        Me.ModeKey2.DropDownHeight = 250
        Me.ModeKey2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ModeKey2.DropDownWidth = 100
        Me.ModeKey2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ModeKey2.FormattingEnabled = True
        Me.ModeKey2.IntegralHeight = False
        Me.ModeKey2.ItemHeight = 20
        Me.ModeKey2.Items.AddRange(New Object() {"蓋亞", "刀戰蓋亞"})
        Me.ModeKey2.Location = New System.Drawing.Point(192, 177)
        Me.ModeKey2.MaxDropDownItems = 5
        Me.ModeKey2.Name = "ModeKey2"
        Me.ModeKey2.Size = New System.Drawing.Size(129, 28)
        Me.ModeKey2.TabIndex = 13
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(390, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 30)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "圖示"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form21
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 273)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ModeKey2)
        Me.Controls.Add(Me.ModeKey1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form21"
        Me.Text = "Form21"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ModeKey1 As ComboBox
    Friend WithEvents ModeKey2 As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button

End Class
