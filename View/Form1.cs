using System;
using System.Windows.Forms;
using Model;      // For Client class
using Controller; // For ClientADO class

namespace View
{
    public partial class Form1 : Form
    {
        private ClientADO clientADO = new ClientADO(); // Initialize ClientADO

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(
                //    $"Nom: {tb_nom1.Text}\n" +
                //    $"Prenom: {tb_prenom1.Text}\n" +
                //    $"Tel: {tb_tel1.Text}\n" +
                //    $"Address: {tb_adr1.Text}\n" +
                //    $"Email: {tb_email1.Text}",
                //    "Field Values"
                //);

                // Validate inputs (basic example)
                if (string.IsNullOrEmpty(tb_nom1.Text) || string.IsNullOrEmpty(tb_prenom1.Text))
                {
                
                    MessageBox.Show("Nom and Prenom are required!", "Error");
                    return;
                }

                // Parse telephone (assuming it's numeric)
                if (!int.TryParse(tb_tel1.Text, out int tel))
                {
                    
                    MessageBox.Show("Telephone must be a number.", "Error");
                    return;
                }

                // Create Client object (Model)
                Client client = new Client(
                    code_client: 0, // Assuming auto-increment ID in DB
                    nom: tb_nom1.Text,
                    prenom: tb_prenom1.Text,
                    adr: tb_adr1.Text,
                    tel: tel,
                    mail: tb_email1.Text
                );

                // Insert into database using ClientADO (Controller)
                clientADO.insert_client(client);

                MessageBox.Show("Client added successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}