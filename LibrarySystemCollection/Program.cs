namespace LibrarySystemCollection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Book Management System");
            Console.WriteLine("==============================================================================");

            Console.WriteLine("What would you like to do?\n1. Add a book\n2. Search for a book\n3. Remove a book\n4. Display all books\n5. Exit");

            Console.Write("Please enter your choice: ");
            var userChoice = int.Parse(Console.ReadLine());

            List<Book> books = new List<Book>();

            while (userChoice != 5)
            {
                if (userChoice == 1)
                {
                    Console.Write("Enter the book title: ");
                    var title = Console.ReadLine();

                    Console.Write("Enter the book author: ");
                    var author = Console.ReadLine();
            
                    Console.Write("Enter the book ISBN: ");
                    var isbn = Console.ReadLine();

                    Console.Write("Enter the book availability: ");
                    var availability = Console.ReadLine();

                    Book book = new Book(title, author, isbn, availability);
            
                    books.Add(book);

                    Console.WriteLine("Book added successfully!\n");
                }
                else if (userChoice == 2)
                {
                    Console.Write("Enter the search item: ");
                    var searchItem = Console.ReadLine();

                    foreach (var item in books)
                    {
                        if (searchItem == item.Title)
                        {
                            Console.WriteLine($"Title: {item.Title}\nAuthor: {item.Author}\nISBN: {item.ISBN}\nAvailability: {item.Availability}");
                            Console.WriteLine();
                        }
                    }
                }
                else if (userChoice == 3)
                {
                    Console.Write("Enter the book ISBN: ");
                    var isbn = Console.ReadLine();
                    foreach (var item in books.ToList())
                    {
                        if (isbn == item.ISBN)
                        {
                            books.Remove(item);
                            Console.WriteLine("Book removed successfully!");
                        }
                        else
                        {
                            Console.WriteLine("ISBN not found!");
                        }
                    }
                }
                else if(userChoice == 4)
                {
                    if (books.Count == 0)
                    {
                        Console.WriteLine("No books to display");
                        Console.WriteLine();
                    }
                    else 
                    { 
                        foreach (var item in books)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Title: {item.Title}\nAuthor: {item.Author}\nISBN: {item.ISBN}\nAvailability: {item.Availability}");
                            Console.WriteLine();
                        }
                    }
                }

            Console.WriteLine("What would you like to do?\n1. Add a book\n2. Search for a book\n3. Remove a book\n3. Display all books\n5. Exit");

            Console.Write("Please enter your choice: ");
            userChoice = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Exiting the program. Thank you!");
        }
    }
}