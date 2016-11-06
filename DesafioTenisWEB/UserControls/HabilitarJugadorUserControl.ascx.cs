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
    public partial class HabilitarJugadorUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnHabilitar_Click(object sender, EventArgs e)
        {
            List<int> habilitar = new List<int>();
            foreach (RepeaterItem item in RptJugador.Items)
            {
                CheckBox checkBox = (CheckBox)item.FindControl("ChkHabilitar");
                if (checkBox.Checked)
                {
                    HiddenField hdnId = (HiddenField)item.FindControl("HdnId");
                    int id = int.Parse(hdnId.Value);
                    habilitar.Add(id);
                }
            }
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtBuscar.Text))
            {
                RptJugador.DataSource = LogicaJugador.FindByNombreOApellido(TxtBuscar.Text);
                RptJugador.DataBind();
            }
        }
    }
}