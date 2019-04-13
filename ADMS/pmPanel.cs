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
    public partial class pmPanel : MetroForm
    {
        private int pm_id;
        private string pm_name;
        private string pm_add;
        private string pm_email;
        private Int64 pm_phone;
        private string pm_joindate;
        public int status;
        oracle.Connection_Query one = new oracle.Connection_Query();
        private Form pm_panel = new Form();
        public Form getForm
        {
            get { return pm_panel; }
            set { pm_panel = value; }
        }
        public pmPanel(int a)
        {
            one.OpenConection();

            pm_id = a;
            InitializeComponent();
        }

        private void pmPanel_Load(object sender, EventArgs e)
        {
            string query = "select *from PMIMAGE where PM_ID=" + pm_id;
            OracleDataReader rd = one.DataReader(query);
            DataTable tbl = new DataTable();
            tbl.Load(rd);
            byte[] imgData = (byte[])tbl.Rows[0][1];
            MemoryStream ms = new MemoryStream();
            ms.Write(imgData, 0, imgData.Length);
            Bitmap bmp = new Bitmap(ms, false);
            jsPictureBox.Image = bmp;
            ms.Dispose();

            string show = "select *from PORTAL_MODERATORS where PM_ID=" + pm_id;
            OracleDataReader dshow = one.DataReader(show);
            DataTable tbl2 = new DataTable();
            tbl2.Load(dshow);
            pm_name = (string)tbl2.Rows[0][1];
            pm_add = (string)tbl2.Rows[0][2];
            pm_phone = (Int64)tbl2.Rows[0][3];
            pm_email = (string)tbl2.Rows[0][4];
            pm_joindate = tbl2.Rows[0][5].ToString();



            idShow.Text = Convert.ToString(pm_id);
            nameShow.Text = pm_name;
            addressShow.Text = pm_add;
            emailShow.Text = pm_email;
            phnShow.Text = Convert.ToString(pm_phone);
            joinShow.Text = pm_joindate;
            name.Text = pm_name;
        }

        private void joinDate_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            UpdateProfileSettings one = new UpdateProfileSettings(pm_id, pm_name, pm_add, pm_email, pm_phone);
          
           one.accountSettings.Visible = true;
            one.ShowDialog();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            UpdateProfileSettings one = new UpdateProfileSettings(pm_id,pm_name,pm_add,pm_email,pm_phone);
            one.updateProfile.Visible = true;
            one.ShowDialog();
        }

        private void searchJob_Click(object sender, EventArgs e)
        {
            Verify emp = new Verify(pm_id);
            emp.ShowDialog();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void delProfile_Click(object sender, EventArgs e)
        {
            verifyJobSeekers js = new verifyJobSeekers(pm_id);
            js.ShowDialog();
        }

        private void stat_Click(object sender, EventArgs e)
        {
            stat obj = new stat();
            obj.ShowDialog();
        }

        private void viw_Click(object sender, EventArgs e)
        {
            view one = new view();
            one.ShowDialog();
        }

        private void recovery_Click(object sender, EventArgs e)
        {
            recoveryPass recover = new recoveryPass();
            recover.ShowDialog();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
