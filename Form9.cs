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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=DESKTOP-RCCP80T\MSSQLSERVER2;Initial Catalog=trainBooking;Integrated Security=True";
            SqlConnection sqlconnection = new SqlConnection(connection);
            try
            {
                sqlconnection.Open();
                MessageBox.Show("Connection Open!");

                string DELETE = "DELETE FROM trainBooking.dbo.Trips WHERE Trip_Id = @Trip_Id";
                SqlCommand sqlCommand = new SqlCommand(DELETE, sqlconnection);
                sqlCommand.Parameters.AddWithValue("@Trip_Id", textBox1.Text);


                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Row deleted successfully!");
                }
                else
                {
                    MessageBox.Show("No rows matched.");
                }
                sqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                sqlconnection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
