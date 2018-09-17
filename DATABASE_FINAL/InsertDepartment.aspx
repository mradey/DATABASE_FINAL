<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InsertDepartment.aspx.vb" Inherits="DATABASE_FINAL.InsertDepartment" %>

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
        <h1>Insert Department</h1>
        <div>  
        <table class="auto-style1">  
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Department Name: </label><asp:TextBox ID="TextBox11" runat="server" Width="176px"></asp:TextBox></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Department Number: </label><asp:TextBox ID="TextBox12" runat="server" Width="183px"></asp:TextBox></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Manager SSN: </label><asp:TextBox ID="TextBox13" runat="server" Width="183px"></asp:TextBox> </label></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Manager Start Date: </label><asp:TextBox ID="TextBox14" runat="server" Width="183px"></asp:TextBox> </label></td></tr>
            </table> 
        </div>
        <p>
            <asp:Button ID="insert_employee" runat="server" Text="Make Department" />
        </p>
            <a class="btn btn-default" href="DataManagement.aspx">Data Management Page &raquo;</a>

    </form>
        <asp:label ID ="errorLabel" runat="server"></asp:label>

</body>
</html>
