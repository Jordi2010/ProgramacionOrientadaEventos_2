using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Return
    {
        public int IdReturn { get; set; }
        public int IdLoan { get; set; }
        public string EstimatedReturnDate { get; set; }
        public string ActualReturnDate { get; set; }
    }
}
