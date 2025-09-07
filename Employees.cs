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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            ShowEmployees();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\BCA2022_54\Documents\Visual Studio 2010\Projects\HARDWARESHOP MANAGEMENT SYSTEM\HARDWARESHOP MANAGEMENT SYSTEM\HardwareShopManagementSystem.mdf;Integrated Security=True;User Instance=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ShowEmployees()
        {
            con.Open();
            string Query = "Select * from Emp_Tbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVEmployeeList.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Reset()
        {
            txtEmployeeName.Text = "";
            txtEmployeeAddress.Text = "";
            txtContactNo.Text = "";
            txtJoinDate.Text = "";
            txtDateOfBirth.Text = "";
            txtPassword.Text = "";
            txtEmployeeGender.Text = "";
            Key = 0;
        }

        //* Coding For Save Button

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text == "" || txtEmployeeAddress.Text == "" || txtContactNo.Text == "" || txtJoinDate.Text == "" || txtDateOfBirth.Text == "" || txtPassword.Text == "" || txtEmployeeGender.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Emp_Tbl(Emp_Name,Emp_Address,Emp_ContactNo,Emp_JOD,Emp_DOB,Emp_Password,Emp_Gender)values(@EN,@EA,@EC,@EJD,@ED,@EP,@EG)", con);
                    cmd.Parameters.AddWithValue("@EN", txtEmployeeName.Text);
                    cmd.Parameters.AddWithValue("@EA", txtEmployeeAddress.Text);
                    cmd.Parameters.AddWithValue("@EC", txtContactNo.Text);
                    cmd.Parameters.AddWithValue("@EJD", txtJoinDate.Value.Date);
                    cmd.Parameters.AddWithValue("@ED", txtDateOfBirth.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@EG", txtEmployeeGender.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added Succesfully");
                    con.Close();
                    ShowEmployees();
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
        private void DGVEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeName.Text = DGVEmployeeList.SelectedRows[0].Cells[1].Value.ToString();

            txtEmployeeAddress.Text = DGVEmployeeList.SelectedRows[0].Cells[2].Value.ToString();

            txtContactNo.Text = DGVEmployeeList.SelectedRows[0].Cells[3].Value.ToString();

            txtJoinDate.Text = DGVEmployeeList.SelectedRows[0].Cells[4].Value.ToString();

            txtDateOfBirth.Text = DGVEmployeeList.SelectedRows[0].Cells[5].Value.ToString();

            txtPassword.Text = DGVEmployeeList.SelectedRows[0].Cells[6].Value.ToString();

            txtEmployeeGender.Text = DGVEmployeeList.SelectedRows[0].Cells[7].Value.ToString();

            if (txtEmployeeName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DGVEmployeeList.SelectedRows[0].Cells[0].Value.ToString());
            }


        }

        //* Coding For Update Button

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text == "" || txtEmployeeAddress.Text == "" || txtContactNo.Text == "" || txtJoinDate.Text == "" || txtDateOfBirth.Text == "" || txtPassword.Text == "" || txtEmployeeGender.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Emp_Tbl Set Emp_Name=@EN,Emp_Address=@EA,Emp_ContactNo=@EC,Emp_JOD=@EJD,Emp_DOB=@ED,Emp_Password=@EP,Emp_Gender=@EG where Emp_Id=@EKey", con);
                    cmd.Parameters.AddWithValue("@EN", txtEmployeeName.Text);
                    cmd.Parameters.AddWithValue("@EA", txtEmployeeAddress.Text);
                    cmd.Parameters.AddWithValue("@EC", txtContactNo.Text);
                    cmd.Parameters.AddWithValue("@EJD", txtJoinDate.Value.Date);
                    cmd.Parameters.AddWithValue("@ED", txtDateOfBirth.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@EG", txtEmployeeGender.Text);

                    cmd.Parameters.AddWithValue("@EKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated Successfully");
                    con.Close();
                    ShowEmployees();
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
                MessageBox.Show("Select The Employee");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Emp_Tbl where Emp_Id=@EKey", con);
                    cmd.Parameters.AddWithValue("@EKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted Successfully");
                    con.Close();
                    ShowEmployees();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
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

        private void GoEmployee_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            this.Hide();
            obj.Show();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            
        }

         
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmployeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmployeeGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Employees_KeyDown(object sender, KeyEventArgs e)
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
            else if (e.Control && e.KeyCode == Keys.D)
            {
                this.Close();
                Dashboard em = new Dashboard();
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
