<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Zadatak03.aspx.cs" Inherits="Vjezbe02.Zadatak03" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Ime
        <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
        <br />
        <br />
        Prezime
        <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnIspis" runat="server" OnClick="btnIspis_Click" Text="ISPIS" Width="128px" />
        <br />
        <br />
        <asp:Label ID="lblIspis" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
