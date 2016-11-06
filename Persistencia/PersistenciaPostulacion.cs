using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Dominio;
using System.Data.Entity;

namespace Persistencia
{
    public static class PersistenciaPostulacion
    {
        

        public static void Add(Postulacion p)
        {
            // en pagina de postulaciones ver Postulacion con boton de "Coordinar con el rival"
            // en el chat, que haya un boton para cofirmar partido(postulante)
            // mensaje al chat "el partido ya no esta disponible" 

            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    db.Postulaciones.Add(p);
                    db.SaveChanges();
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Eliminar -" + ex.Message);
            }
        }

        public static List<Postulacion> FindByJugador(int id)
        {


            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    var postulaciones = db.Postulaciones.Where(x => x.Jugador.JugadorId == id);
                    if (postulaciones != null)
                        return postulaciones.ToList();
                    else
                        return new List<Postulacion>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Eliminar -" + ex.Message);
            }
        }

        public static void Update(Postulacion p)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    db.Entry(p).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Actualizar - Verifique los Datos" + ex.Message);
            }
        }
        public static void Delete(int id)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    Postulacion postulacion = db.Postulaciones.FirstOrDefault(x => x.PostulacionId == id);
                    if (postulacion != null)
                    {
                        db.Postulaciones.Remove(postulacion);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Eliminar - Verifique los datos" + ex.Message);
            }
        }
        public static Postulacion FindById(int id)
        {
            using (DesafioContext db = new DesafioContext())
            {
                return db.Postulaciones.FirstOrDefault(x => x.PostulacionId == id);
                
            }          
        }
        public static List<Postulacion> FindAllOrdenadasPorFecha()
        {
            using (DesafioContext db = new DesafioContext())
            {
                var postulaciones = db.Postulaciones.OrderByDescending(x => x.Fecha);
                if (postulaciones != null)
                    return postulaciones.ToList();
                else
                    return new List<Postulacion>();

            }

        }

    }
}
