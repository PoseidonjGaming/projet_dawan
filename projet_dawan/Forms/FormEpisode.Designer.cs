namespace projet_dawan_WinForm.Forms
{
    partial class FormEpisode
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
            this.btnCasting = new System.Windows.Forms.Button();
            this.txtBoxResumeEpisode = new System.Windows.Forms.TextBox();
            this.linkLblBAEpisode = new System.Windows.Forms.LinkLabel();
            this.lblDateEpisode = new System.Windows.Forms.Label();
            this.pictureBoxEpisode = new System.Windows.Forms.PictureBox();
            this.lblSaison = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.labelEpisode = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEpisode)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCasting);
            this.groupBox1.Controls.Add(this.txtBoxResumeEpisode);
            this.groupBox1.Controls.Add(this.linkLblBAEpisode);
            this.groupBox1.Controls.Add(this.lblDateEpisode);
            this.groupBox1.Controls.Add(this.pictureBoxEpisode);
            this.groupBox1.Location = new System.Drawing.Point(14, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(887, 496);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnCasting
            // 
            this.btnCasting.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCasting.Location = new System.Drawing.Point(738, 153);
            this.btnCasting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCasting.Name = "btnCasting";
            this.btnCasting.Size = new System.Drawing.Size(142, 51);
            this.btnCasting.TabIndex = 5;
            this.btnCasting.Text = "CASTING";
            this.btnCasting.UseVisualStyleBackColor = true;
            this.btnCasting.Click += new System.EventHandler(this.btnCasting_Click);
            // 
            // txtBoxResumeEpisode
            // 
            this.txtBoxResumeEpisode.Location = new System.Drawing.Point(304, 229);
            this.txtBoxResumeEpisode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxResumeEpisode.Multiline = true;
            this.txtBoxResumeEpisode.Name = "txtBoxResumeEpisode";
            this.txtBoxResumeEpisode.Size = new System.Drawing.Size(585, 257);
            this.txtBoxResumeEpisode.TabIndex = 4;
            this.txtBoxResumeEpisode.Text = "Résumé";
            // 
            // linkLblBAEpisode
            // 
            this.linkLblBAEpisode.AutoSize = true;
            this.linkLblBAEpisode.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLblBAEpisode.Location = new System.Drawing.Point(304, 153);
            this.linkLblBAEpisode.Name = "linkLblBAEpisode";
            this.linkLblBAEpisode.Size = new System.Drawing.Size(189, 35);
            this.linkLblBAEpisode.TabIndex = 3;
            this.linkLblBAEpisode.TabStop = true;
            this.linkLblBAEpisode.Text = "Bande Annonce";
            // 
            // lblDateEpisode
            // 
            this.lblDateEpisode.AutoSize = true;
            this.lblDateEpisode.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateEpisode.Location = new System.Drawing.Point(304, 60);
            this.lblDateEpisode.Name = "lblDateEpisode";
            this.lblDateEpisode.Size = new System.Drawing.Size(261, 35);
            this.lblDateEpisode.TabIndex = 2;
            this.lblDateEpisode.Text = "Date de 1ère diffusion";
            // 
            // pictureBoxEpisode
            // 
            this.pictureBoxEpisode.Location = new System.Drawing.Point(7, 28);
            this.pictureBoxEpisode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxEpisode.Name = "pictureBoxEpisode";
            this.pictureBoxEpisode.Size = new System.Drawing.Size(291, 459);
            this.pictureBoxEpisode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEpisode.TabIndex = 0;
            this.pictureBoxEpisode.TabStop = false;
            // 
            // lblSaison
            // 
            this.lblSaison.AutoSize = true;
            this.lblSaison.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaison.Location = new System.Drawing.Point(416, 35);
            this.lblSaison.Name = "lblSaison";
            this.lblSaison.Size = new System.Drawing.Size(163, 46);
            this.lblSaison.TabIndex = 4;
            this.lblSaison.Text = "SAISON : ";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSerie.Location = new System.Drawing.Point(21, 17);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(389, 67);
            this.lblSerie.TabIndex = 3;
            this.lblSerie.Text = "Titre de la série";
            // 
            // labelEpisode
            // 
            this.labelEpisode.AutoSize = true;
            this.labelEpisode.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEpisode.Location = new System.Drawing.Point(585, 35);
            this.labelEpisode.Name = "labelEpisode";
            this.labelEpisode.Size = new System.Drawing.Size(162, 46);
            this.labelEpisode.TabIndex = 6;
            this.labelEpisode.Text = "Episode : ";
            // 
            // FormEpisode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.labelEpisode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSaison);
            this.Controls.Add(this.lblSerie);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEpisode";
            this.Text = "Episode";
            this.Load += new System.EventHandler(this.FormEpisode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEpisode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCasting;
        private TextBox txtBoxResumeEpisode;
        private LinkLabel linkLblBAEpisode;
        private Label lblDateEpisode;
        private PictureBox pictureBoxEpisode;
        private Label lblSaison;
        private Label lblSerie;
        private Label labelEpisode;
    }
}