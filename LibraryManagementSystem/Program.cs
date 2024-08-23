using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementSystem
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Library library = new Library();
            string command = null;
            Console.WriteLine("Library Management System");
            Console.WriteLine("1.Add Book");
            Console.WriteLine("2.List Books");
            Console.WriteLine("3.Search Book by Title");
            Console.WriteLine("4.Borrow Book");
            Console.WriteLine("5.Return Book");
            Console.WriteLine("6.Exit");
            while (command!="6")
            {
                Console.WriteLine("Select an option:");
                command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        {
                            Console.WriteLine("Enter the book title");
                            string title = Console.ReadLine();
                            Console.WriteLine("Enter the book author");
                            string author = Console.ReadLine();
                            Book book = new Book(title, author);
                            library.AddBook(book);
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("All books in library:");
                            Console.WriteLine(library.ListBooks());
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Enter the title of the book you are searching");
                            string title = Console.ReadLine();
                            Console.WriteLine(library.SearchByTitle(title));
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Enter the id of the book you want to borrow");
                            int id = Convert.ToInt32(Console.ReadLine());
                            library.BorrowBook(id);
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("Enter the id of the book you want to return");
                            int id = Convert.ToInt32(Console.ReadLine());
                            library.ReturnBook(id);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong input");
                            break;
                        }
                }

                        

                
            }
        }
    }
}
