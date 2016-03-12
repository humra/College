<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Salje.aspx.cs" Inherits="Vjezbe01.Salje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function postProvjera() {
            var txtIme = document.getElementById("postIme");
            var txtPrezime = document.getElementById("postPrezime");

            if (txtIme.value == "" || txtPrezime.value == "") {
                alert("Morate unjeti sve podatke za POST");
                return false;
            }
            else {
                return confirm("Poslati podatke POST metodom?");
            }
        }
    </script>
</head>
<body>
    <form id="formGet" action="Prima.aspx" method="get">
        <div>
            <table>
                <tr>
                    <td>Ime:</td>
                    <td>
                        <input type="text" name="ime" />
                    </td>
                </tr>
                <tr>
                    <td>Prezime:</td>
                    <td>
                        <input type="text" name="prezime" />
                    </td>
                </tr>
                <tr>
                    <td>Grad:</td>
                    <td><select name="Grad" >
                            <option>Zagreb</option>
                            <option>Rijeka</option>
                            <option>Split</option>
                        </select></td>
                </tr>
                <tr>
                    <td><input type="submit" value="GET" onclick="return confirm('Poslati podatke GET metodom?')"/></td>
                </tr>
            </table>
        </div>
    </form>

    <form id="postForma" action="Prima.aspx" method="post">
        <div>
            <table>
                <tr>
                    <td>Ime:</td>
                    <td>
                        <input type="text" name="postIme" id="postIme"/>
                    </td>
                </tr>
                <tr>
                    <td>Prezime:</td>
                    <td>
                        <input type="text" name="postPrezime" id="postPrezime"/>
                    </td>
                </tr>
                <tr>
                    <td>Grad:</td>
                    <td><select name="postGrad" >
                            <option>Zagreb</option>
                            <option>Rijeka</option>
                            <option>Split</option>
                        </select></td>
                </tr>
                <tr>
                    <td><input type="submit" value="POST" onclick="return postProvjera()"/></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
