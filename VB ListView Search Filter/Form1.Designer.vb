Imports MetroFramework.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MetroForm

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
        Me.mListView = New MetroFramework.Controls.MetroListView()
        Me.searchTxt = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'mListView
        '
        Me.mListView.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.mListView.FullRowSelect = True
        Me.mListView.Location = New System.Drawing.Point(63, 128)
        Me.mListView.Name = "mListView"
        Me.mListView.OwnerDraw = True
        Me.mListView.Size = New System.Drawing.Size(325, 364)
        Me.mListView.TabIndex = 0
        Me.mListView.UseCompatibleStateImageBehavior = False
        Me.mListView.UseSelectable = True
        '
        'searchTxt
        '
        '
        '
        '
        Me.searchTxt.CustomButton.Image = Nothing
        Me.searchTxt.CustomButton.Location = New System.Drawing.Point(150, 1)
        Me.searchTxt.CustomButton.Name = ""
        Me.searchTxt.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.searchTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.searchTxt.CustomButton.TabIndex = 1
        Me.searchTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.searchTxt.CustomButton.UseSelectable = True
        Me.searchTxt.CustomButton.Visible = False
        Me.searchTxt.Lines = New String(-1) {}
        Me.searchTxt.Location = New System.Drawing.Point(151, 89)
        Me.searchTxt.MaxLength = 32767
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchTxt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.searchTxt.SelectedText = ""
        Me.searchTxt.SelectionLength = 0
        Me.searchTxt.SelectionStart = 0
        Me.searchTxt.ShortcutsEnabled = True
        Me.searchTxt.Size = New System.Drawing.Size(172, 23)
        Me.searchTxt.TabIndex = 1
        Me.searchTxt.UseSelectable = True
        Me.searchTxt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.searchTxt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(87, 89)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Filter"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 515)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.searchTxt)
        Me.Controls.Add(Me.mListView)
        Me.Name = "Form1"
        Me.Text = "ListView Search Filter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mListView As MetroFramework.Controls.MetroListView
    Friend WithEvents searchTxt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel

End Class
