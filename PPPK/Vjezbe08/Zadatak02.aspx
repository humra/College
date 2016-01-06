<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Zadatak02.aspx.cs" Inherits="Zadatak02" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ddlDrzava" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDrzava_SelectedIndexChanged" Width="130px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="ddlSortiranje" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlSortiranje_SelectedIndexChanged" Width="128px">
        </asp:DropDownList>
        <asp:BulletedList ID="blGradovi" runat="server">
        </asp:BulletedList>
    
    </div>
    </form>
</body>
</html>
