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
    public partial class RegistroUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Jugador J = new Jugador
                    {
                        Nombre = TxtNombre.Text,
                        Apellido = TxtApellido.Text,
                        Email = TxtEmail.Text,
                        Password = TxtContrasena.Text,
                        Sexo = RadioBSexo.SelectedValue
                    };
                    LogicaJugador.Add(J);
                    LabelMensaje.Text = "Registrado.";
                }

            }
            catch (Exception ex)
            {
                LabelMensaje.Text = ex.Message;
            }
        }
        protected bool Validar()
        {
            if (!RegexEmailValidator.IsValid)
                return false;
            if (TxtNombre.Text.Trim() == "")
                return false;
            if (TxtApellido.Text.Trim() == "")
                return false;
            if (TxtContrasena.Text.Trim() == "")
                return false;
            if (TxtConfirmarContrasena.Text.Trim() == "")
                return false;            
            return true;
        }

    }
}