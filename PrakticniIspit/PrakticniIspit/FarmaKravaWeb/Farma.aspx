<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Farma.aspx.cs" Inherits="FarmaKravaWeb.Farma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ddlPasmina" runat="server" AutoPostBack="True" Height="17px" OnSelectedIndexChanged="ddlPasmina_SelectedIndexChanged" Width="207px">
        </asp:DropDownList>
        <br />
        <asp:GridView ID="gvKrave" runat="server" Height="172px" Width="452px" AutoGenerateColumns="False">
            <Columns>
                <asp:ImageField DataImageUrlField="Slika" >
                    <ControlStyle Height="80px" Width="80px" />
                    <ItemStyle Height="40px" Width="40px" />
                </asp:ImageField>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Ime" HeaderText="Ime" />
                <asp:BoundField DataField="DatumRodjenja" HeaderText="Datum rodjenja" />
                <asp:BoundField DataField="Pasmina" HeaderText="Pasmina" />
                <asp:BoundField DataField="BrojTeladi" HeaderText="Broj teladi" />
                <asp:BoundField DataField="VeterinarskiBroj" HeaderText="Veterinarski broj" />
                
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnDnevnaProizvodnja" runat="server" Text="Dnevna proizvodnja" OnClick="dnevnaProizvodnjaShow" CausesValidation="false"/>
                    </ItemTemplate>
                </asp:TemplateField>
                
            </Columns>
        </asp:GridView>
        
        <br />
        <br />
        <asp:GridView ID="gvDetalji" runat="server" AutoGenerateColumns="False" Visible="False">
            <Columns>
                <asp:BoundField DataField="Datum" HeaderText="Datum" />
                <asp:BoundField DataField="KolicinaMlijeka" HeaderText="Kolicina" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
