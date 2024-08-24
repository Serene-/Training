using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Library
    {
        public List<Book> books { get; set; }
        public Library()
        {
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            book.Id = books.Count + 1;
            books.Add(book);
        }
        public string ListBooks()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Book book in books)
            {
                string isBorrowed;
                if (book.IsBorrowed) isBorrowed = "borrowed";
                else isBorrowed = "not borrowed";
                sb.AppendLine($"{book.Id}. {book.Title} {book.Author} is {isBorrowed}.");
            }
            return sb.ToString();
        }
        public string SearchByTitle(string title)
        {
            Book searchedBook = books.FirstOrDefault(x => x.Title == title);
            StringBuilder sb = new StringBuilder();
            if (searchedBook != null) sb.Append($"{searchedBook.Id}. {searchedBook.Title} {searchedBook.Author} ");
            else sb.Append("The book is not found");
            return sb.ToString();
        }
        public void BorrowBook(int bookId)
        {
            Book searchedBook = books.FirstOrDefault(x=>x.Id==bookId);
            if (searchedBook != null)
            {
                if (!searchedBook.IsBorrowed)
                {
                    if(searchedBook.Borrow())
                        Console.WriteLine($"Book {searchedBook.Title} is borrowed");
                    else Console.WriteLine($"Book {searchedBook.Title} is already borrowed");
                }
                else
                {
                    Console.WriteLine($"Book {searchedBook.Title} is already borrowed");
                }
            }
            else Console.WriteLine("Book with this Id is not found.");
        }
        public void ReturnBook(int bookId)
        {
            Book searchedBook = books.FirstOrDefault( x => x.Id==bookId);
            if(searchedBook!=null)
            {
                searchedBook.Returned();
                Console.WriteLine($"Book {searchedBook.Title} is returned");
            }
            else Console.WriteLine("Book with this Id is not found.");
        }

    }
}
