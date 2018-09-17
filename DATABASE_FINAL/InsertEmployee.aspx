<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InsertEmployee.aspx.vb" Inherits="DATABASE_FINAL.InsertEmployee" %>

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
        <h1>Insert Employee</h1>
        <div>
            <table class="auto-style1">  
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>First Name: </label><asp:TextBox ID="TextBox1" runat="server" Width="176px"></asp:TextBox></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Middle Initial: </label><asp:TextBox ID="TextBox2" runat="server" Width="183px"></asp:TextBox></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Last Name: </label><asp:TextBox ID="TextBox3" runat="server" Width="183px"></asp:TextBox> </label></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>SSN: </label><asp:TextBox ID="TextBox4" runat="server" Width="183px"></asp:TextBox> </label></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Birth Date: </label><asp:TextBox ID="TextBox5" runat="server" Width="183px"></asp:TextBox> </label></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Address: </label><asp:TextBox ID="TextBox6" runat="server" Width="183px"></asp:TextBox> </label></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Sex: </label><asp:TextBox ID="TextBox7" runat="server" Width="183px"></asp:TextBox> </label></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Salary: </label><asp:TextBox ID="TextBox8" runat="server" Width="183px"></asp:TextBox> </label></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Manager SSN: </label><asp:TextBox ID="TextBox9" runat="server" Width="183px"></asp:TextBox> </label></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Department Number: </label><asp:TextBox ID="TextBox10" runat="server" Width="183px"></asp:TextBox> </label></td></tr>
        </table>  
        </div>
        <p>
            <asp:Button ID="insert_employee" runat="server" Text="Make Employee" />
        </p>

    </form>
        <asp:label ID ="errorLabel" runat="server"></asp:label>

</body>
</html>
