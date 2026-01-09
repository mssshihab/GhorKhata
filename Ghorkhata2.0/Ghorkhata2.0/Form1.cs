using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ghorkhata2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Conn = @"Data Source=(LocalDB)\MSSQLLocalDB;
                          AttachDbFilename=C:\Users\shiha\OneDrive\Documents\Ghorkhata.mdf;
                          Integrated Security=True;
                          Connect Timeout=30;
                          Encrypt=False";


            SqlConnection conn1 = new SqlConnection(Conn);
            conn1.Open();

            SqlCommand scmd = new SqlCommand("INSERT INTO [Table](username,email,dob,role, password, confirmpassword) values(@username,@email,@dob,@role, @password, @confirmpassword)", conn1);
            scmd.Parameters.AddWithValue("@username",name.Text);
            scmd.Parameters.AddWithValue("@email", email.Text);
            scmd.Parameters.AddWithValue("@dob", dob.Text);
            scmd.Parameters.AddWithValue("@role", role.Text);
            scmd.Parameters.AddWithValue("@password", password.Text);
            scmd.Parameters.AddWithValue("@confirmpassword", confirmpassword.Text);



            scmd.ExecuteNonQuery();
            conn1.Close();

            MessageBox.Show("Data Inserted Successfully");
        }

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();  
        }
    }
}
