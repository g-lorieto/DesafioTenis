using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Persistencia;

namespace Logica
{
    public static class LogicaComentario
    {
        public static void Add(Comentario c, int comentadoId, int partidoId, bool? gano)
        {
            PersistenciaComentario.Add(c, comentadoId, partidoId, gano);
        }
        public static void Update(Comentario c)
        {
            PersistenciaComentario.Update(c);
        }
        public static void Delete(int IdComentario)
        {
            PersistenciaComentario.Delete(IdComentario);
        }
        public static Comentario FindById(int IdComentario)
        {
            return PersistenciaComentario.FindById(IdComentario);
        }
        public static List<Comentario> FindByJugador(int IdJugador)
        {
            return PersistenciaComentario.FindByJugador(IdJugador);
        }
       
        public static List<Comentario> FindAll()
        {
            return PersistenciaComentario.FindAll();
        }
    }
}
