<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainMaster.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Presentation.Pages.Registration" %>
<%@ Register src="../controls/ctrl_registeration.ascx" tagname="ctrl_registeration" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ctrl_registeration ID="ctrl_registeration1" runat="server" />
</asp:Content>
