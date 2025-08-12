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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connection = @"Data Source=DESKTOP-RCCP80T\MSSQLSERVER2;Initial Catalog=trainBooking;Integrated Security=True";
            SqlConnection sqlconnection = new SqlConnection(connection);
            try
            {
                sqlconnection.Open();
                MessageBox.Show("Connection Open!");

                string insert = "INSERT INTO trainBooking.dbo.Trips VALUES (@Trip_Id, @Time, @Source, @Destination,@Date,@Available_NormalSeats,@Available_VIPSeats)";
                SqlCommand sqlCommand = new SqlCommand(insert, sqlconnection);
                sqlCommand.Parameters.AddWithValue("@Trip_Id", textBox1.Text);
                sqlCommand.Parameters.AddWithValue("@Time", textBox2.Text);
                sqlCommand.Parameters.AddWithValue("@Source", textBox3.Text);
                sqlCommand.Parameters.AddWithValue("@Destination", textBox4.Text);
                sqlCommand.Parameters.AddWithValue("@Date", textBox7.Text);
                sqlCommand.Parameters.AddWithValue("@Available_NormalSeats", textBox5.Text);
                sqlCommand.Parameters.AddWithValue("@Available_VIPSeats", textBox6.Text);
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string connection = @"Data Source=DESKTOP-RCCP80T\MSSQLSERVER2;Initial Catalog=trainBooking;Integrated Security=True";
            SqlConnection sqlconnection = new SqlConnection(connection);
            try
            {
                sqlconnection.Open();
                MessageBox.Show("Connection Open!");

                string update = "UPDATE trainBooking.dbo.Trips SET Trip_Id=@Trip_Id, Time=@Time, Source=@Source,Destination= @Destination,Date=@Date,Available_NormalSeats=@Available_NormalSeats,Available_VIPSeats=@Available_VIPSeats" +
                    " WHERE Trip_Id=@Trip_Id";
                    
                SqlCommand sqlCommand = new SqlCommand(update, sqlconnection);
                sqlCommand.Parameters.AddWithValue("@Trip_Id", textBox1.Text);
                sqlCommand.Parameters.AddWithValue("@Time", textBox2.Text);
                sqlCommand.Parameters.AddWithValue("@Source", textBox3.Text);
                sqlCommand.Parameters.AddWithValue("@Destination", textBox4.Text);
                sqlCommand.Parameters.AddWithValue("@Date", textBox7.Text);
                sqlCommand.Parameters.AddWithValue("@Available_NormalSeats", textBox5.Text);
                sqlCommand.Parameters.AddWithValue("@Available_VIPSeats", textBox6.Text);
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
