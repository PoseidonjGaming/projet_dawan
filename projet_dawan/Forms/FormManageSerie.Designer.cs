namespace projet_dawan
{
    partial class FormManageSerie
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
            this.btnParcourir = new System.Windows.Forms.Button();
            this.dateTimeSortie = new System.Windows.Forms.DateTimePicker();
            this.txtUrlBa = new System.Windows.Forms.TextBox();
            this.txtPathAffiche = new System.Windows.Forms.TextBox();
            this.lblUrlBA = new System.Windows.Forms.Label();
            this.txtResume = new System.Windows.Forms.TextBox();
            this.txtNomSerie = new System.Windows.Forms.TextBox();
            this.lblResume = new System.Windows.Forms.Label();
            this.lblDateDiff = new System.Windows.Forms.Label();
            this.lblNomSerie = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.openFileDialogAffiche = new System.Windows.Forms.OpenFileDialog();
            this.lstBoxSerie = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnParcourir);
            this.groupBox1.Controls.Add(this.dateTimeSortie);
            this.groupBox1.Controls.Add(this.txtUrlBa);
            this.groupBox1.Controls.Add(this.txtPathAffiche);
            this.groupBox1.Controls.Add(this.lblUrlBA);
            this.groupBox1.Controls.Add(this.txtResume);
            this.groupBox1.Controls.Add(this.txtNomSerie);
            this.groupBox1.Controls.Add(this.lblResume);
            this.groupBox1.Controls.Add(this.lblDateDiff);
            this.groupBox1.Controls.Add(this.lblNomSerie);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(307, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // btnParcourir
            // 
            this.btnParcourir.Location = new System.Drawing.Point(5, 194);
            this.btnParcourir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnParcourir.Name = "btnParcourir";
            this.btnParcourir.Size = new System.Drawing.Size(111, 22);
            this.btnParcourir.TabIndex = 10;
            this.btnParcourir.Text = "Parcourir";
            this.btnParcourir.UseVisualStyleBackColor = true;
            this.btnParcourir.Click += new System.EventHandler(this.btnParcourir_Click);
            // 
            // dateTimeSortie
            // 
            this.dateTimeSortie.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeSortie.Location = new System.Drawing.Point(122, 52);
            this.dateTimeSortie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeSortie.Name = "dateTimeSortie";
            this.dateTimeSortie.Size = new System.Drawing.Size(174, 23);
            this.dateTimeSortie.TabIndex = 9;
            // 
            // txtUrlBa
            // 
            this.txtUrlBa.Location = new System.Drawing.Point(122, 222);
            this.txtUrlBa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrlBa.Name = "txtUrlBa";
            this.txtUrlBa.Size = new System.Drawing.Size(174, 23);
            this.txtUrlBa.TabIndex = 8;
            // 
            // txtPathAffiche
            // 
            this.txtPathAffiche.Location = new System.Drawing.Point(122, 195);
            this.txtPathAffiche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPathAffiche.Name = "txtPathAffiche";
            this.txtPathAffiche.ReadOnly = true;
            this.txtPathAffiche.Size = new System.Drawing.Size(174, 23);
            this.txtPathAffiche.TabIndex = 3;
            // 
            // lblUrlBA
            // 
            this.lblUrlBA.AutoSize = true;
            this.lblUrlBA.Location = new System.Drawing.Point(10, 226);
            this.lblUrlBA.Name = "lblUrlBA";
            this.lblUrlBA.Size = new System.Drawing.Size(46, 15);
            this.lblUrlBA.TabIndex = 7;
            this.lblUrlBA.Text = "Url BA :";
            // 
            // txtResume
            // 
            this.txtResume.Location = new System.Drawing.Point(122, 88);
            this.txtResume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResume.Multiline = true;
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(174, 98);
            this.txtResume.TabIndex = 5;
            // 
            // txtNomSerie
            // 
            this.txtNomSerie.Location = new System.Drawing.Point(122, 24);
            this.txtNomSerie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomSerie.Name = "txtNomSerie";
            this.txtNomSerie.Size = new System.Drawing.Size(174, 23);
            this.txtNomSerie.TabIndex = 3;
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.Location = new System.Drawing.Point(10, 92);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(55, 15);
            this.lblResume.TabIndex = 2;
            this.lblResume.Text = "Résumé :";
            // 
            // lblDateDiff
            // 
            this.lblDateDiff.AutoSize = true;
            this.lblDateDiff.Location = new System.Drawing.Point(10, 58);
            this.lblDateDiff.Name = "lblDateDiff";
            this.lblDateDiff.Size = new System.Drawing.Size(85, 15);
            this.lblDateDiff.TabIndex = 1;
            this.lblDateDiff.Text = "Date de sortie :";
            // 
            // lblNomSerie
            // 
            this.lblNomSerie.AutoSize = true;
            this.lblNomSerie.Location = new System.Drawing.Point(10, 28);
            this.lblNomSerie.Name = "lblNomSerie";
            this.lblNomSerie.Size = new System.Drawing.Size(95, 15);
            this.lblNomSerie.TabIndex = 0;
            this.lblNomSerie.Text = "Nom de la série :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(11, 263);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(92, 36);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(108, 263);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(99, 36);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(213, 263);
            this.btnSup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(105, 36);
            this.btnSup.TabIndex = 4;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // openFileDialogAffiche
            // 
            this.openFileDialogAffiche.FileName = "openFileDialog1";
            // 
            // lstBoxSerie
            // 
            this.lstBoxSerie.FormattingEnabled = true;
            this.lstBoxSerie.ItemHeight = 15;
            this.lstBoxSerie.Location = new System.Drawing.Point(323, 9);
            this.lstBoxSerie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBoxSerie.Name = "lstBoxSerie";
            this.lstBoxSerie.Size = new System.Drawing.Size(239, 289);
            this.lstBoxSerie.TabIndex = 5;
            this.lstBoxSerie.SelectedIndexChanged += new System.EventHandler(this.lstBoxSerie_SelectedIndexChanged);
            // 
            // FormManageSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 306);
            this.Controls.Add(this.lstBoxSerie);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormManageSerie";
            this.Text = "AjouterSeries";
            this.Load += new System.EventHandler(this.FormAjoutSerie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        public Button btnAjouter;
        private Button btnAnnuler;
        public TextBox txtUrlBa;
        public TextBox txtPathAffiche;
        public TextBox txtResume;
        public TextBox txtNomSerie;
        private Label lblDateDiff;
        private Label lblNomSerie;
        private Label lblUrlBA;
        private Label lblResume;
        public ListBox lstBoxSerie;
        private Button btnSup;
        private Button btnParcourir;
        public DateTimePicker dateTimeSortie;
        public OpenFileDialog openFileDialogAffiche;
    }
}