namespace Global_GUI
{
    partial class ChooseLoan
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
            this.loanGrid = new MetroFramework.Controls.MetroGrid();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bank_loan_systemDataSet5 = new Global_GUI.Bank_loan_systemDataSet5();
            this.loanTableAdapter = new Global_GUI.Bank_loan_systemDataSet5TableAdapters.loanTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.customerToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.customerToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestRatePerYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.loanGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet5)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // loanGrid
            // 
            this.loanGrid.AllowUserToAddRows = false;
            this.loanGrid.AllowUserToDeleteRows = false;
            this.loanGrid.AllowUserToResizeRows = false;
            this.loanGrid.AutoGenerateColumns = false;
            this.loanGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loanGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loanGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.loanGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loanGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.loanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.interestRatePerYearDataGridViewTextBoxColumn,
            this.loanId});
            this.loanGrid.DataSource = this.loanBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.loanGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.loanGrid.EnableHeadersVisualStyles = false;
            this.loanGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loanGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loanGrid.Location = new System.Drawing.Point(11, 104);
            this.loanGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loanGrid.Name = "loanGrid";
            this.loanGrid.ReadOnly = true;
            this.loanGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loanGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.loanGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.loanGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loanGrid.Size = new System.Drawing.Size(240, 232);
            this.loanGrid.TabIndex = 0;
            this.loanGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loanGrid_CellDoubleClick);
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataMember = "loan";
            this.loanBindingSource.DataSource = this.bank_loan_systemDataSet5;
            // 
            // bank_loan_systemDataSet5
            // 
            this.bank_loan_systemDataSet5.DataSetName = "Bank_loan_systemDataSet5";
            this.bank_loan_systemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loanTableAdapter
            // 
            this.loanTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripLabel,
            this.customerToolStripTextBox});
            this.fillByToolStrip.Location = new System.Drawing.Point(11, 60);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.fillByToolStrip.Size = new System.Drawing.Size(200, 25);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // customerToolStripTextBox
            // 
            this.customerToolStripTextBox.Name = "customerToolStripTextBox";
            this.customerToolStripTextBox.Size = new System.Drawing.Size(150, 25);
            this.customerToolStripTextBox.TextChanged += new System.EventHandler(this.customerToolStripTextBox_TextChanged);
            // 
            // customerToolStripLabel
            // 
            this.customerToolStripLabel.Name = "customerToolStripLabel";
            this.customerToolStripLabel.Size = new System.Drawing.Size(45, 22);
            this.customerToolStripLabel.Text = "Search:";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Loan Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interestRatePerYearDataGridViewTextBoxColumn
            // 
            this.interestRatePerYearDataGridViewTextBoxColumn.DataPropertyName = "interestRatePerYear";
            this.interestRatePerYearDataGridViewTextBoxColumn.HeaderText = "Interest Rate/Year";
            this.interestRatePerYearDataGridViewTextBoxColumn.Name = "interestRatePerYearDataGridViewTextBoxColumn";
            this.interestRatePerYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loanId
            // 
            this.loanId.DataPropertyName = "loanId";
            this.loanId.HeaderText = "loanId";
            this.loanId.Name = "loanId";
            this.loanId.ReadOnly = true;
            this.loanId.Visible = false;
            // 
            // ChooseLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 345);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.loanGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChooseLoan";
            this.Text = "Choose Loan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseLoan_FormClosing);
            this.Load += new System.EventHandler(this.ChooseLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loanGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_loan_systemDataSet5)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bank_loan_systemDataSet5 bank_loan_systemDataSet5;
        private MetroFramework.Controls.MetroGrid loanGrid;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private Bank_loan_systemDataSet5TableAdapters.loanTableAdapter loanTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripTextBox customerToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel customerToolStripLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestRatePerYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanId;
    }
}