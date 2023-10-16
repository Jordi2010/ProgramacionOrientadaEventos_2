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
    public class LoanStatusBussines
    {
        LoanStatusData loanStatusData = new LoanStatusData();
        public DataTable GetAllLoanStatus()
        {
            DataTable loanStatusTable = new DataTable();
            loanStatusTable = loanStatusData.GetLoanStatus();
            return loanStatusTable;
        }
    }
}
