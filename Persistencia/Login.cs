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


namespace Persistencia
{
    public static class Login
    {

        public static Jugador Logueo(string pEmail, string pPassword)
        {
            try
            {
                using (DesafioContext db = new DesafioContext())
                {
                    return db.Jugadores.FirstOrDefault(x => x.Email == pEmail && x.Password == pPassword);
                }               
            }
            catch (Exception ex)
            {
                throw new Exception("Problemas con la conexion a la base de datos");
            }

        }

  


    }
}

