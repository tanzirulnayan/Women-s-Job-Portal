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
    public partial class UpdateProfileSettings : MetroForm
    {
        public string ConnectionString = "Data Source=localhost:1521/XE; User ID=adms; Password=adms";
        oracle.Connection_Query one = new oracle.Connection_Query();

        public int id;
        public string name;
        public string add;
        public string email;
        public Int64 phone;

        public UpdateProfileSettings(int a ,string b, string c, string d, Int64 e)
        {
            id = a;
            name = b;
            add = c;
            email = d;
            phone = e;
            InitializeComponent();

        }

        public void UpdateProfileSettings_Load(object sender, EventArgs e)
        {
            showId.Text = Convert.ToString(id);
            string query = "select *from PMIMAGE where PM_ID=" + id;
            one = new oracle.Connection_Query();
            one.OpenConection();
            OracleDataReader rd = one.DataReader(query);
            DataTable tbl = new DataTable();
            tbl.Load(rd);
            byte[] imgData = (byte[])tbl.Rows[0][1];
            MemoryStream ms = new MemoryStream();
            ms.Write(imgData, 0, imgData.Length);
            Bitmap bmp = new Bitmap(ms, false);
            pmPictureBox.Image = bmp;
            ms.Dispose();
            one.CloseConnection();


            string show = "select *from PORTAL_MODERATORS where PM_ID=" + id;
            one.OpenConection();
            OracleDataReader dshow = one.DataReader(show);
            
            DataTable tbl2 = new DataTable();
            tbl2.Load(dshow);
           string pm_name = (string)tbl2.Rows[0][1];
            string pm_add = (string)tbl2.Rows[0][2];
            Int64 pm_phone = (Int64)tbl2.Rows[0][3];
           string pm_email = (string)tbl2.Rows[0][4];
           string pm_joindate = tbl2.Rows[0][5].ToString();
            one.CloseConnection();
            //pm_joindate = tbl2.Rows[0][5].ToString();
            UpdatenameBox.Text = pm_name;
            updateAddBox.Text = pm_add;
            updateEmail.Text = pm_email;
            updatePhone.Text = Convert.ToString(pm_phone);
            showJoinDate.Text = pm_joindate;


        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void updateProfile_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void accountSettings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string q = "UPDATE PORTAL_MODERATORS SET PM_NAME = :pname, PM_ADDRESS = :padd,  PM_PHONE = :phone, PM_EMAIL = :pemail WHERE PM_ID = :pid";
            OracleConnection con = new OracleConnection(ConnectionString);
            OracleCommand com = new OracleCommand(q, con);
            com.Parameters.Add(new OracleParameter("pname", UpdatenameBox.Text));
            com.Parameters.Add(new OracleParameter("padd", updateAddBox.Text));
            com.Parameters.Add(new OracleParameter("phone", Convert.ToInt32(updatePhone.Text)));
            com.Parameters.Add(new OracleParameter("pemail", updateEmail.Text));
           com.Parameters.Add(new OracleParameter("pid", id));
            con.Open();
            com.ExecuteNonQuery();
            MessageBox.Show("Updated");
            con.Close();



        }

        private void updatePhone_Click(object sender, EventArgs e)
        {

        }

        private void updatePass_Click(object sender, EventArgs e)
        {
            string query = "select PM_PASSWORD from PM_USERS where PM_ID='" + id + "'";
            one.OpenConection();
            OracleDataReader dr = one.DataReader(query);
            dr.Read();
            string oldpass = dr.GetString(0);
            string newpass = pass.Text;
            string newrepass = repass.Text;
            string givenold = g_old_pass.Text;
            one.CloseConnection();

            string q = "UPDATE PM_USERS SET PM_PASSWORD = :pass WHERE PM_ID = :pid";
            OracleConnection conn = new OracleConnection(ConnectionString);
            OracleCommand com = new OracleCommand(q, conn);
            if (newrepass.Equals(newpass) && oldpass.Equals(givenold))
            {
                com.Parameters.Add(new OracleParameter("pass", newpass));
                com.Parameters.Add(new OracleParameter("pid", id));
                conn.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("password updated");
                conn.Close();
            }else if(!newrepass.Equals(newpass) || repass.Text == string.Empty || pass.Text == string.Empty || !oldpass.Equals(givenold))
            {
                MessageBox.Show("Put Correct password");
            }
        }

        private void jsPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
