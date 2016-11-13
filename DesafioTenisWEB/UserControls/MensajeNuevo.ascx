<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MensajeNuevo.ascx.cs" Inherits="DesafioTenisWEB.UserControls.MensajeNuevo" %>
<asp:HiddenField ID="HdnDestinatarioId" runat="server" Value="2"/>
<asp:Label ID="LblNombreDestinatario" runat="server"></asp:Label>
<asp:TextBox ID="TxtMensaje" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredMensaje" runat="server"
  ControlToValidate="TxtMensaje"
  ErrorMessage="Email requerido"
  ForeColor="Red">
</asp:RequiredFieldValidator>

<asp:Button ID="BtnEnviar" runat="server" Text="Enviar" OnClick="BtnEnviar_Click"/>