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
    public partial class VerMensaje : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int jugadorId = ((Jugador)Session["Logueado"]).JugadorId;
                var mensajes = LogicaMensaje.FindByJugador(jugadorId);
                RptMensajes.DataSource = mensajes;
                RptMensajes.DataBind();
            }
        }
    }
}