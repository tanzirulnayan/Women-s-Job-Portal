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
    public partial class jobSeeker : MetroForm
    {
        private int js_id;
        private string js_name;
        private string js_pass;
        private string js_add;
        private string js_image;
        private string js_email;
        private int js_phone;
        private string js_skill;
        private string js_education;
        private string js_dob;
        public string ConnectionString = "Data Source=localhost:1521/XE; User ID=adms; Password=adms";
        //public string q = "insert into JS_USERS_TEMP (JS_ID,JS_PASSWORD) values (:js_id,:js_pass)";
        public jobSeeker()
        {
            InitializeComponent();
        }

        private void jobSeeker_Load(object sender, EventArgs e)
        {
            OracleConnection generate = new OracleConnection(ConnectionString);
            generate.Open();
            OracleCommand gCmd = generate.CreateCommand();
            gCmd.CommandType = CommandType.Text;
            gCmd.CommandText = "select JS_ID_SEQ.nextval from dual";
            int lnNextVal = Convert.ToInt32(gCmd.ExecuteScalar());
            IdBox.Text = Convert.ToString(lnNextVal);
            generate.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
                string q = "insert into JS_USERS_TEMP (JS_ID,JS_PASSWORD) values (:js_id,:js_pass)";
                OracleConnection con = new OracleConnection(ConnectionString);
                OracleCommand com = new OracleCommand(q, con);
                com.Parameters.Add(new OracleParameter("js_id", Convert.ToInt32(IdBox.Text)));
                com.Parameters.Add(new OracleParameter("js_pass", passBox.Text));
                con.Open();

               /* com.AddRowid = true;
                OracleDependency dep = new OracleDependency(com);
                com.Notification.IsNotifiedOnce = false;
                dep.OnChange += new OnChangeEventHandler(OnMyNotificaton);
                */


                com.ExecuteNonQuery();






                string _insertQurey = "INSERT INTO JOB_SEEKERS_TEMP (JS_ID,JS_NAME, JS_ADDRESS, JS_PHONE, JS_EMAIL, JS_DOB,JS_EDUCATION,JS_SKILLS,JS_IMAGE)  VALUES (:js_id,:js_name,:js_add,:js_phone,:js_email,:js_dob,:js_education,:js_skill,:js_image)";
                //OracleConnection connection = new OracleConnection(ConnectionString);
                OracleCommand command2 = new OracleCommand(_insertQurey, con);

                command2.Parameters.Add(new OracleParameter("js_id", Convert.ToInt32(IdBox.Text)));
                command2.Parameters.Add(new OracleParameter("js_name", nameBox.Text));
                command2.Parameters.Add(new OracleParameter("js_add", addressBox.Text));
                command2.Parameters.Add(new OracleParameter("js_phone", Convert.ToInt32(phoneBox.Text)));
                command2.Parameters.Add(new OracleParameter("js_email", emailBox.Text));
                command2.Parameters.Add(new OracleParameter("js_dob", dateTimePicker1.Value.Date));
                command2.Parameters.Add(new OracleParameter("js_education", eduBox.Text));
                command2.Parameters.Add(new OracleParameter("js_skill", skillBox.Text));
                command2.Parameters.Add(new OracleParameter("js_image", IdBox.Text));
                // command2.Parameters.Add(new OracleParameter("js_image",IdBox.Text));
                // command.Connection.ExecuteQueries(_insertQurey);
                // connection.Open();
                command2.ExecuteNonQuery();
                // connection.Close();


                //Image Save
                FileStream fs = new FileStream(textPath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                FileInfo fi = new FileInfo(textPath.Text);
                byte[] imgData = br.ReadBytes((int)fi.Length);
                fs.Close();
                br.Close();

                string _query = "insert into JIMAGE_TEMP values (:js_id,:img)";
                // OracleConnection connection = two.returnConn();
                OracleCommand command3 = new OracleCommand(_query, con);
                command3.Parameters.Add(new OracleParameter("js_id", IdBox.Text));
                command3.Parameters.Add(new OracleParameter("img", (object)imgData));
                command3.ExecuteNonQuery();
                MessageBox.Show("Account Created");

            }
        }

        /*private void OnMyNotificaton(object sender, OracleNotificationEventArgs eventArgs)
        {

            MessageBox.Show("Result set has changed", "Notification Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            DataRow detailRow = eventArgs.Details.Rows[0];
            string rowid = detailRow["Rowid"].ToString();
            string sqlUpdate = q + "where rowid = \'" + rowid + "\'";

            

            for (int i = 1; i < eventArgs.Details.Rows.Count; i++)

            {

                detailRow = eventArgs.Details.Rows[i];

                rowid = detailRow["Rowid"].ToString();

                sqlUpdate = sqlUpdate + " or rowid = \'" + rowid + "\'";

            }
        }*/


    }
    }

