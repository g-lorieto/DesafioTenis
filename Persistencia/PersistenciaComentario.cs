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
    public class PersistenciaComentario
    {

        public static void Add(Comentario c)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    if (!db.Comentarios.Contains(c))
                    {
                        db.Comentarios.Add(c);
                        db.SaveChanges();
                    }
                }
                
            }
            catch
            {
                throw new Exception("Error al generar el Resultado del partido " + c.ComentarioId + " - Verifique los Datos");
            }
        }
        public static void Update(Comentario c)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    db.Entry(c).State = EntityState.Modified;
                    db.SaveChanges();
                }
           
            }
            catch
            {
                throw new Exception("Error al Actualizar resutlado - Verifique los Datos");
            }
        }
        public static void Delete(int id)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    Comentario c = db.Comentarios.FirstOrDefault(x => x.ComentarioId == id);
                    if (c != null)
                    {
                        db.Comentarios.Remove(c);
                        db.SaveChanges();
                    }
                }
            }
            catch
            {
                throw new Exception("Error al Eliminar - Verifique los datos");
            }
        }
        public static Comentario FindById(int id)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    return db.Comentarios.FirstOrDefault(x => x.ComentarioId == id);
                }
            }
            catch
            {
                throw new Exception("Error al Eliminar - Verifique los datos");
            }
        }
        public static List<Comentario> FindByJugador(int IdJugador)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    var comentarios = db.Comentarios.Where(x => x.Comentado.JugadorId == IdJugador);
                    if (comentarios != null)
                        return comentarios.ToList();
                    else
                        return new List<Comentario>();
                }
            }
            catch
            {
                throw new Exception("Error al Eliminar - Verifique los datos");
            }
        }
       
        
        public static List<Comentario> FindAll()
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    var comentarios = db.Comentarios;
                    if (comentarios != null)
                        return comentarios.ToList();
                    else
                        return new List<Comentario>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Actualizar resutlado - Verifique los Datos");
            }
        }

    }
}
