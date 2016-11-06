using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Dominio;

namespace Persistencia
{
    public class PersistenciaMensaje
    {
        public static void Add(Mensaje mensaje)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    if (mensaje != null)
                    {
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

        public static List<Mensaje> FindByJugador(int idJugador)
        {            
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    var mensajes = db.Mensajes.Where(x => x.JugadorDos.JugadorId == idJugador || x.JugadorUno.JugadorId == idJugador);
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
