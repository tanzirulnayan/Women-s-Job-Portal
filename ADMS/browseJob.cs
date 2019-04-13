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

namespace ADMS
{
    public partial class browseJob : MetroForm
    {
        public string ConnectionString = "Data Source=localhost:1521/XE; User ID=adms; Password=adms";
        public OracleConnection con;
        public OracleCommand cmd;
        public int js_id;
        public string job_id;
        public int jobbb_id;
        public int jseek_id;
        oracle.Connection_Query one = new oracle.Connection_Query();

        public browseJob(int a)
        {
            js_id = a;
            InitializeComponent();
        }

        private void browseJob_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tp = "IT";
            string query = "SELECT * from JOB_CIRCULARS where JOB_TYPE =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            result.DataSource = dt;
            con.Close();
        }

        private void searchArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void business_Click(object sender, EventArgs e)
        {
            string tp = "Business";
            string query = "SELECT * from JOB_CIRCULARS where JOB_TYPE =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            result.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tp = "Medical";
            string query = "SELECT * from JOB_CIRCULARS where JOB_TYPE =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            result.DataSource = dt;
            con.Close();
        }

        private void chef_Click(object sender, EventArgs e)
        {
            string tp = "Chef";
            string query = "SELECT * from JOB_CIRCULARS where JOB_TYPE =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            result.DataSource = dt;
            con.Close();
        }

        private void Architecture_Click(object sender, EventArgs e)
        {
            string tp = "Architecture";
            string query = "SELECT * from JOB_CIRCULARS where JOB_TYPE =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            result.DataSource = dt;
            con.Close();
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            string tp = "Teacher";
            string query = "SELECT * from JOB_CIRCULARS where JOB_TYPE =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            result.DataSource = dt;
            con.Close();
        }

        private void lawer_Click(object sender, EventArgs e)
        {
            string tp = "Lawer";
            string query = "SELECT * from JOB_CIRCULARS where JOB_TYPE =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            result.DataSource = dt;
            con.Close();
        }

        private void receptionist_Click(object sender, EventArgs e)
        {
            string tp = "Receptionist";
            string query = "SELECT * from JOB_CIRCULARS where JOB_TYPE =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            result.DataSource = dt;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string tp = "Accounting";
            string query = "SELECT * from JOB_CIRCULARS where JOB_TYPE =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            result.DataSource = dt;
            con.Close();
        }

        private void electric_Click(object sender, EventArgs e)
        {
            string tp = "Electric Engineer";
            string query = "SELECT * from JOB_CIRCULARS where JOB_TYPE =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            result.DataSource = dt;
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void result_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow seelectedrow = result.Rows[index];
            j_id.Text = seelectedrow.Cells[0].Value.ToString();
            //job_id = seelectedrow.Cells[0].Value.ToString();
            title.Text = seelectedrow.Cells[1].Value.ToString();
            position.Text = seelectedrow.Cells[2].Value.ToString();
            nature.Text = seelectedrow.Cells[3].Value.ToString();
            type.Text = seelectedrow.Cells[4].Value.ToString();

            cgpa.Text = seelectedrow.Cells[5].Value.ToString();
            location.Text = seelectedrow.Cells[6].Value.ToString();
            salary.Text = seelectedrow.Cells[7].Value.ToString();


        }

        private void j_id_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            int c_id = Convert.ToInt32(j_id.Text);

            string show = "select *from VIEW_HISTORY where JS_ID=" + js_id;

            OracleConnection con = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand(show, con);
            con.Open();
            // DataTable dt = new DataTable(); 
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable tbl2 = new DataTable();
            if (reader.HasRows)
            {
                tbl2.Load(reader);
                jseek_id = (int)tbl2.Rows[0][0];
                jobbb_id = (int)tbl2.Rows[0][1];


                //int c_id = Convert.ToInt32(j_id.Text);
                if (c_id == jobbb_id && jseek_id == js_id) { MessageBox.Show("You Have already applied for this job"); }
                else
                {
                    string q = "insert into VIEW_HISTORY (JS_ID,C_ID) values (:pm_id,:pm_pass)";
                    con = new OracleConnection(ConnectionString);
                    cmd = new OracleCommand(q, con);
                    cmd.Parameters.Add(new OracleParameter("JS_ID", js_id));
                    cmd.Parameters.Add(new OracleParameter("C_ID", c_id));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucessfully Applied");
                    con.Close();
                }
            }else if (!reader.HasRows)
            {
                string q = "insert into VIEW_HISTORY (JS_ID,C_ID) values (:pm_id,:pm_pass)";
                con = new OracleConnection(ConnectionString);
                cmd = new OracleCommand(q, con);
                cmd.Parameters.Add(new OracleParameter("JS_ID", js_id));
                cmd.Parameters.Add(new OracleParameter("C_ID", c_id));
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sucessfully Applied");
                con.Close();

            }
        }

        private void result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
