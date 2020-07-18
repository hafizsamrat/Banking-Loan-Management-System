namespace Global_GUI
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.manageCustomerBtn = new MetroFramework.Controls.MetroButton();
            this.customerTransactionsBtn = new MetroFramework.Controls.MetroButton();
            this.logoutBtn = new MetroFramework.Controls.MetroButton();
            this.profileBtn = new MetroFramework.Controls.MetroButton();
            this.welcomeLabel = new MetroFramework.Controls.MetroLabel();
            this.manageEmployeeBtn = new MetroFramework.Controls.MetroButton();
            this.manageLoansBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // manageCustomerBtn
            // 
            this.manageCustomerBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.manageCustomerBtn.Location = new System.Drawing.Point(265, 282);
            this.manageCustomerBtn.Name = "manageCustomerBtn";
            this.manageCustomerBtn.Size = new System.Drawing.Size(134, 23);
            this.manageCustomerBtn.TabIndex = 11;
            this.manageCustomerBtn.Text = "Manage Customers";
            this.manageCustomerBtn.UseSelectable = true;
            this.manageCustomerBtn.Click += new System.EventHandler(this.manageCustomerBtn_Click);
            // 
            // customerTransactionsBtn
            // 
            this.customerTransactionsBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.customerTransactionsBtn.Location = new System.Drawing.Point(247, 375);
            this.customerTransactionsBtn.Name = "customerTransactionsBtn";
            this.customerTransactionsBtn.Size = new System.Drawing.Size(170, 23);
            this.customerTransactionsBtn.TabIndex = 10;
            this.customerTransactionsBtn.Text = "View Transactions";
            this.customerTransactionsBtn.UseSelectable = true;
            this.customerTransactionsBtn.Click += new System.EventHandler(this.customerTransactionsBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.logoutBtn.Location = new System.Drawing.Point(294, 474);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 9;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseSelectable = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.profileBtn.Location = new System.Drawing.Point(294, 237);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(75, 23);
            this.profileBtn.TabIndex = 7;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseSelectable = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.welcomeLabel.Location = new System.Drawing.Point(23, 60);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(146, 19);
            this.welcomeLabel.TabIndex = 6;
            this.welcomeLabel.Text = "Welcome UserName";
            // 
            // manageEmployeeBtn
            // 
            this.manageEmployeeBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.manageEmployeeBtn.Location = new System.Drawing.Point(265, 327);
            this.manageEmployeeBtn.Name = "manageEmployeeBtn";
            this.manageEmployeeBtn.Size = new System.Drawing.Size(134, 23);
            this.manageEmployeeBtn.TabIndex = 12;
            this.manageEmployeeBtn.Text = "Manage Employees";
            this.manageEmployeeBtn.UseSelectable = true;
            this.manageEmployeeBtn.Click += new System.EventHandler(this.manageEmployeeBtn_Click);
            // 
            // manageLoansBtn
            // 
            this.manageLoansBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.manageLoansBtn.Location = new System.Drawing.Point(265, 425);
            this.manageLoansBtn.Name = "manageLoansBtn";
            this.manageLoansBtn.Size = new System.Drawing.Size(134, 23);
            this.manageLoansBtn.TabIndex = 13;
            this.manageLoansBtn.Text = "Manage Loans";
            this.manageLoansBtn.UseSelectable = true;
            this.manageLoansBtn.Click += new System.EventHandler(this.manageLoansBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.manageLoansBtn);
            this.Controls.Add(this.manageEmployeeBtn);
            this.Controls.Add(this.manageCustomerBtn);
            this.Controls.Add(this.customerTransactionsBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "AdminHome";
            this.Text = "Admin Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminHome_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton manageCustomerBtn;
        private MetroFramework.Controls.MetroButton customerTransactionsBtn;
        private MetroFramework.Controls.MetroButton logoutBtn;
        private MetroFramework.Controls.MetroButton profileBtn;
        private MetroFramework.Controls.MetroLabel welcomeLabel;
        private MetroFramework.Controls.MetroButton manageEmployeeBtn;
        private MetroFramework.Controls.MetroButton manageLoansBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}