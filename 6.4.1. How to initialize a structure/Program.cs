using System;

// Define a structure. 
struct Book
{
    public string author;
    public string title;
    public int copyright;

    public Book(string a, string t, int c)
    {
        author = a;
        title = t;
        copyright = c;
    }
}

class MainClass
{
    public static void Main()
    {
        Book book1 = new Book("author", "Book name", 2005);

        Book book2 = new Book(); // default constructor 
        Book book3;

        Console.WriteLine(book1.title + " by " + book1.author + ", (c) " + book1.copyright);
        Console.WriteLine();

        if (book2.title == null)
            Console.WriteLine("book2.title is null.");

        book2.title = "title";
        book2.author = "author";
        book2.copyright = 1932;
        Console.Write("book2 now contains: ");
        Console.WriteLine(book2.title + " by " + book2.author + ", (c) " + book2.copyright);

        Console.WriteLine();

        // Console.WriteLine(book3.title); // error, must initialize first 
        book3.title = "Red Storm Rising";

        Console.WriteLine(book3.title); // now OK 
    }
}