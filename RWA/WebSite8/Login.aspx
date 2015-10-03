<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

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
                <td></td>
                <td>
                    <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Registracija korisnika"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblKorisnicko" runat="server" Text="Korisnicko ime: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPassword" runat="server" Text="Lozinka"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnUlaz" runat="server" OnClick="btnUlaz_Click" Text="Ulaz" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Label ID="lblInfo" runat="server" ForeColor="Red" Text="&quot;&quot;"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
