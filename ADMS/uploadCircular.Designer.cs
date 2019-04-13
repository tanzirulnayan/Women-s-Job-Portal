namespace ADMS
{
    partial class uploadCircular
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.c_position = new MetroFramework.Controls.MetroTextBox();
            this.c_id = new MetroFramework.Controls.MetroTextBox();
            this.c_salary = new MetroFramework.Controls.MetroTextBox();
            this.c_cgpa = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.backButton = new MetroFramework.Controls.MetroButton();
            this.uploadButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTextBox1);
            this.metroPanel1.Controls.Add(this.checkedListBox3);
            this.metroPanel1.Controls.Add(this.checkedListBox2);
            this.metroPanel1.Controls.Add(this.checkedListBox1);
            this.metroPanel1.Controls.Add(this.c_position);
            this.metroPanel1.Controls.Add(this.c_id);
            this.metroPanel1.Controls.Add(this.c_salary);
            this.metroPanel1.Controls.Add(this.c_cgpa);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(50, 93);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(811, 558);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(181, 64);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Enter Title";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(257, 43);
            this.metroTextBox1.TabIndex = 37;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Enter Title";
            this.metroTextBox1.WaterMarkColor = System.Drawing.SystemColors.Highlight;
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "Dhaka",
            "Chittagong",
            "Sylhet",
            "Rajshahi",
            "Barishal",
            "Mymensingh",
            "Rangpur",
            "Khulna"});
            this.checkedListBox3.Location = new System.Drawing.Point(181, 323);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(257, 28);
            this.checkedListBox3.TabIndex = 36;
            this.checkedListBox3.SelectedIndexChanged += new System.EventHandler(this.checkedListBox3_SelectedIndexChanged);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Full Time",
            "Part Time"});
            this.checkedListBox2.Location = new System.Drawing.Point(181, 261);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(257, 28);
            this.checkedListBox2.TabIndex = 35;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "IT",
            "Medical",
            "Business",
            "Architecture",
            "Electric Engineer",
            "Pharmasist",
            "Teacher",
            "Chef",
            "Accounting",
            "Receptionist"});
            this.checkedListBox1.Location = new System.Drawing.Point(181, 189);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(257, 28);
            this.checkedListBox1.TabIndex = 34;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // c_position
            // 
            // 
            // 
            // 
            this.c_position.CustomButton.Image = null;
            this.c_position.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.c_position.CustomButton.Name = "";
            this.c_position.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.c_position.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.c_position.CustomButton.TabIndex = 1;
            this.c_position.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.c_position.CustomButton.UseSelectable = true;
            this.c_position.CustomButton.Visible = false;
            this.c_position.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.c_position.Lines = new string[0];
            this.c_position.Location = new System.Drawing.Point(181, 122);
            this.c_position.MaxLength = 32767;
            this.c_position.Name = "c_position";
            this.c_position.PasswordChar = '\0';
            this.c_position.PromptText = "Enter Position";
            this.c_position.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.c_position.SelectedText = "";
            this.c_position.SelectionLength = 0;
            this.c_position.SelectionStart = 0;
            this.c_position.ShortcutsEnabled = true;
            this.c_position.Size = new System.Drawing.Size(257, 43);
            this.c_position.TabIndex = 33;
            this.c_position.UseSelectable = true;
            this.c_position.WaterMark = "Enter Position";
            this.c_position.WaterMarkColor = System.Drawing.SystemColors.Highlight;
            this.c_position.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.c_position.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // c_id
            // 
            // 
            // 
            // 
            this.c_id.CustomButton.Image = null;
            this.c_id.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.c_id.CustomButton.Name = "";
            this.c_id.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.c_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.c_id.CustomButton.TabIndex = 1;
            this.c_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.c_id.CustomButton.UseSelectable = true;
            this.c_id.CustomButton.Visible = false;
            this.c_id.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.c_id.Lines = new string[0];
            this.c_id.Location = new System.Drawing.Point(181, 6);
            this.c_id.MaxLength = 32767;
            this.c_id.Name = "c_id";
            this.c_id.PasswordChar = '\0';
            this.c_id.PromptText = "Enter ID";
            this.c_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.c_id.SelectedText = "";
            this.c_id.SelectionLength = 0;
            this.c_id.SelectionStart = 0;
            this.c_id.ShortcutsEnabled = true;
            this.c_id.Size = new System.Drawing.Size(257, 43);
            this.c_id.TabIndex = 31;
            this.c_id.UseSelectable = true;
            this.c_id.WaterMark = "Enter ID";
            this.c_id.WaterMarkColor = System.Drawing.SystemColors.Highlight;
            this.c_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // c_salary
            // 
            // 
            // 
            // 
            this.c_salary.CustomButton.Image = null;
            this.c_salary.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.c_salary.CustomButton.Name = "";
            this.c_salary.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.c_salary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.c_salary.CustomButton.TabIndex = 1;
            this.c_salary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.c_salary.CustomButton.UseSelectable = true;
            this.c_salary.CustomButton.Visible = false;
            this.c_salary.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.c_salary.Lines = new string[0];
            this.c_salary.Location = new System.Drawing.Point(181, 478);
            this.c_salary.MaxLength = 32767;
            this.c_salary.Name = "c_salary";
            this.c_salary.PasswordChar = '\0';
            this.c_salary.PromptText = "Enter Salary";
            this.c_salary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.c_salary.SelectedText = "";
            this.c_salary.SelectionLength = 0;
            this.c_salary.SelectionStart = 0;
            this.c_salary.ShortcutsEnabled = true;
            this.c_salary.Size = new System.Drawing.Size(257, 43);
            this.c_salary.TabIndex = 30;
            this.c_salary.UseSelectable = true;
            this.c_salary.WaterMark = "Enter Salary";
            this.c_salary.WaterMarkColor = System.Drawing.SystemColors.Highlight;
            this.c_salary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // c_cgpa
            // 
            // 
            // 
            // 
            this.c_cgpa.CustomButton.Image = null;
            this.c_cgpa.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.c_cgpa.CustomButton.Name = "";
            this.c_cgpa.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.c_cgpa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.c_cgpa.CustomButton.TabIndex = 1;
            this.c_cgpa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.c_cgpa.CustomButton.UseSelectable = true;
            this.c_cgpa.CustomButton.Visible = false;
            this.c_cgpa.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.c_cgpa.Lines = new string[0];
            this.c_cgpa.Location = new System.Drawing.Point(181, 402);
            this.c_cgpa.MaxLength = 32767;
            this.c_cgpa.Name = "c_cgpa";
            this.c_cgpa.PasswordChar = '\0';
            this.c_cgpa.PromptText = "Enter CGPA";
            this.c_cgpa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.c_cgpa.SelectedText = "";
            this.c_cgpa.SelectionLength = 0;
            this.c_cgpa.SelectionStart = 0;
            this.c_cgpa.ShortcutsEnabled = true;
            this.c_cgpa.Size = new System.Drawing.Size(257, 43);
            this.c_cgpa.TabIndex = 3;
            this.c_cgpa.UseSelectable = true;
            this.c_cgpa.WaterMark = "Enter CGPA";
            this.c_cgpa.WaterMarkColor = System.Drawing.SystemColors.Highlight;
            this.c_cgpa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(23, 491);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(115, 30);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "Salary";
            // 
            // metroLabel7
            // 
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(23, 415);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(138, 30);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Required CGPA";
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(23, 323);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(115, 30);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Job Location";
            // 
            // metroLabel5
            // 
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(23, 261);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(101, 30);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Job Nature";
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(23, 178);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(101, 30);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Job Type";
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(23, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 30);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Job Position";
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 30);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Title";
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(31, 30);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "ID";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.backButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.backButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.backButton.Location = new System.Drawing.Point(73, 690);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(138, 37);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.backButton.UseCustomBackColor = true;
            this.backButton.UseCustomForeColor = true;
            this.backButton.UseSelectable = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.uploadButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.uploadButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.uploadButton.Location = new System.Drawing.Point(414, 690);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(138, 37);
            this.uploadButton.TabIndex = 8;
            this.uploadButton.Text = "Upload";
            this.uploadButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uploadButton.UseCustomBackColor = true;
            this.uploadButton.UseCustomForeColor = true;
            this.uploadButton.UseSelectable = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cancelButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cancelButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.cancelButton.Location = new System.Drawing.Point(723, 690);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(138, 37);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cancelButton.UseCustomBackColor = true;
            this.cancelButton.UseCustomForeColor = true;
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // uploadCircular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 788);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.metroPanel1);
            this.Name = "uploadCircular";
            this.Text = "Upload Circular";
            this.Load += new System.EventHandler(this.uploadCircular_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox c_position;
        private MetroFramework.Controls.MetroTextBox c_id;
        private MetroFramework.Controls.MetroTextBox c_salary;
        private MetroFramework.Controls.MetroTextBox c_cgpa;
        private MetroFramework.Controls.MetroButton backButton;
        private MetroFramework.Controls.MetroButton uploadButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}