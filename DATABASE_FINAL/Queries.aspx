<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Queries.aspx.vb" Inherits="DATABASE_FINAL.Queries" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 245px;
            height: 108px;
        }
        .auto-style5 {
            width: 243px;
            height: 27px;
        }
    </style>
</head>
<body>
    <h1>Queries</h1>
    <form id="data_management_form" runat="server">
        <p>Query 1: Retrieve information about employees (e.g., SSN and
name) who have dependents or are department managers. </p>
        <p>Query 2: Retrieve information about employees (e.g., SSN and
name) who are department managers and have dependents </p>
        <p>Query 3: Retrieve information about employees who work on
projects but they are not department managers having dependents. </p>
        <p>Query 4: Retrieve information about employees who have worked
on all projects. </p>
        <p>. Query 5: Retrieve information about each project (e.g., project
number & name) and (next to it) number of employees worked on
the account. </p>
        <p>Query 6: Retrieve employees (ssn & lname), their department
managers (ssn & lname) and the projects (pnumber & pname) they
both worked on.</p>

        <div>
            <table class="auto-style1">  
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><asp:Button ID="Button1" runat="server" Text="Query 1" /></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><asp:Button ID="Button2" runat="server" Text="Query 2" /></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><asp:Button ID="Button3" runat="server" Text="Query 3" /></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><asp:Button ID="Button4" runat="server" Text="Query 4" /></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><asp:Button ID="Button5" runat="server" Text="Query 5" /></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><asp:Button ID="Button6" runat="server" Text="Query 6" /></td></tr>
        </table>  
        </div>
       <a class="btn btn-default" href="Default.aspx">Home Page &raquo;</a>


    </form>

</body>
</html>
