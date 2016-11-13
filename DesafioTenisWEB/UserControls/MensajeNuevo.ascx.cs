using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using Dominio;

namespace DesafioTenisWEB.UserControls
{
    public partial class MensajeNuevo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtMensaje.Text))
            {
                int jugadorUno = ((Jugador)Session["Logueado"]).JugadorId;
                int jugadorDos = int.Parse(HdnDestinatarioId.Value);
                Mensaje M = new Mensaje
                { 
                    Fecha = DateTime.Now,                    
                    Leido = false,
                    Texto = TxtMensaje.Text
                };
                LogicaMensaje.Add(M, jugadorUno, jugadorDos);
            }
        }






    }
}