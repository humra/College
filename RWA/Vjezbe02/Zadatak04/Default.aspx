<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>rwa - vjezbe - zadatak 4</title>
    
    <script type="text/javascript">
        function KorisnickoIme_Provjera(sender, args) {
            var broj = parseInt(args.Value);
            if (broj % 2 == 0)
                args.IsValid = true;
            else
                args.IsValid = false;
        }
    </script>

    <style type="text/css">
        body
        {
            font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;         
            font-size:.8em;   
        }
        .style1
        {
            width: 500px;
        }
        input[type=text],
        input[type=password]        
        {
            width:200px;
            padding:5px;
        }
        input[type=submit]{
            width:210px;
        }
        fieldset{
            border:1px solid #ccc;
        }
        legend{
            padding:0 10px;
            font-weight:bold;
            font-size:.9em;
        }
        .style2
        {
            width: 200px;
        }
    </style>
</head>
<body>
    <fieldset><legend>Podaci o osobi</legend>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="5" cellspacing="0" class="style1">
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="Label1" runat="server" Text="Ime:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtIme" runat="server" BorderColor="#CCCCCC" 
                        BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="#333333"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtIme" Display="Dynamic" ErrorMessage="Niste upisali ime" 
                        Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="Label2" runat="server" Text="Prezime:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPrezime" runat="server" BorderColor="#CCCCCC" 
                        BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="#333333"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtPrezime" Display="Dynamic" 
                        ErrorMessage="Niste upisali prezime" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="Label3" runat="server" Text="Godine:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtGodine" runat="server" BorderColor="#CCCCCC" 
                        BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="#333333"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtGodine" Display="Dynamic" 
                        ErrorMessage="Niste upisali godine" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="txtGodine" Display="Dynamic" 
                        ErrorMessage="Niste upisali broj pod godine" Font-Bold="True" ForeColor="Red" 
                        Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                        ControlToValidate="txtGodine" Display="Dynamic" 
                        ErrorMessage="Godine mogu biti u rasponu 0-150" Font-Bold="True" 
                        ForeColor="Red" MaximumValue="150" MinimumValue="0" Type="Integer">*</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" BorderColor="#CCCCCC" 
                        BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="#333333"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtEmail" Display="Dynamic" 
                        ErrorMessage="Niste upisali email" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txtEmail" Display="Dynamic" 
                        ErrorMessage="Krivo upisana e-mail adresa" Font-Bold="True" ForeColor="Red" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="Label5" runat="server" Text="Korisničko ime (parni broj):"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtKorisnickoIme" runat="server" BorderColor="#CCCCCC" 
                        BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="#333333"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtKorisnickoIme" Display="Dynamic" 
                        ErrorMessage="Niste upisali korisničko ime" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" 
                        ControlToValidate="txtKorisnickoIme" Display="Dynamic" 
                        ErrorMessage="Korisničko ime mora biti broj" Font-Bold="True" ForeColor="Red" 
                        Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" 
                        ClientValidationFunction="KorisnickoIme_Provjera" 
                        ControlToValidate="txtKorisnickoIme" Display="Dynamic" 
                        ErrorMessage="Korisničko ime mora biti paran broj" Font-Bold="True" ForeColor="Red" 
                        onservervalidate="CustomValidator1_ServerValidate" 
                        ToolTip="Korisničko ime mora biti paran broj">*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="Label6" runat="server" Text="Lozinka:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLozinka" runat="server" BorderColor="#CCCCCC" 
                        BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="#333333" 
                        TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="txtLozinka" Display="Dynamic" 
                        ErrorMessage="Niste upisali lozinku" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    <asp:Label ID="Label7" runat="server" Text="Potvrda lozinke:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLozinkaPotvrda" runat="server" BorderColor="#CCCCCC" 
                        BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" ForeColor="#333333" 
                        TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="txtLozinkaPotvrda" Display="Dynamic" 
                        ErrorMessage="Niste upisali potvrdu lozinke" Font-Bold="True" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator3" runat="server" 
                        ControlToCompare="txtLozinka" ControlToValidate="txtLozinkaPotvrda" 
                        Display="Dynamic" ErrorMessage="Lozinke u oba polja moraju odgovarati" 
                        Font-Bold="True" ForeColor="Red">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnPosalji" runat="server" BorderColor="#CCCCCC" 
                        BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Size="12px" 
                        Height="30px" Text="Pošalji"  />
                </td>
            </tr>
            <tr>
                <td align="right" class="style2">
                    &nbsp;</td>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Bold="False" 
                        Font-Size="12px" ForeColor="Red" />
                </td>
            </tr>
            </table>
    
    </div>
    </form>
    </fieldset>
</body>
</html>
