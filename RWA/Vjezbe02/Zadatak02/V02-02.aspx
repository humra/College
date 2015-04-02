<%@ Page Language="C#" AutoEventWireup="true" CodeFile="V02-02.aspx.cs" Inherits="Zadatak02_V02_02" %>

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
                <td>Država: </td>
                <td>
                    <asp:DropDownList ID="ddlListDrzave" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlListDrzave_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Grad: </td>
                <td>
                    <asp:DropDownList ID="ddlListGradovi" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
