<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>RWA - vježbe 2 - zadatak 2</title>
    <style type="text/css">
        .style1
        {
            width: 300px;
        }
        body
        {
            font-family:Arial;
            font-size:14px;
        }
        .style2
        {
            width: 60px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="5" cellspacing="0" class="style1">
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="Label1" runat="server" Text="Država:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlDrzave" runat="server" AutoPostBack="True" 
                         Width="120px" onselectedindexchanged="ddlDrzave_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="Label2" runat="server" Text="Grad:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlGradovi" runat="server" Width="120px">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
