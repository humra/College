<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Zadatak04.aspx.cs" Inherits="Zadatak04" %>

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
                    <asp:Label ID="Label1" runat="server" Text="Ime: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtIme" Display="Dynamic" ErrorMessage="Niste upisali ime" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Prezime: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtPrezime" Display="Dynamic" 
                        ErrorMessage="Niste upisali prezime" ForeColor="Red">*
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Godine: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtGodine" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtGodine" Display="Dynamic" ErrorMessage="Niste upisali godine" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtGodine" Display="Dynamic" ErrorMessage="Godine moraju biti 0-150" ForeColor="Red" MaximumValue="150" MinimumValue="0" Type="Integer">*</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Email: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtMail" Display="Dynamic" ErrorMessage="Niste upisali mail" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txtMail" Display="Dynamic" 
                        ErrorMessage="Krivi format mail adrese" ForeColor="Red" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Korisnicko ime: (parni broj)"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtKorisnicko" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtKorisnicko" Display="Dynamic" ErrorMessage="Niste upisali korisnicko ime" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtKorisnicko" ErrorMessage="Korisnicko ime mora biti paran broj" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate">*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Lozinka: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtLozinka" Display="Dynamic" ErrorMessage="Niste upisali lozinku" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Ponoviti lozinku: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPotvrda" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtPotvrda" Display="Dynamic" ErrorMessage="Niste upisali potvrdu lozinke" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtLozinka" ControlToValidate="txtPotvrda" Display="Dynamic" ErrorMessage="Lozinke moraju biti iste" ForeColor="Red">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Posalji" Width="127px" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
