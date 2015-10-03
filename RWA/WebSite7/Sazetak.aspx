<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sazetak.aspx.cs" Inherits="Sazetak" %>

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
                    <asp:Label ID="lblImePrezime" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:BulletedList ID="blArtikli" runat="server">
                    </asp:BulletedList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblAdresa" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMail" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
