<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatabaseFirst.aspx.cs" Inherits="Ishod08.DatabaseFirst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ddlDrzava" runat="server" Width="186px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lbGradovi" runat="server" Height="136px" Width="190px"></asp:ListBox>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server">
        </asp:EntityDataSource>
    
    </div>
    </form>
</body>
</html>
