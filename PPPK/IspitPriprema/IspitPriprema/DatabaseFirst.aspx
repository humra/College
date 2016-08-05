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
    
    </div>
    </form>
</body>
</html>
