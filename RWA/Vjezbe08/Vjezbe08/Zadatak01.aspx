<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Zadatak01.aspx.cs" Inherits="Vjezbe08.Zadatak01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="AdventureWorksOBP">
            <HeaderTemplate>
                <table>
                    <tr>
                        <th>IME</th>
                        <th>PREZIME</th>
                        <th>EMAIL</th>
                        <th></th>
                    </tr>
                </table>
            </HeaderTemplate>
            <ItemTemplate>
                <table>
                    <tr>
                        <td><%# Eval("Ime") %></td>
                        <td><%# Eval("Prezime") %></td>
                        <td><a href="mailto:<%# Eval("Email") %>"> <%# Eval("Email") %> ></a></td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:Repeater>
        <asp:SqlDataSource ID="AdventureWorksOBP" runat="server" ConnectionString="<%$ ConnectionStrings:cs %>" SelectCommand="SELECT TOP 10 Ime, Prezime, Email FROM Kupac"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
