namespace ADMS
{
    partial class emp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emp));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.empName = new MetroFramework.Controls.MetroTextBox();
            this.empId = new MetroFramework.Controls.MetroTextBox();
            this.emPass = new MetroFramework.Controls.MetroTextBox();
            this.empEmail = new MetroFramework.Controls.MetroTextBox();
            this.empPhone = new MetroFramework.Controls.MetroTextBox();
            this.empAdd = new MetroFramework.Controls.MetroTextBox();
            this.empPass = new MetroFramework.Controls.MetroLabel();
            this.empWeb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.empRePass = new MetroFramework.Controls.MetroTextBox();
            this.empSignUpButton = new MetroFramework.Controls.MetroButton();
            this.empPanel = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imageButton = new MetroFramework.Controls.MetroButton();
            this.textPath = new System.Windows.Forms.TextBox();
            this.saveImg = new MetroFramework.Controls.MetroButton();
            this.generateId = new System.Windows.Forms.Label();
            this.empPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(220, 177);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(31, 30);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(220, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 30);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Name";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(220, 430);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 30);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Address";
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(220, 379);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(90, 30);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Phone";
            // 
            // metroLabel5
            // 
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(220, 332);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(73, 30);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Email";
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(220, 484);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(90, 30);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Web Site";
            // 
            // empName
            // 
            // 
            // 
            // 
            this.empName.CustomButton.Image = null;
            this.empName.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.empName.CustomButton.Name = "";
            this.empName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.empName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.empName.CustomButton.TabIndex = 1;
            this.empName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.empName.CustomButton.UseSelectable = true;
            this.empName.CustomButton.Visible = false;
            this.empName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.empName.Lines = new string[0];
            this.empName.Location = new System.Drawing.Point(371, 132);
            this.empName.MaxLength = 32767;
            this.empName.Name = "empName";
            this.empName.PasswordChar = '\0';
            this.empName.PromptText = "Enter your full name";
            this.empName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.empName.SelectedText = "";
            this.empName.SelectionLength = 0;
            this.empName.SelectionStart = 0;
            this.empName.ShortcutsEnabled = true;
            this.empName.Size = new System.Drawing.Size(268, 30);
            this.empName.TabIndex = 14;
            this.empName.UseSelectable = true;
            this.empName.WaterMark = "Enter your full name";
            this.empName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.empName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // empId
            // 
            // 
            // 
            // 
            this.empId.CustomButton.Image = null;
            this.empId.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.empId.CustomButton.Name = "";
            this.empId.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.empId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.empId.CustomButton.TabIndex = 1;
            this.empId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.empId.CustomButton.UseSelectable = true;
            this.empId.CustomButton.Visible = false;
            this.empId.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.empId.Lines = new string[0];
            this.empId.Location = new System.Drawing.Point(371, 177);
            this.empId.MaxLength = 32767;
            this.empId.Name = "empId";
            this.empId.PasswordChar = '\0';
            this.empId.PromptText = "Enter your ID";
            this.empId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.empId.SelectedText = "";
            this.empId.SelectionLength = 0;
            this.empId.SelectionStart = 0;
            this.empId.ShortcutsEnabled = true;
            this.empId.Size = new System.Drawing.Size(268, 30);
            this.empId.TabIndex = 15;
            this.empId.UseSelectable = true;
            this.empId.WaterMark = "Enter your ID";
            this.empId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.empId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emPass
            // 
            // 
            // 
            // 
            this.emPass.CustomButton.Image = null;
            this.emPass.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.emPass.CustomButton.Name = "";
            this.emPass.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.emPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emPass.CustomButton.TabIndex = 1;
            this.emPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emPass.CustomButton.UseSelectable = true;
            this.emPass.CustomButton.Visible = false;
            this.emPass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.emPass.Lines = new string[0];
            this.emPass.Location = new System.Drawing.Point(371, 228);
            this.emPass.MaxLength = 32767;
            this.emPass.Name = "emPass";
            this.emPass.PasswordChar = '\0';
            this.emPass.PromptText = "Enter your password";
            this.emPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emPass.SelectedText = "";
            this.emPass.SelectionLength = 0;
            this.emPass.SelectionStart = 0;
            this.emPass.ShortcutsEnabled = true;
            this.emPass.Size = new System.Drawing.Size(268, 30);
            this.emPass.TabIndex = 16;
            this.emPass.UseSelectable = true;
            this.emPass.WaterMark = "Enter your password";
            this.emPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.emPass.Click += new System.EventHandler(this.emPass_Click);
            // 
            // empEmail
            // 
            // 
            // 
            // 
            this.empEmail.CustomButton.Image = null;
            this.empEmail.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.empEmail.CustomButton.Name = "";
            this.empEmail.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.empEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.empEmail.CustomButton.TabIndex = 1;
            this.empEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.empEmail.CustomButton.UseSelectable = true;
            this.empEmail.CustomButton.Visible = false;
            this.empEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.empEmail.Lines = new string[0];
            this.empEmail.Location = new System.Drawing.Point(371, 332);
            this.empEmail.MaxLength = 32767;
            this.empEmail.Name = "empEmail";
            this.empEmail.PasswordChar = '\0';
            this.empEmail.PromptText = "Enter your email";
            this.empEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.empEmail.SelectedText = "";
            this.empEmail.SelectionLength = 0;
            this.empEmail.SelectionStart = 0;
            this.empEmail.ShortcutsEnabled = true;
            this.empEmail.Size = new System.Drawing.Size(268, 30);
            this.empEmail.TabIndex = 17;
            this.empEmail.UseSelectable = true;
            this.empEmail.WaterMark = "Enter your email";
            this.empEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.empEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // empPhone
            // 
            // 
            // 
            // 
            this.empPhone.CustomButton.Image = null;
            this.empPhone.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.empPhone.CustomButton.Name = "";
            this.empPhone.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.empPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.empPhone.CustomButton.TabIndex = 1;
            this.empPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.empPhone.CustomButton.UseSelectable = true;
            this.empPhone.CustomButton.Visible = false;
            this.empPhone.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.empPhone.Lines = new string[0];
            this.empPhone.Location = new System.Drawing.Point(371, 379);
            this.empPhone.MaxLength = 32767;
            this.empPhone.Name = "empPhone";
            this.empPhone.PasswordChar = '\0';
            this.empPhone.PromptText = "Enter your phone no";
            this.empPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.empPhone.SelectedText = "";
            this.empPhone.SelectionLength = 0;
            this.empPhone.SelectionStart = 0;
            this.empPhone.ShortcutsEnabled = true;
            this.empPhone.Size = new System.Drawing.Size(268, 30);
            this.empPhone.TabIndex = 18;
            this.empPhone.UseSelectable = true;
            this.empPhone.WaterMark = "Enter your phone no";
            this.empPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.empPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // empAdd
            // 
            // 
            // 
            // 
            this.empAdd.CustomButton.Image = null;
            this.empAdd.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.empAdd.CustomButton.Name = "";
            this.empAdd.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.empAdd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.empAdd.CustomButton.TabIndex = 1;
            this.empAdd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.empAdd.CustomButton.UseSelectable = true;
            this.empAdd.CustomButton.Visible = false;
            this.empAdd.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.empAdd.Lines = new string[0];
            this.empAdd.Location = new System.Drawing.Point(371, 430);
            this.empAdd.MaxLength = 32767;
            this.empAdd.Name = "empAdd";
            this.empAdd.PasswordChar = '\0';
            this.empAdd.PromptText = "Enter your address";
            this.empAdd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.empAdd.SelectedText = "";
            this.empAdd.SelectionLength = 0;
            this.empAdd.SelectionStart = 0;
            this.empAdd.ShortcutsEnabled = true;
            this.empAdd.Size = new System.Drawing.Size(268, 30);
            this.empAdd.TabIndex = 19;
            this.empAdd.UseSelectable = true;
            this.empAdd.WaterMark = "Enter your address";
            this.empAdd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.empAdd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // empPass
            // 
            this.empPass.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.empPass.Location = new System.Drawing.Point(220, 224);
            this.empPass.Name = "empPass";
            this.empPass.Size = new System.Drawing.Size(95, 34);
            this.empPass.TabIndex = 20;
            this.empPass.Text = "Password";
            this.empPass.Click += new System.EventHandler(this.empPass_Click);
            // 
            // empWeb
            // 
            // 
            // 
            // 
            this.empWeb.CustomButton.Image = null;
            this.empWeb.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.empWeb.CustomButton.Name = "";
            this.empWeb.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.empWeb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.empWeb.CustomButton.TabIndex = 1;
            this.empWeb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.empWeb.CustomButton.UseSelectable = true;
            this.empWeb.CustomButton.Visible = false;
            this.empWeb.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.empWeb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.empWeb.Lines = new string[0];
            this.empWeb.Location = new System.Drawing.Point(371, 484);
            this.empWeb.MaxLength = 32767;
            this.empWeb.Name = "empWeb";
            this.empWeb.PasswordChar = '\0';
            this.empWeb.PromptText = "Enter website address";
            this.empWeb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.empWeb.SelectedText = "";
            this.empWeb.SelectionLength = 0;
            this.empWeb.SelectionStart = 0;
            this.empWeb.ShortcutsEnabled = true;
            this.empWeb.Size = new System.Drawing.Size(268, 30);
            this.empWeb.TabIndex = 21;
            this.empWeb.UseSelectable = true;
            this.empWeb.WaterMark = "Enter website address";
            this.empWeb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.empWeb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(219, 282);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(123, 34);
            this.metroLabel7.TabIndex = 22;
            this.metroLabel7.Text = "Re - Password";
            // 
            // empRePass
            // 
            // 
            // 
            // 
            this.empRePass.CustomButton.Image = null;
            this.empRePass.CustomButton.Location = new System.Drawing.Point(240, 2);
            this.empRePass.CustomButton.Name = "";
            this.empRePass.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.empRePass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.empRePass.CustomButton.TabIndex = 1;
            this.empRePass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.empRePass.CustomButton.UseSelectable = true;
            this.empRePass.CustomButton.Visible = false;
            this.empRePass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.empRePass.Lines = new string[0];
            this.empRePass.Location = new System.Drawing.Point(371, 286);
            this.empRePass.MaxLength = 32767;
            this.empRePass.Name = "empRePass";
            this.empRePass.PasswordChar = '\0';
            this.empRePass.PromptText = "Re - Enter your password";
            this.empRePass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.empRePass.SelectedText = "";
            this.empRePass.SelectionLength = 0;
            this.empRePass.SelectionStart = 0;
            this.empRePass.ShortcutsEnabled = true;
            this.empRePass.Size = new System.Drawing.Size(268, 30);
            this.empRePass.TabIndex = 23;
            this.empRePass.UseSelectable = true;
            this.empRePass.WaterMark = "Re - Enter your password";
            this.empRePass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.empRePass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // empSignUpButton
            // 
            this.empSignUpButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.empSignUpButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.empSignUpButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.empSignUpButton.ForeColor = System.Drawing.Color.Black;
            this.empSignUpButton.Location = new System.Drawing.Point(372, 430);
            this.empSignUpButton.Name = "empSignUpButton";
            this.empSignUpButton.Size = new System.Drawing.Size(95, 37);
            this.empSignUpButton.TabIndex = 24;
            this.empSignUpButton.Text = "Sign Up";
            this.empSignUpButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.empSignUpButton.UseCustomBackColor = true;
            this.empSignUpButton.UseCustomForeColor = true;
            this.empSignUpButton.UseSelectable = true;
            this.empSignUpButton.Click += new System.EventHandler(this.empSignUpButton_Click);
            // 
            // empPanel
            // 
            this.empPanel.Controls.Add(this.empSignUpButton);
            this.empPanel.ForeColor = System.Drawing.Color.Transparent;
            this.empPanel.HorizontalScrollbarBarColor = true;
            this.empPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.empPanel.HorizontalScrollbarSize = 10;
            this.empPanel.Location = new System.Drawing.Point(172, 125);
            this.empPanel.Name = "empPanel";
            this.empPanel.Size = new System.Drawing.Size(509, 497);
            this.empPanel.TabIndex = 25;
            this.empPanel.UseCustomBackColor = true;
            this.empPanel.UseCustomForeColor = true;
            this.empPanel.UseStyleColors = true;
            this.empPanel.VerticalScrollbarBarColor = true;
            this.empPanel.VerticalScrollbarHighlightOnWheel = false;
            this.empPanel.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel8
            // 
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(290, 29);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(336, 79);
            this.metroLabel8.TabIndex = 27;
            this.metroLabel8.Text = "Employee Registration";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            this.metroLabel8.UseStyleColors = true;
            this.metroLabel8.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // imageButton
            // 
            this.imageButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.imageButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.imageButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.imageButton.ForeColor = System.Drawing.Color.Black;
            this.imageButton.Location = new System.Drawing.Point(747, 286);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(110, 37);
            this.imageButton.TabIndex = 25;
            this.imageButton.Text = "Upload Image";
            this.imageButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.imageButton.UseCustomBackColor = true;
            this.imageButton.UseCustomForeColor = true;
            this.imageButton.UseSelectable = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(742, 244);
            this.textPath.Multiline = true;
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(115, 30);
            this.textPath.TabIndex = 29;
            // 
            // saveImg
            // 
            this.saveImg.Location = new System.Drawing.Point(0, 0);
            this.saveImg.Name = "saveImg";
            this.saveImg.Size = new System.Drawing.Size(75, 23);
            this.saveImg.TabIndex = 0;
            this.saveImg.UseSelectable = true;
            // 
            // generateId
            // 
            this.generateId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateId.Location = new System.Drawing.Point(727, 50);
            this.generateId.Name = "generateId";
            this.generateId.Size = new System.Drawing.Size(130, 37);
            this.generateId.TabIndex = 30;
            // 
            // emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 788);
            this.Controls.Add(this.generateId);
            this.Controls.Add(this.saveImg);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.empRePass);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.empWeb);
            this.Controls.Add(this.empPass);
            this.Controls.Add(this.empAdd);
            this.Controls.Add(this.empPhone);
            this.Controls.Add(this.empEmail);
            this.Controls.Add(this.emPass);
            this.Controls.Add(this.empId);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.empPanel);
            this.Name = "emp";
            this.Load += new System.EventHandler(this.emp_Load);
            this.empPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox empName;
        private MetroFramework.Controls.MetroTextBox empId;
        private MetroFramework.Controls.MetroTextBox emPass;
        private MetroFramework.Controls.MetroTextBox empEmail;
        private MetroFramework.Controls.MetroTextBox empPhone;
        private MetroFramework.Controls.MetroTextBox empAdd;
        private MetroFramework.Controls.MetroLabel empPass;
        private MetroFramework.Controls.MetroTextBox empWeb;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox empRePass;
        private MetroFramework.Controls.MetroButton empSignUpButton;
        private MetroFramework.Controls.MetroPanel empPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton imageButton;
        private System.Windows.Forms.TextBox textPath;
        private MetroFramework.Controls.MetroButton saveImg;
        private System.Windows.Forms.Label generateId;
    }
}