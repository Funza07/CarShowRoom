<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Label7 = New Label()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        Panel6 = New Panel()
        DataGridView1 = New DataGridView()
        Panel3 = New Panel()
        Label2 = New Label()
        Panel1 = New Panel()
        Panel4 = New Panel()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(539, 41)
        Label7.Name = "Label7"
        Label7.Size = New Size(179, 25)
        Label7.TabIndex = 30
        Label7.Text = "Management System"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(512, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(233, 31)
        Label6.TabIndex = 29
        Label6.Text = "Automobile Showroom"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(263, 72)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 50)
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Ebrima", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(359, 83)
        Label5.Name = "Label5"
        Label5.Size = New Size(252, 37)
        Label5.TabIndex = 28
        Label5.Text = "Sales and Purchases"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(385, 1)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(86, 79)
        PictureBox2.TabIndex = 27
        PictureBox2.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(77), CByte(74), CByte(82))
        Panel6.Location = New Point(263, 128)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(608, 11)
        Panel6.TabIndex = 25
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(243, 150)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(639, 384)
        DataGridView1.TabIndex = 24
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(77), CByte(74), CByte(82))
        Panel3.Controls.Add(Label2)
        Panel3.Cursor = Cursors.Hand
        Panel3.Location = New Point(0, 172)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(237, 95)
        Panel3.TabIndex = 22
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(70, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 18)
        Label2.TabIndex = 1
        Label2.Text = "Total Sales"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(77), CByte(74), CByte(82))
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(237, 533)
        Panel1.TabIndex = 21
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(77), CByte(74), CByte(82))
        Panel4.Controls.Add(Label3)
        Panel4.Cursor = Cursors.Hand
        Panel4.Location = New Point(3, 318)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(237, 95)
        Panel4.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(52, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 18)
        Label3.TabIndex = 2
        Label3.Text = "Total Purchase"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(77), CByte(74), CByte(82))
        Button1.Location = New Point(0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(237, 79)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = SystemColors.Control
        Button2.Location = New Point(796, 26)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 61)
        Button2.TabIndex = 31
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(888, 537)
        Controls.Add(Button2)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(PictureBox2)
        Controls.Add(Panel6)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form8"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form8"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
