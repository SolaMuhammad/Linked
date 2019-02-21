<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Experience.ascx.cs" Inherits="LinkedIn.Controllers.Experience" %>
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
         <div class="experience">
        <div class="profile-section">experience</div>

        <div class="experience-data">
            <div id="btn-add-experience" > <a class="btn-add-experience" runat="server" onserverclick="Experience_Click"><i class="fas fa-plus" ></i></a></div>
            <div id="btn-edit-experience"><i class="fas fa-pen" runat="server"></i></div>
            <div class="company-img-container">
                <img src="images/Logo.png">
            </div>
            <div class="experience-details">
                <div class="title" runat="server"> Full Stack Workshop</div>
                <div id ="ComName" class="company-name" runat="server" ondatabinding="Page_Load">National Bank of Egypt (NBE)</div>
                <div class="date">
                    <span class="date-from">2012</span>
                    <span> - </span>
                    <span class="date-to">2014</span>
                </div>
            </div>
        </div>
        <hr>
    </div>
  </body>
</html>