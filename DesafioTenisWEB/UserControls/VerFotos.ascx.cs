using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Logica;

namespace DesafioTenisWEB.UserControls
{
    public partial class VerFotos : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RepeaterFotos.DataSource = LogicaImagen.GetImagesByJugador(LogicaJugador.FindAll().FirstOrDefault().JugadorId);
            RepeaterFotos.DataBind();
        }
    }
}