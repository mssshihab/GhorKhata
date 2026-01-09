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



namespace Ghorkhata2._0
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); 
            f2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                          AttachDbFilename=C:\Users\shiha\OneDrive\Documents\Ghorkhata.mdf;
                          Integrated Security=True;
                          Connect Timeout=30;
                          Encrypt=False";
            SqlConnection con = new SqlConnection(connectionString); 
            con.Open();

            SqlDataAdapter sqlda = new SqlDataAdapter ("SELECT* FROM [user] ",con);
            DataTable dt = new DataTable();

            sqlda.Fill(dt);

            dataGridView1.DataSource = dt;  
            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
