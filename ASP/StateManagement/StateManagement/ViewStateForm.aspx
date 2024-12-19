<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStateForm.aspx.cs" Inherits="StateManagement.TestForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblusername" runat="server" Text="User Name :"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtuname" runat="server" ></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblpassword" runat="server" Text="Password">
                </asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnStore" runat="server" Text="Store Data" OnClick="btnStore_Click" />
            <br />
            <br />
            <asp:Button ID="btnLoad" runat="server" Text="Load Data" OnClick="btnLoad_Click" />
            
            <br />
            <br />
            <asp:Label ID="lblmessage" runat="server" Text="Label"></asp:Label>
            
        </div>
    </form>
</body>
</html>
