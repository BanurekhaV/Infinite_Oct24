<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CacheForm.aspx.cs" Inherits="Caching_Prj.CacheForm" %>
<%--<%@ OutputCache Duration="30" VaryByParam="None" Location="Client" %>--%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Select a Product : &nbsp;&nbsp;<asp:DropDownList ID="DDL" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDL_SelectedIndexChanged">
                 <asp:ListItem Text="All" Value="All"></asp:ListItem>
                 <asp:ListItem Text="Laptops" Value="Laptops"></asp:ListItem>
                  <asp:ListItem Text="Desktops" Value="Desktops"></asp:ListItem>
                   <asp:ListItem Text="iPhones" Value="iPhones"></asp:ListItem>
                   <asp:ListItem Text="LED  TV" Value="LED"></asp:ListItem>             
                                       </asp:DropDownList>
        <br /><br />

        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <br />
        Server Time : <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br /><br />
        Client Time : <br />
        <script>
            document.write(Date());
        </script>
    </form>

</body>
</html>
