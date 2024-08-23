using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        private int id=0;
        public int Id { get { return id; } private set { Id = id; } }
        public string Title { get; set; }   
        public string Author { get; set; }
        public bool IsBorrowed { get; set; }

        public Book( string title, string author)
        {
            Id++;
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
