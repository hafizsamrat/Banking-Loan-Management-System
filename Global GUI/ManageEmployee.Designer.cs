namespace Global_GUI
{
    partial class ManageEmployee
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
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            this.refreshBtn = new MetroFramework.Controls.MetroButton();
            this.searchText = new MetroFramework.Controls.MetroTextBox();
            this.backBtn = new MetroFramework.Controls.MetroButton();
            this.userIdText = new MetroFramework.Controls.MetroTextBox();
            this.userIdLabel = new MetroFramework.Controls.MetroLabel();
            this.okBtn = new MetroFramework.Controls.MetroButton();
            this.customerStatusLabel = new MetroFramework.Controls.MetroLabel();
            this.cbCustomerStatus = new MetroFramework.Controls.MetroComboBox();
            this.employeeGrid = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bank_loan_systemDataSet2 = new Global_GUI.Bank_loan_systemDataSet2();
            this.bank_loan_systemDataSet = new Global_GUI.Bank_loan_systemDataSet();
            this.bankloansystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Global_GUI.Bank_loan_systemDataSet2TableAdapters.employeeTableAdapter();
            this.nameText = new MetroFramework.Controls.MetroTextBox();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.emailText = new MetroFramework.Controls.MetroTextBox();
            this.emailLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordText = new MetroFramework.Controls.MetroTextBox();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.genderLabel = new MetroFramework.Controls.MetroLabel();
            this.maleRadioBtn = new MetroFramework.Controls.MetroRadioButton();
            this.femaleRadioBtn = new MetroFramework.Controls.MetroRadioButton();
            this.salaryText = new MetroFramework.Controls.MetroTextBox();
            this.salaryLabel = new MetroFramework.Controls.MetroLabel();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joiningDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankloansystemDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(468, 299);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseSelectable = true;
            this.deleteBtn.Visible = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(363, 299);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 17;
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
            this.searchText.Location = new System.Drawing.Point(149, 299);
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
            this.searchText.TabIndex = 16;
            this.searchText.UseSelectable = true;
            this.searchText.WaterMark = "Search here";
            this.searchText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(562, 28);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "Back";
            this.backBtn.UseSelectable = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
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
            this.userIdText.Location = new System.Drawing.Point(252, 109);
            this.userIdText.MaxLength = 32767;
            this.userIdText.Name = "userIdText";
            this.userIdText.PasswordChar = '\0';
            this.userIdText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userIdText.SelectedText = "";
            this.userIdText.SelectionLength = 0;
            this.userIdText.SelectionStart = 0;
            this.userIdText.ShortcutsEnabled = true;
            this.userIdText.Size = new System.Drawing.Size(186, 23);
            this.userIdText.TabIndex = 14;
            this.userIdText.UseSelectable = true;
            this.userIdText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userIdText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.userIdLabel.Location = new System.Drawing.Point(149, 111);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(57, 19);
            this.userIdLabel.TabIndex = 13;
            this.userIdLabel.Text = "User ID";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(484, 200);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(108, 23);
            this.okBtn.TabIndex = 12;
            this.okBtn.Text = "Suspend";
            this.okBtn.UseSelectable = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // customerStatusLabel
            // 
            this.customerStatusLabel.AutoSize = true;
            this.customerStatusLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.customerStatusLabel.Location = new System.Drawing.Point(149, 78);
            this.customerStatusLabel.Name = "customerStatusLabel";
            this.customerStatusLabel.Size = new System.Drawing.Size(49, 19);
            this.customerStatusLabel.TabIndex = 11;
            this.customerStatusLabel.Text = "Status";
            // 
            // cbCustomerStatus
            // 
            this.cbCustomerStatus.FormattingEnabled = true;
            this.cbCustomerStatus.ItemHeight = 23;
            this.cbCustomerStatus.Items.AddRange(new object[] {
            "Active Employees",
            "Suspended Employees",
            "Add Employees"});
            this.cbCustomerStatus.Location = new System.Drawing.Point(252, 70);
            this.cbCustomerStatus.Name = "cbCustomerStatus";
            this.cbCustomerStatus.Size = new System.Drawing.Size(186, 29);
            this.cbCustomerStatus.TabIndex = 10;
            this.cbCustomerStatus.UseSelectable = true;
            this.cbCustomerStatus.SelectedIndexChanged += new System.EventHandler(this.cbCustomerStatus_SelectedIndexChanged);
            // 
            // employeeGrid
            // 
            this.employeeGrid.AutoGenerateColumns = false;
            this.employeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.joiningDateDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.employeeGrid.DataSource = this.employeeBindingSource;
            this.employeeGrid.Location = new System.Drawing.Point(6, 343);
            this.employeeGrid.Name = "employeeGrid";
            this.employeeGrid.Size = new System.Drawing.Size(647, 253);
            this.employeeGrid.TabIndex = 19;
            this.employeeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeGrid_CellContentClick);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.bank_loan_systemDataSet2;
            // 
            // bank_loan_systemDataSet2
            // 
            this.bank_loan_systemDataSet2.DataSetName = "Bank_loan_systemDataSet2";
            this.bank_loan_systemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // nameText
            // 
            // 
            // 
            // 
            this.nameText.CustomButton.Image = null;
            this.nameText.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.nameText.CustomButton.Name = "";
            this.nameText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameText.CustomButton.TabIndex = 1;
            this.nameText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameText.CustomButton.UseSelectable = true;
            this.nameText.CustomButton.Visible = false;
            this.nameText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.nameText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.nameText.Lines = new string[0];
            this.nameText.Location = new System.Drawing.Point(252, 142);
            this.nameText.MaxLength = 32767;
            this.nameText.Name = "nameText";
            this.nameText.PasswordChar = '\0';
            this.nameText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameText.SelectedText = "";
            this.nameText.SelectionLength = 0;
            this.nameText.SelectionStart = 0;
            this.nameText.ShortcutsEnabled = true;
            this.nameText.Size = new System.Drawing.Size(186, 23);
            this.nameText.TabIndex = 21;
            this.nameText.UseSelectable = true;
            this.nameText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.nameLabel.Location = new System.Drawing.Point(149, 143);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 19);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Name";
            // 
            // emailText
            // 
            // 
            // 
            // 
            this.emailText.CustomButton.Image = null;
            this.emailText.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.emailText.CustomButton.Name = "";
            this.emailText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailText.CustomButton.TabIndex = 1;
            this.emailText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailText.CustomButton.UseSelectable = true;
            this.emailText.CustomButton.Visible = false;
            this.emailText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.emailText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.emailText.Lines = new string[0];
            this.emailText.Location = new System.Drawing.Point(252, 172);
            this.emailText.MaxLength = 32767;
            this.emailText.Name = "emailText";
            this.emailText.PasswordChar = '\0';
            this.emailText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailText.SelectedText = "";
            this.emailText.SelectionLength = 0;
            this.emailText.SelectionStart = 0;
            this.emailText.ShortcutsEnabled = true;
            this.emailText.Size = new System.Drawing.Size(186, 23);
            this.emailText.TabIndex = 23;
            this.emailText.UseSelectable = true;
            this.emailText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.emailLabel.Location = new System.Drawing.Point(149, 175);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(45, 19);
            this.emailLabel.TabIndex = 22;
            this.emailLabel.Text = "Email";
            // 
            // passwordText
            // 
            // 
            // 
            // 
            this.passwordText.CustomButton.Image = null;
            this.passwordText.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.passwordText.CustomButton.Name = "";
            this.passwordText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordText.CustomButton.TabIndex = 1;
            this.passwordText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordText.CustomButton.UseSelectable = true;
            this.passwordText.CustomButton.Visible = false;
            this.passwordText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passwordText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.passwordText.Lines = new string[0];
            this.passwordText.Location = new System.Drawing.Point(252, 202);
            this.passwordText.MaxLength = 32767;
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '\0';
            this.passwordText.PromptText = "Minimum length 4 ,maximum 20";
            this.passwordText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordText.SelectedText = "";
            this.passwordText.SelectionLength = 0;
            this.passwordText.SelectionStart = 0;
            this.passwordText.ShortcutsEnabled = true;
            this.passwordText.Size = new System.Drawing.Size(186, 23);
            this.passwordText.TabIndex = 25;
            this.passwordText.UseSelectable = true;
            this.passwordText.WaterMark = "Minimum length 4 ,maximum 20";
            this.passwordText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.passwordLabel.Location = new System.Drawing.Point(149, 204);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 19);
            this.passwordLabel.TabIndex = 24;
            this.passwordLabel.Text = "Password";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.genderLabel.Location = new System.Drawing.Point(149, 229);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(58, 19);
            this.genderLabel.TabIndex = 26;
            this.genderLabel.Text = "Gender";
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.Location = new System.Drawing.Point(252, 233);
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Size = new System.Drawing.Size(49, 15);
            this.maleRadioBtn.TabIndex = 27;
            this.maleRadioBtn.Text = "Male";
            this.maleRadioBtn.UseSelectable = true;
            // 
            // femaleRadioBtn
            // 
            this.femaleRadioBtn.AutoSize = true;
            this.femaleRadioBtn.Location = new System.Drawing.Point(346, 233);
            this.femaleRadioBtn.Name = "femaleRadioBtn";
            this.femaleRadioBtn.Size = new System.Drawing.Size(61, 15);
            this.femaleRadioBtn.TabIndex = 28;
            this.femaleRadioBtn.Text = "Female";
            this.femaleRadioBtn.UseSelectable = true;
            // 
            // salaryText
            // 
            // 
            // 
            // 
            this.salaryText.CustomButton.Image = null;
            this.salaryText.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.salaryText.CustomButton.Name = "";
            this.salaryText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.salaryText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.salaryText.CustomButton.TabIndex = 1;
            this.salaryText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salaryText.CustomButton.UseSelectable = true;
            this.salaryText.CustomButton.Visible = false;
            this.salaryText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.salaryText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.salaryText.Lines = new string[0];
            this.salaryText.Location = new System.Drawing.Point(252, 258);
            this.salaryText.MaxLength = 32767;
            this.salaryText.Name = "salaryText";
            this.salaryText.PasswordChar = '\0';
            this.salaryText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.salaryText.SelectedText = "";
            this.salaryText.SelectionLength = 0;
            this.salaryText.SelectionStart = 0;
            this.salaryText.ShortcutsEnabled = true;
            this.salaryText.Size = new System.Drawing.Size(186, 23);
            this.salaryText.TabIndex = 30;
            this.salaryText.UseSelectable = true;
            this.salaryText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.salaryText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.salaryLabel.Location = new System.Drawing.Point(149, 257);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(52, 19);
            this.salaryLabel.TabIndex = 29;
            this.salaryLabel.Text = "Salary";
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "userid";
            this.useridDataGridViewTextBoxColumn.HeaderText = "userid";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // joiningDateDataGridViewTextBoxColumn
            // 
            this.joiningDateDataGridViewTextBoxColumn.DataPropertyName = "joiningDate";
            this.joiningDateDataGridViewTextBoxColumn.HeaderText = "joiningDate";
            this.joiningDateDataGridViewTextBoxColumn.Name = "joiningDateDataGridViewTextBoxColumn";
            this.joiningDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(484, 258);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(108, 23);
            this.updateBtn.TabIndex = 31;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseSelectable = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 600);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.salaryText);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.femaleRadioBtn);
            this.Controls.Add(this.maleRadioBtn);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.employeeGrid);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.userIdText);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.customerStatusLabel);
            this.Controls.Add(this.cbCustomerStatus);
            this.Name = "ManageEmployee";
            this.Text = "Manage Employee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageEmployee_FormClosed);
            this.Load += new System.EventHandler(this.ManageEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankloansystemDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton deleteBtn;
        private MetroFramework.Controls.MetroButton refreshBtn;
        private MetroFramework.Controls.MetroTextBox searchText;
        private MetroFramework.Controls.MetroButton backBtn;
        private MetroFramework.Controls.MetroTextBox userIdText;
        private MetroFramework.Controls.MetroLabel userIdLabel;
        private MetroFramework.Controls.MetroButton okBtn;
        private MetroFramework.Controls.MetroLabel customerStatusLabel;
        private MetroFramework.Controls.MetroComboBox cbCustomerStatus;
        private System.Windows.Forms.DataGridView employeeGrid;
        private System.Windows.Forms.BindingSource bankloansystemDataSetBindingSource;
        private Bank_loan_systemDataSet bank_loan_systemDataSet;
        private Bank_loan_systemDataSet2 bank_loan_systemDataSet2;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Bank_loan_systemDataSet2TableAdapters.employeeTableAdapter employeeTableAdapter;
        private MetroFramework.Controls.MetroTextBox nameText;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroTextBox emailText;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroTextBox passwordText;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroLabel genderLabel;
        private MetroFramework.Controls.MetroRadioButton maleRadioBtn;
        private MetroFramework.Controls.MetroRadioButton femaleRadioBtn;
        private MetroFramework.Controls.MetroTextBox salaryText;
        private MetroFramework.Controls.MetroLabel salaryLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton updateBtn;
    }
}