using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationSimple
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(tb_username.Text=="admin" && tb_password.Text=="admin")
            {
                MessageBox.Show("Login Success");
            }
            else
            {
                MessageBox.Show("Login Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_empty_Click(object sender, EventArgs e)
        {
            tb_username.Text = "";
            tb_password.Text = "";  
        }
    }
}
