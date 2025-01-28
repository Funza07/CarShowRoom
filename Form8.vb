Imports MySql.Data.MySqlClient

Public Class Form8
    ' Connection string for MySQL database
    Dim connectionString As String = "server=localhost;userid=root;password='';database=CSM"
    Dim connection As New MySqlConnection(connectionString)

    ' Panel3 - Total Sales grouped by car_model and car_company for Sold cars
    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Try
            connection.Open()
            ' Query to calculate the sum of car_price grouped by car_model and car_company for Sold cars
            Dim query As String = "
                SELECT 
                    car_model AS Model, 
                    car_company AS Company, 
                    SUM(car_price) AS TotalSales 
                FROM car 
                WHERE car_status = 'Sold' 
                GROUP BY car_model, car_company
                ORDER BY car_company, car_model"
            Dim cmd As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            ' Execute the query and fill the DataTable
            adapter.Fill(dt)

            ' Display the result in DataGridView1
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).HeaderText = "Car Model"
            DataGridView1.Columns(1).HeaderText = "Car Company"
            DataGridView1.Columns(2).HeaderText = "Total Sales (Price)"
        Catch ex As Exception
            MessageBox.Show("Error calculating total sales: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Panel4 - Total Purchase grouped by car_model and car_company for Available cars
    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        Try
            connection.Open()
            ' Query to calculate the sum of car_price grouped by car_model and car_company for Available cars
            Dim query As String = "
                SELECT 
                    car_model AS Model, 
                    car_company AS Company, 
                    SUM(car_price) AS TotalPurchase 
                FROM car 
                WHERE car_status = 'Available' 
                GROUP BY car_model, car_company
                ORDER BY car_company, car_model"
            Dim cmd As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            ' Execute the query and fill the DataTable
            adapter.Fill(dt)

            ' Display the result in DataGridView1
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).HeaderText = "Car Model"
            DataGridView1.Columns(1).HeaderText = "Car Company"
            DataGridView1.Columns(2).HeaderText = "Total Purchase (Price)"
        Catch ex As Exception
            MessageBox.Show("Error calculating total purchase: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Method to load initial data in DataGridView (if needed)
    Private Sub LoadInitialData()
        Try
            connection.Open()
            Dim query As String = "SELECT car_id, car_name, car_model, car_company, car_status, car_price FROM car"
            Dim cmd As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            ' Fill the DataTable with the car data
            adapter.Fill(dt)

            ' Set the DataGridView's DataSource to the DataTable
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading initial data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Load initial data when Form8 loads
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInitialData()
    End Sub

    ' Button to navigate to Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Close()
    End Sub

    ' Button to close the application
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Close()
    End Sub
End Class
