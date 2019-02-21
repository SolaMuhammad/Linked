<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PostBox.ascx.cs" Inherits="LinkedIn.Controllers.PostBox" %>

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
    <div class="body-container">
        <div class="post">
            <div class="post-main">
                <div class="post-main-head">
                    <img class="user-photo" src="images/Logo.png">
                    <div class="user-data">
                        <a class="user-name" href="">Mostafa Hamed</a>
                        <div class="user-title">SW Developer</div>
                    </div>
                </div>
                <div class="post-main-content">Hello World Hello WorldHello WorldHello </div>
                <div class="social-counts">
                    <span class="num-likes">50 Likes</span>
                    <span class="num-comments">50 Comments</span>
                </div>
                <div class="feedback-buttons">
                    <div class="like-button"><i class="far fa-thumbs-up like-button__ilike"></i>Like</div>
                    <div class="comment-button">
                        <i class="far fa-comment-alt comment-button__icomment"></i>Comment
                    </div>
                    <div class="share-button"><i class="fas fa-share share-button__ishare"></i>Share</div>
                </div>
            </div>
            <div class="post-reactions">
                <div class="add-Comment">
                    <img class="user-comment-photo" src="">
                    <div class="comment-box" width="100px" aria-placeholder="Add a comment...."></div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>