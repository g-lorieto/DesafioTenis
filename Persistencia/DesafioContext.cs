﻿using System;
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
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Jugador>()
                .HasMany(x => x.Campeonatos)
                .WithMany(x => x.Participantes)
                .Map(x =>
                {
                    x.ToTable("CampeonatoParticipantes");
                    x.MapLeftKey("CampeonatoId");
                    x.MapRightKey("JugadorId");
                });

            modelBuilder.Entity<Jugador>()
                .HasMany<Mensaje>(x => x.Mensajes)
                .WithRequired(x => x.JugadorUno)
                .HasForeignKey(x => x.JugadorUnoId);

            modelBuilder.Entity<Jugador>()
                .HasMany<Mensaje>(x => x.Mensajes)
                .WithRequired(x => x.JugadorDos)
                .HasForeignKey(x => x.JugadorDosId);

            /*modelBuilder.Entity<Mensaje>()
                .HasRequired<Jugador>(x => x.JugadorUno)
                .WithMany(x => x.Mensajes)
                .HasForeignKey(x => x.JugadorUnoId);

            modelBuilder.Entity<Mensaje>()
                .HasRequired<Jugador>(x => x.JugadorDos)
                .WithMany(x => x.Mensajes)
                .HasForeignKey(x => x.JugadorDosId);*/




        }

    }
}
