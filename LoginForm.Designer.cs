namespace Login_And_Register
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGoToSignUp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.labelGoToSignUp);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 444);
            this.panel1.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(104)))), ((int)(((byte)(46)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(39, 327);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(452, 50);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(94, 232);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(397, 49);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Login_And_Register.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(39, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(94, 149);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(397, 49);
            this.textBoxUsername.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login_And_Register.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(38, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.panel2.Controls.Add(this.labelExit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 122);
            this.panel2.TabIndex = 0;
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.White;
            this.labelExit.Location = new System.Drawing.Point(492, 10);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(26, 25);
            this.labelExit.TabIndex = 1;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            this.labelExit.MouseEnter += new System.EventHandler(this.labelExit_MouseEnter);
            this.labelExit.MouseLeave += new System.EventHandler(this.labelExit_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 122);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGoToSignUp
            // 
            this.labelGoToSignUp.AutoSize = true;
            this.labelGoToSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGoToSignUp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoToSignUp.ForeColor = System.Drawing.Color.White;
            this.labelGoToSignUp.Location = new System.Drawing.Point(141, 407);
            this.labelGoToSignUp.Name = "labelGoToSignUp";
            this.labelGoToSignUp.Size = new System.Drawing.Size(226, 16);
            this.labelGoToSignUp.TabIndex = 7;
            this.labelGoToSignUp.Text = "Don\'t Have An Account? Sign Up Here!";
            this.labelGoToSignUp.Click += new System.EventHandler(this.labelGoToSignUp_Click);
            this.labelGoToSignUp.MouseEnter += new System.EventHandler(this.labelGoToSignUp_MouseEnter);
            this.labelGoToSignUp.MouseLeave += new System.EventHandler(this.labelGoToSignUp_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 442);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelGoToSignUp;
    }
}