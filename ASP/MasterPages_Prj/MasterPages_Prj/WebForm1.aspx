<%@ Page Title="" Language="C#" MasterPageFile="~/AppMaster.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MasterPages_Prj.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <br />

    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="btndo" runat="server" Text="Click for Data" OnClick="btndo_Click" />
</asp:Content>
