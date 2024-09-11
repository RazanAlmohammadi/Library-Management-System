using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book : Base
    {
        public string Title { get; set; }
        public bool IsBorrowed { get; set; }
        public DateTime? BorrowDate { get; set;}
        public string BorrowedBy { get;set;}
        public Book(string title,DateTime? createdDate = null) : base(createdDate)
        {
            Title = title;
            IsBorrowed = false;
            BorrowDate= null;
            BorrowedBy= null;

        }
        public void Borrow(string Name)
        {
            if (IsBorrowed)
            {
                throw new Exception($"The book '{Title}' is already borrowed.");
            }

            IsBorrowed = true;
            BorrowDate = DateTime.Now;
            BorrowedBy = Name;
            
        }

        public void Return(string Name)
        {
            if (!IsBorrowed)
            {
                throw new Exception($"The book '{Title}' is already borrowed.");
            }

            IsBorrowed = false;
            BorrowDate = DateTime.Now;
            BorrowedBy = Name;
        }
    }

}