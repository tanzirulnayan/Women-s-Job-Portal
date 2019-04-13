namespace ADMS
{
    partial class stat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalCircular = new MetroFramework.Controls.MetroLabel();
            this.totalJS = new MetroFramework.Controls.MetroLabel();
            this.totalPM = new MetroFramework.Controls.MetroLabel();
            this.totalemp = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.totalCircular);
            this.panel1.Controls.Add(this.totalJS);
            this.panel1.Controls.Add(this.totalPM);
            this.panel1.Controls.Add(this.totalemp);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Location = new System.Drawing.Point(32, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 311);
            this.panel1.TabIndex = 0;
            // 
            // totalCircular
            // 
            this.totalCircular.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.totalCircular.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.totalCircular.Location = new System.Drawing.Point(274, 225);
            this.totalCircular.Name = "totalCircular";
            this.totalCircular.Size = new System.Drawing.Size(150, 30);
            this.totalCircular.TabIndex = 10;
            // 
            // totalJS
            // 
            this.totalJS.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.totalJS.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.totalJS.Location = new System.Drawing.Point(274, 159);
            this.totalJS.Name = "totalJS";
            this.totalJS.Size = new System.Drawing.Size(150, 30);
            this.totalJS.TabIndex = 9;
            // 
            // totalPM
            // 
            this.totalPM.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.totalPM.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.totalPM.Location = new System.Drawing.Point(274, 88);
            this.totalPM.Name = "totalPM";
            this.totalPM.Size = new System.Drawing.Size(150, 30);
            this.totalPM.TabIndex = 8;
            // 
            // totalemp
            // 
            this.totalemp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.totalemp.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.totalemp.Location = new System.Drawing.Point(274, 23);
            this.totalemp.Name = "totalemp";
            this.totalemp.Size = new System.Drawing.Size(150, 30);
            this.totalemp.TabIndex = 7;
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(18, 225);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(177, 30);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Total Circular";
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(18, 159);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(177, 30);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Total Job Seekers";
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(18, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(198, 30);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Total Portal Moderator";
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(18, 23);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(150, 30);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Total Employers";
            // 
            // stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 788);
            this.Controls.Add(this.panel1);
            this.Name = "stat";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.stat_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel totalCircular;
        private MetroFramework.Controls.MetroLabel totalJS;
        private MetroFramework.Controls.MetroLabel totalPM;
        private MetroFramework.Controls.MetroLabel totalemp;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}