<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ddlDrzave" runat="server" AutoPostBack="True" Height="18px" OnSelectedIndexChanged="ddlDrzave_SelectedIndexChanged" Width="176px">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:ListBox ID="lbGradovi" runat="server" Height="119px" Width="181px"></asp:ListBox>
        <br />
        <br />
        <asp:Label ID="lblInfo" runat="server" ForeColor="Red"></asp:Label>
    
    </div>
    </form>
</body>
</html>
