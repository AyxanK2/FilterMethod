using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yoxlanis
{
    internal class Filter
    {
        public int? Max { get; set; }
        public int? Min { get; set; }
        public string search { get; set; }
        public string sort { get; set; } = "Id";
        public string Sort { get; set; } = "ID";
        public string AscDesc { get; set; } = "asc";
        public List<Book> Books { get; set; }
        public List<Authour> authors { get; set; }

    }
}
