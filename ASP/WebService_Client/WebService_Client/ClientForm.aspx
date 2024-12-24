<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientForm.aspx.cs" Inherits="WebService_Client.ClientForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter User Name : &nbsp;&nbsp;
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnsayhello" runat="server" Text="Sayhello" OnClick="btnsayhello_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
