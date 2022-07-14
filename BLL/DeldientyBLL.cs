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
    public  class DeldientyBLL
    {
    DeldientyDAL deldientyDAL = new DeldientyDAL();
    public string identityinfo(Model.identityinfo identityinfo)
    {
        string result = "OK";
        if (dataGrid1.CurrentRowIndex >= 0 && dataGrid1.DataSource != null && dataGrid1[dataGrid1.CurrentCell] != null)
            {
               
                if(dr.Read())
                {

                }
                else
                {

                }
            }
        else
            {

            }
    }
    }
}
