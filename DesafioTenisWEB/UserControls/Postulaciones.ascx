<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Postulaciones.ascx.cs" Inherits="DesafioTenisWEB.UserControls.PostulacionesUserControl" %>
<asp:Repeater ID="RepeaterPostulaciones" runat="server">
    <HeaderTemplate>
        <table id="TablaPustulaciones">
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
            <td>
                <asp:HyperLink runat="server" Text='<%#Eval("Jugador.Nombre") + " " + Eval("Jugador.Apellido") %>' NavigateUrl='~/Perfil.aspx?Jugador=<%#Eval("Jugador.Id")%>'></asp:HyperLink>
            </td>
            <td>
                <asp:Label runat="server" Text='<%#Eval("Fecha", "{0:dd/MM/yyyy}")%>'></asp:Label>
            </td>
            <td>
                <asp:Label runat="server" Text='<%#Eval("Comentario")%>'></asp:Label>
            </td>
            <td>
                <asp:Label runat="server" Text='<%#Eval("Lugar")%>'></asp:Label>
            </td>
            <td>
                <asp:LinkButton runat="server" Text="Ver Detalles" CommandArgument='<%#Eval("PostulacionId") %>' ID="LinkBDetalles" OnClick="LinkBDetalles_Click"></asp:LinkButton>
            </td>
        </tr>
    </ItemTemplate>
    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:Repeater>

<div class="modal">
    <asp:HiddenField runat="server" ID="HdnIdPostulacion" />
    <asp:Label runat="server" ID="LblNombre"></asp:Label>
    <asp:Label runat="server" ID="LblFecha"></asp:Label>
    <asp:Label runat="server" ID="LblComentario"></asp:Label>
    <asp:TextBox runat="server" ID="TxtMensaje"></asp:TextBox>
    <asp:Button runat="server" ID="BtnConfirmar" OnClick="BtnConfirmar_Click" Text="Confirmar" />
</div>



