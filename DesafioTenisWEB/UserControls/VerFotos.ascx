<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VerFotos.ascx.cs" Inherits="DesafioTenisWEB.UserControls.VerFotos" %>

<div id="modal-foto-grande">
    <asp:Image ID="Image1" ImageUrl="" runat="server" />
</div>

<div id='container'>
    <asp:DataList ID="RepeaterFotos" runat="server" RepeatDirection="Horizontal" RepeatColumns="5" >
        <ItemTemplate>
            <asp:ImageButton ID="ThumbnailImg" ImageUrl='<%# Eval("RutaImagen") %>' Height="100" Width="150" BorderStyle="Ridge" runat="server" OnClientClick="ShowFullImg(this);" />
        </ItemTemplate>
    </asp:DataList>
</div>
<script type="text/html" src="../Scripts/jquery-1.10.2.min.js"></script>
<script type="text/javascript">
    function ShowFullImg(e)
    {
        var imagen = $(this).find(e)[0];
        var url = $(imagen).attr('src');
        $('#modal-foto-grande img').attr('src', url);
        $('#modal-foto-grande').modal();
    }
</script>
