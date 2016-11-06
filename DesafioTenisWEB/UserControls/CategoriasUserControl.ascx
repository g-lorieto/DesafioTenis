<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CategoriasUserControl.ascx.cs" Inherits="DesafioTenisWEB.UserControls.CategoriasUserControl" %>
<asp:Repeater runat="server" ID="RepeaterCategorias">
    <ItemTemplate>
        <asp:LinkButton runat="server" CommandArgument='<%#Eval("Id") %>' OnClick="CambiarCategoria_Click"></asp:LinkButton>
        <asp:Label runat="server" Text='<%#Eval("Nombre") %>'></asp:Label>
    </ItemTemplate>
</asp:Repeater>