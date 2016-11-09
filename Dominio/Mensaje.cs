using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Mensaje
    {
        public int MensajeId { get; set; }
        public string Texto { get; set; }        
        public bool Leido { get; set; }
        public DateTime Fecha { get; set; }
        

        public virtual Jugador JugadorUno { get; set; }
        public virtual Jugador JugadorDos { get; set; }


        public Mensaje()
        {
         
        }

    }
}
