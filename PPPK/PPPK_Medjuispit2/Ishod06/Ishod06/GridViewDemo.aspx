<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewDemo.aspx.cs" Inherits="Ishod06.GridViewDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gvGrid" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="IDOsoba" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:BoundField DataField="IDOsoba" HeaderText="IDOsoba" InsertVisible="False" ReadOnly="True" SortExpression="IDOsoba" />
                <asp:BoundField DataField="Ime" HeaderText="Ime" SortExpression="Ime" />
                <asp:BoundField DataField="Prezime" HeaderText="Prezime" SortExpression="Prezime" />
                <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" ShowHeader="True" />
                <asp:CommandField HeaderText="Edit" ShowEditButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnDodaj" runat="server" OnClick="btnDodaj_Click" Text="INSERT" />
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:GridViewExampleConnectionString %>" DeleteCommand="DELETE FROM [Osoba] WHERE [IDOsoba] = @IDOsoba" InsertCommand="INSERT INTO [Osoba] ([Ime], [Prezime]) VALUES (@Ime, @Prezime)" SelectCommand="SELECT * FROM [Osoba]" UpdateCommand="UPDATE [Osoba] SET [Ime] = @Ime, [Prezime] = @Prezime WHERE [IDOsoba] = @IDOsoba">
            <DeleteParameters>
                <asp:Parameter Name="IDOsoba" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Ime" Type="String" />
                <asp:Parameter Name="Prezime" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Ime" Type="String" />
                <asp:Parameter Name="Prezime" Type="String" />
                <asp:Parameter Name="IDOsoba" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
