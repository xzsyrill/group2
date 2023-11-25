Imports MySql.Data.MySqlClient
Public Class MedicalRecord
    Dim conn As MySqlConnection = New MySqlConnection("server=localhost;username=root;password=;database=db_theodore")
    Dim cmd As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim tbl As New DataTable
    Dim dr As MySqlDataReader

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

    Sub clear()
        txtName1.Clear()
        txtBirth.Clear()
        txtGender.Clear()
        txtAddress.Clear()
        txtNumber.Clear()
        txtEmail.Clear()
        txtName2.Clear()
        txtRelationship.Clear()
        txtAddress2.Clear()
        txtNumber2.Clear()
        txtID.Clear()
    End Sub

    Private Sub lnkSetAppointment_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSetAppointment.LinkClicked
        Appointment.Show()
        Me.Hide()
    End Sub

    Private Sub lnkBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkBack.LinkClicked
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LogIn.Show()
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' "Update tbl_patient set PatName = @Name, PatBday = @Bday WHERE PatID = @ID"

        Try
            conn.Open()
            Dim query As String
            query = "Insert into tbl_patient(PatName,PatBday,PatGender,PatAddress,PatContact,PatEmail,PatEName,PatRelationship,PatEAddress,PatEContact)values(@Name,@Bday,@Gender,@Address,@Contact,@Email,@EName,@Relationship,@EAddress,@EContact)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Name", txtName1.Text)
            cmd.Parameters.AddWithValue("@Bday", txtBirth.Text)
            cmd.Parameters.AddWithValue("@Gender", txtGender.Text)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@Contact", txtNumber.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@EName", txtName2.Text)
            cmd.Parameters.AddWithValue("@Relationship", txtRelationship.Text)
            cmd.Parameters.AddWithValue("@EAddress", txtAddress2.Text)
            cmd.Parameters.AddWithValue("@EContact", txtNumber2.Text)
            cmd.Parameters.AddWithValue("@PatID", txtID.Text)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Successfully Save!", vbOKOnly + vbInformation, "Save!")
            table.Show()
            Me.Hide()
            clear()
            loadTable()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub MedicalRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub linkPatList_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs)
        table.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)

        Try
            conn.Open()
            cmd = conn.CreateCommand
            cmd.CommandText = "DELETE FROM tbl_patient WHERE PatID = @ID"
            cmd.Parameters.AddWithValue("@ID", txtID.Text)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Successfully Deleted!", MsgBoxStyle.Information, "Success")
            clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        table.Show()
        Me.Hide()
    End Sub
End Class