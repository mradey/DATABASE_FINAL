<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PopulateDatabase.aspx.vb" Inherits="DATABASE_FINAL.PopulateDatabase" %>

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
    <form id="data_upload_form" name="upload" runat="server">
        <div>
            <table class="auto-style1">  
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><label>Table Name: </label><asp:TextBox ID="TextBox2" runat="server" name="fname" Width="176px" ></asp:TextBox></td></tr>
            <tr><td colspan="2" style="text-align: left; vertical-align: top" class="auto-style3"><input id="Exfile" runat="server" type="file" name="Exfile" accept="application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" /></td></tr>

            </table>  
        </div>
        <asp:Button ID="submit_table" runat="server" Text="submit" />
        <a class="btn btn-default" href="DataManagement.aspx">Data Management Page &raquo;</a>

        <span id="Span1" runat="Server" />

    </form>

 

</body>
</html>
