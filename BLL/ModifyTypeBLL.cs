using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ModifyTypeBLL
    {
        DAL.ModifiyDAL modifiyDAL = new DAL.ModifiyDAL();
        public string modifytype(Model.Type type1)
        {
            string result = "OK";
            if (type1.Type1 == "" || type1.TID == "")
               
            { result = "请填写完整信息"; }
            else
            {
             string r = type1.TID;
                string s = type1.Type1;
                //检查有没有重复值
                if (modifiyDAL.findType(r,s) == true)
                { result = "类型重复，请重新添加"; }
                //添加
                else
                {
                    if (modifiyDAL.modifytype(type1) == false)
                    {
                        result = "添加失败";
                    }
                }
            }
            return result;

        }
    }
}
