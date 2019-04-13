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
using System.Configuration;
using Oracle.DataAccess.Types;
using System.IO;


namespace ADMS
{
    public partial class emp : MetroForm
    {
        private int e_id;
        private string e_name;
        private string e_pass;
        private string e_add;
        private int e_image;
        private string e_email;
        private string e_web;
        public string ConnectionString = "Data Source=localhost:1521/XE; User ID=adms; Password=adms";
        // oracle.Connection_Query two = new oracle.Connection_Query();


        public emp()
        {

            //two.OpenConection();
            InitializeComponent();
        }

        private void emp_Load(object sender, EventArgs e)
        {
           // int generate_id;
            OracleConnection generate = new OracleConnection(ConnectionString);
            generate.Open();
            OracleCommand gCmd = generate.CreateCommand();
            gCmd.CommandType = CommandType.Text;
            gCmd.CommandText = "select E_ID_SEQ.nextval from dual";
            int lnNextVal = Convert.ToInt32(gCmd.ExecuteScalar());
            generateId.Text = Convert.ToString(lnNextVal);
            generate.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          ;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* string connectionString = "Data Source=localhost:1521/XE; User ID=cba; Password=cba";
              string commmandText = "INSERT INTO employers (E_ID, E_NAME, E_ADDRESS, E_IMAGE, E_EMAIL, E_WEBSITE) VALUES (:e_idd, :e_namee, :e_addd, :e_phonee, :e_emaill, :e_weBB)";
              using (OracleConnection connection = new OracleConnection(connectionString))

                  using (OracleCommand command = new OracleCommand(commmandText, connection))
                  {
                  command.Parameters.Add(new OracleParameter("e_idd", textBox1.Text));
                  command.Parameters.Add(new OracleParameter("e_namee", textBox2.Text));
                  command.Parameters.Add(new OracleParameter("e_addd", textBox3.Text));
                  command.Parameters.Add(new OracleParameter("e_phonee", textBox4.Text));
                  command.Parameters.Add(new OracleParameter("e_emaill", textBox5.Text));
                  command.Parameters.Add(new OracleParameter("e_weBB", textBox6.Text));
                  connection.Open();
                  command.ExecuteNonQuery();
                  connection.Close();


              }*/


                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select *from EMPLOYERS";
            string conStr = "Data Source=localhost:1521/XE; User ID=adms; Password=adms";
            OracleConnection con = new OracleConnection(conStr);
            OracleCommand cmd = new OracleCommand(sql, con);
            con.Open();
            // DataTable dt = new DataTable(); 
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            //dataGridView1.DataSource = dt;
            con.Close();
            //dataGridView1.DataBind();*/
        }

        private void empPass_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog picture = new OpenFileDialog();
            picture.ShowDialog();
            textPath.Text = picture.FileName;
        }

      /*  private void saveImg_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(textPath.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            FileInfo fi = new FileInfo(textPath.Text);
            byte[] imgData = br.ReadBytes((int)fi.Length);
            fs.Close();
            br.Close();

            string _query = "insert into emp_image (E_ID,E_IMAGE) values (e_id,img)";
            OracleConnection connection = two.returnConn();
           OracleCommand command = new OracleCommand(_query, connection);
            command.Parameters.Add(new OracleParameter("e_id", empId.Text));
            command.Parameters.Add(new OracleParameter("img", (object)imgData));
           two.ExecuteQueries(_query);

        }*/

        private void emPass_Click(object sender, EventArgs e)
        {

        }

        private void empSignUpButton_Click(object sender, EventArgs e)
        {


            if (emPass.Text != empRePass.Text) { MessageBox.Show("Correct your password"); }
            else
            {



                string q = "insert into E_USERS_TEMP (E_ID,E_PASSWORD) values (:e_id,:e_pass)";
                OracleConnection con = new OracleConnection(ConnectionString);
                OracleCommand com = new OracleCommand(q, con);
                com.Parameters.Add(new OracleParameter("e_id", Convert.ToInt32(empId.Text)));
                com.Parameters.Add(new OracleParameter("e_pass", emPass.Text));
                con.Open();
                com.ExecuteNonQuery();






                string _insertQurey = "INSERT INTO EMPLOYERS_TEMP (E_ID,E_NAME, E_ADDRESS, E_IMAGE, E_EMAIL, E_WEBSITE)  VALUES (:e_id,:e_name, :e_add, :e_image, :e_email, :e_web)";
                //OracleConnection connection = new OracleConnection(ConnectionString);
                OracleCommand command2 = new OracleCommand(_insertQurey, con);

                command2.Parameters.Add(new OracleParameter("e_id", Convert.ToInt32(empId.Text)));
                command2.Parameters.Add(new OracleParameter("e_name", empName.Text));
                command2.Parameters.Add(new OracleParameter("e_add", empAdd.Text));
                command2.Parameters.Add(new OracleParameter("e_image", Convert.ToInt32(empId.Text)));
                command2.Parameters.Add(new OracleParameter("e_email", empEmail.Text));
                command2.Parameters.Add(new OracleParameter("e_web", empWeb.Text));
                // command.Connection.ExecuteQueries(_insertQurey);
                // connection.Open();
                command2.ExecuteNonQuery();
                // connection.Close();


                //Image Save
                FileStream fs = new FileStream(textPath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                FileInfo fi = new FileInfo(textPath.Text);
                byte[] imgData = br.ReadBytes((int)fi.Length);
                fs.Close();
                br.Close();

                string _query = "insert into EMP_IMAGE_TEMP values (:e_id,:img)";
                // OracleConnection connection = two.returnConn();
                OracleCommand command3 = new OracleCommand(_query, con);
                 command3.Parameters.Add(new OracleParameter("e_id", empId.Text));
                 command3.Parameters.Add(new OracleParameter("img", (object)imgData));
                command3.ExecuteNonQuery();
                MessageBox.Show("Signup Sucessfully");
                Close();
            }
        }
    }
}
