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
    public class DetailsCde
    {
        private Article art;
        private String qte_cdee;
        private String livree;
        private String total;

        /// <summary>
        /// Initialisation
        /// </summary>
        public DetailsCde()
        {
            art = new Article();
            total = qte_cdee = "0";
            livree = "F";
        }

        public Article Art
        {
            get { return art; }
            set { art = value; }
        }
        public String Qte_cdee
        {
            get { return qte_cdee; }
            set { qte_cdee = value; }
        }
        public String Livree
        {
            get { return livree; }
            set { livree = value; }
        }
        public String Total
        {
            get { return total; }
            set { total = value; }
        }

        /// <summary>
        /// Afficher la liste des articles de la commande
        /// </summary>
        /// <param name="no_cmd">numéro de la commande</param>
        /// <returns>liste de détails d'articles</returns>
        public List<DetailsCde> getLesDetails(String no_cmd)
        {
            DataTable dt;
            sErreurs err = new sErreurs("", "");
            //MySqlConnection cnx = Connexion.getInstance().getConnexion();

            String mysql = "SELECT A.NO_ARTICLE, A.LIB_ARTICLE, A.QTE_DISPO, A.VILLE_ART, A.PRIX_ART, A.INTERROMPU, D.QTE_CDEE, D.LIVREE, (A.PRIX_ART*D.QTE_CDEE) as TOTAL ";
            mysql += "FROM ARTICLES A, DETAIL_CDE D ";
            mysql += "WHERE A.NO_ARTICLE = D.NO_ARTICLE AND D.NO_COMMAND = '" + no_cmd + "'";
            try
            {
                dt = DbInterface.Lecture(mysql, err);
                List<DetailsCde> mesDetails = new List<DetailsCde>();
                foreach (DataRow dataRow in dt.Rows)
                {
                    DetailsCde detail = new DetailsCde();
                    detail.art.No_article = dataRow[0].ToString();
                    detail.art.Lib_article = dataRow[1].ToString();
                    detail.art.Qte_dispo = dataRow[2].ToString();
                    detail.art.Ville_art = dataRow[3].ToString();
                    detail.art.Prix_art = dataRow[4].ToString();
                    detail.art.Interrompu = dataRow[5].ToString();
                    detail.qte_cdee = dataRow[6].ToString();
                    detail.livree = dataRow[7].ToString();
                    detail.total = dataRow[8].ToString();

                    mesDetails.Add(detail);
                }
                return mesDetails;
            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }
    }
}
