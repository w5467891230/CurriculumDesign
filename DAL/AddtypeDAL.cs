using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AddTypeDAL
    {
        private SqlConnection oleConnection1 = new SqlConnection(LibraryMIS.database.dbConnection.connection);
        public bool findType(string r)//查
        {
            oleConnection1.Open();
            string sql = "select * from type where type='" + r + "'";
            SqlCommand cmd = new SqlCommand(sql, oleConnection1);
            if (null != cmd.ExecuteScalar())
            { return true; }
            oleConnection1.Close();
            return false;

        }
        //添加
        public bool addtype(Model.Type type1)
        {

            try
            {
                oleConnection1.Open();
                string sql = "select * from type where type='" + type1.TID + "'";
                SqlCommand cmd = new SqlCommand(sql, oleConnection1);
                sql = "insert into type (type,tRemark) values ('" + type1.TID + "','" + type1.TRemark + "')";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                oleConnection1.Close();

                return true;
            }
            catch
            { return false; }
        }
    }
}

