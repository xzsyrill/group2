Public Class Appointment
    Dim gender As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Confirmation.Show()
        Me.Hide()
    End Sub

    Private Sub rdbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMale.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub rdbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFemale.CheckedChanged
        gender = "Female"
    End Sub
End Class