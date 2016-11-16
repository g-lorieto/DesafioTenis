<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="DesafioTenisWEB.WebForm3" %>

<%@ Register Src="~/UserControls/AltaPostulacion.ascx" TagPrefix="uc1" TagName="AltaPostulacion" %>
<%@ Register Src="~/UserControls/Postulaciones.ascx" TagPrefix="uc1" TagName="Postulaciones" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:AltaPostulacion runat="server" ID="AltaPostulacion" />
        <hr />
        <uc1:Postulaciones runat="server" id="Postulaciones" />
    </div>
    </form>
</body>
</html>
