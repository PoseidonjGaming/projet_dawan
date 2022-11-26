namespace projet_dawan
{
    partial class PageBibliotheque
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBxSerie = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFiltrer = new System.Windows.Forms.ComboBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.buttonAddWich = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIBLIOTHÈQUE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBxSerie);
            this.groupBox1.Location = new System.Drawing.Point(10, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(679, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des séries";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(430, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rechercher :";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(430, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filtrer :";
            // 
            // comboBoxFiltrer
            // 
            this.comboBoxFiltrer.FormattingEnabled = true;
            this.comboBoxFiltrer.Location = new System.Drawing.Point(526, 47);
            this.comboBoxFiltrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxFiltrer.Name = "comboBoxFiltrer";
            this.comboBoxFiltrer.Size = new System.Drawing.Size(148, 23);
            this.comboBoxFiltrer.TabIndex = 5;
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
            this.buttonAddWich.Location = new System.Drawing.Point(349, 45);
            this.buttonAddWich.Name = "buttonAddWich";
            this.buttonAddWich.Size = new System.Drawing.Size(75, 23);
            this.buttonAddWich.TabIndex = 8;
            this.buttonAddWich.Text = "A regarder";
            this.buttonAddWich.UseVisualStyleBackColor = true;
            this.buttonAddWich.Click += new System.EventHandler(this.buttonAddWich_Click);
            // 
            // PageBibliotheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 339);
            this.Controls.Add(this.buttonAddWich);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.comboBoxFiltrer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PageBibliotheque";
            this.Text = "PageBibliotheque";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtRechercher;
        private Label label3;
        private ComboBox comboBoxFiltrer;
        private Button btnRetour;
        private ListBox lstBxSerie;
        private Button btnDetail;
        private Button buttonAddWich;
    }
}