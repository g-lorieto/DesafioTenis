<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DesafioTenisWEB.WebForm1" EnableEventValidation="false"%>




<%@ Register Src="~/UserControls/UploadImagen.ascx" TagPrefix="uc1" TagName="UploadImagen" %>
<%@ Register Src="~/UserControls/VerFotos.ascx" TagPrefix="uc2" TagName="VerFotos" %>






<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:UploadImagen runat="server" id="UploadImagen" />
        <br /><hr /><br />
        <uc2:VerFotos runat="server" id="VerFotos" />
    </div>
    </form>
</body>
</html>
