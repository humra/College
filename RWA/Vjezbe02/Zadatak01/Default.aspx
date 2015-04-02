<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>RWA - vježbe 2 - zadatak 1</title>
    <style type="text/css">
        .style1 {
            width: 100%;
        }
        body
        {
            font-family:Calibri;
            font-size:14px;    
        }
        
        .style2
        {
            width: 170px;
        }
        .style3
        {
            width: 200px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>RWA - vježbe 2 - zadatak 1</h1>
        <table cellpadding="5" cellspacing="0" class="style1">
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="Label1" runat="server" Text="Ime:"></asp:Label>
                </td>
                <td class="style3">
                    <asp:TextBox ID="txtIme" runat="server" BorderColor="#CCCCCC" 
                        BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="#333333" 
                        Width="120px"></asp:TextBox>
                </td>
                <td rowspan="6" valign="top">
                    <asp:Panel ID="PanelIspis" runat="server" BackColor="#DDDDDD" Height="100px" 
                        Visible="False" Width="250px">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="Label2" runat="server" Text="Prezime:"></asp:Label>
                </td>
                <td class="style3">
                    <asp:TextBox ID="txtPrezime" runat="server" BorderColor="#CCCCCC" 
                        BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="#333333" 
                        Width="120px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="Label3" runat="server" Text="Grad:"></asp:Label>
                </td>
                <td class="style3">
                    <asp:DropDownList ID="ddlGrad" runat="server" Width="120px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="Label4" runat="server" Text="Spol:"></asp:Label>
                </td>
                <td class="style3">
                    <asp:RadioButtonList ID="rblSpol" runat="server">
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="Label5" runat="server" Text="Vozačka dozvola:"></asp:Label>
                </td>
                <td class="style3">
                    <asp:CheckBox ID="cbVozacka" runat="server" />
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    &nbsp;</td>
                <td class="style3">
                    <asp:Button ID="btnIspis" runat="server" BorderColor="#CCCCCC" 
                        BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Size="12px" 
                        ForeColor="#333333" Height="30px" Text="Ispiši podatke" Width="120px" 
                        onclick="btnIspis_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
