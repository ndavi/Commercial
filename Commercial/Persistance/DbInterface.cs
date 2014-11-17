using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MesErreurs;
using Persistance;


namespace Persistance
{

    public abstract class DbInterface
    {

        /// <summary>
        /// Exécution de la requête demandée en paramètre, req, 
        /// et retour du resultat : un DataTable
        /// Si tout se passe bien la connexion est prête à être fermée
        /// par le client qui utilisera cette connexion
        /// </summary>
        /// <param name="req">RequêteMySql à exécuter</param>
        /// <returns></returns>
        public static DataTable Lecture(String req, sErreurs er)
        {
            MySqlConnection cnx = null;
            try
            {
               ///
               /// on récupère l'instance courante de la classe
               //
                cnx = Connexion.getInstance().getConnexion();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = req;
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;

                // Construire le DataSet
                DataSet ds = new DataSet();
                da.Fill(ds, "resultat");
                cnx.Close();

                // Retourner la table
                return (ds.Tables["resultat"]);
            }
            catch (MonException me)
            {
                throw (me);
            }
            catch (Exception e)
            {

                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
            finally
            {
                // S'il y a eu un problème, la connexion
                // peut être encore ouverte, dans ce cas
                // il faut la fermer.                 
                if (cnx != null)
                    cnx.Close();
            }
        }



        /// <summary>
        /// Exécution d'une requête de mise à jour : INSERT, UPDATE, DELETE
        /// La connexion est systématiquement fermée après exécution
        /// </summary>
        /// <param name="req">RequêteMySql à exécuter</param>
        public static void Ecriture(String req, sErreurs er)
        {
            MySqlConnection cnx = null;
            try
            {
                cnx = Connexion.getInstance().getConnexion();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
            }
            catch (MonException me)
            {
                throw me;
            }
catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
            finally
            {
                // Fermer systématiquement la connexion               
                if (cnx != null)
                    cnx.Close();
            }
        }


        /// <summary>
        /// Exécution d'une procédure stockée. Dans la requête, les paramètres
        /// sont passés dans un ArrayList dont chaque occurrence est un tableau
        /// de 2 string (nom_paramètre, valeur)
        /// </summary>
        /// <param name="procedure">Nom de la procédure stockée à appeler</param>
        /// <param name="alParams">Paramètres à passer à la procédure stockée</param>
        public static void Procedure_Stockee(String procedure, ArrayList alParams, sErreurs er)
        {
            MySqlConnection cnx = null;
            int i, nbligne;
            string[] alContenu;
            try
            {
                cnx = Connexion.getInstance().getConnexion();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = procedure;
                nbligne = alParams.Count;
                for (i = 0; i < nbligne; i++)
                {
                    alContenu = alParams[i].ToString().Split(';');
                    cmd.Parameters.AddWithValue(alContenu[0], alContenu[1]);
                }
                cmd.Connection = cnx;
                cmd.ExecuteNonQuery();
            }
            catch (MonException me)
            {
                throw me;
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
            finally
            {
                // Fermer systématiquement la connexion               
                if (cnx != null)
                    cnx.Close();
            }
        }

        /// <summary>
        /// Toutes les écritures (une ou plusieurs tables impactées)
        /// s'exécutent dans une transaction
        /// La ArrayList fournit une liste de requêtes ( 1 à n) qui
        /// s'exécuteront dans la même transaction.
        /// Si une des requêtes requiert d'aller incrémenter un des paramètres
        /// de la table PARAMETRE (Dernier N) candidat, Dernier N° classe ...)
        /// ce n° est passé par nopar.
        /// /// Important : comme il n'y a qu'un seul nopar, il ne peut y avoir qu'une seule
        /// requête d'insertion dans la liste des requêtes à exécuter.
        /// </summary>
        /// <param name="reqs">Liste des requêtes à exécuter</param>
        /// <param name="nopar">N° du paramètre à incrémenter</param>
        /// <returns></returns>
        public static long db_Transaction(ArrayList reqs, string nopar, sErreurs er)
        {
            MySqlConnection cnx = null;
            MySqlTransaction maTransaction = null;
            string requete;
            long numpar = 0;
            try
            {
                // Obtenir une connexion
                cnx = Connexion.getInstance().getConnexion();

                // Récupérer la valeur de la clé primaire de la table
                // impliquée dans l'insertion
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                maTransaction = cnx.BeginTransaction();
                cmd.Transaction = maTransaction;
                if (nopar != "")
                {
                    cmd.CommandText = "inc_parametre";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("numpar", nopar);
                    MySqlParameter myParm = cmd.Parameters.AddWithValue("valeur", System.Data.SqlDbType.BigInt);
                    myParm.Direction = System.Data.ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    numpar = Int32.Parse(cmd.Parameters["valeur"].Value.ToString());
                }
                // Effectuer l'insertion proprement dite
                cmd.CommandType = System.Data.CommandType.Text;
                foreach (String req in reqs)
                {
                    // remplacer si nécessaire :NOPAR par sa valeur
                    // dans chacune des requêtes d'insertion
                    if (nopar != "")
                        requete = req.Replace(":nopar", numpar.ToString());
                    else
                        requete = req;
                    cmd.CommandText = requete;
                    cmd.ExecuteNonQuery();
                }
                maTransaction.Commit();
                return (numpar);
            }
            catch (MonException me)
            {
                throw me;
            }
            catch (Exception e)
            {
                maTransaction.Rollback();
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
            finally
            {
                // Fermer systématiquement la connexion               
                if (cnx != null)
                    cnx.Close();
 }
        }
    }
}