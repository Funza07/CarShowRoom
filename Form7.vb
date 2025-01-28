Imports MySql.Data.MySqlClient

Public Class Form7
    ' Connection string for the MySQL database
    Dim connectionString As String = "server=localhost;userid=root;password='';database=CSM"
    Dim connection As New MySqlConnection(connectionString)

    ' Panel2 - Hire Employee
    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        ' Open Form5 when Panel2 is clicked
        Form5.Show()
        Me.Close()

    End Sub

    ' Panel3 - Update Employee


    ' Panel4 - Fire Employee
    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        ' Open a MessageBox to get employee ID
        Dim employeeID As String = InputBox("Enter Employee ID to fire:", "Fire Employee")

        If String.IsNullOrEmpty(employeeID) Then
            MessageBox.Show("Employee ID is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Execute query to update employee status to 'Fired' and set fire date to current date
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            connection.Open()

            Dim query As String = "UPDATE employee SET employee_status = 'Fired', employee_firedate = @fireDate WHERE Employee_ID = @employeeID"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@employeeID", employeeID)
            cmd.Parameters.AddWithValue("@fireDate", DateTime.Now.ToString("yyyy-MM-dd"))

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Employee status updated to Fired.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadEmployeeData() ' Reload data after firing
            Else
                MessageBox.Show("Employee ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating employee status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Panel5 - Rehire Employee
    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        ' Open a MessageBox to get employee ID
        Dim employeeID As String = InputBox("Enter Employee ID to rehire:", "Rehire Employee")

        If String.IsNullOrEmpty(employeeID) Then
            MessageBox.Show("Employee ID is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Execute query to update employee status to 'Working' and set hire date to current date and fire date to NULL
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            connection.Open()

            Dim query As String = "UPDATE employee SET employee_status = 'Working', employee_hiredate = @hireDate, employee_firedate = NULL WHERE Employee_ID = @employeeID"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@employeeID", employeeID)
            cmd.Parameters.AddWithValue("@hireDate", DateTime.Now.ToString("yyyy-MM-dd"))

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Employee status updated to Working.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadEmployeeData() ' Reload data after rehiring
            Else
                MessageBox.Show("Employee ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating employee status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Method to load employee data into DataGridView
    Private Sub LoadEmployeeData()
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            connection.Open()

            Dim query As String = "SELECT Employee_ID, Employee_name, employee_contact, employee_address, employee_email, employee_designation, employee_hiredate, employee_firedate, employee_status, employee_sales FROM employee"
            Dim cmd As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            ' Fill the DataTable with the employee data
            adapter.Fill(dt)

            ' Set the DataGridView's DataSource to the DataTable
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading employee data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Load employee data when the form loads
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Close()

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
