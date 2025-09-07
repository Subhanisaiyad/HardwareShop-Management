using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HARDWARESHOP_MANAGEMENT_SYSTEM
{
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\BCA2022_54\Documents\Visual Studio 2010\Projects\HARDWARESHOP MANAGEMENT SYSTEM\HARDWARESHOP MANAGEMENT SYSTEM\HardwareShopManagementSystem.mdf;Integrated Security=True;User Instance=True");

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        

        //* Coding For Admin Button 

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin obj = new Admin();
            this.Hide();
            obj.Show();
        }

        //* Coding For Login Button

        public static string User;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter UserName And Password To Login");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda=new SqlDataAdapter("Select Count(*) from Emp_Tbl Where Emp_Name='"+txtUserName.Text+ "' and Emp_Password='"+txtPassword.Text+"'",con);
                DataTable dt=new DataTable();
                sda.Fill(dt);
                if(dt.Rows[0][0].ToString()=="1")
                {
                    User=txtUserName.Text;
                    Billing Obj=new Billing();
                    Obj.Show();
                    this.Hide();
                    con.Close();

                }
                else
                {
                    MessageBox.Show("You Have Entered Wrong UserName And Password");
                }
                con.Close();

             }
            btnLogin.Text = "&Login";
          }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

    }
}
