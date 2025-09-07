using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HARDWARESHOP_MANAGEMENT_SYSTEM
{
   
    public partial class Admin : Form
    {

        
        
        public Admin()
        {
            InitializeComponent();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //* Coding For Back Button

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (txtAdminPassword.Text == "")
            {

            }
            else if (txtAdminPassword.Text == "subhani")
            {
                
                Dashboard obj = new Dashboard();
                this.Hide();
                obj.Show();

            }
            else
            {
                MessageBox.Show("You Have Entered Wrong Admin Password");
                txtAdminPassword.Text = "";
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
          
        }

       
        
    }
}
