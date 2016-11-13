<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="DesafioTenisWEB.WebForm2" %>

<%@ Register Src="~/UserControls/AltaPostulacion.ascx" TagPrefix="uc1" TagName="AltaPostulacion" %>
<%@ Register Src="~/UserControls/MensajeNuevo.ascx" TagPrefix="uc1" TagName="MensajeNuevo" %>
<%@ Register Src="~/UserControls/VerMensaje.ascx" TagPrefix="uc1" TagName="VerMensaje" %>







<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:MensajeNuevo runat="server" id="MensajeNuevo" />
        <hr />
        <uc1:VerMensaje runat="server" ID="VerMensaje" />
    </div>
    </form>
</body>
</html>
