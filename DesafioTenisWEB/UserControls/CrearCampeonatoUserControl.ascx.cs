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
    public partial class CrearCampeonatoUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCrearCampeonato_Click(object sender, EventArgs e)
        {
            Campeonato.Tipos tipo;
            Enum.TryParse(DDLTipo.SelectedValue, out tipo);

            Campeonato C = new Campeonato
            {
                Nombre = TxtNombre.Text,
                CantidadDeJugadores = int.Parse(DDLCantidadJugadores.SelectedValue),
                Tipo = tipo,
                FechaInicio = DateTime.Parse(TxtFecha.Text)
            };

            LogicaCampeonato.Add(C);
        }

        private void CargarDDLs ()
        {
            DDLTipo.Items.Clear();
            DDLCantidadJugadores.Items.Clear();

            foreach(string tipo in Enum.GetNames(typeof(Campeonato.Tipos)))
            {
                DDLTipo.Items.Add(new ListItem(tipo, tipo));
            }

            for(int i = 1; i <= 100; i++)
            {
                DDLCantidadJugadores.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
                
        }
    }
}