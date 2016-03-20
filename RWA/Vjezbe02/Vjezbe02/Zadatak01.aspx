<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Zadatak01.aspx.cs" Inherits="Vjezbe02.Zadatak01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    
    <h1>RWA - vjezbe 2 - zadatak 1</h1>

    <table>
        <tr>
            <td>Ime: </td>
            <td>
                <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Prezime</td>
            <td>
                <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Grad:</td>
            <td>
                <asp:DropDownList ID="ddlGrad" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Spol:</td>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>Vozacka dozvola:</td>
            <td>
                <asp:CheckBox ID="cbVozacka" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnIspisi" runat="server" OnClick="btnIspisi_Click" Text="ISPIS" Width="107px" />
            </td>
        </tr>
    </table>
    <br />
        <asp:Panel ID="panelInfo" runat="server">
        </asp:Panel>
    </form>
</body>
</html>
