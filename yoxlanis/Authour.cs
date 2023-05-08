using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yoxlanis
{
    internal class Authour
    {
        private static int id_;
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<Book> Authors { get; set; } = new List<Book>();
        public Authour(string name,string lastname)
        {
            id_++;
            ID = id_;
            Name = name;
            LastName = lastname;
        }

    }
}
