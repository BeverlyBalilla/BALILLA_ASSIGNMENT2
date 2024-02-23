<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - BeverlyBalilla_Assignment2</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Beverly", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                    <li>@Html.ActionLink("About", "About", "Home")</li>
                    <li>@Html.ActionLink("Photos", "Photos", "Home")</li>
                </ul>
            </div>
        </div>
    </div>
    <div class="container body-content">
        S
        @RenderBody()
        <hr />
    </div>

    <footer style="background-color: black; text-align: center;">
        <ul class="social-links" style="display: flex; justify-content: center; margin: 10px;">
            <li style="margin-right: 10px;">
                <a href="https://www.facebook.com/your_facebook_page"><img src="~/Content/Images/facebook.png"></a>
            </li>
            <li style="margin-right: 10px;">
                <a href="https://www.instagram.com/your_instagram_profile"><img src="~/Content/Images/instagram.jpg"></a>
            </li>
            <li style="margin-right: 10px;">
                <a href="mailto:your_email@example.com"><img src="~/Content/Images/gmail1.jpg"></a>
            </li>
        </ul>
        <p style="color: white; text-align: center;"> &copy; @DateTime.Now.Year - BEVERLY BALILLA</p>
    </footer>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
