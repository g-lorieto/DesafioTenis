using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Dominio;
using System.Data.Entity;

namespace Persistencia
{
    public class PersistenciaPartido
    {

       
        
        public static void Add(Partido p)
        {
            // cartel de aviso con las tareas pendientes (calificaciones y comentario).
            // amistoso libre, resultado opcional con calificacion obligatoria().
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    db.Partidos.Add(p);
                    db.SaveChanges();
                }                
            }
            catch
            {
                throw new Exception("Error al generar el Partido - Verifique los Datos");
            }
        }

        /*public static List<Partido> FindUltimosPartidosByCategoria(int categoria)
        {
            using (DesafioContext db = new DesafioContext())
            {
                var partidos = db.Partidos.OrderByDescending(x => x.Fecha).Where(x => x.JugadorDesafiado.Categoria.Id == categoria
                                && x.JugadorDesafiante.Categoria.Id == categoria && x.Terminado == true);
                if (partidos != null)
                    return partidos.ToList();
                else
                    return new List<Partido>();
            }
        }*/

        public static List<Partido> FindByJugadorPendientes(int id)
        {
            using (DesafioContext db = new DesafioContext())
            {
                var partidos = db.Partidos.Where(x => x.JugadorDesafiado.JugadorId == id && x.JugadorDesafiante.JugadorId == id && x.Terminado == false && x.Cancelado == false);
                if (partidos != null)
                    return partidos.ToList();
                else
                    return new List<Partido>();
            }
        }

        public static void ConfirmarPostulacionEnPartido(Jugador jugador, Postulacion postulacion)
        {
            Partido P = new Partido
            {
                JugadorDesafiante = postulacion.Jugador,
                JugadorDesafiado = jugador,
                Fecha = postulacion.Fecha,
                Lugar = postulacion.Lugar,
                Comentario = postulacion.Comentario
            };
            Add(P);
        }

        public static List<Partido> FindByJugadorCalificar(int id)
        {
            using (DesafioContext db = new DesafioContext())
            {
                var partidos = db.Partidos.Where(x => x.EstaComentado == false && x.JugadorDesafiado.JugadorId == id && x.JugadorDesafiante.JugadorId == id);
                if (partidos != null)
                    return partidos.ToList();
                else
                    return new List<Partido>();
            }
        }
        public static bool TienePartido(int idJugador, DateTime fecha)
        {
            using (DesafioContext db = new DesafioContext())
            {
                var partidos = db.Partidos.Where(x => x.JugadorDesafiado.JugadorId == idJugador || x.JugadorDesafiante.JugadorId == idJugador);
                var partidosNoFinalizados = partidos.Where(x => x.Terminado == false);
                var partido = partidosNoFinalizados.Where(x => x.Fecha == fecha).FirstOrDefault();
                if (partido == null)
                    return false;
                return true;
                
            }
        }

        public static void Update(Partido p)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    db.Entry(p).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch
            {
                throw new Exception("Error al Actualizar - Verifique los Datos");
            }
        }
        public static void Delete(int idPartido)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    Partido partido = db.Partidos.FirstOrDefault(x => x.PartidoId == idPartido);
                    if (partido != null)
                    {
                        db.Partidos.Remove(partido);
                        db.SaveChanges();
                    }
                }
            }
            catch
            {
                throw new Exception("Error al Eliminar - Verifique los datos");
            }
        }
        public static Partido FindById(int idPartido)
        {
            using (DesafioContext db = new DesafioContext())
            {
                return db.Partidos.FirstOrDefault(x => x.PartidoId == idPartido);
            }
        }

        public static List<Partido> FindAll()
        {
           
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    var partidos = db.Partidos;
                    if (partidos != null)
                        return partidos.ToList();
                    else
                        return new List<Partido>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Eliminar -" + ex.Message);
            }
        }
        public static List<Partido> FindByMonth()
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    var partidos = db.Partidos.Where(x => x.Fecha.Month == DateTime.Now.Month);
                    if (partidos != null)
                        return partidos.ToList();
                    else
                        return new List<Partido>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Eliminar -" + ex.Message);
            }
        }
        public static List<Partido> FindFinalizados()
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    var partidos = db.Partidos.Where(x => x.Terminado == true && x.Fecha.Year == DateTime.Now.Year);
                    if (partidos != null)
                        return partidos.ToList();
                    else
                        return new List<Partido>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Eliminar -" + ex.Message);
            }

        }

    }
}
