Imports MySql.Data.MySqlClient

Public Class Form11
    ' Connection string for the MySQL database
    Dim connectionString As String = "server=localhost;userid=root;password='';database=CSM"
    Dim connection As New MySqlConnection(connectionString)

    ' Panel3 Click event to load the Manufacturer table data
    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Try
            connection.Open()

            ' SQL query to fetch all data from the Manufacturer table
            Dim query As String = "SELECT Manufacturer_id, Manufacturer_name, Manufacturer_email, Manufacturer_address, Manufacturer_contact FROM Manufacturer"
            Dim cmd As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            ' Fill the DataTable with the query result
            adapter.Fill(dt)

            ' Set the DataSource of DataGridView1 to the DataTable
            DataGridView1.DataSource = dt
        Catch ex As Exception
            ' Handle any exceptions and show an error message
            MessageBox.Show("Error fetching Manufacturer data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection to the database
            connection.Close()
        End Try
    End Sub

    ' Optional: Load event to clear DataGridView1 on form load
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Clear the DataGridView on form load
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
    End Sub

    ' Button to navigate back to another form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show() ' Navigate to Form3
        Me.Close()
    End Sub

    ' Button to close the application
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
