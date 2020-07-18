namespace Global_GUI
{
    partial class MyTransactions
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
            this.backBtn = new MetroFramework.Controls.MetroButton();
            this.balanceLabel = new MetroFramework.Controls.MetroLabel();
            this.recieverLabel = new MetroFramework.Controls.MetroLabel();
            this.amountLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.recieverText = new MetroFramework.Controls.MetroTextBox();
            this.amountText = new MetroFramework.Controls.MetroTextBox();
            this.passwordText = new MetroFramework.Controls.MetroTextBox();
            this.confirmBtn = new MetroFramework.Controls.MetroButton();
            this.cbType = new MetroFramework.Controls.MetroComboBox();
            this.typeBtn = new MetroFramework.Controls.MetroLabel();
            this.transactionGrid = new System.Windows.Forms.DataGridView();
            this.transactionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bank_loan_systemDataSet = new Global_GUI.Bank_loan_systemDataSet();
            this.transactionsTableAdapter = new Global_GUI.Bank_loan_systemDataSetTableAdapters.transactionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.backBtn.Location = new System.Drawing.Point(529, 34);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.UseSelectable = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.balanceLabel.Location = new System.Drawing.Point(253, 73);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(69, 19);
            this.balanceLabel.TabIndex = 5;
            this.balanceLabel.Text = "Balance :";
            // 
            // recieverLabel
            // 
            this.recieverLabel.AutoSize = true;
            this.recieverLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.recieverLabel.Location = new System.Drawing.Point(149, 159);
            this.recieverLabel.Name = "recieverLabel";
            this.recieverLabel.Size = new System.Drawing.Size(84, 19);
            this.recieverLabel.TabIndex = 6;
            this.recieverLabel.Text = "Reciever Id";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.amountLabel.Location = new System.Drawing.Point(149, 188);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(62, 19);
            this.amountLabel.TabIndex = 7;
            this.amountLabel.Text = "Amount";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.passwordLabel.Location = new System.Drawing.Point(149, 220);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 19);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
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
            this.recieverText.Location = new System.Drawing.Point(253, 155);
            this.recieverText.MaxLength = 32767;
            this.recieverText.Name = "recieverText";
            this.recieverText.PasswordChar = '\0';
            this.recieverText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.recieverText.SelectedText = "";
            this.recieverText.SelectionLength = 0;
            this.recieverText.SelectionStart = 0;
            this.recieverText.ShortcutsEnabled = true;
            this.recieverText.Size = new System.Drawing.Size(196, 23);
            this.recieverText.TabIndex = 9;
            this.recieverText.UseSelectable = true;
            this.recieverText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.recieverText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.amountText.Location = new System.Drawing.Point(253, 184);
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
            this.amountText.TabIndex = 10;
            this.amountText.UseSelectable = true;
            this.amountText.WaterMark = "Minimum 10 to Maxmimum 500,000";
            this.amountText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amountText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.passwordText.Location = new System.Drawing.Point(253, 216);
            this.passwordText.MaxLength = 32767;
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '●';
            this.passwordText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordText.SelectedText = "";
            this.passwordText.SelectionLength = 0;
            this.passwordText.SelectionStart = 0;
            this.passwordText.ShortcutsEnabled = true;
            this.passwordText.Size = new System.Drawing.Size(196, 23);
            this.passwordText.TabIndex = 11;
            this.passwordText.UseSelectable = true;
            this.passwordText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // confirmBtn
            // 
            this.confirmBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.confirmBtn.Location = new System.Drawing.Point(481, 159);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 12;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseSelectable = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.ItemHeight = 23;
            this.cbType.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw",
            "Transfer"});
            this.cbType.Location = new System.Drawing.Point(253, 111);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(196, 29);
            this.cbType.TabIndex = 13;
            this.cbType.UseSelectable = true;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // typeBtn
            // 
            this.typeBtn.AutoSize = true;
            this.typeBtn.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.typeBtn.Location = new System.Drawing.Point(149, 121);
            this.typeBtn.Name = "typeBtn";
            this.typeBtn.Size = new System.Drawing.Size(41, 19);
            this.typeBtn.TabIndex = 14;
            this.typeBtn.Text = "Type";
            // 
            // transactionGrid
            // 
            this.transactionGrid.AutoGenerateColumns = false;
            this.transactionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIdDataGridViewTextBoxColumn,
            this.senderDataGridViewTextBoxColumn,
            this.recieverDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.datetimeDataGridViewTextBoxColumn});
            this.transactionGrid.DataSource = this.transactionsBindingSource;
            this.transactionGrid.Location = new System.Drawing.Point(31, 252);
            this.transactionGrid.Name = "transactionGrid";
            this.transactionGrid.RowHeadersWidth = 42;
            this.transactionGrid.Size = new System.Drawing.Size(581, 300);
            this.transactionGrid.TabIndex = 15;
            this.transactionGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transactionGrid_CellContentClick);
            // 
            // transactionIdDataGridViewTextBoxColumn
            // 
            this.transactionIdDataGridViewTextBoxColumn.DataPropertyName = "transactionId";
            this.transactionIdDataGridViewTextBoxColumn.HeaderText = "transactionId";
            this.transactionIdDataGridViewTextBoxColumn.Name = "transactionIdDataGridViewTextBoxColumn";
            this.transactionIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // senderDataGridViewTextBoxColumn
            // 
            this.senderDataGridViewTextBoxColumn.DataPropertyName = "sender";
            this.senderDataGridViewTextBoxColumn.HeaderText = "sender";
            this.senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
            // 
            // recieverDataGridViewTextBoxColumn
            // 
            this.recieverDataGridViewTextBoxColumn.DataPropertyName = "reciever";
            this.recieverDataGridViewTextBoxColumn.HeaderText = "reciever";
            this.recieverDataGridViewTextBoxColumn.Name = "recieverDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "datetime";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "datetime";
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            this.datetimeDataGridViewTextBoxColumn.Width = 170;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "transactions";
            this.transactionsBindingSource.DataSource = this.bank_loan_systemDataSet;
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
            // MyTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 561);
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
            this.Name = "MyTransactions";
            this.Text = "My Transactions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyTransactions_FormClosed);
            this.Load += new System.EventHandler(this.MyTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton backBtn;
        private MetroFramework.Controls.MetroLabel balanceLabel;
        private MetroFramework.Controls.MetroLabel recieverLabel;
        private MetroFramework.Controls.MetroLabel amountLabel;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroTextBox recieverText;
        private MetroFramework.Controls.MetroTextBox amountText;
        private MetroFramework.Controls.MetroTextBox passwordText;
        private MetroFramework.Controls.MetroButton confirmBtn;
        private MetroFramework.Controls.MetroComboBox cbType;
        private MetroFramework.Controls.MetroLabel typeBtn;
        private System.Windows.Forms.DataGridView transactionGrid;
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