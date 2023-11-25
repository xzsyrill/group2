Public Class Confirmation

    Dim x As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        x = MsgBox("Do you really want to submit?", vbYesNo + vbQuestion, "Confirmation")
        If x = vbYes Then
            MsgBox("You have successfuly sent your appointment request!", vbOKOnly + vbInformation, "Thank You")
            If vbOK Then
                LogIn.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Appointment.Show()
        Me.Hide()
    End Sub
End Class