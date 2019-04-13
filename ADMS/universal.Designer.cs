namespace ADMS
{
    partial class universal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(universal));
            this.selectionPanel = new System.Windows.Forms.Panel();
            this.infoButton = new System.Windows.Forms.Button();
            this.empButton = new System.Windows.Forms.Button();
            this.jobseekButton = new System.Windows.Forms.Button();
            this.portalModarator = new System.Windows.Forms.Button();
            this.selectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectionPanel
            // 
            this.selectionPanel.Controls.Add(this.infoButton);
            this.selectionPanel.Controls.Add(this.empButton);
            this.selectionPanel.Controls.Add(this.jobseekButton);
            this.selectionPanel.Controls.Add(this.portalModarator);
            this.selectionPanel.Location = new System.Drawing.Point(288, 190);
            this.selectionPanel.Name = "selectionPanel";
            this.selectionPanel.Size = new System.Drawing.Size(330, 317);
            this.selectionPanel.TabIndex = 0;
            this.selectionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.selectionPanel_Paint);
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.infoButton.FlatAppearance.BorderSize = 0;
            this.infoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.ForeColor = System.Drawing.Color.Black;
            this.infoButton.Image = ((System.Drawing.Image)(resources.GetObject("infoButton.Image")));
            this.infoButton.Location = new System.Drawing.Point(158, 150);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(136, 128);
            this.infoButton.TabIndex = 11;
            this.infoButton.Text = "Information";
            this.infoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.infoButton.UseVisualStyleBackColor = false;
            // 
            // empButton
            // 
            this.empButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.empButton.FlatAppearance.BorderSize = 0;
            this.empButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.empButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empButton.ForeColor = System.Drawing.Color.Black;
            this.empButton.Image = ((System.Drawing.Image)(resources.GetObject("empButton.Image")));
            this.empButton.Location = new System.Drawing.Point(3, 150);
            this.empButton.Name = "empButton";
            this.empButton.Size = new System.Drawing.Size(136, 128);
            this.empButton.TabIndex = 10;
            this.empButton.Text = "Employers";
            this.empButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.empButton.UseVisualStyleBackColor = false;
            this.empButton.Click += new System.EventHandler(this.empButton_Click);
            // 
            // jobseekButton
            // 
            this.jobseekButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.jobseekButton.FlatAppearance.BorderSize = 0;
            this.jobseekButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.jobseekButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jobseekButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobseekButton.ForeColor = System.Drawing.Color.Black;
            this.jobseekButton.Image = ((System.Drawing.Image)(resources.GetObject("jobseekButton.Image")));
            this.jobseekButton.Location = new System.Drawing.Point(3, 3);
            this.jobseekButton.Name = "jobseekButton";
            this.jobseekButton.Size = new System.Drawing.Size(136, 128);
            this.jobseekButton.TabIndex = 9;
            this.jobseekButton.Text = "Job Seekers";
            this.jobseekButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.jobseekButton.UseVisualStyleBackColor = false;
            this.jobseekButton.Click += new System.EventHandler(this.jobseekButton_Click);
            // 
            // portalModarator
            // 
            this.portalModarator.BackColor = System.Drawing.Color.LightSkyBlue;
            this.portalModarator.FlatAppearance.BorderSize = 0;
            this.portalModarator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.portalModarator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portalModarator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portalModarator.ForeColor = System.Drawing.Color.Black;
            this.portalModarator.Image = ((System.Drawing.Image)(resources.GetObject("portalModarator.Image")));
            this.portalModarator.Location = new System.Drawing.Point(158, 3);
            this.portalModarator.Name = "portalModarator";
            this.portalModarator.Size = new System.Drawing.Size(136, 128);
            this.portalModarator.TabIndex = 8;
            this.portalModarator.Text = "Portal Modarator";
            this.portalModarator.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.portalModarator.UseVisualStyleBackColor = false;
            this.portalModarator.Click += new System.EventHandler(this.portalModarator_Click);
            // 
            // universal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 788);
            this.Controls.Add(this.selectionPanel);
            this.Name = "universal";
            this.Text = "Selection";
            this.Load += new System.EventHandler(this.universal_Load);
            this.selectionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel selectionPanel;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button empButton;
        private System.Windows.Forms.Button jobseekButton;
        private System.Windows.Forms.Button portalModarator;
    }
}