namespace projet_dawan.Controls
{
    partial class LastSerieAdd
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNew = new System.Windows.Forms.Button();
            this.newAffiche = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.newAffiche)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(8, 210);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(143, 46);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "Titre 1";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // newAffiche
            // 
            this.newAffiche.ImageLocation = "C:\\Users\\Admin Stagiaire\\Desktop\\projet_dawan\\projet_dawan\\bin\\Debug\\net6.0-windo" +
    "ws\\photo\\affiche wandavision.jpg";
            this.newAffiche.Location = new System.Drawing.Point(11, 3);
            this.newAffiche.Name = "newAffiche";
            this.newAffiche.Size = new System.Drawing.Size(143, 179);
            this.newAffiche.TabIndex = 6;
            this.newAffiche.TabStop = false;
            this.newAffiche.Click += new System.EventHandler(this.newAffiche_Click);
            // 
            // LastSerieAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.newAffiche);
            this.Name = "LastSerieAdd";
            this.Size = new System.Drawing.Size(154, 542);
            ((System.ComponentModel.ISupportInitialize)(this.newAffiche)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnNew;
        private PictureBox newAffiche;
    }
}
