using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UserBLL
    {
        UserDAL userDAL=new UserDAL();
        public string AddUserMethod(Model.manager user)
        {
            string result = "添加成功";
            if (user.MName == "" || user.MCode == "" || user.MCodeRe == "" || user.RadioManage == false && user.RadioWork == false)
            {
                result = "请输入完整信息";
            }
            else
            {
                if (user.MCode != user.MCodeRe)
                {
                    result = "两次密码输入不一致";
                }
                else
                {
                    //检查有无重复用户名
                    if (userDAL.FindUserName(user.MName) == false)
                    {
                        result = "用户名已存在";
                    }
                    //添加
                    else
                    {
                        if (userDAL.AddUserMethod(user) == false)
                        {
                            result = "添加失败";
                        }
                    }

                }

            }
            return result;
        }
        public object QueryAll1()
        {
           return userDAL.QueryAll1();
        }
        public int QueryAll2()
        {
            return userDAL.QueryAll2();
        }
        public string QueryAll3(int i)
        {
           return userDAL.QueryAll3(i);
        }
        public string ModifyUserMtehod(Model.manager manager)
        {
            string result = "修改成功";
            if (manager.RadioManage == false && manager.RadioWork == false)
                result = "请选择权限";
            else
            {
                if (userDAL.ModifyUserMethod(manager) == false)
                {
                    result = "修改失败";
                }
            }
            return result;
        }
        public string DeleteUserMethod(int q)
        {
            string result = userDAL.DeleteUserMethod(q);
            if ( result== null)
            {
                return result = "删除失败";
            }
            else
            {
                return result;
            }
        }
    }
}
