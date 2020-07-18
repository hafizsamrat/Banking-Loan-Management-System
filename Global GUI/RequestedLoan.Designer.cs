namespace Global_GUI
{
    partial class RequestedLoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.requestLoanGrid = new MetroFramework.Controls.MetroGrid();
            this.bank_loan_systemDataSet9 = new Global_GUI.Bank_loan_systemDataSet9();
            this.activeLoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activeLoanTableAdapter = new Global_GUI.Bank_loan_systemDataSet9TableAdapters.activeLoanTableAdapter();
            this.loanTransactionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostOfLoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payableAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfPaymentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidNoOfPaymentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanApprovalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueLoanAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanTransactionIdText = new MetroFramework.Controls.MetroTextBox();
            this.loanTransactionIdLabel = new MetroFramework.Controls.MetroLabel();
            this.approveBtn = new MetroFramework.Controls.MetroButton();
            this.rejectBtn = new MetroFramework.Controls.MetroButton();
            this.backBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.requestLoanGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeLoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // requestLoanGrid
            // 
            this.requestLoanGrid.AllowUserToAddRows = false;
            this.requestLoanGrid.AllowUserToDeleteRows = false;
            this.requestLoanGrid.AllowUserToResizeRows = false;
            this.requestLoanGrid.AutoGenerateColumns = false;
            this.requestLoanGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.requestLoanGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.requestLoanGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.requestLoanGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.requestLoanGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.requestLoanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestLoanGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loanTransactionIdDataGridViewTextBoxColumn,
            this.loanIdDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.loanAmountDataGridViewTextBoxColumn,
            this.monthlyPaymentDataGridViewTextBoxColumn,
            this.interestDataGridViewTextBoxColumn,
            this.totalCostOfLoanDataGridViewTextBoxColumn,
            this.payableAmountDataGridViewTextBoxColumn,
            this.noOfPaymentsDataGridViewTextBoxColumn,
            this.paidNoOfPaymentsDataGridViewTextBoxColumn,
            this.loanApprovalDateDataGridViewTextBoxColumn,
            this.approveDataGridViewTextBoxColumn,
            this.dueLoanAmountDataGridViewTextBoxColumn});
            this.requestLoanGrid.DataSource = this.activeLoanBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.requestLoanGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.requestLoanGrid.EnableHeadersVisualStyles = false;
            this.requestLoanGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.requestLoanGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.requestLoanGrid.Location = new System.Drawing.Point(23, 242);
            this.requestLoanGrid.Name = "requestLoanGrid";
            this.requestLoanGrid.ReadOnly = true;
            this.requestLoanGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.requestLoanGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.requestLoanGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.requestLoanGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.requestLoanGrid.Size = new System.Drawing.Size(625, 296);
            this.requestLoanGrid.TabIndex = 0;
            this.requestLoanGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestLoanGrid_CellContentClick);
            // 
            // bank_loan_systemDataSet9
            // 
            this.bank_loan_systemDataSet9.DataSetName = "Bank_loan_systemDataSet9";
            this.bank_loan_systemDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activeLoanBindingSource
            // 
            this.activeLoanBindingSource.DataMember = "activeLoan";
            this.activeLoanBindingSource.DataSource = this.bank_loan_systemDataSet9;
            // 
            // activeLoanTableAdapter
            // 
            this.activeLoanTableAdapter.ClearBeforeFill = true;
            // 
            // loanTransactionIdDataGridViewTextBoxColumn
            // 
            this.loanTransactionIdDataGridViewTextBoxColumn.DataPropertyName = "LoanTransactionId";
            this.loanTransactionIdDataGridViewTextBoxColumn.HeaderText = "Loan Transaction Id";
            this.loanTransactionIdDataGridViewTextBoxColumn.Name = "loanTransactionIdDataGridViewTextBoxColumn";
            this.loanTransactionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.loanTransactionIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // loanIdDataGridViewTextBoxColumn
            // 
            this.loanIdDataGridViewTextBoxColumn.DataPropertyName = "loanId";
            this.loanIdDataGridViewTextBoxColumn.HeaderText = "Loan Id";
            this.loanIdDataGridViewTextBoxColumn.Name = "loanIdDataGridViewTextBoxColumn";
            this.loanIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.loanIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "userid";
            this.useridDataGridViewTextBoxColumn.HeaderText = "User Id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            this.useridDataGridViewTextBoxColumn.Width = 50;
            // 
            // loanAmountDataGridViewTextBoxColumn
            // 
            this.loanAmountDataGridViewTextBoxColumn.DataPropertyName = "loanAmount";
            this.loanAmountDataGridViewTextBoxColumn.HeaderText = "Loan Amount";
            this.loanAmountDataGridViewTextBoxColumn.Name = "loanAmountDataGridViewTextBoxColumn";
            this.loanAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.loanAmountDataGridViewTextBoxColumn.Width = 90;
            // 
            // monthlyPaymentDataGridViewTextBoxColumn
            // 
            this.monthlyPaymentDataGridViewTextBoxColumn.DataPropertyName = "monthlyPayment";
            this.monthlyPaymentDataGridViewTextBoxColumn.HeaderText = "Monthly Payment";
            this.monthlyPaymentDataGridViewTextBoxColumn.Name = "monthlyPaymentDataGridViewTextBoxColumn";
            this.monthlyPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthlyPaymentDataGridViewTextBoxColumn.Width = 90;
            // 
            // interestDataGridViewTextBoxColumn
            // 
            this.interestDataGridViewTextBoxColumn.DataPropertyName = "interest";
            this.interestDataGridViewTextBoxColumn.HeaderText = "Interest";
            this.interestDataGridViewTextBoxColumn.Name = "interestDataGridViewTextBoxColumn";
            this.interestDataGridViewTextBoxColumn.ReadOnly = true;
            this.interestDataGridViewTextBoxColumn.Width = 90;
            // 
            // totalCostOfLoanDataGridViewTextBoxColumn
            // 
            this.totalCostOfLoanDataGridViewTextBoxColumn.DataPropertyName = "totalCostOfLoan";
            this.totalCostOfLoanDataGridViewTextBoxColumn.HeaderText = "Total Cost of Loan";
            this.totalCostOfLoanDataGridViewTextBoxColumn.Name = "totalCostOfLoanDataGridViewTextBoxColumn";
            this.totalCostOfLoanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payableAmountDataGridViewTextBoxColumn
            // 
            this.payableAmountDataGridViewTextBoxColumn.DataPropertyName = "payableAmount";
            this.payableAmountDataGridViewTextBoxColumn.HeaderText = "payableAmount";
            this.payableAmountDataGridViewTextBoxColumn.Name = "payableAmountDataGridViewTextBoxColumn";
            this.payableAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.payableAmountDataGridViewTextBoxColumn.Visible = false;
            // 
            // noOfPaymentsDataGridViewTextBoxColumn
            // 
            this.noOfPaymentsDataGridViewTextBoxColumn.DataPropertyName = "noOfPayments";
            this.noOfPaymentsDataGridViewTextBoxColumn.HeaderText = "No of Payments";
            this.noOfPaymentsDataGridViewTextBoxColumn.Name = "noOfPaymentsDataGridViewTextBoxColumn";
            this.noOfPaymentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paidNoOfPaymentsDataGridViewTextBoxColumn
            // 
            this.paidNoOfPaymentsDataGridViewTextBoxColumn.DataPropertyName = "paidNoOfPayments";
            this.paidNoOfPaymentsDataGridViewTextBoxColumn.HeaderText = "paidNoOfPayments";
            this.paidNoOfPaymentsDataGridViewTextBoxColumn.Name = "paidNoOfPaymentsDataGridViewTextBoxColumn";
            this.paidNoOfPaymentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.paidNoOfPaymentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // loanApprovalDateDataGridViewTextBoxColumn
            // 
            this.loanApprovalDateDataGridViewTextBoxColumn.DataPropertyName = "loanApprovalDate";
            this.loanApprovalDateDataGridViewTextBoxColumn.HeaderText = "loanApprovalDate";
            this.loanApprovalDateDataGridViewTextBoxColumn.Name = "loanApprovalDateDataGridViewTextBoxColumn";
            this.loanApprovalDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.loanApprovalDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // approveDataGridViewTextBoxColumn
            // 
            this.approveDataGridViewTextBoxColumn.DataPropertyName = "approve";
            this.approveDataGridViewTextBoxColumn.HeaderText = "approve";
            this.approveDataGridViewTextBoxColumn.Name = "approveDataGridViewTextBoxColumn";
            this.approveDataGridViewTextBoxColumn.ReadOnly = true;
            this.approveDataGridViewTextBoxColumn.Visible = false;
            // 
            // dueLoanAmountDataGridViewTextBoxColumn
            // 
            this.dueLoanAmountDataGridViewTextBoxColumn.DataPropertyName = "dueLoanAmount";
            this.dueLoanAmountDataGridViewTextBoxColumn.HeaderText = "dueLoanAmount";
            this.dueLoanAmountDataGridViewTextBoxColumn.Name = "dueLoanAmountDataGridViewTextBoxColumn";
            this.dueLoanAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.dueLoanAmountDataGridViewTextBoxColumn.Visible = false;
            // 
            // loanTransactionIdText
            // 
            // 
            // 
            // 
            this.loanTransactionIdText.CustomButton.Image = null;
            this.loanTransactionIdText.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.loanTransactionIdText.CustomButton.Name = "";
            this.loanTransactionIdText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.loanTransactionIdText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loanTransactionIdText.CustomButton.TabIndex = 1;
            this.loanTransactionIdText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loanTransactionIdText.CustomButton.UseSelectable = true;
            this.loanTransactionIdText.CustomButton.Visible = false;
            this.loanTransactionIdText.Enabled = false;
            this.loanTransactionIdText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.loanTransactionIdText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.loanTransactionIdText.Lines = new string[0];
            this.loanTransactionIdText.Location = new System.Drawing.Point(248, 138);
            this.loanTransactionIdText.MaxLength = 32767;
            this.loanTransactionIdText.Name = "loanTransactionIdText";
            this.loanTransactionIdText.PasswordChar = '\0';
            this.loanTransactionIdText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loanTransactionIdText.SelectedText = "";
            this.loanTransactionIdText.SelectionLength = 0;
            this.loanTransactionIdText.SelectionStart = 0;
            this.loanTransactionIdText.ShortcutsEnabled = true;
            this.loanTransactionIdText.Size = new System.Drawing.Size(226, 23);
            this.loanTransactionIdText.TabIndex = 25;
            this.loanTransactionIdText.UseSelectable = true;
            this.loanTransactionIdText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loanTransactionIdText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // loanTransactionIdLabel
            // 
            this.loanTransactionIdLabel.AutoSize = true;
            this.loanTransactionIdLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.loanTransactionIdLabel.Location = new System.Drawing.Point(88, 142);
            this.loanTransactionIdLabel.Name = "loanTransactionIdLabel";
            this.loanTransactionIdLabel.Size = new System.Drawing.Size(138, 19);
            this.loanTransactionIdLabel.TabIndex = 24;
            this.loanTransactionIdLabel.Text = "Loan Transaction Id";
            // 
            // approveBtn
            // 
            this.approveBtn.Location = new System.Drawing.Point(248, 178);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(93, 23);
            this.approveBtn.TabIndex = 39;
            this.approveBtn.Text = "Approve";
            this.approveBtn.UseSelectable = true;
            this.approveBtn.Visible = false;
            this.approveBtn.Click += new System.EventHandler(this.approveBtn_Click);
            // 
            // rejectBtn
            // 
            this.rejectBtn.Location = new System.Drawing.Point(381, 178);
            this.rejectBtn.Name = "rejectBtn";
            this.rejectBtn.Size = new System.Drawing.Size(93, 23);
            this.rejectBtn.TabIndex = 40;
            this.rejectBtn.Text = "Reject";
            this.rejectBtn.UseSelectable = true;
            this.rejectBtn.Visible = false;
            this.rejectBtn.Click += new System.EventHandler(this.rejectBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(543, 31);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(79, 23);
            this.backBtn.TabIndex = 41;
            this.backBtn.Text = "Back";
            this.backBtn.UseSelectable = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // RequestedLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 600);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.rejectBtn);
            this.Controls.Add(this.approveBtn);
            this.Controls.Add(this.loanTransactionIdText);
            this.Controls.Add(this.loanTransactionIdLabel);
            this.Controls.Add(this.requestLoanGrid);
            this.Name = "RequestedLoan";
            this.Text = "Requested Loan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RequestedLoan_FormClosed);
            this.Load += new System.EventHandler(this.RequestedLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestLoanGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeLoanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid requestLoanGrid;
        private Bank_loan_systemDataSet9 bank_loan_systemDataSet9;
        private System.Windows.Forms.BindingSource activeLoanBindingSource;
        private Bank_loan_systemDataSet9TableAdapters.activeLoanTableAdapter activeLoanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanTransactionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostOfLoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payableAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfPaymentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidNoOfPaymentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanApprovalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueLoanAmountDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox loanTransactionIdText;
        private MetroFramework.Controls.MetroLabel loanTransactionIdLabel;
        private MetroFramework.Controls.MetroButton approveBtn;
        private MetroFramework.Controls.MetroButton rejectBtn;
        private MetroFramework.Controls.MetroButton backBtn;
    }
}