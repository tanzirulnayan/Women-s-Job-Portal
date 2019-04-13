namespace ADMS
{
    partial class Verify
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
            this.employers = new System.Windows.Forms.DataGridView();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.idDelete = new MetroFramework.Controls.MetroTextBox();
            this.delete = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.valid = new MetroFramework.Controls.MetroTextBox();
            this.approve = new MetroFramework.Controls.MetroButton();
            this.refreshButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.employers)).BeginInit();
            this.SuspendLayout();
            // 
            // employers
            // 
            this.employers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employers.Location = new System.Drawing.Point(34, 91);
            this.employers.Name = "employers";
            this.employers.Size = new System.Drawing.Size(707, 398);
            this.employers.TabIndex = 0;
            // 
            // metroLabel13
            // 
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.Location = new System.Drawing.Point(34, 510);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(178, 30);
            this.metroLabel13.TabIndex = 4;
            this.metroLabel13.Text = "Enter id to delete";
            // 
            // idDelete
            // 
            // 
            // 
            // 
            this.idDelete.CustomButton.Image = null;
            this.idDelete.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.idDelete.CustomButton.Name = "";
            this.idDelete.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.idDelete.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idDelete.CustomButton.TabIndex = 1;
            this.idDelete.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idDelete.CustomButton.UseSelectable = true;
            this.idDelete.CustomButton.Visible = false;
            this.idDelete.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.idDelete.Lines = new string[0];
            this.idDelete.Location = new System.Drawing.Point(473, 510);
            this.idDelete.MaxLength = 32767;
            this.idDelete.Name = "idDelete";
            this.idDelete.PasswordChar = '\0';
            this.idDelete.PromptText = "Enter id";
            this.idDelete.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idDelete.SelectedText = "";
            this.idDelete.SelectionLength = 0;
            this.idDelete.SelectionStart = 0;
            this.idDelete.ShortcutsEnabled = true;
            this.idDelete.Size = new System.Drawing.Size(268, 30);
            this.idDelete.TabIndex = 13;
            this.idDelete.UseSelectable = true;
            this.idDelete.WaterMark = "Enter id";
            this.idDelete.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idDelete.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.delete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.delete.ForeColor = System.Drawing.Color.Black;
            this.delete.Location = new System.Drawing.Point(586, 546);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(155, 40);
            this.delete.TabIndex = 50;
            this.delete.TabStop = false;
            this.delete.Text = "Delete User";
            this.delete.Theme = MetroFramework.MetroThemeStyle.Light;
            this.delete.UseCustomBackColor = true;
            this.delete.UseCustomForeColor = true;
            this.delete.UseSelectable = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(34, 614);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(178, 30);
            this.metroLabel1.TabIndex = 51;
            this.metroLabel1.Text = "Enter id to approve";
            // 
            // valid
            // 
            // 
            // 
            // 
            this.valid.CustomButton.Image = null;
            this.valid.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.valid.CustomButton.Name = "";
            this.valid.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.valid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.valid.CustomButton.TabIndex = 1;
            this.valid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.valid.CustomButton.UseSelectable = true;
            this.valid.CustomButton.Visible = false;
            this.valid.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.valid.Lines = new string[0];
            this.valid.Location = new System.Drawing.Point(473, 614);
            this.valid.MaxLength = 32767;
            this.valid.Name = "valid";
            this.valid.PasswordChar = '\0';
            this.valid.PromptText = "Enter id";
            this.valid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.valid.SelectedText = "";
            this.valid.SelectionLength = 0;
            this.valid.SelectionStart = 0;
            this.valid.ShortcutsEnabled = true;
            this.valid.Size = new System.Drawing.Size(268, 30);
            this.valid.TabIndex = 52;
            this.valid.UseSelectable = true;
            this.valid.WaterMark = "Enter id";
            this.valid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.valid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // approve
            // 
            this.approve.BackColor = System.Drawing.Color.LightSkyBlue;
            this.approve.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.approve.ForeColor = System.Drawing.Color.Black;
            this.approve.Location = new System.Drawing.Point(586, 650);
            this.approve.Name = "approve";
            this.approve.Size = new System.Drawing.Size(155, 40);
            this.approve.TabIndex = 53;
            this.approve.TabStop = false;
            this.approve.Text = "Approve User";
            this.approve.Theme = MetroFramework.MetroThemeStyle.Light;
            this.approve.UseCustomBackColor = true;
            this.approve.UseCustomForeColor = true;
            this.approve.UseSelectable = true;
            this.approve.Click += new System.EventHandler(this.Approve_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.refreshButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.refreshButton.ForeColor = System.Drawing.Color.Black;
            this.refreshButton.Location = new System.Drawing.Point(555, 23);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(186, 40);
            this.refreshButton.TabIndex = 62;
            this.refreshButton.TabStop = false;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.refreshButton.UseCustomBackColor = true;
            this.refreshButton.UseCustomForeColor = true;
            this.refreshButton.UseSelectable = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 788);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.approve);
            this.Controls.Add(this.valid);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.idDelete);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.employers);
            this.Name = "Verify";
            this.Text = "Verify";
            this.Load += new System.EventHandler(this.Verify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employers;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox idDelete;
        private MetroFramework.Controls.MetroButton delete;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox valid;
        private MetroFramework.Controls.MetroButton approve;
        private MetroFramework.Controls.MetroButton refreshButton;
    }
}