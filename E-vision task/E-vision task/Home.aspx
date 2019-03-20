<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="E_vision_task.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="StyleSheet1.css" type="text/css" rel="stylesheet" />
      <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
       <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
      <div class="cd-main-content">
    <nav class="navbar navbar-default navbar-fixed-top">
    <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#mynavbar">
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>                        
      </button>
<a class="navbar-brand" href="#mypage">Product items</a>
        </div>
        <div class="collapse navbar-collapse" id="mynavbar">
            <ul class="nav navbar-nav navbar-right">
                <li><a href="Home.aspx">Home</a></li>
                <li><a href="viewer.aspx">View items</a></li>
                <li><a href="WebForm1.aspx">Edit items</a></li>
            </ul>
        </div>
    </div>
        </nav>
        </div>
    <form runat="server">
    <div class="div2">
        <asp:Button ID="Button3" runat="server" Text="View Products Items" class="btns" onclick="view"/>
        <asp:Button ID="Button4" runat="server" Text="  Edit Product Items" class="btns" OnClick="editt"/>
    </div>
        </form>
     <script>
         $(document).ready(function () {
             $(window).scroll(function () {
                 $(".div2").each(function () {
                     var pos = $(this).offset().top;

                     var winTop = $(window).scrollTop();
                     if (pos < winTop + 600) {
                         $(this).addClass("slide");
                     }
                 });
             });
         });
      </script>
</body>
</html>
