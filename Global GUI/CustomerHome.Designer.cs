namespace Global_GUI
{
    partial class CustomerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHome));
            this.welcomeLabel = new MetroFramework.Controls.MetroLabel();
            this.profileBtn = new MetroFramework.Controls.MetroButton();
            this.logoutBtn = new MetroFramework.Controls.MetroButton();
            this.transactionBtn = new MetroFramework.Controls.MetroButton();
            this.myLoansBtn = new MetroFramework.Controls.MetroButton();
            this.applyLoanBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.welcomeLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.welcomeLabel.Location = new System.Drawing.Point(23, 86);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(170, 25);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome userName";
            // 
            // profileBtn
            // 
            this.profileBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.profileBtn.Location = new System.Drawing.Point(177, 305);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(75, 23);
            this.profileBtn.TabIndex = 1;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseSelectable = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.logoutBtn.Location = new System.Drawing.Point(562, 33);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseSelectable = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // transactionBtn
            // 
            this.transactionBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.transactionBtn.Location = new System.Drawing.Point(287, 305);
            this.transactionBtn.Name = "transactionBtn";
            this.transactionBtn.Size = new System.Drawing.Size(96, 23);
            this.transactionBtn.TabIndex = 3;
            this.transactionBtn.Text = "Transactions";
            this.transactionBtn.UseSelectable = true;
            this.transactionBtn.Click += new System.EventHandler(this.transactionBtn_Click);
            // 
            // myLoansBtn
            // 
            this.myLoansBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.myLoansBtn.Location = new System.Drawing.Point(421, 305);
            this.myLoansBtn.Name = "myLoansBtn";
            this.myLoansBtn.Size = new System.Drawing.Size(74, 23);
            this.myLoansBtn.TabIndex = 4;
            this.myLoansBtn.Text = "My Loans";
            this.myLoansBtn.UseSelectable = true;
            this.myLoansBtn.Click += new System.EventHandler(this.myLoansBtn_Click);
            // 
            // applyLoanBtn
            // 
            this.applyLoanBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.applyLoanBtn.Location = new System.Drawing.Point(277, 383);
            this.applyLoanBtn.Name = "applyLoanBtn";
            this.applyLoanBtn.Size = new System.Drawing.Size(121, 23);
            this.applyLoanBtn.TabIndex = 5;
            this.applyLoanBtn.Text = "Apply For Loan";
            this.applyLoanBtn.UseSelectable = true;
            this.applyLoanBtn.Click += new System.EventHandler(this.applyLoanBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.applyLoanBtn);
            this.Controls.Add(this.myLoansBtn);
            this.Controls.Add(this.transactionBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "CustomerHome";
            this.Text = "Customer Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerHome_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel welcomeLabel;
        private MetroFramework.Controls.MetroButton profileBtn;
        private MetroFramework.Controls.MetroButton logoutBtn;
        private MetroFramework.Controls.MetroButton transactionBtn;
        private MetroFramework.Controls.MetroButton myLoansBtn;
        private MetroFramework.Controls.MetroButton applyLoanBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}