<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kupnja.aspx.cs" Inherits="Vjezbe03.Kupnja" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 171px;
            width: 296px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblPozdrav" runat="server"></asp:Label>
        <br />
        <br />
        Artikl:
        <asp:TextBox ID="txtArtikl" runat="server" Width="220px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDodajArtikl" runat="server" OnClick="btnDodajArtikl_Click" Text="Dodaj u kosaricu" Width="126px" />
        <br />
        Sadrzaj kosarice:<br />
&nbsp;<asp:ListBox ID="lbKosarica" runat="server" Height="176px" Width="267px"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="btnZavrsiKupnju" runat="server" OnClick="btnZavrsiKupnju_Click" Text="Zavrsi kupnju &gt;" Width="97px" />
        <br />
        <br />
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
