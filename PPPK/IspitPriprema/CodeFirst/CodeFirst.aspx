<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CodeFirst.aspx.cs" Inherits="CodeFirst.CodeFirst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ddlDrzava" runat="server" AutoPostBack="True" Height="28px" OnSelectedIndexChanged="ddlDrzava_SelectedIndexChanged" Width="201px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:ListBox ID="lbGrad" runat="server" Height="223px" Width="247px"></asp:ListBox>
    
    </div>
    </form>
</body>
</html>
