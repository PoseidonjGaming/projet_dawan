namespace projet_dawan.Forms
{
    partial class FormPersonnage
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
            this.labelPersonnage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImagePersonnage = new System.Windows.Forms.PictureBox();
            this.labelNomPerso = new System.Windows.Forms.Label();
            this.labelActeur = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePersonnage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPersonnage
            // 
            this.labelPersonnage.AutoSize = true;
            this.labelPersonnage.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPersonnage.Location = new System.Drawing.Point(12, 9);
            this.labelPersonnage.Name = "labelPersonnage";
            this.labelPersonnage.Size = new System.Drawing.Size(225, 37);
            this.labelPersonnage.TabIndex = 1;
            this.labelPersonnage.Text = "Fiche personnage";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelActeur);
            this.groupBox1.Controls.Add(this.labelNomPerso);
            this.groupBox1.Controls.Add(this.ImagePersonnage);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 279);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // ImagePersonnage
            // 
            this.ImagePersonnage.Location = new System.Drawing.Point(15, 26);
            this.ImagePersonnage.Name = "ImagePersonnage";
            this.ImagePersonnage.Size = new System.Drawing.Size(186, 231);
            this.ImagePersonnage.TabIndex = 0;
            this.ImagePersonnage.TabStop = false;
            // 
            // labelNomPerso
            // 
            this.labelNomPerso.AutoSize = true;
            this.labelNomPerso.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNomPerso.Location = new System.Drawing.Point(223, 26);
            this.labelNomPerso.Name = "labelNomPerso";
            this.labelNomPerso.Size = new System.Drawing.Size(235, 32);
            this.labelNomPerso.TabIndex = 1;
            this.labelNomPerso.Text = "Nom du personnage";
            this.labelNomPerso.Click += new System.EventHandler(this.labelNomPerso_Click);
            // 
            // labelActeur
            // 
            this.labelActeur.AutoSize = true;
            this.labelActeur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelActeur.Location = new System.Drawing.Point(223, 71);
            this.labelActeur.Name = "labelActeur";
            this.labelActeur.Size = new System.Drawing.Size(152, 28);
            this.labelActeur.TabIndex = 2;
            this.labelActeur.Text = "Nom de l\'acteur";
            this.labelActeur.Click += new System.EventHandler(this.labelActeur_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(223, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 125);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations";
            // 
            // FormPersonnage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 340);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelPersonnage);
            this.Name = "FormPersonnage";
            this.Text = "FormPersonnage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePersonnage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPersonnage;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label labelActeur;
        private Label labelNomPerso;
        private PictureBox ImagePersonnage;
    }
}