<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="REGISTRATION.aspx.vb" Inherits="DATABASE_FINAL.REGISTRATION" %>

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
        <h1>Registration</h1>
        <div>
        <table class="auto-style1">  
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Username: </label><asp:TextBox ID="TextBox1" runat="server" Width="176px"></asp:TextBox></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Password: <asp:TextBox ID="TextBox2" type="password" runat="server" Width="183px"></asp:TextBox> </label></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Confirm Password: </label><asp:TextBox ID="TextBox3" type="password" runat="server" Width="127px"></asp:TextBox></td></tr>
        </table>  
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Register!" />
        </p>
         <p>
            Already a User? Login Below!
        </p>
        <p>
          <a class="btn btn-default" href="LOGIN.aspx">Login &raquo;</a>

        </p>

    </form>

    <asp:label ID ="label1" runat="server"></asp:label>
</body>
</html>
