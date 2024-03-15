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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void passwordlab_Click(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=FusionFlareDiningDB;Integrated Security=True;");
            if(usernametext.Text==""||passwordbox.Text=="")
            {
                MessageBox.Show("Please Provide Username & password");
            }
            else
            {
                string username=usernametext.Text;
                string password=passwordbox.Text;
                try
                {
                  String query="Select * from Signin Where username='"+usernametext.Text+"'AND password='"+passwordbox.Text+"'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable Signin = new DataTable();
                    sda.Fill(Signin);
                    if(Signin.Rows.Count>0) 
                    {
                        username = usernametext.Text;
                        password = passwordbox.Text;
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                        {
                        MessageBox.Show("Invalid username & password");
                    }

                }
                catch(Exception ex) {
                    MessageBox.Show(" " + ex);
                }
            }
        }

        //signin btn button1_Click
        private void button1_Click(object sender, EventArgs e)
        {
            Signin signinpage= new Signin();
            this.Hide();
            signinpage.Show();
           // this.Close();
        }
    }
}
