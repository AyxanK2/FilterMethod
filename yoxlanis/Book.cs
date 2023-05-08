using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace yoxlanis
{
    internal class Book
    {
        private static int id_ { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Page { get; set; }
        public List<Authour> Books { get; set; } = new List<Authour>();
        public Book(string name,int page)
        {
            id_++;
            Id =id_;
            Name = name;
            Page = page;         
        }
    }
}
