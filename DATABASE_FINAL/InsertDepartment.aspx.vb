Imports System.Data.SqlClient

Public Class InsertDepartment
    Inherits System.Web.UI.Page

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub insertEmployee(sender As Object, e As EventArgs) Handles insert_employee.Click

        myConn = New SqlConnection("Data Source=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=COMPANY_DATABASE1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        'myConn = New SqlConnection("Server=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=Company;User Id=radey.2;Password=radey.2102297NJ2OH")
        myCmd = myConn.CreateCommand
        Dim Command As String = ""
        Command = Command & "INSERT INTO DEPARTMENT VALUES("
        Command = Command & "'" + TextBox11.Text & "',"
        Command = Command & "'" + TextBox12.Text & "',"
        Command = Command & "'" + TextBox13.Text & "',"
        Command = Command & "'" + TextBox14.Text & "');"


        myCmd.CommandText = Command
        myConn.Open()
        myCmd.ExecuteNonQuery()
        myConn.Close()
        Server.Transfer("~/InsertEmployee.aspx")
    End Sub

End Class