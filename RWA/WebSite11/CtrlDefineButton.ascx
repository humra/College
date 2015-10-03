<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CtrlDefineButton.ascx.cs" Inherits="CtrlDefineButton" %>

<table>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Gumb 1 tekst: "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Gumb 1 URL: "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td></td>
        <td>
            <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
        </td>
    </tr>
</table>