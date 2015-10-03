<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Salje.aspx.cs" Inherits="Salje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function PostPitanje() {
            var txtIme = document.getElementById("imePost");
            var txtPrezime = document.getElementById("prezimePost");

            if (txtIme.value == "" || txtPrezime.value == "") {
                alert("Niste upisali ime i prezime u POST formi!");
                txtIme.focus();
                return false;
            }
            else {
                return confirm("Poslati podatke POST formom?");
            }
        }
    </script>
</head>
<body>
    <form id="getForma" action="Prima.aspx" method="get">
        <table>
            <tr>
                <td>
                    Ime:
                </td>
                <td>
                    <input type="text" name="imeGet" />
                </td>
            </tr>
            <tr>
                <td>
                    Prezime:
                </td>
                <td>
                    <input type="text" name="prezimeGet" />
                </td>
            </tr>
            <tr>
                <td>Grad:</td>
                <td>
                    <select name="gradGet">
                        <option value="Zagreb">Zagreb</option>
                        <option value="Rijeka">Rijeka</option>
                        <option value="Osijek">Osijek</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <input type="submit" id="btnSubmitGet" value="Posalji podatke GET metodom"
                        onclick="return confirm('Poslati podatke GET metodom?')"/>
                </td>
            </tr>
        </table>
    </form>

    <form id="postForma" action="Prima.aspx" method="post">
        <table>
            <tr>
                <td>
                    Ime:
                </td>
                <td>
                    <input type="text" name="imePost" id="imePost"/>
                </td>
            </tr>
            <tr>
                <td>
                    Prezime:
                </td>
                <td>
                    <input type="text" name="prezimePost" id="prezimePost"/>
                </td>
            </tr>
            <tr>
                <td>Grad:</td>
                <td>
                    <select name="gradPost">
                        <option value="Zagreb">Zagreb</option>
                        <option value="Rijeka">Rijeka</option>
                        <option value="Osijek">Osijek</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <input type="submit" id="btnSubmitPost" value="Posalji podatke Post metodom"
                        onclick="return PostPitanje()"/>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
