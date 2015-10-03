<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Obrazac.ascx.cs" Inherits="Obrazac" %>

<table>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Korisnicko ime: "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" Display="Dynamic" ErrorMessage="Niste unjeli korisnicko ime" ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Lozinka: "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="Niste unjeli lozinku" ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Ponoviti lozinku: "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPotvrda" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPotvrda" Display="Dynamic" ErrorMessage="Morate ponovno unjeti lozinku" ForeColor="Red">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td></td>
        <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:PlaceHolder ID="phObavijest" runat="server"></asp:PlaceHolder>
        </td>
        <td>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </td>
    </tr>
</table>