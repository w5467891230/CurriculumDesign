using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class UserDAL
    {
        private SqlConnection oleConnection1 = new SqlConnection(LibraryMIS.database.dbConnection.connection);
        public bool AddUserMethod(Model.manager userModel)
        {
            try
            {
                //oleConnection1.Open();
                string sql;
                SqlCommand cmd = new SqlCommand("", oleConnection1);
                if (userModel.RadioManage == true)
                    sql = "insert into manager " +
                        "values ('" + userModel.MName + "','" + userModel.MCode + "',1,0,0)";
                else
                    sql = "insert into manager " +
                        "values ('" + userModel.MName + "','" + userModel.MCode + "',0,1,0)";

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
        public bool FindUserName(string username)
        {
            oleConnection1.Open();
            SqlCommand cmd = new SqlCommand("", oleConnection1);
            string sql = "select * from manager where MName = '" + username + "'";
            cmd.CommandText = sql;
            if (null == cmd.ExecuteScalar())
            {
                return true;
            }
            oleConnection1.Close();
            return false;
        }
    }
}
