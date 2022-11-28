namespace projet_dawan
{
    partial class FormAccueil
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
            this.watchlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDeco = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(791, 30);
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
            this.toolStripBibli.Size = new System.Drawing.Size(200, 26);
            this.toolStripBibli.Text = "&Bibliothéque";
            this.toolStripBibli.Click += new System.EventHandler(this.toolStripBibli_Click);
            // 
            // toolStripAddSerie
            // 
            this.toolStripAddSerie.Name = "toolStripAddSerie";
            this.toolStripAddSerie.Size = new System.Drawing.Size(200, 26);
            this.toolStripAddSerie.Text = "&AjouterSéries";
            this.toolStripAddSerie.Click += new System.EventHandler(this.toolStripAddSerie_Click);
            // 
            // toolStripDeleteSerie
            // 
            this.toolStripDeleteSerie.Name = "toolStripDeleteSerie";
            this.toolStripDeleteSerie.Size = new System.Drawing.Size(200, 26);
            this.toolStripDeleteSerie.Text = "&SupprimerSéries";
            this.toolStripDeleteSerie.Click += new System.EventHandler(this.toolStripDeleteSerie_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // toolStripCompte
            // 
            this.toolStripCompte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGerer,
            this.watchlistToolStripMenuItem,
            this.toolStripDeco});
            this.toolStripCompte.Name = "toolStripCompte";
            this.toolStripCompte.Size = new System.Drawing.Size(76, 24);
            this.toolStripCompte.Text = "&Compte";
            // 
            // toolStripGerer
            // 
            this.toolStripGerer.Name = "toolStripGerer";
            this.toolStripGerer.Size = new System.Drawing.Size(179, 26);
            this.toolStripGerer.Text = "&Gérer";
            this.toolStripGerer.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripGerer.Click += new System.EventHandler(this.toolStripGerer_Click);
            // 
            // watchlistToolStripMenuItem
            // 
            this.watchlistToolStripMenuItem.Name = "watchlistToolStripMenuItem";
            this.watchlistToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.watchlistToolStripMenuItem.Text = "&Watchlist";
            this.watchlistToolStripMenuItem.Click += new System.EventHandler(this.watchlistToolStripMenuItem_Click);
            // 
            // toolStripDeco
            // 
            this.toolStripDeco.Name = "toolStripDeco";
            this.toolStripDeco.Size = new System.Drawing.Size(179, 26);
            this.toolStripDeco.Text = "&Deconnexion";
            this.toolStripDeco.Click += new System.EventHandler(this.toolStripDeco_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(413, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACCEUIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(217, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rechercher :";
            // 
            // txtRechercher
            // 
            this.txtRechercher.Location = new System.Drawing.Point(320, 77);
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(302, 27);
            this.txtRechercher.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 279);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dernières séries ajoutées :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(627, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 403);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAccueil";
            this.Text = "PageAcceuil";
            this.Load += new System.EventHandler(this.PageAcceuil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private Label label3;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem watchlistToolStripMenuItem;
        private Button btnSearch;
    }
}