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
    public partial class RegistrarPostulacion : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarHoras();
        }

        protected void RegistrarPostulacion_Click(object sender, EventArgs e)
        {
            if (DDLHoras.SelectedValue != null)
            {
                int postulanteId = ((Jugador)Session["Logueado"]).JugadorId;
                Postulacion P = new Postulacion
                {   
                    Comentario = TxtComentario.Text,
                    Fecha = DateTime.Parse(TxtFecha.Text + " " + DDLHoras.SelectedValue),
                    Lugar = TxtLugar.Text,
                    Confirmada = false
                };
                LogicaPostulacion.Add(P, postulanteId);
            }
        }





        private void cargarHoras()
        {
            DDLHoras.Items.Clear();
            for (int i = 7; i <= 23; i++)
            {
                DDLHoras.Items.Add(new ListItem(i + ":00", i + ":00:00"));
            }
            DDLHoras.DataBind();
        }
    }
}