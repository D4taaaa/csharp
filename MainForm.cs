using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Login_And_Register
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.Black;
        }

        private void labelExit_Leave(object sender, EventArgs e)
        {
            //missclick
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.White;
        }
    }
}
