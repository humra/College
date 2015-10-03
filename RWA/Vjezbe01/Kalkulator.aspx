<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Kalkulator.aspx.cs" Inherits="Kalkulator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="calcForma" name="calcForma" action="Rezultat.aspx" method="get">
    <table>
        <tr>
            <td>Broj A:</td>
            <td>
                <input type="text" name="brojA" id="brojA" />
            </td>
        </tr>
        <tr>
            <td>Broj B:</td>
            <td>
                <input type="text" name="brojB" id="brojB" />
            </td>
        </tr>
        <tr>
            <td>Racunska operacija: </td>
            <td>
                <select name="operacija">
                    <option value="+">+</option>
                    <option value="-">-</option>
                    <option value="/">/</option>
                    <option value="*">*</option>
                </select>
            </td>
        </tr>
        <tr>
            <td />
            <td>
                <input type="submit" value="Izracunaj" id="btnSubmit" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
