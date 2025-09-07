using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace HARDWARESHOP_MANAGEMENT_SYSTEM
{
    public partial class Manufacture : Form
    {
        public Manufacture()
        {
            InitializeComponent();
            ShowManufacturer();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\BCA2022_54\Documents\Visual Studio 2010\Projects\HARDWARESHOP MANAGEMENT SYSTEM\HARDWARESHOP MANAGEMENT SYSTEM\HardwareShopManagementSystem.mdf;Integrated Security=True;User Instance=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowManufacturer()
        {
            con.Open();
            string Query = "Select * from Manufa_Tbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVManufacturerList.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Reset()
        {
            txtManufacturerName.Text = "";
            txtManufacturerAddress.Text = "";
            txtManufacturerContactNo.Text = "";
            txtManufacturerEmailId.Text = "";
            Key = 0;
        }


        //* Coding For Save Button

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtManufacturerName.Text == "" || txtManufacturerAddress.Text == "" || txtManufacturerContactNo.Text == "" ||  txtManufacturerEmailId.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Manufa_Tbl(Manufa_Name,Manufa_Address,Manufa_ContactNo,Manufa_EmailId)values(@MN,@MA,@MC,@ME)", con);
                    cmd.Parameters.AddWithValue("@MN", txtManufacturerName.Text);
                    cmd.Parameters.AddWithValue("@MA", txtManufacturerAddress.Text);
                    cmd.Parameters.AddWithValue("@MC", txtManufacturerContactNo.Text);
                    cmd.Parameters.AddWithValue("@ME", txtManufacturerEmailId.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manufacturer Added Successfully");
                    con.Close();
                    ShowManufacturer();
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
            if (txtManufacturerName.Text == "" || txtManufacturerAddress.Text == "" || txtManufacturerContactNo.Text == "" || txtManufacturerEmailId.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Manufa_Tbl set Manufa_Name=@MN,Manufa_Address=@MA,Manufa_ContactNo=@MC,Manufa_EmailId=@ME where Manufa_Id=@MKey", con);
                    cmd.Parameters.AddWithValue("@MN", txtManufacturerName.Text);
                    cmd.Parameters.AddWithValue("@MA", txtManufacturerAddress.Text);
                    cmd.Parameters.AddWithValue("@MC", txtManufacturerContactNo.Text);
                    cmd.Parameters.AddWithValue("@ME", txtManufacturerEmailId.Text);
                    cmd.Parameters.AddWithValue("@MKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manufacturer Updated Successfully");
                    con.Close();
                    ShowManufacturer();
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
                MessageBox.Show("Select The Manufacturer");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Manufa_Tbl where Manufa_Id=@MKey", con);
                    cmd.Parameters.AddWithValue("@MKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manufacturer Deleted Successfully");
                    con.Close();
                    ShowManufacturer();
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
        private void DGVManufacturerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManufacturerName.Text = DGVManufacturerList.SelectedRows[0].Cells[1].Value.ToString();

            txtManufacturerAddress.Text = DGVManufacturerList.SelectedRows[0].Cells[2].Value.ToString();

            txtManufacturerContactNo.Text = DGVManufacturerList.SelectedRows[0].Cells[3].Value.ToString();

            txtManufacturerEmailId.Text = DGVManufacturerList.SelectedRows[0].Cells[4].Value.ToString();

            if (txtManufacturerName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DGVManufacturerList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

       
        //* Coding For Module Change

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

        private void btnManufacture_Click(object sender, EventArgs e)
        {
            Manufacture obj = new Manufacture();
            this.Hide();
            obj.Show();
        }

        private void GoManufacture_Click(object sender, EventArgs e)
        {
            Manufacture obj = new Manufacture();
            this.Hide();
            obj.Show();
        }

        private void Manufacture_Load(object sender, EventArgs e)
        {

        }

        private void txtManufacturerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtManufacturerContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Manufacture_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.I)
            {
                this.Close();
                Items it = new Items();
                it.Show();

            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                this.Close();
                Dashboard ma = new Dashboard();
                ma.Show();
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                this.Close();
                Customers cs = new Customers();
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

        private void txtManufacturerEmailId_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

       
        
        

        
    }
}
