<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="LinkedIn.Controllers.Menu" %>
 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Home</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" type="text/css" media="screen" href="../css/stylesheet.css" />
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.0/css/all.css"
        integrity="sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ" crossorigin="anonymous"/>
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,500,700" rel="stylesheet" />
</head>

<body>
    <div class="header">
            <div class="header-left-side">
                <div class="logo"><img alt="" class="icon" src="../images/Logo.png"/> </div>
                <input class="Search-box" type="text" placeholder="Search"/>
            </div>
            <div class="header-right-side">

                <ul class="Menu-list">
                    <li class="menu-item"><a class="item-Container" runat="server" onserverclick="home_Click"> <i class="fas fa-home"></i><span
                                class="item-text">Home</span></a></li>
                    <li class="menu-item"><a class="item-Container" runat="server" onserverclick="Network_Click"><i class="fas fa-users"></i><span class="item-text">my
                                Network</span></a></li>
                    <li class="menu-item"><a class="item-Container" runat="server" onserverclick="jobs_Click"><i class="fas fa-briefcase"></i><span
                                class="item-text">jobs</span></a></li>
                    <li class="menu-item"><a class="item-Container" runat="server" onserverclick="notification_Click"><i class="far fa-bell"></i><span
                                class="item-text">notification</span></a></li>
                    <li class="menu-item"><a class="item-Container" runat="server" onserverclick="profile_Click"><i class="fas fa-user-alt"></i><span
                                class="item-text">me</span></a></li>
                </ul>
            </div>
        </div>
    </body>
</html>