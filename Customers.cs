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
    public partial class Customers : Form
    {
        
        public Customers()
        {
            InitializeComponent();
            ShowCustomers();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\BCA2022_54\Documents\Visual Studio 2010\Projects\HARDWARESHOP MANAGEMENT SYSTEM\HARDWARESHOP MANAGEMENT SYSTEM\HardwareShopManagementSystem.mdf;Integrated Security=True;User Instance=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ShowCustomers()
        {
            con.Open();
            string Query = "Select * from Cus_Tbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVCustomerList.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Reset()
        {
            txtCustomerName.Text = "";
            txtCustomerAddress.Text = "";
            txtCustomerContactNo.Text = "";
            txtCustomerDateOfBirth.Text = "";
            txtCustomerGender.Text = "";
        }

        //* Coding For Save Button

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "" || txtCustomerAddress.Text == "" || txtCustomerContactNo.Text == "" || txtCustomerDateOfBirth.Text == "" || txtCustomerGender.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Cus_Tbl(Cus_Name,Cus_Address,Cus_ContactNo,Cus_DOB,Cus_Gender)values(@CN,@CA,@CC,@CD,@CG)", con);
                    cmd.Parameters.AddWithValue("@CN", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@CA", txtCustomerAddress.Text);
                    cmd.Parameters.AddWithValue("@CC", txtCustomerContactNo.Text);
                    cmd.Parameters.AddWithValue("@CD", txtCustomerDateOfBirth.Value.Date);
                    cmd.Parameters.AddWithValue("@CG", txtCustomerGender.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Added Successfully");
                    con.Close();
                    ShowCustomers();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //* Coding For Update Button

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "" || txtCustomerAddress.Text == "" || txtCustomerContactNo.Text == "" || txtCustomerDateOfBirth.Text == "" || txtCustomerGender.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Cus_Tbl set Cus_Name=@CN,Cus_Address=@CA,Cus_ContactNo=@CC,Cus_DOB=@CD,Cus_Gender=@CG where Cus_Id=@CKey", con);
                    cmd.Parameters.AddWithValue("@CN", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@CA", txtCustomerAddress.Text);
                    cmd.Parameters.AddWithValue("@CC", txtCustomerContactNo.Text);
                    cmd.Parameters.AddWithValue("@CD", txtCustomerDateOfBirth.Value.Date);
                    cmd.Parameters.AddWithValue("@CG", txtCustomerGender.Text);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Updated Successfully");
                    con.Close();
                    ShowCustomers();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                
            }
        }

        //* Coding For Delete Button

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select The Customer");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Cus_Tbl where Cus_Id=@CKey", con);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Successfully");
                    con.Close();
                    ShowCustomers();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //* Coding For Data Gride View

        int Key = 0;
        private void DGVCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerName.Text = DGVCustomerList.SelectedRows[0].Cells[1].Value.ToString();

            txtCustomerAddress.Text = DGVCustomerList.SelectedRows[0].Cells[2].Value.ToString();

            txtCustomerContactNo.Text = DGVCustomerList.SelectedRows[0].Cells[3].Value.ToString();

            txtCustomerDateOfBirth.Text = DGVCustomerList.SelectedRows[0].Cells[4].Value.ToString();

            txtCustomerGender.Text = DGVCustomerList.SelectedRows[0].Cells[5].Value.ToString();

            if (txtCustomerName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key=Convert.ToInt32(DGVCustomerList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }


        //* Coding For Change Module

        private void GoDashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            this.Hide();
            obj.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            this.Hide();
            obj.Show();
        }

        private void GoItem_Click(object sender, EventArgs e)
        {
            Items obj = new Items();
            this.Hide();
            obj.Show();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            Items obj = new Items();
            this.Hide();
            obj.Show();
        }

        private void GoManufacture_Click(object sender, EventArgs e)
        {
            Manufacture obj = new Manufacture();
            this.Hide();
            obj.Show();
        }

        private void btnManufacture_Click(object sender, EventArgs e)
        {
            Manufacture obj = new Manufacture();
            this.Hide();
            obj.Show();
        }

        private void GoEmployee_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            this.Hide();
            obj.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            this.Hide();
            obj.Show();
        }

        private void GoBilling_Click(object sender, EventArgs e)
        {
            Billing obj = new Billing();
            this.Hide();
            obj.Show();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            Billing obj = new Billing();
            this.Hide();
            obj.Show();
        }

        private void GoLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }

        private void GoCustomer_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            this.Hide();
            obj.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            this.Hide();
            obj.Show();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCustomerGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCustomerContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Customers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.I)
            {
                this.Close();
                Items it = new Items();
                it.Show();

            }
            else if (e.Control && e.KeyCode == Keys.M)
            {
                this.Close();
                Manufacture ma = new Manufacture();
                ma.Show();
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                this.Close();
                Dashboard cs = new Dashboard();
                cs.Show();
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                this.Close();
                Billing bl = new Billing();
                bl.Show();
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                this.Close();
                Employees em = new Employees();
                em.Show();
            }
            else if (e.Control && e.KeyCode == Keys.L)
            {
                this.Close();
                Login lo = new Login();
                lo.Show();
            }
        }

       


        
       
       
    }
}
