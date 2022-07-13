using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
   public class DeltypeBLL
    {
        DAL.DeltypeDAL deltypedal = new DAL.DeltypeDAL();
        public string deltype2(Model.Type type1,int i,object h,object k)
        {
            string result = "OK";
            if (i >= 0 && h != null && k != null)
            // { result = "删除类型'" + type1.Type1 + "'失败，请先删掉该类型图书"; }
            //else
            //{
            {  string dd = type1.Type1;
                
                if (deltypedal.DelType(type1) == true)
                { result = "删除类型'" + type1.Type1 + "'失败，请先删掉该类型图书"; }
                //添加
                else
                {
                    if (deltypedal.DelType(type1) == false)
                    {
                        result = "删除成功";
                    }
                }
            }
            return result;

        }
    }
}
