@Code
    ViewData("Title") = "Photos"
End Code

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>BEVERLY</title>
    <style>
        body {
            background-color: darkred;
            min-height: 90vh;
        }

        section {
            display: flex;
            margin: 20px auto;
            max-width: 800px;
            background-color: white;
            padding: 20px;
            border-radius: 10px;
        }

        img {
            max-width: 30%;
            height: auto;
            margin: 5px;
        }

        .footer {
            background-color: #000000;
            color: white;
            height: 50px;
            margin: 0;
            position: absolute;
            bottom: 0;
            width: 100%;
            text-align: center;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .social-links {
            display: flex;
            justify-content: space-between;
        }

            .social-links img {
                max-width: 30px;
                height: 20px;
            }
    </style>
</head>
<body>

    <section id="home">
        <div>
            <br>
            <br />
            <br>
            <br />
            <br>
            <br />
            <br>
            <br />
            <br>
            <br />
            <br>
            <br />
            <h3 style="text-align: center;">PICTURE COLLECTION</h3>
        </div>

        <div class="image-grid">
            <img src="~/Content/Images/1.jpg">
            <img src="~/Content/Images/2.jpg">
            <img src="~/Content/Images/3.jpg">
            <img src="~/Content/Images/4.jpg">
            <img src="~/Content/Images/5.jpg">
            <img src="~/Content/Images/6.jpg">
            <img src="~/Content/Images/7.jpg">
            <img src="~/Content/Images/8.jpg">
            <img src="~/Content/Images/9.jpg">
            <img src="~/Content/Images/10.jpg">
            <img src="~/Content/Images/11.jpg">
            <img src="~/Content/Images/12.jpg">

        </div>
    </section>



</body>
</html>
