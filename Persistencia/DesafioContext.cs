using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dominio;

namespace Persistencia
{
    public class DesafioContext : DbContext
    {
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }
        public DbSet<Partido> Partidos { get; set; }
        public DbSet<Postulacion> Postulaciones { get; set; }
        public DbSet<Campeonato> Campeonatos { get; set; }
        public DesafioContext():base("DefaultConnection")
        {
            //agregar configurando para DF
            //<add name="conn" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;INTEGRATED SECURITY=true;DataBase=BienvenidosUYMVC;" providerName="System.Data.SqlClient" />
        }

    }
}
