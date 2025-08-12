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
    public partial class Form4 : Form
    {
        public Form4()
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

                string insert = "INSERT INTO trainBooking.dbo.Tickets VALUES (@Trip_Id, @Passenger_Id)";
                SqlCommand sqlCommand = new SqlCommand(insert, sqlconnection);
                sqlCommand.Parameters.AddWithValue("@Trip_Id", textBox2.Text);
                sqlCommand.Parameters.AddWithValue("@Passenger_Id", textBox1.Text);

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

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.Show();
           
        }
    }
}
