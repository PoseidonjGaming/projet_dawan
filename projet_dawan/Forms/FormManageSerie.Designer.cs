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
            this.label5 = new System.Windows.Forms.Label();
            this.txtResume = new System.Windows.Forms.TextBox();
            this.txtNomSerie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtResume);
            this.groupBox1.Controls.Add(this.txtNomSerie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // btnParcourir
            // 
            this.btnParcourir.Location = new System.Drawing.Point(6, 259);
            this.btnParcourir.Name = "btnParcourir";
            this.btnParcourir.Size = new System.Drawing.Size(127, 29);
            this.btnParcourir.TabIndex = 10;
            this.btnParcourir.Text = "Parcourir";
            this.btnParcourir.UseVisualStyleBackColor = true;
            this.btnParcourir.Click += new System.EventHandler(this.btnParcourir_Click);
            // 
            // dateTimeSortie
            // 
            this.dateTimeSortie.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeSortie.Location = new System.Drawing.Point(139, 70);
            this.dateTimeSortie.Name = "dateTimeSortie";
            this.dateTimeSortie.Size = new System.Drawing.Size(198, 27);
            this.dateTimeSortie.TabIndex = 9;
            // 
            // txtUrlBa
            // 
            this.txtUrlBa.Location = new System.Drawing.Point(139, 296);
            this.txtUrlBa.Name = "txtUrlBa";
            this.txtUrlBa.Size = new System.Drawing.Size(198, 27);
            this.txtUrlBa.TabIndex = 8;
            // 
            // txtPathAffiche
            // 
            this.txtPathAffiche.Location = new System.Drawing.Point(139, 260);
            this.txtPathAffiche.Name = "txtPathAffiche";
            this.txtPathAffiche.ReadOnly = true;
            this.txtPathAffiche.Size = new System.Drawing.Size(198, 27);
            this.txtPathAffiche.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Url BA :";
            // 
            // txtResume
            // 
            this.txtResume.Location = new System.Drawing.Point(139, 117);
            this.txtResume.Multiline = true;
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(198, 130);
            this.txtResume.TabIndex = 5;
            // 
            // txtNomSerie
            // 
            this.txtNomSerie.Location = new System.Drawing.Point(139, 32);
            this.txtNomSerie.Name = "txtNomSerie";
            this.txtNomSerie.Size = new System.Drawing.Size(198, 27);
            this.txtNomSerie.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Résumé :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date de sortie :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de la série :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(13, 351);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(105, 48);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(124, 351);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(113, 48);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(243, 351);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(120, 48);
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
            this.lstBoxSerie.ItemHeight = 20;
            this.lstBoxSerie.Location = new System.Drawing.Point(369, 12);
            this.lstBoxSerie.Name = "lstBoxSerie";
            this.lstBoxSerie.Size = new System.Drawing.Size(273, 384);
            this.lstBoxSerie.TabIndex = 5;
            this.lstBoxSerie.SelectedIndexChanged += new System.EventHandler(this.lstBoxSerie_SelectedIndexChanged);
            // 
            // FormAjoutSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 408);
            this.Controls.Add(this.lstBoxSerie);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAjoutSerie";
            this.Text = "AjouterSeries";
            this.Load += new System.EventHandler(this.FormAjoutSerie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAjouter;
        private Button btnAnnuler;
        private Label label2;
        private Label label1;
        private TextBox txtUrlBa;
        private TextBox txtPathAffiche;
        private Label label5;
        private TextBox txtResume;
        private TextBox txtNomSerie;
        private Label label3;
        private DateTimePicker dateTimeSortie;
        private Button btnSup;
        private Button btnParcourir;
        private OpenFileDialog openFileDialogAffiche;
        private ListBox lstBoxSerie;
    }
}