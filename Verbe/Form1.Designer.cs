namespace Verbe
{
    partial class Form1
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
            this.cbTemps = new System.Windows.Forms.ComboBox();
            this.cbPersonne = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTemps = new System.Windows.Forms.Label();
            this.lblPersonne = new System.Windows.Forms.Label();
            this.lblVerbe = new System.Windows.Forms.Label();
            this.btnAleatoire = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.cbVerbe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbTemps
            // 
            this.cbTemps.FormattingEnabled = true;
            this.cbTemps.Items.AddRange(new object[] {
            "Présent Indicatif",
            "Présent Impératif"});
            this.cbTemps.Location = new System.Drawing.Point(117, 72);
            this.cbTemps.Name = "cbTemps";
            this.cbTemps.Size = new System.Drawing.Size(121, 21);
            this.cbTemps.TabIndex = 1;
            // 
            // cbPersonne
            // 
            this.cbPersonne.FormattingEnabled = true;
            this.cbPersonne.Items.AddRange(new object[] {
            "Je",
            "Tu",
            "Il/Elle/On",
            "Nous",
            "Vous",
            "Ils/Elles/Ont"});
            this.cbPersonne.Location = new System.Drawing.Point(117, 131);
            this.cbPersonne.Name = "cbPersonne";
            this.cbPersonne.Size = new System.Drawing.Size(121, 21);
            this.cbPersonne.TabIndex = 2;
            this.cbPersonne.SelectedIndexChanged += new System.EventHandler(this.cbPersonne_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // lblTemps
            // 
            this.lblTemps.AutoSize = true;
            this.lblTemps.Location = new System.Drawing.Point(18, 72);
            this.lblTemps.Name = "lblTemps";
            this.lblTemps.Size = new System.Drawing.Size(45, 13);
            this.lblTemps.TabIndex = 4;
            this.lblTemps.Text = "Temps :";
            this.lblTemps.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPersonne
            // 
            this.lblPersonne.AutoSize = true;
            this.lblPersonne.Location = new System.Drawing.Point(18, 134);
            this.lblPersonne.Name = "lblPersonne";
            this.lblPersonne.Size = new System.Drawing.Size(58, 13);
            this.lblPersonne.TabIndex = 5;
            this.lblPersonne.Text = "Personne :";
            // 
            // lblVerbe
            // 
            this.lblVerbe.AutoSize = true;
            this.lblVerbe.Location = new System.Drawing.Point(18, 16);
            this.lblVerbe.Name = "lblVerbe";
            this.lblVerbe.Size = new System.Drawing.Size(41, 13);
            this.lblVerbe.TabIndex = 6;
            this.lblVerbe.Text = "Verbe :";
            // 
            // btnAleatoire
            // 
            this.btnAleatoire.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAleatoire.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAleatoire.Location = new System.Drawing.Point(21, 171);
            this.btnAleatoire.Name = "btnAleatoire";
            this.btnAleatoire.Size = new System.Drawing.Size(82, 33);
            this.btnAleatoire.TabIndex = 7;
            this.btnAleatoire.Text = "Aléatoire";
            this.btnAleatoire.UseVisualStyleBackColor = false;
            this.btnAleatoire.Click += new System.EventHandler(this.btnAleatoire_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnValider.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnValider.Location = new System.Drawing.Point(163, 171);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(91, 33);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // cbVerbe
            // 
            this.cbVerbe.FormattingEnabled = true;
            this.cbVerbe.Items.AddRange(new object[] {
            "Conjuguer",
            "Gagner",
            "Sécher",
            "Finir",
            "Choisir",
            "Frémir",
            "Prendre",
            "Peindre",
            "Rendre"});
            this.cbVerbe.Location = new System.Drawing.Point(117, 16);
            this.cbVerbe.Name = "cbVerbe";
            this.cbVerbe.Size = new System.Drawing.Size(121, 21);
            this.cbVerbe.TabIndex = 0;
            this.cbVerbe.SelectedIndexChanged += new System.EventHandler(this.cbVerbe_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(266, 220);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAleatoire);
            this.Controls.Add(this.lblVerbe);
            this.Controls.Add(this.lblPersonne);
            this.Controls.Add(this.lblTemps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPersonne);
            this.Controls.Add(this.cbTemps);
            this.Controls.Add(this.cbVerbe);
            this.Name = "Form1";
            this.Text = "Conjugueur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbTemps;
        private System.Windows.Forms.ComboBox cbPersonne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTemps;
        private System.Windows.Forms.Label lblPersonne;
        private System.Windows.Forms.Label lblVerbe;
        private System.Windows.Forms.Button btnAleatoire;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cbVerbe;
    }
}

