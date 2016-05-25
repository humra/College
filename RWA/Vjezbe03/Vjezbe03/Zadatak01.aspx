<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Zadatak01.aspx.cs" Inherits="Vjezbe03.Zadatak01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Koliko boja:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtKolikoBoja" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnPrikazi" runat="server" OnClick="btnPrikazi_Click" Text="Prikazi" Width="81px" />
        <br />
        <br />
        <asp:PlaceHolder ID="ph" runat="server"></asp:PlaceHolder>
        <br />
        <br />
        <asp:BulletedList ID="blBoje" runat="server">
        </asp:BulletedList>
    
    </div>
    </form>
</body>
</html>
