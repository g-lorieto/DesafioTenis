using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Persistencia;

namespace Logica
{
    public static class LogicaPartido
    {
        public static void Add(Partido partido)
        {
            if (partido == null)
                throw new Exception("Error al cargar el parido");
            else
                PersistenciaPartido.Add(partido);
        }

        public static void Update(Partido partido)
        {
            if (partido == null)
                throw new Exception("Error al cargar el partido");
            else
                PersistenciaPartido.Update(partido);
        }

        public static void Delete(int idPartido)
        {
            PersistenciaPartido.Delete(idPartido);
        }

        public static Partido FindbyId(int idPartido)
        {
            return PersistenciaPartido.FindById(idPartido);
        }
        public static List<Partido> FindByJugadorCalificar(int idJugador)
        {
            return PersistenciaPartido.FindByJugadorCalificar(idJugador);           
        }
        public static bool TienePartido(int idJugador, DateTime fecha)
        {
            return PersistenciaPartido.TienePartido(idJugador, fecha);
        }

        public static void ConfirmarPostulacionEnPartido(int jugadorId, int postulacionId, string comentarioNuevo)
        {            
            PersistenciaPartido.ConfirmarPostulacionEnPartido(jugadorId, postulacionId, comentarioNuevo);
        }

        public static List<Partido> FindByMonth()
        {
            return PersistenciaPartido.FindByMonth();
        }
        public static List<Partido> FindFinalizados()
        {
            return PersistenciaPartido.FindFinalizados();
        }
        //partidos finalizados. por jugador
        /*public static List<Partido> FindUltimosPartidosByCategoria(int categoria)
        {
            return PersistenciaPartido.FindUltimosPartidosByCategoria(categoria);
        }*/
        public static List<Partido> FindByJugadorPendientes(int idJugador)
        {
            return PersistenciaPartido.FindByJugadorPendientes(idJugador);
        }
        public static List<Partido> FindAll()
        {
            return PersistenciaPartido.FindAll();
        }
    }
}
