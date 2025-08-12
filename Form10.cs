using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace train307
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=DESKTOP-RCCP80T\\MSSQLSERVER2;Initial Catalog=trainBooking;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection);

            try
            {
                sqlConnection.Open();
                string select = @"SELECT t.Trip_Id, t.Trip_Number, t.Time, t.Source, t.Destination, t.Date, t.Available_NormalSeats, t.Available_VIPSeats, tr.Train_Number
                  FROM trainBooking.dbo.Trips AS t
                  INNER JOIN trainBooking.dbo.Trains AS tr ON t.Trip_Id = tr.Trip_Id";
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
