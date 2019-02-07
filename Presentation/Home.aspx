<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Presentation.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="posts" runat="server" AutoPostBack="True">
    </asp:DropDownList>
    <asp:Panel ID="Panel1" runat="server">
        <asp:TextBox ID="content" runat="server"></asp:TextBox>
        <asp:TextBox ID="userId" runat="server"></asp:TextBox>
        <asp:Button ID="Post" runat="server" OnClick="Post_Click" Text="Post" />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="btn_SaveImage" runat="server" OnClick="btn_SaveImage_Click" Text="Save Image" />
        <asp:Image ID="Image1" runat="server" />
    </asp:Panel>
</asp:Content>
