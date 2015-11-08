<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Zadatak01.aspx.cs" Inherits="Zadatak01" %>

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
                <td>Drzave:</td>
                <td>Gradovi:</td>
                <td>Grad:</td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="ddlDrzave" runat="server" AutoPostBack="True" Height="21px" Width="134px" OnSelectedIndexChanged="ddlDrzave_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:ListBox ID="lbGradovi" runat="server" Height="103px" Width="174px" AutoPostBack="True" OnSelectedIndexChanged="lbGradovi_SelectedIndexChanged" SelectionMode="Multiple"></asp:ListBox>
                </td>
                <td>
                    <asp:TextBox ID="txtGrad" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnBrisiDrzavu" runat="server" Text="Obrisi drzavu" Width="102px" Visible="False" OnClick="btnBrisiDrzavu_Click" />
                </td>
                <td>
                    <asp:Button ID="btnBrisiGrad" runat="server" Text="Obrisi grad" Width="102px" Visible="False" OnClick="btnBrisiGrad_Click" />
                </td>
                <td>
                    <asp:Button ID="btnDodajGrad" runat="server" Text="Dodaj grad" Visible="False" Width="86px" OnClick="btnDodajGrad_Click" />
                    <asp:Button ID="btnUrediGrad" runat="server" Text="Uredi grad" Visible="False" Width="86px" OnClick="btnUrediGrad_Click" />
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="lblInfo" runat="server" ForeColor="Red"></asp:Label>
    </div>
    </form>
</body>
</html>
