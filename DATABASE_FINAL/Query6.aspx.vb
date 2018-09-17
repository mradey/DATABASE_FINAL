Imports System.Data.SqlClient

Public Class Query6
    Inherits System.Web.UI.Page
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myConn = New SqlConnection("Data Source=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=COMPANY_DATABASE1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        'myConn = New SqlConnection("Server=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=Company;User Id=radey.2;Password=radey.2102297NJ2OH")
        myCmd = myConn.CreateCommand
        Dim command As String = "SELECT E.SSN, E.LNAME, S.SSN, S.LNAME, P.PNAME, P.PNUMBER
                                 FROM Employee AS E
                                 INNER JOIN Employee S ON E.SUPPERSSN = S.SSN
                                 INNER JOIN Works_On WE ON E.SSN = WE.ESSN
                                 INNER JOIN Works_On WS ON S.SSN = WS.ESSN AND WE.PNO = WS.PNO
                                 INNER JOIN Project P ON WE.PNO = P.PNUMBER"
        myCmd.CommandText = command
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Dim s As String = "ESSN ELNAME SSSN SLNAME PNAME PNUMBER"
        While myReader.Read()
            s = s & myReader.GetString(0) & " " & myReader.GetString(1) & " " & myReader.GetString(2) & " " & myReader.GetString(3) & " " & myReader.GetString(4) & " " & myReader.GetString(5) & " "
            s = s & "<br></br>"
        End While
        Query6Span1.InnerHtml = s
        myReader.Close()
        myConn.Close()
    End Sub



End Class