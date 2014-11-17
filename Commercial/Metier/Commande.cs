/*
 * THIBAULT LAZERT P1003011
 * UE ISI Polytech'Lyon
 * semestre automne 2012
 * 
 * Application gestion commerciale
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using Utilitaires;
using Persistance;
using MesErreurs;


namespace Metier
{
    public class Commande
    {
        private Clientel client;
        private String noCommande;
        private DateTime dateCommande;
        private String facture;
        private Vendeur vendeur;


        public String NoCommande
        {
            get { return noCommande; }
            set { noCommande = value; }
        }
        public Vendeur Vendeur
        {
            get { return vendeur; }
            set { vendeur = value; }
        }
        public Clientel Client
        {
            get { return client; }
            set { client = value; }
        }
        public DateTime DateCommande
        {
            get { return dateCommande; }
            set { dateCommande = value; }
        }
        public String Facture
        {
            get { return facture; }
            set { facture = value; }
        }

        /// <summary>
        /// Initialisation
        /// </summary>
        public Commande()
        {
            noCommande = "";
            facture = "";
            vendeur = new Vendeur();
            client = new Clientel();
            dateCommande = DateTime.Today;
        }

        /// <summary>
        /// Initialisation avec les paramètres
        /// </summary>
        public Commande(String noC, DateTime dateC, String factC, Vendeur ven, Clientel cli)
        {
            noCommande = noC;
            dateCommande = dateC;
            facture = factC;
            vendeur = ven;
            client = cli;
        }

        /// <summary>
        /// Lister les commandes de la base
        /// </summary>
        /// <param name="tri">champ de tri</param>
        /// <param name="ordre">sens du tri</param>
        /// <returns>Liste de commandes</returns>
        public List<Commande> getLesCommandes(String tri = "NO_COMMAND", String ordre = "ASC")
	    {
	        DataTable dt;
            sErreurs err = new sErreurs("","");
            //MySqlConnection cnx = Connexion.getInstance().getConnexion();

	        String mysql = "SELECT NO_COMMAND, NO_VENDEUR, NO_CLIENT, DATE_CDE, FACTURE ";
	        mysql += "FROM COMMANDES ";
            mysql += "ORDER BY " + tri + " " + ordre;
	        try
	        {
                dt = DbInterface.Lecture(mysql, err);
	            List<Commande> mesCdes = new List<Commande> ();
	            foreach (DataRow dataRow in dt.Rows)
	            {
	                Vendeur unvd = new Vendeur();
	                unvd = unvd.RechercheUnVendeur(dataRow[1].ToString());
	                Clientel uncli = new Clientel();
                    uncli = uncli.RechercheUnClient(dataRow[2].ToString());
	                Commande unecde = new Commande(dataRow[0].ToString(),
	                                                ((DateTime)dataRow[3]),
	                                                dataRow[4].ToString(),unvd,uncli);                              
	                mesCdes.Add(unecde);
	            }
	            return mesCdes;
	        }
	        catch (MonException erreur)
	        {
	            throw erreur;
	        }
	    }

        /// <summary>
        /// Supprimer une commande avec son id
        /// </summary>
        /// <param name="idCommande">numéro de la commande</param>
        public void supprimerCommande(String idCommande)
        {
            DataTable dt;
            sErreurs err = new sErreurs("", "");

            String mysql;
            try
            {
                // supprimer les détails de la commande
                mysql = "DELETE FROM DETAIL_CDE WHERE NO_COMMAND = " + idCommande;
                dt = DbInterface.Lecture(mysql, err);

                // supprimer la commande elle-même
                mysql = "DELETE FROM COMMANDES WHERE NO_COMMAND = " + idCommande + " LIMIT 1";
                dt = DbInterface.Lecture(mysql, err);      
            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }

        /// <summary>
        /// Ajouter la commande courante dans la base de données
        /// </summary>
        public void ajouterCommande()
        {
            DataTable dt;
            sErreurs err = new sErreurs("", "");

            String mysql;
            try
            {
                // enregistrer la commande
                mysql = "INSERT INTO COMMANDES (NO_COMMAND, NO_VENDEUR, NO_CLIENT, DATE_CDE, FACTURE) VALUES ('";
                mysql += this.NoCommande;
                mysql += "', '";
                mysql += this.Vendeur.NoVendeur;
                mysql += "', '";
                mysql += this.Client.NoCl;
                mysql += "', '";
                mysql += Fonctions.DateToString(DateCommande);
                mysql += "', '";
                mysql += this.Facture;
                mysql += "');";
                dt = DbInterface.Lecture(mysql, err);

            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }

        /// <summary>
        /// Modifier les informations de la commande courante dans la base de données
        /// </summary>
        public void modifierCommande()
        {
            DataTable dt;
            sErreurs err = new sErreurs("", "");

            String mysql;
            try
            {
                // actualiser les infoamtions dans la base
                mysql = "UPDATE COMMANDES SET NO_VENDEUR = '";
                mysql += this.Vendeur.NoVendeur;
                mysql += "', NO_CLIENT = '";
                mysql += this.Client.NoCl;
                mysql += "', DATE_CDE = '";
                mysql += Fonctions.DateToString(DateCommande);
                mysql += "', FACTURE = '";
                mysql += this.Facture;
                mysql += "' WHERE NO_COMMAND = '"+this.noCommande+"';";
                dt = DbInterface.Lecture(mysql, err);

            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }

        /// <summary>
        /// Rechercher une commande d'après son numéro
        /// </summary>
        /// <param name="no_cmd">Numéro de la commande</param>
        /// <returns>Commande courante</returns>
        public Commande RechercheCommande(String no_cmd)
        {

            String mysql;
            DataTable dt;
            sErreurs er = new sErreurs("Erreur sur recherche d'une commande.", "Commande.RechercheCommande()");
            try
            {

                mysql = "SELECT NO_COMMAND, NO_VENDEUR, NO_CLIENT, DATE_CDE, FACTURE ";
                mysql += "FROM COMMANDES ";
                mysql += "WHERE NO_COMMAND = '" + no_cmd + "'";
                dt = DbInterface.Lecture(mysql, er);

                if (dt.IsInitialized)
                {
                    DataRow dataRow = dt.Rows[0];
                    Vendeur unvd = new Vendeur();
                    unvd = unvd.RechercheUnVendeur(dataRow[1].ToString());
                    this.vendeur = unvd;
                    Clientel uncli = new Clientel();
                    uncli = uncli.RechercheUnClient(dataRow[2].ToString());
                    this.client = uncli;
                    this.noCommande = dataRow[0].ToString();
                    this.dateCommande = ((DateTime)dataRow[3]);
                    this.facture = dataRow[4].ToString();

                    return this;
                }
                else
                    return null;
            }
            catch (MySqlException e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }

        /// <summary>
        /// Détermine si un numéro de commande est libre ou déjà utilisé
        /// </summary>
        /// <param name="no">numéro de commande</param>
        /// <returns>booléen</returns>
        public bool NumeroLibre(String no)
        {
            List<Commande> tous = getLesCommandes();
            foreach (Commande cmd in tous)
                if (cmd.noCommande == no)
                    return false;
            return true;
        }
        
    }
}
