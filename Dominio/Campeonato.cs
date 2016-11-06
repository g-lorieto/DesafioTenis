using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Campeonato
    {
        public enum Tipos { Single, Doble, Mixto };

        public int CampeonatoId { get; set; }
        public string Nombre { get; set; }
        public int CantidadDeJugadores { get; set; }
        public DateTime FechaInicio { get; set; }
        public Tipos Tipo { get; set; }
        public bool Finalizado { get; set; }
 

        
        public virtual List<Jugador> Participantes { get; set; }
        public virtual Jugador Ganador { get; set; }
    }
}
