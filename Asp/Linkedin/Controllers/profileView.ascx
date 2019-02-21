<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="profileView.ascx.cs" Inherits="LinkedIn.Controllers.profile_view" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Home</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" type="text/css" media="screen" href="../css/stylesheet.css" />
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.0/css/all.css"
        integrity="sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ" crossorigin="anonymous" />
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,500,700" rel="stylesheet" />
</head>
<body>
    <div class="profile-view">
        <div class="container-img-background">
            <img id="img-background" src="images/cover.jpg" />
        </div>

        <div class="container-img-profile">
            <img id="img-profile" src="images/me.jpg" />
        </div>

        <div class="profile-details">
            <div id="btn-edit-profile"><i class="fas fa-pen"></i></div>
            <div class="profile-details-left">
                <div id="profile-user-name">Amal Ahmed</div>
                <div id="profile-headline">full-stack developer</div>
            </div>
            <div class="profile-details-right">
                <div id="current-company-container">
                    <img id="company-img" src="images/Logo.png">
                    <span class="current-company-name">ITI</span>
                </div>
                <div id="see-connection"><i class="fas fa-users"></i><span class="connection-num">See connections</span></div>
            </div>
        </div>
    </div>
</body>
</html>