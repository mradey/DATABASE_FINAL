Imports System.Data.SqlClient

Public Class AdminPage
    Inherits System.Web.UI.Page

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub viewUsers(sender As Object, e As EventArgs) Handles Button1.Click
        myConn = New SqlConnection("Data Source=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=Company;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        'myConn = New SqlConnection("Server=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=Company;User Id=radey.2;Password=radey.2102297NJ2OH")
        myCmd = myConn.CreateCommand
        Dim command As String = "SELECT * FROM ULOGIN;"
        myCmd.CommandText = command
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Dim s As String = "USERID PASSWORD <br></br>"
        While myReader.Read()
            s = s & myReader.GetString(0) & " " & myReader.GetString(1) & " "
            s = s & "<br></br>"
        End While
        Span1.InnerHtml = s
        myReader.Close()
        myConn.Close()
    End Sub
    Protected Sub addUser(sender As Object, e As EventArgs) Handles Button2.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        myConn = New SqlConnection("Data Source=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=Company;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        'myConn = New SqlConnection("Server=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=Company;User Id=radey.2;Password=radey.2102297NJ2OH")
        myCmd = myConn.CreateCommand
        Dim command As String = "INSERT INTO ULOGIN VALUES('" & username & "',"
        command = command & "'" + password & "');"
        myCmd.CommandText = command
        myConn.Open()
        myCmd.ExecuteNonQuery()
        myConn.Close()
    End Sub
    Protected Sub deleteUser(sender As Object, e As EventArgs) Handles Button3.Click
        Dim username As String = TextBox3.Text
        myConn = New SqlConnection("Data Source=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=Company;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        'myConn = New SqlConnection("Server=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=Company;User Id=radey.2;Password=radey.2102297NJ2OH")
        myCmd = myConn.CreateCommand
        Dim command As String = "DELETE FROM ULOGIN WHERE USERID = '" + username + "';"
        myCmd.CommandText = command
        myConn.Open()
        myCmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

End Class