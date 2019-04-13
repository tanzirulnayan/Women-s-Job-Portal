using MetroFramework.Forms;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMS
{
    public partial class updateEmployee : MetroForm
    {
        public string ConnectionString = "Data Source=localhost:1521/XE; User ID=adms; Password=adms";
        oracle.Connection_Query one = new oracle.Connection_Query();
        public int id;
        public updateEmployee(int a)
        {
            id = a;
            InitializeComponent();
        }

        private void updateEmployee_Load(object sender, EventArgs e)
        {
            showId.Text = Convert.ToString(id);
            string show = "select *from EMPLOYERS where E_ID=" + id;
            one.OpenConection();
            OracleDataReader dshow = one.DataReader(show);

            DataTable tbl2 = new DataTable();
            tbl2.Load(dshow);
            string pm_name = (string)tbl2.Rows[0][1];
            string pm_add = (string)tbl2.Rows[0][2];
            string pm_email = (string)tbl2.Rows[0][4];
            string pm_web = (string)tbl2.Rows[0][5];
            one.CloseConnection();
            //pm_joindate = tbl2.Rows[0][5].ToString();
            UpdatenameBox.Text = pm_name;
            updateAddBox.Text = pm_add;
            updateEmail.Text = pm_email;
            updateSite.Text = pm_web;
            //showJoinDate.Text = pm_joindate;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string q = "UPDATE EMPLOYERS SET E_NAME = :pname, E_ADDRESS = :padd,  E_WEBSITE = :phone, E_EMAIL = :pemail WHERE E_ID = :pid";
            OracleConnection con = new OracleConnection(ConnectionString);
            OracleCommand com = new OracleCommand(q, con);
            com.Parameters.Add(new OracleParameter("pname", UpdatenameBox.Text));
            com.Parameters.Add(new OracleParameter("padd", updateAddBox.Text));
            com.Parameters.Add(new OracleParameter("phone", updateSite.Text));
            com.Parameters.Add(new OracleParameter("pemail", updateEmail.Text));
            com.Parameters.Add(new OracleParameter("pid", id));
            con.Open();
            com.ExecuteNonQuery();
            MessageBox.Show("Update Sucessful");
            con.Close();
        }

        private void updatePass_Click(object sender, EventArgs e)
        {
            string query = "select E_PASSWORD from E_USERS where E_ID='" + id + "'";
            one.OpenConection();
            OracleDataReader dr = one.DataReader(query);
            dr.Read();
            string oldpass = dr.GetString(0);
            string newpass = pass.Text;
            string newrepass = repass.Text;
            string givenold = g_old_pass.Text;
            one.CloseConnection();

            string q = "UPDATE E_USERS SET E_PASSWORD = :pass WHERE E_ID = :pid";
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
            }
            else if (!newrepass.Equals(newpass) || repass.Text == string.Empty || pass.Text == string.Empty || !oldpass.Equals(givenold))
            {
                MessageBox.Show("Put Correct password");
            }
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if(metroToggle1.Checked == true)
            {
                accountSettings.Visible = true;
            }else if(metroToggle1.Checked == false)
            {
                accountSettings.Visible = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
