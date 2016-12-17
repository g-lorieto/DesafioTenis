<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VerMensaje.ascx.cs" Inherits="DesafioTenisWEB.UserControls.VerMensaje" %>
<hr />
<asp:Repeater ID="RptMensajes" runat="server">
    <ItemTemplate>
        <asp:Label ID="LblJugador" runat="server" Text='<%#Eval("JugadorUno.Apellido") == ((Dominio.Jugador)Session["Logueado"]).Apellido ? %>'></asp:Label> :
        <asp:Label ID="LblFechaHora" runat="server" Text='<%#Eval("Fecha") %>'></asp:Label> |
        <asp:Label ID="LblMensaje" runat="server" Text='<%#Eval("Texto") %>'></asp:Label>
        <hr />
    </ItemTemplate>
</asp:Repeater>

