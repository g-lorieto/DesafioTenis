<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="JugadoresUserControl.ascx.cs" Inherits="DesafioTenisWEB.UserControls.JugadoresUserControl" %>
<asp:Repeater ID="RepeaterJugadores" runat="server">
    <ItemTemplate>
        <asp:LinkButton runat="server" OnClick="GoToPerfil_Click" CommandArgument='<%#Eval("Id")%>'>
            <asp:Image runat="server" ImageUrl='<%#Eval("Foto")%>' AlternateText='<%#Eval("NombreCompleto")%>' />
            <asp:Label runat="server" Text='<%#Eval("NombreCompleto")%>'></asp:Label>
            <asp:Label runat="server" Text='<%#Eval("Puntaje")%>'></asp:Label>
        </asp:LinkButton>
        <hr />
    </ItemTemplate>
</asp:Repeater>
