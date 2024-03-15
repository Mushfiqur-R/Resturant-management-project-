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

namespace E_Project
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show(this);
        }

        private void consigbtn_Click(object sender, EventArgs e)
        {
            if (inputuser.Text == "")
            {
                MessageBox.Show("Username required!!");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Email required!!");
            }
            else if (passwordbox.Text == "")
            {
                MessageBox.Show("Please provide Password!!");

            }
            else {
                SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=FusionFlareDiningDB;Integrated Security=True;");
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Signin]\r\n           ([username]\r\n           ,[email]\r\n           ,[password])\r\n     VALUES\r\n           ('" + inputuser.Text + "','" + textBox1.Text + "','" + passwordbox.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("signin Successfull");
                Form1 login = new Form1();
                this.Hide();
                login.Show(this);

            }
        }
    }
}
