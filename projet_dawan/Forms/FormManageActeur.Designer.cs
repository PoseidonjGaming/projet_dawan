namespace projet_dawan.Forms
{
    partial class FormManageActeur
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
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.groupBoxAdd_Update = new System.Windows.Forms.GroupBox();
            this.btnNewActeur = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstBoxActeur = new System.Windows.Forms.ListBox();
            this.groupBoxAdd_Update.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(69, 22);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNom.TabIndex = 0;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(69, 54);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 23);
            this.txtPrenom.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 25);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(40, 15);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom: ";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(6, 57);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(55, 15);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prénom: ";
            // 
            // groupBoxAdd_Update
            // 
            this.groupBoxAdd_Update.Controls.Add(this.btnNewActeur);
            this.groupBoxAdd_Update.Controls.Add(this.btnSup);
            this.groupBoxAdd_Update.Controls.Add(this.btnAdd);
            this.groupBoxAdd_Update.Controls.Add(this.txtBoxNom);
            this.groupBoxAdd_Update.Controls.Add(this.lblPrenom);
            this.groupBoxAdd_Update.Controls.Add(this.txtPrenom);
            this.groupBoxAdd_Update.Controls.Add(this.lblNom);
            this.groupBoxAdd_Update.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAdd_Update.Name = "groupBoxAdd_Update";
            this.groupBoxAdd_Update.Size = new System.Drawing.Size(176, 143);
            this.groupBoxAdd_Update.TabIndex = 4;
            this.groupBoxAdd_Update.TabStop = false;
            this.groupBoxAdd_Update.Text = "Gérer un acteur";
            // 
            // btnNewActeur
            // 
            this.btnNewActeur.Location = new System.Drawing.Point(6, 112);
            this.btnNewActeur.Name = "btnNewActeur";
            this.btnNewActeur.Size = new System.Drawing.Size(163, 23);
            this.btnNewActeur.TabIndex = 6;
            this.btnNewActeur.Text = "Nouvel Acteur";
            this.btnNewActeur.UseVisualStyleBackColor = true;
            this.btnNewActeur.Click += new System.EventHandler(this.btnNewActeur_Click);
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(87, 83);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(82, 23);
            this.btnSup.TabIndex = 5;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstBoxActeur
            // 
            this.lstBoxActeur.FormattingEnabled = true;
            this.lstBoxActeur.ItemHeight = 15;
            this.lstBoxActeur.Location = new System.Drawing.Point(12, 161);
            this.lstBoxActeur.Name = "lstBoxActeur";
            this.lstBoxActeur.Size = new System.Drawing.Size(176, 214);
            this.lstBoxActeur.TabIndex = 5;
            this.lstBoxActeur.SelectedIndexChanged += new System.EventHandler(this.lstBoxActeur_SelectedIndexChanged);
            // 
            // FormManageActeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 387);
            this.Controls.Add(this.lstBoxActeur);
            this.Controls.Add(this.groupBoxAdd_Update);
            this.Name = "FormManageActeur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gérer les acteurs";
            this.Load += new System.EventHandler(this.FormManageActeur_Load);
            this.groupBoxAdd_Update.ResumeLayout(false);
            this.groupBoxAdd_Update.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtBoxNom;
        private TextBox txtPrenom;
        private Label lblNom;
        private Label lblPrenom;
        private GroupBox groupBoxAdd_Update;
        private Button btnSup;
        private Button btnAdd;
        private ListBox lstBoxActeur;
        private Button btnNewActeur;
    }
}