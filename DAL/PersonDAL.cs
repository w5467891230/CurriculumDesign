using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
     public class PersonDAL
    {
        private SqlConnection oleConnection1 = new SqlConnection(LibraryMIS.database.dbConnection.connection);
        //private SqlConnection oleConnection1 = null;
        public bool addPerson(Model.person person)
        {
            try
            {
                oleConnection1.Open();
                string sql;
                sql = "insert into person values ('" + person.PID + "'," +
                        "'" + person.PName + "','" + person.PSex + "','" + person.PPhone + "','" + person.PN + "'," +
                        "'" + person.PCode + "'," + person.PMoney + ",'" + person.identityname + "','" + person.PRemark + "',0)";
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
        public bool findIsHaveperson(string PID,string PN)
        {
            oleConnection1.Open();
            string sql1 = "select * from person where PID<>'" + PID + "' and PN='" + PN + "'";
            SqlCommand cmd = new SqlCommand(sql1, oleConnection1);
            if (null != cmd.ExecuteScalar())
            {
                return true;
            }
            oleConnection1.Close();
            return false;
        }
        public bool ModifyPersonMothed(Model.person person)
        {
            try
            {
                oleConnection1.Open();
                string sql1 = "update person set PName='" + person.PName + "',PSex='" + person.PSex + "'," +
                    "PN='" + person.PN + "',PPhone='" + person.PPhone + "',PCode='" + person.PCode + "'," +
                    "PRemark='" + person.PRemark + "',PMoney='" + person.PMoney + "',identityname='" + person.identityname + "' where PID='" + person.PID + "'";
                SqlCommand cmd1 = new SqlCommand(sql1, oleConnection1);
                cmd1.ExecuteNonQuery();
                oleConnection1.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DelPersonMothed(Model.person person)
        {
            try
            {
                oleConnection1.Open();
                string sql = "delete from person where PID='" + person.PsXx + "'";
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
        

       
         
       
    }
}
