namespace projet_dawan.Forms
{
    partial class FormMangaPerso
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxSerie = new System.Windows.Forms.ComboBox();
            this.comboBoxActeur = new System.Windows.Forms.ComboBox();
            this.txtNomPerso = new System.Windows.Forms.TextBox();
            this.lblResume = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblActeur = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.listBoxPerso = new System.Windows.Forms.ListBox();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBoxSerie);
            this.groupBox1.Controls.Add(this.comboBoxActeur);
            this.groupBox1.Controls.Add(this.txtNomPerso);
            this.groupBox1.Controls.Add(this.lblResume);
            this.groupBox1.Controls.Add(this.lblSerie);
            this.groupBox1.Controls.Add(this.lblActeur);
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 155);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 75);
            this.textBox1.TabIndex = 7;
            // 
            // comboBoxSerie
            // 
            this.comboBoxSerie.FormattingEnabled = true;
            this.comboBoxSerie.Location = new System.Drawing.Point(90, 106);
            this.comboBoxSerie.Name = "comboBoxSerie";
            this.comboBoxSerie.Size = new System.Drawing.Size(239, 28);
            this.comboBoxSerie.TabIndex = 6;
            // 
            // comboBoxActeur
            // 
            this.comboBoxActeur.FormattingEnabled = true;
            this.comboBoxActeur.Location = new System.Drawing.Point(90, 67);
            this.comboBoxActeur.Name = "comboBoxActeur";
            this.comboBoxActeur.Size = new System.Drawing.Size(239, 28);
            this.comboBoxActeur.TabIndex = 5;
            // 
            // txtNomPerso
            // 
            this.txtNomPerso.Location = new System.Drawing.Point(77, 27);
            this.txtNomPerso.Name = "txtNomPerso";
            this.txtNomPerso.Size = new System.Drawing.Size(252, 27);
            this.txtNomPerso.TabIndex = 4;
            // 
            // label4
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResume.Location = new System.Drawing.Point(6, 151);
            this.lblResume.Name = "label4";
            this.lblResume.Size = new System.Drawing.Size(88, 28);
            this.lblResume.TabIndex = 3;
            this.lblResume.Text = "Resumé :";
            // 
            // label3
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSerie.Location = new System.Drawing.Point(6, 102);
            this.lblSerie.Name = "label3";
            this.lblSerie.Size = new System.Drawing.Size(64, 28);
            this.lblSerie.TabIndex = 2;
            this.lblSerie.Text = "Serie :";
            // 
            // label2
            // 
            this.lblActeur.AutoSize = true;
            this.lblActeur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActeur.Location = new System.Drawing.Point(6, 63);
            this.lblActeur.Name = "label2";
            this.lblActeur.Size = new System.Drawing.Size(78, 28);
            this.lblActeur.TabIndex = 1;
            this.lblActeur.Text = "Acteur :";
            // 
            // label1
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNom.Location = new System.Drawing.Point(6, 23);
            this.lblNom.Name = "label1";
            this.lblNom.Size = new System.Drawing.Size(65, 28);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(77, 273);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(94, 29);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // listBoxPerso
            // 
            this.listBoxPerso.FormattingEnabled = true;
            this.listBoxPerso.ItemHeight = 20;
            this.listBoxPerso.Location = new System.Drawing.Point(367, 21);
            this.listBoxPerso.Name = "listBoxPerso";
            this.listBoxPerso.Size = new System.Drawing.Size(181, 284);
            this.listBoxPerso.TabIndex = 2;
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(206, 273);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(94, 29);
            this.btnSuppr.TabIndex = 3;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // FormAjoutPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 314);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.listBoxPerso);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAjoutPerso";
            this.Text = "FormAjoutPerso";
            this.Load += new System.EventHandler(this.FormAjoutPerso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        public ComboBox comboBoxSerie;
        public ComboBox comboBoxActeur;
        public TextBox txtNomPerso;
        private TextBox textBox1;
        private Label lblNom;
        private Label lblResume;
        private Label lblSerie;
        private Label lblActeur;
        public ListBox listBoxPerso;
        private Button btnAjouter;
        private Button btnSuppr;
    }
}