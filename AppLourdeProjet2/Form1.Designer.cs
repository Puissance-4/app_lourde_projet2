namespace AppLourdeProjet2
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
            this.RechercheInfoLoc = new System.Windows.Forms.Button();
            this.labelChoix = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RechercheInfoLoc
            // 
            this.RechercheInfoLoc.Location = new System.Drawing.Point(69, 61);
            this.RechercheInfoLoc.Name = "RechercheInfoLoc";
            this.RechercheInfoLoc.Size = new System.Drawing.Size(304, 23);
            this.RechercheInfoLoc.TabIndex = 0;
            this.RechercheInfoLoc.Text = "Rechercher des informations sur une location";
            this.RechercheInfoLoc.UseVisualStyleBackColor = true;
            this.RechercheInfoLoc.Click += new System.EventHandler(this.RechercheInfoLoc_Click);
            // 
            // labelChoix
            // 
            this.labelChoix.AutoSize = true;
            this.labelChoix.Location = new System.Drawing.Point(340, 25);
            this.labelChoix.Name = "labelChoix";
            this.labelChoix.Size = new System.Drawing.Size(100, 13);
            this.labelChoix.TabIndex = 1;
            this.labelChoix.Text = "Choisir une action...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelChoix);
            this.Controls.Add(this.RechercheInfoLoc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RechercheInfoLoc;
        private System.Windows.Forms.Label labelChoix;
    }
}

