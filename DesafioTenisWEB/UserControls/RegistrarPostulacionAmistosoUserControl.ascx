<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RegistrarPostulacionAmistosoUserControl.ascx.cs" Inherits="DesafioTenisWEB.UserControls.RegistrarPostulacion" %>
<asp:Panel ID="PanelPostualcion" DefaultButton="registrarPostulacion" runat="server">
    <asp:Label runat="server">Fecha: </asp:Label>
    <asp:TextBox runat="server" ID="TxtFecha" TextMode="date" placeholder="Ingrese una fecha..."></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFecha" runat="server"
        ControlToValidate="TxtFecha"
        ErrorMessage="Fecha requerida"
        ForeColor="Red">
    </asp:RequiredFieldValidator>

    <asp:Label runat="server">Hora: </asp:Label>
    <asp:DropDownList ID="DDLHoras" runat="server"></asp:DropDownList>

    <asp:Label runat="server">Lugar/Cancha: </asp:Label>
    <asp:TextBox runat="server" ID="TxtLugar" placeholder="Ingrese cancha..."></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredLugar" runat="server"
        ControlToValidate="TxtLugar"
        ErrorMessage="Lugar requerido"
        ForeColor="Red">
    </asp:RequiredFieldValidator>

    <asp:Label runat="server">Comentario: </asp:Label>
    <asp:TextBox runat="server" ID="TxtComentario" CssClass="form-control" TextMode="Multiline" placeholder="Enter ..."></asp:TextBox>

    <asp:HiddenField runat="server" ID="HdnPostulacionAmistoso" />
    <asp:Button ID="RegistrarPostulacionAmistoso" runat="server" OnClick="RegistrarPostulacionAmistoso_Click" Text="Postularme/Amistoso" />
</asp:Panel>
