Imports System.Data.SqlClient

Public Class InsertEmployee
    Inherits System.Web.UI.Page

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub insertEmployee(sender As Object, e As EventArgs) Handles insert_employee.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        myConn = New SqlConnection("Data Source=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=COMPANY_DATABASE1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        'myConn = New SqlConnection("Server=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=Company;User Id=radey.2;Password=radey.2102297NJ2OH")
        myCmd = myConn.CreateCommand
        Dim command As String = "INSERT INTO EMPLOYEE VALUES('" & TextBox1.Text & "',"
        command = command & "'" + TextBox2.Text & "',"
        command = command & "'" + TextBox3.Text & "',"
        command = command & "'" + TextBox4.Text & "',"
        command = command & "'" + TextBox5.Text & "',"
        command = command & "'" + TextBox6.Text & "',"
        command = command & "'" + TextBox7.Text & "',"
        command = command & "'" + TextBox8.Text & "',"
        command = command & "'" + TextBox9.Text & "',"
        command = command & "'" + TextBox10.Text & "'); "


        myCmd.CommandText = command
        myConn.Open()
        myCmd.ExecuteNonQuery()
        myConn.Close()
        Server.Transfer("~/DataManagement.aspx")
    End Sub

End Class