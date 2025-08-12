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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=DESKTOP-RCCP80T\MSSQLSERVER2;Initial Catalog=trainBooking;Integrated Security=True";
            SqlConnection sqlconnection = new SqlConnection(connection);
            try
            {
                sqlconnection.Open();
                MessageBox.Show("Connection Open!");

                string insert = "INSERT INTO trainBooking.dbo.Trains VALUES (@Train_Number,@Trip_id, @NormalSeats_No, @VIPSeats_No)";
                SqlCommand sqlCommand = new SqlCommand(insert, sqlconnection);
                sqlCommand.Parameters.AddWithValue("@Trip_id", textBox2.Text);
                sqlCommand.Parameters.AddWithValue("@NormalSeats_No", textBox3.Text);
                sqlCommand.Parameters.AddWithValue("@VIPSeats_No", textBox4.Text);
                sqlCommand.Parameters.AddWithValue("@Train_Number", textBox1.Text);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully!");
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            delete2 delete2 = new delete2();    
            delete2.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=DESKTOP-RCCP80T\MSSQLSERVER2;Initial Catalog=trainBooking;Integrated Security=True";
            SqlConnection sqlconnection = new SqlConnection(connection);
            try
            {
                sqlconnection.Open();

                string update = "UPDATE trainBooking.dbo.Trains SET Trip_id = @Trip_id, NormalSeats_No = @NormalSeats_No, VIPSeats_No = @VIPSeats_No WHERE Train_Number = @Train_Number";
                SqlCommand sqlCommand = new SqlCommand(update, sqlconnection);
                sqlCommand.Parameters.AddWithValue("@Trip_id", textBox1.Text);
                sqlCommand.Parameters.AddWithValue("@NormalSeats_No", textBox2.Text);
                sqlCommand.Parameters.AddWithValue("@VIPSeats_No", textBox3.Text);
                sqlCommand.Parameters.AddWithValue("@Train_Number", textBox4.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data Updated successfully!");
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
