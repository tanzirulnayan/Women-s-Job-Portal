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
    public partial class view : MetroForm
    {
        public string ConnectionString = "Data Source=localhost:1521/XE; User ID=adms; Password=adms";
        OracleConnection con;
        OracleCommand cmd;
        public view()
        {
            InitializeComponent();
        }

        private void view_Load(object sender, EventArgs e)
        {
            /* con = new OracleConnection(ConnectionString);
             cmd = new OracleCommand();
             cmd.Connection = con;
             con.Open();
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.CommandText = "SELECT * FROM EMPLOYER_CIRCULAR";
             OracleDataReader reader = cmd.ExecuteReader();
             DataTable dt = new DataTable();
             dt.Load(reader);

             empCircular.DataSource = dt;
             con.Close();*/
            string sql = "SELECT * FROM EMPLOYER_CIRCULAR";
            //string conStr = "Data Source=localhost:1521/XE; User ID=hr; Password=hr";
            OracleConnection con = new OracleConnection(ConnectionString);
            OracleCommand cmd = new OracleCommand(sql, con);
            con.Open();
            // DataTable dt = new DataTable(); 
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            empCircular.DataSource = dt;
        }
    }
}
