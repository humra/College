<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPero.aspx.cs" Inherits="Vjezbe03.LoginPero" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Registracija korisnika<br />
        <br />
        Korisnicko ime:
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br />
        Lozinka:
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="btnUlaz" runat="server" OnClick="btnUlaz_Click" Text="Ulaz &gt;" Width="82px" />
        <br />
        <br />
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
