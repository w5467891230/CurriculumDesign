using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace LibraryMIS
{ 
    public  class ldientyBLL
    {
        ldientyDAL deldientyDAL = new ldientyDAL();
        ldientyDAL addidentyDAL = new ldientyDAL();

        public string delIdentity(Model.identityinfo identityinfo)
        {
            string result = "删除成功";
            if (deldientyDAL.FindIdentity(identityinfo.identityname) == true)
            {
                result = "删除身份'" + identityinfo.identityname + "'失败，有该身份的读者存在！";
            }
            else
            {
                if (deldientyDAL.delIdentity(identityinfo) == false)
                {
                    result = "删除失败";
                }               
            }
            return result;
        }
        public string addIdentity(string ID, string Date, string Num)
        {
            string result = "增加成功";
            if (addidentyDAL.FindIdentity( ID) == true)
            {
                result = "增加身份'" + ID + "'失败，有该身份的读者存在！";
            }
            else
            {
                if (addidentyDAL.addIdentity(ID, Date, Num) == false)
                {
                    result = "增加失败";
                }
            }
            return result;
        }
    }
}
