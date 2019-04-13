namespace ADMS
{
    partial class recoveryPass
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
            this.empRecovery = new System.Windows.Forms.Panel();
            this.showPass = new MetroFramework.Controls.MetroLabel();
            this.showPassButton = new MetroFramework.Controls.MetroButton();
            this.empID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.jsshowpass = new MetroFramework.Controls.MetroLabel();
            this.showPassJS = new MetroFramework.Controls.MetroButton();
            this.jsID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.backbutton = new MetroFramework.Controls.MetroButton();
            this.empRecovery.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // empRecovery
            // 
            this.empRecovery.Controls.Add(this.metroLabel2);
            this.empRecovery.Controls.Add(this.showPass);
            this.empRecovery.Controls.Add(this.showPassButton);
            this.empRecovery.Controls.Add(this.empID);
            this.empRecovery.Controls.Add(this.metroLabel1);
            this.empRecovery.Location = new System.Drawing.Point(23, 75);
            this.empRecovery.Name = "empRecovery";
            this.empRecovery.Size = new System.Drawing.Size(562, 227);
            this.empRecovery.TabIndex = 27;
            // 
            // showPass
            // 
            this.showPass.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.showPass.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.showPass.Location = new System.Drawing.Point(286, 132);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(268, 37);
            this.showPass.TabIndex = 30;
            this.showPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showPass.Click += new System.EventHandler(this.showPass_Click);
            // 
            // showPassButton
            // 
            this.showPassButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.showPassButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.showPassButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.showPassButton.ForeColor = System.Drawing.Color.Black;
            this.showPassButton.Location = new System.Drawing.Point(60, 132);
            this.showPassButton.Name = "showPassButton";
            this.showPassButton.Size = new System.Drawing.Size(129, 37);
            this.showPassButton.TabIndex = 29;
            this.showPassButton.Text = "Show Password";
            this.showPassButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.showPassButton.UseCustomBackColor = true;
            this.showPassButton.UseCustomForeColor = true;
            this.showPassButton.UseSelectable = true;
            this.showPassButton.Click += new System.EventHandler(this.showPassButton_Click);
            // 
            // empID
            // 
            // 
            // 
            // 
            this.empID.CustomButton.Image = null;
            this.empID.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.empID.CustomButton.Name = "";
            this.empID.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.empID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.empID.CustomButton.TabIndex = 1;
            this.empID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.empID.CustomButton.UseSelectable = true;
            this.empID.CustomButton.Visible = false;
            this.empID.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.empID.Lines = new string[0];
            this.empID.Location = new System.Drawing.Point(286, 72);
            this.empID.MaxLength = 32767;
            this.empID.Name = "empID";
            this.empID.PasswordChar = '\0';
            this.empID.PromptText = "Enter id";
            this.empID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.empID.SelectedText = "";
            this.empID.SelectionLength = 0;
            this.empID.SelectionStart = 0;
            this.empID.ShortcutsEnabled = true;
            this.empID.Size = new System.Drawing.Size(268, 30);
            this.empID.TabIndex = 28;
            this.empID.UseSelectable = true;
            this.empID.WaterMark = "Enter id";
            this.empID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.empID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(3, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(226, 30);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Enter id ";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(131, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(309, 30);
            this.metroLabel2.TabIndex = 31;
            this.metroLabel2.Text = "Recovery Password for Employers";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.jsshowpass);
            this.panel1.Controls.Add(this.showPassJS);
            this.panel1.Controls.Add(this.jsID);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Location = new System.Drawing.Point(23, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 184);
            this.panel1.TabIndex = 28;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(131, 12);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(333, 30);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "Recovery Password for Job Seekers";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jsshowpass
            // 
            this.jsshowpass.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.jsshowpass.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.jsshowpass.Location = new System.Drawing.Point(286, 132);
            this.jsshowpass.Name = "jsshowpass";
            this.jsshowpass.Size = new System.Drawing.Size(268, 37);
            this.jsshowpass.TabIndex = 30;
            this.jsshowpass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showPassJS
            // 
            this.showPassJS.BackColor = System.Drawing.Color.LightSkyBlue;
            this.showPassJS.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.showPassJS.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.showPassJS.ForeColor = System.Drawing.Color.Black;
            this.showPassJS.Location = new System.Drawing.Point(60, 132);
            this.showPassJS.Name = "showPassJS";
            this.showPassJS.Size = new System.Drawing.Size(129, 37);
            this.showPassJS.TabIndex = 29;
            this.showPassJS.Text = "Show Password";
            this.showPassJS.Theme = MetroFramework.MetroThemeStyle.Light;
            this.showPassJS.UseCustomBackColor = true;
            this.showPassJS.UseCustomForeColor = true;
            this.showPassJS.UseSelectable = true;
            this.showPassJS.Click += new System.EventHandler(this.showPassJS_Click);
            // 
            // jsID
            // 
            // 
            // 
            // 
            this.jsID.CustomButton.Image = null;
            this.jsID.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.jsID.CustomButton.Name = "";
            this.jsID.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.jsID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.jsID.CustomButton.TabIndex = 1;
            this.jsID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.jsID.CustomButton.UseSelectable = true;
            this.jsID.CustomButton.Visible = false;
            this.jsID.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.jsID.Lines = new string[0];
            this.jsID.Location = new System.Drawing.Point(286, 72);
            this.jsID.MaxLength = 32767;
            this.jsID.Name = "jsID";
            this.jsID.PasswordChar = '\0';
            this.jsID.PromptText = "Enter id";
            this.jsID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jsID.SelectedText = "";
            this.jsID.SelectionLength = 0;
            this.jsID.SelectionStart = 0;
            this.jsID.ShortcutsEnabled = true;
            this.jsID.Size = new System.Drawing.Size(268, 30);
            this.jsID.TabIndex = 28;
            this.jsID.UseSelectable = true;
            this.jsID.WaterMark = "Enter id";
            this.jsID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.jsID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(3, 72);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(226, 30);
            this.metroLabel5.TabIndex = 27;
            this.metroLabel5.Text = "Enter id ";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backbutton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.backbutton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.backbutton.ForeColor = System.Drawing.Color.Black;
            this.backbutton.Location = new System.Drawing.Point(23, 531);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(129, 37);
            this.backbutton.TabIndex = 32;
            this.backbutton.Text = "Back";
            this.backbutton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.backbutton.UseCustomBackColor = true;
            this.backbutton.UseCustomForeColor = true;
            this.backbutton.UseSelectable = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // recoveryPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.empRecovery);
            this.Name = "recoveryPass";
            this.Text = "Recovery Password";
            this.Load += new System.EventHandler(this.recoveryPass_Load);
            this.empRecovery.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel empRecovery;
        private MetroFramework.Controls.MetroLabel showPass;
        private MetroFramework.Controls.MetroButton showPassButton;
        private MetroFramework.Controls.MetroTextBox empID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel jsshowpass;
        private MetroFramework.Controls.MetroButton showPassJS;
        private MetroFramework.Controls.MetroTextBox jsID;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton backbutton;
    }
}