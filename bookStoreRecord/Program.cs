namespace bookStoreRecord;
class Program
{
    public record Bookstore(int ID, string Title, string Author, double Price);
       
    public static void Main(string[] args)
    {
        Bookstore book = new(1, "Midnight Library", "Matt Haig", 13.48);
        Console.WriteLine(book);

        Bookstore book2 = new(2, "Project Hail Mary", "Andy Weir", 13.98);
        Console.WriteLine(book2);

        Bookstore book3 = new(3, "How to Stop Time", "Matt Haig", 12.48);
        Console.WriteLine(book3);
        Console.ReadKey();
    }
}

