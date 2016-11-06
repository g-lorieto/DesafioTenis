using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Persistencia;

namespace Logica
{
    public static class LogicaCampeonato
    {
        public static void Add(Campeonato c)
        {
            PersistenciaCampeonato.Add(c);
        }
        public static void Update(Campeonato c)
        {
            PersistenciaCampeonato.Update(c);
        }
        public static void Delete(int IdCampeonato)
        {
            PersistenciaCampeonato.Delete(IdCampeonato);
        }
        public static Campeonato FindById(int IdCampeonato)
        {
            return PersistenciaCampeonato.FindById(IdCampeonato);
        }
    }
}
