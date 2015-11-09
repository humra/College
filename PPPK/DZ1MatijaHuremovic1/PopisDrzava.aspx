<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PopisDrzava.aspx.cs" Inherits="PopisDrzava" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 121px;
        }
        .auto-style2 {
            width: 144px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td class="auto-style2">
                    <asp:ListBox ID="lbDrzave" runat="server" SelectionMode="Multiple" Width="267px" Height="154px"></asp:ListBox>
                </td>
                <td>
                    <asp:Button ID="btnBrisi" runat="server" Text="Brisi" Width="174px" Height="57px" OnClick="btnBrisi_Click" />
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/UpisDrzava.aspx">Upis drzava</asp:HyperLink>
    </div>
    </form>
</body>
</html>
