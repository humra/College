<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Zadatak03.aspx.cs" Inherits="Zadatak03_Zadatak03" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>Ime: </td>
                <td>
                    <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Prezime: </td>
                <td>
                    <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Ispis" Width="128px" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
        <br />
    </div>
        <asp:Label ID="lblIme" runat="server"></asp:Label>
    </form>
</body>
</html>
