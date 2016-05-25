<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="kontrola.ascx.cs" Inherits="Vjezbe04.kontrola" %>
<p>
    Korisnicko ime:&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="Korisnicko ime je obavezno"></asp:RequiredFieldValidator>
</p>
<p>
    Lozinka:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLozinka" ErrorMessage="Lozinka je obavezna"></asp:RequiredFieldValidator>
</p>
<p>
    Ponovi lozinku:&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtPonoviLozinku" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPonoviLozinku" ErrorMessage="Potvrda lozinke je obavezna"></asp:RequiredFieldValidator>
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtLozinka" ControlToValidate="txtPonoviLozinku" ErrorMessage="Lozinke moraju biti iste"></asp:CompareValidator>
</p>
<p>
    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="81px" />
</p>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" />
<asp:Label ID="lblInfo" runat="server" Visible="False"></asp:Label>
<p>
</p>
<p>
    &nbsp;</p>

