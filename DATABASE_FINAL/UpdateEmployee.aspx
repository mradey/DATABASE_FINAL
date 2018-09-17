<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UpdateEmployee.aspx.vb" Inherits="DATABASE_FINAL.UpdateEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 264px;
        }
        .auto-style3 {
            width: 262px;
        }
    </style>
</head>
<body>
    <form id="registration_form" runat="server">
        <div>
        <table class="auto-style1">  
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Employee First Name: </label><asp:TextBox ID="TextBox1" runat="server" Width="176px"></asp:TextBox></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Employee Last Name: </label><asp:TextBox ID="TextBox2" runat="server" Width="176px"></asp:TextBox></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>New Salary: <asp:TextBox ID="TextBox3" runat="server" Width="183px"></asp:TextBox> </label></td></tr>
        </table>  
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </p>
          <asp:Button ID="Button5" runat="server" Text="Back" />

    </form>
    <a class="btn btn-default" href="DataManagement.aspx">Data Management Page &raquo;</a>

    <asp:label ID ="label1" runat="server"></asp:label>
</body>
</html>
