namespace projet_dawan
{
    partial class FormWatchlist
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
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnExportList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBoxWatchlist = new System.Windows.Forms.ListBox();
            this.saveFileDialogWatchList = new System.Windows.Forms.SaveFileDialog();
<<<<<<< HEAD
=======
            this.btnLoad = new System.Windows.Forms.Button();
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
            this.openFileDialogLoad = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(402, 197);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(109, 33);
            this.btnClearAll.TabIndex = 0;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnExportList
            // 
            this.btnExportList.Location = new System.Drawing.Point(402, 145);
            this.btnExportList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportList.Name = "btnExportList";
            this.btnExportList.Size = new System.Drawing.Size(109, 44);
            this.btnExportList.TabIndex = 1;
            this.btnExportList.Text = "Save";
            this.btnExportList.UseVisualStyleBackColor = true;
            this.btnExportList.Click += new System.EventHandler(this.btnExportList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.lstBoxWatchlist);
            this.groupBox1.Controls.Add(this.btnClearAll);
            this.groupBox1.Controls.Add(this.btnExportList);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 251);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lstBoxWatchlist
            // 
            this.lstBoxWatchlist.FormattingEnabled = true;
            this.lstBoxWatchlist.ItemHeight = 20;
            this.lstBoxWatchlist.Location = new System.Drawing.Point(6, 27);
            this.lstBoxWatchlist.Name = "lstBoxWatchlist";
            this.lstBoxWatchlist.Size = new System.Drawing.Size(390, 204);
            this.lstBoxWatchlist.TabIndex = 2;
            // 
<<<<<<< HEAD
            // openFileDialogLoad
            // 
            this.openFileDialogLoad.FileName = "openFileDialog1";
=======
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(402, 109);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(109, 29);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialogLoad
            // 
            this.openFileDialogLoad.FileName = "openFileDialogLoad";
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
            // 
            // FormWatchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 279);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormWatchlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Watchlist";
            this.Load += new System.EventHandler(this.FormWatchlist_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnClearAll;
        private Button btnExportList;
        private GroupBox groupBox1;
        public ListBox lstBoxWatchlist;
        public SaveFileDialog saveFileDialogWatchList;
<<<<<<< HEAD
=======
        private Button btnLoad;
>>>>>>> f984640f1965c9eef8b8e8c88742c195a1fc19ce
        public OpenFileDialog openFileDialogLoad;
    }
}