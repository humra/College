<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sazetak.aspx.cs" Inherits="Vjezbe03.Sazetak" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblImePrezime" runat="server"></asp:Label>
        <br />
        <br />
        <asp:BulletedList ID="blProizvodi" runat="server">
        </asp:BulletedList>
        <br />
        <br />
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
