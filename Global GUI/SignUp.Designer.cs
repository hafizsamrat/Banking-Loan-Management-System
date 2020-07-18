namespace Global_GUI
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.userIdlabel = new MetroFramework.Controls.MetroLabel();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.emailLabel = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.genderLabel = new MetroFramework.Controls.MetroLabel();
            this.dateOfBirthLabel = new MetroFramework.Controls.MetroLabel();
            this.userIdText = new MetroFramework.Controls.MetroTextBox();
            this.passwordText = new MetroFramework.Controls.MetroTextBox();
            this.emailText = new MetroFramework.Controls.MetroTextBox();
            this.nameText = new MetroFramework.Controls.MetroTextBox();
            this.maleRadioBtn = new MetroFramework.Controls.MetroRadioButton();
            this.femaleRadioBtn = new MetroFramework.Controls.MetroRadioButton();
            this.dateOfBirthText = new MetroFramework.Controls.MetroDateTime();
            this.showPasswordBtn = new MetroFramework.Controls.MetroButton();
            this.signUpBtn = new MetroFramework.Controls.MetroButton();
            this.loginBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userIdlabel
            // 
            this.userIdlabel.AutoSize = true;
            this.userIdlabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.userIdlabel.Location = new System.Drawing.Point(110, 252);
            this.userIdlabel.Name = "userIdlabel";
            this.userIdlabel.Size = new System.Drawing.Size(57, 19);
            this.userIdlabel.TabIndex = 0;
            this.userIdlabel.Text = "User ID";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.passwordLabel.Location = new System.Drawing.Point(110, 337);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 19);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.emailLabel.Location = new System.Drawing.Point(110, 309);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(45, 19);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.nameLabel.Location = new System.Drawing.Point(110, 280);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 19);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.genderLabel.Location = new System.Drawing.Point(110, 373);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(58, 19);
            this.genderLabel.TabIndex = 4;
            this.genderLabel.Text = "Gender";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(110, 402);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(100, 19);
            this.dateOfBirthLabel.TabIndex = 5;
            this.dateOfBirthLabel.Text = "Date Of  Birth";
            // 
            // userIdText
            // 
            // 
            // 
            // 
            this.userIdText.CustomButton.Image = null;
            this.userIdText.CustomButton.Location = new System.Drawing.Point(192, 1);
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
            this.userIdText.Location = new System.Drawing.Point(234, 248);
            this.userIdText.MaxLength = 32767;
            this.userIdText.Name = "userIdText";
            this.userIdText.PasswordChar = '\0';
            this.userIdText.ReadOnly = true;
            this.userIdText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userIdText.SelectedText = "";
            this.userIdText.SelectionLength = 0;
            this.userIdText.SelectionStart = 0;
            this.userIdText.ShortcutsEnabled = true;
            this.userIdText.Size = new System.Drawing.Size(214, 23);
            this.userIdText.TabIndex = 6;
            this.userIdText.TabStop = false;
            this.userIdText.UseSelectable = true;
            this.userIdText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userIdText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordText
            // 
            // 
            // 
            // 
            this.passwordText.CustomButton.Image = null;
            this.passwordText.CustomButton.Location = new System.Drawing.Point(192, 1);
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
            this.passwordText.Location = new System.Drawing.Point(234, 333);
            this.passwordText.MaxLength = 32767;
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '●';
            this.passwordText.PromptText = "at least 4 characters";
            this.passwordText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordText.SelectedText = "";
            this.passwordText.SelectionLength = 0;
            this.passwordText.SelectionStart = 0;
            this.passwordText.ShortcutsEnabled = true;
            this.passwordText.Size = new System.Drawing.Size(214, 23);
            this.passwordText.TabIndex = 7;
            this.passwordText.UseSelectable = true;
            this.passwordText.WaterMark = "at least 4 characters";
            this.passwordText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emailText
            // 
            // 
            // 
            // 
            this.emailText.CustomButton.Image = null;
            this.emailText.CustomButton.Location = new System.Drawing.Point(192, 1);
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
            this.emailText.Location = new System.Drawing.Point(234, 305);
            this.emailText.MaxLength = 32767;
            this.emailText.Name = "emailText";
            this.emailText.PasswordChar = '\0';
            this.emailText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailText.SelectedText = "";
            this.emailText.SelectionLength = 0;
            this.emailText.SelectionStart = 0;
            this.emailText.ShortcutsEnabled = true;
            this.emailText.Size = new System.Drawing.Size(214, 23);
            this.emailText.TabIndex = 8;
            this.emailText.UseSelectable = true;
            this.emailText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nameText
            // 
            // 
            // 
            // 
            this.nameText.CustomButton.Image = null;
            this.nameText.CustomButton.Location = new System.Drawing.Point(192, 1);
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
            this.nameText.Location = new System.Drawing.Point(234, 276);
            this.nameText.MaxLength = 32767;
            this.nameText.Name = "nameText";
            this.nameText.PasswordChar = '\0';
            this.nameText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameText.SelectedText = "";
            this.nameText.SelectionLength = 0;
            this.nameText.SelectionStart = 0;
            this.nameText.ShortcutsEnabled = true;
            this.nameText.Size = new System.Drawing.Size(214, 23);
            this.nameText.TabIndex = 9;
            this.nameText.UseSelectable = true;
            this.nameText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.maleRadioBtn.Location = new System.Drawing.Point(234, 373);
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Size = new System.Drawing.Size(55, 19);
            this.maleRadioBtn.TabIndex = 10;
            this.maleRadioBtn.Text = "Male";
            this.maleRadioBtn.UseSelectable = true;
            // 
            // femaleRadioBtn
            // 
            this.femaleRadioBtn.AutoSize = true;
            this.femaleRadioBtn.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.femaleRadioBtn.Location = new System.Drawing.Point(331, 373);
            this.femaleRadioBtn.Name = "femaleRadioBtn";
            this.femaleRadioBtn.Size = new System.Drawing.Size(68, 19);
            this.femaleRadioBtn.TabIndex = 11;
            this.femaleRadioBtn.Text = "Female";
            this.femaleRadioBtn.UseSelectable = true;
            // 
            // dateOfBirthText
            // 
            this.dateOfBirthText.Location = new System.Drawing.Point(234, 400);
            this.dateOfBirthText.MinimumSize = new System.Drawing.Size(4, 29);
            this.dateOfBirthText.Name = "dateOfBirthText";
            this.dateOfBirthText.Size = new System.Drawing.Size(214, 29);
            this.dateOfBirthText.TabIndex = 12;
            // 
            // showPasswordBtn
            // 
            this.showPasswordBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.showPasswordBtn.Location = new System.Drawing.Point(481, 333);
            this.showPasswordBtn.Name = "showPasswordBtn";
            this.showPasswordBtn.Size = new System.Drawing.Size(128, 23);
            this.showPasswordBtn.TabIndex = 13;
            this.showPasswordBtn.Text = "Show Password";
            this.showPasswordBtn.UseSelectable = true;
            this.showPasswordBtn.Click += new System.EventHandler(this.showPasswordBtn_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.signUpBtn.Location = new System.Drawing.Point(362, 466);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(86, 38);
            this.signUpBtn.TabIndex = 14;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseSelectable = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.loginBtn.Location = new System.Drawing.Point(234, 466);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(79, 38);
            this.loginBtn.TabIndex = 15;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseSelectable = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(251, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.showPasswordBtn);
            this.Controls.Add(this.dateOfBirthText);
            this.Controls.Add(this.femaleRadioBtn);
            this.Controls.Add(this.maleRadioBtn);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userIdText);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userIdlabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUp";
            this.Padding = new System.Windows.Forms.Padding(30, 78, 30, 26);
            this.Text = "Create an account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUp_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel userIdlabel;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel genderLabel;
        private MetroFramework.Controls.MetroLabel dateOfBirthLabel;
        private MetroFramework.Controls.MetroTextBox userIdText;
        private MetroFramework.Controls.MetroTextBox passwordText;
        private MetroFramework.Controls.MetroTextBox emailText;
        private MetroFramework.Controls.MetroTextBox nameText;
        private MetroFramework.Controls.MetroRadioButton maleRadioBtn;
        private MetroFramework.Controls.MetroRadioButton femaleRadioBtn;
        private MetroFramework.Controls.MetroDateTime dateOfBirthText;
        private MetroFramework.Controls.MetroButton showPasswordBtn;
        private MetroFramework.Controls.MetroButton signUpBtn;
        private MetroFramework.Controls.MetroButton loginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}