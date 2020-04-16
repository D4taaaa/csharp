namespace Login_And_Register
{
    partial class RegisterForm
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
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGoToLogIn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.labelGoToLogIn);
            this.panel1.Controls.Add(this.textBoxPasswordConfirm);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.textBoxLastname);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxFirstname);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 647);
            this.panel1.TabIndex = 1;
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordConfirm.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(42, 462);
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(800, 52);
            this.textBoxPasswordConfirm.TabIndex = 9;
            this.textBoxPasswordConfirm.Text = "Confirm password";
            this.textBoxPasswordConfirm.Enter += new System.EventHandler(this.textBoxPasswordConfirm_Enter);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.Location = new System.Drawing.Point(42, 396);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(800, 52);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUsername.Location = new System.Drawing.Point(42, 329);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(800, 52);
            this.textBoxUsername.TabIndex = 7;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastname.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLastname.Location = new System.Drawing.Point(445, 191);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(397, 52);
            this.textBoxLastname.TabIndex = 6;
            this.textBoxLastname.Text = "Surname";
            this.textBoxLastname.Enter += new System.EventHandler(this.textBoxLastname_Enter);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(104)))), ((int)(((byte)(46)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(42, 532);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(800, 50);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "CREATE ACCOUNT";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(42, 259);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(800, 52);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstname.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFirstname.Location = new System.Drawing.Point(42, 191);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(397, 52);
            this.textBoxFirstname.TabIndex = 200;
            this.textBoxFirstname.Text = "Name";
            this.textBoxFirstname.Enter += new System.EventHandler(this.textBoxFirstname_Enter);
            this.textBoxFirstname.Leave += new System.EventHandler(this.textBoxFirstname_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.panel2.Controls.Add(this.labelExit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 122);
            this.panel2.TabIndex = 0;
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.Black;
            this.labelExit.Location = new System.Drawing.Point(845, 9);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(26, 25);
            this.labelExit.TabIndex = 1;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            this.labelExit.Enter += new System.EventHandler(this.labelExit_Enter);
            this.labelExit.Leave += new System.EventHandler(this.labelExit_Leave);
            this.labelExit.MouseEnter += new System.EventHandler(this.labelExit_MouseEnter);
            this.labelExit.MouseLeave += new System.EventHandler(this.labelExit_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(885, 122);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGoToLogIn
            // 
            this.labelGoToLogIn.AutoSize = true;
            this.labelGoToLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGoToLogIn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoToLogIn.ForeColor = System.Drawing.Color.White;
            this.labelGoToLogIn.Location = new System.Drawing.Point(321, 599);
            this.labelGoToLogIn.Name = "labelGoToLogIn";
            this.labelGoToLogIn.Size = new System.Drawing.Size(236, 16);
            this.labelGoToLogIn.TabIndex = 201;
            this.labelGoToLogIn.Text = "Already Have An Account? Sign In Here!";
            this.labelGoToLogIn.Click += new System.EventHandler(this.labelGoToLogIn_Click);
            this.labelGoToLogIn.MouseEnter += new System.EventHandler(this.labelGoToLogIn_MouseEnter);
            this.labelGoToLogIn.MouseLeave += new System.EventHandler(this.labelGoToLogIn_MouseLeave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 646);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPasswordConfirm;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Label labelGoToLogIn;
    }
}