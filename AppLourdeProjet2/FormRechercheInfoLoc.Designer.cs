namespace AppLourdeProjet2
{
    partial class FormRechercheInfoLoc
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
            this.labelNumLoc = new System.Windows.Forms.Label();
            this.textBoxNumLoc = new System.Windows.Forms.TextBox();
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.ViewInfoFiche = new System.Windows.Forms.DataGridView();
            this.NumLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Immatriculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontantRegle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateHreDepartPrevu = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DateHreDepartReel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateHreRetourPrevu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateHreRetourReel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ViewInfoFiche)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumLoc
            // 
            this.labelNumLoc.AutoSize = true;
            this.labelNumLoc.Location = new System.Drawing.Point(68, 58);
            this.labelNumLoc.Name = "labelNumLoc";
            this.labelNumLoc.Size = new System.Drawing.Size(105, 13);
            this.labelNumLoc.TabIndex = 0;
            this.labelNumLoc.Text = "Numéro de location :";
            // 
            // textBoxNumLoc
            // 
            this.textBoxNumLoc.Location = new System.Drawing.Point(179, 51);
            this.textBoxNumLoc.Name = "textBoxNumLoc";
            this.textBoxNumLoc.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumLoc.TabIndex = 1;
            this.textBoxNumLoc.TextChanged += new System.EventHandler(this.textBoxNumLoc_TextChanged);
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.Location = new System.Drawing.Point(350, 49);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.Size = new System.Drawing.Size(75, 23);
            this.BtnRechercher.TabIndex = 2;
            this.BtnRechercher.Text = "Rechercher";
            this.BtnRechercher.UseVisualStyleBackColor = true;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // ViewInfoFiche
            // 
            this.ViewInfoFiche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewInfoFiche.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumLocation,
            this.Immatriculation,
            this.DateLocation,
            this.MontantRegle,
            this.DateHreDepartPrevu,
            this.DateHreDepartReel,
            this.DateHreRetourPrevu,
            this.DateHreRetourReel});
            this.ViewInfoFiche.Location = new System.Drawing.Point(37, 105);
            this.ViewInfoFiche.Name = "ViewInfoFiche";
            this.ViewInfoFiche.Size = new System.Drawing.Size(897, 117);
            this.ViewInfoFiche.TabIndex = 3;
            // 
            // NumLocation
            // 
            this.NumLocation.HeaderText = "Numéro de location";
            this.NumLocation.Name = "NumLocation";
            this.NumLocation.ReadOnly = true;
            // 
            // Immatriculation
            // 
            this.Immatriculation.HeaderText = "Immatriculation";
            this.Immatriculation.Name = "Immatriculation";
            this.Immatriculation.ReadOnly = true;
            // 
            // DateLocation
            // 
            this.DateLocation.HeaderText = "Date de location";
            this.DateLocation.Name = "DateLocation";
            this.DateLocation.ReadOnly = true;
            // 
            // MontantRegle
            // 
            this.MontantRegle.HeaderText = "Montant réglé";
            this.MontantRegle.Name = "MontantRegle";
            this.MontantRegle.ReadOnly = true;
            // 
            // DateHreDepartPrevu
            // 
            this.DateHreDepartPrevu.HeaderText = "Date et heure du départ prévues";
            this.DateHreDepartPrevu.Name = "DateHreDepartPrevu";
            this.DateHreDepartPrevu.ReadOnly = true;
            // 
            // DateHreDepartReel
            // 
            this.DateHreDepartReel.HeaderText = "Date et heure du départ réelles";
            this.DateHreDepartReel.Name = "DateHreDepartReel";
            this.DateHreDepartReel.ReadOnly = true;
            // 
            // DateHreRetourPrevu
            // 
            this.DateHreRetourPrevu.HeaderText = "Date et heure du retour prévues";
            this.DateHreRetourPrevu.Name = "DateHreRetourPrevu";
            this.DateHreRetourPrevu.ReadOnly = true;
            // 
            // DateHreRetourReel
            // 
            this.DateHreRetourReel.HeaderText = "Date et heure du retour réelles";
            this.DateHreRetourReel.Name = "DateHreRetourReel";
            this.DateHreRetourReel.ReadOnly = true;
            // 
            // FormRechercheInfoLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 245);
            this.Controls.Add(this.ViewInfoFiche);
            this.Controls.Add(this.BtnRechercher);
            this.Controls.Add(this.textBoxNumLoc);
            this.Controls.Add(this.labelNumLoc);
            this.Name = "FormRechercheInfoLoc";
            this.Text = "FormRechercheInfoLoc";
            ((System.ComponentModel.ISupportInitialize)(this.ViewInfoFiche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumLoc;
        private System.Windows.Forms.TextBox textBoxNumLoc;
        private System.Windows.Forms.Button BtnRechercher;
        private System.Windows.Forms.DataGridView ViewInfoFiche;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Immatriculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontantRegle;
        private System.Windows.Forms.DataGridViewLinkColumn DateHreDepartPrevu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateHreDepartReel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateHreRetourPrevu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateHreRetourReel;
    }
}