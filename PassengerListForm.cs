using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace train307
{
    public partial class PassengerListForm : Form
    {
        public DataTable PassengerData
        {
            set
            {
                dataGridView1.DataSource = value;
            }
        }

        public PassengerListForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=DESKTOP-RCCP80T\\MSSQLSERVER2;Initial Catalog=trainBooking;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);

            try
            {
                sqlConnection.Open();
                string select = "SELECT Passenger_ID, First_Name, Last_Name FROM trainBooking.dbo.Passengers";
                SqlCommand sqlCommand = new SqlCommand(select, sqlConnection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Create a new instance of PassengerListForm
                PassengerListForm passengerListForm = new PassengerListForm();
                passengerListForm.PassengerData = dataTable; // Set the DataTable as the data source for DataGridView
                passengerListForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
/*
  string connection = "Data Source=DESKTOP-RCCP80T\\MSSQLSERVER2;Initial Catalog=trainBooking;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);

            try
            {
                sqlConnection.Open();
                string select = "SELECT Passenger_ID, First_Name, Last_Name FROM trainBooking.dbo.Passengers";
                SqlCommand sqlCommand = new SqlCommand(select, sqlConnection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Create a new instance of PassengerListForm
                PassengerListForm passengerListForm = new PassengerListForm();
                passengerListForm.PassengerData = dataTable; // Set the DataTable as the data source for DataGridView
                passengerListForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }*/