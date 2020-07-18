namespace Global_GUI
{
    partial class EmployeeHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeHome));
            this.welcomeLabel = new MetroFramework.Controls.MetroLabel();
            this.profileBtn = new MetroFramework.Controls.MetroButton();
            this.employeeTransactionBtn = new MetroFramework.Controls.MetroButton();
            this.logoutBtn = new MetroFramework.Controls.MetroButton();
            this.customerTransactionsBtn = new MetroFramework.Controls.MetroButton();
            this.manageCustomerBtn = new MetroFramework.Controls.MetroButton();
            this.applyLoanBtn = new MetroFramework.Controls.MetroButton();
            this.myLoansBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.welcomeLabel.Location = new System.Drawing.Point(23, 83);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(146, 19);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome UserName";
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.profileBtn.Location = new System.Drawing.Point(172, 256);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(75, 23);
            this.profileBtn.TabIndex = 1;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseSelectable = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // employeeTransactionBtn
            // 
            this.employeeTransactionBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.employeeTransactionBtn.Location = new System.Drawing.Point(172, 298);
            this.employeeTransactionBtn.Name = "employeeTransactionBtn";
            this.employeeTransactionBtn.Size = new System.Drawing.Size(124, 23);
            this.employeeTransactionBtn.TabIndex = 2;
            this.employeeTransactionBtn.Text = "My Transactions";
            this.employeeTransactionBtn.UseSelectable = true;
            this.employeeTransactionBtn.Click += new System.EventHandler(this.employeeTransactionBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.logoutBtn.Location = new System.Drawing.Point(546, 37);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseSelectable = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // customerTransactionsBtn
            // 
            this.customerTransactionsBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.customerTransactionsBtn.Location = new System.Drawing.Point(239, 377);
            this.customerTransactionsBtn.Name = "customerTransactionsBtn";
            this.customerTransactionsBtn.Size = new System.Drawing.Size(170, 23);
            this.customerTransactionsBtn.TabIndex = 4;
            this.customerTransactionsBtn.Text = "Customers Transactions";
            this.customerTransactionsBtn.UseSelectable = true;
            this.customerTransactionsBtn.Click += new System.EventHandler(this.customerTransactionsBtn_Click);
            // 
            // manageCustomerBtn
            // 
            this.manageCustomerBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.manageCustomerBtn.Location = new System.Drawing.Point(206, 337);
            this.manageCustomerBtn.Name = "manageCustomerBtn";
            this.manageCustomerBtn.Size = new System.Drawing.Size(134, 23);
            this.manageCustomerBtn.TabIndex = 5;
            this.manageCustomerBtn.Text = "Manage Customers";
            this.manageCustomerBtn.UseSelectable = true;
            this.manageCustomerBtn.Click += new System.EventHandler(this.manageCustomerBtn_Click);
            // 
            // applyLoanBtn
            // 
            this.applyLoanBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.applyLoanBtn.Location = new System.Drawing.Point(288, 417);
            this.applyLoanBtn.Name = "applyLoanBtn";
            this.applyLoanBtn.Size = new System.Drawing.Size(121, 23);
            this.applyLoanBtn.TabIndex = 6;
            this.applyLoanBtn.Text = "Apply For Loan";
            this.applyLoanBtn.UseSelectable = true;
            this.applyLoanBtn.Click += new System.EventHandler(this.applyLoanBtn_Click);
            // 
            // myLoansBtn
            // 
            this.myLoansBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.myLoansBtn.Location = new System.Drawing.Point(335, 457);
            this.myLoansBtn.Name = "myLoansBtn";
            this.myLoansBtn.Size = new System.Drawing.Size(74, 23);
            this.myLoansBtn.TabIndex = 7;
            this.myLoansBtn.Text = "My Loans";
            this.myLoansBtn.UseSelectable = true;
            this.myLoansBtn.Click += new System.EventHandler(this.myLoansBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(251, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.myLoansBtn);
            this.Controls.Add(this.applyLoanBtn);
            this.Controls.Add(this.manageCustomerBtn);
            this.Controls.Add(this.customerTransactionsBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.employeeTransactionBtn);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "EmployeeHome";
            this.Text = "Employee Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeHome_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel welcomeLabel;
        private MetroFramework.Controls.MetroButton profileBtn;
        private MetroFramework.Controls.MetroButton employeeTransactionBtn;
        private MetroFramework.Controls.MetroButton logoutBtn;
        private MetroFramework.Controls.MetroButton customerTransactionsBtn;
        private MetroFramework.Controls.MetroButton manageCustomerBtn;
        private MetroFramework.Controls.MetroButton applyLoanBtn;
        private MetroFramework.Controls.MetroButton myLoansBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}