<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Salje.aspx.cs" Inherits="Send_Recieve_Salje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function postProvjera() {
            var ime = document.getElementById("postIme").value;
            var prezime = document.getElementById("postPrezime").value;
            
            if (ime == "" || prezime == "") {
                alert("Niste upisali sve vrijednosti!");
                return false;
            }
            else {
                return confirm("Poslati podatke POST metodom?");
            }
        }
    </script>
</head>
<body>
    <form id="getForma" method="get" action="Prima.aspx">
        <div>
            <table>
                <tr>
                    <td>Ime: </td>
                    <td>
                        <input type="text" id="getIme" name="getIme" /></td>
                </tr>
                <tr>
                    <td>Prezime: </td>
                    <td>
                        <input type="text" id="getPrezime" name="getPrezime" /></td>
                </tr>
                <tr>
                    <td>Grad: </td>
                    <td>
                        <select name="grad">
                            <option>Zagreb</option>
                            <option>Rijeka</option>
                            <option>Split</option>
                            <option>Osijek</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <input type="submit" value="Posalji podatke GET metodom" onclick="return confirm('Poslati podatke GET metodom?');" /></td>
                </tr>
            </table>
        </div>
    </form>

    <form id="postForma" method="post" action="Prima.aspx">
        <div>
            <table>
                <tr>
                    <td>Ime: </td>
                    <td>
                        <input type="text" id="postIme" name="postIme" /></td>
                </tr>
                <tr>
                    <td>Prezime: </td>
                    <td>
                        <input type="text" id="postPrezime" name="postPrezime" /></td>
                </tr>
                <tr>
                    <td>Grad: </td>
                    <td>
                        <select name="grad">
                            <option>Zagreb</option>
                            <option>Rijeka</option>
                            <option>Split</option>
                            <option>Osijek</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <input type="submit" value="Posalji podatke POST metodom" onclick="return postProvjera()" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
