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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace train307
{
    public partial class delete2 : Form
    {
        public delete2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=DESKTOP-RCCP80T\MSSQLSERVER2;Initial Catalog=trainBooking;Integrated Security=True";
            SqlConnection sqlconnection = new SqlConnection(connection);
            try
            {
                sqlconnection.Open();
                MessageBox.Show("Connection Open!");

                string DELETE = "DELETE FROM trainBooking.dbo.Trains WHERE Train_Number = @Train_Number";
                SqlCommand sqlCommand = new SqlCommand(DELETE, sqlconnection);
                sqlCommand.Parameters.AddWithValue("@Train_Number", textBox1.Text);


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
    }
}
