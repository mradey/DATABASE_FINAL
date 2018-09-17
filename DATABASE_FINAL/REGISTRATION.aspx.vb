
Imports System.Data.SqlClient

Public Class REGISTRATION
    Inherits System.Web.UI.Page

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim username As String = TextBox1.Text
        Dim pass As String = TextBox2.Text
        Dim confPass As String = TextBox3.Text
        Dim Prompt As String = "Passwords don't match"

        If (pass = confPass) Then
            myConn = New SqlConnection("Data Source=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=Company;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            'myConn = New SqlConnection("Server=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=Company;User Id=radey.2;Password=radey.2102297NJ2OH")
            myCmd = myConn.CreateCommand
            Dim command As String = "SELECT COUNT(*) FROM ULOGIN WHERE USERID = '" + username + "';"
            myCmd.CommandText = command
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            myReader.Read()
            Dim exists As Int32 = myReader.GetInt32(0)
            myReader.Close()
            If (exists >= 1) Then
                label1.Text = "Username already taken"
                TextBox1.Text = ""
            Else
                command = "INSERT INTO ULOGIN VALUES ('" + username + "','" + pass + "');"
                myCmd.CommandText = command
                myCmd.ExecuteNonQuery()
                myConn.Close()
                label1.Text = ""
                Server.Transfer("~/LOGIN.aspx", True)

            End If

        Else
            label1.Text = Prompt
            TextBox2.Text = ""
            TextBox3.Text = ""
        End If

    End Sub

End Class