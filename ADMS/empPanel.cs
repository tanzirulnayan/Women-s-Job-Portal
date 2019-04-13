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
using System.IO;

namespace ADMS
{
    public partial class empPanel : MetroForm
    {
        public int id;
        private string e_name;
        private string e_add;
        private string e_email;
        private string e_web;
        private Form e_panel = new Form();
        oracle.Connection_Query one = new oracle.Connection_Query();
        public Form getForm
        {
            get { return e_panel; }
            set { e_panel = value; }
        }
        public empPanel(int a)
        {
            one.OpenConection();
            id = a;
            InitializeComponent();
        }

        private void empPanel_Load(object sender, EventArgs e)
        {
            string query = "select *from EMP_IMAGE where E_ID=" + id;
            OracleDataReader rd = one.DataReader(query);
            DataTable tbl = new DataTable();
            tbl.Load(rd);
            byte[] imgData = (byte[])tbl.Rows[0][1];
            MemoryStream ms = new MemoryStream();
            ms.Write(imgData, 0, imgData.Length);
            Bitmap bmp = new Bitmap(ms, false);
            empPictureBox.Image = bmp;
            ms.Dispose();

            string show = "select *from EMPLOYERS where E_ID=" + id;
            OracleDataReader dshow = one.DataReader(show);
            DataTable tbl2 = new DataTable();
            tbl2.Load(dshow);
            e_name = (string)tbl2.Rows[0][1];
            e_add = (string)tbl2.Rows[0][2];
            e_email = (string)tbl2.Rows[0][4];
            e_web = (string)tbl2.Rows[0][5];
            idShow.Text = Convert.ToString(id);
            nameShow.Text = e_name;
            addressShow.Text = e_add;
            emailShow.Text = e_email;
            webShow.Text = e_web;
            name.Text = e_name;




        }

        private void webShow_Click(object sender, EventArgs e)
        {

        }

        private void nameShow_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uploadCircular_Click(object sender, EventArgs e)
        {
            uploadCircular uc = new uploadCircular(id);
            uc.ShowDialog();
        }

        private void searchJS_Click(object sender, EventArgs e)
        {
            browseJS bjs = new browseJS();
            bjs.ShowDialog();
        }

        private void updateProfile_Click(object sender, EventArgs e)
        {
            updateEmployee upemp = new updateEmployee(id);
            upemp.ShowDialog();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showCircular_Click(object sender, EventArgs e)
        {
            show sh = new show(id);
            sh.ShowDialog();

        }
    }
}
