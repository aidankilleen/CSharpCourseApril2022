<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="HelloWorldDotNetWebApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>


    <h3>Aidan was here....</h3>
    <p>&nbsp;</p>
    <p>
        <asp:ListBox ID="lstUsers" runat="server"></asp:ListBox>
    </p>


</asp:Content>
