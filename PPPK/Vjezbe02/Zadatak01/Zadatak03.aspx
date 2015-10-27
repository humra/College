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
                <td colspan="2">Drzava:</td>
                <td>Gradovi drzave:</td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="ddlDrzave" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDrzave_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>Grad:</td>
                <td rowspan="3">
                    <asp:ListBox ID="lbGradovi" runat="server" OnSelectedIndexChanged="lbGradovi_SelectedIndexChanged" Width="159px" AutoPostBack="True"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td style="margin-left: 40px">
                    <asp:TextBox ID="txtDrzava" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="txtGrad" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnUrediDrzava" runat="server" Text="UREDI" OnClick="btnUrediDrzava_Click" />
                    <asp:Button ID="btnObrisiDrzava" runat="server" Text="OBRISI" OnClick="btnObrisiDrzava_Click" />
                </td>
                <td>
                    <asp:Button ID="btnDodajGrad" runat="server" Text="DODAJ" OnClick="btnDodajGrad_Click" />
                    <asp:Button ID="btnObrisiGrad" runat="server" Text="OBRISI" OnClick="btnObrisiGrad_Click" />
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
