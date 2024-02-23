@Code
    ViewData("Title") = "Home Page"
End Code

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Beverly</title>
    <style>
        body {
            background-color: #AA336A;
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
            max-width: 80%;
            height: auto;
        }

        .footer {
            background-color: #000000;
            color: white;
            height: 50px;
            margin: 0;
            position: center;
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
            <h1>COME EXPLORE TOGETHER TO KNOW ABOUT ME.</h1>

            <p>I HPE you ENJOY!</p>

        </div>
        <div>
            <img src="~/Content/Images/ME.jpg">
        </div>
    </section>



</body>
</html>
