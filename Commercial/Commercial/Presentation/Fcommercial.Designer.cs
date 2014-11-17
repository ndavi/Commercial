namespace Commercial.Presentation
{
    partial class Fcommercial
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interrogerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheVendeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeArticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.augmenterdiminuerLesPrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_etat = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.interrogerToolStripMenuItem,
            this.gérerToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // interrogerToolStripMenuItem
            // 
            this.interrogerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheClientToolStripMenuItem,
            this.ficheVendeurToolStripMenuItem,
            this.listeCommandesToolStripMenuItem,
            this.listeArticlesToolStripMenuItem});
            this.interrogerToolStripMenuItem.Name = "interrogerToolStripMenuItem";
            this.interrogerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.interrogerToolStripMenuItem.Text = "Interroger";
            // 
            // ficheClientToolStripMenuItem
            // 
            this.ficheClientToolStripMenuItem.Name = "ficheClientToolStripMenuItem";
            this.ficheClientToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ficheClientToolStripMenuItem.Text = "Fiche Client";
            this.ficheClientToolStripMenuItem.Click += new System.EventHandler(this.ficheClientToolStripMenuItem_Click);
            // 
            // ficheVendeurToolStripMenuItem
            // 
            this.ficheVendeurToolStripMenuItem.Name = "ficheVendeurToolStripMenuItem";
            this.ficheVendeurToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ficheVendeurToolStripMenuItem.Text = "Fiche Vendeur";
            // 
            // listeCommandesToolStripMenuItem
            // 
            this.listeCommandesToolStripMenuItem.Name = "listeCommandesToolStripMenuItem";
            this.listeCommandesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.listeCommandesToolStripMenuItem.Text = "Liste commandes";
            this.listeCommandesToolStripMenuItem.Click += new System.EventHandler(this.listeCommandesToolStripMenuItem_Click);
            // 
            // listeArticlesToolStripMenuItem
            // 
            this.listeArticlesToolStripMenuItem.Name = "listeArticlesToolStripMenuItem";
            this.listeArticlesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.listeArticlesToolStripMenuItem.Text = "Liste articles";
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesCommandesToolStripMenuItem,
            this.augmenterdiminuerLesPrixToolStripMenuItem});
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.gérerToolStripMenuItem.Text = "Gérer";
            // 
            // gestionDesCommandesToolStripMenuItem
            // 
            this.gestionDesCommandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.gestionDesCommandesToolStripMenuItem.Name = "gestionDesCommandesToolStripMenuItem";
            this.gestionDesCommandesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.gestionDesCommandesToolStripMenuItem.Text = "Gestion des commandes";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // augmenterdiminuerLesPrixToolStripMenuItem
            // 
            this.augmenterdiminuerLesPrixToolStripMenuItem.Name = "augmenterdiminuerLesPrixToolStripMenuItem";
            this.augmenterdiminuerLesPrixToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.augmenterdiminuerLesPrixToolStripMenuItem.Text = "Augmenter/diminuer les prix";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_etat);
            this.groupBox1.Location = new System.Drawing.Point(0, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 31);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lbl_etat
            // 
            this.lbl_etat.AutoSize = true;
            this.lbl_etat.Location = new System.Drawing.Point(7, 12);
            this.lbl_etat.Name = "lbl_etat";
            this.lbl_etat.Size = new System.Drawing.Size(41, 13);
            this.lbl_etat.TabIndex = 0;
            this.lbl_etat.Text = "lbl_etat";
            // 
            // Fcommercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fcommercial";
            this.Text = "Application commerciale";
            this.Load += new System.EventHandler(this.Fcommercial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interrogerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheVendeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeArticlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem augmenterdiminuerLesPrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_etat;
    }
}

