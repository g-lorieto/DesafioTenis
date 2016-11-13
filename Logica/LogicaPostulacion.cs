using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Persistencia;

namespace Logica
{
    public class LogicaPostulacion
    {
        public static void Add(Postulacion p, int postulanteId)
        {
            if (p == null)
                throw new Exception("Error al cargar el parido");
            else
            
                PersistenciaPostulacion.Add(p, postulanteId);
        }

        public static void Update(Postulacion p)
        {
            if (p == null)
                throw new Exception("Error al cargar el partido");
            else
                PersistenciaPostulacion.Update(p);
        }

        public static void Delete(int id)
        {
            PersistenciaPostulacion.Delete(id);
        }

        public static Postulacion FindbyId(int id)
        {
            return PersistenciaPostulacion.FindById(id);
        }
        public static List<Postulacion> FindByJugador(int id)
        {
            return PersistenciaPostulacion.FindByJugador(id);
           
        }
        public static List<Postulacion> FindAllOrdenadoPorFecha(int idJugadorExcluido)
        {
            return PersistenciaPostulacion.FindAllOrdenadasPorFecha(idJugadorExcluido);
        }
    }
}
