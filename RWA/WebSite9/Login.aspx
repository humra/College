<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" UnobtrusiveValidationMode="None" %>

<%@ Register Src="~/Obrazac.ascx" TagPrefix="uc1" TagName="Obrazac" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:Obrazac runat="server" ID="loginObrazac" />
    </div>
    </form>
</body>
</html>
