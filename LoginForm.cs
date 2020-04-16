using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_And_Register
{
    public partial class LoginForm : Form
    {



        

        public LoginForm()
        {
            InitializeComponent();

            
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.Black;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.White;
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn and `password` = @pass", db.getConnection());

            command.Parameters.Add("@usn",MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.Show();


            }
            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username to Login");
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login");
                }
                else 
                {
                    MessageBox.Show("Wrong Username Or Password");
                }

            }

        }

        private void labelGoToSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();

        }

        private void labelGoToSignUp_MouseEnter(object sender, EventArgs e)
        {
            labelGoToSignUp.ForeColor = Color.LightBlue;
        }

        private void labelGoToSignUp_MouseLeave(object sender, EventArgs e)
        {
            labelGoToSignUp.ForeColor = Color.White;
        }
    }
}
