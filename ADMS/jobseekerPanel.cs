using MetroFramework.Forms;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMS
{
    public partial class jobseekerPanel : MetroForm
    {
        public int js_id;
        private string j_name;
        private string j_add;
        private string j_email;
        private Int64 j_phone;
        private string j_dob;
        private string j_edu;
        private string j_skill;
        oracle.Connection_Query one = new oracle.Connection_Query();

        private Form jobseeker_Panel = new Form();
        public Form getForm
        {
            get { return jobseeker_Panel; }
            set { jobseeker_Panel = value; }
        }
        public jobseekerPanel(int a)
        {
            one.OpenConection();
            js_id = a;
            InitializeComponent();
        }

        private void jobseekerPanel_Load(object sender, EventArgs e)
        {
            string query = "select *from JIMAGE where J_ID=" + js_id;
            OracleDataReader rd = one.DataReader(query);
            DataTable tbl = new DataTable();
            tbl.Load(rd);
            byte[] imgData = (byte[])tbl.Rows[0][1];
            MemoryStream ms = new MemoryStream();
            ms.Write(imgData, 0, imgData.Length);
            Bitmap bmp = new Bitmap(ms, false);
            jsPictureBox.Image = bmp;
            ms.Dispose();

            string show = "select *from JOB_SEEKERS where JS_ID=" + js_id;
            OracleDataReader dshow = one.DataReader(show);
            DataTable tbl2 = new DataTable();
            tbl2.Load(dshow);
            j_name = (string)tbl2.Rows[0][1];
            j_add = (string)tbl2.Rows[0][2];
            j_phone = (Int64)tbl2.Rows[0][3];
            j_email = (string)tbl2.Rows[0][4];
            j_dob = tbl2.Rows[0][5].ToString();
            j_edu = (string)tbl2.Rows[0][6];
            j_skill = (string)tbl2.Rows[0][7];
          
  
            idShow.Text = Convert.ToString(js_id);
            nameShow.Text = j_name;
            addressShow.Text = j_add;
            emailShow.Text = j_email;
            phnShow.Text = Convert.ToString(j_phone);
            dobShow.Text = j_dob;
            eduShow.Text = j_edu;
            skillShow.Text = j_skill;
            name.Text = j_name;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchJob_Click(object sender, EventArgs e)
        {
            browseJob job = new browseJob(js_id);
            job.ShowDialog();
        }

        private void updateProfile_Click(object sender, EventArgs e)
        {
            updateJobSeeker upjob = new updateJobSeeker(js_id);
            upjob.ShowDialog();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
