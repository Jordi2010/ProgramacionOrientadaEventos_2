using CommonLayer.Entities;
using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Crud
{
    public class ReturnBusiness
    {

        ReturnData returnData = new ReturnData();

        public DataTable GetReturn()
        {
            DataTable loanTable = new DataTable();

            loanTable = returnData.GetAllReturn();

            return loanTable;
        }
        public void AddReturn(Return Return)
        {
            returnData.AddReturn(Return);
        }

        public void UpdateReturn(Return Return)
        {
            returnData.UpdateReturn(Return);
        }
        public void DeleteReturn(Return Return)
        {
            returnData.DeleteReturn(Return);
        }
    }
}