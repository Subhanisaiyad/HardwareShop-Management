namespace HARDWARESHOP_MANAGEMENT_SYSTEM
{
    partial class Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBilling = new System.Windows.Forms.Button();
            this.GoBilling = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.GoLogout = new System.Windows.Forms.PictureBox();
            this.GoEmployee = new System.Windows.Forms.PictureBox();
            this.GoCustomer = new System.Windows.Forms.PictureBox();
            this.GoItem = new System.Windows.Forms.PictureBox();
            this.btnManufacture = new System.Windows.Forms.Button();
            this.GoManufacture = new System.Windows.Forms.PictureBox();
            this.GoDashboard = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCustomerGender = new System.Windows.Forms.ComboBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.DGVCustomerList = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCustomerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerContactNo = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoManufacture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.ForeColor = System.Drawing.Color.Teal;
            this.btnLogout.Location = new System.Drawing.Point(59, 576);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(123, 35);
            this.btnLogout.TabIndex = 39;
            this.btnLogout.Text = "Logout";
            this.toolTip1.SetToolTip(this.btnLogout, "Logout (Press Ctrl + L)");
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.ForeColor = System.Drawing.Color.Teal;
            this.btnEmployee.Location = new System.Drawing.Point(65, 499);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(123, 35);
            this.btnEmployee.TabIndex = 37;
            this.btnEmployee.Text = "Employees";
            this.toolTip1.SetToolTip(this.btnEmployee, "Employees (Press Ctrl + E)");
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Teal;
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(59, 351);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(123, 35);
            this.btnCustomer.TabIndex = 36;
            this.btnCustomer.Text = "Customers";
            this.toolTip1.SetToolTip(this.btnCustomer, "Customers");
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnBilling);
            this.panel1.Controls.Add(this.GoBilling);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnItem);
            this.panel1.Controls.Add(this.GoLogout);
            this.panel1.Controls.Add(this.GoEmployee);
            this.panel1.Controls.Add(this.GoCustomer);
            this.panel1.Controls.Add(this.GoItem);
            this.panel1.Controls.Add(this.btnManufacture);
            this.panel1.Controls.Add(this.GoManufacture);
            this.panel1.Controls.Add(this.GoDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.LimeGreen;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 630);
            this.panel1.TabIndex = 42;
            // 
            // btnBilling
            // 
            this.btnBilling.ForeColor = System.Drawing.Color.Teal;
            this.btnBilling.Location = new System.Drawing.Point(59, 425);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(123, 35);
            this.btnBilling.TabIndex = 41;
            this.btnBilling.Text = "Billing";
            this.toolTip1.SetToolTip(this.btnBilling, "Billing (Press Ctrl + B)");
            this.btnBilling.UseVisualStyleBackColor = true;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // GoBilling
            // 
            this.GoBilling.Image = global::HARDWARESHOP_MANAGEMENT_SYSTEM.Properties.Resources.billing1;
            this.GoBilling.Location = new System.Drawing.Point(3, 410);
            this.GoBilling.Name = "GoBilling";
            this.GoBilling.Size = new System.Drawing.Size(50, 50);
            this.GoBilling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoBilling.TabIndex = 40;
            this.GoBilling.TabStop = false;
            this.toolTip1.SetToolTip(this.GoBilling, "Billing");
            this.GoBilling.Click += new System.EventHandler(this.GoBilling_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.ForeColor = System.Drawing.Color.Teal;
            this.btnDashboard.Location = new System.Drawing.Point(59, 123);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(123, 35);
            this.btnDashboard.TabIndex = 23;
            this.btnDashboard.Text = "Dashboard";
            this.toolTip1.SetToolTip(this.btnDashboard, "Dashboard (Press Ctrl + D)");
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnItem
            // 
            this.btnItem.BackColor = System.Drawing.Color.White;
            this.btnItem.ForeColor = System.Drawing.Color.Teal;
            this.btnItem.Location = new System.Drawing.Point(59, 194);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(123, 35);
            this.btnItem.TabIndex = 35;
            this.btnItem.Text = "Items";
            this.toolTip1.SetToolTip(this.btnItem, "Items (Press Ctrl + I)");
            this.btnItem.UseVisualStyleBackColor = false;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // GoLogout
            // 
            this.GoLogout.Image = global::HARDWARESHOP_MANAGEMENT_SYSTEM.Properties.Resources.logout;
            this.GoLogout.Location = new System.Drawing.Point(3, 561);
            this.GoLogout.Name = "GoLogout";
            this.GoLogout.Size = new System.Drawing.Size(50, 50);
            this.GoLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoLogout.TabIndex = 34;
            this.GoLogout.TabStop = false;
            this.toolTip1.SetToolTip(this.GoLogout, "Logout");
            this.GoLogout.Click += new System.EventHandler(this.GoLogout_Click);
            // 
            // GoEmployee
            // 
            this.GoEmployee.Image = global::HARDWARESHOP_MANAGEMENT_SYSTEM.Properties.Resources.employee;
            this.GoEmployee.Location = new System.Drawing.Point(3, 484);
            this.GoEmployee.Name = "GoEmployee";
            this.GoEmployee.Size = new System.Drawing.Size(50, 50);
            this.GoEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoEmployee.TabIndex = 30;
            this.GoEmployee.TabStop = false;
            this.toolTip1.SetToolTip(this.GoEmployee, "Employees");
            this.GoEmployee.Click += new System.EventHandler(this.GoEmployee_Click);
            // 
            // GoCustomer
            // 
            this.GoCustomer.Image = global::HARDWARESHOP_MANAGEMENT_SYSTEM.Properties.Resources.customer;
            this.GoCustomer.Location = new System.Drawing.Point(3, 336);
            this.GoCustomer.Name = "GoCustomer";
            this.GoCustomer.Size = new System.Drawing.Size(50, 50);
            this.GoCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoCustomer.TabIndex = 28;
            this.GoCustomer.TabStop = false;
            this.toolTip1.SetToolTip(this.GoCustomer, "Customers");
            this.GoCustomer.Click += new System.EventHandler(this.GoCustomer_Click);
            // 
            // GoItem
            // 
            this.GoItem.Image = global::HARDWARESHOP_MANAGEMENT_SYSTEM.Properties.Resources.itms;
            this.GoItem.Location = new System.Drawing.Point(3, 181);
            this.GoItem.Name = "GoItem";
            this.GoItem.Size = new System.Drawing.Size(50, 50);
            this.GoItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoItem.TabIndex = 26;
            this.GoItem.TabStop = false;
            this.toolTip1.SetToolTip(this.GoItem, "Items");
            this.GoItem.Click += new System.EventHandler(this.GoItem_Click);
            // 
            // btnManufacture
            // 
            this.btnManufacture.BackColor = System.Drawing.Color.White;
            this.btnManufacture.ForeColor = System.Drawing.Color.Teal;
            this.btnManufacture.Location = new System.Drawing.Point(59, 268);
            this.btnManufacture.Name = "btnManufacture";
            this.btnManufacture.Size = new System.Drawing.Size(123, 35);
            this.btnManufacture.TabIndex = 25;
            this.btnManufacture.Text = "Manufacturer";
            this.toolTip1.SetToolTip(this.btnManufacture, "Manufacturer (Press Ctrl + M)");
            this.btnManufacture.UseVisualStyleBackColor = false;
            this.btnManufacture.Click += new System.EventHandler(this.btnManufacture_Click);
            // 
            // GoManufacture
            // 
            this.GoManufacture.Image = global::HARDWARESHOP_MANAGEMENT_SYSTEM.Properties.Resources.manufacturer;
            this.GoManufacture.Location = new System.Drawing.Point(3, 253);
            this.GoManufacture.Name = "GoManufacture";
            this.GoManufacture.Size = new System.Drawing.Size(50, 50);
            this.GoManufacture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoManufacture.TabIndex = 24;
            this.GoManufacture.TabStop = false;
            this.toolTip1.SetToolTip(this.GoManufacture, "Manufacturer");
            this.GoManufacture.Click += new System.EventHandler(this.GoManufacture_Click);
            // 
            // GoDashboard
            // 
            this.GoDashboard.Image = global::HARDWARESHOP_MANAGEMENT_SYSTEM.Properties.Resources.dashboard;
            this.GoDashboard.Location = new System.Drawing.Point(3, 108);
            this.GoDashboard.Name = "GoDashboard";
            this.GoDashboard.Size = new System.Drawing.Size(50, 50);
            this.GoDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoDashboard.TabIndex = 22;
            this.GoDashboard.TabStop = false;
            this.toolTip1.SetToolTip(this.GoDashboard, "Dashboard");
            this.GoDashboard.Click += new System.EventHandler(this.GoDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(107, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "PowerFlow";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HARDWARESHOP_MANAGEMENT_SYSTEM.Properties.Resources.PowerFlow;
            this.pictureBox1.Location = new System.Drawing.Point(3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(212, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Customers";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtCustomerGender);
            this.panel2.Controls.Add(this.txtCustomerAddress);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.DGVCustomerList);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtCustomerDateOfBirth);
            this.panel2.Controls.Add(this.txtCustomerContactNo);
            this.panel2.Controls.Add(this.txtCustomerName);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(211, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 565);
            this.panel2.TabIndex = 40;
            // 
            // txtCustomerGender
            // 
            this.txtCustomerGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCustomerGender.FormattingEnabled = true;
            this.txtCustomerGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtCustomerGender.Location = new System.Drawing.Point(64, 172);
            this.txtCustomerGender.Name = "txtCustomerGender";
            this.txtCustomerGender.Size = new System.Drawing.Size(190, 27);
            this.txtCustomerGender.TabIndex = 59;
            this.txtCustomerGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerGender_KeyPress);
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(298, 85);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(189, 92);
            this.txtCustomerAddress.TabIndex = 52;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(553, 230);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 35);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.btnDelete, "Delete");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(381, 230);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 35);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Update";
            this.toolTip1.SetToolTip(this.btnUpdate, "Update");
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(211, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 35);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Save";
            this.toolTip1.SetToolTip(this.btnSave, "Save");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DGVCustomerList
            // 
            this.DGVCustomerList.BackgroundColor = System.Drawing.Color.White;
            this.DGVCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomerList.Location = new System.Drawing.Point(5, 325);
            this.DGVCustomerList.Name = "DGVCustomerList";
            this.DGVCustomerList.RowTemplate.Height = 24;
            this.DGVCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCustomerList.Size = new System.Drawing.Size(892, 237);
            this.DGVCustomerList.TabIndex = 48;
            this.DGVCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomerList_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(358, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 19);
            this.label10.TabIndex = 47;
            this.label10.Text = "Customers List";
            // 
            // txtCustomerDateOfBirth
            // 
            this.txtCustomerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtCustomerDateOfBirth.Location = new System.Drawing.Point(717, 85);
            this.txtCustomerDateOfBirth.Name = "txtCustomerDateOfBirth";
            this.txtCustomerDateOfBirth.Size = new System.Drawing.Size(131, 26);
            this.txtCustomerDateOfBirth.TabIndex = 45;
            // 
            // txtCustomerContactNo
            // 
            this.txtCustomerContactNo.Location = new System.Drawing.Point(514, 86);
            this.txtCustomerContactNo.MaxLength = 10;
            this.txtCustomerContactNo.Name = "txtCustomerContactNo";
            this.txtCustomerContactNo.Size = new System.Drawing.Size(171, 26);
            this.txtCustomerContactNo.TabIndex = 44;
            this.txtCustomerContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerContactNo_KeyPress);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(61, 88);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(193, 26);
            this.txtCustomerName.TabIndex = 42;
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(83, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 19);
            this.label9.TabIndex = 41;
            this.label9.Text = "Customer Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(339, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 40;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(730, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(549, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "Contact No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(88, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(14, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Customers Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(505, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 22);
            this.label3.TabIndex = 39;
            this.label3.Text = "HardwareShop Management System";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::HARDWARESHOP_MANAGEMENT_SYSTEM.Properties.Resources.close_icon_16;
            this.pictureBox2.Location = new System.Drawing.Point(1047, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Close");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1122, 630);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Customers_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoManufacture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.PictureBox GoBilling;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.PictureBox GoLogout;
        private System.Windows.Forms.PictureBox GoEmployee;
        private System.Windows.Forms.PictureBox GoCustomer;
        private System.Windows.Forms.PictureBox GoItem;
        private System.Windows.Forms.Button btnManufacture;
        private System.Windows.Forms.PictureBox GoManufacture;
        private System.Windows.Forms.PictureBox GoDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView DGVCustomerList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtCustomerDateOfBirth;
        private System.Windows.Forms.TextBox txtCustomerContactNo;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtCustomerGender;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}