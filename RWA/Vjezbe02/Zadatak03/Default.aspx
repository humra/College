<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>RWA - vježbe 2 - zadatak 3</title>
    <style type="text/css">
        body
        {
            font-family:Arial;
            font-size:12px;
        }
        .style1
        {
            width: 500px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="5" cellspacing="0" class="style1">
            <tr>
                <td align="right">
                    <asp:Label ID="Label1" runat="server" Text="Ime:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtIme" runat="server" BorderColor="#CCCCCC" 
                        BorderStyle="Solid" BorderWidth="1px" Font-Bold="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label2" runat="server" Text="Prezime:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPrezime" runat="server" BorderColor="#CCCCCC" 
                        BorderStyle="Solid" BorderWidth="1px" Font-Bold="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnIspis" runat="server" BorderColor="#CCCCCC" 
                        BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Size="12px" 
                        ForeColor="#333333" Height="30px" onclick="btnIspis_Click" Text="Ispis" 
                        Width="155px" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Label ID="lblInfo" runat="server" Font-Bold="True" Font-Size="XX-Large" 
                        ForeColor="Red"></asp:Label>
                </td>
            </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
