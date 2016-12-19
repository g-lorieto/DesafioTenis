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
    public partial class CalificarPartido : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDDLPartidos();
        }

        protected void BtnCalificar_Click(object sender, EventArgs e)
        {
            bool? gano = null;
            if (RdBResultado.SelectedIndex >= 0)
            {
                gano = RdBResultado.SelectedItem.Value == "1" ? true : false;                
            }
            if (RdBEstrellas.SelectedIndex >= 0) {
                Comentario comentario = new Comentario
                {
                    Comentador = (Jugador)Session["Logueado"],
                    Estrellas = int.Parse(RdBEstrellas.SelectedValue),
                    Texto = TxtComentario.Text,
                };
                int otroJugadorId = int.Parse(HdnOtroJugadorId.Value);
                int partidoId = int.Parse(HdnPartidoId.Value);
                LogicaComentario.Add(comentario, otroJugadorId, partidoId, gano);
            }
            

        }

        protected void DDLPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idPartido = int.Parse(((ListItem)sender).Value);
            var partido = LogicaPartido.FindbyId(idPartido);
            LblFecha.Text = partido.Fecha.ToString();
            var otroJugador = partido.JugadorDesafiado.Email == ((Jugador)Session["Logueado"]).Email ? partido.JugadorDesafiante : ((Jugador)Session["Logueado"]);
            LblNombreOtroJugador.Text = otroJugador.NombreCompleto();
            HdnOtroJugadorId.Value = otroJugador.JugadorId.ToString();
            HdnPartidoId.Value = partido.PartidoId.ToString();

        }

        protected void CargarDDLPartidos()
        {
            var partidos = LogicaPartido.FindByJugadorCalificar(LogicaJugador.FindAll().FirstOrDefault().JugadorId);

            foreach(Partido p in partidos)
            {
                var jugador = p.JugadorDesafiado.Email == LogicaJugador.FindAll().FirstOrDefault().Email ? p.JugadorDesafiante : p.JugadorDesafiado;
                DDLPartidos.Items.Add(new ListItem(jugador.NombreCompleto() + " - " + p.Fecha, p.PartidoId.ToString()));
            }
            DDLPartidos.DataBind();
        }
    }
}