<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calc.aspx.cs" Inherits="Calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="get" action="Rezultat.aspx">
    <div>
    
        <input id="txtPrviBroj" type="text" name="prvi"/><br />
        <br />
        <input id="txtDrugiBroj" type="text" name="drugi"/><br />
        <br />
        <select id="slcRacunskaOperacija" name="operacija">
            <option>+</option>
            <option>-</option>
            <option>*</option>
            <option>/</option>
        </select><br />
        <br />
        <br />
        <input type="submit" id="btn" value="Izracunaj"/></div>
    </form>
</body>
</html>
