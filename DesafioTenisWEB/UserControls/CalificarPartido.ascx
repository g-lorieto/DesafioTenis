<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CalificarPartido.ascx.cs" Inherits="DesafioTenisWEB.UserControls.CalificarPartido" %>
<asp:DropDownList runat="server" ID="DDLPartidos" OnSelectedIndexChanged="DDLPartidos_SelectedIndexChanged">
</asp:DropDownList>
<asp:Label runat="server" ID="LblNombreOtroJugador"></asp:Label>
<asp:Label runat="server" ID="LblFecha" ></asp:Label>
<asp:HiddenField runat="server" ID="HdnPartidoId"/>
<asp:HiddenField runat="server" ID="HdnOtroJugadorId" />
<asp:RadioButtonList ID="RdBEstrellas" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
    <asp:ListItem Value="1" Text="1"></asp:ListItem>
    <asp:ListItem Value="2" Text="2"></asp:ListItem>
    <asp:ListItem Value="3" Text="3"></asp:ListItem>
    <asp:ListItem Value="4" Text="4"></asp:ListItem>
    <asp:ListItem Value="5" Text="5"></asp:ListItem>
</asp:RadioButtonList>

<asp:TextBox runat="server" ID="TxtComentario"></asp:TextBox>

<asp:RadioButtonList ID="RdBResultado" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
    <asp:ListItem Value="1" Text="Gane"></asp:ListItem>
    <asp:ListItem Value="0" Text="Perdi"></asp:ListItem>
</asp:RadioButtonList>

<asp:Button runat="server" ID="BtnCalificar" OnClick="BtnCalificar_Click" />

