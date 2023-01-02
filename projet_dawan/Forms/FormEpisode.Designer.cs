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
            this.lblEpisode = new System.Windows.Forms.Label();
            this.lblSaison = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTitreEp = new System.Windows.Forms.Label();
            this.lstBoxEpisode = new System.Windows.Forms.ListBox();
            this.btnCasting = new System.Windows.Forms.Button();
            this.txtBoxResumeSaison = new System.Windows.Forms.TextBox();
            this.lblDateSaison = new System.Windows.Forms.Label();
            this.pictureBoxSaison = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaison)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEpisode
            // 
            this.lblEpisode.AutoSize = true;
            this.lblEpisode.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEpisode.Location = new System.Drawing.Point(114, 9);
            this.lblEpisode.Name = "lblEpisode";
            this.lblEpisode.Size = new System.Drawing.Size(313, 54);
            this.lblEpisode.TabIndex = 0;
            this.lblEpisode.Text = "Titre de la série";
            // 
            // lblSaison
            // 
            this.lblSaison.AutoSize = true;
            this.lblSaison.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaison.Location = new System.Drawing.Point(443, 22);
            this.lblSaison.Name = "lblSaison";
            this.lblSaison.Size = new System.Drawing.Size(129, 37);
            this.lblSaison.TabIndex = 1;
            this.lblSaison.Text = "SAISON : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTitreEp);
            this.groupBox1.Controls.Add(this.lstBoxEpisode);
            this.groupBox1.Controls.Add(this.btnCasting);
            this.groupBox1.Controls.Add(this.txtBoxResumeSaison);
            this.groupBox1.Controls.Add(this.lblDateSaison);
            this.groupBox1.Controls.Add(this.pictureBoxSaison);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 372);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblTitreEp
            // 
            this.lblTitreEp.AutoSize = true;
            this.lblTitreEp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitreEp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitreEp.Location = new System.Drawing.Point(201, 22);
            this.lblTitreEp.Name = "lblTitreEp";
            this.lblTitreEp.Size = new System.Drawing.Size(90, 28);
            this.lblTitreEp.TabIndex = 8;
            this.lblTitreEp.Text = "Episode: ";
            // 
            // lstBoxEpisode
            // 
            this.lstBoxEpisode.FormattingEnabled = true;
            this.lstBoxEpisode.ItemHeight = 15;
            this.lstBoxEpisode.Location = new System.Drawing.Point(6, 242);
            this.lstBoxEpisode.Name = "lstBoxEpisode";
            this.lstBoxEpisode.Size = new System.Drawing.Size(189, 124);
            this.lstBoxEpisode.TabIndex = 7;
            this.lstBoxEpisode.SelectedIndexChanged += new System.EventHandler(this.lstBoxEpisode_SelectedIndexChanged);
            // 
            // btnCasting
            // 
            this.btnCasting.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCasting.Location = new System.Drawing.Point(663, 115);
            this.btnCasting.Name = "btnCasting";
            this.btnCasting.Size = new System.Drawing.Size(107, 38);
            this.btnCasting.TabIndex = 5;
            this.btnCasting.Text = "CASTING";
            this.btnCasting.UseVisualStyleBackColor = true;
            this.btnCasting.Click += new System.EventHandler(this.btnCasting_Click);
            // 
            // txtBoxResumeSaison
            // 
            this.txtBoxResumeSaison.Location = new System.Drawing.Point(201, 172);
            this.txtBoxResumeSaison.Multiline = true;
            this.txtBoxResumeSaison.Name = "txtBoxResumeSaison";
            this.txtBoxResumeSaison.ReadOnly = true;
            this.txtBoxResumeSaison.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxResumeSaison.Size = new System.Drawing.Size(569, 194);
            this.txtBoxResumeSaison.TabIndex = 4;
            this.txtBoxResumeSaison.TabStop = false;
            this.txtBoxResumeSaison.Text = "Résumé";
            // 
            // lblDateSaison
            // 
            this.lblDateSaison.AutoSize = true;
            this.lblDateSaison.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateSaison.Location = new System.Drawing.Point(201, 50);
            this.lblDateSaison.Name = "lblDateSaison";
            this.lblDateSaison.Size = new System.Drawing.Size(204, 28);
            this.lblDateSaison.TabIndex = 2;
            this.lblDateSaison.Text = "Date de 1ère diffusion";
            // 
            // pictureBoxSaison
            // 
            this.pictureBoxSaison.Location = new System.Drawing.Point(6, 22);
            this.pictureBoxSaison.Name = "pictureBoxSaison";
            this.pictureBoxSaison.Size = new System.Drawing.Size(189, 214);
            this.pictureBoxSaison.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSaison.TabIndex = 0;
            this.pictureBoxSaison.TabStop = false;
            // 
            // FormEpisode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSaison);
            this.Controls.Add(this.lblEpisode);
            this.Name = "FormEpisode";
            this.Text = "Saison";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaison)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEpisode;
        private Label lblSaison;
        private GroupBox groupBox1;
        private Button btnCasting;
        private TextBox txtBoxResumeSaison;
        private Label lblDateSaison;
        private PictureBox pictureBoxSaison;
        private ListBox lstBoxEpisode;
        private Label lblTitreEp;
    }
}