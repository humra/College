<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Kupovina.aspx.cs" Inherits="Kupovina" %>

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
                    <asp:ListBox ID="lbPonuda" runat="server" SelectionMode="Multiple" Width="100px"></asp:ListBox>
                </td>
                <td>
                    <asp:Button ID="btnDesno" runat="server" OnClick="btnDesno_Click" Text="&gt;" Width="60px" />
                    <br />
                    <asp:Button ID="btnLijevo" runat="server" OnClick="btnLijevo_Click" Text="&lt;" Width="60px" />
                </td>
                <td>
                    <asp:ListBox ID="lbKosarica" runat="server" SelectionMode="Multiple" Width="100px"></asp:ListBox>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
