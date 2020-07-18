namespace Global_GUI
{
    partial class MyLoans
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
            this.activeLoanGrid = new MetroFramework.Controls.MetroGrid();
            this.bank_loan_systemDataSet6 = new Global_GUI.Bank_loan_systemDataSet6();
            this.activeLoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activeLoanTableAdapter = new Global_GUI.Bank_loan_systemDataSet6TableAdapters.activeLoanTableAdapter();
            this.backBtn = new MetroFramework.Controls.MetroButton();
            this.loanTransactionHistory = new MetroFramework.Controls.MetroButton();
            this.monthlyPayLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.payInstallmentLabel = new MetroFramework.Controls.MetroLabel();
            this.monthlyPaymentText = new MetroFramework.Controls.MetroTextBox();
            this.payAmountLabel = new MetroFramework.Controls.MetroLabel();
            this.payAmountText = new MetroFramework.Controls.MetroTextBox();
            this.dueInstallmentsText = new MetroFramework.Controls.MetroTextBox();
            this.payInstallmentsText = new MetroFramework.Controls.MetroTextBox();
            this.payBtn = new MetroFramework.Controls.MetroButton();
            this.myBalanceText = new MetroFramework.Controls.MetroTextBox();
            this.balanceLabel = new MetroFramework.Controls.MetroLabel();
            this.bank_loan_systemDataSet8 = new Global_GUI.Bank_loan_systemDataSet8();
            this.activeLoanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.activeLoanTableAdapter1 = new Global_GUI.Bank_loan_systemDataSet8TableAdapters.activeLoanTableAdapter();
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
            this.dueLoanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.activeLoanGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeLoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeLoanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // activeLoanGrid
            // 
            this.activeLoanGrid.AllowUserToAddRows = false;
            this.activeLoanGrid.AllowUserToDeleteRows = false;
            this.activeLoanGrid.AllowUserToResizeRows = false;
            this.activeLoanGrid.AutoGenerateColumns = false;
            this.activeLoanGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.activeLoanGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.activeLoanGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.activeLoanGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activeLoanGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.activeLoanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activeLoanGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dueLoanAmount});
            this.activeLoanGrid.DataSource = this.activeLoanBindingSource1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.activeLoanGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.activeLoanGrid.EnableHeadersVisualStyles = false;
            this.activeLoanGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.activeLoanGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.activeLoanGrid.Location = new System.Drawing.Point(11, 321);
            this.activeLoanGrid.Name = "activeLoanGrid";
            this.activeLoanGrid.ReadOnly = true;
            this.activeLoanGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activeLoanGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.activeLoanGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.activeLoanGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activeLoanGrid.Size = new System.Drawing.Size(647, 256);
            this.activeLoanGrid.TabIndex = 0;
            this.activeLoanGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.activeLoanGrid_CellContentClick);
            // 
            // bank_loan_systemDataSet6
            // 
            this.bank_loan_systemDataSet6.DataSetName = "Bank_loan_systemDataSet6";
            this.bank_loan_systemDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activeLoanBindingSource
            // 
            this.activeLoanBindingSource.DataMember = "activeLoan";
            this.activeLoanBindingSource.DataSource = this.bank_loan_systemDataSet6;
            // 
            // activeLoanTableAdapter
            // 
            this.activeLoanTableAdapter.ClearBeforeFill = true;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(558, 45);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(79, 23);
            this.backBtn.TabIndex = 31;
            this.backBtn.Text = "Back";
            this.backBtn.UseSelectable = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // loanTransactionHistory
            // 
            this.loanTransactionHistory.Location = new System.Drawing.Point(495, 89);
            this.loanTransactionHistory.Name = "loanTransactionHistory";
            this.loanTransactionHistory.Size = new System.Drawing.Size(142, 23);
            this.loanTransactionHistory.TabIndex = 32;
            this.loanTransactionHistory.Text = "Loan Transactions History";
            this.loanTransactionHistory.UseSelectable = true;
            this.loanTransactionHistory.Click += new System.EventHandler(this.loanTransactionHistory_Click);
            // 
            // monthlyPayLabel
            // 
            this.monthlyPayLabel.AutoSize = true;
            this.monthlyPayLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.monthlyPayLabel.Location = new System.Drawing.Point(58, 125);
            this.monthlyPayLabel.Name = "monthlyPayLabel";
            this.monthlyPayLabel.Size = new System.Drawing.Size(127, 19);
            this.monthlyPayLabel.TabIndex = 33;
            this.monthlyPayLabel.Text = "Monthly Payment";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(58, 176);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(118, 19);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "Due Installments";
            // 
            // payInstallmentLabel
            // 
            this.payInstallmentLabel.AutoSize = true;
            this.payInstallmentLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.payInstallmentLabel.Location = new System.Drawing.Point(58, 219);
            this.payInstallmentLabel.Name = "payInstallmentLabel";
            this.payInstallmentLabel.Size = new System.Drawing.Size(117, 19);
            this.payInstallmentLabel.TabIndex = 35;
            this.payInstallmentLabel.Text = "Pay Installments";
            // 
            // monthlyPaymentText
            // 
            // 
            // 
            // 
            this.monthlyPaymentText.CustomButton.Image = null;
            this.monthlyPaymentText.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.monthlyPaymentText.CustomButton.Name = "";
            this.monthlyPaymentText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.monthlyPaymentText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.monthlyPaymentText.CustomButton.TabIndex = 1;
            this.monthlyPaymentText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.monthlyPaymentText.CustomButton.UseSelectable = true;
            this.monthlyPaymentText.CustomButton.Visible = false;
            this.monthlyPaymentText.Enabled = false;
            this.monthlyPaymentText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.monthlyPaymentText.Lines = new string[0];
            this.monthlyPaymentText.Location = new System.Drawing.Point(207, 121);
            this.monthlyPaymentText.MaxLength = 32767;
            this.monthlyPaymentText.Name = "monthlyPaymentText";
            this.monthlyPaymentText.PasswordChar = '\0';
            this.monthlyPaymentText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.monthlyPaymentText.SelectedText = "";
            this.monthlyPaymentText.SelectionLength = 0;
            this.monthlyPaymentText.SelectionStart = 0;
            this.monthlyPaymentText.ShortcutsEnabled = true;
            this.monthlyPaymentText.Size = new System.Drawing.Size(164, 23);
            this.monthlyPaymentText.TabIndex = 36;
            this.monthlyPaymentText.UseSelectable = true;
            this.monthlyPaymentText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.monthlyPaymentText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // payAmountLabel
            // 
            this.payAmountLabel.AutoSize = true;
            this.payAmountLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.payAmountLabel.Location = new System.Drawing.Point(58, 270);
            this.payAmountLabel.Name = "payAmountLabel";
            this.payAmountLabel.Size = new System.Drawing.Size(112, 19);
            this.payAmountLabel.TabIndex = 37;
            this.payAmountLabel.Text = "Paying Amount";
            // 
            // payAmountText
            // 
            // 
            // 
            // 
            this.payAmountText.CustomButton.Image = null;
            this.payAmountText.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.payAmountText.CustomButton.Name = "";
            this.payAmountText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.payAmountText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.payAmountText.CustomButton.TabIndex = 1;
            this.payAmountText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.payAmountText.CustomButton.UseSelectable = true;
            this.payAmountText.CustomButton.Visible = false;
            this.payAmountText.Enabled = false;
            this.payAmountText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.payAmountText.Lines = new string[0];
            this.payAmountText.Location = new System.Drawing.Point(207, 266);
            this.payAmountText.MaxLength = 32767;
            this.payAmountText.Name = "payAmountText";
            this.payAmountText.PasswordChar = '\0';
            this.payAmountText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.payAmountText.SelectedText = "";
            this.payAmountText.SelectionLength = 0;
            this.payAmountText.SelectionStart = 0;
            this.payAmountText.ShortcutsEnabled = true;
            this.payAmountText.Size = new System.Drawing.Size(164, 23);
            this.payAmountText.TabIndex = 38;
            this.payAmountText.UseSelectable = true;
            this.payAmountText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.payAmountText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dueInstallmentsText
            // 
            // 
            // 
            // 
            this.dueInstallmentsText.CustomButton.Image = null;
            this.dueInstallmentsText.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.dueInstallmentsText.CustomButton.Name = "";
            this.dueInstallmentsText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dueInstallmentsText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dueInstallmentsText.CustomButton.TabIndex = 1;
            this.dueInstallmentsText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dueInstallmentsText.CustomButton.UseSelectable = true;
            this.dueInstallmentsText.CustomButton.Visible = false;
            this.dueInstallmentsText.Enabled = false;
            this.dueInstallmentsText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.dueInstallmentsText.Lines = new string[0];
            this.dueInstallmentsText.Location = new System.Drawing.Point(207, 172);
            this.dueInstallmentsText.MaxLength = 32767;
            this.dueInstallmentsText.Name = "dueInstallmentsText";
            this.dueInstallmentsText.PasswordChar = '\0';
            this.dueInstallmentsText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dueInstallmentsText.SelectedText = "";
            this.dueInstallmentsText.SelectionLength = 0;
            this.dueInstallmentsText.SelectionStart = 0;
            this.dueInstallmentsText.ShortcutsEnabled = true;
            this.dueInstallmentsText.Size = new System.Drawing.Size(164, 23);
            this.dueInstallmentsText.TabIndex = 39;
            this.dueInstallmentsText.UseSelectable = true;
            this.dueInstallmentsText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dueInstallmentsText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // payInstallmentsText
            // 
            // 
            // 
            // 
            this.payInstallmentsText.CustomButton.Image = null;
            this.payInstallmentsText.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.payInstallmentsText.CustomButton.Name = "";
            this.payInstallmentsText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.payInstallmentsText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.payInstallmentsText.CustomButton.TabIndex = 1;
            this.payInstallmentsText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.payInstallmentsText.CustomButton.UseSelectable = true;
            this.payInstallmentsText.CustomButton.Visible = false;
            this.payInstallmentsText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.payInstallmentsText.Lines = new string[0];
            this.payInstallmentsText.Location = new System.Drawing.Point(207, 215);
            this.payInstallmentsText.MaxLength = 32767;
            this.payInstallmentsText.Name = "payInstallmentsText";
            this.payInstallmentsText.PasswordChar = '\0';
            this.payInstallmentsText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.payInstallmentsText.SelectedText = "";
            this.payInstallmentsText.SelectionLength = 0;
            this.payInstallmentsText.SelectionStart = 0;
            this.payInstallmentsText.ShortcutsEnabled = true;
            this.payInstallmentsText.Size = new System.Drawing.Size(164, 23);
            this.payInstallmentsText.TabIndex = 40;
            this.payInstallmentsText.UseSelectable = true;
            this.payInstallmentsText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.payInstallmentsText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.payInstallmentsText.TextChanged += new System.EventHandler(this.payInstallmentsText_TextChanged);
            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(450, 266);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(79, 23);
            this.payBtn.TabIndex = 41;
            this.payBtn.Text = "Pay";
            this.payBtn.UseSelectable = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // myBalanceText
            // 
            // 
            // 
            // 
            this.myBalanceText.CustomButton.Image = null;
            this.myBalanceText.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.myBalanceText.CustomButton.Name = "";
            this.myBalanceText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.myBalanceText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.myBalanceText.CustomButton.TabIndex = 1;
            this.myBalanceText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.myBalanceText.CustomButton.UseSelectable = true;
            this.myBalanceText.CustomButton.Visible = false;
            this.myBalanceText.Enabled = false;
            this.myBalanceText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.myBalanceText.Lines = new string[0];
            this.myBalanceText.Location = new System.Drawing.Point(218, 56);
            this.myBalanceText.MaxLength = 32767;
            this.myBalanceText.Name = "myBalanceText";
            this.myBalanceText.PasswordChar = '\0';
            this.myBalanceText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.myBalanceText.SelectedText = "";
            this.myBalanceText.SelectionLength = 0;
            this.myBalanceText.SelectionStart = 0;
            this.myBalanceText.ShortcutsEnabled = true;
            this.myBalanceText.Size = new System.Drawing.Size(175, 23);
            this.myBalanceText.TabIndex = 43;
            this.myBalanceText.UseSelectable = true;
            this.myBalanceText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.myBalanceText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.balanceLabel.Location = new System.Drawing.Point(116, 60);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(86, 19);
            this.balanceLabel.TabIndex = 42;
            this.balanceLabel.Text = "My Balance";
            // 
            // bank_loan_systemDataSet8
            // 
            this.bank_loan_systemDataSet8.DataSetName = "Bank_loan_systemDataSet8";
            this.bank_loan_systemDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activeLoanBindingSource1
            // 
            this.activeLoanBindingSource1.DataMember = "activeLoan";
            this.activeLoanBindingSource1.DataSource = this.bank_loan_systemDataSet8;
            // 
            // activeLoanTableAdapter1
            // 
            this.activeLoanTableAdapter1.ClearBeforeFill = true;
            // 
            // loanTransactionIdDataGridViewTextBoxColumn
            // 
            this.loanTransactionIdDataGridViewTextBoxColumn.DataPropertyName = "LoanTransactionId";
            this.loanTransactionIdDataGridViewTextBoxColumn.HeaderText = "LoanTransactionId";
            this.loanTransactionIdDataGridViewTextBoxColumn.Name = "loanTransactionIdDataGridViewTextBoxColumn";
            this.loanTransactionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.loanTransactionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // loanIdDataGridViewTextBoxColumn
            // 
            this.loanIdDataGridViewTextBoxColumn.DataPropertyName = "loanId";
            this.loanIdDataGridViewTextBoxColumn.HeaderText = "loanId";
            this.loanIdDataGridViewTextBoxColumn.Name = "loanIdDataGridViewTextBoxColumn";
            this.loanIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.loanIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "userid";
            this.useridDataGridViewTextBoxColumn.HeaderText = "userid";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            this.useridDataGridViewTextBoxColumn.Visible = false;
            // 
            // loanAmountDataGridViewTextBoxColumn
            // 
            this.loanAmountDataGridViewTextBoxColumn.DataPropertyName = "loanAmount";
            this.loanAmountDataGridViewTextBoxColumn.HeaderText = "Loan Amount";
            this.loanAmountDataGridViewTextBoxColumn.Name = "loanAmountDataGridViewTextBoxColumn";
            this.loanAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthlyPaymentDataGridViewTextBoxColumn
            // 
            this.monthlyPaymentDataGridViewTextBoxColumn.DataPropertyName = "monthlyPayment";
            this.monthlyPaymentDataGridViewTextBoxColumn.HeaderText = "Monthly Payment";
            this.monthlyPaymentDataGridViewTextBoxColumn.Name = "monthlyPaymentDataGridViewTextBoxColumn";
            this.monthlyPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interestDataGridViewTextBoxColumn
            // 
            this.interestDataGridViewTextBoxColumn.DataPropertyName = "interest";
            this.interestDataGridViewTextBoxColumn.HeaderText = "interest";
            this.interestDataGridViewTextBoxColumn.Name = "interestDataGridViewTextBoxColumn";
            this.interestDataGridViewTextBoxColumn.ReadOnly = true;
            this.interestDataGridViewTextBoxColumn.Width = 80;
            // 
            // totalCostOfLoanDataGridViewTextBoxColumn
            // 
            this.totalCostOfLoanDataGridViewTextBoxColumn.DataPropertyName = "totalCostOfLoan";
            this.totalCostOfLoanDataGridViewTextBoxColumn.HeaderText = "totalCostOfLoan";
            this.totalCostOfLoanDataGridViewTextBoxColumn.Name = "totalCostOfLoanDataGridViewTextBoxColumn";
            this.totalCostOfLoanDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalCostOfLoanDataGridViewTextBoxColumn.Visible = false;
            // 
            // payableAmountDataGridViewTextBoxColumn
            // 
            this.payableAmountDataGridViewTextBoxColumn.DataPropertyName = "payableAmount";
            this.payableAmountDataGridViewTextBoxColumn.HeaderText = "Due Amount";
            this.payableAmountDataGridViewTextBoxColumn.Name = "payableAmountDataGridViewTextBoxColumn";
            this.payableAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.payableAmountDataGridViewTextBoxColumn.Width = 80;
            // 
            // noOfPaymentsDataGridViewTextBoxColumn
            // 
            this.noOfPaymentsDataGridViewTextBoxColumn.DataPropertyName = "noOfPayments";
            this.noOfPaymentsDataGridViewTextBoxColumn.HeaderText = "Total Payments";
            this.noOfPaymentsDataGridViewTextBoxColumn.Name = "noOfPaymentsDataGridViewTextBoxColumn";
            this.noOfPaymentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.noOfPaymentsDataGridViewTextBoxColumn.Width = 50;
            // 
            // paidNoOfPaymentsDataGridViewTextBoxColumn
            // 
            this.paidNoOfPaymentsDataGridViewTextBoxColumn.DataPropertyName = "paidNoOfPayments";
            this.paidNoOfPaymentsDataGridViewTextBoxColumn.HeaderText = "Paid Installments";
            this.paidNoOfPaymentsDataGridViewTextBoxColumn.Name = "paidNoOfPaymentsDataGridViewTextBoxColumn";
            this.paidNoOfPaymentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.paidNoOfPaymentsDataGridViewTextBoxColumn.Width = 60;
            // 
            // loanApprovalDateDataGridViewTextBoxColumn
            // 
            this.loanApprovalDateDataGridViewTextBoxColumn.DataPropertyName = "loanApprovalDate";
            this.loanApprovalDateDataGridViewTextBoxColumn.HeaderText = "Loan Approval Date";
            this.loanApprovalDateDataGridViewTextBoxColumn.Name = "loanApprovalDateDataGridViewTextBoxColumn";
            this.loanApprovalDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // approveDataGridViewTextBoxColumn
            // 
            this.approveDataGridViewTextBoxColumn.DataPropertyName = "approve";
            this.approveDataGridViewTextBoxColumn.HeaderText = "approve";
            this.approveDataGridViewTextBoxColumn.Name = "approveDataGridViewTextBoxColumn";
            this.approveDataGridViewTextBoxColumn.ReadOnly = true;
            this.approveDataGridViewTextBoxColumn.Visible = false;
            // 
            // dueLoanAmount
            // 
            this.dueLoanAmount.DataPropertyName = "dueLoanAmount";
            this.dueLoanAmount.HeaderText = "dueLoanAmount";
            this.dueLoanAmount.Name = "dueLoanAmount";
            this.dueLoanAmount.ReadOnly = true;
            this.dueLoanAmount.Visible = false;
            // 
            // MyLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 600);
            this.Controls.Add(this.myBalanceText);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.payInstallmentsText);
            this.Controls.Add(this.dueInstallmentsText);
            this.Controls.Add(this.payAmountText);
            this.Controls.Add(this.payAmountLabel);
            this.Controls.Add(this.monthlyPaymentText);
            this.Controls.Add(this.payInstallmentLabel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.monthlyPayLabel);
            this.Controls.Add(this.loanTransactionHistory);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.activeLoanGrid);
            this.Name = "MyLoans";
            this.Text = "My Loans";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyLoans_FormClosed);
            this.Load += new System.EventHandler(this.MyLoans_Load);
            this.VisibleChanged += new System.EventHandler(this.MyLoans_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.activeLoanGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeLoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeLoanBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid activeLoanGrid;
        private Bank_loan_systemDataSet6 bank_loan_systemDataSet6;
        private System.Windows.Forms.BindingSource activeLoanBindingSource;
        private Bank_loan_systemDataSet6TableAdapters.activeLoanTableAdapter activeLoanTableAdapter;
        private MetroFramework.Controls.MetroButton backBtn;
        private MetroFramework.Controls.MetroButton loanTransactionHistory;
        private MetroFramework.Controls.MetroLabel monthlyPayLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel payInstallmentLabel;
        private MetroFramework.Controls.MetroTextBox monthlyPaymentText;
        private MetroFramework.Controls.MetroLabel payAmountLabel;
        private MetroFramework.Controls.MetroTextBox payAmountText;
        private MetroFramework.Controls.MetroTextBox dueInstallmentsText;
        private MetroFramework.Controls.MetroTextBox payInstallmentsText;
        private MetroFramework.Controls.MetroButton payBtn;
        private MetroFramework.Controls.MetroTextBox myBalanceText;
        private MetroFramework.Controls.MetroLabel balanceLabel;
        private Bank_loan_systemDataSet8 bank_loan_systemDataSet8;
        private System.Windows.Forms.BindingSource activeLoanBindingSource1;
        private Bank_loan_systemDataSet8TableAdapters.activeLoanTableAdapter activeLoanTableAdapter1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dueLoanAmount;
    }
}