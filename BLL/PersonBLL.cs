using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
     public class PersonBLL
    {
        PersonDAL personDAL = new PersonDAL();
        public string addPerson(Model.person person)
        {

            string result = "OK";
            if (person.PID == "" || person.PName == "" || person.PCode == "" || person.PN == "")
            {
                result = "请填写完整信息";
            }
            else
            {
                if (personDAL.findIsHaveperson(person.PID,person.PN) == true)
                {
                    result = "图书证号或身份证号重复重复";
                }
                else
                {
                    if (personDAL.addPerson(person) == false)
                    {
                        result = "添加失败";
                    }
                   
                }
            }
            return result;
        }
        public string ModifyPersonMothed(Model.person person)
        {
            string result = "修改信息成功";
            if(person.PName==""||person.PN==""||person.PCode=="")
            {
                result = "请填写完整信息";
            }
            else
            {
                if(personDAL.findIsHaveperson(person.PID,person.PCode)==true)
                {
                    result = "身份证号码发生重复";
              }
                else
                {
                    if(personDAL.ModifyPersonMothed(person)==false)
                    {
                        result = "修改信息失败";
                    }
                }
            }
            return result;
        }

        public string DelPersonMothed(Model.person person)
        {
            string result = "删除成功";
            if(person.PsRow>=0 && person.PsData!=null && person.PsCurrent!=null)
            {
                personDAL.DelPersonMothed(person);
                return result;
            }
            else
            {
                result="删除失败";
                return result;
            }
        }

        
    }
}
