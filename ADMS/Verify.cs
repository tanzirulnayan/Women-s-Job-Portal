using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.DataAccess.Types;

namespace ADMS
{
    public partial class Verify : MetroForm
    {
        public string ConnectionString = "Data Source=localhost:1521/XE; User ID=adms; Password=adms";
        //public string command01 = "insert into EMPLOYERS (E_ID, E_NAME, E_ADDRESS, E_IMAGE, E_EMAIL, E_WEBSITE) VALUES (:id, :e_name, :e_add, :e_image, :e_email, :e_web)";
        // oracle.Connection_Query one = new oracle.Connection_Query();
        //public string command = "insert into E_USERS(E_ID,E_PASSWORD) VALUES (:id,:password)";
        public int iddd;
        public Verify(int a)
        {
            iddd = a;
            InitializeComponent();
        }

        private void Verify_Load(object sender, EventArgs e)
        {
            oracle.Connection_Query one = new oracle.Connection_Query();
            one.OpenConection();
            string query = "select * from EMPLOYERS_TEMP";
            OracleDataReader rd = one.DataReader(query);
            DataTable dt = new DataTable();
            dt.Load(rd);
            employers.DataSource = dt;
            one.CloseConnection();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(idDelete.Text == string.Empty) { MessageBox.Show("Please insert an id"); }
            else
            {
                //int id_delete = Convert.ToInt32(idDelete.Text);
                string delete_query = "DELETE from EMPLOYERS_TEMP WHERE E_ID  = :ID";
                string delete_pass = "DELETE from E_USERS_TEMP WHERE E_ID  = :ID";
                string delete_image = "DELETE from EMP_IMAGE_TEMP WHERE E_ID  = :ID";
                OracleConnection conn = new OracleConnection(ConnectionString);
                //delete details
                OracleCommand cmd = new OracleCommand(delete_query, conn);
                conn.Open();
                cmd.Parameters.Add(new OracleParameter("ID", Convert.ToInt32(idDelete.Text)));
                cmd.ExecuteNonQuery();
                //delete details
                OracleCommand pass = new OracleCommand(delete_pass, conn);
               
                pass.Parameters.Add(new OracleParameter("ID", Convert.ToInt32(idDelete.Text)));
                pass.ExecuteNonQuery();
                //delete details
                OracleCommand image = new OracleCommand(delete_image, conn);
                image.Parameters.Add(new OracleParameter("ID", Convert.ToInt32(idDelete.Text)));
                image.ExecuteNonQuery();

                MessageBox.Show("Delete sucessfull");
                conn.Close();

            }
        }

