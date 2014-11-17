namespace Commercial.Presentation
{
    partial class Fclient
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
            this.cb_Client = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LB_NOM = new System.Windows.Forms.Label();
            this.LB_VILLE = new System.Windows.Forms.Label();
            this.LB_SOCIETE = new System.Windows.Forms.Label();
            this.LB_PRENOM = new System.Windows.Forms.Label();
            this.LB_ADRESSE = new System.Windows.Forms.Label();
            this.LB_CP = new System.Windows.Forms.Label();
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.btn_interroger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informations sur un CLIENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client : ";
            // 
            // cb_Client
            // 
            this.cb_Client.FormattingEnabled = true;
            this.cb_Client.Location = new System.Drawing.Point(255, 72);
            this.cb_Client.Name = "cb_Client";
            this.cb_Client.Size = new System.Drawing.Size(121, 21);
            this.cb_Client.TabIndex = 2;
            this.cb_Client.SelectedIndexChanged += new System.EventHandler(this.cb_Client_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Societe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adresse :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ville :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Code postal :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Prénom :";
            // 
            // LB_NOM
            // 
            this.LB_NOM.AutoSize = true;
            this.LB_NOM.Location = new System.Drawing.Point(90, 111);
            this.LB_NOM.Name = "LB_NOM";
            this.LB_NOM.Size = new System.Drawing.Size(0, 13);
            this.LB_NOM.TabIndex = 9;
            // 
            // LB_VILLE
            // 
            this.LB_VILLE.AutoSize = true;
            this.LB_VILLE.Location = new System.Drawing.Point(90, 207);
            this.LB_VILLE.Name = "LB_VILLE";
            this.LB_VILLE.Size = new System.Drawing.Size(0, 13);
            this.LB_VILLE.TabIndex = 10;
            // 
            // LB_SOCIETE
            // 
            this.LB_SOCIETE.AutoSize = true;
            this.LB_SOCIETE.Location = new System.Drawing.Point(90, 159);
            this.LB_SOCIETE.Name = "LB_SOCIETE";
            this.LB_SOCIETE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_SOCIETE.Size = new System.Drawing.Size(0, 13);
            this.LB_SOCIETE.TabIndex = 11;
            // 
            // LB_PRENOM
            // 
            this.LB_PRENOM.AutoSize = true;
            this.LB_PRENOM.Location = new System.Drawing.Point(90, 135);
            this.LB_PRENOM.Name = "LB_PRENOM";
            this.LB_PRENOM.Size = new System.Drawing.Size(0, 13);
            this.LB_PRENOM.TabIndex = 12;
            // 
            // LB_ADRESSE
            // 
            this.LB_ADRESSE.AutoSize = true;
            this.LB_ADRESSE.Location = new System.Drawing.Point(90, 182);
            this.LB_ADRESSE.Name = "LB_ADRESSE";
            this.LB_ADRESSE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_ADRESSE.Size = new System.Drawing.Size(0, 13);
            this.LB_ADRESSE.TabIndex = 13;
            // 
            // LB_CP
            // 
            this.LB_CP.AutoSize = true;
            this.LB_CP.Location = new System.Drawing.Point(110, 232);
            this.LB_CP.Name = "LB_CP";
            this.LB_CP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_CP.Size = new System.Drawing.Size(0, 13);
            this.LB_CP.TabIndex = 14;
            // 
            // btn_Fermer
            // 
            this.btn_Fermer.Location = new System.Drawing.Point(427, 46);
            this.btn_Fermer.Name = "btn_Fermer";
            this.btn_Fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_Fermer.TabIndex = 15;
            this.btn_Fermer.Text = "Fermer";
            this.btn_Fermer.UseVisualStyleBackColor = true;
            this.btn_Fermer.Click += new System.EventHandler(this.btn_Fermer_Click);
            // 
            // btn_interroger
            // 
            this.btn_interroger.Location = new System.Drawing.Point(427, 100);
            this.btn_interroger.Name = "btn_interroger";
            this.btn_interroger.Size = new System.Drawing.Size(75, 23);
            this.btn_interroger.TabIndex = 16;
            this.btn_interroger.Text = "Interroger";
            this.btn_interroger.UseVisualStyleBackColor = true;
            this.btn_interroger.Click += new System.EventHandler(this.btn_interroger_Click);
            // 
            // Fclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 273);
            this.Controls.Add(this.btn_interroger);
            this.Controls.Add(this.btn_Fermer);
            this.Controls.Add(this.LB_CP);
            this.Controls.Add(this.LB_ADRESSE);
            this.Controls.Add(this.LB_PRENOM);
            this.Controls.Add(this.LB_SOCIETE);
            this.Controls.Add(this.LB_VILLE);
            this.Controls.Add(this.LB_NOM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Client);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fclient";
            this.Text = "Fclient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LB_NOM;
        private System.Windows.Forms.Label LB_VILLE;
        private System.Windows.Forms.Label LB_SOCIETE;
        private System.Windows.Forms.Label LB_PRENOM;
        private System.Windows.Forms.Label LB_ADRESSE;
        private System.Windows.Forms.Label LB_CP;
        private System.Windows.Forms.Button btn_Fermer;
        private System.Windows.Forms.Button btn_interroger;
    }
}