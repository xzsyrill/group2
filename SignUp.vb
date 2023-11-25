Imports MySql.Data.MySqlClient

Public Class SignUp
    Dim conn As MySqlConnection = New MySqlConnection("server=localhost;username=root;password=;database=db_theodore")
    Dim cmd As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim tbl As New DataTable
    Dim dr As MySqlDataReader
    Private Sub lnkBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkBack.LinkClicked
        LogIn.Show()
        Me.Hide()
    End Sub

    Private Sub btnCreateAcc_Click(sender As Object, e As EventArgs) Handles btnCreateAcc.Click
        Try
            conn.Open()
            Dim query As String
            query = "Insert into tbl_create(CrUser,CrPass,CrRPass)values(@User,@Pass,@RPass)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@User", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Pass", txtPassword.Text)
            cmd.Parameters.AddWithValue("@RPass", txtRetypePass.Text)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Welcome", vbOKOnly + vbInformation, "Welcome")
            MedicalRecord.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class