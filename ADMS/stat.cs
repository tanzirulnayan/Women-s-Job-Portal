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
    public partial class stat : MetroForm
    {
        public string ConnectionString = "Data Source=localhost:1521/XE; User ID=adms; Password=adms";
        OracleConnection con;
        OracleCommand cmd;
        public stat()
        {
            InitializeComponent();
        }

        private void stat_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "TOTALEMPLOYERS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("return_value", OracleType.Int32).Direction = ParameterDirection.ReturnValue;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                int val = (int)cmd.Parameters["return_value"].Value;
                totalemp.Text = Convert.ToString(val);
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Error");
            }

            //totalJobSeekers
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "TOTALJOBSEEKERS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("return_value", OracleType.Int32).Direction = ParameterDirection.ReturnValue;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                int val = (int)cmd.Parameters["return_value"].Value;
                totalJS.Text = Convert.ToString(val);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error");
            }

            //totalPortalModerators

            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "TOTALPORTALMODERATORS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("return_value", OracleType.Int32).Direction = ParameterDirection.ReturnValue;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                int val = (int)cmd.Parameters["return_value"].Value;
                totalPM.Text = Convert.ToString(val);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error");
            }

            //totalCirculars
            con = new OracleConnection(ConnectionString);
            cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "TOTALCIRCULARS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("return_value", OracleType.Int32).Direction = ParameterDirection.ReturnValue;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                int val = (int)cmd.Parameters["return_value"].Value;
                totalCircular.Text = Convert.ToString(val);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error");
            }

        }
    }
}
