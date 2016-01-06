<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Zadatak01.aspx.cs" Inherits="Zadatak01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnSpremiXML" runat="server" Height="61px" OnClick="btnSpremiXML_Click" Text="SpremiXML" Width="154px" />
        <br />
        <br />
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnUcitaj" runat="server" Height="58px" OnClick="btnUcitaj_Click" Text="UcitajXML" Width="149px" />
        <br />
        <br />
        <asp:Label ID="lblPodaci" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
