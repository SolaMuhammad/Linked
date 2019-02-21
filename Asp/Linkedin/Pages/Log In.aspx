<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log In.aspx.cs" Inherits="Linkedin.Pages.Log_In" %>

<%@ Register src="../Controllers/ctr_Login.ascx" tagname="ctr_Login" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:ctr_Login ID="ctr_Login1" runat="server" />
        </div>
    </form>
</body>
</html>
