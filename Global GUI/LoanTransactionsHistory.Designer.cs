namespace Global_GUI
{
    partial class LoanTransactionsHistory
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
            this.loanHistoryGrid = new MetroFramework.Controls.MetroGrid();
            this.loanTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bank_loan_systemDataSet7 = new Global_GUI.Bank_loan_systemDataSet7();
            this.loanTransactionTableAdapter = new Global_GUI.Bank_loan_systemDataSet7TableAdapters.loanTransactionTableAdapter();
            this.backBtn = new MetroFramework.Controls.MetroButton();
            this.searchText = new MetroFramework.Controls.MetroTextBox();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginningBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.principalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.loanHistoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // loanHistoryGrid
            // 
            this.loanHistoryGrid.AllowUserToAddRows = false;
            this.loanHistoryGrid.AllowUserToDeleteRows = false;
            this.loanHistoryGrid.AllowUserToResizeRows = false;
            this.loanHistoryGrid.AutoGenerateColumns = false;
            this.loanHistoryGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loanHistoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loanHistoryGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.loanHistoryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loanHistoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.loanHistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanHistoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.loanNameDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.beginningBalanceDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.principalDataGridViewTextBoxColumn,
            this.interestDataGridViewTextBoxColumn,
            this.endingBalanceDataGridViewTextBoxColumn});
            this.loanHistoryGrid.DataSource = this.loanTransactionBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.loanHistoryGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.loanHistoryGrid.EnableHeadersVisualStyles = false;
            this.loanHistoryGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loanHistoryGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loanHistoryGrid.Location = new System.Drawing.Point(8, 154);
            this.loanHistoryGrid.Name = "loanHistoryGrid";
            this.loanHistoryGrid.ReadOnly = true;
            this.loanHistoryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loanHistoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.loanHistoryGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.loanHistoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loanHistoryGrid.Size = new System.Drawing.Size(641, 289);
            this.loanHistoryGrid.TabIndex = 0;
            // 
            // loanTransactionBindingSource
            // 
            this.loanTransactionBindingSource.DataMember = "loanTransaction";
            this.loanTransactionBindingSource.DataSource = this.bank_loan_systemDataSet7;
            // 
            // bank_loan_systemDataSet7
            // 
            this.bank_loan_systemDataSet7.DataSetName = "Bank_loan_systemDataSet7";
            this.bank_loan_systemDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loanTransactionTableAdapter
            // 
            this.loanTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(543, 43);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(79, 23);
            this.backBtn.TabIndex = 32;
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
            this.searchText.Location = new System.Drawing.Point(92, 108);
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
            this.searchText.TabIndex = 33;
            this.searchText.UseSelectable = true;
            this.searchText.WaterMark = "Search here";
            this.searchText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "userid";
            this.useridDataGridViewTextBoxColumn.HeaderText = "userid";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            this.useridDataGridViewTextBoxColumn.Visible = false;
            this.useridDataGridViewTextBoxColumn.Width = 50;
            // 
            // loanNameDataGridViewTextBoxColumn
            // 
            this.loanNameDataGridViewTextBoxColumn.DataPropertyName = "loanName";
            this.loanNameDataGridViewTextBoxColumn.HeaderText = "Loan Name";
            this.loanNameDataGridViewTextBoxColumn.Name = "loanNameDataGridViewTextBoxColumn";
            this.loanNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.loanNameDataGridViewTextBoxColumn.Width = 90;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "paymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "Payment Date";
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentDateDataGridViewTextBoxColumn.Width = 85;
            // 
            // beginningBalanceDataGridViewTextBoxColumn
            // 
            this.beginningBalanceDataGridViewTextBoxColumn.DataPropertyName = "beginningBalance";
            this.beginningBalanceDataGridViewTextBoxColumn.HeaderText = "Beginning Balance";
            this.beginningBalanceDataGridViewTextBoxColumn.Name = "beginningBalanceDataGridViewTextBoxColumn";
            this.beginningBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.beginningBalanceDataGridViewTextBoxColumn.Width = 85;
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "payment";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            this.paymentDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentDataGridViewTextBoxColumn.Width = 85;
            // 
            // principalDataGridViewTextBoxColumn
            // 
            this.principalDataGridViewTextBoxColumn.DataPropertyName = "principal";
            this.principalDataGridViewTextBoxColumn.HeaderText = "principal";
            this.principalDataGridViewTextBoxColumn.Name = "principalDataGridViewTextBoxColumn";
            this.principalDataGridViewTextBoxColumn.ReadOnly = true;
            this.principalDataGridViewTextBoxColumn.Width = 85;
            // 
            // interestDataGridViewTextBoxColumn
            // 
            this.interestDataGridViewTextBoxColumn.DataPropertyName = "interest";
            this.interestDataGridViewTextBoxColumn.HeaderText = "interest";
            this.interestDataGridViewTextBoxColumn.Name = "interestDataGridViewTextBoxColumn";
            this.interestDataGridViewTextBoxColumn.ReadOnly = true;
            this.interestDataGridViewTextBoxColumn.Width = 85;
            // 
            // endingBalanceDataGridViewTextBoxColumn
            // 
            this.endingBalanceDataGridViewTextBoxColumn.DataPropertyName = "endingBalance";
            this.endingBalanceDataGridViewTextBoxColumn.HeaderText = "Ending Balance";
            this.endingBalanceDataGridViewTextBoxColumn.Name = "endingBalanceDataGridViewTextBoxColumn";
            this.endingBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.endingBalanceDataGridViewTextBoxColumn.Width = 90;
            // 
            // LoanTransactionsHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 600);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.loanHistoryGrid);
            this.Name = "LoanTransactionsHistory";
            this.Text = "My Loan Transactions History";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoanTransactionsHistory_FormClosed);
            this.Load += new System.EventHandler(this.LoanTransactionsHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loanHistoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid loanHistoryGrid;
        private Bank_loan_systemDataSet7 bank_loan_systemDataSet7;
        private System.Windows.Forms.BindingSource loanTransactionBindingSource;
        private Bank_loan_systemDataSet7TableAdapters.loanTransactionTableAdapter loanTransactionTableAdapter;
        private MetroFramework.Controls.MetroButton backBtn;
        private MetroFramework.Controls.MetroTextBox searchText;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginningBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn principalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingBalanceDataGridViewTextBoxColumn;
    }
}