using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book : Base
    {
        public string Title { get; set; }
        public Book(string title, DateTime? createdDate = null) : base(createdDate)
        {
            Title = title;
        }
    }
}