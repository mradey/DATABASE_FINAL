<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AdminPage.aspx.vb" Inherits="DATABASE_FINAL.AdminPage" %>

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
    <form id="login_form" runat="server">
        <h1>Admin Page</h1>
        <div>
            <table class="auto-style1">  
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><asp:Button ID="Button1" runat="server" Text="View Users" /></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>User to add(ID,Password): </label><asp:TextBox ID="TextBox1" runat="server" Width="176px"></asp:TextBox><asp:TextBox ID="TextBox2" runat="server" Width="176px"></asp:TextBox></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><asp:Button ID="Button2" runat="server" Text="Add User" /></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>User to delete: </label><asp:TextBox ID="TextBox3" runat="server" Width="176px"></asp:TextBox></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><asp:Button ID="Button3" runat="server" Text="Delete User" /></td></tr>            
            </table>  
        </div>
        <a class="btn btn-default" href="Default.aspx">Home &raquo;</a>

        <span id="Span1" runat="Server" />

    </form>

</body>
</html>
