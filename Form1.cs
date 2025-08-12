namespace train307
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.ComponentModel;
    using System.Net;
    using System.Data.Common;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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

                string insert = "INSERT INTO trainBooking.dbo.Passengers VALUES (@First_Name, @Last_Name, @Passenger_Password, @Passenger_Email)";
                SqlCommand sqlCommand = new SqlCommand(insert, sqlconnection);
                sqlCommand.Parameters.AddWithValue("@First_Name", textBox2.Text);
                sqlCommand.Parameters.AddWithValue("@Last_Name", textBox3.Text);
                sqlCommand.Parameters.AddWithValue("@Passenger_Password", textBox4.Text);
                sqlCommand.Parameters.AddWithValue("@Passenger_Email", textBox5.Text);
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
            delete dele = new delete();
            dele.Show();
            this.Hide();

        }


        private void button3_Click(object sender, EventArgs e)
        {


            string connection = @"Data Source=DESKTOP-RCCP80T\MSSQLSERVER2;Initial Catalog=trainBooking;Integrated Security=True";
            SqlConnection sqlconnection = new SqlConnection(connection);
            try
            {
                sqlconnection.Open();

                string update = "UPDATE trainBooking.dbo.Passengers SET First_Name = @First_Name, Last_Name = @Last_Name, Passenger_Password = @Passenger_Password WHERE Passenger_Email = @Passenger_Email";
                SqlCommand sqlCommand = new SqlCommand(update, sqlconnection);
                sqlCommand.Parameters.AddWithValue("@First_Name", textBox2.Text);
                sqlCommand.Parameters.AddWithValue("@Last_Name", textBox3.Text);
                sqlCommand.Parameters.AddWithValue("@Passenger_Password", textBox4.Text);
                sqlCommand.Parameters.AddWithValue("@Passenger_Email", textBox5.Text);
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



        private void button4_Click(object sender, EventArgs e)
        {
           PassengerListForm form = new PassengerListForm();    
            form.Show();
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
