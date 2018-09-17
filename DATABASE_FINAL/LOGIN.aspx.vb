Imports System.Data.SqlClient

Public Class LOGIN
    Inherits System.Web.UI.Page

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub loginButton(sender As Object, e As EventArgs) Handles login_button.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        myConn = New SqlConnection("Data Source=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=Company;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        'myConn = New SqlConnection("Server=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=Company;User Id=radey.2;Password=radey.2102297NJ2OH")
        myCmd = myConn.CreateCommand
        Dim command As String = "SELECT COUNT(*) FROM ULOGIN WHERE USERID = '" + username + "';"
        myCmd.CommandText = command
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        Dim userExists As Int32 = myReader.GetInt32(0)
        myReader.Close()
        If (userExists > 0) Then
            command = "SELECT PASSWORD FROM ULOGIN WHERE USERID = '" + username + "';"
            myCmd.CommandText = command
            myReader = myCmd.ExecuteReader()
            myReader.Read()
            Dim actualUserPassword = myReader.GetString(0)
            myReader.Close()
            If (actualUserPassword = password) Then
                command = "SELECT COUNT(*) FROM ADMIN WHERE USERID = '" + username + "';"
                myCmd.CommandText = command
                myReader = myCmd.ExecuteReader()
                myReader.Read()
                Dim admin As Int32 = myReader.GetInt32(0)
                myConn.Close()
                If (admin > 0) Then
                    Server.Transfer("~/AdminPage.aspx", True)

                Else
                    Server.Transfer("~/Default.aspx", True)

                End If
            Else
                errorLabel.Text = "Incorrect Password"
            End If

        Else
            errorLabel.Text = "Invalid username"
        End If
        myConn.Close()
    End Sub

End Class