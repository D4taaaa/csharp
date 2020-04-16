using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login_And_Register
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxFirstname_Enter(object sender, EventArgs e)
        {
            String fname = textBoxFirstname.Text;
            if (fname.Equals("Name"))
            {
                textBoxFirstname.Text = "";
                textBoxFirstname.ForeColor = Color.Black;
            }
        }

        private void textBoxFirstname_Leave(object sender, EventArgs e)
        {
            //useless
        }

        private void textBoxLastname_Enter(object sender, EventArgs e)
        {
            String lname = textBoxLastname.Text;
            if (lname.Equals("Surname"))
            {
                textBoxLastname.Text = "";
                textBoxLastname.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.Equals("Email"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            String uname = textBoxUsername.Text;
            if (uname.Equals("Username"))
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            String pass = textBoxPassword.Text;
            if (pass.Equals("Password"))
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPasswordConfirm_Enter(object sender, EventArgs e)
        {
            String cpass = textBoxPasswordConfirm.Text;
            if (cpass.Equals("Confirm password"))
            {
                textBoxPasswordConfirm.Text = "";
                textBoxPasswordConfirm.ForeColor = Color.Black;
                textBoxPasswordConfirm.UseSystemPasswordChar = true;
            }
        }

        
        //For Some reason these two dont work
        //i figured it out :P
        private void labelExit_Enter(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.White;
        }

        private void labelExit_Leave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.Black;
        }

        //These work :D

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.White;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.Black;
        }

        
        //User Registration part :)
        private void buttonRegister_Click(object sender, EventArgs e)
        {


            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`name`, `surname`, `email`, `username`, `password`) VALUES (@fn, @ln, @email, @usn, @pass)", db.getConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBoxFirstname.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textBoxLastname.Text;
            command.Parameters.Add("email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            db.openConnection();



            if (!CheckBoxTextValue())
            {

                if (textBoxPassword.Text.Equals(textBoxPasswordConfirm.Text))
                {
                    if (CheckUsername())
                    {
                        MessageBox.Show("This Username Is Taken");
                    }
                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account Has Been Created!");
                        }
                        else
                        {
                            MessageBox.Show("Error, Most Likely The Database Is Down");
                        }


                    }
                }
                else
                {
                    MessageBox.Show("Passwords don't match");
                }
            }

                
            else
            {
                MessageBox.Show("Fill All The Boxes");
            }

            
            db.closeConnection();




        }

        public bool CheckUsername()
        {
            DB db = new DB();
            String username = textBoxUsername.Text;
            

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn and `username` = @usn", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
            
        }

        public bool CheckBoxTextValue()
        {
            String fname = textBoxLastname.Text;
            String lname = textBoxLastname.Text;
            String email = textBoxEmail.Text;
            String uname = textBoxUsername.Text;
            String pass = textBoxPassword.Text;
            if(fname.Equals("Name") || fname.Equals("") || lname.Equals("Surname") || lname.Equals("") || email.Equals("Email") || email.Equals("") || uname.Equals("Username") || uname.Equals("") || pass.Equals("Password") || pass.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void labelGoToLogIn_MouseEnter(object sender, EventArgs e)
        {
            labelGoToLogIn.ForeColor = Color.LightBlue;
        }

        private void labelGoToLogIn_MouseLeave(object sender, EventArgs e)
        {
            labelGoToLogIn.ForeColor = Color.White;
        }

        private void labelGoToLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }
    }
}
