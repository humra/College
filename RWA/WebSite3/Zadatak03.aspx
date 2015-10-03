<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Zadatak03.aspx.cs" Inherits="Zadatak03" %>

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
                <td>
                    <asp:Label ID="lblIme" runat="server" Text="Ime: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPrezime" runat="server" Text="Prezime: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnIspis" runat="server" Text="Ispis" OnClick="btnIspis_Click" Width="130px" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblPodaci" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
