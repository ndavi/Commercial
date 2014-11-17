using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilitaires;
using Metier;
using MesErreurs;


namespace Commercial.Presentation
{
    public partial class Fclient : Form
    {

        public Fclient()
        {
            InitializeComponent();

            //List<String> mesNumeros;
            Clientel unClient = new Clientel();
            try
            {
                /* Lecture classique
                cb_Client.DataSource = unClient.LectureNoClient();

                Clientel unClient = new Clientel();
                mesNumeros = unClient.LectureNoClient();
                foreach (String item in mesNumeros)
                {
                    cb_Client.Items.Add(item);
                }
                */

                // Lecture à partir d’un data source 
                cb_Client.DataSource = unClient.LectureNoClient();

            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }
        }


        private void cb_Client_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_interroger_Click(object sender, EventArgs e)
        {
            string numCli;
            Clientel unClient = new Clientel();
            Clientel unClientCherche;

            try
            {
                numCli = cb_Client.Text;
                unClientCherche = unClient.RechercheUnClient(numCli);
                LB_NOM.Text = "Nom : " + unClientCherche.NomCl;
                LB_PRENOM.Text = "Prénom : " + unClientCherche.PrenomCl;
                LB_SOCIETE.Text = "Societe : " + unClientCherche.Societe;
                LB_ADRESSE.Text = "Adresse : " + unClientCherche.AdresseCl;
                LB_VILLE.Text = "Ville : " + unClientCherche.VilleCl;
                LB_CP.Text = "Code Postal :" + unClientCherche.CodePostCl;

            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }
        }
    }
}