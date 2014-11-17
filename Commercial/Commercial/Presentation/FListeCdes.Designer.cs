namespace Commercial.Presentation
{
    partial class FListeCdes
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
            this.lvcdes = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.numCheck = new System.Windows.Forms.CheckBox();
            this.numVenCheck = new System.Windows.Forms.CheckBox();
            this.numCliCheck = new System.Windows.Forms.CheckBox();
            this.dateCmdCheck = new System.Windows.Forms.CheckBox();
            this.factureCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvcdes
            // 
            this.lvcdes.Location = new System.Drawing.Point(1, 38);
            this.lvcdes.Name = "lvcdes";
            this.lvcdes.Size = new System.Drawing.Size(633, 246);
            this.lvcdes.TabIndex = 0;
            this.lvcdes.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtres : ";
            // 
            // numCheck
            // 
            this.numCheck.AutoSize = true;
            this.numCheck.Checked = true;
            this.numCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numCheck.Location = new System.Drawing.Point(58, 12);
            this.numCheck.Name = "numCheck";
            this.numCheck.Size = new System.Drawing.Size(63, 17);
            this.numCheck.TabIndex = 2;
            this.numCheck.Text = "Numéro";
            this.numCheck.UseVisualStyleBackColor = true;
            this.numCheck.CheckedChanged += new System.EventHandler(this.numCheck_CheckedChanged);
            // 
            // numVenCheck
            // 
            this.numVenCheck.AutoSize = true;
            this.numVenCheck.Checked = true;
            this.numVenCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numVenCheck.Location = new System.Drawing.Point(127, 12);
            this.numVenCheck.Name = "numVenCheck";
            this.numVenCheck.Size = new System.Drawing.Size(106, 17);
            this.numVenCheck.TabIndex = 3;
            this.numVenCheck.Text = "Numéro Vendeur";
            this.numVenCheck.UseVisualStyleBackColor = true;
            this.numVenCheck.CheckedChanged += new System.EventHandler(this.numVenCheck_CheckedChanged);
            // 
            // numCliCheck
            // 
            this.numCliCheck.AutoSize = true;
            this.numCliCheck.Checked = true;
            this.numCliCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numCliCheck.Location = new System.Drawing.Point(239, 12);
            this.numCliCheck.Name = "numCliCheck";
            this.numCliCheck.Size = new System.Drawing.Size(92, 17);
            this.numCliCheck.TabIndex = 4;
            this.numCliCheck.Text = "Numéro Client";
            this.numCliCheck.UseVisualStyleBackColor = true;
            this.numCliCheck.CheckedChanged += new System.EventHandler(this.numCliCheck_CheckedChanged);
            // 
            // dateCmdCheck
            // 
            this.dateCmdCheck.AutoSize = true;
            this.dateCmdCheck.Checked = true;
            this.dateCmdCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dateCmdCheck.Location = new System.Drawing.Point(337, 12);
            this.dateCmdCheck.Name = "dateCmdCheck";
            this.dateCmdCheck.Size = new System.Drawing.Size(105, 17);
            this.dateCmdCheck.TabIndex = 5;
            this.dateCmdCheck.Text = "Date Commande";
            this.dateCmdCheck.UseVisualStyleBackColor = true;
            this.dateCmdCheck.CheckedChanged += new System.EventHandler(this.dateCmdCheck_CheckedChanged);
            // 
            // factureCheck
            // 
            this.factureCheck.AutoSize = true;
            this.factureCheck.Checked = true;
            this.factureCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.factureCheck.Location = new System.Drawing.Point(448, 12);
            this.factureCheck.Name = "factureCheck";
            this.factureCheck.Size = new System.Drawing.Size(62, 17);
            this.factureCheck.TabIndex = 6;
            this.factureCheck.Text = "Facture";
            this.factureCheck.UseVisualStyleBackColor = true;
            this.factureCheck.CheckedChanged += new System.EventHandler(this.factureCheck_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Filtrer par date";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ajouter Commande";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Modifier Commande";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(281, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Supprimer Commande";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(421, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Détail Commande";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FListeCdes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 333);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.factureCheck);
            this.Controls.Add(this.dateCmdCheck);
            this.Controls.Add(this.numCliCheck);
            this.Controls.Add(this.numVenCheck);
            this.Controls.Add(this.numCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvcdes);
            this.Name = "FListeCdes";
            this.Text = "FListeCdes";
            this.Load += new System.EventHandler(this.FListeCdes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvcdes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox numCheck;
        private System.Windows.Forms.CheckBox numVenCheck;
        private System.Windows.Forms.CheckBox numCliCheck;
        private System.Windows.Forms.CheckBox dateCmdCheck;
        private System.Windows.Forms.CheckBox factureCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}