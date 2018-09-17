<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="LOGIN.aspx.vb" Inherits="DATABASE_FINAL.LOGIN" %>

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
        <h1>Login</h1>
        <div>
            <table class="auto-style1">  
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Username: </label><asp:TextBox ID="TextBox1" runat="server" Width="176px"></asp:TextBox></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Password: <asp:TextBox ID="TextBox2" type="password" runat="server" Width="183px"></asp:TextBox> </label></td></tr>
        </table>  
        </div>
        <p>
            <asp:Button ID="login_button" runat="server" Text="Login" />
        </p>
        <p>
            New User? Register Below!
        </p>
        <p>
           <a class="btn btn-default" href="REGISTRATION.aspx">Registration &raquo;</a>

        </p>

    </form>

        <asp:label ID ="errorLabel" runat="server"></asp:label>

</body>
</html>
