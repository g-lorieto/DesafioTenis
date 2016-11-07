<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="DesafioTenisWEB.UserControls.LoginUserControl" %>

<asp:TextBox runat="server" ID="TxtEmail" placeholder="Email"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredEmail" runat="server"
  ControlToValidate="TxtEmail"
  ErrorMessage="Email requerido"
  ForeColor="Red">
</asp:RequiredFieldValidator>

<asp:TextBox runat="server" ID="TxtContrasena" placeholder="Contraseña"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredContrasena" runat="server"
  ControlToValidate="TxtContrasena"
  ErrorMessage="Contraseña requerida"
  ForeColor="Red">
</asp:RequiredFieldValidator>

<asp:Button ID="BtnLogin" runat="server" Text="Ingresar" CssClass="btn btn-primary btn-block btn-flat" OnClick="BtnLogin_Click" />

<asp:Label ID="LblMensaje" runat="server"></asp:Label>




