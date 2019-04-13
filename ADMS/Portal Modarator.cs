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
    public partial class PM : MetroForm
    {
        public string ConnectionString = "Data Source=localhost:1521/XE; User ID=adms; Password=adms";
        private string pm_name;
        private int pm_id;
        private string pm_pass;
        private string pm_repass;
        private string pm_email;
        private int pm_phone;
        private string pm_add;
        private string pm_joindate;
        //public string _insertQurey = "INSERT INTO PORTAL_MODERATORS (PM_ID,PM_NAME, PM_ADDRESS, PM_PHONE, PM_EMAIL, PM_JOIN_DATE)  VALUES (:pm_id,:pm_name,:pm_add,:pm_phone,:pm_email,:pm_joindate)";
        public PM()
        {
            InitializeComponent();
        }

        private void Portal_Modarator_Load(object sender, EventArgs e)
        {
            OracleConnection generate = new OracleConnection(ConnectionString);
            generate.Open();
            OracleCommand gCmd = generate.CreateCommand();
            gCmd.CommandType = CommandType.Text;
            gCmd.CommandText = "select PM_ID_SEQ.nextval from dual";
            int lnNextVal = Convert.ToInt32(gCmd.ExecuteScalar());
            IdBox.Text = Convert.ToString(lnNextVal);
            generate.Close();
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog picture = new OpenFileDialog();
            picture.ShowDialog();
            textPath.Text = picture.FileName;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (passBox.Text != repassBox.Text) { MessageBox.Show("Correct your password"); }
            else
            {
                string q = "insert into PM_USERS (PM_ID,PM_PASSWORD) values (:pm_id,:pm_pass)";
                OracleConnection con = new OracleConnection(ConnectionString);
                OracleCommand com = new OracleCommand(q, con);
                com.Parameters.Add(new OracleParameter("pm_id", Convert.ToInt32(IdBox.Text)));
                com.Parameters.Add(new OracleParameter("pm_pass", passBox.Text));
                con.Open();
                com.ExecuteNonQuery();






               string _insertQurey = "INSERT INTO PORTAL_MODERATORS (PM_ID,PM_NAME, PM_ADDRESS, PM_PHONE, PM_EMAIL, PM_JOIN_DATE)  VALUES (:pm_id,:pm_name,:pm_add,:pm_phone,:pm_email,:pm_joindate)";
                //OracleConnection connection = new OracleConnection(ConnectionString);
                OracleCommand command2 = new OracleCommand(_insertQurey, con);

                command2.Parameters.Add(new OracleParameter("pm_id", Convert.ToInt32(IdBox.Text)));
                command2.Parameters.Add(new OracleParameter("pm_name", nameBox.Text));
                command2.Parameters.Add(new OracleParameter("pm_add", addressBox.Text));
                command2.Parameters.Add(new OracleParameter("pm_phone", Convert.ToInt32(phoneBox.Text)));
                command2.Parameters.Add(new OracleParameter("pm_email", emailBox.Text));
                command2.Parameters.Add(new OracleParameter("pm_joindate", dateTimePicker1.Value.Date));
                // command2.Parameters.Add(new OracleParameter("js_image",IdBox.Text));
                // command.Connection.ExecuteQueries(_insertQurey);
                // connection.Open();

                /*command2.AddRowid = true;
                OracleDependency dep = new OracleDependency(command2);
                command2.Notification.IsNotifiedOnce = false;
                dep.OnChange += new OnChangeEventHandler(OnMyNotificaton);*/



                command2.ExecuteNonQuery();
                // connection.Close();


                //Image Save
                FileStream fs = new FileStream(textPath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                FileInfo fi = new FileInfo(textPath.Text);
                byte[] imgData = br.ReadBytes((int)fi.Length);
                fs.Close();
                br.Close();

                string _query = "insert into PMIMAGE values (:pm_id,:img)";
                // OracleConnection connection = two.returnConn();
                OracleCommand command3 = new OracleCommand(_query, con);
                command3.Parameters.Add(new OracleParameter("pm_id", IdBox.Text));
                command3.Parameters.Add(new OracleParameter("img", (object)imgData));
                command3.ExecuteNonQuery();
                MessageBox.Show("Account Created");

            }
        }

       /* private void OnMyNotificaton(object sender, OracleNotificationEventArgs eventArgs)
        {
            MessageBox.Show("Result set has changed", "Notification Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            DataRow detailRow = eventArgs.Details.Rows[0];
            string rowid = detailRow["Rowid"].ToString();
            string sqlUpdate = _insertQurey + "where rowid = \'" + rowid + "\'";



            for (int i = 1; i < eventArgs.Details.Rows.Count; i++)

            {

                detailRow = eventArgs.Details.Rows[i];

                rowid = detailRow["Rowid"].ToString();

                sqlUpdate = sqlUpdate + " or rowid = \'" + rowid + "\'";

            }
        }*/
    }
}
