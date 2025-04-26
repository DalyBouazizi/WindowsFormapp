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

        //clean
        private void clean()
        {
            tb_nom1.Clear();
            tb_prenom1.Clear();
            tb_tel1.Clear();
            tb_adr1.Clear();
            tb_email1.Clear();
            tb_idcl.Clear();
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
                clean();
                MessageBox.Show("Client added successfully!", "Success");
            }
            catch (Exception ex)
            {
                clean();
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(tb_idcl.Text, out int id))
                {
                    int rows = clientADO.delete_client(id);
                    if (rows > 0)
                    {

                        MessageBox.Show("Client deleted successfully!", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Client not found!", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(tb_idcl.Text, out int id))
                {
                    Client client = clientADO.get_client_by_id(id);
                    if (client != null)
                    {
                        tb_nom1.Text = client.Nom;
                        tb_prenom1.Text = client.Prenom;
                        tb_tel1.Text = client.Tel.ToString();
                        tb_adr1.Text = client.Adr;
                        tb_email1.Text = client.Mail;
                    }
                    else
                    {
                        MessageBox.Show("Client not found.", "Info");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(tb_idcl.Text, out int id))
                {
                    if (!int.TryParse(tb_tel1.Text, out int tel))
                    {
                        MessageBox.Show("Telephone must be a number.", "Error");
                        return;
                    }

                    Client client = new Client(
                        code_client: id,
                        nom: tb_nom1.Text,
                        prenom: tb_prenom1.Text,
                        adr: tb_adr1.Text,
                        tel: tel,
                        mail: tb_email1.Text
                    );

                    int rows = clientADO.update_client(client);
                    if (rows > 0)
                    {
                        clean();   
                        MessageBox.Show("Client updated successfully!", "Success");
                    }
                    else
                    {
                        clean();
                        MessageBox.Show("Update failed. Client might not exist.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }
    }
}