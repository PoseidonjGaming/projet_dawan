namespace projet_dawan.Forms
{
    partial class FormCasting
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
            this.lblCasting = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInterpete = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelActeur = new System.Windows.Forms.Label();
            this.labelNomPerso = new System.Windows.Forms.Label();
            this.imagePersonnage = new System.Windows.Forms.PictureBox();
            this.lstBoxCasting = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonnage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCasting
            // 
            this.lblCasting.AutoSize = true;
            this.lblCasting.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCasting.Location = new System.Drawing.Point(16, 15);
            this.lblCasting.Name = "lblCasting";
            this.lblCasting.Size = new System.Drawing.Size(205, 30);
            this.lblCasting.TabIndex = 0;
            this.lblCasting.Text = "Casting / Nom série";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInterpete);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelActeur);
            this.groupBox1.Controls.Add(this.labelNomPerso);
            this.groupBox1.Controls.Add(this.imagePersonnage);
            this.groupBox1.Controls.Add(this.lstBoxCasting);
            this.groupBox1.Location = new System.Drawing.Point(10, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(609, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblInterpete
            // 
            this.lblInterpete.AutoSize = true;
            this.lblInterpete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInterpete.Location = new System.Drawing.Point(267, 68);
            this.lblInterpete.Name = "lblInterpete";
            this.lblInterpete.Size = new System.Drawing.Size(112, 21);
            this.lblInterpete.TabIndex = 5;
            this.lblInterpete.Text = "Interprété par :";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(267, 120);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(327, 82);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations";
            // 
            // labelActeur
            // 
            this.labelActeur.AutoSize = true;
            this.labelActeur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelActeur.Location = new System.Drawing.Point(267, 89);
            this.labelActeur.Name = "labelActeur";
            this.labelActeur.Size = new System.Drawing.Size(92, 21);
            this.labelActeur.TabIndex = 3;
            this.labelActeur.Text = "Nom acteur";
            // 
            // labelNomPerso
            // 
            this.labelNomPerso.AutoSize = true;
            this.labelNomPerso.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNomPerso.Location = new System.Drawing.Point(267, 32);
            this.labelNomPerso.Name = "labelNomPerso";
            this.labelNomPerso.Size = new System.Drawing.Size(191, 30);
            this.labelNomPerso.TabIndex = 2;
            this.labelNomPerso.Text = "Nom personnage";
            // 
            // imagePersonnage
            // 
            this.imagePersonnage.Location = new System.Drawing.Point(485, 20);
            this.imagePersonnage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagePersonnage.Name = "imagePersonnage";
            this.imagePersonnage.Size = new System.Drawing.Size(109, 91);
            this.imagePersonnage.TabIndex = 1;
            this.imagePersonnage.TabStop = false;
            // 
            // lstBoxCasting
            // 
            this.lstBoxCasting.FormattingEnabled = true;
            this.lstBoxCasting.ItemHeight = 15;
            this.lstBoxCasting.Location = new System.Drawing.Point(5, 20);
            this.lstBoxCasting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBoxCasting.Name = "lstBoxCasting";
            this.lstBoxCasting.Size = new System.Drawing.Size(246, 184);
            this.lstBoxCasting.TabIndex = 0;
            this.lstBoxCasting.SelectedIndexChanged += new System.EventHandler(this.listBoxCasting_SelectedIndexChanged);
            // 
            // FormCasting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 279);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCasting);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCasting";
            this.Text = "FormCasting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonnage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCasting;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label labelActeur;
        private Label labelNomPerso;
        private PictureBox imagePersonnage;
        private ListBox lstBoxCasting;
        private Label lblInterpete;
    }
}