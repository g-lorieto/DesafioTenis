using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Persistencia;

namespace Logica
{
    public class LogicaMensaje
    {
        public void Add(Mensaje mensaje)
        {
            PersistenciaMensaje.Add(mensaje);
        }
        public void Delete(int idMensaje)
        {
            PersistenciaMensaje.Delete(idMensaje);
        }
 
        public List<Mensaje> FindByJugador(int idJugador)
        {
            return PersistenciaMensaje.FindByJugador(idJugador);
        }

    }
}
