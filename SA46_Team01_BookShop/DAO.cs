using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace SA46Team01WNET
{
    public class DAO
    {
        string Cons;
        SqlConnection cn;
        public DAO()
        {
            Cons = "data source = TAZ-PC\\MSSQLSERVER2017; integrated security = SSPI; database = SA46Team01WNET";
            cn = new SqlConnection(Cons);
        }
        public DataSet Query(string command)
        {
            cn.Open();

            SqlCommand cmd = new SqlCommand(command, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "dataset");
            cn.Close();

            return ds;
        }
    }
}