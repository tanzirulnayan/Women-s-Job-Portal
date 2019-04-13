using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace ADMS
{
    class oracle
    {
        public class Connection_Query
        {


            public OracleConnection con = null;
            public string ConnectionString = "Data Source=localhost:1521/XE; User ID=adms; Password=adms";


            public void OpenConection()
            {
                con = new OracleConnection(ConnectionString);
                try { con.Open(); }
                catch (Exception expr) { }
            }
            public OracleConnection returnConn()
            {
                con = new OracleConnection(ConnectionString);
                try { con.Open(); return con; }
                catch (Exception expr) { return con; }

            }


            public void CloseConnection()
            {
                con.Close();
            }


            public void ExecuteQueries(string Query_)
            {
                OracleCommand cmd = new OracleCommand(Query_, con);
                cmd.ExecuteNonQuery();
                
            }

            public OracleDataReader DataReader(string Query_)
            {
                OracleCommand cmd = new OracleCommand(Query_, con);
                OracleDataReader dr = cmd.ExecuteReader();
                return dr;
            }


            /* public object ShowDataInGridView(string Query_)
             {
                 OracleDataAdapter dr = new OracleDataAdapter(Query_, ConnectionString);
                 DataTable ds = new DataTable();
                 dr.Fill(ds);
                 object dataum = ds.Tables[0];
                 return dataum;
             }*/
        }
    }
}
