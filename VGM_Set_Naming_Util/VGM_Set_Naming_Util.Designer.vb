<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VGM_Set_Naming_Util
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitleEng = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtTitleEng = New System.Windows.Forms.TextBox()
        Me.lblTitleInitial = New System.Windows.Forms.Label()
        Me.txtTitleInitial = New System.Windows.Forms.TextBox()
        Me.lblDeveloper = New System.Windows.Forms.Label()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.txtDeveloper = New System.Windows.Forms.TextBox()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.txtTagOut = New System.Windows.Forms.TextBox()
        Me.btnTagInit = New System.Windows.Forms.Button()
        Me.txtDateYYYY = New System.Windows.Forms.TextBox()
        Me.lblDivSep1 = New System.Windows.Forms.Label()
        Me.txtDateMM = New System.Windows.Forms.TextBox()
        Me.txtDateDD = New System.Windows.Forms.TextBox()
        Me.lblDivSep2 = New System.Windows.Forms.Label()
        Me.btnClipboard = New System.Windows.Forms.Button()
        Me.lblSystem = New System.Windows.Forms.Label()
        Me.cmbSystem = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblTitleEng
        '
        Me.lblTitleEng.AutoSize = True
        Me.lblTitleEng.Location = New System.Drawing.Point(12, 33)
        Me.lblTitleEng.Name = "lblTitleEng"
        Me.lblTitleEng.Size = New System.Drawing.Size(160, 13)
        Me.lblTitleEng.TabIndex = 2
        Me.lblTitleEng.Text = "Title (English Localized Release)"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(12, 56)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(97, 13)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date (yyyy/mm/dd)"
        '
        'txtTitleEng
        '
        Me.txtTitleEng.Location = New System.Drawing.Point(180, 30)
        Me.txtTitleEng.Name = "txtTitleEng"
        Me.txtTitleEng.Size = New System.Drawing.Size(240, 20)
        Me.txtTitleEng.TabIndex = 3
        '
        'lblTitleInitial
        '
        Me.lblTitleInitial.AutoSize = True
        Me.lblTitleInitial.Location = New System.Drawing.Point(12, 9)
        Me.lblTitleInitial.Name = "lblTitleInitial"
        Me.lblTitleInitial.Size = New System.Drawing.Size(102, 13)
        Me.lblTitleInitial.TabIndex = 0
        Me.lblTitleInitial.Text = "Title (Initial Release)"
        '
        'txtTitleInitial
        '
        Me.txtTitleInitial.Location = New System.Drawing.Point(180, 6)
        Me.txtTitleInitial.Name = "txtTitleInitial"
        Me.txtTitleInitial.Size = New System.Drawing.Size(240, 20)
        Me.txtTitleInitial.TabIndex = 1
        '
        'lblDeveloper
        '
        Me.lblDeveloper.AutoSize = True
        Me.lblDeveloper.Location = New System.Drawing.Point(12, 80)
        Me.lblDeveloper.Name = "lblDeveloper"
        Me.lblDeveloper.Size = New System.Drawing.Size(56, 13)
        Me.lblDeveloper.TabIndex = 10
        Me.lblDeveloper.Text = "Developer"
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Location = New System.Drawing.Point(12, 103)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(50, 13)
        Me.lblPublisher.TabIndex = 12
        Me.lblPublisher.Text = "Publisher"
        '
        'txtDeveloper
        '
        Me.txtDeveloper.Location = New System.Drawing.Point(180, 77)
        Me.txtDeveloper.Name = "txtDeveloper"
        Me.txtDeveloper.Size = New System.Drawing.Size(240, 20)
        Me.txtDeveloper.TabIndex = 11
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(180, 100)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(240, 20)
        Me.txtPublisher.TabIndex = 13
        '
        'txtTagOut
        '
        Me.txtTagOut.Location = New System.Drawing.Point(15, 259)
        Me.txtTagOut.Name = "txtTagOut"
        Me.txtTagOut.Size = New System.Drawing.Size(405, 20)
        Me.txtTagOut.TabIndex = 17
        '
        'btnTagInit
        '
        Me.btnTagInit.Location = New System.Drawing.Point(166, 230)
        Me.btnTagInit.Name = "btnTagInit"
        Me.btnTagInit.Size = New System.Drawing.Size(101, 23)
        Me.btnTagInit.TabIndex = 16
        Me.btnTagInit.Text = "Process Tags"
        Me.btnTagInit.UseVisualStyleBackColor = True
        '
        'txtDateYYYY
        '
        Me.txtDateYYYY.Location = New System.Drawing.Point(180, 53)
        Me.txtDateYYYY.MaxLength = 4
        Me.txtDateYYYY.Name = "txtDateYYYY"
        Me.txtDateYYYY.Size = New System.Drawing.Size(45, 20)
        Me.txtDateYYYY.TabIndex = 5
        '
        'lblDivSep1
        '
        Me.lblDivSep1.AutoSize = True
        Me.lblDivSep1.Location = New System.Drawing.Point(228, 56)
        Me.lblDivSep1.Name = "lblDivSep1"
        Me.lblDivSep1.Size = New System.Drawing.Size(12, 13)
        Me.lblDivSep1.TabIndex = 6
        Me.lblDivSep1.Text = "/"
        '
        'txtDateMM
        '
        Me.txtDateMM.Location = New System.Drawing.Point(246, 53)
        Me.txtDateMM.MaxLength = 2
        Me.txtDateMM.Name = "txtDateMM"
        Me.txtDateMM.Size = New System.Drawing.Size(29, 20)
        Me.txtDateMM.TabIndex = 7
        '
        'txtDateDD
        '
        Me.txtDateDD.Location = New System.Drawing.Point(299, 53)
        Me.txtDateDD.MaxLength = 2
        Me.txtDateDD.Name = "txtDateDD"
        Me.txtDateDD.Size = New System.Drawing.Size(29, 20)
        Me.txtDateDD.TabIndex = 9
        '
        'lblDivSep2
        '
        Me.lblDivSep2.AutoSize = True
        Me.lblDivSep2.Location = New System.Drawing.Point(281, 56)
        Me.lblDivSep2.Name = "lblDivSep2"
        Me.lblDivSep2.Size = New System.Drawing.Size(12, 13)
        Me.lblDivSep2.TabIndex = 8
        Me.lblDivSep2.Text = "/"
        '
        'btnClipboard
        '
        Me.btnClipboard.Location = New System.Drawing.Point(166, 285)
        Me.btnClipboard.Name = "btnClipboard"
        Me.btnClipboard.Size = New System.Drawing.Size(101, 23)
        Me.btnClipboard.TabIndex = 18
        Me.btnClipboard.Text = "Copy Tag Info"
        Me.btnClipboard.UseVisualStyleBackColor = True
        '
        'lblSystem
        '
        Me.lblSystem.AutoSize = True
        Me.lblSystem.Location = New System.Drawing.Point(12, 126)
        Me.lblSystem.Name = "lblSystem"
        Me.lblSystem.Size = New System.Drawing.Size(41, 13)
        Me.lblSystem.TabIndex = 14
        Me.lblSystem.Text = "System"
        '
        'cmbSystem
        '
        Me.cmbSystem.FormattingEnabled = True
        Me.cmbSystem.ItemHeight = 13
        Me.cmbSystem.Items.AddRange(New Object() {"3DO", "3DS", "Amiga", "Android", "DC", "GC", "GG", "iOS", "N64", "NDS", "NES", "NGCD", "PC", "PC-88", "PC-FX", "PS1", "PS2", "PS3", "PS4", "PSP", "SAT", "SCD", "SMD", "SNES", "Switch", "TCD", "Vita", "Wii", "WiiU", "WS", "WSC", "Xbox", "X360"})
        Me.cmbSystem.Location = New System.Drawing.Point(180, 123)
        Me.cmbSystem.Name = "cmbSystem"
        Me.cmbSystem.Size = New System.Drawing.Size(121, 21)
        Me.cmbSystem.TabIndex = 15
        '
        'VGM_Set_Naming_Util
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 315)
        Me.Controls.Add(Me.cmbSystem)
        Me.Controls.Add(Me.lblSystem)
        Me.Controls.Add(Me.btnClipboard)
        Me.Controls.Add(Me.lblDivSep2)
        Me.Controls.Add(Me.txtDateDD)
        Me.Controls.Add(Me.txtDateMM)
        Me.Controls.Add(Me.lblDivSep1)
        Me.Controls.Add(Me.txtDateYYYY)
        Me.Controls.Add(Me.btnTagInit)
        Me.Controls.Add(Me.txtTagOut)
        Me.Controls.Add(Me.txtPublisher)
        Me.Controls.Add(Me.txtDeveloper)
        Me.Controls.Add(Me.lblPublisher)
        Me.Controls.Add(Me.lblDeveloper)
        Me.Controls.Add(Me.txtTitleInitial)
        Me.Controls.Add(Me.lblTitleInitial)
        Me.Controls.Add(Me.txtTitleEng)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTitleEng)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VGM_Set_Naming_Util"
        Me.Text = "VGM Set Naming Utility"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitleEng As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtTitleEng As TextBox
    Friend WithEvents lblTitleInitial As Label
    Friend WithEvents txtTitleInitial As TextBox
    Friend WithEvents lblDeveloper As Label
    Friend WithEvents lblPublisher As Label
    Friend WithEvents txtDeveloper As TextBox
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents txtTagOut As TextBox
    Friend WithEvents btnTagInit As Button
    Friend WithEvents txtDateYYYY As TextBox
    Friend WithEvents lblDivSep1 As Label
    Friend WithEvents txtDateMM As TextBox
    Friend WithEvents txtDateDD As TextBox
    Friend WithEvents lblDivSep2 As Label
    Friend WithEvents btnClipboard As Button
    Friend WithEvents lblSystem As Label
    Friend WithEvents cmbSystem As ComboBox
End Class
