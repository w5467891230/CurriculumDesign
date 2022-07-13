using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DeldientyDAL
    {
        private SqlConnection oleConnection1 = new SqlConnection();
        public bool deldienty(Model identity)
        {
            try
            {
                oleConnection1.Open();
                string sql = "select * from person where identity='" + ds.Tables["identity"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, oleConnection1);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                return true;
                try
                {
                    MessageBox.Show("删除身份'" + ds.Tables["identity"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim() + "'失败，有该身份的读者存在！", "提示");
                    dr.Close();

                }
                catch { }
            }
            catch { return false; }
        }
    }

}
}
