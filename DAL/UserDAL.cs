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
        DataSet ds;
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
        public object QueryAll1()
        {
            Model.manager manager = new Model.manager();
            oleConnection1.Open();
            string sql = "select MName as 用户名,MCode as 密码,manage as 权限1,work as 权限2,query as 权限3 from manager";
            SqlDataAdapter adp = new SqlDataAdapter(sql, oleConnection1);
            ds = new DataSet();
            ds.Clear();
            adp.Fill(ds, "user");
            manager.cc = ds.Tables["user"].DefaultView;
            manager.count = ds.Tables["user"].Rows.Count;
            oleConnection1.Close();
            return manager.cc;
        }
        public int QueryAll2()
        {
            Model.manager manager = new Model.manager();
            oleConnection1.Open();
            string sql = "select MName as 用户名,MCode as 密码,manage as 权限1,work as 权限2,query as 权限3 from manager";
            SqlDataAdapter adp = new SqlDataAdapter(sql, oleConnection1);
            ds = new DataSet();
            ds.Clear();
            adp.Fill(ds, "user");
            manager.count = ds.Tables["user"].Rows.Count;
            oleConnection1.Close();
            return manager.count;
        }
        public string QueryAll3(int i)
        {
            oleConnection1.Open();
            string sql = "select MName as 用户名,MCode as 密码,manage as 权限1,work as 权限2,query as 权限3 from manager";
            SqlDataAdapter adp = new SqlDataAdapter(sql, oleConnection1);
            ds = new DataSet();
            ds.Clear();
            adp.Fill(ds, "user");
            string q = ds.Tables[0].Rows[i][0].ToString().Trim();
            oleConnection1.Close();
            return q;
        }
        public bool ModifyUserMethod(Model.manager manager)
        {
            try
            {
                oleConnection1.Open();
                string sql;
                if (manager.RadioManage == true)
                    sql = "update manager set manage=1,work=0,query=0 where MName='" + manager.MName + "'";
                else
                    sql = "update manager set manage=0,work=1,query=0 where MName='" + manager.MName + "'";

                SqlCommand cmd = new SqlCommand(sql, oleConnection1);
                cmd.ExecuteNonQuery();
                oleConnection1.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public string DeleteUserMethod(int q)
        {
            try
            {
                oleConnection1.Open();
                string sql = "select MName as 用户名,MCode as 密码,manage as 权限1,work as 权限2,query as 权限3 from manager";
                SqlDataAdapter adp = new SqlDataAdapter(sql, oleConnection1);
                ds = new DataSet();
                ds.Clear();
                adp.Fill(ds, "user");
                oleConnection1.Close();
                oleConnection1.Open();
                string sql2 = "delete from manager where MName = '" + ds.Tables["user"].Rows[q][0].ToString().Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql2, oleConnection1);
                cmd.ExecuteNonQuery();
                oleConnection1.Close();
                var a = ds.Tables[0].Rows[q][0].ToString().Trim(); 
                return a;
            }
            catch
            {
                return null;
            }

        }
    }
}
