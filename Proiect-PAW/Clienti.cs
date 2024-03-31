using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_PAW.Data;
using Proiect_PAW.Models;

namespace Proiect_PAW
{
    public partial class Clienti : Form
    {
        public Clienti()
        {
            InitializeComponent();

        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                var nume = numeClientTextBox.Text;
                var telefon = telefonClientTextBox.Text;
                var sex = (Sex)Enum.Parse(typeof(Sex), sexComboBox.SelectedItem.ToString());

                var newClient = new Client(nume, sex, telefon);

                ClientCollection.Instance.AddClient(new Client("John Doe", Sex.Masculin, "1234567890"));


                MessageBox.Show("Client adaugat cu succes!");
                numeClientTextBox.Clear();
                telefonClientTextBox.Clear();
                sexComboBox.SelectedIndex = -1;

                LoadClientsIntoDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adaugarea clientului: " + ex.Message);
            }
        }

        private void LoadClientsIntoDataGridView()
        {
            DataTable clientsTable = ClientCollection.Instance.GetClientsDataTable();
            dataGridView1.DataSource = clientsTable;
            dataGridView1.Refresh(); // Ensure to refresh the DataGridView
        }

        private void ConfigureDataGridView()
        {
            // Clear any auto-generated columns
            dataGridView1.Columns.Clear();

            // Manually add columns
            dataGridView1.Columns.Add("ClientId", "Client ID");
            dataGridView1.Columns.Add("Nume", "Name");
            dataGridView1.Columns.Add("Sex", "Sex");
            dataGridView1.Columns.Add("Telefon", "Phone");

            // Rebind the data source to refresh data
            LoadClientsIntoDataGridView();
        }

        private void Clienti_Load(object sender, EventArgs e)
        {
            DataTable clientsTable = ClientCollection.Instance.GetClientsDataTable();

            // Set the DataTable as the data source for dataGridView1
            dataGridView1.DataSource = clientsTable;

            // Optionally, adjust the DataGridView properties for better UI
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Adjust columns to fill the grid
            dataGridView1.AllowUserToAddRows = false; // Disable the option to add rows directly through the DataGridView
            dataGridView1.ReadOnly = true; // Make the grid read-only if you don't want users to edit it directly

            ConfigureDataGridView();
        }
    }
}
