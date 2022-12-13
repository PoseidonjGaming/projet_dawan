namespace projet_dawan
{
    partial class FormBibliotheque
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBxSerie = new System.Windows.Forms.ListBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.lblFiltre = new System.Windows.Forms.Label();
            this.cmbFiltrer = new System.Windows.Forms.ComboBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.buttonAddWich = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitre.Location = new System.Drawing.Point(55, 24);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(207, 37);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "BIBLIOTHÈQUE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBxSerie);
            this.groupBox1.Location = new System.Drawing.Point(11, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 341);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des séries";
            // 
            // lstBxSerie
            // 
            this.lstBxSerie.FormattingEnabled = true;
            this.lstBxSerie.ItemHeight = 20;
            this.lstBxSerie.Location = new System.Drawing.Point(6, 27);
            this.lstBxSerie.Name = "lstBxSerie";
            this.lstBxSerie.Size = new System.Drawing.Size(764, 304);
            this.lstBxSerie.TabIndex = 0;
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecherche.Location = new System.Drawing.Point(491, 24);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(104, 23);
            this.lblRecherche.TabIndex = 2;
            this.lblRecherche.Text = "Rechercher :";
            // 
            // txtRechercher
            // 
            this.txtRechercher.Location = new System.Drawing.Point(601, 20);
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(169, 27);
            this.txtRechercher.TabIndex = 3;
            this.txtRechercher.TextChanged += new System.EventHandler(this.txtRechercher_TextChanged);
            // 
            // lblFiltre
            // 
            this.lblFiltre.AutoSize = true;
            this.lblFiltre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFiltre.Location = new System.Drawing.Point(491, 68);
            this.lblFiltre.Name = "lblFiltre";
            this.lblFiltre.Size = new System.Drawing.Size(62, 23);
            this.lblFiltre.TabIndex = 4;
            this.lblFiltre.Text = "Filtrer :";
            // 
            // cmbFiltrer
            // 
            this.cmbFiltrer.FormattingEnabled = true;
            this.cmbFiltrer.Location = new System.Drawing.Point(601, 63);
            this.cmbFiltrer.Name = "cmbFiltrer";
            this.cmbFiltrer.Size = new System.Drawing.Size(169, 28);
            this.cmbFiltrer.TabIndex = 5;
            this.cmbFiltrer.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrer_SelectedIndexChanged);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(11, 24);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(37, 37);
            this.btnRetour.TabIndex = 6;
            this.btnRetour.Text = "<";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(391, 19);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(94, 29);
            this.btnDetail.TabIndex = 7;
            this.btnDetail.Text = "Détail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // buttonAddWich
            // 
            this.buttonAddWich.Location = new System.Drawing.Point(399, 60);
            this.buttonAddWich.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddWich.Name = "buttonAddWich";
            this.buttonAddWich.Size = new System.Drawing.Size(86, 31);
            this.buttonAddWich.TabIndex = 8;
            this.buttonAddWich.Text = "A regarder";
            this.buttonAddWich.UseVisualStyleBackColor = true;
            this.buttonAddWich.Click += new System.EventHandler(this.buttonAddWich_Click);
            // 
            // FormBibliotheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.buttonAddWich);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.cmbFiltrer);
            this.Controls.Add(this.lblFiltre);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitre);
            this.Name = "FormBibliotheque";
            this.Text = "PageBibliotheque";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitre;
        private GroupBox groupBox1;
        private Label lblRecherche;
        public TextBox txtRechercher;
        private Label lblFiltre;
        public ComboBox cmbFiltrer;
        private Button btnRetour;
        public ListBox lstBxSerie;
        private Button btnDetail;
        private Button buttonAddWich;
    }
}