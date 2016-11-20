<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="DesafioTenisWEB.WebForm4" %>

<%@ Register Src="~/UserControls/Registro.ascx" TagPrefix="uc1" TagName="Registro" %>
<%@ Register Src="~/UserControls/VerMensaje.ascx" TagPrefix="uc1" TagName="VerMensaje" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:VerMensaje runat="server" ID="VerMensaje" />
    </div>
    </form>
</body>
</html>
