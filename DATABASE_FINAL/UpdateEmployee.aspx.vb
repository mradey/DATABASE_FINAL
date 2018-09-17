
Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class UpdateEmployee
    Inherits System.Web.UI.Page

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim Smtp_Server As New SmtpClient
        'Dim e_mail As New MailMessage()
        'Smtp_Server.UseDefaultCredentials = False
        'Smtp_Server.Credentials = New Net.NetworkCredential("radeymichael@gmail.com", "mr102297")
        'Dim adminEmail As String = ""
        'Smtp_Server.Port = 587
        'Smtp_Server.EnableSsl = True
        'Smtp_Server.Host = "smtp.gmail.com"




        Dim fname As String = TextBox1.Text
        Dim lname As String = TextBox2.Text
        Dim salary As String = TextBox3.Text
        myConn = New SqlConnection("Data Source=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=COMPANY_DATABASE1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        'myConn = New SqlConnection("Server=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=Company;User Id=radey.2;Password=radey.2102297NJ2OH")
        Dim command As String = "UPDATE EMPLOYEE SET SALARY = '" + salary + "' WHERE FNAME = '" + fname + "' AND LNAME = '" + lname + "';"
        myCmd = myConn.CreateCommand
        myCmd.CommandText = command
        myConn.Open()
        myCmd.ExecuteNonQuery()
        myConn.Close()




        'e_mail = New MailMessage()
        'e_mail.From = New MailAddress("radeymichael@gmail.com")
        'e_mail.To.Add(adminEmail)
        'e_mail.Subject = "Updated Employee"
        'e_mail.IsBodyHtml = False
        'e_mail.Body = "updated Employee: " + fname + " " + lname + " now has salary: " + salary
        'Smtp_Server.Send(e_mail)

    End Sub

End Class