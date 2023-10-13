using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Book
    {
        public int IdBook { get; set; }
        public int IdAuthor { get; set; }
        public int IdStatus { get; set; }
        public string Publisher { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public string Genre { get; set; }
    }
}
