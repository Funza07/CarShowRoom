Imports MySql.Data.MySqlClient

Public Class Form6
    ' Connection string for the MySQL database
    Dim connectionString As String = "server=localhost;userid=root;password='';database=CSM"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Check if all textboxes are filled
        If String.IsNullOrEmpty(TextBox1.Text) OrElse String.IsNullOrEmpty(TextBox2.Text) OrElse String.IsNullOrEmpty(TextBox3.Text) OrElse String.IsNullOrEmpty(TextBox4.Text) OrElse String.IsNullOrEmpty(TextBox5.Text) OrElse String.IsNullOrEmpty(TextBox6.Text) OrElse String.IsNullOrEmpty(TextBox7.Text) OrElse String.IsNullOrEmpty(TextBox8.Text) OrElse String.IsNullOrEmpty(TextBox9.Text) OrElse String.IsNullOrEmpty(TextBox10.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Insert into the manufacturer table
        Try
            connection.Open()
            Dim insertManufacturerQuery As String = "INSERT INTO manufacturer (manufacturer_id, manufacturer_name, manufacturer_email, manufacturer_address, manufacturer_contact) " &
                                                     "VALUES (@manufacturerID, @manufacturerName, @manufacturerEmail, @manufacturerAddress, @manufacturerContact)"
            Dim cmdManufacturer As New MySqlCommand(insertManufacturerQuery, connection)
            cmdManufacturer.Parameters.AddWithValue("@manufacturerID", TextBox1.Text)
            cmdManufacturer.Parameters.AddWithValue("@manufacturerName", TextBox3.Text)
            cmdManufacturer.Parameters.AddWithValue("@manufacturerEmail", TextBox10.Text)
            cmdManufacturer.Parameters.AddWithValue("@manufacturerAddress", TextBox6.Text)
            cmdManufacturer.Parameters.AddWithValue("@manufacturerContact", TextBox8.Text)

            cmdManufacturer.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error inserting manufacturer data: " & ex.Message)
            connection.Close()
            Return
        End Try

        ' Insert into the car table
        Try
            Dim insertCarQuery As String = "INSERT INTO car (car_id, car_name, car_model, car_company, car_status, car_price) " &
                                           "VALUES (@carID, @carName, @carModel, @carCompany, @carStatus, @carPrice)"
            Dim cmdCar As New MySqlCommand(insertCarQuery, connection)
            cmdCar.Parameters.AddWithValue("@carID", TextBox2.Text)
            cmdCar.Parameters.AddWithValue("@carName", TextBox4.Text)
            cmdCar.Parameters.AddWithValue("@carModel", TextBox7.Text)
            cmdCar.Parameters.AddWithValue("@carCompany", TextBox5.Text)
            cmdCar.Parameters.AddWithValue("@carStatus", "Available")
            cmdCar.Parameters.AddWithValue("@carPrice", Convert.ToDecimal(TextBox9.Text))

            cmdCar.ExecuteNonQuery()
            MessageBox.Show("Manufacturer and Car data inserted successfully.")
        Catch ex As Exception
            MessageBox.Show("Error inserting car data: " & ex.Message)
            connection.Close()
            Return
        End Try

        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Close()
    End Sub


End Class
