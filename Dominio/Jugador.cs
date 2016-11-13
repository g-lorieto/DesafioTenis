using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Jugador
    {
        public int JugadorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }        
        public string Sexo { get; set; }        
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Manana { get; set; }
        public bool Tarde { get; set; }
        public bool Noche { get; set; }        
        public string Foto { get; set; }
        public int RankingSingle { get; set; }        
        public DateTime? FechaNacimiento { get; set; }
        public string Celular { get; set; }
        public bool Estado { get; set; }
        public int Puntaje { get; set; }

        public virtual ICollection<Campeonato> Campeonatos { get; set; }
        

        public string NombreCompleto()
        {
            return  string.Format("{0} {1}", Nombre, Apellido);
        }

        public override string ToString()
        {
            return NombreCompleto();
        }


        public override bool Equals(object obj)
        {
            return this.Email == ((Jugador)obj).Email;
        }

        public Jugador()
        {
            this.Campeonatos = new List<Campeonato>();
        }
    }
}
