Imports MySql.Data.MySqlClient

Public Class Form10
    ' Connection string for the MySQL database
    Dim connectionString As String = "server=localhost;userid=root;password='';database=CSM"
    Dim connection As New MySqlConnection(connectionString)

    ' Panel2 - Credit Amount (Sold Cars)
    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Try
            ' Open the connection if not already open
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            connection.Open()

            ' Query to fetch sold cars from the car table
            Dim query As String = "SELECT car_id, car_name, car_model, car_company, car_status, car_price FROM car WHERE car_status = 'Sold'"
            Dim cmd As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            ' Fill the DataTable with the query result
            adapter.Fill(dt)

            ' Display the data in DataGridView1
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error fetching sold cars: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            connection.Close()
        End Try
    End Sub

    ' Panel3 - Debit Amount (Available Cars)
    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Try
            ' Open the connection if not already open
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            connection.Open()

            ' Query to fetch available cars from the car table
            Dim query As String = "SELECT car_id, car_name, car_model, car_company, car_status, car_price FROM car WHERE car_status = 'Available'"
            Dim cmd As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            ' Fill the DataTable with the query result
            adapter.Fill(dt)

            ' Display the data in DataGridView1
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error fetching available cars: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            connection.Close()
        End Try
    End Sub

    ' Panel4 - Total Transactions (All Cars)
    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        Try
            ' Open the connection if not already open
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            connection.Open()

            ' Query to fetch all cars from the car table
            Dim query As String = "SELECT car_id, car_name, car_model, car_company, car_status, car_price FROM car"
            Dim cmd As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            ' Fill the DataTable with the query result
            adapter.Fill(dt)

            ' Display the data in DataGridView1
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error fetching all cars: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            connection.Close()
        End Try
    End Sub

    ' Load event to initialize data or settings (if needed)
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optionally load default data or settings here
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Close()

    End Sub
End Class
