﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Vjezbe04.Login" %>

<%@ Register src="kontrola.ascx" tagname="kontrola" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:kontrola ID="kontrola1" runat="server" />
    
    </div>
    </form>
</body>
</html>