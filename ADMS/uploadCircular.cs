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
using System.IO;


namespace ADMS
{

    public partial class uploadCircular : MetroForm
    {
        private int e_id;
        private string job_type;
        private string job_nature;
        private string job_location;
        public string ConnectionString = "Data Source=localhost:1521/XE; User ID=adms; Password=adms";

        public uploadCircular(int a)
        {
            e_id = a;
            InitializeComponent();
        }

        private void uploadCircular_Load(object sender, EventArgs e)
        {
            OracleConnection generate = new OracleConnection(ConnectionString);
            generate.Open();
            OracleCommand gCmd = generate.CreateCommand();
            gCmd.CommandType = CommandType.Text;
            gCmd.CommandText = "select C_ID_SEQ.nextval from dual";
            int lnNextVal = Convert.ToInt32(gCmd.ExecuteScalar());
            c_id.Text = Convert.ToString(lnNextVal);
            generate.Close();
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }



        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {

            if (c_id.Text == string.Empty || metroTextBox1.Text == string.Empty || c_position.Text == string.Empty || c_cgpa.Text == string.Empty || c_salary.Text == string.Empty) { MessageBox.Show("Please fill up all field"); }
            else
            {

                //Job_Type value
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        job_type = job_type + checkedListBox1.Items[i].ToString();
                        break;

                    }
                }//Job_Type value end

                //Job_Nature value
                for (int i = 0; i < checkedListBox2.Items.Count; i++)
                {
                    if (checkedListBox2.GetItemChecked(i))
                    {
                        job_nature = job_nature + checkedListBox2.Items[i].ToString();
                        break;

                    }
                }//Job_Nature value end

                //Job_Location value
                for (int i = 0; i < checkedListBox3.Items.Count; i++)
                {
                    if (checkedListBox3.GetItemChecked(i))
                    {
                        job_location = job_location + checkedListBox3.Items[i].ToString();
                        break;

                    }
                }//Job_Location value end


                  string _insertQurey = "INSERT INTO JOB_CIRCULARS (C_ID,C_TITLE,J_POSITION,JOB_NATURE,JOB_TYPE,CGPA_REQ,JOB_LOCATION,SALARY,E_ID)  VALUES (:job_id,:job_title,:job_position,:job_nature,:job_type,:c_cgpa,:job_location,:job_salary,:e_id)";

                  OracleConnection con = new OracleConnection(ConnectionString);
                  con.Open();
                  //OracleConnection connection = new OracleConnection(ConnectionString);
                  OracleCommand command2 = new OracleCommand(_insertQurey, con);
               
              

                command2.Parameters.Add(new OracleParameter("job_id", Convert.ToInt32(c_id.Text)));
                command2.Parameters.Add(new OracleParameter("job_title", metroTextBox1.Text));
                command2.Parameters.Add(new OracleParameter("job_position", c_position.Text));
                command2.Parameters.Add(new OracleParameter("job_nature", job_nature));
                command2.Parameters.Add(new OracleParameter("job_type", job_type));
                command2.Parameters.Add(new OracleParameter("c_cgpa", Convert.ToDecimal(c_cgpa.Text)));
                command2.Parameters.Add(new OracleParameter("job_location", job_location));
                command2.Parameters.Add(new OracleParameter("job_salary", Convert.ToInt32(c_salary.Text)));
                command2.Parameters.Add(new OracleParameter("e_id", e_id));
                command2.ExecuteNonQuery();
                MessageBox.Show("Uploaded");
                job_type = ""; job_nature = ""; job_location = "";

            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkedListBox1.CheckedItems.Count > 1)
            {
                MessageBox.Show("Please select only one");
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox2.CheckedItems.Count > 1)
            {
                MessageBox.Show("Please select only one");
            }
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox3.CheckedItems.Count > 1)
            {
                MessageBox.Show("Please select only one");
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

