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
    public partial class AdminProceduresForm : Form
    {
        string connectionString = "server=localhost;user id=root;password=33london;database=GymMembership";


        public AdminProceduresForm()
        {
            InitializeComponent();
        }

        private void AdminProceduresForm_Load(object sender, EventArgs e)
        {
           


        }

        private void LoadCustomers()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Customers", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;





            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int customerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string firstName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string lastName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                int months = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);


                UpdateCustomer(customerId, firstName, lastName, months);
                LoadCustomers();
            }

        }

        private void UpdateCustomer(int customerId, string firstName, string lastName, int months)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Customers SET FirstName = @firstName, LastName = @lastName, MembershipMonths = @months, EndDate = @endDate WHERE ID = @id", con);
                cmd.Parameters.AddWithValue("@id", customerId);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@months", months);
                cmd.Parameters.AddWithValue("@endDate", DateTime.Now.AddMonths(months));
                cmd.ExecuteNonQuery();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int customerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    DeleteCustomer(customerId);
                    LoadCustomers();
                }
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

        private void btnAdminExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListCustomers_Click(object sender, EventArgs e)
        {
            LoadCustomerss();
        }

        private void LoadCustomerss()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT FirstName AS 'Ad', LastName AS 'Soyad', MembershipMonths AS 'Üyelik Süresi (Ay)', RegistrationDate AS 'Kayıt Tarihi' FROM Customers";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // DataGridView'a verileri yükle
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri alınırken bir hata oluştu: " + ex.Message);
                }
            }
        }





    }

}
