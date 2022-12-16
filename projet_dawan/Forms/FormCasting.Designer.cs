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
            this.labelCasting = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelActeur = new System.Windows.Forms.Label();
            this.labelNomPerso = new System.Windows.Forms.Label();
            this.imagePersonnage = new System.Windows.Forms.PictureBox();
            this.listBoxCasting = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonnage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCasting
            // 
            this.labelCasting.AutoSize = true;
            this.labelCasting.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCasting.Location = new System.Drawing.Point(18, 20);
            this.labelCasting.Name = "labelCasting";
            this.labelCasting.Size = new System.Drawing.Size(252, 37);
            this.labelCasting.TabIndex = 0;
            this.labelCasting.Text = "Casting / Nom série";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelActeur);
            this.groupBox1.Controls.Add(this.labelNomPerso);
            this.groupBox1.Controls.Add(this.imagePersonnage);
            this.groupBox1.Controls.Add(this.listBoxCasting);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 284);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(305, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Interprété par :";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(305, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 110);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations";
            // 
            // labelActeur
            // 
            this.labelActeur.AutoSize = true;
            this.labelActeur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelActeur.Location = new System.Drawing.Point(305, 119);
            this.labelActeur.Name = "labelActeur";
            this.labelActeur.Size = new System.Drawing.Size(115, 28);
            this.labelActeur.TabIndex = 3;
            this.labelActeur.Text = "Nom acteur";
            // 
            // labelNomPerso
            // 
            this.labelNomPerso.AutoSize = true;
            this.labelNomPerso.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNomPerso.Location = new System.Drawing.Point(305, 43);
            this.labelNomPerso.Name = "labelNomPerso";
            this.labelNomPerso.Size = new System.Drawing.Size(238, 37);
            this.labelNomPerso.TabIndex = 2;
            this.labelNomPerso.Text = "Nom personnage";
            // 
            // imagePersonnage
            // 
            this.imagePersonnage.Location = new System.Drawing.Point(554, 26);
            this.imagePersonnage.Name = "imagePersonnage";
            this.imagePersonnage.Size = new System.Drawing.Size(125, 121);
            this.imagePersonnage.TabIndex = 1;
            this.imagePersonnage.TabStop = false;
            // 
            // listBoxCasting
            // 
            this.listBoxCasting.FormattingEnabled = true;
            this.listBoxCasting.ItemHeight = 20;
            this.listBoxCasting.Location = new System.Drawing.Point(6, 26);
            this.listBoxCasting.Name = "listBoxCasting";
            this.listBoxCasting.Size = new System.Drawing.Size(281, 244);
            this.listBoxCasting.TabIndex = 0;
            this.listBoxCasting.SelectedIndexChanged += new System.EventHandler(this.listBoxCasting_SelectedIndexChanged);
            // 
            // FormCasting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelCasting);
            this.Name = "FormCasting";
            this.Text = "FormCasting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePersonnage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label labelCasting;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        public Label labelActeur;
        public Label labelNomPerso;
        public PictureBox imagePersonnage;
        public ListBox listBoxCasting;
        private Label label1;
    }
}