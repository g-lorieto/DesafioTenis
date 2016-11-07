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
    public partial class PerfilTopUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Jugador"] != null)
            {
                try
                {
                    int IdJugador = int.Parse(Request.QueryString["Jugador"].ToString());
                    Jugador J = LogicaJugador.FindbyId(IdJugador);
                    if (J != null)
                    {
                        UdpPerfilTop.DataSource = J;
                        UdpPerfilTop.DataBind();
                    }
                }
                catch
                {

                }
            }
        }
    }
}