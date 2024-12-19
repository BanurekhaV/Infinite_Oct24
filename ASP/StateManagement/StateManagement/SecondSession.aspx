<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecondSession.aspx.cs" Inherits="StateManagement.SecondSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnGetSession" runat="server" Text="Get Session" OnClick="BtnGetSession_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="Btnthird" runat="server" Text="Go to another Page" OnClick="Btnthird_Click" />
            <br />
            <br />
            <asp:Label ID="Lblname" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Lblcity" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
