using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;
using System.Data.Entity;

namespace Persistencia
{
    public class PersistenciaCampeonato
    {
        public static void Add(Campeonato C)
        {
            using(DesafioContext db = new DesafioContext())
            {
                if (!db.Campeonatos.Contains(C))
                {
                    db.Campeonatos.Add(C);
                    db.SaveChanges();
                }
            }
        }
        public static void Update(Campeonato c)
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
                    Campeonato c = db.Campeonatos.FirstOrDefault(x => x.CampeonatoId == id);
                    if (c != null)
                    {
                        db.Campeonatos.Remove(c);
                        db.SaveChanges();
                    }
                }
            }
            catch
            {
                throw new Exception("Error al Eliminar - Verifique los datos");
            }
        }
        public static Campeonato FindById(int id)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    return db.Campeonatos.FirstOrDefault(x => x.CampeonatoId == id);
                }
            }
            catch
            {
                throw new Exception("Error al Eliminar - Verifique los datos");
            }
        }

    }
}
