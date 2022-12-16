namespace projet_dawan.Forms
{
    partial class FormAjoutEpisode
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
            this.numSaison = new System.Windows.Forms.NumericUpDown();
            this.cmbSerie = new System.Windows.Forms.ComboBox();
            this.datePremDiff = new System.Windows.Forms.DateTimePicker();
            this.txtBoxResume = new System.Windows.Forms.TextBox();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.checkBoxLastSeason = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSaison)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numSaison);
            this.groupBox1.Controls.Add(this.cmbSerie);
            this.groupBox1.Controls.Add(this.datePremDiff);
            this.groupBox1.Controls.Add(this.txtBoxResume);
            this.groupBox1.Controls.Add(this.txtBoxNom);
            this.groupBox1.Controls.Add(this.checkBoxLastSeason);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 412);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // numSaison
            // 
            this.numSaison.Location = new System.Drawing.Point(71, 109);
            this.numSaison.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSaison.Name = "numSaison";
            this.numSaison.Size = new System.Drawing.Size(304, 27);
            this.numSaison.TabIndex = 10;
            this.numSaison.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSaison.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbSerie
            // 
            this.cmbSerie.FormattingEnabled = true;
            this.cmbSerie.Location = new System.Drawing.Point(71, 64);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Size = new System.Drawing.Size(304, 28);
            this.cmbSerie.TabIndex = 9;
            this.cmbSerie.SelectedIndexChanged += new System.EventHandler(this.cmbSerie_SelectedIndexChanged);
            // 
            // datePremDiff
            // 
            this.datePremDiff.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePremDiff.Location = new System.Drawing.Point(143, 156);
            this.datePremDiff.Name = "datePremDiff";
            this.datePremDiff.Size = new System.Drawing.Size(232, 27);
            this.datePremDiff.TabIndex = 8;
            // 
            // txtBoxResume
            // 
            this.txtBoxResume.Location = new System.Drawing.Point(7, 225);
            this.txtBoxResume.Multiline = true;
            this.txtBoxResume.Name = "txtBoxResume";
            this.txtBoxResume.Size = new System.Drawing.Size(368, 147);
            this.txtBoxResume.TabIndex = 7;
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(71, 20);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(304, 27);
            this.txtBoxNom.TabIndex = 6;
            // 
            // checkBoxLastSeason
            // 
            this.checkBoxLastSeason.AutoSize = true;
            this.checkBoxLastSeason.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxLastSeason.Location = new System.Drawing.Point(7, 378);
            this.checkBoxLastSeason.Name = "checkBoxLastSeason";
            this.checkBoxLastSeason.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxLastSeason.Size = new System.Drawing.Size(230, 24);
            this.checkBoxLastSeason.TabIndex = 5;
            this.checkBoxLastSeason.Text = "Dernier épisode de la saison ?";
            this.checkBoxLastSeason.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date de diffusion :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Série :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resumé :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saison :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(46, 445);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(130, 52);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(217, 445);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(130, 52);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FormAjoutEpisode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 524);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAjoutEpisode";
            this.Text = "Ajouter un episode";
            this.Load += new System.EventHandler(this.FormAjoutEpisode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSaison)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbSerie;
        private DateTimePicker datePremDiff;
        private TextBox txtBoxResume;
        private TextBox txtBoxNom;
        private CheckBox checkBoxLastSeason;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAjouter;
        private Button btnAnnuler;
        private NumericUpDown numSaison;
    }
}