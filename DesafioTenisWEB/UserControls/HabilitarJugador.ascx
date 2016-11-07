<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HabilitarJugador.ascx.cs" Inherits="DesafioTenisWEB.UserControls.HabilitarJugadorUserControl" %>
<asp:Label runat="server" Text="Buscar Jugador"></asp:Label>
<asp:TextBox runat="server" ID="TxtBuscar"></asp:TextBox>
<asp:Button runat="server" ID="BtnBuscar" OnClick="BtnBuscar_Click"/>
<asp:Repeater runat="server" ID="RptJugador">
    <ItemTemplate>
        <asp:HiddenField runat="server" ID="HdnId" Value=='<%#Eval("Id") %>' />
        <asp:Label runat="server" Text='<%#Eval("NombreCompleto") %>'></asp:Label>
        <asp:Label runat="server" Text='<%#Eval("Email") %>'></asp:Label>
        <asp:Label runat="server" Text='<%#Eval("Habilitado") %>'></asp:Label>
        <asp:CheckBox runat="server" ID="ChkHabilitar" Text="Habilitar" />
    </ItemTemplate>
</asp:Repeater>
<asp:Button runat="server" ID="BtnHabilitar" OnClick="BtnHabilitar_Click" />

