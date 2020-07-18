namespace Global_GUI
{
    partial class ManageLoans
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
            this.cbLoanStatus = new MetroFramework.Controls.MetroComboBox();
            this.loanNameText = new MetroFramework.Controls.MetroTextBox();
            this.LoanNameLabel = new MetroFramework.Controls.MetroLabel();
            this.okBtn = new MetroFramework.Controls.MetroButton();
            this.interestRateEmpText = new MetroFramework.Controls.MetroTextBox();
            this.interestRateEmpLabel = new MetroFramework.Controls.MetroLabel();
            this.interestRateCustomerText = new MetroFramework.Controls.MetroTextBox();
            this.interestRateCustomerLabel = new MetroFramework.Controls.MetroLabel();
            this.loanGrid = new MetroFramework.Controls.MetroGrid();
            this.loanIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestRatePerYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bank_loan_systemDataSet5 = new Global_GUI.Bank_loan_systemDataSet5();
            this.bank_loan_systemDataSet3 = new Global_GUI.Bank_loan_systemDataSet3();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loanTableAdapter = new Global_GUI.Bank_loan_systemDataSet3TableAdapters.loanTableAdapter();
            this.backBtn = new MetroFramework.Controls.MetroButton();
            this.refreshBtn = new MetroFramework.Controls.MetroButton();
            this.searchText = new MetroFramework.Controls.MetroTextBox();
            this.perLabel = new MetroFramework.Controls.MetroLabel();
            this.per = new MetroFramework.Controls.MetroLabel();
            this.bank_loan_systemDataSet4 = new Global_GUI.Bank_loan_systemDataSet4();
            this.loanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loanTableAdapter1 = new Global_GUI.Bank_loan_systemDataSet4TableAdapters.loanTableAdapter();
            this.loanTableAdapter2 = new Global_GUI.Bank_loan_systemDataSet5TableAdapters.loanTableAdapter();
            this.operationLabel = new MetroFramework.Controls.MetroLabel();
            this.requestedLoanBtn = new MetroFramework.Controls.MetroButton();
            this.loantransactionsHistoryBtn = new MetroFramework.Controls.MetroButton();
            this.activeLoanBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.loanGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLoanStatus
            // 
            this.cbLoanStatus.FormattingEnabled = true;
            this.cbLoanStatus.ItemHeight = 23;
            this.cbLoanStatus.Items.AddRange(new object[] {
            "Update Loan",
            "Add New Loan"});
            this.cbLoanStatus.Location = new System.Drawing.Point(214, 95);
            this.cbLoanStatus.Name = "cbLoanStatus";
            this.cbLoanStatus.Size = new System.Drawing.Size(226, 29);
            this.cbLoanStatus.TabIndex = 12;
            this.cbLoanStatus.UseSelectable = true;
            this.cbLoanStatus.SelectedIndexChanged += new System.EventHandler(this.cbCustomerStatus_SelectedIndexChanged);
            // 
            // loanNameText
            // 
            // 
            // 
            // 
            this.loanNameText.CustomButton.Image = null;
            this.loanNameText.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.loanNameText.CustomButton.Name = "";
            this.loanNameText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.loanNameText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loanNameText.CustomButton.TabIndex = 1;
            this.loanNameText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loanNameText.CustomButton.UseSelectable = true;
            this.loanNameText.CustomButton.Visible = false;
            this.loanNameText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.loanNameText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.loanNameText.Lines = new string[0];
            this.loanNameText.Location = new System.Drawing.Point(214, 148);
            this.loanNameText.MaxLength = 32767;
            this.loanNameText.Name = "loanNameText";
            this.loanNameText.PasswordChar = '\0';
            this.loanNameText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loanNameText.SelectedText = "";
            this.loanNameText.SelectionLength = 0;
            this.loanNameText.SelectionStart = 0;
            this.loanNameText.ShortcutsEnabled = true;
            this.loanNameText.Size = new System.Drawing.Size(226, 23);
            this.loanNameText.TabIndex = 23;
            this.loanNameText.UseSelectable = true;
            this.loanNameText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loanNameText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoanNameLabel
            // 
            this.LoanNameLabel.AutoSize = true;
            this.LoanNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LoanNameLabel.Location = new System.Drawing.Point(87, 152);
            this.LoanNameLabel.Name = "LoanNameLabel";
            this.LoanNameLabel.Size = new System.Drawing.Size(85, 19);
            this.LoanNameLabel.TabIndex = 22;
            this.LoanNameLabel.Text = "Loan Name";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(459, 233);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(108, 23);
            this.okBtn.TabIndex = 24;
            this.okBtn.Text = "Update";
            this.okBtn.UseSelectable = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // interestRateEmpText
            // 
            // 
            // 
            // 
            this.interestRateEmpText.CustomButton.Image = null;
            this.interestRateEmpText.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.interestRateEmpText.CustomButton.Name = "";
            this.interestRateEmpText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.interestRateEmpText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.interestRateEmpText.CustomButton.TabIndex = 1;
            this.interestRateEmpText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.interestRateEmpText.CustomButton.UseSelectable = true;
            this.interestRateEmpText.CustomButton.Visible = false;
            this.interestRateEmpText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.interestRateEmpText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.interestRateEmpText.Lines = new string[0];
            this.interestRateEmpText.Location = new System.Drawing.Point(312, 193);
            this.interestRateEmpText.MaxLength = 32767;
            this.interestRateEmpText.Name = "interestRateEmpText";
            this.interestRateEmpText.PasswordChar = '\0';
            this.interestRateEmpText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.interestRateEmpText.SelectedText = "";
            this.interestRateEmpText.SelectionLength = 0;
            this.interestRateEmpText.SelectionStart = 0;
            this.interestRateEmpText.ShortcutsEnabled = true;
            this.interestRateEmpText.Size = new System.Drawing.Size(88, 23);
            this.interestRateEmpText.TabIndex = 26;
            this.interestRateEmpText.UseSelectable = true;
            this.interestRateEmpText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.interestRateEmpText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // interestRateEmpLabel
            // 
            this.interestRateEmpLabel.AutoSize = true;
            this.interestRateEmpLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.interestRateEmpLabel.Location = new System.Drawing.Point(87, 197);
            this.interestRateEmpLabel.Name = "interestRateEmpLabel";
            this.interestRateEmpLabel.Size = new System.Drawing.Size(213, 19);
            this.interestRateEmpLabel.TabIndex = 25;
            this.interestRateEmpLabel.Text = "Interest Rate /Year [Employee]";
            // 
            // interestRateCustomerText
            // 
            // 
            // 
            // 
            this.interestRateCustomerText.CustomButton.Image = null;
            this.interestRateCustomerText.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.interestRateCustomerText.CustomButton.Name = "";
            this.interestRateCustomerText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.interestRateCustomerText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.interestRateCustomerText.CustomButton.TabIndex = 1;
            this.interestRateCustomerText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.interestRateCustomerText.CustomButton.UseSelectable = true;
            this.interestRateCustomerText.CustomButton.Visible = false;
            this.interestRateCustomerText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.interestRateCustomerText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.interestRateCustomerText.Lines = new string[0];
            this.interestRateCustomerText.Location = new System.Drawing.Point(312, 233);
            this.interestRateCustomerText.MaxLength = 32767;
            this.interestRateCustomerText.Name = "interestRateCustomerText";
            this.interestRateCustomerText.PasswordChar = '\0';
            this.interestRateCustomerText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.interestRateCustomerText.SelectedText = "";
            this.interestRateCustomerText.SelectionLength = 0;
            this.interestRateCustomerText.SelectionStart = 0;
            this.interestRateCustomerText.ShortcutsEnabled = true;
            this.interestRateCustomerText.Size = new System.Drawing.Size(88, 23);
            this.interestRateCustomerText.TabIndex = 28;
            this.interestRateCustomerText.UseSelectable = true;
            this.interestRateCustomerText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.interestRateCustomerText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // interestRateCustomerLabel
            // 
            this.interestRateCustomerLabel.AutoSize = true;
            this.interestRateCustomerLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.interestRateCustomerLabel.Location = new System.Drawing.Point(87, 237);
            this.interestRateCustomerLabel.Name = "interestRateCustomerLabel";
            this.interestRateCustomerLabel.Size = new System.Drawing.Size(211, 19);
            this.interestRateCustomerLabel.TabIndex = 27;
            this.interestRateCustomerLabel.Text = "Interest Rate /Year [Customer]";
            // 
            // loanGrid
            // 
            this.loanGrid.AllowUserToResizeRows = false;
            this.loanGrid.AutoGenerateColumns = false;
            this.loanGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loanGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loanGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.loanGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loanGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.loanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loanIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.interestRatePerYearDataGridViewTextBoxColumn,
            this.consumer});
            this.loanGrid.DataSource = this.loanBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.loanGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.loanGrid.EnableHeadersVisualStyles = false;
            this.loanGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loanGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loanGrid.Location = new System.Drawing.Point(110, 325);
            this.loanGrid.Name = "loanGrid";
            this.loanGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loanGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.loanGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.loanGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loanGrid.Size = new System.Drawing.Size(434, 234);
            this.loanGrid.TabIndex = 29;
            this.loanGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loanGrid_CellContentClick);
            // 
            // loanIdDataGridViewTextBoxColumn
            // 
            this.loanIdDataGridViewTextBoxColumn.DataPropertyName = "loanId";
            this.loanIdDataGridViewTextBoxColumn.HeaderText = "loanId";
            this.loanIdDataGridViewTextBoxColumn.Name = "loanIdDataGridViewTextBoxColumn";
            this.loanIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interestRatePerYearDataGridViewTextBoxColumn
            // 
            this.interestRatePerYearDataGridViewTextBoxColumn.DataPropertyName = "interestRatePerYear";
            this.interestRatePerYearDataGridViewTextBoxColumn.HeaderText = "interestRate/Year";
            this.interestRatePerYearDataGridViewTextBoxColumn.Name = "interestRatePerYearDataGridViewTextBoxColumn";
            this.interestRatePerYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consumer
            // 
            this.consumer.DataPropertyName = "consumer";
            this.consumer.HeaderText = "consumer";
            this.consumer.Name = "consumer";
            this.consumer.ReadOnly = true;
            // 
            // loanBindingSource2
            // 
            this.loanBindingSource2.DataMember = "loan";
            this.loanBindingSource2.DataSource = this.bank_loan_systemDataSet5;
            // 
            // bank_loan_systemDataSet5
            // 
            this.bank_loan_systemDataSet5.DataSetName = "Bank_loan_systemDataSet5";
            this.bank_loan_systemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bank_loan_systemDataSet3
            // 
            this.bank_loan_systemDataSet3.DataSetName = "Bank_loan_systemDataSet3";
            this.bank_loan_systemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataMember = "loan";
            this.loanBindingSource.DataSource = this.bank_loan_systemDataSet3;
            // 
            // loanTableAdapter
            // 
            this.loanTableAdapter.ClearBeforeFill = true;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(558, 29);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(79, 23);
            this.backBtn.TabIndex = 30;
            this.backBtn.Text = "Back";
            this.backBtn.UseSelectable = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(407, 284);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 32;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseSelectable = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // searchText
            // 
            // 
            // 
            // 
            this.searchText.CustomButton.Image = null;
            this.searchText.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.searchText.CustomButton.Name = "";
            this.searchText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchText.CustomButton.TabIndex = 1;
            this.searchText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchText.CustomButton.UseSelectable = true;
            this.searchText.CustomButton.Visible = false;
            this.searchText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.searchText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.searchText.Lines = new string[0];
            this.searchText.Location = new System.Drawing.Point(183, 284);
            this.searchText.MaxLength = 32767;
            this.searchText.Name = "searchText";
            this.searchText.PasswordChar = '\0';
            this.searchText.PromptText = "Search here";
            this.searchText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchText.SelectedText = "";
            this.searchText.SelectionLength = 0;
            this.searchText.SelectionStart = 0;
            this.searchText.ShortcutsEnabled = true;
            this.searchText.Size = new System.Drawing.Size(186, 23);
            this.searchText.TabIndex = 31;
            this.searchText.UseSelectable = true;
            this.searchText.WaterMark = "Search here";
            this.searchText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            this.searchText.Click += new System.EventHandler(this.searchText_Click);
            // 
            // perLabel
            // 
            this.perLabel.AutoSize = true;
            this.perLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.perLabel.Location = new System.Drawing.Point(406, 197);
            this.perLabel.Name = "perLabel";
            this.perLabel.Size = new System.Drawing.Size(21, 19);
            this.perLabel.TabIndex = 33;
            this.perLabel.Text = "%";
            // 
            // per
            // 
            this.per.AutoSize = true;
            this.per.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.per.Location = new System.Drawing.Point(406, 237);
            this.per.Name = "per";
            this.per.Size = new System.Drawing.Size(21, 19);
            this.per.TabIndex = 34;
            this.per.Text = "%";
            // 
            // bank_loan_systemDataSet4
            // 
            this.bank_loan_systemDataSet4.DataSetName = "Bank_loan_systemDataSet4";
            this.bank_loan_systemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loanBindingSource1
            // 
            this.loanBindingSource1.DataMember = "loan";
            this.loanBindingSource1.DataSource = this.bank_loan_systemDataSet4;
            // 
            // loanTableAdapter1
            // 
            this.loanTableAdapter1.ClearBeforeFill = true;
            // 
            // loanTableAdapter2
            // 
            this.loanTableAdapter2.ClearBeforeFill = true;
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.operationLabel.Location = new System.Drawing.Point(87, 105);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(77, 19);
            this.operationLabel.TabIndex = 35;
            this.operationLabel.Text = "Operation";
            // 
            // requestedLoanBtn
            // 
            this.requestedLoanBtn.Location = new System.Drawing.Point(529, 87);
            this.requestedLoanBtn.Name = "requestedLoanBtn";
            this.requestedLoanBtn.Size = new System.Drawing.Size(108, 23);
            this.requestedLoanBtn.TabIndex = 36;
            this.requestedLoanBtn.Text = "Requested Loan";
            this.requestedLoanBtn.UseSelectable = true;
            this.requestedLoanBtn.Click += new System.EventHandler(this.requestedLoanBtn_Click);
            // 
            // loantransactionsHistoryBtn
            // 
            this.loantransactionsHistoryBtn.Location = new System.Drawing.Point(496, 116);
            this.loantransactionsHistoryBtn.Name = "loantransactionsHistoryBtn";
            this.loantransactionsHistoryBtn.Size = new System.Drawing.Size(141, 23);
            this.loantransactionsHistoryBtn.TabIndex = 37;
            this.loantransactionsHistoryBtn.Text = "Loan Transactions History";
            this.loantransactionsHistoryBtn.UseSelectable = true;
            this.loantransactionsHistoryBtn.Click += new System.EventHandler(this.loantransactionsHistoryBtn_Click);
            // 
            // activeLoanBtn
            // 
            this.activeLoanBtn.Location = new System.Drawing.Point(544, 58);
            this.activeLoanBtn.Name = "activeLoanBtn";
            this.activeLoanBtn.Size = new System.Drawing.Size(93, 23);
            this.activeLoanBtn.TabIndex = 38;
            this.activeLoanBtn.Text = "Active Loan";
            this.activeLoanBtn.UseSelectable = true;
            this.activeLoanBtn.Click += new System.EventHandler(this.activeLoanBtn_Click);
            // 
            // ManageLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 600);
            this.Controls.Add(this.activeLoanBtn);
            this.Controls.Add(this.loantransactionsHistoryBtn);
            this.Controls.Add(this.requestedLoanBtn);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.per);
            this.Controls.Add(this.perLabel);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.loanGrid);
            this.Controls.Add(this.interestRateCustomerText);
            this.Controls.Add(this.interestRateCustomerLabel);
            this.Controls.Add(this.interestRateEmpText);
            this.Controls.Add(this.interestRateEmpLabel);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.loanNameText);
            this.Controls.Add(this.LoanNameLabel);
            this.Controls.Add(this.cbLoanStatus);
            this.Name = "ManageLoans";
            this.Text = "Manage Loans";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageLoans_FormClosed);
            this.Load += new System.EventHandler(this.ManageLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loanGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cbLoanStatus;
        private MetroFramework.Controls.MetroTextBox loanNameText;
        private MetroFramework.Controls.MetroLabel LoanNameLabel;
        private MetroFramework.Controls.MetroButton okBtn;
        private MetroFramework.Controls.MetroTextBox interestRateEmpText;
        private MetroFramework.Controls.MetroLabel interestRateEmpLabel;
        private MetroFramework.Controls.MetroTextBox interestRateCustomerText;
        private MetroFramework.Controls.MetroLabel interestRateCustomerLabel;
        private MetroFramework.Controls.MetroGrid loanGrid;
        private Bank_loan_systemDataSet3 bank_loan_systemDataSet3;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private Bank_loan_systemDataSet3TableAdapters.loanTableAdapter loanTableAdapter;
        private MetroFramework.Controls.MetroButton backBtn;
        private MetroFramework.Controls.MetroButton refreshBtn;
        private MetroFramework.Controls.MetroTextBox searchText;
        private MetroFramework.Controls.MetroLabel perLabel;
        private MetroFramework.Controls.MetroLabel per;
        private Bank_loan_systemDataSet4 bank_loan_systemDataSet4;
        private System.Windows.Forms.BindingSource loanBindingSource1;
        private Bank_loan_systemDataSet4TableAdapters.loanTableAdapter loanTableAdapter1;
        private Bank_loan_systemDataSet5 bank_loan_systemDataSet5;
        private System.Windows.Forms.BindingSource loanBindingSource2;
        private Bank_loan_systemDataSet5TableAdapters.loanTableAdapter loanTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestRatePerYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumer;
        private MetroFramework.Controls.MetroLabel operationLabel;
        private MetroFramework.Controls.MetroButton requestedLoanBtn;
        private MetroFramework.Controls.MetroButton loantransactionsHistoryBtn;
        private MetroFramework.Controls.MetroButton activeLoanBtn;
    }
}