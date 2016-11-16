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
    public partial class PostulacionesUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Logueado"] != null)
            {
                int jugadorId = ((Jugador)Session["Logueado"]).JugadorId;
                var postulaciones = LogicaPostulacion.FindAllOrdenadoPorFecha(jugadorId);
                if (postulaciones.Count > 0)
                {
                    RepeaterPostulaciones.DataSource = postulaciones;
                    RepeaterPostulaciones.DataBind();
                }
                else
                {
                    //postulaciones vacias
                }
            }
        }

        protected void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (HdnIdPostulacion.Value != null)
            {
                int postulacionId = int.Parse(HdnIdPostulacion.Value);
                int jugadorId = ((Jugador)Session["Logueado"]).JugadorId;
                LogicaPartido.ConfirmarPostulacionEnPartido(jugadorId, postulacionId);
            }

        }

        protected void LinkBDetalles_Click(object sender, EventArgs e)
        {
            int IdPostulacion = int.Parse(((LinkButton)sender).CommandArgument);
            VerDatosPostulacion(IdPostulacion);
        }

        private void VerDatosPostulacion(int IdPostulacion)
        {
            Postulacion P = LogicaPostulacion.FindbyId(IdPostulacion);
            if (P != null)
            {
                HdnIdPostulacion.Value = P.PostulacionId.ToString();
                LblNombre.Text = P.Jugador.NombreCompleto();
                LblFecha.Text = P.Fecha.ToString().Split(':')[0] + ":" + P.Fecha.ToString().Split(':')[1];
                LblComentario.Text = P.Comentario;
            }

        }
    }
}