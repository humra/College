<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Zadatak01.aspx.cs" Inherits="Zadatak01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>RWA - vjezbe 2 - zadatak 1</h1>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Ime"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                </td>
                <td rowspan="6">
                    <asp:Panel ID="panelShow" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Prezime"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Grad"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlGrad" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Spol"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="rbSpol" runat="server">
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Vozacka dozvola"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="chkVozacka" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    
                </td>
                <td>
                    <asp:Button ID="btnIspisi" runat="server" Text="Ispisi podatke" OnClick="btnIspisi_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
