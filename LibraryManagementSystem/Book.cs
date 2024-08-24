using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }   
        public string Author { get; set; }
        public bool IsBorrowed { get; set; }

        public Book( string title, string author)
        {
            Title = title;
            Author = author;
            IsBorrowed = false;
        }
        public bool Borrow()
        {
            if (IsBorrowed) return false;
            else
            {
                IsBorrowed = true;
            }
            return true;
        }
        public void Returned()
        {

                IsBorrowed = false;
        }
    }
}
