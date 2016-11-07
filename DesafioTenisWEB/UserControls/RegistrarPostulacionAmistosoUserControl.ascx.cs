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

        protected void RegistrarPostulacionAmistoso_Click(object sender, EventArgs e)
        {
            if (DDLHoras.SelectedValue != null)
            {
                if (HdnPostulacionAmistoso.Value == Enums.TipoPartido.Amistoso.ToString())
                { }
                else if (HdnPostulacionAmistoso.Value == Enums.TipoPartido.Postulacion.ToString())
                { }

            }
        }
        private void CrearPartido()
        {
            Partido P = new Partido
            {
                JugadorDesafiante = (Jugador)Session["Jugador"],
                Fecha = DateTime.Parse(TxtFecha.Text + " " + DDLHoras.SelectedValue),
                Lugar = TxtLugar.Text,
                Confirmado = false,
                Calificado = false,
                Cancelado = false,
                Terminado = false,
                
            };
            if (!string.IsNullOrWhiteSpace(TxtComentario.Text))
                P.Comentarios.Add(TxtComentario.Text);

            LogicaPartido.Add(P);


        }
        private void CrearPostulacion()
        {
            Postulacion P = new Postulacion
            {
                Jugador = (Jugador)Session["Jugador"],
                Comentario = TxtComentario.Text,
                Fecha = DateTime.Parse(TxtFecha.Text + " " + DDLHoras.SelectedValue),
                Lugar = TxtLugar.Text,
                Confirmada = false
            };
            LogicaPostulacion.Add(P);
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