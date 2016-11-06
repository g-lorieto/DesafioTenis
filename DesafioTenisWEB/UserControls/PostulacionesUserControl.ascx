<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PostulacionesUserControl.ascx.cs" Inherits="DesafioTenisWEB.UserControls.PostulacionesUserControl" %>
<asp:Repeater ID="RepeaterPostulaciones" runat="server">
    <HeaderTemplate>
        <table id="TablaPustulaciones">
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
            <td>
                <asp:HyperLink runat="server" Text='<%#Eval("NombreCompleto") %>' NavigateUrl='~/Perfil.aspx?Jugador=<%#Eval("Jugador.Id")%>'></asp:HyperLink>
            </td>
            <td>
                <asp:Label runat="server" Text='<%#Eval("Fecha").ToString().Split(':')[0] + Eval("Fecha").ToString().Split(':')[1] %>'></asp:Label>
            </td>
            <td>
                <asp:Label runat="server" Text='<%#Eval("Comentario")%>'></asp:Label>
            </td>
            <td>
                <asp:LinkButton runat="server" CommandArgument='<%#Eval("Id") %>' ID="LinkBDetalles" OnClick="LinkBDetalles_Click"></asp:LinkButton>
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



