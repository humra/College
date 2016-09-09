<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="EntityCodeFirstPractice.StartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 145px;
        }
        .auto-style2 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td class="auto-style1">Guild name: </td>
                <td>
                    <asp:TextBox ID="txtGuildName" runat="server" Width="195px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="2">
                    <asp:Button ID="btnInsertGuild" runat="server" OnClick="btnInsertGuild_Click" Text="CREATE GUILD" Width="141px" />
                </td>
                <td></td>
            </tr>
            <tr>
                <td>Player nickname:</td>
                <td>
                    <asp:TextBox ID="txtMemberNickname" runat="server" Width="189px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Player&#39;s guild ID:</td>
                <td><asp:TextBox ID="txtMemberGuildId" runat="server" Width="189px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnInsertMember" runat="server" Text="INSERT MEMBER" OnClick="btnInsertMember_Click" Width="141px" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnDeleteMember" runat="server" Text="DELETE MEMBER" OnClick="btnDeleteMember_Click" Width="191px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:DropDownList ID="ddlGuilds" runat="server" Height="23px" Width="139px" AutoPostBack="True" OnSelectedIndexChanged="ddlGuilds_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:ListBox ID="lbGuildMembers" runat="server" Height="139px" Width="347px"></asp:ListBox>
                </td>
                <td></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
