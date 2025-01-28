Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class Form9
    ' Variables to hold passed data
    Private carId As String
    Private customerName As String
    Private customerCNIC As String
    Private customerContact As String
    Private customerAddress As String
    Private employeeId As String
    Private employeeName As String
    Private employeeContact As String
    Private employeeDesignation As String
    Private orderId As Integer
    Private carName As String
    Private carModel As String
    Private carCompany As String
    Private carPrice As Decimal
    Private taxAmount As Decimal = 1500 ' Example tax amount
    Private billAmount As Decimal
    Private orderDate As DateTime

    ' Custom Constructor
    Public Sub New(carId As String, customerName As String, customerCNIC As String, customerContact As String, customerAddress As String, employeeId As String, employeeName As String, employeeContact As String, employeeDesignation As String, orderId As Integer, carName As String, carModel As String, carCompany As String, carPrice As Decimal, orderDate As Date)
        ' Initialize the form
        InitializeComponent()

        ' Assign data to local variables
        Me.carId = carId
        Me.customerName = customerName
        Me.customerCNIC = customerCNIC
        Me.customerContact = customerContact
        Me.customerAddress = customerAddress
        Me.employeeId = employeeId
        Me.employeeName = employeeName
        Me.employeeContact = employeeContact
        Me.employeeDesignation = employeeDesignation
        Me.orderId = orderId
        Me.carName = carName
        Me.carModel = carModel
        Me.carCompany = carCompany
        Me.carPrice = carPrice
        Me.orderDate = orderDate

        ' Calculate total bill
        billAmount = carPrice + taxAmount
    End Sub

    ' Fetch Employee Details from the Database
    Private Sub FetchEmployeeDetails(empId As String)
        Try
            ' Connection string to your MySQL database
            Dim connectionString As String = "server=localhost;userid=root;password=yourpassword;database=yourdatabase"
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Query to get employee details
                Dim query As String = "SELECT Employee_name, Employee_contact, Employee_designation FROM Employee WHERE Employee_ID = @empId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@empId", empId)

                    ' Execute the query and fetch the data
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            employeeName = reader("Employee_name").ToString()
                            employeeContact = reader("Employee_contact").ToString()
                            employeeDesignation = reader("Employee_designation").ToString()
                        Else
                            MessageBox.Show("Employee not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching employee details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Create PrintDocument object
    Private WithEvents PrintDoc As New PrintDocument

    ' Create PrintPreviewDialog object
    Private WithEvents PrintPreviewDialog As New PrintPreviewDialog

    ' Button to open Print Preview
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Set the PrintDocument for the PrintPreviewDialog
        PrintPreviewDialog.Document = PrintDoc

        ' Display the PrintPreviewDialog
        PrintPreviewDialog.ShowDialog()
    End Sub

    ' PrintPage event for PrintDocument
    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        ' Set fonts and layout
        Dim titleFont As New Font("Arial", 16, FontStyle.Bold)
        Dim headerFont As New Font("Arial", 12, FontStyle.Bold)
        Dim regularFont As New Font("Arial", 10)
        Dim margin As Integer = 50
        Dim currentY As Integer = margin
        Dim lineSpacing As Integer = 25

        ' Draw a centered header
        Dim centerX As Integer = e.PageBounds.Width / 2
        Dim headerText As String = "CAR SHOWROOM BILL"
        Dim headerSize As SizeF = e.Graphics.MeasureString(headerText, titleFont)
        e.Graphics.DrawString(headerText, titleFont, Brushes.Black, centerX - headerSize.Width / 2, currentY)
        currentY += lineSpacing + 10

        ' Draw a horizontal line
        e.Graphics.DrawLine(Pens.Black, margin, currentY, e.PageBounds.Width - margin, currentY)
        currentY += lineSpacing

        ' Section: Customer Details
        e.Graphics.DrawString("CUSTOMER DETAILS", headerFont, Brushes.Black, margin, currentY)
        currentY += lineSpacing
        e.Graphics.DrawString("Name: " & customerName, regularFont, Brushes.Black, margin, currentY)
        currentY += lineSpacing
        e.Graphics.DrawString("CNIC: " & customerCNIC, regularFont, Brushes.Black, margin, currentY)
        currentY += lineSpacing
        e.Graphics.DrawString("Contact: " & customerContact, regularFont, Brushes.Black, margin, currentY)
        currentY += lineSpacing
        e.Graphics.DrawString("Address: " & customerAddress, regularFont, Brushes.Black, margin, currentY)
        currentY += lineSpacing + 10

        ' Draw a horizontal line
        e.Graphics.DrawLine(Pens.Black, margin, currentY, e.PageBounds.Width - margin, currentY)
        currentY += lineSpacing

        ' Section: Car Details
        e.Graphics.DrawString("CAR DETAILS", headerFont, Brushes.Black, margin, currentY)
        currentY += lineSpacing
        e.Graphics.DrawString("Car Name: " & carName, regularFont, Brushes.Black, margin, currentY)
        currentY += lineSpacing
        e.Graphics.DrawString("Model: " & carModel, regularFont, Brushes.Black, margin, currentY)
        currentY += lineSpacing
        e.Graphics.DrawString("Company: " & carCompany, regularFont, Brushes.Black, margin, currentY)
        currentY += lineSpacing
        e.Graphics.DrawString("Price: " & carPrice.ToString("C2"), regularFont, Brushes.Black, margin, currentY)
        currentY += lineSpacing + 10

        ' Draw a horizontal line
        e.Graphics.DrawLine(Pens.Black, margin, currentY, e.PageBounds.Width - margin, currentY)
        currentY += lineSpacing

        ' Section: Billing Details
        e.Graphics.DrawString("BILLING DETAILS", headerFont, Brushes.Black, margin, currentY)
        currentY += lineSpacing
        e.Graphics.DrawString("Tax Amount: " & taxAmount.ToString("C2"), regularFont, Brushes.Black, margin, currentY)
        currentY += lineSpacing
        e.Graphics.DrawString("Total Bill: " & billAmount.ToString("C2"), headerFont, Brushes.Black, margin, currentY)
        currentY += lineSpacing + 10

        ' Draw a horizontal line
        e.Graphics.DrawLine(Pens.Black, margin, currentY, e.PageBounds.Width - margin, currentY)
        currentY += lineSpacing

        ' Section: Order Details
        e.Graphics.DrawString("ORDER DETAILS", headerFont, Brushes.Black, margin, currentY)
        currentY += lineSpacing
        e.Graphics.DrawString("Order ID: " & orderId.ToString(), regularFont, Brushes.Black, margin, currentY)
        currentY += lineSpacing
        e.Graphics.DrawString("Order Date: " & orderDate.ToString("yyyy-MM-dd"), regularFont, Brushes.Black, margin, currentY)
        currentY += lineSpacing

        ' Footer
        currentY += 30
        e.Graphics.DrawString("Thank you for choosing our showroom!", headerFont, Brushes.Black, margin, currentY)
    End Sub



    ' Method to update label values
    Private Sub UpdateLabels()
        ' Car Section
        Label4.Text = carName
        'Label5.Text = carId
        Label7.Text = carModel
        Label9.Text = carCompany

        ' Seller/Customer Section
        Label35.Text = customerName
        Label33.Text = customerCNIC
        Label31.Text = customerContact
        Label29.Text = customerAddress



        ' Order Section
        Label26.Text = orderId.ToString()
        Label24.Text = billAmount.ToString("C2") ' Format as currency
        Label22.Text = orderDate.ToString("yyyy-MM-dd")
    End Sub



    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateLabels()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
