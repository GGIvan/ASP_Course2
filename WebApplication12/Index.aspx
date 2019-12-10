<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication12.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Previous" />
    <asp:Button ID="Button2" runat="server" Text="Next" OnClick="Button2_Click" />
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
</asp:Content>
