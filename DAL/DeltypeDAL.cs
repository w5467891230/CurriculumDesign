using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DeltypeDAL
    {
        private SqlConnection oleConnection1 = new SqlConnection(LibraryMIS.database.dbConnection.connection);
        public bool DelType(Model.Type type1)//查
        {
            try
            {
                oleConnection1.Open();
                string sql = "select * from book where type='" + type1.Type1 + "'";
                SqlCommand cmd = new SqlCommand(sql, oleConnection1);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    dr.Close();
                    return true;
                }
                else
                {
                    dr.Close();
                    sql = "delete from type where type not in(select distinct type from book) and TID " +
                    "= " + type1.TRemark + "";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    oleConnection1.Close();
                    return false;
                }
            }
            catch { return false; }
        }
        //删除

    }
}
