using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Dominio;
using System.Data.Entity;

namespace Persistencia
{
    public class PersistenciaMensaje
    {
        public static void Add(Mensaje mensaje, int jugadorUno, int jugadorDos)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    if (mensaje != null)
                    {
                        Jugador uno = db.Jugadores.FirstOrDefault(x => x.JugadorId == jugadorUno);
                        Jugador dos = db.Jugadores.FirstOrDefault(x => x.JugadorId == jugadorDos);
                        mensaje.JugadorUno = uno;
                        mensaje.JugadorDos = dos;
                        db.Mensajes.Add(mensaje);
                        db.SaveChanges();
                    }
                }

            }
            catch
            {
                throw new Exception("Error al generar el Resultado del partido - Verifique los Datos");
            }
        }

        public static List<Mensaje> FindByJugadores(int idJugadorUno, int idJugadorDos)
        {
            using (DesafioContext db = new DesafioContext())
            {
                var mensajes = db.Mensajes
                    .Where(x => (x.JugadorUno.JugadorId == idJugadorUno && x.JugadorDos.JugadorId == idJugadorDos)
                || (x.JugadorUno.JugadorId == idJugadorDos && x.JugadorDos.JugadorId == idJugadorUno))
                .Include(x => x.JugadorUno)
                .Include(x => x.JugadorDos);

                if (mensajes != null)
                    return mensajes.ToList();
                else
                    return new List<Mensaje>();
            }
        }

        public static List<Mensaje> FindByJugadorAgrupado(int idJugador)
        {
            using (DesafioContext db = new DesafioContext())
            {
                var agrupados = (from m in db.Mensajes
                                where m.JugadorUno.JugadorId == idJugador || m.JugadorDos.JugadorId == idJugador
                                let otroJugadorId = (m.JugadorUno.JugadorId == idJugador) ? m.JugadorDos.JugadorId : m.JugadorUno.JugadorId
                                group m by otroJugadorId into g
                                select g.OrderByDescending(m => m.Fecha).FirstOrDefault())
                                .Include(x => x.JugadorUno)
                                .Include(x => x.JugadorDos);

                if (agrupados != null)
                    return agrupados.ToList();
                else
                    return new List<Mensaje>();
            }
        }

        public static List<Mensaje> FindByJugador(int idJugador)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    var mensajes = db.Mensajes.Where(x => x.JugadorUno.JugadorId == idJugador || x.JugadorDos.JugadorId == idJugador)
                        .Include(x => x.JugadorUno)
                        .Include(x => x.JugadorDos);

                    if (mensajes != null)
                        return mensajes.ToList();
                    else
                        return new List<Mensaje>();
                }
            }
            catch
            {
                throw new Exception("Error al generar el Resultado del partido - Verifique los Datos");
            }
        }

        public static void Delete(int idMensaje)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    Mensaje mensaje = db.Mensajes.FirstOrDefault(x => x.MensajeId == idMensaje);
                    if (mensaje != null)
                    {
                        db.Mensajes.Remove(mensaje);
                        db.SaveChanges();
                    }
                }
            }
            catch
            {
                throw new Exception("Error al generar el Resultado del partido - Verifique los Datos");
            }
        }






    }
}
