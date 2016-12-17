using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public static class PersistenciaImagen
    {
        public static void Add(Imagen imagen)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    db.Imagenes.Add(imagen);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }
        public static void Delete(int id)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    Imagen imagen = new Imagen { ImagenId = id };
                    db.Imagenes.Attach(imagen);
                    db.Imagenes.Remove(imagen);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public static List<Imagen> GetImagesByJugador(int idJugador)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    List<Imagen> imagenes = db.Imagenes.Where(x => x.JugadorId == idJugador).ToList();
                    if (imagenes.Count > 0)
                        return imagenes;
                    else
                        return new List<Imagen>();
                
                }
            }
            catch (Exception ex)
            {
                return new List<Imagen>();
            }
        }
    }
}
