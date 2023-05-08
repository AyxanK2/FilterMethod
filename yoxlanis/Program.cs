
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace yoxlanis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("Varli ata kasib ata",100),
                new Book("Sefirler",300),
                new Book("Dostayevski",400),
            };
            List<Authour> authors = new List<Authour>()
            {
                new Authour("Robert","Kiyosaki"),
                new Authour("Malik","Aliyev"),
                new Authour("Dostayev","Ski"),
            };
               
            Filter filter = new Filter { search = "a",Sort = "LastName"};
            //FilterBook(books, filter);
            FilterAuthors(authors, filter);
           

           
        }
        static void FilterBook(IEnumerable<Book> books,Filter filter)
        {
            if (filter.Max is int && filter.Min is int)
                books = books.Where(x => x.Page >= filter.Min && x.Page <= filter.Max);
            if (!string.IsNullOrEmpty(filter.search))
                books = books.Where(x => x.Name.ToLower().Contains(filter.search.ToLower()));
            switch (filter.AscDesc)
            {
                case "asc":
                    books = books.OrderBy(x => x.GetType().GetProperty(filter.sort).GetValue(x));
                    break;
                case "desc":
                    books = books.OrderByDescending(x => x.GetType().GetProperty(filter.sort).GetValue(x));
                    break;
            }
            foreach (Book item in books)
            {
                Console.WriteLine($" {item.Id} {item.Name} {item.Page}");
            }
        }   
        static void FilterAuthors(IEnumerable<Authour> authors ,Filter filter)
        {
            if (!string.IsNullOrEmpty(filter.search))
            {
                authors = authors.Where(x => x.Name.ToLower().Contains(filter.search.ToLower()) 
                                    || (x.LastName.ToLower().Contains(filter.search.ToLower())));
            }
            switch (filter.AscDesc)
            {
                case "asc":
                    authors = authors.OrderBy(x=>x.GetType().GetProperty(filter.Sort).GetValue(x));
                    break;
                case "desc":
                    authors = authors.OrderByDescending(x => x.GetType().GetProperty(filter.Sort).GetValue(x));
                    break;
            }
            foreach (Authour item in authors)
            {
                Console.WriteLine($"{item.ID} {item.Name} {item.LastName}");
            }
        }
    }
}