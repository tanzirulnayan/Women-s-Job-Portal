namespace ADMS
{
    partial class verifyJobSeekers
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
            this.approveJS = new MetroFramework.Controls.MetroButton();
            this.validJS = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.deleteJS = new MetroFramework.Controls.MetroButton();
            this.idDeleteJS = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.employers = new System.Windows.Forms.DataGridView();
            this.refreshButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.employers)).BeginInit();
            this.SuspendLayout();
            // 
            // approveJS
            // 
            this.approveJS.BackColor = System.Drawing.Color.LightSkyBlue;
            this.approveJS.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.approveJS.ForeColor = System.Drawing.Color.Black;
            this.approveJS.Location = new System.Drawing.Point(649, 654);
            this.approveJS.Name = "approveJS";
            this.approveJS.Size = new System.Drawing.Size(155, 40);
            this.approveJS.TabIndex = 60;
            this.approveJS.TabStop = false;
            this.approveJS.Text = "Approve User";
            this.approveJS.Theme = MetroFramework.MetroThemeStyle.Light;
            this.approveJS.UseCustomBackColor = true;
            this.approveJS.UseCustomForeColor = true;
            this.approveJS.UseSelectable = true;
            this.approveJS.Click += new System.EventHandler(this.approveJS_Click);
            // 
            // validJS
            // 
            // 
            // 
            // 
            this.validJS.CustomButton.Image = null;
            this.validJS.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.validJS.CustomButton.Name = "";
            this.validJS.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.validJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.validJS.CustomButton.TabIndex = 1;
            this.validJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.validJS.CustomButton.UseSelectable = true;
            this.validJS.CustomButton.Visible = false;
            this.validJS.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.validJS.Lines = new string[0];
            this.validJS.Location = new System.Drawing.Point(536, 618);
            this.validJS.MaxLength = 32767;
            this.validJS.Name = "validJS";
            this.validJS.PasswordChar = '\0';
            this.validJS.PromptText = "Enter id";
            this.validJS.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.validJS.SelectedText = "";
            this.validJS.SelectionLength = 0;
            this.validJS.SelectionStart = 0;
            this.validJS.ShortcutsEnabled = true;
            this.validJS.Size = new System.Drawing.Size(268, 30);
            this.validJS.TabIndex = 59;
            this.validJS.UseSelectable = true;
            this.validJS.WaterMark = "Enter id";
            this.validJS.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.validJS.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(97, 618);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(178, 30);
            this.metroLabel1.TabIndex = 58;
            this.metroLabel1.Text = "Enter id to approve";
            // 
            // deleteJS
            // 
            this.deleteJS.BackColor = System.Drawing.Color.LightSkyBlue;
            this.deleteJS.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.deleteJS.ForeColor = System.Drawing.Color.Black;
            this.deleteJS.Location = new System.Drawing.Point(649, 488);
            this.deleteJS.Name = "deleteJS";
            this.deleteJS.Size = new System.Drawing.Size(155, 40);
            this.deleteJS.TabIndex = 57;
            this.deleteJS.TabStop = false;
            this.deleteJS.Text = "Delete User";
            this.deleteJS.Theme = MetroFramework.MetroThemeStyle.Light;
            this.deleteJS.UseCustomBackColor = true;
            this.deleteJS.UseCustomForeColor = true;
            this.deleteJS.UseSelectable = true;
            this.deleteJS.Click += new System.EventHandler(this.deleteJS_Click);
            // 
            // idDeleteJS
            // 
            // 
            // 
            // 
            this.idDeleteJS.CustomButton.Image = null;
            this.idDeleteJS.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.idDeleteJS.CustomButton.Name = "";
            this.idDeleteJS.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.idDeleteJS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idDeleteJS.CustomButton.TabIndex = 1;
            this.idDeleteJS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idDeleteJS.CustomButton.UseSelectable = true;
            this.idDeleteJS.CustomButton.Visible = false;
            this.idDeleteJS.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.idDeleteJS.Lines = new string[0];
            this.idDeleteJS.Location = new System.Drawing.Point(536, 452);
            this.idDeleteJS.MaxLength = 32767;
            this.idDeleteJS.Name = "idDeleteJS";
            this.idDeleteJS.PasswordChar = '\0';
            this.idDeleteJS.PromptText = "Enter id";
            this.idDeleteJS.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idDeleteJS.SelectedText = "";
            this.idDeleteJS.SelectionLength = 0;
            this.idDeleteJS.SelectionStart = 0;
            this.idDeleteJS.ShortcutsEnabled = true;
            this.idDeleteJS.Size = new System.Drawing.Size(268, 30);
            this.idDeleteJS.TabIndex = 56;
            this.idDeleteJS.UseSelectable = true;
            this.idDeleteJS.WaterMark = "Enter id";
            this.idDeleteJS.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idDeleteJS.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.Location = new System.Drawing.Point(97, 452);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(178, 30);
            this.metroLabel13.TabIndex = 55;
            this.metroLabel13.Text = "Enter id to delete";
            // 
            // employers
            // 
            this.employers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employers.Location = new System.Drawing.Point(97, 95);
            this.employers.Name = "employers";
            this.employers.Size = new System.Drawing.Size(707, 324);
            this.employers.TabIndex = 54;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.refreshButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.refreshButton.ForeColor = System.Drawing.Color.Black;
            this.refreshButton.Location = new System.Drawing.Point(618, 33);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(186, 40);
            this.refreshButton.TabIndex = 61;
            this.refreshButton.TabStop = false;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.refreshButton.UseCustomBackColor = true;
            this.refreshButton.UseCustomForeColor = true;
            this.refreshButton.UseSelectable = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // verifyJobSeekers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 788);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.approveJS);
            this.Controls.Add(this.validJS);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.deleteJS);
            this.Controls.Add(this.idDeleteJS);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.employers);
            this.Name = "verifyJobSeekers";
            this.Text = "Verify Job Seekers";
            this.Load += new System.EventHandler(this.verifyJobSeekers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton approveJS;
        private MetroFramework.Controls.MetroTextBox validJS;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton deleteJS;
        private MetroFramework.Controls.MetroTextBox idDeleteJS;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.DataGridView employers;
        private MetroFramework.Controls.MetroButton refreshButton;
    }
}