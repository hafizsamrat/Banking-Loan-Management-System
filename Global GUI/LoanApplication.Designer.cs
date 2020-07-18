namespace Global_GUI
{
    partial class LoanApplication
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
            this.loanTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.loanTypeText = new MetroFramework.Controls.MetroTextBox();
            this.interestRateText = new MetroFramework.Controls.MetroTextBox();
            this.interestRateLabel = new MetroFramework.Controls.MetroLabel();
            this.perLabel = new MetroFramework.Controls.MetroLabel();
            this.backBtn = new MetroFramework.Controls.MetroButton();
            this.totalCostOfLoanText = new MetroFramework.Controls.MetroTextBox();
            this.totalCostOfLoanLabel = new MetroFramework.Controls.MetroLabel();
            this.interestText = new MetroFramework.Controls.MetroTextBox();
            this.interestLabel = new MetroFramework.Controls.MetroLabel();
            this.noOfPaymentsText = new MetroFramework.Controls.MetroTextBox();
            this.noOfPaymentmentLabel = new MetroFramework.Controls.MetroLabel();
            this.monthlyPaymentText = new MetroFramework.Controls.MetroTextBox();
            this.monthlyPaymentLabel = new MetroFramework.Controls.MetroLabel();
            this.loanAmountText = new MetroFramework.Controls.MetroTextBox();
            this.loanAmountLabel = new MetroFramework.Controls.MetroLabel();
            this.monthlyLabel = new MetroFramework.Controls.MetroLabel();
            this.okBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // loanTypeLabel
            // 
            this.loanTypeLabel.AutoSize = true;
            this.loanTypeLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.loanTypeLabel.Location = new System.Drawing.Point(110, 86);
            this.loanTypeLabel.Name = "loanTypeLabel";
            this.loanTypeLabel.Size = new System.Drawing.Size(77, 19);
            this.loanTypeLabel.TabIndex = 0;
            this.loanTypeLabel.Text = "Loan Type";
            // 
            // loanTypeText
            // 
            // 
            // 
            // 
            this.loanTypeText.CustomButton.Image = null;
            this.loanTypeText.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.loanTypeText.CustomButton.Name = "";
            this.loanTypeText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.loanTypeText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loanTypeText.CustomButton.TabIndex = 1;
            this.loanTypeText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loanTypeText.CustomButton.UseSelectable = true;
            this.loanTypeText.CustomButton.Visible = false;
            this.loanTypeText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.loanTypeText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.loanTypeText.Lines = new string[0];
            this.loanTypeText.Location = new System.Drawing.Point(213, 82);
            this.loanTypeText.MaxLength = 32767;
            this.loanTypeText.Name = "loanTypeText";
            this.loanTypeText.PasswordChar = '\0';
            this.loanTypeText.PromptText = "Select A Type";
            this.loanTypeText.ReadOnly = true;
            this.loanTypeText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loanTypeText.SelectedText = "";
            this.loanTypeText.SelectionLength = 0;
            this.loanTypeText.SelectionStart = 0;
            this.loanTypeText.ShortcutsEnabled = true;
            this.loanTypeText.Size = new System.Drawing.Size(186, 23);
            this.loanTypeText.TabIndex = 1;
            this.loanTypeText.UseSelectable = true;
            this.loanTypeText.WaterMark = "Select A Type";
            this.loanTypeText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loanTypeText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.loanTypeText.Click += new System.EventHandler(this.loanTypeText_Click);
            // 
            // interestRateText
            // 
            // 
            // 
            // 
            this.interestRateText.CustomButton.Image = null;
            this.interestRateText.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.interestRateText.CustomButton.Name = "";
            this.interestRateText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.interestRateText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.interestRateText.CustomButton.TabIndex = 1;
            this.interestRateText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.interestRateText.CustomButton.UseSelectable = true;
            this.interestRateText.CustomButton.Visible = false;
            this.interestRateText.Enabled = false;
            this.interestRateText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.interestRateText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.interestRateText.Lines = new string[0];
            this.interestRateText.Location = new System.Drawing.Point(263, 123);
            this.interestRateText.MaxLength = 32767;
            this.interestRateText.Name = "interestRateText";
            this.interestRateText.PasswordChar = '\0';
            this.interestRateText.ReadOnly = true;
            this.interestRateText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.interestRateText.SelectedText = "";
            this.interestRateText.SelectionLength = 0;
            this.interestRateText.SelectionStart = 0;
            this.interestRateText.ShortcutsEnabled = true;
            this.interestRateText.Size = new System.Drawing.Size(94, 23);
            this.interestRateText.TabIndex = 3;
            this.interestRateText.UseSelectable = true;
            this.interestRateText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.interestRateText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.interestRateLabel.Location = new System.Drawing.Point(110, 127);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(129, 19);
            this.interestRateLabel.TabIndex = 2;
            this.interestRateLabel.Text = "Interest Rate/Year";
            // 
            // perLabel
            // 
            this.perLabel.AutoSize = true;
            this.perLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.perLabel.Location = new System.Drawing.Point(378, 127);
            this.perLabel.Name = "perLabel";
            this.perLabel.Size = new System.Drawing.Size(21, 19);
            this.perLabel.TabIndex = 4;
            this.perLabel.Text = "%";
            // 
            // backBtn
            // 
            this.backBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.backBtn.Location = new System.Drawing.Point(526, 31);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseSelectable = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // totalCostOfLoanText
            // 
            // 
            // 
            // 
            this.totalCostOfLoanText.CustomButton.Image = null;
            this.totalCostOfLoanText.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.totalCostOfLoanText.CustomButton.Name = "";
            this.totalCostOfLoanText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.totalCostOfLoanText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalCostOfLoanText.CustomButton.TabIndex = 1;
            this.totalCostOfLoanText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalCostOfLoanText.CustomButton.UseSelectable = true;
            this.totalCostOfLoanText.CustomButton.Visible = false;
            this.totalCostOfLoanText.Enabled = false;
            this.totalCostOfLoanText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.totalCostOfLoanText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.totalCostOfLoanText.Lines = new string[0];
            this.totalCostOfLoanText.Location = new System.Drawing.Point(263, 312);
            this.totalCostOfLoanText.MaxLength = 32767;
            this.totalCostOfLoanText.Name = "totalCostOfLoanText";
            this.totalCostOfLoanText.PasswordChar = '\0';
            this.totalCostOfLoanText.ReadOnly = true;
            this.totalCostOfLoanText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalCostOfLoanText.SelectedText = "";
            this.totalCostOfLoanText.SelectionLength = 0;
            this.totalCostOfLoanText.SelectionStart = 0;
            this.totalCostOfLoanText.ShortcutsEnabled = true;
            this.totalCostOfLoanText.Size = new System.Drawing.Size(136, 23);
            this.totalCostOfLoanText.TabIndex = 7;
            this.totalCostOfLoanText.UseSelectable = true;
            this.totalCostOfLoanText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalCostOfLoanText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // totalCostOfLoanLabel
            // 
            this.totalCostOfLoanLabel.AutoSize = true;
            this.totalCostOfLoanLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.totalCostOfLoanLabel.Location = new System.Drawing.Point(110, 316);
            this.totalCostOfLoanLabel.Name = "totalCostOfLoanLabel";
            this.totalCostOfLoanLabel.Size = new System.Drawing.Size(129, 19);
            this.totalCostOfLoanLabel.TabIndex = 6;
            this.totalCostOfLoanLabel.Text = "Total Cost of Loan";
            // 
            // interestText
            // 
            // 
            // 
            // 
            this.interestText.CustomButton.Image = null;
            this.interestText.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.interestText.CustomButton.Name = "";
            this.interestText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.interestText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.interestText.CustomButton.TabIndex = 1;
            this.interestText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.interestText.CustomButton.UseSelectable = true;
            this.interestText.CustomButton.Visible = false;
            this.interestText.Enabled = false;
            this.interestText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.interestText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.interestText.Lines = new string[0];
            this.interestText.Location = new System.Drawing.Point(263, 276);
            this.interestText.MaxLength = 32767;
            this.interestText.Name = "interestText";
            this.interestText.PasswordChar = '\0';
            this.interestText.ReadOnly = true;
            this.interestText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.interestText.SelectedText = "";
            this.interestText.SelectionLength = 0;
            this.interestText.SelectionStart = 0;
            this.interestText.ShortcutsEnabled = true;
            this.interestText.Size = new System.Drawing.Size(136, 23);
            this.interestText.TabIndex = 9;
            this.interestText.UseSelectable = true;
            this.interestText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.interestText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.interestLabel.Location = new System.Drawing.Point(110, 280);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(96, 19);
            this.interestLabel.TabIndex = 8;
            this.interestLabel.Text = "Total Interest";
            // 
            // noOfPaymentsText
            // 
            // 
            // 
            // 
            this.noOfPaymentsText.CustomButton.Image = null;
            this.noOfPaymentsText.CustomButton.Location = new System.Drawing.Point(55, 1);
            this.noOfPaymentsText.CustomButton.Name = "";
            this.noOfPaymentsText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.noOfPaymentsText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.noOfPaymentsText.CustomButton.TabIndex = 1;
            this.noOfPaymentsText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.noOfPaymentsText.CustomButton.UseSelectable = true;
            this.noOfPaymentsText.CustomButton.Visible = false;
            this.noOfPaymentsText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.noOfPaymentsText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.noOfPaymentsText.Lines = new string[0];
            this.noOfPaymentsText.Location = new System.Drawing.Point(263, 209);
            this.noOfPaymentsText.MaxLength = 32767;
            this.noOfPaymentsText.Name = "noOfPaymentsText";
            this.noOfPaymentsText.PasswordChar = '\0';
            this.noOfPaymentsText.PromptText = "max 144";
            this.noOfPaymentsText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.noOfPaymentsText.SelectedText = "";
            this.noOfPaymentsText.SelectionLength = 0;
            this.noOfPaymentsText.SelectionStart = 0;
            this.noOfPaymentsText.ShortcutsEnabled = true;
            this.noOfPaymentsText.Size = new System.Drawing.Size(77, 23);
            this.noOfPaymentsText.TabIndex = 11;
            this.noOfPaymentsText.UseSelectable = true;
            this.noOfPaymentsText.WaterMark = "max 144";
            this.noOfPaymentsText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.noOfPaymentsText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.noOfPaymentsText.TextChanged += new System.EventHandler(this.noOfInstallmentText_TextChanged);
            // 
            // noOfPaymentmentLabel
            // 
            this.noOfPaymentmentLabel.AutoSize = true;
            this.noOfPaymentmentLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.noOfPaymentmentLabel.Location = new System.Drawing.Point(110, 213);
            this.noOfPaymentmentLabel.Name = "noOfPaymentmentLabel";
            this.noOfPaymentmentLabel.Size = new System.Drawing.Size(116, 19);
            this.noOfPaymentmentLabel.TabIndex = 10;
            this.noOfPaymentmentLabel.Text = "No of Payments";
            // 
            // monthlyPaymentText
            // 
            // 
            // 
            // 
            this.monthlyPaymentText.CustomButton.Image = null;
            this.monthlyPaymentText.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.monthlyPaymentText.CustomButton.Name = "";
            this.monthlyPaymentText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.monthlyPaymentText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.monthlyPaymentText.CustomButton.TabIndex = 1;
            this.monthlyPaymentText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.monthlyPaymentText.CustomButton.UseSelectable = true;
            this.monthlyPaymentText.CustomButton.Visible = false;
            this.monthlyPaymentText.Enabled = false;
            this.monthlyPaymentText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.monthlyPaymentText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.monthlyPaymentText.Lines = new string[0];
            this.monthlyPaymentText.Location = new System.Drawing.Point(263, 241);
            this.monthlyPaymentText.MaxLength = 32767;
            this.monthlyPaymentText.Name = "monthlyPaymentText";
            this.monthlyPaymentText.PasswordChar = '\0';
            this.monthlyPaymentText.ReadOnly = true;
            this.monthlyPaymentText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.monthlyPaymentText.SelectedText = "";
            this.monthlyPaymentText.SelectionLength = 0;
            this.monthlyPaymentText.SelectionStart = 0;
            this.monthlyPaymentText.ShortcutsEnabled = true;
            this.monthlyPaymentText.Size = new System.Drawing.Size(136, 23);
            this.monthlyPaymentText.TabIndex = 13;
            this.monthlyPaymentText.UseSelectable = true;
            this.monthlyPaymentText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.monthlyPaymentText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // monthlyPaymentLabel
            // 
            this.monthlyPaymentLabel.AutoSize = true;
            this.monthlyPaymentLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.monthlyPaymentLabel.Location = new System.Drawing.Point(110, 245);
            this.monthlyPaymentLabel.Name = "monthlyPaymentLabel";
            this.monthlyPaymentLabel.Size = new System.Drawing.Size(127, 19);
            this.monthlyPaymentLabel.TabIndex = 12;
            this.monthlyPaymentLabel.Text = "Monthly Payment";
            // 
            // loanAmountText
            // 
            // 
            // 
            // 
            this.loanAmountText.CustomButton.Image = null;
            this.loanAmountText.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.loanAmountText.CustomButton.Name = "";
            this.loanAmountText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.loanAmountText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loanAmountText.CustomButton.TabIndex = 1;
            this.loanAmountText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loanAmountText.CustomButton.UseSelectable = true;
            this.loanAmountText.CustomButton.Visible = false;
            this.loanAmountText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.loanAmountText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.loanAmountText.Lines = new string[0];
            this.loanAmountText.Location = new System.Drawing.Point(263, 167);
            this.loanAmountText.MaxLength = 32767;
            this.loanAmountText.Name = "loanAmountText";
            this.loanAmountText.PasswordChar = '\0';
            this.loanAmountText.PromptText = "maximum 10 crore";
            this.loanAmountText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loanAmountText.SelectedText = "";
            this.loanAmountText.SelectionLength = 0;
            this.loanAmountText.SelectionStart = 0;
            this.loanAmountText.ShortcutsEnabled = true;
            this.loanAmountText.Size = new System.Drawing.Size(136, 23);
            this.loanAmountText.TabIndex = 15;
            this.loanAmountText.UseSelectable = true;
            this.loanAmountText.WaterMark = "maximum 10 crore";
            this.loanAmountText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loanAmountText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.loanAmountText.TextChanged += new System.EventHandler(this.loanAmountText_TextChanged);
            // 
            // loanAmountLabel
            // 
            this.loanAmountLabel.AutoSize = true;
            this.loanAmountLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.loanAmountLabel.Location = new System.Drawing.Point(110, 171);
            this.loanAmountLabel.Name = "loanAmountLabel";
            this.loanAmountLabel.Size = new System.Drawing.Size(98, 19);
            this.loanAmountLabel.TabIndex = 14;
            this.loanAmountLabel.Text = "Loan Amount";
            // 
            // monthlyLabel
            // 
            this.monthlyLabel.AutoSize = true;
            this.monthlyLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.monthlyLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.monthlyLabel.Location = new System.Drawing.Point(346, 209);
            this.monthlyLabel.Name = "monthlyLabel";
            this.monthlyLabel.Size = new System.Drawing.Size(53, 15);
            this.monthlyLabel.TabIndex = 16;
            this.monthlyLabel.Text = "monthly";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(398, 378);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 17;
            this.okBtn.Text = "Apply";
            this.okBtn.UseSelectable = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // LoanApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 600);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.monthlyLabel);
            this.Controls.Add(this.loanAmountText);
            this.Controls.Add(this.loanAmountLabel);
            this.Controls.Add(this.monthlyPaymentText);
            this.Controls.Add(this.monthlyPaymentLabel);
            this.Controls.Add(this.noOfPaymentsText);
            this.Controls.Add(this.noOfPaymentmentLabel);
            this.Controls.Add(this.interestText);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.totalCostOfLoanText);
            this.Controls.Add(this.totalCostOfLoanLabel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.perLabel);
            this.Controls.Add(this.interestRateText);
            this.Controls.Add(this.interestRateLabel);
            this.Controls.Add(this.loanTypeText);
            this.Controls.Add(this.loanTypeLabel);
            this.Name = "LoanApplication";
            this.Text = "Loan Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoanApplication_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel loanTypeLabel;
        private MetroFramework.Controls.MetroTextBox loanTypeText;
        private MetroFramework.Controls.MetroTextBox interestRateText;
        private MetroFramework.Controls.MetroLabel interestRateLabel;
        private MetroFramework.Controls.MetroLabel perLabel;
        private MetroFramework.Controls.MetroButton backBtn;
        private MetroFramework.Controls.MetroTextBox totalCostOfLoanText;
        private MetroFramework.Controls.MetroLabel totalCostOfLoanLabel;
        private MetroFramework.Controls.MetroTextBox interestText;
        private MetroFramework.Controls.MetroLabel interestLabel;
        private MetroFramework.Controls.MetroTextBox noOfPaymentsText;
        private MetroFramework.Controls.MetroLabel noOfPaymentmentLabel;
        private MetroFramework.Controls.MetroTextBox monthlyPaymentText;
        private MetroFramework.Controls.MetroLabel monthlyPaymentLabel;
        private MetroFramework.Controls.MetroTextBox loanAmountText;
        private MetroFramework.Controls.MetroLabel loanAmountLabel;
        private MetroFramework.Controls.MetroLabel monthlyLabel;
        private MetroFramework.Controls.MetroButton okBtn;
    }
}