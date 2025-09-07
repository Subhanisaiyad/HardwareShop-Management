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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            ShowItems();
            ShowBilling();
            GetCustomersId();
            lblEmployeeName.Text = Login.User;
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\BCA2022_54\Documents\Visual Studio 2010\Projects\HARDWARESHOP MANAGEMENT SYSTEM\HARDWARESHOP MANAGEMENT SYSTEM\HardwareShopManagementSystem.mdf;Integrated Security=True;User Instance=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        int Key = 0, Stock;
        private void UpdateQnty()
        {
            try
            {
                int NewQnty = Stock - Convert.ToInt32(txtQuantity.Text);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Item_Tbl set Item_Qnty=@IQ where Item_Id=@IKey", con);
                cmd.Parameters.AddWithValue("@IQ", NewQnty);
                cmd.Parameters.AddWithValue("@IKey", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Updated Successfully");
                con.Close();
                ShowItems();
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void ShowItems()
        {
            con.Open();
            string Query = "Select * from Item_Tbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVItemList.DataSource = ds.Tables[0];
            con.Close();
        }
       
       private void ShowBilling()
        {
            con.Open();
            string Query = "Select * from Bill_Tbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVTransactions.DataSource = ds.Tables[0];
            con.Close();
           
         }

       private void GetCustomersId()
       {
           con.Open();
           SqlCommand cmd = new SqlCommand("Select Cus_Id from Cus_Tbl", con);
           SqlDataReader Rdr;
           Rdr = cmd.ExecuteReader();
           DataTable dt = new DataTable();
           dt.Columns.Add("Cus_Tbl", typeof(int));
           dt.Load(Rdr);
           txtCustomerId.ValueMember = "Cus_Id";
           txtCustomerId.DataSource = dt;
           con.Close();      
       }

       private void GetCustomersName()
       {
           con.Open();
           string Query = "Select * from Cus_Tbl where Cus_Id='" + txtCustomerId.SelectedValue.ToString() + "'";
           SqlCommand cmd = new SqlCommand(Query, con);
           DataTable dt = new DataTable();
           SqlDataAdapter sda = new SqlDataAdapter(cmd);
           sda.Fill(dt);
           foreach (DataRow dr in dt.Rows)
           {
               txtCustomerName.Text = dr["Cus_Name"].ToString();
           }
           con.Close();
       }

       private void txtCustomerId_SelectionChangeCommitted_1(object sender, EventArgs e)
       {
           GetCustomersName();
       }

       private void btnsave_Click(object sender, EventArgs e)
       {
           if (lblEmployeeName.Text == "" || txtCustomerId.Text == "" || txtCustomerName.Text == "" || txtBillDate.Text == "" || txtItemName.Text == "" || txtQuantity.Text == "" || LblTotal.Text == "")
           {

               if (lblEmployeeName.Text == "")
               {
                   MessageBox.Show("EmpName");
               }
               else if (txtCustomerId.Text == "")
               {
                   MessageBox.Show("Missig CusId");
               }
               else if (txtCustomerName.Text== "")
               {
                   MessageBox.Show("Customer Name Missing");
               }
               else if (txtBillDate.Text == "")
               {
                   MessageBox.Show("BillDate");
               }
               else if (txtItemName.Text == "")
               {
                   MessageBox.Show("Item Name");
               }
               else if (txtQuantity.Text == "")
               {
                   MessageBox.Show("Qunty");
               }
               else if (LblTotal.Text == "")
               {
                   MessageBox.Show("Total");
               }

               else
               {
                   MessageBox.Show("Missing Information");
               }

           }
           else
           {
               try
               {
                   con.Open();
                   SqlCommand cmd = new SqlCommand("Insert into Bill_Tbl(Emp_Name,Bill_Cus_Id,Bill_Cus_Name,Bill_Date,Item_Name,Item_Qnty,Bill_Amount)Values(@EN,@BCI,@BCN,@BD,@IN,@IQ,@BA)", con);
                   cmd.Parameters.AddWithValue("@EN", lblEmployeeName.Text);
                   cmd.Parameters.AddWithValue("@BCI", txtCustomerId.Text.ToString());
                   cmd.Parameters.AddWithValue("@BCN", txtCustomerName.Text);
                   cmd.Parameters.AddWithValue("@BD", txtBillDate.Value.Date);
                   cmd.Parameters.AddWithValue("@IN", txtItemName.Text);
                   cmd.Parameters.AddWithValue("@IQ", txtQuantity.Text);
                   cmd.Parameters.AddWithValue("@BA", GrdTotal.ToString()); 
                   cmd.ExecuteNonQuery();
                   MessageBox.Show("Bill Saved Successfully");
                   con.Close();
                   ShowBilling();
               }
               catch (Exception Ex)
               {
                   MessageBox.Show(Ex.Message);
               }
           }
       }
               
       private void DGVTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {
           lblEmployeeName.Text = DGVTransactions.SelectedRows[0].Cells[1].Value.ToString();

           txtCustomerId.Text = DGVTransactions.SelectedRows[0].Cells[2].Value.ToString();

           txtCustomerName.Text = DGVTransactions.SelectedRows[0].Cells[3].Value.ToString();

           txtBillDate.Text = DGVTransactions.SelectedRows[0].Cells[4].Value.ToString();

           txtItemName.Text = DGVTransactions.SelectedRows[0].Cells[5].Value.ToString();

           txtQuantity.Text = DGVTransactions.SelectedRows[0].Cells[6].Value.ToString();

           LblTotal.Text = DGVTransactions.SelectedRows[0].Cells[7].Value.ToString();

           if (lblEmployeeName.Text == "")
           {
               Key = 0;
           }
           else
           {
               Key = Convert.ToInt32(DGVTransactions.SelectedRows[0].Cells[0].Value.ToString());
           }
       }

     



       int ItemId, ItemPrice, ItemQnty, ItemTotal;
         string ItemName;
         int Pos = 60;
         int n = 0, GrdTotal = 0;
         private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
         {
             e.Graphics.DrawString("Power Flow", new Font("Time New Roman",17, FontStyle.Bold), Brushes.Teal, new Point(200));
             e.Graphics.DrawString("Bill Date :-" +txtBillDate.Text, new Font("Time New Roman", 17, FontStyle.Bold), Brushes.Black, new Point(500));
             e.Graphics.DrawString("Id   Item          Quantity    Price      Total", new Font("Time New Roman", 15, FontStyle.Bold), Brushes.Black, new Point(50, 40));
             foreach (DataGridViewRow row in DGVBill.Rows)
             {
                 ItemId = Convert.ToInt32(row.Cells["Column1"].Value);
                 ItemName = "" + row.Cells["Column2"].Value;
                 ItemQnty = Convert.ToInt32(row.Cells["Column3"].Value);
                 ItemPrice = Convert.ToInt32(row.Cells["Column4"].Value);
                 ItemTotal = Convert.ToInt32(row.Cells["Column5"].Value);

                 e.Graphics.DrawString("" + ItemId, new Font("Time New Roman", 12, FontStyle.Bold), Brushes.Blue, new Point(50, Pos));
                 e.Graphics.DrawString("" + ItemName, new Font("Time New Roman", 12, FontStyle.Bold), Brushes.Blue, new Point(80, Pos)); 
                 e.Graphics.DrawString("" + ItemQnty, new Font("Time New Roman", 12, FontStyle.Bold), Brushes.Blue, new Point(200, Pos));
                 e.Graphics.DrawString("" + ItemPrice, new Font("Time New Roman", 12, FontStyle.Bold), Brushes.Blue, new Point(300, Pos));
                 e.Graphics.DrawString("" + ItemTotal, new Font("Time New Roman", 12, FontStyle.Bold), Brushes.Blue, new Point(385, Pos));
                 Pos = Pos + 20;
             }
             e.Graphics.DrawString("Grand Total: Rs. " + GrdTotal, new Font("Time New Roamn", 17, FontStyle.Bold), Brushes.Black, new Point(200, Pos + 50));
             e.Graphics.DrawString("Employee Name :-" + lblEmployeeName.Text, new Font("Time New Roamn", 17, FontStyle.Bold), Brushes.Black, new Point(100, Pos + 90));
             string CustomerName=txtCustomerName.Text;
             if (string.IsNullOrEmpty(CustomerName))
             {
                 CustomerName = "N/A";
             }
             
             e.Graphics.DrawString("Customer Name:-" + txtCustomerName.Text, new Font("Time New Roman", 17, FontStyle.Bold), Brushes.Black, new Point(100, Pos + 130));
             e.Graphics.DrawString("*****  Power Flow  *****", new Font("Time New Roman", 17, FontStyle.Bold), Brushes.Teal, new Point(200, Pos + 170));
             e.Graphics.DrawString(" Thank You For Visting...! ", new Font("Time New Roman", 17, FontStyle.Bold), Brushes.DarkBlue, new Point(150, Pos + 220));
             DGVBill.Rows.Clear();
             DGVBill.Refresh();
             Pos = 100;
             GrdTotal = 0;
             n = 0;

             
         }




         private void Billing_Load(object sender, EventArgs e)
         {
             DGVBill.Columns.Add("Column1", "S.No");
             DGVBill.Columns.Add("Column2", "ItemName");
             DGVBill.Columns.Add("Column3", "Quntity");
             DGVBill.Columns.Add("Column4", "ItemPrice");
             DGVBill.Columns.Add("Column5", "Total");
         }
       
         private void btnPrint_Click(object sender, EventArgs e)
         {
             if (DGVBill.Rows.Count == 0)
             {
                 MessageBox.Show("No Data.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }

             printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 850, 1100);

             printPreviewDialog1.Document = printDocument1;

             if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
             {
                 printDocument1.Print();
             }
            

         }
        
      

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            
            if (txtQuantity.Text == "" || Convert.ToInt32(txtQuantity.Text) > Stock)
            {
                MessageBox.Show("Enter Correct Qunatity");
            }
            else
            {
                int total = Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(txtItemPrice.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = ++n });
                newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = txtItemName.Text });
                newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = txtQuantity.Text });
                newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = txtItemPrice.Text });
                newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = total });
                DGVBill.Rows.Add(newRow);
                GrdTotal = GrdTotal + total;
                LblTotal.Text = "RS:" + GrdTotal;
                n++;
                UpdateQnty();
            }
        }

        private void DGVItemList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DGVItemList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            txtItemName.Text = DGVItemList.SelectedRows[0].Cells[1].Value.ToString();
            Stock = Convert.ToInt32(DGVItemList.SelectedRows[0].Cells[4].Value.ToString());
            txtItemPrice.Text = DGVItemList.SelectedRows[0].Cells[5].Value.ToString();
            if (txtItemName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DGVItemList.SelectedRows[0].Cells[0].Value.ToString());
            }

        }




        //* Coding For Change Modules

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblEmployeeName_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void DGVBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCustomerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtItemPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Billing_KeyDown(object sender, KeyEventArgs e)
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
            else if (e.Control && e.KeyCode == Keys.D)
            {
                this.Close();
                Dashboard bl = new Dashboard();
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
