using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class ldientyDAL
    {
        private SqlConnection oleConnection1 = new SqlConnection(LibraryMIS.database.dbConnection.connection);
        /*public bool identity(Model.identityinfo identityname)
        {
            try
            {
                oleConnection1.Open();
                string sql = "select * from person where identity='" + identityname + "'";
                SqlCommand cmd = new SqlCommand(sql, oleConnection1);

                return true;
            }
            catch { return false; }
        }*/
        public bool delIdentity(Model.identityinfo identityname)
        {
            try
            {
                string sql = "delete from identityinfo where identityname not in(select distinct identityname from person) and identityname=  " +
                    "'" + identityname.identityname + "'";
                SqlCommand cmd = new SqlCommand(sql, oleConnection1);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                oleConnection1.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool FindIdentity(string a)
        {
            oleConnection1.Open();
            string sql = "select * from person where identityname='" + a + "'";
            SqlCommand cmd = new SqlCommand(sql, oleConnection1);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                return true;
            }
            else
            {
                dr.Close();
                return false;
            }
        }
        public bool FindIdentity1(string ID)
        {
            oleConnection1.Open();
            string sql = "select * from person where identityname='" + ID + "'";
            SqlCommand cmd = new SqlCommand(sql, oleConnection1);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                return true;
            }
            else
            {
                dr.Close();
                return false;
            }
        }
        public bool addIdentity(string ID,string Date,string Num)
        {
            try
            {
                string sql = "select * from identityinfo where identityname='" + ID + "'";
                SqlCommand cmd = new SqlCommand(sql, oleConnection1);
                sql = "insert into identityinfo values ('" + ID + "'," + Date + "," + Num + ")";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                oleConnection1.Close();
                return true;        
            } 
            catch { return false; }
        }
    }
}
