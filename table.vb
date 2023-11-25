Imports MySql.Data.MySqlClient
Public Class table
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
            patientList.DataSource = tbl
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close()
        End Try

    End Sub
    Private Sub table_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
    End Sub

    Private Sub patientList_DoubleClick(sender As Object, e As EventArgs) Handles patientList.DoubleClick
        MedicalRecord.Show()
        Me.Hide()

        MedicalRecord.txtName1.Text = patientList.Item("PatName", patientList.CurrentRow.Index).Value
        MedicalRecord.txtBirth.Text = patientList.Item("PatBday", patientList.CurrentRow.Index).Value
        MedicalRecord.txtGender.Text = patientList.Item("PatGender", patientList.CurrentRow.Index).Value
        MedicalRecord.txtAddress.Text = patientList.Item("PatAddress", patientList.CurrentRow.Index).Value
        MedicalRecord.txtNumber.Text = patientList.Item("PatContact", patientList.CurrentRow.Index).Value
        MedicalRecord.txtEmail.Text = patientList.Item("PatEmail", patientList.CurrentRow.Index).Value
        MedicalRecord.txtName2.Text = patientList.Item("PatEName", patientList.CurrentRow.Index).Value
        MedicalRecord.txtRelationship.Text = patientList.Item("PatRelationship", patientList.CurrentRow.Index).Value
        MedicalRecord.txtAddress2.Text = patientList.Item("PatEAddress", patientList.CurrentRow.Index).Value
        MedicalRecord.txtNumber2.Text = patientList.Item("PatEContact", patientList.CurrentRow.Index).Value
        MedicalRecord.txtID.Text = patientList.Item("PatID", patientList.CurrentRow.Index).Value
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MedicalRecord.Show()
        Me.Hide()
    End Sub
End Class