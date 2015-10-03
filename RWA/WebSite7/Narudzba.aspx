<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Narudzba.aspx.cs" Inherits="Narudzba" %>

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
                <td colspan="3">
                    <asp:Label ID="lblPodaci" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Artikl"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtArtikl" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnDodaj" runat="server" Text="Dodaj" OnClick="btnDodaj_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Sadrzaj kosarice"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="lbKosarica" runat="server" Rows="10" Width="200px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnZavrsi" runat="server" Text="Zavrsi kupnju >" OnClick="btnZavrsi_Click" />
                    <br />
                    <asp:Label ID="lblInfo" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
