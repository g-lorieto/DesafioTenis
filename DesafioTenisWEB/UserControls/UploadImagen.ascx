<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UploadImagen.ascx.cs" Inherits="DesafioTenisWEB.UserControls.UploadImagen" %>
<asp:FileUpload ID="ImageUpload" runat="server" />
<asp:Button ID="BtnGuardarFotos" runat="server" Text="Guardar" OnClick="BtnGuardarFotos_Click" />