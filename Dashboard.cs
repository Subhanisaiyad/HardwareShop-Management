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
    public partial class Dashboard : Form
    {
        

        public Dashboard()
        {
            InitializeComponent();
            CountItem();
            CountCustomer();
            CountEmployee();
            SumAmount();
            GetEmployee();
            SumAmountByEmployee();
            GetBestCustomer();
            GetBestEmployee();
            this.KeyPreview = true;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\BCA2022_54\Documents\Visual Studio 2010\Projects\HARDWARESHOP MANAGEMENT SYSTEM\HARDWARESHOP MANAGEMENT SYSTEM\HardwareShopManagementSystem.mdf;Integrated Security=True;User Instance=True");

        private void CountItem()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Item_Tbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblItems.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void CountCustomer()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Cus_Tbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LblCustomers.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void CountEmployee()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Emp_Tbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LblEmployees.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void SumAmount()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select  Sum(Bill_Amount)from Bill_Tbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LblSellAmount.Text = "Rs." + dt.Rows[0][0].ToString();
            con.Close();
        }

        private void GetEmployee()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Emp_Name from Emp_Tbl", con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Emp_Name", typeof(string));
            dt.Load(Rdr);
            ComboSellsByEmployee.ValueMember = "Emp_Name";
            ComboSellsByEmployee.DataSource = dt;
            con.Close();
        }

        private void SumAmountByEmployee()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(Bill_Amount)from Bill_Tbl where Emp_Name='" + ComboSellsByEmployee.SelectedValue.ToString() + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LblSellsByEmployee.Text = "Rs." + dt.Rows[0][0].ToString();
            con.Close(); 
        }

        private void GetBestCustomer()
        {
            try
            {
                con.Open();
                string InnerQuery = "Select Max(Bill_Amount) from Bill_Tbl";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, con);
                sda1.Fill(dt1);
                string Query = "Select Bill_Cus_Name from Bill_Tbl where Bill_Amount='" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                LblBestCustomer.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
            }
        }

        private void GetBestEmployee()
        {
            try
            {
                con.Open();
                string InnerQuery = "Select Max(Bill_Amount) from Bill_Tbl";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, con);
                sda1.Fill(dt1);
                string Query = "Select Emp_Name from Bill_Tbl where Bill_Amount='" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                LblBestEmployee.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
            } 
        }


        private void ComboSellsByEmployee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SumAmountByEmployee();
        }


        private void GoItem_Click(object sender, EventArgs e)
        {
            Items obj = new Items();
            this.Hide();
            obj.Show();
        }

        private void btnItem_Click_1(object sender, EventArgs e)
        {
            Items obj = new Items();
            this.Hide();
            obj.Show();
        }

        private void GoManufacture_Click_1(object sender, EventArgs e)
        {
            Manufacture obj = new Manufacture();
            this.Hide();
            obj.Show();
        }

        private void btnManufacture_Click_1(object sender, EventArgs e)
        {
            Manufacture obj = new Manufacture();
            this.Hide();
            obj.Show();
        }

        private void GoCustomer_Click_1(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            this.Hide();
            obj.Show();
        }

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            this.Hide();
            obj.Show();
        }

        private void GoEmployee_Click_1(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            this.Hide();
            obj.Show();
        }

        private void btnEmployee_Click_1(object sender, EventArgs e)
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
        private void Dashboard_KeyDown(object sender, KeyEventArgs e)
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

      
        private void Dashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void LblBestEmployee_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void LblBestCustomer_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

       

        

        
        
    }
}
