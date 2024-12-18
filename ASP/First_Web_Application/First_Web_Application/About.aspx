<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="First_Web_Application.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <h3>Use this area to provide additional information.</h3>
    <ol>
        <li>Item 1</li>
        <li>Item 2</li>
    </ol>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Button" />   <br />
    <input type="button"  runat="server" value="HTML Button"/>
</asp:Content>
