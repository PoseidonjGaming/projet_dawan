namespace projet_dawan
{
    partial class PageAcceuil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBibli = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAddSerie = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDeleteSerie = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCompte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGerer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDeco = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNew4 = new System.Windows.Forms.Button();
            this.btnNew3 = new System.Windows.Forms.Button();
            this.btnNew2 = new System.Windows.Forms.Button();
            this.btnNew1 = new System.Windows.Forms.Button();
            this.newAffiche4 = new System.Windows.Forms.PictureBox();
            this.newAffiche3 = new System.Windows.Forms.PictureBox();
            this.newAffiche2 = new System.Windows.Forms.PictureBox();
            this.newAffiche1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newAffiche4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAffiche3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAffiche2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAffiche1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu,
            this.toolStripCompte});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBibli,
            this.toolStripAddSerie,
            this.toolStripDeleteSerie,
            this.quitterToolStripMenuItem});
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(60, 24);
            this.toolStripMenu.Text = "&Menu";
            // 
            // toolStripBibli
            // 
            this.toolStripBibli.Name = "toolStripBibli";
            this.toolStripBibli.Size = new System.Drawing.Size(224, 26);
            this.toolStripBibli.Text = "&Bibliothéque";
            this.toolStripBibli.Click += new System.EventHandler(this.toolStripBibli_Click);
            // 
            // toolStripAddSerie
            // 
            this.toolStripAddSerie.Name = "toolStripAddSerie";
            this.toolStripAddSerie.Size = new System.Drawing.Size(224, 26);
            this.toolStripAddSerie.Text = "&AjouterSéries";
            this.toolStripAddSerie.Click += new System.EventHandler(this.toolStripAddSerie_Click);
            // 
            // toolStripDeleteSerie
            // 
            this.toolStripDeleteSerie.Name = "toolStripDeleteSerie";
            this.toolStripDeleteSerie.Size = new System.Drawing.Size(224, 26);
            this.toolStripDeleteSerie.Text = "&SupprimerSéries";
            this.toolStripDeleteSerie.Click += new System.EventHandler(this.toolStripDeleteSerie_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // toolStripCompte
            // 
            this.toolStripCompte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGerer,
            this.toolStripDeco});
            this.toolStripCompte.Name = "toolStripCompte";
            this.toolStripCompte.Size = new System.Drawing.Size(76, 24);
            this.toolStripCompte.Text = "&Compte";
            // 
            // toolStripGerer
            // 
            this.toolStripGerer.Name = "toolStripGerer";
            this.toolStripGerer.Size = new System.Drawing.Size(224, 26);
            this.toolStripGerer.Text = "&Gérer";
            // 
            // toolStripDeco
            // 
            this.toolStripDeco.Name = "toolStripDeco";
            this.toolStripDeco.Size = new System.Drawing.Size(224, 26);
            this.toolStripDeco.Text = "&Deconnexion";
            this.toolStripDeco.Click += new System.EventHandler(this.toolStripDeco_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(324, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACCEUIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(376, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rechercher :";
            // 
            // txtRechercher
            // 
            this.txtRechercher.Location = new System.Drawing.Point(486, 105);
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(302, 27);
            this.txtRechercher.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNew4);
            this.groupBox1.Controls.Add(this.btnNew3);
            this.groupBox1.Controls.Add(this.btnNew2);
            this.groupBox1.Controls.Add(this.btnNew1);
            this.groupBox1.Controls.Add(this.newAffiche4);
            this.groupBox1.Controls.Add(this.newAffiche3);
            this.groupBox1.Controls.Add(this.newAffiche2);
            this.groupBox1.Controls.Add(this.newAffiche1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 300);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnNew4
            // 
            this.btnNew4.Location = new System.Drawing.Point(597, 247);
            this.btnNew4.Name = "btnNew4";
            this.btnNew4.Size = new System.Drawing.Size(143, 29);
            this.btnNew4.TabIndex = 8;
            this.btnNew4.Text = "Titre 4";
            this.btnNew4.UseVisualStyleBackColor = true;
            // 
            // btnNew3
            // 
            this.btnNew3.Location = new System.Drawing.Point(413, 247);
            this.btnNew3.Name = "btnNew3";
            this.btnNew3.Size = new System.Drawing.Size(143, 29);
            this.btnNew3.TabIndex = 7;
            this.btnNew3.Text = "Titre 3";
            this.btnNew3.UseVisualStyleBackColor = true;
            // 
            // btnNew2
            // 
            this.btnNew2.Location = new System.Drawing.Point(220, 247);
            this.btnNew2.Name = "btnNew2";
            this.btnNew2.Size = new System.Drawing.Size(143, 29);
            this.btnNew2.TabIndex = 6;
            this.btnNew2.Text = "Titre 2";
            this.btnNew2.UseVisualStyleBackColor = true;
            // 
            // btnNew1
            // 
            this.btnNew1.Location = new System.Drawing.Point(33, 247);
            this.btnNew1.Name = "btnNew1";
            this.btnNew1.Size = new System.Drawing.Size(143, 29);
            this.btnNew1.TabIndex = 5;
            this.btnNew1.Text = "Titre 1";
            this.btnNew1.UseVisualStyleBackColor = true;
            // 
            // newAffiche4
            // 
            this.newAffiche4.Location = new System.Drawing.Point(597, 62);
            this.newAffiche4.Name = "newAffiche4";
            this.newAffiche4.Size = new System.Drawing.Size(143, 179);
            this.newAffiche4.TabIndex = 4;
            this.newAffiche4.TabStop = false;
            // 
            // newAffiche3
            // 
            this.newAffiche3.Location = new System.Drawing.Point(413, 62);
            this.newAffiche3.Name = "newAffiche3";
            this.newAffiche3.Size = new System.Drawing.Size(143, 179);
            this.newAffiche3.TabIndex = 3;
            this.newAffiche3.TabStop = false;
            // 
            // newAffiche2
            // 
            this.newAffiche2.Location = new System.Drawing.Point(220, 62);
            this.newAffiche2.Name = "newAffiche2";
            this.newAffiche2.Size = new System.Drawing.Size(143, 179);
            this.newAffiche2.TabIndex = 2;
            this.newAffiche2.TabStop = false;
            // 
            // newAffiche1
            // 
            this.newAffiche1.Location = new System.Drawing.Point(33, 62);
            this.newAffiche1.Name = "newAffiche1";
            this.newAffiche1.Size = new System.Drawing.Size(143, 179);
            this.newAffiche1.TabIndex = 1;
            this.newAffiche1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dernières séries ajoutées :";
            // 
            // PageAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PageAcceuil";
            this.Text = "PageAcceuil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newAffiche4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAffiche3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAffiche2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAffiche1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenu;
        private ToolStripMenuItem toolStripCompte;
        private Label label1;
        private Label label2;
        private TextBox txtRechercher;
        private ToolStripMenuItem toolStripBibli;
        private ToolStripMenuItem toolStripAddSerie;
        private ToolStripMenuItem toolStripDeleteSerie;
        private ToolStripMenuItem toolStripGerer;
        private ToolStripMenuItem toolStripDeco;
        private GroupBox groupBox1;
        private PictureBox newAffiche4;
        private PictureBox newAffiche3;
        private PictureBox newAffiche2;
        private PictureBox newAffiche1;
        private Label label3;
        private Button btnNew4;
        private Button btnNew3;
        private Button btnNew2;
        private Button btnNew1;
        private ToolStripMenuItem quitterToolStripMenuItem;
    }
}