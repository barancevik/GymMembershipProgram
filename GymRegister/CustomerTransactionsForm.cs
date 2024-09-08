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

namespace GymRegister
{
    public partial class CustomerTransactionsForm : Form
    {
        string connectionString = "server=localhost;user id=root;password=33london;database=GymMembership";

        public CustomerTransactionsForm()
        {
            InitializeComponent();
        }

        private void bbtnAddCustomer_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int months = Convert.ToInt32(txtMonths.Text);

            AddCustomer(firstName, lastName, months);



        }

        private void AddCustomer(string firstName, string lastName, int months)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Customers (FirstName, LastName, RegistrationDate, MembershipMonths, EndDate) VALUES (@firstName, @lastName, @registrationDate, @months, @endDate)", con);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@registrationDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@months", months);
                cmd.Parameters.AddWithValue("@endDate", DateTime.Now.AddMonths(months));
                cmd.ExecuteNonQuery();
            }



        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int customerId;
            
            if (int.TryParse(txtCustomerId.Text, out customerId))
            {
                
                DeleteCustomer(customerId);
            }
            else
            {
                
                MessageBox.Show("Please enter a valid customer ID.", "Incorrect Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteCustomer(int customerId)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Customers WHERE ID = @id", con);
                cmd.Parameters.AddWithValue("@id", customerId);
                cmd.ExecuteNonQuery();
            }
        }
        private void CustomerTransactionsForm_Load(object sender, EventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}