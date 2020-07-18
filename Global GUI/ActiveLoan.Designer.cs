namespace Global_GUI
{
    partial class ActiveLoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backBtn = new MetroFramework.Controls.MetroButton();
            this.activeGrid = new MetroFramework.Controls.MetroGrid();
            this.loanTransactionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostOfLoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payableAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueLoanAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfPaymentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidNoOfPaymentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanApprovalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeLoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bank_loan_systemDataSet9 = new Global_GUI.Bank_loan_systemDataSet9();
            this.activeLoanTableAdapter = new Global_GUI.Bank_loan_systemDataSet9TableAdapters.activeLoanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.activeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeLoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(542, 43);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(79, 23);
            this.backBtn.TabIndex = 34;
            this.backBtn.Text = "Back";
            this.backBtn.UseSelectable = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // activeGrid
            // 
            this.activeGrid.AllowUserToResizeRows = false;
            this.activeGrid.AutoGenerateColumns = false;
            this.activeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.activeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.activeGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.activeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.activeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loanTransactionIdDataGridViewTextBoxColumn,
            this.loanIdDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.loanAmountDataGridViewTextBoxColumn,
            this.monthlyPaymentDataGridViewTextBoxColumn,
            this.interestDataGridViewTextBoxColumn,
            this.totalCostOfLoanDataGridViewTextBoxColumn,
            this.payableAmountDataGridViewTextBoxColumn,
            this.dueLoanAmountDataGridViewTextBoxColumn,
            this.noOfPaymentsDataGridViewTextBoxColumn,
            this.paidNoOfPaymentsDataGridViewTextBoxColumn,
            this.loanApprovalDateDataGridViewTextBoxColumn,
            this.approveDataGridViewTextBoxColumn});
            this.activeGrid.DataSource = this.activeLoanBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.activeGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.activeGrid.EnableHeadersVisualStyles = false;
            this.activeGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.activeGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.activeGrid.Location = new System.Drawing.Point(0, 101);
            this.activeGrid.Name = "activeGrid";
            this.activeGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.activeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.activeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activeGrid.Size = new System.Drawing.Size(652, 251);
            this.activeGrid.TabIndex = 36;
            // 
            // loanTransactionIdDataGridViewTextBoxColumn
            // 
            this.loanTransactionIdDataGridViewTextBoxColumn.DataPropertyName = "LoanTransactionId";
            this.loanTransactionIdDataGridViewTextBoxColumn.HeaderText = "Loan Trans action Id";
            this.loanTransactionIdDataGridViewTextBoxColumn.Name = "loanTransactionIdDataGridViewTextBoxColumn";
            this.loanTransactionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.loanTransactionIdDataGridViewTextBoxColumn.Width = 35;
            // 
            // loanIdDataGridViewTextBoxColumn
            // 
            this.loanIdDataGridViewTextBoxColumn.DataPropertyName = "loanId";
            this.loanIdDataGridViewTextBoxColumn.HeaderText = "Loan Id";
            this.loanIdDataGridViewTextBoxColumn.Name = "loanIdDataGridViewTextBoxColumn";
            this.loanIdDataGridViewTextBoxColumn.Width = 35;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "userid";
            this.useridDataGridViewTextBoxColumn.HeaderText = "User Id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.Width = 40;
            // 
            // loanAmountDataGridViewTextBoxColumn
            // 
            this.loanAmountDataGridViewTextBoxColumn.DataPropertyName = "loanAmount";
            this.loanAmountDataGridViewTextBoxColumn.HeaderText = "Loan Amount";
            this.loanAmountDataGridViewTextBoxColumn.Name = "loanAmountDataGridViewTextBoxColumn";
            this.loanAmountDataGridViewTextBoxColumn.Width = 70;
            // 
            // monthlyPaymentDataGridViewTextBoxColumn
            // 
            this.monthlyPaymentDataGridViewTextBoxColumn.DataPropertyName = "monthlyPayment";
            this.monthlyPaymentDataGridViewTextBoxColumn.HeaderText = "Monthly Payment";
            this.monthlyPaymentDataGridViewTextBoxColumn.Name = "monthlyPaymentDataGridViewTextBoxColumn";
            this.monthlyPaymentDataGridViewTextBoxColumn.Width = 70;
            // 
            // interestDataGridViewTextBoxColumn
            // 
            this.interestDataGridViewTextBoxColumn.DataPropertyName = "interest";
            this.interestDataGridViewTextBoxColumn.HeaderText = "interest";
            this.interestDataGridViewTextBoxColumn.Name = "interestDataGridViewTextBoxColumn";
            this.interestDataGridViewTextBoxColumn.Visible = false;
            // 
            // totalCostOfLoanDataGridViewTextBoxColumn
            // 
            this.totalCostOfLoanDataGridViewTextBoxColumn.DataPropertyName = "totalCostOfLoan";
            this.totalCostOfLoanDataGridViewTextBoxColumn.HeaderText = "Total Cost of Loan";
            this.totalCostOfLoanDataGridViewTextBoxColumn.Name = "totalCostOfLoanDataGridViewTextBoxColumn";
            this.totalCostOfLoanDataGridViewTextBoxColumn.Width = 75;
            // 
            // payableAmountDataGridViewTextBoxColumn
            // 
            this.payableAmountDataGridViewTextBoxColumn.DataPropertyName = "payableAmount";
            this.payableAmountDataGridViewTextBoxColumn.HeaderText = "Due Total Amount";
            this.payableAmountDataGridViewTextBoxColumn.Name = "payableAmountDataGridViewTextBoxColumn";
            this.payableAmountDataGridViewTextBoxColumn.Width = 70;
            // 
            // dueLoanAmountDataGridViewTextBoxColumn
            // 
            this.dueLoanAmountDataGridViewTextBoxColumn.DataPropertyName = "dueLoanAmount";
            this.dueLoanAmountDataGridViewTextBoxColumn.HeaderText = "Due Loan Amount";
            this.dueLoanAmountDataGridViewTextBoxColumn.Name = "dueLoanAmountDataGridViewTextBoxColumn";
            this.dueLoanAmountDataGridViewTextBoxColumn.Width = 75;
            // 
            // noOfPaymentsDataGridViewTextBoxColumn
            // 
            this.noOfPaymentsDataGridViewTextBoxColumn.DataPropertyName = "noOfPayments";
            this.noOfPaymentsDataGridViewTextBoxColumn.HeaderText = "No of Pay ments";
            this.noOfPaymentsDataGridViewTextBoxColumn.Name = "noOfPaymentsDataGridViewTextBoxColumn";
            this.noOfPaymentsDataGridViewTextBoxColumn.Width = 35;
            // 
            // paidNoOfPaymentsDataGridViewTextBoxColumn
            // 
            this.paidNoOfPaymentsDataGridViewTextBoxColumn.DataPropertyName = "paidNoOfPayments";
            this.paidNoOfPaymentsDataGridViewTextBoxColumn.HeaderText = "Paid Pay ments";
            this.paidNoOfPaymentsDataGridViewTextBoxColumn.Name = "paidNoOfPaymentsDataGridViewTextBoxColumn";
            this.paidNoOfPaymentsDataGridViewTextBoxColumn.Width = 35;
            // 
            // loanApprovalDateDataGridViewTextBoxColumn
            // 
            this.loanApprovalDateDataGridViewTextBoxColumn.DataPropertyName = "loanApprovalDate";
            this.loanApprovalDateDataGridViewTextBoxColumn.HeaderText = "Loan Approval Date";
            this.loanApprovalDateDataGridViewTextBoxColumn.Name = "loanApprovalDateDataGridViewTextBoxColumn";
            this.loanApprovalDateDataGridViewTextBoxColumn.Width = 70;
            // 
            // approveDataGridViewTextBoxColumn
            // 
            this.approveDataGridViewTextBoxColumn.DataPropertyName = "approve";
            this.approveDataGridViewTextBoxColumn.HeaderText = "approve";
            this.approveDataGridViewTextBoxColumn.Name = "approveDataGridViewTextBoxColumn";
            this.approveDataGridViewTextBoxColumn.Visible = false;
            // 
            // activeLoanBindingSource
            // 
            this.activeLoanBindingSource.DataMember = "activeLoan";
            this.activeLoanBindingSource.DataSource = this.bank_loan_systemDataSet9;
            // 
            // bank_loan_systemDataSet9
            // 
            this.bank_loan_systemDataSet9.DataSetName = "Bank_loan_systemDataSet9";
            this.bank_loan_systemDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activeLoanTableAdapter
            // 
            this.activeLoanTableAdapter.ClearBeforeFill = true;
            // 
            // ActiveLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 600);
            this.Controls.Add(this.activeGrid);
            this.Controls.Add(this.backBtn);
            this.Name = "ActiveLoan";
            this.Text = "Active Loan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActiveLoan_FormClosed);
            this.Load += new System.EventHandler(this.ActiveLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeLoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton backBtn;
        private MetroFramework.Controls.MetroGrid activeGrid;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dueLoanAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfPaymentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidNoOfPaymentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanApprovalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approveDataGridViewTextBoxColumn;
    }
}