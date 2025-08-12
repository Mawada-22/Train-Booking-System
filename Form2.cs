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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            delete2 delete = new delete2();
            delete.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }
    }
}
