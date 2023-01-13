namespace projet_dawan.Forms
{
    partial class FormManagePerso
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
            this.txtBoxNom = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.txtBoxNom);
            this.groupBox1.Controls.Add(this.comboBoxSerie);
            this.groupBox1.Controls.Add(this.comboBoxActeur);
            this.groupBox1.Controls.Add(this.txtNomPerso);
            this.groupBox1.Controls.Add(this.lblResume);
            this.groupBox1.Controls.Add(this.lblSerie);
            this.groupBox1.Controls.Add(this.lblActeur);
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(305, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(88, 116);
            this.txtBoxNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxNom.Multiline = true;
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(201, 57);
            this.txtBoxNom.TabIndex = 7;
            // 
            // comboBoxSerie
            // 
            this.comboBoxSerie.FormattingEnabled = true;
            this.comboBoxSerie.Location = new System.Drawing.Point(79, 80);
            this.comboBoxSerie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSerie.Name = "comboBoxSerie";
            this.comboBoxSerie.Size = new System.Drawing.Size(210, 23);
            this.comboBoxSerie.TabIndex = 6;
            // 
            // comboBoxActeur
            // 
            this.comboBoxActeur.FormattingEnabled = true;
            this.comboBoxActeur.Location = new System.Drawing.Point(79, 50);
            this.comboBoxActeur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxActeur.Name = "comboBoxActeur";
            this.comboBoxActeur.Size = new System.Drawing.Size(210, 23);
            this.comboBoxActeur.TabIndex = 5;
            // 
            // txtNomPerso
            // 
            this.txtNomPerso.Location = new System.Drawing.Point(67, 20);
            this.txtNomPerso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomPerso.Name = "txtNomPerso";
            this.txtNomPerso.Size = new System.Drawing.Size(221, 23);
            this.txtNomPerso.TabIndex = 4;
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResume.Location = new System.Drawing.Point(5, 113);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(73, 21);
            this.lblResume.TabIndex = 3;
            this.lblResume.Text = "Resumé :";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSerie.Location = new System.Drawing.Point(5, 76);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(52, 21);
            this.lblSerie.TabIndex = 2;
            this.lblSerie.Text = "Serie :";
            // 
            // lblActeur
            // 
            this.lblActeur.AutoSize = true;
            this.lblActeur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActeur.Location = new System.Drawing.Point(5, 47);
            this.lblActeur.Name = "lblActeur";
            this.lblActeur.Size = new System.Drawing.Size(62, 21);
            this.lblActeur.TabIndex = 1;
            this.lblActeur.Text = "Acteur :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNom.Location = new System.Drawing.Point(5, 17);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(52, 21);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(67, 205);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(82, 22);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // listBoxPerso
            // 
            this.listBoxPerso.FormattingEnabled = true;
            this.listBoxPerso.ItemHeight = 15;
            this.listBoxPerso.Location = new System.Drawing.Point(321, 16);
            this.listBoxPerso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPerso.Name = "listBoxPerso";
            this.listBoxPerso.Size = new System.Drawing.Size(159, 214);
            this.listBoxPerso.TabIndex = 2;
            this.listBoxPerso.SelectedIndexChanged += new System.EventHandler(this.listBoxPerso_SelectedIndexChanged);
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(180, 205);
            this.btnSuppr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(82, 22);
            this.btnSuppr.TabIndex = 3;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // FormManagePerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 236);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.listBoxPerso);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormManagePerso";
            this.Text = "FormAjoutPerso";
            this.Load += new System.EventHandler(this.FormAjoutPerso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBoxSerie;
        private ComboBox comboBoxActeur;
        private TextBox txtNomPerso;
        private TextBox txtBoxNom;
        private Label lblNom;
        private Label lblResume;
        private Label lblSerie;
        private Label lblActeur;
        private ListBox listBoxPerso;
        private Button btnAjouter;
        private Button btnSuppr;
    }
}