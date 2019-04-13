namespace ADMS
{
    partial class logIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logIn));
            this.userID = new MetroFramework.Controls.MetroLabel();
            this.password = new MetroFramework.Controls.MetroLabel();
            this.userIdBox = new MetroFramework.Controls.MetroTextBox();
            this.passBox = new MetroFramework.Controls.MetroTextBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxPass = new System.Windows.Forms.PictureBox();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.signUpButton = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.portalModarator = new MetroFramework.Controls.MetroCheckBox();
            this.employee = new MetroFramework.Controls.MetroCheckBox();
            this.jobSeeker = new MetroFramework.Controls.MetroCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).BeginInit();
            this.SuspendLayout();
            // 
            // userID
            // 
            this.userID.AutoSize = true;
            this.userID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.userID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.userID.Location = new System.Drawing.Point(311, 268);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(70, 25);
            this.userID.Style = MetroFramework.MetroColorStyle.Blue;
            this.userID.TabIndex = 0;
            this.userID.Text = "User ID";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.password.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.password.Location = new System.Drawing.Point(311, 329);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(87, 25);
            this.password.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // userIdBox
            // 
            // 
            // 
            // 
            this.userIdBox.CustomButton.Image = null;
            this.userIdBox.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.userIdBox.CustomButton.Name = "";
            this.userIdBox.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.userIdBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userIdBox.CustomButton.TabIndex = 1;
            this.userIdBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userIdBox.CustomButton.UseSelectable = true;
            this.userIdBox.CustomButton.Visible = false;
            this.userIdBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.userIdBox.Lines = new string[0];
            this.userIdBox.Location = new System.Drawing.Point(421, 261);
            this.userIdBox.MaxLength = 32767;
            this.userIdBox.Name = "userIdBox";
            this.userIdBox.PasswordChar = '\0';
            this.userIdBox.PromptText = "Enter User Id";
            this.userIdBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userIdBox.SelectedText = "";
            this.userIdBox.SelectionLength = 0;
            this.userIdBox.SelectionStart = 0;
            this.userIdBox.ShortcutsEnabled = true;
            this.userIdBox.Size = new System.Drawing.Size(194, 43);
            this.userIdBox.TabIndex = 2;
            this.userIdBox.UseSelectable = true;
            this.userIdBox.WaterMark = "Enter User Id";
            this.userIdBox.WaterMarkColor = System.Drawing.SystemColors.Highlight;
            this.userIdBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passBox
            // 
            // 
            // 
            // 
            this.passBox.CustomButton.Image = null;
            this.passBox.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.passBox.CustomButton.Name = "";
            this.passBox.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.passBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passBox.CustomButton.TabIndex = 1;
            this.passBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passBox.CustomButton.UseSelectable = true;
            this.passBox.CustomButton.Visible = false;
            this.passBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.passBox.Lines = new string[0];
            this.passBox.Location = new System.Drawing.Point(422, 329);
            this.passBox.MaxLength = 32767;
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '\0';
            this.passBox.PromptText = "Enter Password";
            this.passBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passBox.SelectedText = "";
            this.passBox.SelectionLength = 0;
            this.passBox.SelectionStart = 0;
            this.passBox.ShortcutsEnabled = true;
            this.passBox.Size = new System.Drawing.Size(193, 42);
            this.passBox.TabIndex = 3;
            this.passBox.UseSelectable = true;
            this.passBox.WaterMark = "Enter Password";
            this.passBox.WaterMarkColor = System.Drawing.SystemColors.Highlight;
            this.passBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(257, 259);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(48, 45);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 4;
            this.pictureBoxUser.TabStop = false;
            // 
            // pictureBoxPass
            // 
            this.pictureBoxPass.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPass.Image")));
            this.pictureBoxPass.Location = new System.Drawing.Point(257, 318);
            this.pictureBoxPass.Name = "pictureBoxPass";
            this.pictureBoxPass.Size = new System.Drawing.Size(48, 49);
            this.pictureBoxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPass.TabIndex = 5;
            this.pictureBoxPass.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.loginButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.loginButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.loginButton.Location = new System.Drawing.Point(520, 426);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(95, 37);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Log In";
            this.loginButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginButton.UseCustomBackColor = true;
            this.loginButton.UseCustomForeColor = true;
            this.loginButton.UseSelectable = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(253, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Don\'t have an account yet?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.signUpButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.signUpButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.signUpButton.Location = new System.Drawing.Point(257, 528);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(91, 37);
            this.signUpButton.TabIndex = 8;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.signUpButton.UseCustomBackColor = true;
            this.signUpButton.UseCustomForeColor = true;
            this.signUpButton.UseSelectable = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Log in as";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // portalModarator
            // 
            this.portalModarator.AutoSize = true;
            this.portalModarator.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.portalModarator.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.portalModarator.Location = new System.Drawing.Point(361, 386);
            this.portalModarator.Name = "portalModarator";
            this.portalModarator.Size = new System.Drawing.Size(163, 25);
            this.portalModarator.TabIndex = 10;
            this.portalModarator.Text = "Portal Moderator";
            this.portalModarator.UseCustomBackColor = true;
            this.portalModarator.UseCustomForeColor = true;
            this.portalModarator.UseSelectable = true;
            this.portalModarator.UseStyleColors = true;
            this.portalModarator.CheckedChanged += new System.EventHandler(this.portalModarator_CheckedChanged);
            // 
            // employee
            // 
            this.employee.AutoSize = true;
            this.employee.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.employee.ForeColor = System.Drawing.Color.SkyBlue;
            this.employee.Location = new System.Drawing.Point(530, 385);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(103, 25);
            this.employee.TabIndex = 11;
            this.employee.Text = "Employer";
            this.employee.UseCustomBackColor = true;
            this.employee.UseCustomForeColor = true;
            this.employee.UseSelectable = true;
            // 
            // jobSeeker
            // 
            this.jobSeeker.AutoSize = true;
            this.jobSeeker.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.jobSeeker.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.jobSeeker.Location = new System.Drawing.Point(639, 386);
            this.jobSeeker.Name = "jobSeeker";
            this.jobSeeker.Size = new System.Drawing.Size(113, 25);
            this.jobSeeker.TabIndex = 12;
            this.jobSeeker.Text = "Job Seeker";
            this.jobSeeker.UseCustomBackColor = true;
            this.jobSeeker.UseCustomForeColor = true;
            this.jobSeeker.UseSelectable = true;
            this.jobSeeker.CheckedChanged += new System.EventHandler(this.jobSeeker_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(253, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Note: Select One";
            // 
            // logIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(900, 788);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jobSeeker);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.portalModarator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pictureBoxPass);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userIdBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userID);
            this.Name = "logIn";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel userID;
        private MetroFramework.Controls.MetroLabel password;
        private MetroFramework.Controls.MetroTextBox userIdBox;
        private MetroFramework.Controls.MetroTextBox passBox;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.PictureBox pictureBoxPass;
        private MetroFramework.Controls.MetroButton loginButton;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton signUpButton;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroCheckBox portalModarator;
        private MetroFramework.Controls.MetroCheckBox employee;
        private MetroFramework.Controls.MetroCheckBox jobSeeker;
        private System.Windows.Forms.Label label3;
    }
}

