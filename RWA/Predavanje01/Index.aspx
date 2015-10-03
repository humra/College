<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Index stranica</title>
    <script type="text/javascript">
        window.onload = function () {
            document.getElementByID("form1").method = document.getElementById("selMetoda").value;

            document.getElementById("selMetoda").onchange = function () {
                document.getElementById("form1").method = this.value;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server" action="Obradi.aspx">
    <fieldset>
        <legend>Moja prva aplikacija</legend>


        <label for="txtA">Parametar A:</label>
        <br />
        <input type="text" id="txtA" name="txtA" value="" />
        <br />
        <label for="txtB">Parametar B:</label>
        <br />
        <input type="text" id="txtB" name="txtB" value="" />
        <br />

        <select id="selMetoda">
            <option value="get">GET</option>
            <option value="post">POST</option>
        </select>
        <br />

        <input type="submit" id="btnSubmit" value="Posalji parametre" />
    </fieldset>
    </form>
</body>
</html>
