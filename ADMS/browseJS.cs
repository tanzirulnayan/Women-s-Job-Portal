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
    public partial class browseJS : MetroForm
    {
        public string ConnectionString = "Data Source=localhost:1521/XE; User ID=adms; Password=adms";
        public OracleConnection con;
        public OracleCommand cmd;
        public browseJS()
        {
            InitializeComponent();
        }

        private void browseJS_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tp = "Electronics";
            string query = "SELECT * from JOB_SEEKERS where JS_SKILLS =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            job.DataSource = dt;
            con.Close();
        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {
                    }

        private void programming_Click(object sender, EventArgs e)
        {
            string tp = "Programming";
            string query = "SELECT * from JOB_SEEKERS where JS_SKILLS =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            job.DataSource = dt;
            con.Close();
        }

        private void business_Click(object sender, EventArgs e)
        {
            string tp = "Business";
            string query = "SELECT * from JOB_SEEKERS where JS_SKILLS =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            job.DataSource = dt;
            con.Close();
        }

        private void medical_Click(object sender, EventArgs e)
        {
            string tp = "Medical";
            string query = "SELECT * from JOB_SEEKERS where JS_SKILLS =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            job.DataSource = dt;
            con.Close();
        }

        private void chef_Click(object sender, EventArgs e)
        {
            string tp = "Chef";
            string query = "SELECT * from JOB_SEEKERS where JS_SKILLS =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            job.DataSource = dt;
            con.Close();
        }

        private void Architecture_Click(object sender, EventArgs e)
        {
            string tp = "Architecture";
            string query = "SELECT * from JOB_SEEKERS where JS_SKILLS =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            job.DataSource = dt;
            con.Close();
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            string tp = "Teacher";
            string query = "SELECT * from JOB_SEEKERS where JS_SKILLS =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            job.DataSource = dt;
            con.Close();
        }

        private void lawer_Click(object sender, EventArgs e)
        {
            string tp = "Lawer";
            string query = "SELECT * from JOB_SEEKERS where JS_SKILLS =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            job.DataSource = dt;
            con.Close();
        }

        private void receptionist_Click(object sender, EventArgs e)
        {
            string tp = "Receptionist";
            string query = "SELECT * from JOB_SEEKERS where JS_SKILLS =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            job.DataSource = dt;
            con.Close();
        }

        private void accounting_Click(object sender, EventArgs e)
        {
            string tp = "Accounting";
            string query = "SELECT * from JOB_SEEKERS where JS_SKILLS =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            job.DataSource = dt;
            con.Close();
        }

        private void it_Click(object sender, EventArgs e)
        {
            string tp = "IT";
            string query = "SELECT * from JOB_SEEKERS where JS_SKILLS =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            job.DataSource = dt;
            con.Close();
        }

        private void network_Click(object sender, EventArgs e)
        {
            string tp = "Networking";
            string query = "SELECT * from JOB_SEEKERS where JS_SKILLS =:type";
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand(query, con);
            con.Open();
            cmd.Parameters.Add(new OracleParameter("type", tp));
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            job.DataSource = dt;
            con.Close();
        }

        private void job_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow seelectedrow = job.Rows[index];
            name.Text = seelectedrow.Cells[1].Value.ToString();
            address.Text = seelectedrow.Cells[2].Value.ToString();
            phone.Text = seelectedrow.Cells[3].Value.ToString();
            email.Text = seelectedrow.Cells[4].Value.ToString();
            education.Text = seelectedrow.Cells[5].Value.ToString();
            skill.Text = seelectedrow.Cells[6].Value.ToString();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void uploadCircular_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

