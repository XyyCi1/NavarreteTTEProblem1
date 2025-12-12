Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click


        Dim query As String = "INSERT INTO `museum_db`.`artifacts_tbl` (`artifact_name`, `country`, `year_found`, `condition`) VALUES (@artifact_name, @country, @year_found, @condition);"

        Try
            Using conn As New MySqlConnection("Server = localhost;userid=root;password=root;database=museum_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@artifact_name", TextBoxName.Text)
                    cmd.Parameters.AddWithValue("@country", TextBoxOrigin.Text)
                    cmd.Parameters.AddWithValue("@year_found", CInt(TextBoxYRDisc.Text))
                    cmd.Parameters.AddWithValue("@condition", ComboBoxCondition.Text)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Record Inserted Successfully")

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ButtonLoad_Click(sender As Object, e As EventArgs) Handles ButtonLoad.Click
        Dim query As String = "SELECT * FROM museum_db.artifacts_tbl;"

        Try

            Using conn As New MySqlConnection("server=localhost;userid=root;password=root;database=museum_db;")
                Dim adapter As New MySqlDataAdapter(query, conn) ' get from
                Dim table As New DataTable() ' table object
                adapter.Fill(table) ' from adapter to table object
                DataGridView1.DataSource = table ' display to DataGridView
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim id As Integer = CInt(selectedRow.Cells("id").Value)

            Dim query As String = "DELETE FROM artifacts_tbl WHERE id = @id"
            Try
                Using conn As New MySqlConnection("server=localhost;userid=root;password=root;database=museum_db;")
                    conn.Open()
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", id)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Record Deleted Successfully")
                        Else
                            MessageBox.Show("Delete Failed: No matching record found")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select a row to delete")
        End If
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        DataGridView1.EndEdit()
        BindingContext(DataGridView1.DataSource).EndCurrentEdit()

        Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(rowIndex)
        Dim idValue = selectedRow.Cells("id").Value
        Dim nameValue = selectedRow.Cells("artifact_name").Value
        Dim countryValue = selectedRow.Cells("country").Value
        Dim YearFoundValue = selectedRow.Cells("year_found").Value
        Dim ConditionValue = selectedRow.Cells("condition").Value



        If idValue IsNot Nothing AndAlso idValue.ToString().Trim() <> "" AndAlso Integer.TryParse(idValue.ToString(), Nothing) Then
            Dim query As String = "UPDATE museum_db.artifacts_tbl 
                        SET artifact_name = @artifact_name,
                            country = @country,
                            year_found = @year_found,
                            `condition` = @condition
                        WHERE id = @id;"



            Try
                Using conn As New MySqlConnection("server=localhost;userid=root;password=root;database=museum_db;")
                    conn.Open()
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@artifact_name", nameValue.ToString())
                        cmd.Parameters.AddWithValue("@country", countryValue)
                        cmd.Parameters.AddWithValue("@year_found", CInt(YearFoundValue))
                        cmd.Parameters.AddWithValue("@condition", ConditionValue)
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idValue))

                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Record Updated Successfully")
                            ButtonLoad_Click(Nothing, Nothing)
                        Else
                            MessageBox.Show("Update Failed: No matching record found")
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("ID is invalid. Please select a valid row.")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBoxName.Text = row.Cells("artifact_name").Value.ToString()
            TextBoxOrigin.Text = row.Cells("country").Value.ToString()
            TextBoxYRDisc.Text = row.Cells("year_found").Value.ToString()

            ComboBoxCondition.Text = row.Cells("condition").Value.ToString()




        End If
    End Sub
End Class
