<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Zadatak02.aspx.cs" Inherits="Zadatak02" %>

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
                    <asp:Label ID="Label1" runat="server" Text="Drzava"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlDrzava" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDrzava_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Grad"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlGrad" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
