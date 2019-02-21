<%@ Page Title="" Language="C#" MasterPageFile="Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LinkedIn.Home" %>
<%@ Register src="Controllers/CreatePost.ascx" tagname="CreatePost" tagprefix="uc1" %>
<%@ Register src="Controllers/PostBox.ascx" tagname="PostBox" tagprefix="uc2" %>
<%@ Register src="Controllers/ProfileCard.ascx" tagname="ProfileCard" tagprefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
  
  
   
   <uc1:CreatePost ID="CreatePost1" runat="server" />
    <uc2:PostBox ID="PostBox1" runat="server" />
    <uc3:ProfileCard ID="ProfileCard1" runat="server" />
    
    
   
  
  
   
   
</asp:Content>

