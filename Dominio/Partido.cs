using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Partido
    {
        

        public int PartidoId { get; set; }        
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public string Comentario { get; set; }
        public bool Confirmado { get; set; }
        public bool Terminado { get; set; }
        public bool Cancelado { get; set; }
        public bool EstaComentadoJugadorDesafiante { get; set; }
        public bool EstaComentadoJugadorDesafiado { get; set; }


        public virtual Jugador JugadorDesafiante { get; set; }
        public virtual Jugador JugadorDesafiado { get; set; }        
        public virtual Jugador Ganador { get; set; }

        public Jugador OtroJugador(int jugadorId)
        {
            if (JugadorDesafiado.JugadorId == jugadorId)
                return JugadorDesafiante;
            else if (JugadorDesafiante.JugadorId == jugadorId)
                return JugadorDesafiado;
            return null;
        }

        public Partido() { }
    }
}
