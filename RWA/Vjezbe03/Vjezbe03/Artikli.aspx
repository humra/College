<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Artikli.aspx.cs" Inherits="Vjezbe03.Artikli" %>

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
                <td>Ponuda</td>
                <td></td>
                <td>Odabrano</td>
            </tr>
            <tr>
                <td>
                    <asp:ListBox ID="lbPonuda" runat="server" Height="176px" Width="170px"></asp:ListBox>
                </td>
                <td>
                    <asp:Button ID="btnOdaberi" runat="server" OnClick="btnOdaberi_Click" Text="&gt;" Width="98px" />
                    <br />
                    <asp:Button ID="btnMakni" runat="server" OnClick="btnMakni_Click" Text="&lt;" Width="98px" />
                </td>
                <td>
                    <asp:ListBox ID="lbOdabrano" runat="server" Height="176px" Width="170px"></asp:ListBox>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
