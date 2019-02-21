<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="LinkedIn.Profile" %>
<%@ Register src="Controllers/profileView.ascx" tagname="profileView" tagprefix="uc1" %>
<%@ Register src="Controllers/Experience.ascx" tagname="Experience" tagprefix="uc2" %>
<%@ Register src="Controllers/education.ascx" tagname="education" tagprefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <uc1:profileView ID="profileView1" runat="server" />
     <uc2:Experience ID="Experience1" runat="server" />
    <uc3:education ID="education1" runat="server" />
   
    
    
</asp:Content>
