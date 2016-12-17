using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Persistencia;

namespace Logica
{
    public class LogicaImagen
    {
        public static void Add(Imagen imagen)
        {
            PersistenciaImagen.Add(imagen);
        }
        public static void Delete(int id)
        {
            PersistenciaImagen.Delete(id);
        }

        public static List<Imagen> GetImagesByJugador(int idJugador)
        {
            return PersistenciaImagen.GetImagesByJugador(idJugador);
        }

    }
}
