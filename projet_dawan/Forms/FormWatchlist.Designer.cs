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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(352, 148);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(95, 25);
            this.btnClearAll.TabIndex = 0;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnExportList
            // 
            this.btnExportList.Location = new System.Drawing.Point(352, 109);
            this.btnExportList.Name = "btnExportList";
            this.btnExportList.Size = new System.Drawing.Size(95, 33);
            this.btnExportList.TabIndex = 1;
            this.btnExportList.Text = "Save";
            this.btnExportList.UseVisualStyleBackColor = true;
            this.btnExportList.Click += new System.EventHandler(this.btnExportList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBoxWatchlist);
            this.groupBox1.Controls.Add(this.btnClearAll);
            this.groupBox1.Controls.Add(this.btnExportList);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(452, 188);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lstBoxWatchlist
            // 
            this.lstBoxWatchlist.FormattingEnabled = true;
            this.lstBoxWatchlist.ItemHeight = 15;
            this.lstBoxWatchlist.Location = new System.Drawing.Point(5, 20);
            this.lstBoxWatchlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBoxWatchlist.Name = "lstBoxWatchlist";
            this.lstBoxWatchlist.Size = new System.Drawing.Size(342, 154);
            this.lstBoxWatchlist.TabIndex = 2;
            // 
            // FormWatchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 209);
            this.Controls.Add(this.groupBox1);
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
        private ListBox lstBoxWatchlist;
    }
}