<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Zadatak01.aspx.cs" Inherits="Zadatak01" UnobtrusiveValidationMode="None"%>

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
                    <asp:Label ID="Label1" runat="server" Text="Koliko boja: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBoje" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="txtBoje" Display="Dynamic" 
                        ErrorMessage="Morate unjeti broj" ForeColor="Red" 
                        Operator="DataTypeCheck">*</asp:CompareValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                        ControlToValidate="txtBoje" ErrorMessage="Maksimalno 10 boja!" 
                        ForeColor="Red" MaximumValue="10" Type="Integer" MinimumValue="0">*</asp:RangeValidator>
                </td>
                <td>
                    <asp:Button ID="btnPrikazi" runat="server" Text="Prikazi" OnClick="btnPrikaziPoljaZaUnosBoja_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:PlaceHolder ID="ph" runat="server"></asp:PlaceHolder>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:BulletedList ID="blLista" runat="server">
                    </asp:BulletedList>
                </td>
            </tr>
            </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </div>
    </form>
</body>
</html>
