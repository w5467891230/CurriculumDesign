using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Tests
{
    [TestClass()]
    public class UserBLLTests
    {
        [TestMethod()]
        public void AddUserMethodTest()
        {
            Model.manager user = new Model.manager();
            user.MName = "55";
            user.MCode = "55";
            user.MCodeRe = "55";
            user.RadioManage = true;
            user.RadioWork = false;

            BLL.UserBLL userBLL = new BLL.UserBLL();
            string result = userBLL.AddUserMethod(user);
            Assert.AreEqual("添加成功", result);
        }
    }
}