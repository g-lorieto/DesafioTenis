using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Postulacion
    {
        public int PostulacionId { get; set; }        
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public string Comentario { get; set; }
        public bool Confirmada { get; set; }
        public virtual Jugador Jugador { get; set; }

        public Postulacion() { }

    }
}
