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
    public partial class show : MetroForm
    {
        int id;
        public show(int a)
        {
            id = a;
            InitializeComponent();
        }

        private void show_Load(object sender, EventArgs e)
        {
            string circu = "select js.js_id, js.js_name, js.js_address, js.js_phone, js.js_email, js.js_dob, js.js_education, js.js_skills, jc.c_id, jc.c_title FROM view_history vh, job_circulars jc, job_seekers js WHERE vh.c_id = jc.c_id AND vh.js_id = js.js_id AND jc.e_id =" + id;
            oracle.Connection_Query one = new oracle.Connection_Query();
            one.OpenConection();

            OracleDataReader rd = one.DataReader(circu);

            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;

            one.CloseConnection();

        }
    }
}
