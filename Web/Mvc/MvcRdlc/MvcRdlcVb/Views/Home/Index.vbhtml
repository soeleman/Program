@Code
    Layout = Nothing
End Code
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css">
</head>
<body>
    <div class="container">
        <div>
            <h4>RDLC on MVC on VB too</h4>
        </div>
        <div>
            @Html.Partial("~/Pages/RdlcViewer.ascx")
        </div>
    </div>
</body>
</html>