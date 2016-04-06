<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Zadatak04.aspx.cs" Inherits="Vjezbe02.Zadatak04" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function KorisnickoIme_Provjera(sender, args) {
            var broj = parseInt(args.Value);
            if (broj % 2 == 0)
                args.IsValid = true;
            else
                args.IsValid = false;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset name="forma">

            Ime:
            <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtIme" ErrorMessage="*"></asp:RequiredFieldValidator>
            <br />
            Prezime:
            <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPrezime" ErrorMessage="*"></asp:RequiredFieldValidator>
            <br />
            Godine:
            <asp:TextBox ID="txtGodine" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtGodine" ErrorMessage="*"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtGodine" ErrorMessage="*" MaximumValue="150" MinimumValue="0"></asp:RangeValidator>
            <br />
            Email:
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEmail" ErrorMessage="*"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="*" ValidationExpression="\w+@(gmail|yahoo)(.com|.hr)"></asp:RegularExpressionValidator>
            <br />
            Korisnicko ime (parni broj):
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtUsername" ErrorMessage="*"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="*" ClientValidationFunction="KorisnickoIme_Provjera" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            <br />
            Lozinka: <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtLozinka" ErrorMessage="*"></asp:RequiredFieldValidator>
            <br />
            Potvrda lozinke:
            <asp:TextBox ID="txtPotvrdaLozinke" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtPotvrdaLozinke" ErrorMessage="*"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtLozinka" ControlToValidate="txtPotvrdaLozinke" ErrorMessage="*"></asp:CompareValidator>
            <br />
            <br />
            <asp:Button ID="btnSalji" runat="server" Text="Posalji" Width="101px" onClick="return paran()"/>
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />

        </fieldset>
    </div>
    </form>
</body>
</html>
