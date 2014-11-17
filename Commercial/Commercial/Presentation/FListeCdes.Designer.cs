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
            this.SuspendLayout();
            // 
            // lvcdes
            // 
            this.lvcdes.Location = new System.Drawing.Point(1, 0);
            this.lvcdes.Name = "lvcdes";
            this.lvcdes.Size = new System.Drawing.Size(633, 335);
            this.lvcdes.TabIndex = 0;
            this.lvcdes.UseCompatibleStateImageBehavior = false;
            // 
            // FListeCdes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 333);
            this.Controls.Add(this.lvcdes);
            this.Name = "FListeCdes";
            this.Text = "FListeCdes";
            this.Load += new System.EventHandler(this.FListeCdes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvcdes;
    }
}