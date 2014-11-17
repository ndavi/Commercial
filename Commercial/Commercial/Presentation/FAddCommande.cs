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

namespace Commercial.Presentation
{
    public partial class FAddCommande : Form
    {
        public FAddCommande()
        {
            InitializeComponent();
            Clientel unClient = new Clientel();
            cb_numClient.DataSource = unClient.LectureNoClient();
            Vendeur unVendeur = new Vendeur();
            cb_numVendeur.DataSource = unVendeur.LectureNoVendeur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_inserer_Click(object sender, EventArgs e)
        {

        }
    }
}
