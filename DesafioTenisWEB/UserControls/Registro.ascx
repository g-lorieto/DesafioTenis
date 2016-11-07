<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Registro.ascx.cs" Inherits="DesafioTenisWEB.UserControls.RegistroUserControl" %>
<%@ Register Src="~/UserControls/JugadoresUserControl.ascx" TagPrefix="uc1" TagName="JugadoresUserControl" %>

<asp:Label runat="server" Text="Email"></asp:Label>
<asp:TextBox runat="server" ID="TxtEmail" placehorder="Email"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredEmail" runat="server"
  ControlToValidate="TxtEmail"
  ErrorMessage="Email requerido"
  ForeColor="Red">
</asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RegexEmailValidator" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="TxtEmail" ErrorMessage="Email Invalido"></asp:RegularExpressionValidator>

<asp:Label runat="server" Text="Contrasena"></asp:Label>

<asp:TextBox runat="server" ID="TxtContrasena" placehorder="Contraseña"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredContrasena" runat="server"
  ControlToValidate="TxtContrasena"
  ErrorMessage="Contraseña requerida"
  ForeColor="Red">
</asp:RequiredFieldValidator>
<asp:Label runat="server" Text="Confirmar"></asp:Label>

<asp:TextBox runat="server" ID="TxtConfirmarContrasena" placehorder="Confiarmar Contraseña"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredConfirmarContrasena" runat="server"
  ControlToValidate="TxtConfirmarContrasena"
  ErrorMessage="Confirmar contraseña requerida"
  ForeColor="Red">
</asp:RequiredFieldValidator>
<asp:Label runat="server" Text="Nombre"></asp:Label>

<asp:TextBox runat="server" ID="TxtNombre" placehorder="Nombre"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredNombre" runat="server"
  ControlToValidate="TxtNombre"
  ErrorMessage="Nombre requerido"
  ForeColor="Red">
</asp:RequiredFieldValidator>
<asp:Label runat="server" Text="Apellido"></asp:Label>

<asp:TextBox runat="server" ID="TxtApellido" placehorder="Apellido"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredApellido" runat="server"
  ControlToValidate="TxtApellido"
  ErrorMessage="Apellido requerido"
  ForeColor="Red">
</asp:RequiredFieldValidator>
<asp:Label runat="server" Text="Sexo"></asp:Label>

<asp:RadioButtonList ID="RadioBSexo" runat="server" RepeatLayout="Flow" RepeatDirection="Horizontal">
    <asp:ListItem Value="M">Jugador</asp:ListItem>
    <asp:ListItem Value="F">Jugadora</asp:ListItem>
</asp:RadioButtonList>
<asp:RequiredFieldValidator ID="RequiredSexo" runat="server"
  ControlToValidate="RadioBSexo"
  ErrorMessage="Sexo requerido"
  ForeColor="Red">
</asp:RequiredFieldValidator>

<asp:Label ID="LabelMensaje" runat="server"></asp:Label>

<asp:Button ID="BtnRegistro" runat="server" Text="Registrarse" CssClass="btn btn-primary btn-block btn-flat" OnClick="BtnRegistro_Click" />
