using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;
using MesErreurs;
using System.Globalization;

namespace Commercial.Presentation
{
    public partial class FListeCdes : Form
    {
        public FListeCdes()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            lvcdes.Items.Clear();
            lvcdes.View = View.Details;
            lvcdes.Columns.Add("Numéro", 100,HorizontalAlignment.Left);
            lvcdes.Columns.Add("Numéro Vendeur", 100, HorizontalAlignment.Left);
            lvcdes.Columns.Add("Numéro Client", 100, HorizontalAlignment.Left);
            lvcdes.Columns.Add("Date Commande", 100, HorizontalAlignment.Left);
            lvcdes.Columns.Add("Facture", 100, HorizontalAlignment.Left);
            this.AfficherListe();
        }

        private void FListeCdes_Load(object sender, EventArgs e)
        {

        }
        private void AfficherListe()
        {
            Commande unecommande = new Commande();
            List<Commande> mesCommandes;
            string numCde, numVend, NumCli, facture, datecde;
            ListViewItem lvitem_cde;

            lvcdes.Items.Clear();
            lvcdes.Columns.Clear();
            lvcdes.View = View.Details;
            lvcdes.Columns.Add("1", "Numéro");
            lvcdes.Columns.Add("2", "Numéro Vendeur");
            lvcdes.Columns.Add("3", "Numéro Client");
            lvcdes.Columns.Add("4", "Date Commande");
            lvcdes.Columns.Add("5", "Facture"); 
          try
          {
              mesCommandes = unecommande.getLesCommandes();
            
            foreach (Commande c in mesCommandes)
            {

                numCde = c.NoCommande;
                // On récupère la property NoVendeur
                numVend = c.Vendeur.NoVendeur;
                NumCli = c.Client.NoCl;
                datecde = c.DateCommande.ToShortDateString();
                facture = c.Facture;
                lvitem_cde = new ListViewItem(new string[] { numCde, numVend, NumCli, datecde, facture }, -1, Color.Black, Color.LightGreen, null);
                lvcdes.Items.Add(lvitem_cde);
            }

           if (!numCheck.Checked) lvcdes.Columns.RemoveByKey("1");
            if (!numVenCheck.Checked) lvcdes.Columns.RemoveByKey("2");
            if (!numCliCheck.Checked) lvcdes.Columns.RemoveByKey("3");
            if (!dateCmdCheck.Checked) lvcdes.Columns.RemoveByKey("4");
            if (!factureCheck.Checked) lvcdes.Columns.RemoveByKey("5");

            lvcdes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
          }
          catch (MonException erreur)
          {
              throw erreur;
          }
        }

        private void numCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficherListe();
        }

        private void numVenCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficherListe();
        }

        private void numCliCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficherListe();
        }

        private void dateCmdCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficherListe();
        }

        private void factureCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficherListe();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FAddCommande fAdd = new FAddCommande();
            fAdd.ShowDialog();
        }
    }
}
