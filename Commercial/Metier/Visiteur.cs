using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using Utilitaires;
using Persistance;

namespace Metier
{
    public class Visiteur
    {

        private String id;
        private String prenom;
        private String nom;
        private String login;
        private String mdp;
        private String adresse;
        private String cp;
        private String ville;
        private DateTime dateEmbauche;
/// <summary>
/// Pour chaque champ, on définit une propmerty
/// </summary>
        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        // fields
       

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }

// <summary>
/// Constructeurs de la classe
/// </summary>

        public Visiteur(int hashCode, String id, String nom, String prenom,
                String login, String mdp, String adresse, String cp, String ville,
                DateTime dateEmbauche)
        {

            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.mdp = mdp;
            this.adresse = adresse;
            this.cp = cp;
            this.ville = ville;
            this.dateEmbauche = dateEmbauche;
        }

/// <summary>
/// Constructeur vide
/// </summary>
        public Visiteur()
        {        }

/// <summary>
// Lire un utilisateur sur son ID
//// </summary>
/// <param name="id_utilisateur">N° de l'utilisateur à lire</param>

        public bool Lire_Utilisateur(int id_utilisateur)
        {
            return true;

            /*String mysql;
            DataTable dt;
            sErreurs er = new sErreurs("Erreur sur recherche d'un article.", "Article.RechercheArticle()");
            try
            {

                mysql = "SELECT * ";
                mysql += "FROM VISITEUR ";
                mysql += "WHERE NO_UTILISATEUR = '" + id_utilisateur + "'";
                dt = DbInterface.Lecture(mysql, er);

                if (dt.IsInitialized)
                {
                    DataRow dataRow = dt.Rows[0];

                    this.no_article = dataRow[0].ToString();
                    this.lib_article = dataRow[1].ToString();
                    this.qte_dispo = dataRow[2].ToString();
                    this.ville_art = dataRow[3].ToString();
                    this.prix_art = dataRow[4].ToString();
                    this.interrompu = dataRow[5].ToString();

                    return this;
                }
                else
                    return null;
            }
            catch (MySqlException e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }*/

        }
  }
}