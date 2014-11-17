namespace Commercial.Presentation
{
    partial class FAddCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_numCommande = new System.Windows.Forms.TextBox();
            this.btn_inserer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_numClient = new System.Windows.Forms.ComboBox();
            this.cb_numVendeur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insertion d\'une Commande";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro de commande";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numéro de client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de commande";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numéro de vendeur";
            // 
            // tb_numCommande
            // 
            this.tb_numCommande.Location = new System.Drawing.Point(204, 69);
            this.tb_numCommande.Name = "tb_numCommande";
            this.tb_numCommande.Size = new System.Drawing.Size(200, 20);
            this.tb_numCommande.TabIndex = 5;
            // 
            // btn_inserer
            // 
            this.btn_inserer.Location = new System.Drawing.Point(49, 266);
            this.btn_inserer.Name = "btn_inserer";
            this.btn_inserer.Size = new System.Drawing.Size(75, 23);
            this.btn_inserer.TabIndex = 9;
            this.btn_inserer.Text = "Insérer";
            this.btn_inserer.UseVisualStyleBackColor = true;
            this.btn_inserer.Click += new System.EventHandler(this.btn_inserer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // cb_numClient
            // 
            this.cb_numClient.FormattingEnabled = true;
            this.cb_numClient.Location = new System.Drawing.Point(204, 177);
            this.cb_numClient.Name = "cb_numClient";
            this.cb_numClient.Size = new System.Drawing.Size(200, 21);
            this.cb_numClient.TabIndex = 12;
            // 
            // cb_numVendeur
            // 
            this.cb_numVendeur.FormattingEnabled = true;
            this.cb_numVendeur.Location = new System.Drawing.Point(204, 222);
            this.cb_numVendeur.Name = "cb_numVendeur";
            this.cb_numVendeur.Size = new System.Drawing.Size(200, 21);
            this.cb_numVendeur.TabIndex = 13;
            // 
            // FAddCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 301);
            this.Controls.Add(this.cb_numVendeur);
            this.Controls.Add(this.cb_numClient);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_inserer);
            this.Controls.Add(this.tb_numCommande);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAddCommande";
            this.Text = "FAddClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_numCommande;
        private System.Windows.Forms.Button btn_inserer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cb_numClient;
        private System.Windows.Forms.ComboBox cb_numVendeur;
    }
}