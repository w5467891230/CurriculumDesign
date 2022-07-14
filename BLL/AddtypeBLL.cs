using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace BLL
{
   
    public class AddTypeBLL
    {
        DAL.AddTypeDAL addtype = new DAL.AddTypeDAL();
        public string addtype2(Model.Type type12)
        { 
            string result = "OK";
            if (type12.TID == "" || type12.TRemark == "")
            {result="请填写完整信息"; }
            else
            {
                string r = type12.TID;
                //检查有没有重复值
                if (addtype.findType(r) == true)
                { result = "类型重复，请重新添加"; }
                //添加
                else
                {
                    if (addtype.addtype(type12) == false)
                    {
                        result = "添加失败";
                    }
                }
            }
            return result;

        }
    }
    }

