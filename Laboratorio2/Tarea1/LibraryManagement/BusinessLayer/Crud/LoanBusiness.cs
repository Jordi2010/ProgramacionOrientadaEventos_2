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
    public class LoanBusiness
    {
        LoanData loanData = new LoanData();

        public DataTable GetLoan()
        {
            DataTable loanTable = new DataTable();

            loanTable = loanData.GetAllLoan();

            return loanTable;
        }

        public DataTable GetFilterLoan()
        {
            DataTable loanTable = new DataTable();

            loanTable = loanData.GetFilterLoan();

            return loanTable;
        }

        public DataTable GetClientNameByLoanID(Loan loan)
        {
            DataTable loanTable = new DataTable();

            loanTable = loanData.GetClientNameByLoan(loan);

            return loanTable;
        }

        public void AddLoan(Loan loan)
        {
            loanData.AddLoan(loan);
        }

        public void UpdateLoan(Loan loan)
        {
            loanData.UpdateLoan(loan);
        }
        public void UpdateStatusLoan(Loan loan)
        {
            loanData.UpdateStatusLoan(loan);
        }
        public void DeleteLoan(Loan loan)
        {
            loanData.DeleteLoan(loan);
        }
    }
}
