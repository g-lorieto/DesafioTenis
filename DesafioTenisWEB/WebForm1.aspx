<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DesafioTenisWEB.WebForm1" %>


<%@ Register Src="~/UserControls/Login.ascx" TagPrefix="uc1" TagName="LoginUserControl" %>
<%@ Register Src="~/UserControls/Registro.ascx" TagPrefix="uc1" TagName="Registro" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <br />
        <uc1:LoginUserControl runat="server" id="LoginUserControl" />
    </div>
    </form>
</body>
</html>
