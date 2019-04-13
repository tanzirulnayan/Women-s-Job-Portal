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
using System.Data.OracleClient;

namespace ADMS
{
    public partial class recoveryPass : MetroForm
    {
        public string ConnectionString = "Data Source=localhost:1521/XE; User ID=adms; Password=adms";
        public OracleConnection con;
        public OracleCommand cmd;
        public string empPass;
        public string jspass;
        public recoveryPass()
        {
            InitializeComponent();
        }

        private void recoveryPass_Load(object sender, EventArgs e)
        {

        }

        private void empName_Click(object sender, EventArgs e)
        {

        }

        private void showPass_Click(object sender, EventArgs e)
        {

        }

        private void showPassButton_Click(object sender, EventArgs e)
        {

            //Package with OUT_CURSOR start
            con = new OracleConnection(ConnectionString);
            con.Open();
            DataSet ds = new DataSet();
            cmd = new OracleCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "emp_pass_pkg.GetPass";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("eid_no", OracleType.Int32).Value = Convert.ToInt32(empID.Text);
            cmd.Parameters.Add("e_ref", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);
            DataTable tbl = ds.Tables[0];
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                DataRow myRow = tbl.Rows[i];
                empPass = myRow["E_PASSWORD"].ToString();
                //// getting the value from column DNAME
            }
            showPass.Text = empPass;
            //Package with OUT_CURSOR End
        }

        private void showPassJS_Click(object sender, EventArgs e)
        {
            //Package with OUT_CURSOR start
            con = new OracleConnection(ConnectionString);
            con.Open();
            DataSet ds = new DataSet();
            cmd = new OracleCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = "js_pass_pkg.GetPass";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("jsid_no", OracleType.Int32).Value = Convert.ToInt32(jsID.Text);
            cmd.Parameters.Add("e_ref", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);
            DataTable tbl = ds.Tables[0];
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                DataRow myRow = tbl.Rows[i];
                jspass = myRow["JS_PASSWORD"].ToString();
                //// getting the value from column DNAME
            }
            jsshowpass.Text = jspass;
            //Package with OUT_CURSOR End
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
