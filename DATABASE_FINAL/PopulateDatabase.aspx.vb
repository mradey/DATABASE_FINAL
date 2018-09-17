Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient

Public Class PopulateDatabase
    Inherits System.Web.UI.Page

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub process_file(sender As Object, e As EventArgs) Handles submit_table.Click
        Dim filename As String = RandomString()
        If Not (Exfile.PostedFile Is Nothing) Then
            Try
                Exfile.PostedFile.SaveAs("C:\Users\radey\source\repos\Company_WebAPP\" + filename + ".xlsx")
                Span1.InnerHtml = "Upload Successful!"
            Catch ex As Exception
                Span1.InnerHtml = "Error saving file"
            End Try
        End If
        Dim application = New Excel.Application()
        Dim workbook As Excel.Workbook = application.Workbooks.Open("C:\Users\radey\source\repos\Company_WebAPP\" + filename + ".xlsx")
        Dim worksheet As Excel.Worksheet = workbook.Sheets(1)
        Dim usedRange = worksheet.UsedRange
        Dim Array2d As Object(,) = usedRange.Value2
        workbook.Save()
        workbook.Close()
        application.Quit()
        myConn = New SqlConnection("Data Source=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=COMPANY_DATABASE1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        'myConn = New SqlConnection("Server=LAPTOP-E3TPRQS4\SQLEXPRESS;Database=Company;User Id=radey.2;Password=radey.2102297NJ2OH")
        myCmd = myConn.CreateCommand
        myConn.Open()

        Dim temp As String = Array2d(1, 1)
        Dim dataType As String = "VARCHAR(100)"
        Dim str As String = "CREATE TABLE " + TextBox2.Text + "("
        Dim x As Integer = Array2d.GetLength(0)
        Dim y As Integer = Array2d.GetLength(1)
        For i As Integer = 1 To y
            str = str & Array2d(1, i)
            str = str & " VARCHAR(100)"
            If (i = y) Then
            Else
                str = str & ","
            End If

            str = str & " "
        Next
        str = str & ");"


        Dim INSERT As String = "INSERT INTO " + TextBox2.Text + " VALUES("
        Dim VALUES As String = ""

        For a As Integer = 2 To x
            VALUES = VALUES & INSERT
            For b As Integer = 1 To y
                VALUES = VALUES & "'" & Array2d(a, b) & "'"
                If (b = y) Then
                    VALUES = VALUES & ");"
                Else
                    VALUES = VALUES & ","
                End If

            Next

        Next
        myCmd.CommandText = str & " " & VALUES
        myCmd.ExecuteNonQuery()

        myConn.Close()
    End Sub

    Private Function RandomString() As String
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 20
            Dim idx As Integer = r.Next(0, 25)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

End Class