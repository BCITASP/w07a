<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CorsStudentClient.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h3>Cors Request</h3>
    <button id="btnGetStudents">Get Students</button>
    <pre id="preOutput"></pre>

    <script src="Scripts/jquery-2.1.3.js"></script>
    <script>
        $(function () {
            var getStudents = function () {
                var url = "http://w09a.ergostratus.com/api/Student/";
                $.get(url).always(showResponse);
                return false;
            };
            var showResponse = function (object) {
                $("#preOutput").text(JSON.stringify(object, null, 4));
            };
            $("#btnGetStudents").click(getStudents);
        });
    </script>

</body>
</html>
