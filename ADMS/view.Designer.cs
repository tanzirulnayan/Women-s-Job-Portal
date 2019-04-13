namespace ADMS
{
    partial class view
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
            this.empCir = new System.Windows.Forms.Label();
            this.empCircular = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.empCircular)).BeginInit();
            this.SuspendLayout();
            // 
            // empCir
            // 
            this.empCir.AutoSize = true;
            this.empCir.Location = new System.Drawing.Point(23, 73);
            this.empCir.Name = "empCir";
            this.empCir.Size = new System.Drawing.Size(99, 13);
            this.empCir.TabIndex = 0;
            this.empCir.Text = "Employeer Circulars";
            // 
            // empCircular
            // 
            this.empCircular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empCircular.Location = new System.Drawing.Point(22, 113);
            this.empCircular.Name = "empCircular";
            this.empCircular.Size = new System.Drawing.Size(547, 198);
            this.empCircular.TabIndex = 1;
            // 
            // view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 788);
            this.Controls.Add(this.empCircular);
            this.Controls.Add(this.empCir);
            this.Name = "view";
            this.Text = "View";
            this.Load += new System.EventHandler(this.view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empCircular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label empCir;
        private System.Windows.Forms.DataGridView empCircular;
    }
}