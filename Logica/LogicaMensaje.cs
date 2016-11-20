using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Persistencia;

namespace Logica
{
    public static class LogicaMensaje
    {
        public static void Add(Mensaje mensaje, int jugadorUno, int jugadorDos)
        {
            PersistenciaMensaje.Add(mensaje, jugadorUno, jugadorDos);
        }
        public static void Delete(int idMensaje)
        {
            PersistenciaMensaje.Delete(idMensaje);
        }
 
        public static List<Mensaje> FindByJugador(int idJugador)
        {
            return PersistenciaMensaje.FindByJugador(idJugador);
        }

        public static List<Mensaje> FindByJugadores(int idJugadorUno, int idJugadorDos)
        {
            return PersistenciaMensaje.FindByJugadores(idJugadorUno, idJugadorDos);
        }

        public static List<Mensaje> FindByJugadorAgrupado(int idJugador)
        {
            return PersistenciaMensaje.FindByJugadorAgrupado(idJugador);
        }

    }
}
