<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DataManagement.aspx.vb" Inherits="DATABASE_FINAL.DataManagement" %>

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
    <form id="data_management_form" runat="server">
        <h1>Data Management Page</h1>
        <div>
            <table class="auto-style1">  
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><asp:Button ID="Button1" runat="server" Text="Create Company Database" /></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><asp:Button ID="Button2" runat="server" Text="Populate Company Database" /></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><asp:Button ID="Button3" runat="server" Text="Insert Employee" /></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><asp:Button ID="Button4" runat="server" Text="Update Employee" /></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><asp:Button ID="Button5" runat="server" Text="Home" /></td></tr>

        </table>  

        </div>
    </form>

</body>
</html>
