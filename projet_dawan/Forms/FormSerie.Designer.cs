namespace projet_dawan_WinForm
{
    partial class FormSerie
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSerie = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonToWatch = new System.Windows.Forms.Button();
            this.lstBoxSaison = new System.Windows.Forms.ListBox();
            this.btnCasting = new System.Windows.Forms.Button();
            this.txtBoxResumeSerie = new System.Windows.Forms.TextBox();
            this.linkLblBASerie = new System.Windows.Forms.LinkLabel();
            this.lblDateSerie = new System.Windows.Forms.Label();
            this.pictureBoxSerie = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSerie)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSerie.Location = new System.Drawing.Point(238, 9);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(313, 54);
            this.lblSerie.TabIndex = 0;
            this.lblSerie.Text = "Titre de la série";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonToWatch);
            this.groupBox1.Controls.Add(this.lstBoxSaison);
            this.groupBox1.Controls.Add(this.btnCasting);
            this.groupBox1.Controls.Add(this.txtBoxResumeSerie);
            this.groupBox1.Controls.Add(this.linkLblBASerie);
            this.groupBox1.Controls.Add(this.lblDateSerie);
            this.groupBox1.Controls.Add(this.pictureBoxSerie);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 372);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // buttonToWatch
            // 
            this.buttonToWatch.Location = new System.Drawing.Point(683, 86);
            this.buttonToWatch.Name = "buttonToWatch";
            this.buttonToWatch.Size = new System.Drawing.Size(75, 23);
            this.buttonToWatch.TabIndex = 7;
            this.buttonToWatch.Text = "To Watch";
            this.buttonToWatch.UseVisualStyleBackColor = true;
            this.buttonToWatch.Click += new System.EventHandler(this.buttonToWatch_Click);
            // 
            // lstBoxSaison
            // 
            this.lstBoxSaison.FormattingEnabled = true;
            this.lstBoxSaison.ItemHeight = 15;
            this.lstBoxSaison.Location = new System.Drawing.Point(6, 258);
            this.lstBoxSaison.Name = "lstBoxSaison";
            this.lstBoxSaison.Size = new System.Drawing.Size(165, 109);
            this.lstBoxSaison.TabIndex = 6;
            this.lstBoxSaison.SelectedIndexChanged += new System.EventHandler(this.lstBoxSaison_SelectedIndexChanged);
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
            // txtBoxResumeSerie
            // 
            this.txtBoxResumeSerie.Location = new System.Drawing.Point(201, 172);
            this.txtBoxResumeSerie.Multiline = true;
            this.txtBoxResumeSerie.Name = "txtBoxResumeSerie";
            this.txtBoxResumeSerie.Size = new System.Drawing.Size(569, 194);
            this.txtBoxResumeSerie.TabIndex = 4;
            this.txtBoxResumeSerie.Text = "Résumé";
            // 
            // linkLblBASerie
            // 
            this.linkLblBASerie.AutoSize = true;
            this.linkLblBASerie.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLblBASerie.Location = new System.Drawing.Point(201, 115);
            this.linkLblBASerie.Name = "linkLblBASerie";
            this.linkLblBASerie.Size = new System.Drawing.Size(148, 28);
            this.linkLblBASerie.TabIndex = 3;
            this.linkLblBASerie.TabStop = true;
            this.linkLblBASerie.Text = "Bande Annonce";
            // 
            // lblDateSerie
            // 
            this.lblDateSerie.AutoSize = true;
            this.lblDateSerie.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateSerie.Location = new System.Drawing.Point(201, 44);
            this.lblDateSerie.Name = "lblDateSerie";
            this.lblDateSerie.Size = new System.Drawing.Size(204, 28);
            this.lblDateSerie.TabIndex = 2;
            this.lblDateSerie.Text = "Date de 1ère diffusion";
            // 
            // pictureBoxSerie
            // 
            this.pictureBoxSerie.Location = new System.Drawing.Point(6, 22);
            this.pictureBoxSerie.Name = "pictureBoxSerie";
            this.pictureBoxSerie.Size = new System.Drawing.Size(165, 230);
            this.pictureBoxSerie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSerie.TabIndex = 0;
            this.pictureBoxSerie.TabStop = false;
            // 
            // FormSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSerie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSerie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Serie";
            this.Load += new System.EventHandler(this.FormSerie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSerie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSerie;
        private GroupBox groupBox1;
        private PictureBox pictureBoxSerie;
        private TextBox txtBoxResumeSerie;
        private LinkLabel linkLblBASerie;
        private Label lblDateSerie;
        private Button btnCasting;
        private ListBox lstBoxSaison;
        private Button buttonToWatch;
    }
}