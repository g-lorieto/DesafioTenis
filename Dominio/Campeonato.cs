﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
    public class Campeonato
    {
        public int CampeonatoId { get; set; }
        public string Nombre { get; set; }
        public int CantidadDeJugadores { get; set; }
        public DateTime FechaInicio { get; set; }
        public Enums.TipoCampeonato Tipo { get; set; }
        public bool Finalizado { get; set; }
 

        
        public virtual ICollection<Jugador> Participantes { get; set; }
        public virtual Jugador Ganador { get; set; }

        public Campeonato()
        {
            this.Participantes = new List<Jugador>();
        }
    }
}
