using System.Text.Json;
namespace Task4
{
    public class MyBooksTheyAreAMess
    {
        public void Execution()
        {
            Console.WriteLine("📚 My books they are a mess 📚");

            string jsonText = File.ReadAllText("books.json");

            Book[] books = JsonSerializer.Deserialize<Book[]>(jsonText);
            /*IEnumerable<IGrouping<string, Book>> GroupBooksByAuthorLastName()
            {
                return books.GroupBy(book => GetLastName(book.author));
            }

            string GetLastName(string author)
            {
                string[] parts = author.Split(' ');
                return parts.LastOrDefault();
            }
            */

            IEnumerable<IGrouping<string, Book>> GroupBooksByAuthorFirstName()
            {
                return books.GroupBy(book => GetFirstName(book.author));
            }

            string GetFirstName(string author)
            {
                string[] parts = author.Split(' ');
                return parts.LastOrDefault();
            }

            foreach (Book book in books)
            {
                /*
                if (book.title.Contains("The"))
                {
                    Console.WriteLine($"Title: {book.title}, Publication Year: {book.publication_year}, Author: {book.author}, ISBN: {book.isbn}");
                }
                */

                /*
                if (book.author.Contains("t"))
                {
                    Console.WriteLine($"Title: {book.title}, Publication Year: {book.publication_year}, Author: {book.author}, ISBN: {book.isbn}");
                }
                else if (book.author.Contains("T"))
                {
                    Console.WriteLine($"Title: {book.title}, Publication Year: {book.publication_year}, Author: {book.author}, ISBN: {book.isbn}");
                }
                */

                /*
                if (book.publication_year > 1992)
                {
                    Console.WriteLine($"Title: {book.title}, Publication Year: {book.publication_year}, Author: {book.author}, ISBN: {book.isbn}");
                }
                */

                /*
                if (book.publication_year > 2004)
                {
                    Console.WriteLine($"Title: {book.title}, Publication Year: {book.publication_year}, Author: {book.author}, ISBN: {book.isbn}");
                }
                */

                /*
                string authorName = "Terry Pratchett";
                if (book.author.Contains(authorName))
                {
                    Console.WriteLine($"Author: {book.author}, ISBN: {book.isbn}");
                }
                */

                /*
                Array.Sort(books, CompareByTitleDescending);
                int CompareByTitleDescending(Book x, Book y)
                {
                    return string.Compare(y.title, x.title);
                }
                Console.WriteLine($"Title: {book.title}, Publication Year: {book.publication_year}, Author: {book.author}, ISBN: {book.isbn}");
                */

                /*
                Array.Sort(books, CompareByPublicationYearDescending);
                int CompareByPublicationYearDescending(Book x, Book y)
                {
                    return y.publication_year.CompareTo(x.publication_year);
                }
                Console.WriteLine($"Publication Year: {book.publication_year}, Title: {book.title}, Author: {book.author}, ISBN: {book.isbn}");
                */



            }

            /*var groupedBooksLastName = GroupBooksByAuthorLastName();
            foreach (var group in groupedBooksLastName)
            {
                Console.WriteLine($"Author Last Name: {group.Key}");
                foreach (var book in group)
                {
                    Console.WriteLine($"  Title: {book.title}, Publication Year: {book.publication_year}, Author: {book.author}, ISBN: {book.isbn}");
                }
            }*/

            var groupedBooksFistName = GroupBooksByAuthorFirstName();
            foreach (var group in groupedBooksFistName)
            {
                Console.WriteLine($"Author First Name: {group.Key}");
                foreach (var book in group)
                {
                    Console.WriteLine($"  Title: {book.title}, Publication Year: {book.publication_year}, Author: {book.author}, ISBN: {book.isbn}");
                }
            }
        }





        public class Book
        {
            public string title { get; set; }
            public int publication_year { get; set; }
            public string author { get; set; }
            public string isbn { get; set; }
        }
    }
}


