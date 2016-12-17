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
        public DbSet<Imagen> Imagenes { get; set; }
        public DesafioContext():base("DefaultConnection")
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jugador>()
                .HasMany(x => x.Campeonatos)
                .WithMany(x => x.Participantes)
                .Map(x =>
                {
                    x.ToTable("CampeonatoParticipantes");
                    x.MapLeftKey("CampeonatoId");
                    x.MapRightKey("JugadorId");
                });
            

            base.OnModelCreating(modelBuilder);


        }

    }
}
