namespace Global_GUI
{
    partial class EmployeeTransaction
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
            this.typeBtn = new MetroFramework.Controls.MetroLabel();
            this.cbType = new MetroFramework.Controls.MetroComboBox();
            this.confirmBtn = new MetroFramework.Controls.MetroButton();
            this.passwordText = new MetroFramework.Controls.MetroTextBox();
            this.amountText = new MetroFramework.Controls.MetroTextBox();
            this.recieverText = new MetroFramework.Controls.MetroTextBox();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.amountLabel = new MetroFramework.Controls.MetroLabel();
            this.recieverLabel = new MetroFramework.Controls.MetroLabel();
            this.balanceLabel = new MetroFramework.Controls.MetroLabel();
            this.backBtn = new MetroFramework.Controls.MetroButton();
            this.transactionGrid = new System.Windows.Forms.DataGridView();
            this.transactionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankloansystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bank_loan_systemDataSet = new Global_GUI.Bank_loan_systemDataSet();
            this.transactionsTableAdapter = new Global_GUI.Bank_loan_systemDataSetTableAdapters.transactionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankloansystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // typeBtn
            // 
            this.typeBtn.AutoSize = true;
            this.typeBtn.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.typeBtn.Location = new System.Drawing.Point(152, 123);
            this.typeBtn.Name = "typeBtn";
            this.typeBtn.Size = new System.Drawing.Size(41, 19);
            this.typeBtn.TabIndex = 25;
            this.typeBtn.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.ItemHeight = 23;
            this.cbType.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw",
            "Transfer"});
            this.cbType.Location = new System.Drawing.Point(256, 113);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(196, 29);
            this.cbType.TabIndex = 24;
            this.cbType.UseSelectable = true;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // confirmBtn
            // 
            this.confirmBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.confirmBtn.Location = new System.Drawing.Point(484, 161);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 23;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseSelectable = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // passwordText
            // 
            // 
            // 
            // 
            this.passwordText.CustomButton.Image = null;
            this.passwordText.CustomButton.Location = new System.Drawing.Point(174, 1);
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
            this.passwordText.Location = new System.Drawing.Point(256, 218);
            this.passwordText.MaxLength = 32767;
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '●';
            this.passwordText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordText.SelectedText = "";
            this.passwordText.SelectionLength = 0;
            this.passwordText.SelectionStart = 0;
            this.passwordText.ShortcutsEnabled = true;
            this.passwordText.Size = new System.Drawing.Size(196, 23);
            this.passwordText.TabIndex = 22;
            this.passwordText.UseSelectable = true;
            this.passwordText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // amountText
            // 
            // 
            // 
            // 
            this.amountText.CustomButton.Image = null;
            this.amountText.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.amountText.CustomButton.Name = "";
            this.amountText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.amountText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amountText.CustomButton.TabIndex = 1;
            this.amountText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amountText.CustomButton.UseSelectable = true;
            this.amountText.CustomButton.Visible = false;
            this.amountText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.amountText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.amountText.Lines = new string[0];
            this.amountText.Location = new System.Drawing.Point(256, 186);
            this.amountText.MaxLength = 32767;
            this.amountText.Name = "amountText";
            this.amountText.PasswordChar = '\0';
            this.amountText.PromptText = "Minimum 10 to Maxmimum 500,000";
            this.amountText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amountText.SelectedText = "";
            this.amountText.SelectionLength = 0;
            this.amountText.SelectionStart = 0;
            this.amountText.ShortcutsEnabled = true;
            this.amountText.Size = new System.Drawing.Size(196, 23);
            this.amountText.TabIndex = 21;
            this.amountText.UseSelectable = true;
            this.amountText.WaterMark = "Minimum 10 to Maxmimum 500,000";
            this.amountText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amountText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // recieverText
            // 
            // 
            // 
            // 
            this.recieverText.CustomButton.Image = null;
            this.recieverText.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.recieverText.CustomButton.Name = "";
            this.recieverText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.recieverText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.recieverText.CustomButton.TabIndex = 1;
            this.recieverText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.recieverText.CustomButton.UseSelectable = true;
            this.recieverText.CustomButton.Visible = false;
            this.recieverText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.recieverText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.recieverText.Lines = new string[0];
            this.recieverText.Location = new System.Drawing.Point(256, 157);
            this.recieverText.MaxLength = 32767;
            this.recieverText.Name = "recieverText";
            this.recieverText.PasswordChar = '\0';
            this.recieverText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.recieverText.SelectedText = "";
            this.recieverText.SelectionLength = 0;
            this.recieverText.SelectionStart = 0;
            this.recieverText.ShortcutsEnabled = true;
            this.recieverText.Size = new System.Drawing.Size(196, 23);
            this.recieverText.TabIndex = 20;
            this.recieverText.UseSelectable = true;
            this.recieverText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.recieverText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.passwordLabel.Location = new System.Drawing.Point(152, 222);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 19);
            this.passwordLabel.TabIndex = 19;
            this.passwordLabel.Text = "Password";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.amountLabel.Location = new System.Drawing.Point(152, 190);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(62, 19);
            this.amountLabel.TabIndex = 18;
            this.amountLabel.Text = "Amount";
            // 
            // recieverLabel
            // 
            this.recieverLabel.AutoSize = true;
            this.recieverLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.recieverLabel.Location = new System.Drawing.Point(152, 161);
            this.recieverLabel.Name = "recieverLabel";
            this.recieverLabel.Size = new System.Drawing.Size(84, 19);
            this.recieverLabel.TabIndex = 17;
            this.recieverLabel.Text = "Reciever Id";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.balanceLabel.Location = new System.Drawing.Point(256, 75);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(69, 19);
            this.balanceLabel.TabIndex = 16;
            this.balanceLabel.Text = "Balance :";
            // 
            // backBtn
            // 
            this.backBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.backBtn.Location = new System.Drawing.Point(562, 29);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "Back";
            this.backBtn.UseSelectable = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // transactionGrid
            // 
            this.transactionGrid.AllowUserToAddRows = false;
            this.transactionGrid.AllowUserToDeleteRows = false;
            this.transactionGrid.AutoGenerateColumns = false;
            this.transactionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIdDataGridViewTextBoxColumn,
            this.senderDataGridViewTextBoxColumn,
            this.recieverDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.datetimeDataGridViewTextBoxColumn});
            this.transactionGrid.DataSource = this.transactionsBindingSource;
            this.transactionGrid.Location = new System.Drawing.Point(43, 266);
            this.transactionGrid.Name = "transactionGrid";
            this.transactionGrid.ReadOnly = true;
            this.transactionGrid.RowHeadersWidth = 42;
            this.transactionGrid.Size = new System.Drawing.Size(574, 300);
            this.transactionGrid.TabIndex = 26;
            this.transactionGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transactionGrid_CellContentClick);
            // 
            // transactionIdDataGridViewTextBoxColumn
            // 
            this.transactionIdDataGridViewTextBoxColumn.DataPropertyName = "transactionId";
            this.transactionIdDataGridViewTextBoxColumn.HeaderText = "transactionId";
            this.transactionIdDataGridViewTextBoxColumn.Name = "transactionIdDataGridViewTextBoxColumn";
            this.transactionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // senderDataGridViewTextBoxColumn
            // 
            this.senderDataGridViewTextBoxColumn.DataPropertyName = "sender";
            this.senderDataGridViewTextBoxColumn.HeaderText = "sender";
            this.senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
            this.senderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recieverDataGridViewTextBoxColumn
            // 
            this.recieverDataGridViewTextBoxColumn.DataPropertyName = "reciever";
            this.recieverDataGridViewTextBoxColumn.HeaderText = "reciever";
            this.recieverDataGridViewTextBoxColumn.Name = "recieverDataGridViewTextBoxColumn";
            this.recieverDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 80;
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "datetime";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "datetime";
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            this.datetimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.datetimeDataGridViewTextBoxColumn.Width = 170;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "transactions";
            this.transactionsBindingSource.DataSource = this.bankloansystemDataSetBindingSource;
            // 
            // bankloansystemDataSetBindingSource
            // 
            this.bankloansystemDataSetBindingSource.DataSource = this.bank_loan_systemDataSet;
            this.bankloansystemDataSetBindingSource.Position = 0;
            // 
            // bank_loan_systemDataSet
            // 
            this.bank_loan_systemDataSet.DataSetName = "Bank_loan_systemDataSet";
            this.bank_loan_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 600);
            this.Controls.Add(this.transactionGrid);
            this.Controls.Add(this.typeBtn);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.amountText);
            this.Controls.Add(this.recieverText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.recieverLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.backBtn);
            this.Name = "EmployeeTransaction";
            this.Text = "My Transactions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeTransaction_FormClosed);
            this.Load += new System.EventHandler(this.EmployeeTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankloansystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel typeBtn;
        private MetroFramework.Controls.MetroComboBox cbType;
        private MetroFramework.Controls.MetroButton confirmBtn;
        private MetroFramework.Controls.MetroTextBox passwordText;
        private MetroFramework.Controls.MetroTextBox amountText;
        private MetroFramework.Controls.MetroTextBox recieverText;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroLabel amountLabel;
        private MetroFramework.Controls.MetroLabel recieverLabel;
        private MetroFramework.Controls.MetroLabel balanceLabel;
        private MetroFramework.Controls.MetroButton backBtn;
        private System.Windows.Forms.DataGridView transactionGrid;
        private System.Windows.Forms.BindingSource bankloansystemDataSetBindingSource;
        private Bank_loan_systemDataSet bank_loan_systemDataSet;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private Bank_loan_systemDataSetTableAdapters.transactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
    }
}