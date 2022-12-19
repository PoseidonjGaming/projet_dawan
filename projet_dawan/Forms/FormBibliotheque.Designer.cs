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
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.lstBxSerie = new System.Windows.Forms.ListBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.lblFiltre = new System.Windows.Forms.Label();
            this.cmbFiltrer = new System.Windows.Forms.ComboBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.buttonAddWich = new System.Windows.Forms.Button();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitre.Location = new System.Drawing.Point(48, 18);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(169, 30);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "BIBLIOTHÈQUE";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.lstBxSerie);
            this.groupBoxResult.Location = new System.Drawing.Point(10, 73);
            this.groupBoxResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxResult.Size = new System.Drawing.Size(679, 256);
            this.groupBoxResult.TabIndex = 1;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Liste des résultat de la recherche";
            // 
            // lstBxSerie
            // 
            this.lstBxSerie.FormattingEnabled = true;
            this.lstBxSerie.ItemHeight = 15;
            this.lstBxSerie.Location = new System.Drawing.Point(5, 20);
            this.lstBxSerie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBxSerie.Name = "lstBxSerie";
            this.lstBxSerie.Size = new System.Drawing.Size(669, 229);
            this.lstBxSerie.TabIndex = 0;
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecherche.Location = new System.Drawing.Point(430, 18);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(83, 19);
            this.lblRecherche.TabIndex = 2;
            this.lblRecherche.Text = "Rechercher :";
            // 
            // txtRechercher
            // 
            this.txtRechercher.Location = new System.Drawing.Point(526, 15);
            this.txtRechercher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(148, 23);
            this.txtRechercher.TabIndex = 3;
            this.txtRechercher.TextChanged += new System.EventHandler(this.txtRechercher_TextChanged);
            // 
            // lblFiltre
            // 
            this.lblFiltre.AutoSize = true;
            this.lblFiltre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFiltre.Location = new System.Drawing.Point(430, 51);
            this.lblFiltre.Name = "lblFiltre";
            this.lblFiltre.Size = new System.Drawing.Size(51, 19);
            this.lblFiltre.TabIndex = 4;
            this.lblFiltre.Text = "Filtrer :";
            // 
            // cmbFiltrer
            // 
            this.cmbFiltrer.FormattingEnabled = true;
            this.cmbFiltrer.Location = new System.Drawing.Point(526, 47);
            this.cmbFiltrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltrer.Name = "cmbFiltrer";
            this.cmbFiltrer.Size = new System.Drawing.Size(148, 23);
            this.cmbFiltrer.TabIndex = 5;
            this.cmbFiltrer.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrer_SelectedIndexChanged);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(10, 18);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(32, 28);
            this.btnRetour.TabIndex = 6;
            this.btnRetour.Text = "<";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(342, 14);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(82, 22);
            this.btnDetail.TabIndex = 7;
            this.btnDetail.Text = "Détail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // buttonAddWich
            // 
            this.buttonAddWich.Location = new System.Drawing.Point(342, 49);
            this.buttonAddWich.Name = "buttonAddWich";
            this.buttonAddWich.Size = new System.Drawing.Size(82, 23);
            this.buttonAddWich.TabIndex = 8;
            this.buttonAddWich.Text = "A regarder";
            this.buttonAddWich.UseVisualStyleBackColor = true;
            this.buttonAddWich.Click += new System.EventHandler(this.buttonAddWich_Click);
            // 
            // FormBibliotheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 339);
            this.Controls.Add(this.buttonAddWich);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.cmbFiltrer);
            this.Controls.Add(this.lblFiltre);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.lblTitre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBibliotheque";
            this.Text = "PageBibliotheque";
            this.groupBoxResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitre;
        private GroupBox groupBoxResult;
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