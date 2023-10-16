using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Loan
    {
        public int IdLoan { get; set; }
        public int IdBook { get; set; }
        public string Customer { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnEstimatedDate { get; set; }
        public int IdLoanStatus { get; set; }
    }
}
