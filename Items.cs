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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
            ShowItems();
            GetManufacturerId();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\BCA2022_54\Documents\Visual Studio 2010\Projects\HARDWARESHOP MANAGEMENT SYSTEM\HARDWARESHOP MANAGEMENT SYSTEM\HardwareShopManagementSystem.mdf;Integrated Security=True;User Instance=True");
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowItems()
        {
            con.Open();
            string Query = "Select * from Item_Tbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVItems.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Reset()
        {
            txtItemName.Text = "";
            txtIPltemType.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtManufacturerId.Text = "";
            txtManufacturerName.Text = "";
            txtItemCategories.Text = "";
            Key = 0;
        }

        private void GetManufacturerId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Manufa_Id from Manufa_Tbl", con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Manufa_Tbl",typeof(int));
            dt.Load(Rdr);
            txtManufacturerId.ValueMember = "Manufa_Id";
            txtManufacturerId.DataSource = dt;
            con.Close();
        }

        private void GetManufacturerName()
        {
            con.Open();
            string Query = "Select * from Manufa_Tbl where Manufa_Id='" + txtManufacturerId.SelectedValue.ToString()+"'";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtManufacturerName.Text = dr["Manufa_Name"].ToString();
            }
            con.Close();
        }

        private void txtManufacturerId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetManufacturerName();
        }


        //* Coding For Save Button

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "" || txtIPltemType.Text == "" || txtElItemType.Text == "" || txtQuantity.Text == "" || txtPrice.Text == "" || txtManufacturerId.Text == "" || txtManufacturerName.Text == "" || txtItemCategories.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Item_Tbl(Item_Name,PL_Item_Type,EL_Item_Type,Item_Qnty,Item_Price,Item_Manufa_Id,Item_Manufa_Name,Item_Categories)values(@IN,@PIT,@EIT,@IQ,@IP,@IMI,@IMN,@IC)", con);
                    cmd.Parameters.AddWithValue("@IN", txtItemName.Text);
                    cmd.Parameters.AddWithValue("@PIT", txtIPltemType.Text);
                    cmd.Parameters.AddWithValue("@EIT", txtElItemType.Text);
                    cmd.Parameters.AddWithValue("@IQ", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@IP", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@IMI", txtManufacturerId.Text);
                    cmd.Parameters.AddWithValue("@IMN", txtManufacturerName.Text);
                    cmd.Parameters.AddWithValue("@IC", txtItemCategories.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Added Successfully");
                    con.Close();
                    ShowItems();
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
            if (txtItemName.Text == "" || txtIPltemType.Text == "" || txtElItemType.Text == "" || txtQuantity.Text == "" || txtPrice.Text == "" || txtManufacturerId.Text == "" || txtManufacturerName.Text == "" || txtItemCategories.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("Update Item_Tbl set Item_Name=@IN,PL_Item_Type=@PIT,EL_Item_Type=@EIT,Item_Qnty=@IQ,Item_Price=@IP,Item_Manufa_Id=@IMI,Item_Manufa_Name=@IMN,Item_Categories=@IC where Item_Id=@IKey", con);
                    cmd.Parameters.AddWithValue("@IN", txtItemName.Text);
                    cmd.Parameters.AddWithValue("@PIT", txtIPltemType.Text);
                    cmd.Parameters.AddWithValue("@EIT", txtElItemType.Text);
                    cmd.Parameters.AddWithValue("@IQ", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@IP", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@IMI", txtManufacturerId.Text);
                    cmd.Parameters.AddWithValue("@IMN", txtManufacturerName.Text);
                    cmd.Parameters.AddWithValue("@IC", txtItemCategories.Text);
                    cmd.Parameters.AddWithValue("@IKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Updated Successfully");
                    con.Close();
                    ShowItems();
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
                MessageBox.Show("Select The Item");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Item_Tbl where Item_Id=@IKey", con);
                    cmd.Parameters.AddWithValue("@IKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Deleted Successfully");
                    con.Close();
                    ShowItems();
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
        private void DGVItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItemName.Text = DGVItems.SelectedRows[0].Cells[1].Value.ToString();

            txtIPltemType.Text = DGVItems.SelectedRows[0].Cells[2].Value.ToString();

            txtElItemType.Text = DGVItems.SelectedRows[0].Cells[3].Value.ToString();

            txtQuantity.Text = DGVItems.SelectedRows[0].Cells[4].Value.ToString();

            txtPrice.Text = DGVItems.SelectedRows[0].Cells[5].Value.ToString();

            txtManufacturerId.Text = DGVItems.SelectedRows[0].Cells[6].Value.ToString();

            txtManufacturerName.Text = DGVItems.SelectedRows[0].Cells[7].Value.ToString();

            txtItemCategories.Text = DGVItems.SelectedRows[0].Cells[8].Value.ToString();


            if (txtItemName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DGVItems.SelectedRows[0].Cells[0].Value.ToString());
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

        private void Items_Load(object sender, EventArgs e)
        {
            
        }

        private void txtItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtItemCategories_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIPltemType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtElItemType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtManufacturerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtManufacturerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Items_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D)
            {
                this.Close();
                Dashboard it = new Dashboard();
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

        

       
  
        
    }
}
