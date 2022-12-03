namespace EntityFrameWorkApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrnom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrnom = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(12, 12);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 23);
            this.textBoxNom.TabIndex = 0;
            // 
            // textBoxPrnom
            // 
            this.textBoxPrnom.Location = new System.Drawing.Point(12, 41);
            this.textBoxPrnom.Name = "textBoxPrnom";
            this.textBoxPrnom.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrnom.TabIndex = 1;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(118, 15);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(34, 15);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Nom";
            // 
            // labelPrnom
            // 
            this.labelPrnom.AutoSize = true;
            this.labelPrnom.Location = new System.Drawing.Point(118, 44);
            this.labelPrnom.Name = "labelPrnom";
            this.labelPrnom.Size = new System.Drawing.Size(49, 15);
            this.labelPrnom.TabIndex = 3;
            this.labelPrnom.Text = "Prénom";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 70);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 214);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 329);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelPrnom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxPrnom);
            this.Controls.Add(this.textBoxNom);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNom;
        private TextBox textBoxPrnom;
        private Label labelNom;
        private Label labelPrnom;
        private Button buttonAdd;
        private ListBox listBox1;
    }
}