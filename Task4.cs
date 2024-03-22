using System.Text.Json;
namespace Task4
{
    public class MyBooksTheyAreAMess
    {
        public Book[] books;
        public void Execution()
        {
            Console.WriteLine("📚 My books they are a mess 📚");
            string jsonText = File.ReadAllText("books.json");
            books = JsonSerializer.Deserialize<Book[]>(jsonText);

            FilteredByTitelStartingWithThe();
            FilteredByContainingT();
            FilteredByPublicationAfter1992();
            FilteredByPublicationBefore2004();
            FilteredByAuthorName();
            SortedByDecendingTitel();
            SortedByDecendingPublicationYear();
            GroupByAuthorLastName();
            GroupByAuthorFirstName();
        }

        private void FilteredByTitelStartingWithThe()
        {
            Console.WriteLine("Filtering books whose titel starts with 'The': ");
            foreach (Book book in books)
            {
                if (book.title.Contains("The"))
                {
                    Console.WriteLine($"Title: {book.title}, Publication Year: {book.publication_year}, Author: {book.author}, ISBN: {book.isbn}");
                }
            }
            Console.WriteLine();
        }

        private void FilteredByContainingT()
        {
            Console.WriteLine("Filtering books whose authors name contains 't & T': ");
            foreach (Book book in books)
            {
                if (book.author.Contains("t"))
                {
                    Console.WriteLine($"Title: {book.title}, Publication Year: {book.publication_year}, Author: {book.author}, ISBN: {book.isbn}");
                }
                else if (book.author.Contains("T"))
                {
                    Console.WriteLine($"Title: {book.title}, Publication Year: {book.publication_year}, Author: {book.author}, ISBN: {book.isbn}");
                }
            }
            Console.WriteLine();
        }

        private void FilteredByPublicationAfter1992()
        {
            Console.WriteLine("Filtering books who have been published after 1992: ");
            foreach (Book book in books)
            {
                if (book.publication_year > 1992)
                {
                    Console.WriteLine($"Title: {book.title}, Publication Year: {book.publication_year}, Author: {book.author}, ISBN: {book.isbn}");
                }
            }
            Console.WriteLine();
        }

        private void FilteredByPublicationBefore2004()
        {
            Console.WriteLine("Filtering books who have been published before 2004: ");
            foreach (Book book in books)
            {
                if (book.publication_year < 2004)
                {
                    Console.WriteLine($"Title: {book.title}, Publication Year: {book.publication_year}, Author: {book.author}, ISBN: {book.isbn}");
                }
            }
            Console.WriteLine();
        }

        private void FilteredByAuthorName()
        {
            string authorName = "Terry Pratchett";
            Console.WriteLine($"Filtering books by author {authorName}:");
            foreach (Book book in books)
            {
                if (book.author.Contains(authorName))
                {
                    Console.WriteLine($"Author: {book.author}, ISBN: {book.isbn}");
                }
            }
            Console.WriteLine();
        }

        private void SortedByDecendingTitel()
        {
            Console.WriteLine("Sorted books decending alphabetically: ");
            Array.Sort(books, (x, y) => string.Compare(y.title, x.title));
            foreach (Book book in books)
            {
                int CompareByTitleDescending(Book x, Book y)
                {
                    return string.Compare(y.title, x.title);
                }
                Console.WriteLine($"Title: {book.title}, Publication Year: {book.publication_year}, Author: {book.author}, ISBN: {book.isbn}");
            }
            Console.WriteLine();
        }
        private void SortedByDecendingPublicationYear()
        {
            Console.WriteLine("Sorted books descending by publication year:");
            Array.Sort(books, CompareByPublicationYearDescending);
            foreach (Book book in books)
            {
                Console.WriteLine($"Publication Year: {book.publication_year}, Title: {book.title}, Author: {book.author}, ISBN: {book.isbn}");
            }
            Console.WriteLine();
        }

        private int CompareByPublicationYearDescending(Book x, Book y)
        {
            return y.publication_year.CompareTo(x.publication_year);
        }
        private void GroupByAuthorLastName()
        {
            Console.WriteLine("Grouping books by author's last name:");
            var groupedBooks = books.GroupBy(book => GetLastName(book.author));
            foreach (var group in groupedBooks)
            {
                Console.WriteLine($"Author Last Name: {group.Key}");
                foreach (var book in group)
                {
                    Console.WriteLine($"    Title: {book.title}, Publication Year: {book.publication_year}, Author: {book.author}, ISBN: {book.isbn}");

                }
            }
            Console.WriteLine();
        }
        private string GetLastName(string author)
        {
            string[] parts = author.Split(' ');
            return parts[parts.Length - 1];
        }
        private void GroupByAuthorFirstName()
        {
            Console.WriteLine("Grouping books by author's first name:");
            var groupedBooks = books.GroupBy(book => GetFirstName(book.author));
            foreach (var group in groupedBooks)
            {
                Console.WriteLine($"Author First Name: {group.Key}");
                foreach (var book in group)
                {
                    Console.WriteLine($"    Title: {book.title}, Publication Year: {book.publication_year}, Author: {book.author}, ISBN: {book.isbn}");
                }
            }
            Console.WriteLine();
        }
        private string GetFirstName(string author)
        {
            string[] parts = author.Split(' ');
            return parts[0];
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