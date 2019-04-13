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
    public partial class verifyJobSeekers : MetroForm
    {
        //public OracleDataReader rd;
       // public string  query = "select * from JOB_SEEKERS_TEMP";
        public string ConnectionString = "Data Source=localhost:1521/XE; User ID=adms; Password=adms";
        int pm_id;
        public verifyJobSeekers(int a)
        {
            pm_id = a;
            InitializeComponent();
        }

        private void verifyJobSeekers_Load(object sender, EventArgs e)
        {
            oracle.Connection_Query one = new oracle.Connection_Query();
            one.OpenConection();
            string query = "select * from JOB_SEEKERS_TEMP";
            OracleDataReader rd = one.DataReader(query);
            
            DataTable dt = new DataTable();
            dt.Load(rd);
            employers.DataSource = dt;
           
            one.CloseConnection();

        }

        private void approveJS_Click(object sender, EventArgs e)
        {
            bool status = false;
            int approve_id = Convert.ToInt32(validJS.Text);
            if (validJS.Text == string.Empty) { MessageBox.Show("Please insert an id"); }
            else
            {
                string _query = "select * from JS_USERS_TEMP where JS_ID=" + approve_id;
                oracle.Connection_Query two = new oracle.Connection_Query();
                two.OpenConection();
                two.ExecuteQueries(_query);
               /* try
                {
                    two.ExecuteQueries(_query);
                }catch(Exception ex) { status = true; MessageBox.Show("Error!!!"); }
                if (status == true)
                {*/
                    string trans_user = "insert into JS_USERS(JS_ID,JS_PASSWORD) select JS_ID, JS_PASSWORD from JS_USERS_TEMP where JS_ID=" + approve_id;
                    two.ExecuteQueries(trans_user);
                    string trans_image = "insert into JIMAGE(J_ID,J_IMAGE) select J_ID, J_IMAGE from JIMAGE_TEMP where J_ID=" + approve_id;
                    two.ExecuteQueries(trans_image);
                  string trans_data = "insert into JOB_SEEKERS(JS_ID,JS_NAME,JS_ADDRESS,JS_PHONE,JS_EMAIL,JS_DOB,JS_EDUCATION,JS_SKILLS) select JS_ID,JS_NAME,JS_ADDRESS,JS_PHONE,JS_EMAIL,JS_DOB,JS_EDUCATION,JS_SKILLS from JOB_SEEKERS_TEMP where JS_ID=" + approve_id;




                two.ExecuteQueries(trans_data);

                    string show = "select *from JS_USERS_TEMP where JS_ID=" + approve_id;
                    OracleDataReader dshow = two.DataReader(show);
                     DataTable tbl2 = new DataTable();
                     tbl2.Load(dshow);
                    string js_pass;
                     int js_id;
                     js_id = (int)tbl2.Rows[0][0];
                     js_pass = (string)tbl2.Rows[0][1];

                string q = "insert into APPROVE_HISTORY (JS_ID,JS_PASSWORD,PM_ID) values (:js_id,:js_pass,:pm_id)";
                OracleConnection con = new OracleConnection(ConnectionString);
                OracleCommand com = new OracleCommand(q, con);
                com.Parameters.Add(new OracleParameter("js_id", js_id));
                com.Parameters.Add(new OracleParameter("js_pass", js_pass));
                com.Parameters.Add(new OracleParameter("pm_id", pm_id));
                con.Open();
                com.ExecuteNonQuery();
                con.Close();


                string del_user = "DELETE from JS_USERS_TEMP WHERE JS_ID=" + approve_id;
                    two.ExecuteQueries(del_user);

                    string del_user_image = "DELETE from JIMAGE_TEMP WHERE J_ID=" + approve_id;
                    two.ExecuteQueries(del_user_image);

                    string del_user_data = "DELETE from JOB_SEEKERS_TEMP WHERE JS_ID=" + approve_id;
                    two.ExecuteQueries(del_user_data);
                


                two.CloseConnection();

                MessageBox.Show("Sucessfully approved");
                }
            }

        private void deleteJS_Click(object sender, EventArgs e)
        {
            if (idDeleteJS.Text == string.Empty) { MessageBox.Show("Please insert an id"); }
            else
            {
                //int id_delete = Convert.ToInt32(idDelete.Text);
                string delete_query = "DELETE from JOB_SEEKERS_TEMP WHERE JS_ID  = :ID";
                string delete_pass = "DELETE from JS_USERS_TEMP WHERE JS_ID  = :ID";
                string delete_image = "DELETE from JIMAGE_TEMP WHERE J_ID  = :ID";
                OracleConnection conn = new OracleConnection(ConnectionString);
                //delete details
                OracleCommand cmd = new OracleCommand(delete_query, conn);
                conn.Open();
                cmd.Parameters.Add(new OracleParameter("ID", Convert.ToInt32(idDeleteJS.Text)));
                cmd.ExecuteNonQuery();
                //delete details
                OracleCommand pass = new OracleCommand(delete_pass, conn);

                pass.Parameters.Add(new OracleParameter("ID", Convert.ToInt32(idDeleteJS.Text)));
                pass.ExecuteNonQuery();
                //delete details
                OracleCommand image = new OracleCommand(delete_image, conn);
                image.Parameters.Add(new OracleParameter("ID", Convert.ToInt32(idDeleteJS.Text)));
                image.ExecuteNonQuery();

                MessageBox.Show("Delete sucessfull");
                conn.Close();

            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            oracle.Connection_Query one = new oracle.Connection_Query();
            one.OpenConection();
            string query = "select * from JOB_SEEKERS_TEMP";
            OracleDataReader rd = one.DataReader(query);

            DataTable dt = new DataTable();
            dt.Load(rd);
            employers.DataSource = dt;

            one.CloseConnection();
        }

    }
    }

