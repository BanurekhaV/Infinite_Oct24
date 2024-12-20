<%@ Page Title="" Language="C#" MasterPageFile="~/AppMaster.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="MasterPages_Prj.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <asp:TextBox ID="txtb1" runat="server"></asp:TextBox>
    <asp:Button ID="btngo" runat="server" Text="Go" OnClick="btngo_Click" />


    <br />
    <br />
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>

</asp:Content>
