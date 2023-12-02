namespace AuthorandBookManagementSystem;
class Program
{
    static void Main(string[] args)
    {

        Author author = new Author("J.K. Rowling", 1965, "British");
        Console.WriteLine($"Author information:\n {author.displayAouthorInfo()}");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Adding book for {author.AuthorName}");

        int i = 0;
        do
        {
            Console.Write("Enter book title : ");
            string title = Console.ReadLine();

            int year;
            Console.Write("Enter book Publish year : ");
            int.TryParse(Console.ReadLine(), out year);

            Console.Write("Enter book genre : ");
            string genre = Console.ReadLine();
            author.addBooks(title,year,genre);
            i++;
        } while (i < 3);
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Displaying Books for {author.AuthorName}");
        Console.WriteLine($"Books Authored by {author.AuthorName}:");
        Console.WriteLine(author.displaybookForAuthor());
        
    }
}

