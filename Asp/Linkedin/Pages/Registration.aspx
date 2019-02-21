<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Linkedin.Pages.Registration" %>

<%@ Register src="../Controllers/ctr_Login.ascx" tagname="ctr_Login" tagprefix="uc1" %>
<%@ Register src="../Controllers/ctrl_registeration.ascx" tagname="ctrl_registeration" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc2:ctrl_registeration ID="ctrl_registeration1" runat="server" />
        </div>
    </form>
</body>
</html>
