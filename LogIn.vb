Imports MySql.Data.MySqlClient

Public Class LogIn

    Dim conn As MySqlConnection = New MySqlConnection("server=localhost;username=root;password=;database=db_theodore")
    Dim cmd As New MySqlCommand
    Dim tbl As DataTable
    Dim adapter As MySqlDataAdapter
    Dim dr As MySqlDataReader

    Dim Msg As Integer

    Sub loadTable()
        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * From tbl_patient"
            adapter.SelectCommand = cmd
            tbl.Clear()
            adapter.Fill(tbl)
            table.patientList.DataSource = tbl
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        If txtUsername.Text = "StTheodoreMC" And txtPassword.Text = "Theodore7659" Then
            Msg = MsgBox("Ikaw pala yan Doc/Nurse!", +vbOKOnly + vbInformation, "Login Succesfull")
        ElseIf txtUsername.Text = "Patient" And txtPassword.Text = "Patient0267" Then
            Msg = MsgBox("Hi, Kumusta pasok ka!", vbOKOnly + vbInformation, "Login Successful")
        Else
            Msg = MsgBox("Hala cno kah?!", vbRetryCancel + vbExclamation, "Login Unsuccessful")
        End If

        MedicalRecord.Show()
        Me.Hide()


    End Sub

    Private Sub lnkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSignUp.LinkClicked
        SignUp.Show()
        Me.Hide()
    End Sub

    Private Sub lnkBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkBack.LinkClicked
        Home.Show()
        Me.Hide()
    End Sub
End Class