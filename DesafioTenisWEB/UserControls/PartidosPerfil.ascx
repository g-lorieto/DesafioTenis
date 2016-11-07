<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PartidosPerfil.ascx.cs" Inherits="DesafioTenisWEB.UserControls.PartidosPerfil" %>
<asp:Repeater runat="server" ID="PostAmistosos">
    <ItemTemplate>
        <asp:Image runat="server" ImageUrl='<%#Eval("JugadorDesafiante.Foto")%>' AlternateText='<%#Eval("JugadorDesafiante.Nombre")%>' />
        <asp:Label runat="server" Text='<%#Eval("JugadorDesafiante.NombreCompleto")%>'></asp:Label>
        <asp:TextBox runat="server" placeholder="Responder" ID="TxtMensaje" />
        <asp:Button runat="server" CommandArgument='<%#Eval("Id")%>' OnCommand="EnviarMensaje" CssClass="btn btn-danger pull-right btn-block btn-sm" Text="Enviar Mensaje"></asp:Button>
    </ItemTemplate>
</asp:Repeater>
