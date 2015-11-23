<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="lbPrvihDeset" runat="server"></asp:ListBox>
        <br />
        <br />
        Upisite ID osobe:
        <asp:TextBox ID="txtIdOsobe" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnPrikaziDetalje" runat="server" OnClick="btnPrikaziDetalje_Click" Text="PRIKAZI DETALJE" />
        <br />
        <br />
        <asp:Label ID="lblDetalji" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblInfo" runat="server" ForeColor="Red"></asp:Label>
    
    </div>
    </form>
</body>
</html>
