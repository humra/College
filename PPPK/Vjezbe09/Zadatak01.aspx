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
                <td>Odaberi marku:</td>
                <td>
                    <asp:DropDownList ID="ddlMarke" runat="server" AutoPostBack="True" Height="23px" OnSelectedIndexChanged="ddlMarke_SelectedIndexChanged" Width="155px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Marka:</td>
                <td>
                    <asp:TextBox ID="txtMarka" runat="server" Width="143px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Proizvođač:</td>
                <td>
                    <asp:TextBox ID="txtProizvodjac" runat="server" Width="141px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Godina:</td>
                <td>
                    <asp:TextBox ID="txtGodina" runat="server" Width="142px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Konjskih snaga:</td>
                <td>
                    <asp:TextBox ID="txtKS" runat="server" Width="141px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Upisano automobila</td>
                <td>
                    <asp:Label ID="lblUpisano" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="INSERT" />
                    <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="UPDATE" />
                    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="DELETE" />
                </td>
                <td></td>
            </tr>
        </table>
        <br />
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
