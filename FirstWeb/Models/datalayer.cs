using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;

namespace FirstWeb.Models
{
    public class datalayer
    {
        SqlConnection con=new SqlConnection(ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString);

        public bool insertwithproc(string procname, SqlParameter[] p )
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(procname, con);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddRange(p);
                int i = cmd.ExecuteNonQuery();
                if(i>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
                
            }
            finally
            {
                con.Close();
            }
            
        }
        public DataTable ShowRecords(string procname, SqlParameter[] parm)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(procname, con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddRange(parm);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            sa.Fill(dt);
            return dt;
        }
    }
}