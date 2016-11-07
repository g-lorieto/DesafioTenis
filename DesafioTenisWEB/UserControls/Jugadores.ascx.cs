using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesafioTenisWEB.UserControls
{
    public partial class JugadoresUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GoToPerfil_Click(object sender, EventArgs e)
        {
            LinkButton btn = ((LinkButton)sender);
            if (!string.IsNullOrWhiteSpace(btn.CommandArgument))
            {
                int IdPerfil = int.Parse(btn.CommandArgument);
                //Response.Redirect("Perfil.aspx?id=" + IdPerfil);
            }
        }
    }
}