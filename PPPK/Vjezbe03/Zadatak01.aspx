<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Zadatak01.aspx.cs" Inherits="Zadatak01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:DropDownList ID="ddlDrzave" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDrzave_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:BulletedList ID="blGradoviDrzave" runat="server">
                    </asp:BulletedList>
                </td>
            </tr>
            <tr>
                <td>Drzava:</td>
                <td>
                    <asp:TextBox ID="txtDrzava" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:BulletedList ID="blGradoviZaDodati" runat="server">
                    </asp:BulletedList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Grad:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtGrad" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnDodajGrad" runat="server" Text="DODAJ GRAD" Width="125px" OnClick="btnDodajGrad_Click" />
                </td>
                <td>
                    <asp:Button ID="btnSpremiUBazu" runat="server" Text="SPREMI U DB" Width="125px" OnClick="btnSpremiUBazu_Click" />
                </td>
            </tr>
        </table>
    </div>
        <asp:Label ID="lblInfo" runat="server" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
