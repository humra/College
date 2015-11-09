<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpisDrzava.aspx.cs" Inherits="UpisDrzava" %>

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
                    <asp:TextBox ID="txtNaziv" runat="server" Height="35px" Width="157px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnDodaj" runat="server" Height="30px" OnClick="btnDodaj_Click" Text="Dodaj" Width="66px" />
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/PopisDrzava.aspx">Popis drzava</asp:HyperLink>
    </div>
    </form>
</body>
</html>
