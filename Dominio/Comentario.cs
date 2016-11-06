using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Comentario
    {
        public int ComentarioId { get; set; }
        public string Texto { get; set; }        
        public int Estrellas { get; set; }


        public virtual Jugador Comentado { get; set; }
        public virtual Jugador Comentador { get; set; }

        public Comentario()
        {

        }

        public bool ValidarCalificacion()
        {
            return Estrellas < 6 && Estrellas > 0;
        }
    }
}
