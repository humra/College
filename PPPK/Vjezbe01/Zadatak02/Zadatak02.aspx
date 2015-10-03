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
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="AdventureWorksOBP" /> </br>
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="PPPKDatabase" /> </br>
                    <asp:CheckBox ID="CheckBox3" runat="server" Text="RWADatabase" /> </br>
                </td>
                <td>
                    <asp:ListBox ID="lbStatus" runat="server"></asp:ListBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnConnect" runat="server" OnClick="btnConnect_Click" Text="START" />
    </div>
    </form>
</body>
</html>
