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
    public partial class LoginUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Jugador J = LogicaJugador.Logueo(TxtEmail.Text, TxtContrasena.Text);
                    if (J != null)
                    {
                        LblMensaje.Text = "Logueado";
                    }
                }
            }
            catch (Exception ex)
            {
                LblMensaje.Text = ex.Message;
            }
        }

        protected bool Validar()
        {
            if (TxtEmail.Text.Trim() == "")
                return false;
            if (TxtContrasena.Text.Trim() == "")
                return false;

            return true;
        }
    }
}