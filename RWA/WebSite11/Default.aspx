<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="~/CtrlDefineButton.ascx" TagPrefix="uc1" TagName="CtrlDefineButton" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:CtrlDefineButton runat="server" ID="CtrlDefineButton" />
    </div>
    </form>
</body>
</html>
