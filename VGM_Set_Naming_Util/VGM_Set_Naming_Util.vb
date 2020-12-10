Public Class VGM_Set_Naming_Util
    Private Sub btnTagInit_Click(sender As Object, e As EventArgs) Handles btnTagInit.Click
        Dim titleInitial, titleUS, title, dateRelease, dateYr, developer, publisher, system As String

        titleUS = txtTitleEng.Text
        titleInitial = txtTitleInitial.Text

        If titleUS = "" And titleInitial = "" Then
            MessageBox.Show("Please input a title.", "Error")
            txtTitleInitial.Focus()
            Return
        ElseIf titleInitial = "" Then
            title = titleUS & " "
        ElseIf titleUS = "" Then
            title = titleInitial & " "
        Else
            title = titleInitial & " [" & titleUS & "] "
        End If

        'Data Validation: Month/Day 2-Digit Format
        If txtDateMM.Text.Count = 1 And txtDateDD.Text.Count = 1 Then
            txtDateMM.Text = "0" & txtDateMM.Text
            txtDateDD.Text = "0" & txtDateDD.Text
        ElseIf txtDateMM.Text.Count = 1 Then
            txtDateMM.Text = "0" & txtDateMM.Text
        ElseIf txtDateDD.Text.Count = 1 Then
            txtDateDD.Text = "0" & txtDateDD.Text
        End If

        'Data Validation: Month Error Check
        If Not IsNumeric(txtDateMM.Text) Then
            MessageBox.Show("Month must be in numeric form.", "Error")
            txtDateMM.Focus()
            Return
        ElseIf txtDateMM.Text.Substring(0, 1) = "." Or txtDateMM.Text.Substring(1, 1) = "." Then
            MessageBox.Show("Month must be in numeric form.", "Error")
            txtDateMM.Focus()
            Return
        ElseIf txtDateMM.Text.Substring(0, 1) = "," Or txtDateMM.Text.Substring(1, 1) = "," Then
            MessageBox.Show("Month must be in numeric form.", "Error")
            txtDateMM.Focus()
            Return
        ElseIf txtDateMM.Text.Substring(0, 1) = "$" Or txtDateMM.Text.Substring(1, 1) = "$" Then
            MessageBox.Show("Month must be in numeric form.", "Error")
            txtDateMM.Focus()
            Return
        ElseIf txtDateMM.Text >= "13" Then
            MessageBox.Show("Month cannot exceed over a value of 12.", "Error")
            txtDateMM.Focus()
            Return
        ElseIf txtDateMM.Text = "00" Then
            MessageBox.Show("Month cannot be less than or equal to 0.", "Error")
            txtDateMM.Focus()
            Return
        End If

        'Data Validation: Day Error Check
        If Not IsNumeric(txtDateDD.Text) Then
            MessageBox.Show("Day must be in numeric form.", "Error")
            txtDateDD.Focus()
            Return
        ElseIf txtDateDD.Text.Substring(0, 1) = "." Or txtDateDD.Text.Substring(1, 1) = "." Then
            MessageBox.Show("Day must be in numeric form.", "Error")
            txtDateDD.Focus()
            Return
        ElseIf txtDateDD.Text.Substring(0, 1) = "," Or txtDateDD.Text.Substring(1, 1) = "," Then
            MessageBox.Show("Day must be in numeric form.", "Error")
            txtDateDD.Focus()
            Return
        ElseIf txtDateDD.Text.Substring(0, 1) = "$" Or txtDateDD.Text.Substring(1, 1) = "$" Then
            MessageBox.Show("Day must be in numeric form.", "Error")
            txtDateDD.Focus()
            Return
        ElseIf txtDateDD.Text >= "32" Then
            MessageBox.Show("Day cannot exceed over a value of 31.", "Error")
            txtDateDD.Focus()
            Return
        ElseIf txtDateDD.Text = "00" Then
            MessageBox.Show("Day cannot be less than or equal to 0.", "Error")
            txtDateDD.Focus()
            Return
        End If

        'Year Process
        If txtDateYYYY.Text.Count = 1 Then
            dateYr = ""
        ElseIf txtDateYYYY.Text.Count = 2 Then
            dateYr += txtDateYYYY.Text.Substring(0, 2) & "xx"
        ElseIf txtDateYYYY.Text.Count = 3 Then
            dateYr += txtDateYYYY.Text.Substring(0, 3) & "x"
        ElseIf txtDateYYYY.Text.Count = 4 Then
            If Not IsNumeric(txtDateYYYY.Text.Substring(2, 1)) Then
                dateYr += txtDateYYYY.Text.Substring(0, 2) & "xx"
            ElseIf Not IsNumeric(txtDateYYYY.Text.Substring(3, 1)) Then
                dateYr += txtDateYYYY.Text.Substring(0, 3) & "x"
            ElseIf IsNumeric(txtDateYYYY.Text.Substring(0)) Then
                dateYr = txtDateYYYY.Text
            Else
                dateYr = ""
            End If
        End If

        'Month/Day Process
        If dateYr = "" Then
            dateRelease = ""
        ElseIf txtDateMM.Text = "" Or txtDateDD.Text = "" Then
            dateRelease = "(" & dateYr & ")"
        ElseIf txtDateDD.Text = "" And IsNumeric(txtDateYYYY.Text) Then
            dateRelease = "(" & dateYr & "-" & txtDateMM.Text & ")"
        Else
            dateRelease = "(" & dateYr & "-" & txtDateMM.Text & "-" & txtDateDD.Text & ")"
        End If

        If txtDeveloper.Text = "" And Not txtPublisher.Text = "" Then
            txtDeveloper.Text = txtPublisher.Text
            txtPublisher.Text = ""
            developer = "(" & txtDeveloper.Text & ")"
            MessageBox.Show("Assuming publisher is developer.")
        ElseIf txtDeveloper.Text = "" Then
            MessageBox.Show("Please input developer credentials.", "Error")
            txtDeveloper.Focus()
            Return
        ElseIf txtDeveloper.Text = txtPublisher.Text Then
            developer = "(" & txtDeveloper.Text & ")"
        ElseIf txtPublisher.Text = "" Then
            developer = "(" & txtDeveloper.Text & ")"
        Else
            developer = "(" & txtDeveloper.Text & ")"
            publisher = "(" & txtPublisher.Text & ")"
        End If

        If cmbSystem.Text = "" Then
            MessageBox.Show("Please input a system.", "Error")
            cmbSystem.Focus()
            Return
        Else
            system = "[" & CStr(cmbSystem.Text) & "]"
        End If

        txtTagOut.Text = title & dateRelease & developer & publisher & system
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClipboard.Click
        Clipboard.SetDataObject(txtTagOut.Text)
        txtTagOut.Focus()
    End Sub
End Class