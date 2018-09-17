Imports System.Data.SqlClient

Public Class Queries
    Inherits System.Web.UI.Page
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub query1(sender As Object, e As EventArgs) Handles Button1.Click
        Server.Transfer("~/Query1.aspx")
    End Sub
    Protected Sub query2(sender As Object, e As EventArgs) Handles Button2.Click
        Server.Transfer("~/Query2.aspx")

    End Sub
    Protected Sub query3(sender As Object, e As EventArgs) Handles Button3.Click
        Server.Transfer("~/Query3.aspx")

    End Sub
    Protected Sub query4(sender As Object, e As EventArgs) Handles Button4.Click
        Server.Transfer("~/Query4.aspx")

    End Sub
    Protected Sub query5(sender As Object, e As EventArgs) Handles Button5.Click
        Server.Transfer("~/Query5.aspx")

    End Sub
    Protected Sub query6(sender As Object, e As EventArgs) Handles Button6.Click
        Server.Transfer("~/Query6.aspx")

    End Sub

End Class