namespace projet_dawan
{
    partial class FormGererCompte
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModifierPassword = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.ModifierLogin = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.ConfirmPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ModifierPassword);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.ModifierLogin);
            this.groupBox1.Controls.Add(this.UserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 263);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(265, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 114);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Location = new System.Drawing.Point(0, 186);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(227, 27);
            this.ConfirmPassword.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirmer mot de passe :";
            // 
            // ModifierPassword
            // 
            this.ModifierPassword.Location = new System.Drawing.Point(133, 215);
            this.ModifierPassword.Name = "ModifierPassword";
            this.ModifierPassword.Size = new System.Drawing.Size(94, 29);
            this.ModifierPassword.TabIndex = 5;
            this.ModifierPassword.Text = "Modifier";
            this.ModifierPassword.UseVisualStyleBackColor = true;
            this.ModifierPassword.Click += new System.EventHandler(this.ModifierPassword_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(0, 133);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(227, 27);
            this.Password.TabIndex = 4;
            // 
            // ModifierLogin
            // 
            this.ModifierLogin.Location = new System.Drawing.Point(133, 79);
            this.ModifierLogin.Name = "ModifierLogin";
            this.ModifierLogin.Size = new System.Drawing.Size(94, 29);
            this.ModifierLogin.TabIndex = 3;
            this.ModifierLogin.Text = "Modifier";
            this.ModifierLogin.UseVisualStyleBackColor = true;
            this.ModifierLogin.Click += new System.EventHandler(this.ModifierLogin_Click);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(0, 46);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(227, 27);
            this.UserName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom utilisateur :";
            // 
            // FormGererCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 288);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormGererCompte";
            this.Text = "GererCompte";
            this.Load += new System.EventHandler(this.FormGererCompte_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private TextBox UserName;
        private Label label2;
        private Label label1;
        private TextBox ConfirmPassword;
        private Label label3;
        private Button ModifierPassword;
        private TextBox Password;
        private Button ModifierLogin;
        private PictureBox pictureBox1;
    }
}