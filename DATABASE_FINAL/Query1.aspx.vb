Imports System.Data.SqlClient

Public Class Query1
    Inherits System.Web.UI.Page
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myConn = New SqlConnection("Data Source=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=COMPANY_DATABASE1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        'myConn = New SqlConnection("Server=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=Company;User Id=radey.2;Password=radey.2102297NJ2OH")
        myCmd = myConn.CreateCommand
        Dim command As String = "SELECT SSN, FNAME, LNAME 
                                 FROM Employee
                                 WHERE SSN IN (SELECT ESSN
			                                   FROM Dependent)
                                 UNION
                                 SELECT SSN, FNAME, LNAME 
                                 FROM Employee
                                 WHERE SSN IN (SELECT MGRSSN
			                                   FROM Department);"
        myCmd.CommandText = command
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Dim s As String = "SSN FNAME LNAME"
        While myReader.Read()
            s = s & myReader.GetString(0) & " " & myReader.GetString(1) & " " & myReader.GetString(2) & " "
            s = s & "<br></br>"
        End While
        Query1Span1.InnerHtml = s
        myReader.Close()
        myConn.Close()
    End Sub


End Class