<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ishod03.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="lbDrzava" runat="server" AutoPostBack="True" Height="146px" OnSelectedIndexChanged="lbDrzava_SelectedIndexChanged" Width="127px"></asp:ListBox>
&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lbGrad" runat="server" AutoPostBack="True" Height="138px" Width="125px"></asp:ListBox>
    
    </div>
    </form>
</body>
</html>
