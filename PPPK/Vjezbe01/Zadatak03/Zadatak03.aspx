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
                <td>Baza:  </td>
                <td>
                    <asp:TextBox ID="tbDBName" runat="server" Width="128px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnOpen" runat="server" OnClick="btnOpen_Click" Text="OTVORI" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:ListBox ID="lbLog" runat="server"></asp:ListBox>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
