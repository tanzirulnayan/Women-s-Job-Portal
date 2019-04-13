using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.DataAccess.Types;
using ADMS;

namespace ADMS
{
    public partial class logIn : MetroForm
    {
        private int user_id;
        private string pass;
        oracle.Connection_Query one = new oracle.Connection_Query();
       
        
        public logIn()
        {
            one.OpenConection();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void portalModarator_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void jobSeeker_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            universal uni = new universal();
            uni.getForm = this;
            this.Hide();
            uni.ShowDialog();
            Close();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            user_id = Convert.ToInt32(userIdBox.Text);
            pass = passBox.Text;
            //employee log_in Start
            if(employee.Checked == true && (portalModarator.Checked == false && jobSeeker.Checked == false))
            {
                string query = "select E_PASSWORD from E_USERS where E_ID='" + user_id + "'";
                OracleDataReader dr = one.DataReader(query);
                if (!dr.HasRows)
                {
                    MessageBox.Show("Invalid User");
                    userIdBox.Clear();
                    passBox.Clear();
                    
                }
                else
                {
                    dr.Read();
                    string password = dr.GetString(0);
                    if (pass.Equals(password))
                    {
                        empPanel one = new empPanel(user_id);
                        one.getForm = this;
                        this.Hide();
                        one.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                }
            }
            //Portal_modarator log_in start
            else if(portalModarator.Checked == true && (employee.Checked == false && jobSeeker.Checked == false))
            {
                string query = "select PM_PASSWORD from PM_USERS where PM_ID='" + user_id + "'";
                OracleDataReader dr = one.DataReader(query);
                if (!dr.HasRows)
                {
                    MessageBox.Show("Invalid User");
                    userIdBox.Clear();
                    passBox.Clear();

                }
                else
                {
                    dr.Read();
                    string password = dr.GetString(0);
                    if (pass.Equals(password))
                    {
                        pmPanel one = new pmPanel(user_id);
                        one.getForm = this;
                        this.Hide();
                        one.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                }
            }
            //Job_Seeker log_in start
            else if(jobSeeker.Checked == true && (employee.Checked == false && portalModarator.Checked == false))
            {
                string query = "select JS_PASSWORD from JS_USERS where JS_ID='" + user_id + "'";
                OracleDataReader dr = one.DataReader(query);
                if (!dr.HasRows)
                {
                    MessageBox.Show("Invalid User");
                    userIdBox.Clear();
                    passBox.Clear();

                }
                else
                {
                    dr.Read();
                    string password = dr.GetString(0);
                    if (pass.Equals(password))
                    {
                        jobseekerPanel one = new jobseekerPanel(user_id);
                        one.getForm = this;
                        this.Hide();
                        one.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                }
            }
        }
    }
}
