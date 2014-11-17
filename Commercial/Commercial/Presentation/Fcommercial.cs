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

namespace Commercial.Presentation
{
    public partial class Fcommercial : Form
    {
        public Fcommercial()
        {
            InitializeComponent();
        }

        private void Fcommercial_Load(object sender, EventArgs e)
        {
            try
            {
                bool rep;
                // on connecte l'application à la base de données
                rep = OuvertureApplication.getOuverture();
                // si la connexion a réussie : on active les menus
                if (rep)
                {

                    interrogerToolStripMenuItem.Enabled = true;
                    gérerToolStripMenuItem.Enabled = true;

                    lbl_etat.Text = "Etat : en ligne";
                    lbl_etat.ForeColor = Color.DarkGreen;
                }
                // sinon on désactive les menus
                else
                {
                    Close();
                    /*interrogerToolStripMenuItem.Enabled = false;
                    gérerToolStripMenuItem.Enabled = false;

                    lbl_etat.Text = "Etat : hors ligne - erreur de connexion";
                    lbl_etat.ForeColor = Color.Red;*/
                }
            }
            catch (MonException excep)
            {
                MessageBox.Show(excep.MessageSysteme(), "Erreur de connexion");
                interrogerToolStripMenuItem.Enabled = false;
                gérerToolStripMenuItem.Enabled = false;
                lbl_etat.Text = excep.MessageSysteme();
                lbl_etat.ForeColor = Color.Red;
            }
        }

        private void ficheClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fclient fc;

            fc = new Fclient();
            fc.ShowDialog();
        }

        private void listeCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FListeCdes fcdes = new FListeCdes();
            fcdes.ShowDialog();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FListeCdes fcdes = new FListeCdes();
            fcdes.ShowDialog();
        }
    }
}
