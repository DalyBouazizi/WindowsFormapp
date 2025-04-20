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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = Int16.Parse(tb_number.Text);
            verifierPerfect(a);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_number_TextChanged(object sender, EventArgs e)
        {
          

        }

        public void verifierPerfect(int a)
        {
            int somme = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    somme += i;
                }
            }
            if (somme == a)
            {
                MessageBox.Show(a + " est un nombre est parfait");
            }
            else
            {
                MessageBox.Show(a + " est un nombre n'est pas parfait");
            }
        }
    }
}
