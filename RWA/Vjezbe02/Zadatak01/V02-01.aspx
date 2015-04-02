<%@ Page Language="C#" AutoEventWireup="true" CodeFile="V02-01.aspx.cs" Inherits="Zadatak01_V02_01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>RWA - vježbe 02, zadatak 01</h1>
            <table>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="Label1" Text="Ime"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                    </td>
                    <td rowspan="6">
                        <asp:Panel ID="Panel2" runat="server">
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
                        <asp:Label ID="Label5" runat="server" Text="Vozačka dozvola"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox ID="cbVozacka" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="btnIspisi" runat="server" OnClick="btnIspisi_Click" Text="Ispiši podatke" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
