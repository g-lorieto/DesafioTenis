using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Persistencia;

namespace Logica
{
    public static class LogicaJugador
    {
        public static void Add(Jugador jugador)
        {
            if (jugador == null)
                throw new Exception("No se ingreso un Jugador");
            else
                PersistenciaJugador.Add(jugador);
        }

        public static void Update(Jugador jugador)
        {
            if (jugador == null)
                throw new Exception("Error al traer el jugador");
            else
                PersistenciaJugador.Update(jugador);
        }

        public static void Delete(int id)
        {
            PersistenciaJugador.Delete(id);
        }
        public static void CambioPassword(string email, string password)
        {
            if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(password))
                PersistenciaJugador.CambioPassword(email, password);
        }
        public static Jugador FindByEmail(string email)
        {
            if (!string.IsNullOrWhiteSpace(email))
                return PersistenciaJugador.FindfByEmail(email);
            else
                return null;
        }
        
        public static int CantidadDeJugadores()
        {
            return PersistenciaJugador.CantidadDeJugadores();
        }
        
        public static Jugador FindbyId(int id)
        {
            return PersistenciaJugador.FindById(id);
        }

        public static List<Jugador> FindDesafios(int rank)
        {
            return PersistenciaJugador.FindDesafios(rank);
        }
        public static List<Jugador> FindByNombreOApellido(string nombreOApellido)
        {
            return PersistenciaJugador.FindByNombreOApellido(nombreOApellido);
        }
        public static Jugador Logueo(string pEmail, string pPasswd)
        {      
            return (Login.Logueo(pEmail, pPasswd));
        }
        public static List<Jugador> FindAll()
        {
            return PersistenciaJugador.FindAll();
        }
    }
}
