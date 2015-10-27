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
                <td>
                    <asp:DropDownList ID="ddlDrzave" runat="server" OnSelectedIndexChanged="ddlDrzave_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:BulletedList ID="blGradovi" runat="server">
                    </asp:BulletedList>
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="lblInfo" runat="server" ForeColor="Red"></asp:Label>
    </div>
    </form>
</body>
</html>
