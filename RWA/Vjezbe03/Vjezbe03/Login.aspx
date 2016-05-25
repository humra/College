<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Vjezbe03.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Ime i prezime:
        <asp:TextBox ID="txtImePrezime" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtImePrezime" ErrorMessage="*"></asp:RequiredFieldValidator>
        <br />
        Adresa:
        <asp:TextBox ID="txtAdresa" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAdresa" ErrorMessage="*"></asp:RequiredFieldValidator>
        <br />
        E-mail:
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" ErrorMessage="*"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Button ID="btnUlaz" runat="server" OnClick="btnUlaz_Click" Text="Ulaz &gt;" Width="109px" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <br />
    
    </div>
    </form>
</body>
</html>
