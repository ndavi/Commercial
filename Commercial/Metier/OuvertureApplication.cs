using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using Persistance;
using Utilitaires;
using MesErreurs;

namespace Metier
{
    public class OuvertureApplication
    {
        /// <summary>
        /// Tentative de connexion à la base
        /// </summary>
        /// <returns></returns>
        static public bool getOuverture()
        {
            try
            {
                MySqlConnection mysqlcnx = Connexion.getInstance().getConnexion();
                return true;
            }
            catch (MonException excep)
            {
                throw excep;
            }
        }
    }
}