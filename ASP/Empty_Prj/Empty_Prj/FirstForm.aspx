<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstForm.aspx.cs" Inherits="Empty_Prj.FirstForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblname" runat="server" Text="Enter Name :"></asp:Label>
            &nbsp;   &nbsp;
            <asp:TextBox ID="Txtname" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnclick" runat="server" OnClick="btnclick_Click" Text="Click me" />
        </div>
    </form>
    
</body>
</html>
