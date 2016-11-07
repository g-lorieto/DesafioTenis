<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PerfilTopUserControl.ascx.cs" Inherits="DesafioTenisWEB.UserControls.PerfilTopUserControl" %>
<asp:Repeater runat="server" ID="UdpPerfilTop">
    <ItemTemplate>
        <asp:Image runat="server" ID="ImgPerfil" AlternateText='<%#Eval("NombreCompleto") %>' ImageUrl='<%#Eval("Foto") %>' />
        <asp:Label runat="server" ID="LblNombre" Text='<%#Eval("NombreCompleto") %>'></asp:Label>
        <asp:Label runat="server" ID="LblCiudad" Text='<%#Eval("Ciudad") %>'></asp:Label>
        <asp:Label runat="server" ID="LblClub" Text='<%#Eval("Club") %>'></asp:Label>
        <asp:Label runat="server" ID="LblFechaNacimiento" Text='<%#Eval("FechaNacimineto").ToString().Split(' ')[0] %>'></asp:Label>
        <asp:Label runat="server" ID="LblId" Text='<%#Eval("Id") %>'></asp:Label>
    </ItemTemplate>
</asp:Repeater>
