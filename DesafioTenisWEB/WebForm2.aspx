<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="DesafioTenisWEB.WebForm2" %>

<%@ Register Src="~/UserControls/AltaPostulacion.ascx" TagPrefix="uc1" TagName="AltaPostulacion" %>





<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:AltaPostulacion runat="server" ID="AltaPostulacion" />
    </div>
    </form>
</body>
</html>
