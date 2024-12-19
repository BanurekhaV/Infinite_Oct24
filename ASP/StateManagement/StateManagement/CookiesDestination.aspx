<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookiesDestination.aspx.cs" Inherits="StateManagement.CookiesDestination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbldata1" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbldata2" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnLoad" runat="server" Text="GetData" OnClick="btnLoad_Click" />
        </div>
    </form>
</body>
</html>
