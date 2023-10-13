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
        public string LoanDate { get; set; }
    }
}
