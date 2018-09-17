Imports System.Data.SqlClient

Public Class DataManagement
    Inherits System.Web.UI.Page
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub createDatabase(sender As Object, e As EventArgs) Handles Button1.Click
        myConn = New SqlConnection("Data Source=LAPTOP-E3TPRQS4\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        myCmd = myConn.CreateCommand
        Dim command As String = "CREATE DATABASE COMPANY_DATABASE1;"
        myCmd.CommandText = command
        myConn.Open()
        myCmd.ExecuteNonQuery()
    End Sub
    Protected Sub populateDatabase(sender As Object, e As EventArgs) Handles Button2.Click
        Server.Transfer("~/PopulateDatabase.aspx", True)
    End Sub
    Protected Sub insertEmployee(sender As Object, e As EventArgs) Handles Button3.Click
        Server.Transfer("~/InsertDepartment.aspx", True)

    End Sub
    Protected Sub updateEmployee(sender As Object, e As EventArgs) Handles Button4.Click
        Server.Transfer("~/UpdateEmployee.aspx", True)

    End Sub
    Protected Sub back(sender As Object, e As EventArgs) Handles Button5.Click
        Server.Transfer("~/Default.aspx", True)
    End Sub
End Class