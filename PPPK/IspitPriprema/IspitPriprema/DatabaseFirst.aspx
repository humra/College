<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatabaseFirst.aspx.cs" Inherits="IspitPriprema.DatabaseFirst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="dropdownGradovi" runat="server" Height="19px" Width="222px" AutoPostBack="True" OnSelectedIndexChanged="updateKupci">
        </asp:DropDownList>
    
        <br />
        <br />
        <asp:ListBox ID="lbKupci" runat="server" Height="208px" Width="220px"></asp:ListBox>
    
        <br />
        <br />
        <asp:TextBox ID="txtNoviGrad" runat="server" Width="212px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDodajGrad" runat="server" OnClick="btnDodajGrad_Click" Text="DODAJ GRAD" Width="113px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBrisiGrad" runat="server" OnClick="btnBrisiGrad_Click" Text="BRISI GRAD" Width="107px" />
    
    </div>
    </form>
</body>
</html>
