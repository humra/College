<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtrlDefineButton.ascx.cs" Inherits="Vjezbe04.CtrlDefineButton" %>

<table>
    <tr>
        <td>
            <asp:Label ID="lblTekst" runat="server"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtTekst" runat="server"></asp:TextBox>
        </td>
        <td><iframe id="frame" runat="server" style="height: 122px; width: 402px" ></iframe></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblURL" runat="server"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtURL" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td></td>
        <td>
            <asp:LinkButton ID="btnSpremi" runat="server" OnClick="btnSpremi_Click">Spremi</asp:LinkButton>
        </td>
    </tr>
</table>