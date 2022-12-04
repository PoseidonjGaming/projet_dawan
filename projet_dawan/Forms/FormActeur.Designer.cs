namespace projet_dawan.Forms
{
    partial class FormActeur
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
            this.labelActeur = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageActeur = new System.Windows.Forms.PictureBox();
            this.listBoxApparition = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageActeur)).BeginInit();
            this.SuspendLayout();
            // 
            // labelActeur
            // 
            this.labelActeur.AutoSize = true;
            this.labelActeur.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelActeur.Location = new System.Drawing.Point(12, 9);
            this.labelActeur.Name = "labelActeur";
            this.labelActeur.Size = new System.Drawing.Size(323, 37);
            this.labelActeur.TabIndex = 2;
            this.labelActeur.Text = "Fiche Acteur : Nom Acteur";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.listBoxApparition);
            this.groupBox1.Controls.Add(this.imageActeur);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 271);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // imageActeur
            // 
            this.imageActeur.Location = new System.Drawing.Point(6, 26);
            this.imageActeur.Name = "imageActeur";
            this.imageActeur.Size = new System.Drawing.Size(172, 230);
            this.imageActeur.TabIndex = 0;
            this.imageActeur.TabStop = false;
            // 
            // listBoxApparition
            // 
            this.listBoxApparition.FormattingEnabled = true;
            this.listBoxApparition.ItemHeight = 20;
            this.listBoxApparition.Location = new System.Drawing.Point(184, 152);
            this.listBoxApparition.Name = "listBoxApparition";
            this.listBoxApparition.Size = new System.Drawing.Size(320, 104);
            this.listBoxApparition.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(184, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Biographie de l\'acteur";
            // 
            // FormActeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 340);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelActeur);
            this.Name = "FormActeur";
            this.Text = "FormActeur";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageActeur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelActeur;
        private GroupBox groupBox1;
        private PictureBox imageActeur;
        private ListBox listBoxApparition;
        private GroupBox groupBox2;
    }
}