Imports MySql.Data.MySqlClient

Public Class Form5
    ' Declare the connection string to the database
    Dim connectionString As String = "Server=localhost;Database=CSM;Uid=root;Pwd=;"
    Dim connection As New MySqlConnection(connectionString)

    ' Button3 click event to save the data to the database
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Get values from textboxes
        Dim fullname As String = TextBox1.Text
        Dim address As String = TextBox2.Text
        Dim password As String = TextBox3.Text
        Dim contact As String = TextBox4.Text
        Dim email As String = TextBox5.Text
        Dim designation As String = TextBox6.Text

        ' Validation (You can expand validation based on your needs)
        If String.IsNullOrEmpty(fullname) Or String.IsNullOrEmpty(address) Or String.IsNullOrEmpty(password) Or String.IsNullOrEmpty(contact) Or String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(designation) Then
            MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Get current system date for hire date
        Dim hireDate As String = DateTime.Now.ToString("yyyy-MM-dd")

        ' SQL query to insert data into employee table
        Dim query As String = "INSERT INTO employee (Employee_name, Employee_password, employee_contact, employee_address, employee_email, employee_designation, employee_hiredate) " &
                              "VALUES (@Employee_name, @Employee_password, @employee_contact, @employee_address, @employee_email, @employee_designation, @employee_hiredate)"

        ' Using command object to execute query
        Try
            ' Open connection
            connection.Open()

            ' Create MySQL command
            Dim cmd As New MySqlCommand(query, connection)

            ' Add parameters to prevent SQL injection
            cmd.Parameters.AddWithValue("@Employee_name", fullname)
            cmd.Parameters.AddWithValue("@Employee_password", password)
            cmd.Parameters.AddWithValue("@employee_contact", contact)
            cmd.Parameters.AddWithValue("@employee_address", address)
            cmd.Parameters.AddWithValue("@employee_email", email)
            cmd.Parameters.AddWithValue("@employee_designation", designation)
            cmd.Parameters.AddWithValue("@employee_hiredate", hireDate)

            ' Execute the query
            cmd.ExecuteNonQuery()

            ' Notify the user that the data was saved successfully
            MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Optionally, clear the textboxes after saving the data
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()

        Catch ex As Exception
            ' Handle any errors (e.g., connection errors or SQL issues)
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Always close the connection when done
            connection.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Close()

    End Sub
End Class
