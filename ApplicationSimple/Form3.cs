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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string input = tb_date.Text;
            string[] parts = input.Split('/');

            int JourDeSemaine = Int16.Parse(parts[0]);
            int Jour = Int16.Parse(parts[1]);
            int Mois = Int16.Parse(parts[2]);
            ConvertDate(JourDeSemaine, Jour, Mois);



        }

 

        public void ConvertDate(int weekDay, int day, int month)
        {
            string[] daysOfWeek = { "", "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            string[] months = { "", "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet",
                        "Août", "Septembre", "Octobre", "Novembre", "Décembre" };

            if (weekDay >= 1 && weekDay <= 7 && month >= 1 && month <= 12)
            {
               String result = " "+daysOfWeek[weekDay] + " " + day + " " + months[month];

                MessageBox.Show(result,"TEST",MessageBoxButtons.YesNo,MessageBoxIcon.Information );
                Console.Write(result);
                
                //label_res.Text += result;
            }
            else
            {

                MessageBox.Show("Date non valide", "TEST", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            }
        }
           
        }

       
    }

