namespace projet_dawan
{
    partial class PageTestSerie
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
            this.labelTestName = new System.Windows.Forms.Label();
            this.labelTestDate = new System.Windows.Forms.Label();
            this.labelTestResume = new System.Windows.Forms.Label();
            this.labelTestType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTestName
            // 
            this.labelTestName.AutoSize = true;
            this.labelTestName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTestName.Location = new System.Drawing.Point(12, 9);
            this.labelTestName.Name = "labelTestName";
            this.labelTestName.Size = new System.Drawing.Size(102, 28);
            this.labelTestName.TabIndex = 0;
            this.labelTestName.Text = "Test Name";
            // 
            // labelTestDate
            // 
            this.labelTestDate.AutoSize = true;
            this.labelTestDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTestDate.Location = new System.Drawing.Point(12, 57);
            this.labelTestDate.Name = "labelTestDate";
            this.labelTestDate.Size = new System.Drawing.Size(91, 28);
            this.labelTestDate.TabIndex = 1;
            this.labelTestDate.Text = "Test Date";
            // 
            // labelTestResume
            // 
            this.labelTestResume.AutoSize = true;
            this.labelTestResume.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTestResume.Location = new System.Drawing.Point(12, 150);
            this.labelTestResume.Name = "labelTestResume";
            this.labelTestResume.Size = new System.Drawing.Size(117, 28);
            this.labelTestResume.TabIndex = 2;
            this.labelTestResume.Text = "Test Resume";
            // 
            // labelTestType
            // 
            this.labelTestType.AutoSize = true;
            this.labelTestType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTestType.Location = new System.Drawing.Point(12, 106);
            this.labelTestType.Name = "labelTestType";
            this.labelTestType.Size = new System.Drawing.Size(91, 28);
            this.labelTestType.TabIndex = 3;
            this.labelTestType.Text = "Test Type";
            // 
            // PageTestSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.labelTestType);
            this.Controls.Add(this.labelTestResume);
            this.Controls.Add(this.labelTestDate);
            this.Controls.Add(this.labelTestName);
            this.Name = "PageTestSerie";
            this.Text = "PageTestSerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTestName;
        private Label labelTestDate;
        private Label labelTestResume;
        private Label labelTestType;
    }
}