        private void Approve_Click(object sender, EventArgs e)
        {
            int approve_id;
            string password;
            int id;
            if (valid.Text == string.Empty) { MessageBox.Show("Please insert an id"); }
            else
            {
                approve_id = Convert.ToInt32(valid.Text);
                string _query = "select * from E_USERS_TEMP where E_ID=" + approve_id;
                oracle.Connection_Query two = new oracle.Connection_Query();
                two.OpenConection();
                OracleDataReader zz = two.DataReader(_query);
                DataTable tbl1 = new DataTable();
                tbl1.Load(zz);
                id = (int)tbl1.Rows[0][0];
                password = (string)tbl1.Rows[0][1];
                two.CloseConnection();

               var command = "insert into E_USERS(E_ID,E_PASSWORD) VALUES (:id,:password)";
                OracleConnection connection = new OracleConnection(ConnectionString);
                OracleCommand cmd = new OracleCommand(command, connection);
                cmd.Parameters.Add(new OracleParameter("id", id));
                cmd.Parameters.Add(new OracleParameter("password", password));
                connection.Open();
                /*cmd.AddRowid = true;
                OracleDependency dep = new OracleDependency(cmd);
                cmd.Notification.IsNotifiedOnce = false;
                dep.OnChange += new OnChangeEventHandler(OnMyNotificaton);*/
                cmd.ExecuteNonQuery();
                connection.Close();

                string image = "select * from EMP_IMAGE_TEMP where E_ID=" + approve_id;
                two.OpenConection();
                OracleDataReader im = two.DataReader(image);
                DataTable tbl2 = new DataTable();
                tbl2.Load(im);
                byte[] imgData = (byte[])tbl2.Rows[0][1];
                var command0 = "insert into EMP_IMAGE(E_ID,E_IMAGE) VALUES (:id,:image)";
                
                OracleConnection eight = new OracleConnection(ConnectionString);
                
                OracleCommand cmd0 = new OracleCommand(command0, eight);
                cmd0.Parameters.Add(new OracleParameter("id", id));
                cmd0.Parameters.Add(new OracleParameter("image", (object)imgData));
                eight.Open();
                cmd0.ExecuteNonQuery();
                eight.Close();
               
                oracle.Connection_Query five = new oracle.Connection_Query();
                string info = "select *from EMPLOYERS_TEMP where E_ID=" + approve_id;
                five.OpenConection();
                OracleDataReader dshow = five.DataReader(info);
                DataTable tbl3 = new DataTable();
                tbl3.Load(dshow);
               string  e_name = (string)tbl3.Rows[0][0];
               string e_add = (string)tbl3.Rows[0][1];
               string e_image = (string)tbl3.Rows[0][2];
                string e_email = (string)tbl3.Rows[0][3];
                string e_web = (string)tbl3.Rows[0][4];
                five.CloseConnection();
                //insert into main
              var command01 = "insert into EMPLOYERS (E_ID, E_NAME, E_ADDRESS, E_IMAGE, E_EMAIL, E_WEBSITE) VALUES (:id, :e_name, :e_add, :e_image, :e_email, :e_web)";
                OracleConnection _con = new OracleConnection(ConnectionString);
                OracleCommand cmd01 = new OracleCommand(command01, _con);
                cmd01.Parameters.Add(new OracleParameter("id", approve_id));
                cmd01.Parameters.Add(new OracleParameter("e_name", e_name));
                cmd01.Parameters.Add(new OracleParameter("e_add", e_add));
                cmd01.Parameters.Add(new OracleParameter("e_image", e_image));
                cmd01.Parameters.Add(new OracleParameter("e_email", e_email));
                cmd01.Parameters.Add(new OracleParameter("e_web", e_web));
                _con.Open();

               /* cmd01.AddRowid = true;
                OracleDependency dep = new OracleDependency(cmd01);
                cmd01.Notification.IsNotifiedOnce = false;
                dep.OnChange += new OnChangeEventHandler(OnMyNotificaton);*/
                cmd01.ExecuteNonQuery();



                cmd01.ExecuteNonQuery();
                _con.Close();


                string show = "select *from EMPLOYERS_TEMP where E_ID=" + approve_id;
                OracleDataReader app = two.DataReader(show);
                DataTable tbl6 = new DataTable();
                tbl6.Load(app);
                string ap_pass;
                int ap_int;
                
                //ap_pass = (string)tbl6.Rows[0][1];

                string q = "insert into VERIFY_HISTORY (E_ID,E_PASSWORD,PM_ID) values (:id,:ap_pass,:iddd)";
                OracleConnection con = new OracleConnection(ConnectionString);
                OracleCommand com = new OracleCommand(q, con);
                com.Parameters.Add(new OracleParameter("id", approve_id));
                com.Parameters.Add(new OracleParameter("ap_pass", password));
                com.Parameters.Add(new OracleParameter("iddd", iddd));
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sucessfully inserted");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            oracle.Connection_Query one = new oracle.Connection_Query();
            one.OpenConection();
            string query = "select * from EMPLOYERS_TEMP";
            OracleDataReader rd = one.DataReader(query);

            DataTable dt = new DataTable();
            dt.Load(rd);
            employers.DataSource = dt;

            one.CloseConnection();
        }

        /* private void OnMyNotificaton(object sender, OracleNotificationEventArgs eventArgs)
         {
             MessageBox.Show("Result set has changed", "Notification Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             DataRow detailRow = eventArgs.Details.Rows[0];
             string rowid = detailRow["Rowid"].ToString();
             string sqlUpdate = command01 + "where rowid = \'" + rowid + "\'";



             for (int i = 1; i < eventArgs.Details.Rows.Count; i++)

             {

                 detailRow = eventArgs.Details.Rows[i];

                 rowid = detailRow["Rowid"].ToString();

                 sqlUpdate = sqlUpdate + " or rowid = \'" + rowid + "\'";

             }
         }*/
    }
}
