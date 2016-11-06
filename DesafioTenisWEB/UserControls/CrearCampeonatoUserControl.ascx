<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CrearCampeonatoUserControl.ascx.cs" Inherits="DesafioTenisWEB.UserControls.CrearCampeonatoUserControl" %>
<asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredNombre" runat="server"
    ControlToValidate="TxtNombre"
    ErrorMessage="Nombre requerido"
    ForeColor="Red">
</asp:RequiredFieldValidator>
<asp:TextBox ID="TxtFecha" TextMode="Date" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFecha" runat="server"
    ControlToValidate="TxtFecha"
    ErrorMessage="Fecha requerida"
    ForeColor="Red">
</asp:RequiredFieldValidator>
<asp:DropDownList ID="DDLCantidadJugadores" runat="server"></asp:DropDownList>
<asp:DropDownList ID="DDLTipo" runat="server"></asp:DropDownList>
<asp:Button ID="BtnCrearCampeonato" runat="server" OnClick="BtnCrearCampeonato_Click" />