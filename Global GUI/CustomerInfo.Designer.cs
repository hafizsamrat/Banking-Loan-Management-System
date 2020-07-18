namespace Global_GUI
{
    partial class CustomerInfo
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
            this.cbCustomerStatus = new MetroFramework.Controls.MetroComboBox();
            this.customerStatusLabel = new MetroFramework.Controls.MetroLabel();
            this.okBtn = new MetroFramework.Controls.MetroButton();
            this.userIdLabel = new MetroFramework.Controls.MetroLabel();
            this.userIdText = new MetroFramework.Controls.MetroTextBox();
            this.customerGrid = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bank_loan_systemDataSet1 = new Global_GUI.Bank_loan_systemDataSet1();
            this.bank_loan_systemDataSet = new Global_GUI.Bank_loan_systemDataSet();
            this.bankloansystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Global_GUI.Bank_loan_systemDataSet1TableAdapters.customerTableAdapter();
            this.backBtn = new MetroFramework.Controls.MetroButton();
            this.searchText = new MetroFramework.Controls.MetroTextBox();
            this.refreshBtn = new MetroFramework.Controls.MetroButton();
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankloansystemDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCustomerStatus
            // 
            this.cbCustomerStatus.FormattingEnabled = true;
            this.cbCustomerStatus.ItemHeight = 23;
            this.cbCustomerStatus.Items.AddRange(new object[] {
            "Active Customers",
            "New Customers",
            "Suspended Customers"});
            this.cbCustomerStatus.Location = new System.Drawing.Point(233, 99);
            this.cbCustomerStatus.Name = "cbCustomerStatus";
            this.cbCustomerStatus.Size = new System.Drawing.Size(186, 29);
            this.cbCustomerStatus.TabIndex = 0;
            this.cbCustomerStatus.UseSelectable = true;
            this.cbCustomerStatus.SelectedIndexChanged += new System.EventHandler(this.cbCustomerStatus_SelectedIndexChanged);
            // 
            // customerStatusLabel
            // 
            this.customerStatusLabel.AutoSize = true;
            this.customerStatusLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.customerStatusLabel.Location = new System.Drawing.Point(151, 99);
            this.customerStatusLabel.Name = "customerStatusLabel";
            this.customerStatusLabel.Size = new System.Drawing.Size(49, 19);
            this.customerStatusLabel.TabIndex = 1;
            this.customerStatusLabel.Text = "Status";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(453, 137);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(108, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "Suspend";
            this.okBtn.UseSelectable = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.userIdLabel.Location = new System.Drawing.Point(151, 141);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(57, 19);
            this.userIdLabel.TabIndex = 3;
            this.userIdLabel.Text = "User ID";
            // 
            // userIdText
            // 
            // 
            // 
            // 
            this.userIdText.CustomButton.Image = null;
            this.userIdText.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.userIdText.CustomButton.Name = "";
            this.userIdText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.userIdText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userIdText.CustomButton.TabIndex = 1;
            this.userIdText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userIdText.CustomButton.UseSelectable = true;
            this.userIdText.CustomButton.Visible = false;
            this.userIdText.Enabled = false;
            this.userIdText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.userIdText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.userIdText.Lines = new string[0];
            this.userIdText.Location = new System.Drawing.Point(233, 141);
            this.userIdText.MaxLength = 32767;
            this.userIdText.Name = "userIdText";
            this.userIdText.PasswordChar = '\0';
            this.userIdText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userIdText.SelectedText = "";
            this.userIdText.SelectionLength = 0;
            this.userIdText.SelectionStart = 0;
            this.userIdText.ShortcutsEnabled = true;
            this.userIdText.Size = new System.Drawing.Size(186, 23);
            this.userIdText.TabIndex = 4;
            this.userIdText.UseSelectable = true;
            this.userIdText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userIdText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // customerGrid
            // 
            this.customerGrid.AllowUserToAddRows = false;
            this.customerGrid.AutoGenerateColumns = false;
            this.customerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.useridDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn});
            this.customerGrid.DataSource = this.customerBindingSource;
            this.customerGrid.Location = new System.Drawing.Point(67, 289);
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.Size = new System.Drawing.Size(530, 210);
            this.customerGrid.TabIndex = 5;
            this.customerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGrid_CellContentClick);
            // 
            // select
            // 
            this.select.HeaderText = "select";
            this.select.Name = "select";
            this.select.Width = 40;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "userid";
            this.useridDataGridViewTextBoxColumn.HeaderText = "userid";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            this.useridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.useridDataGridViewTextBoxColumn.Width = 80;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 70;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.bank_loan_systemDataSet1;
            // 
            // bank_loan_systemDataSet1
            // 
            this.bank_loan_systemDataSet1.DataSetName = "Bank_loan_systemDataSet1";
            this.bank_loan_systemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bank_loan_systemDataSet
            // 
            this.bank_loan_systemDataSet.DataSetName = "Bank_loan_systemDataSet";
            this.bank_loan_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankloansystemDataSetBindingSource
            // 
            this.bankloansystemDataSetBindingSource.DataSource = this.bank_loan_systemDataSet;
            this.bankloansystemDataSetBindingSource.Position = 0;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(550, 40);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Back";
            this.backBtn.UseSelectable = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
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
            this.searchText.Location = new System.Drawing.Point(233, 188);
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
            this.searchText.TabIndex = 7;
            this.searchText.UseSelectable = true;
            this.searchText.WaterMark = "Search here";
            this.searchText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(233, 228);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 8;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseSelectable = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(344, 228);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseSelectable = true;
            this.deleteBtn.Visible = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 600);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.customerGrid);
            this.Controls.Add(this.userIdText);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.customerStatusLabel);
            this.Controls.Add(this.cbCustomerStatus);
            this.Name = "CustomerInfo";
            this.Text = "Customers View";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerInfo_FormClosed);
            this.Load += new System.EventHandler(this.CustomerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankloansystemDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbCustomerStatus;
        private MetroFramework.Controls.MetroLabel customerStatusLabel;
        private MetroFramework.Controls.MetroButton okBtn;
        private MetroFramework.Controls.MetroLabel userIdLabel;
        private MetroFramework.Controls.MetroTextBox userIdText;
        private System.Windows.Forms.DataGridView customerGrid;
        private System.Windows.Forms.BindingSource bankloansystemDataSetBindingSource;
        private Bank_loan_systemDataSet bank_loan_systemDataSet;
        private Bank_loan_systemDataSet1 bank_loan_systemDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Bank_loan_systemDataSet1TableAdapters.customerTableAdapter customerTableAdapter;
        private MetroFramework.Controls.MetroButton backBtn;
        private MetroFramework.Controls.MetroTextBox searchText;
        private MetroFramework.Controls.MetroButton refreshBtn;
        private MetroFramework.Controls.MetroButton deleteBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
    }
}