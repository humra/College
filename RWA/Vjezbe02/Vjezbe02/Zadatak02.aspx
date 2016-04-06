<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Zadatak02.aspx.cs" Inherits="Vjezbe02.Zadatak02" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ddlDrzava" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDrzava_SelectedIndexChanged" Width="134px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="ddlGradovi" runat="server" Width="134px">
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
