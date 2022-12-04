namespace projet_dawan_WinForm
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
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblSaison = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBoxEpisode = new System.Windows.Forms.ListBox();
            this.btnCasting = new System.Windows.Forms.Button();
            this.txtBoxResumeSaison = new System.Windows.Forms.TextBox();
            this.linkLblBASaison = new System.Windows.Forms.LinkLabel();
            this.lblDateSaison = new System.Windows.Forms.Label();
            this.pictureBoxSaison = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaison)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSerie.Location = new System.Drawing.Point(130, 12);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(389, 67);
            this.lblSerie.TabIndex = 0;
            this.lblSerie.Text = "Titre de la série";
            // 
            // lblSaison
            // 
            this.lblSaison.AutoSize = true;
            this.lblSaison.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaison.Location = new System.Drawing.Point(506, 29);
            this.lblSaison.Name = "lblSaison";
            this.lblSaison.Size = new System.Drawing.Size(163, 46);
            this.lblSaison.TabIndex = 1;
            this.lblSaison.Text = "SAISON : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBoxEpisode);
            this.groupBox1.Controls.Add(this.btnCasting);
            this.groupBox1.Controls.Add(this.txtBoxResumeSaison);
            this.groupBox1.Controls.Add(this.linkLblBASaison);
            this.groupBox1.Controls.Add(this.lblDateSaison);
            this.groupBox1.Controls.Add(this.pictureBoxSaison);
            this.groupBox1.Location = new System.Drawing.Point(14, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(887, 496);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lstBoxEpisode
            // 
            this.lstBoxEpisode.FormattingEnabled = true;
            this.lstBoxEpisode.ItemHeight = 20;
            this.lstBoxEpisode.Location = new System.Drawing.Point(7, 343);
            this.lstBoxEpisode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstBoxEpisode.Name = "lstBoxEpisode";
            this.lstBoxEpisode.Size = new System.Drawing.Size(188, 144);
            this.lstBoxEpisode.TabIndex = 7;
            this.lstBoxEpisode.SelectedIndexChanged += new System.EventHandler(this.lstBoxEpisode_SelectedIndexChanged);
            // 
            // btnCasting
            // 
            this.btnCasting.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCasting.Location = new System.Drawing.Point(758, 153);
            this.btnCasting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCasting.Name = "btnCasting";
            this.btnCasting.Size = new System.Drawing.Size(122, 51);
            this.btnCasting.TabIndex = 5;
            this.btnCasting.Text = "CASTING";
            this.btnCasting.UseVisualStyleBackColor = true;
            this.btnCasting.Click += new System.EventHandler(this.btnCasting_Click);
            // 
            // txtBoxResumeSaison
            // 
            this.txtBoxResumeSaison.Location = new System.Drawing.Point(230, 229);
            this.txtBoxResumeSaison.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxResumeSaison.Multiline = true;
            this.txtBoxResumeSaison.Name = "txtBoxResumeSaison";
            this.txtBoxResumeSaison.Size = new System.Drawing.Size(650, 257);
            this.txtBoxResumeSaison.TabIndex = 4;
            this.txtBoxResumeSaison.Text = "Résumé";
            // 
            // linkLblBASaison
            // 
            this.linkLblBASaison.AutoSize = true;
            this.linkLblBASaison.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLblBASaison.Location = new System.Drawing.Point(230, 153);
            this.linkLblBASaison.Name = "linkLblBASaison";
            this.linkLblBASaison.Size = new System.Drawing.Size(189, 35);
            this.linkLblBASaison.TabIndex = 3;
            this.linkLblBASaison.TabStop = true;
            this.linkLblBASaison.Text = "Bande Annonce";
            // 
            // lblDateSaison
            // 
            this.lblDateSaison.AutoSize = true;
            this.lblDateSaison.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateSaison.Location = new System.Drawing.Point(230, 59);
            this.lblDateSaison.Name = "lblDateSaison";
            this.lblDateSaison.Size = new System.Drawing.Size(261, 35);
            this.lblDateSaison.TabIndex = 2;
            this.lblDateSaison.Text = "Date de 1ère diffusion";
            // 
            // pictureBoxSaison
            // 
            this.pictureBoxSaison.Location = new System.Drawing.Point(7, 29);
            this.pictureBoxSaison.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxSaison.Name = "pictureBoxSaison";
            this.pictureBoxSaison.Size = new System.Drawing.Size(189, 307);
            this.pictureBoxSaison.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSaison.TabIndex = 0;
            this.pictureBoxSaison.TabStop = false;
            // 
            // FormSaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSaison);
            this.Controls.Add(this.lblSerie);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSaison";
            this.Text = "Saison";
            this.Load += new System.EventHandler(this.FormSaison_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaison)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSerie;
        private Label lblSaison;
        private GroupBox groupBox1;
        private Button btnCasting;
        private TextBox txtBoxResumeSaison;
        private LinkLabel linkLblBASaison;
        private Label lblDateSaison;
        private PictureBox pictureBoxSaison;
        private ListBox lstBoxEpisode;
    }
}