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
    public static class PersistenciaJugador
    {
        public static void Add(Jugador j)
        {  
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    if (db.Jugadores.Where(x => x.Email == j.Email).Count() == 0)
                    {
                        db.Jugadores.Add(j);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Agregar el Jugador - Verifique los Datos");
            }

        }
        public static List<Jugador> FindByNombreOApellido(string nombreOApellido)
        {
            try
            {
                using(DesafioContext db = new DesafioContext())
                {
                    var jugadores = db.Jugadores.Where(x => x.NombreCompleto().Contains(nombreOApellido));
                    if (jugadores != null)
                        return jugadores.ToList();
                    else
                        return new List<Jugador>();
                }
            }
            catch
            {
                return new List<Jugador>();
            }
        }
        public static int GetUltimoRankingSingle(int categoria)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    int? ultimoRanking = db.Jugadores.OrderByDescending(x => x.RankingSingle).FirstOrDefault().RankingSingle;
                    if (ultimoRanking != null)
                        return (int)ultimoRanking;
                    else
                        return 1;
                }
            }
            catch
            {
                return 1;
            }
        }
        public static void Update(Jugador j)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    db.Entry(j).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch
            {
                throw new Exception("Error al actualizar los datos - Verifiquelos por favor");
            }
        }
        public static void Delete(int Id)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    Jugador j = db.Jugadores.FirstOrDefault(x => x.JugadorId == Id);
                    if (j != null)
                    {
                        db.Jugadores.Remove(j);
                        db.SaveChanges();                        
                    }
                }
            }
            catch
            {
                throw new Exception("Error al Eliminar al Juagador - Verifique los datos");
            }
        }
        public static Jugador FindById(int Id)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    return db.Jugadores.FirstOrDefault(x => x.JugadorId == Id);                       
                }
            }
            catch
            {
                return null;
            }
        }
        /*public static List<Jugador> FindPorCategoria(int IdCategoria)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    var jugadores = db.Jugadores.Where(x => x.Categoria.Id == IdCategoria);
                    if (jugadores != null)
                        return jugadores.ToList();
                    else
                        return new List<Jugador>();
                             
                }
            }
            catch
            {
                return null;
            }
        }*/
        public static List<Jugador> FindDesafios(int rankingSingleJugador)
        {
            try
            {
                using(DesafioContext db = new DesafioContext())
                {
                    var jugaores = db.Jugadores.Where(x => x.RankingSingle >= rankingSingleJugador + 10);
                    if (jugaores != null)
                        return jugaores.ToList();
                    else
                        return new List<Jugador>();
                }
            }
            catch
            {
                return null;
            }
        }
        

        public static int CantidadDeJugadores()
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    return db.Jugadores.Count();
                }

            }
            catch
            {
                return -1;
            }
        }
        public static void PartialUpdate(Jugador j, int categoriaId)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    Jugador jugador = db.Jugadores.FirstOrDefault(x => x.Email == j.Email);
                    db.Entry(jugador).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar los datos - " + ex.Message);
            }
        }
        public static void CambioPassword(string Email, string Password)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    Jugador j = db.Jugadores.FirstOrDefault(x => x.Email == Email);
                    if (j != null)
                    {
                        j.Password = Password;
                        db.Entry(j).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar los datos -" + ex.Message);
            }
        }
        public static Jugador FindfByEmail(string Email)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    return db.Jugadores.FirstOrDefault(x => x.Email.ToLower() == Email.ToLower());                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar los datos -" + ex.Message);
            }            
        }
        public static List<Jugador> FindAll()
        {
            
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    var jugadores = db.Jugadores;
                    if (jugadores != null)
                        return jugadores.ToList();
                    else
                        return new List<Jugador>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar los datos -" + ex.Message);
            } 
        }

    }
}
