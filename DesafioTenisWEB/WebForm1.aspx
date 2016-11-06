<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DesafioTenisWEB.WebForm1" %>

<%@ Register Src="~/UserControls/RegistroUserControl.ascx" TagPrefix="uc1" TagName="RegistroUserControl" %>
<%@ Register Src="~/UserControls/LoginUserControl.ascx" TagPrefix="uc1" TagName="LoginUserControl" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:RegistroUserControl runat="server" id="RegistroUserControl" />
        <hr />
        <uc1:LoginUserControl runat="server" id="LoginUserControl" />

    </div>
    </form>
</body>
</html>
